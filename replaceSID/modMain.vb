Imports System.Text.RegularExpressions
Imports System.Collections.Generic
Imports System.IO

Module modMain
    Public Delegate Sub _setState(ByVal b_state As Boolean)
    Public dic_sidmap As New Dictionary(Of String, String)
    Public _exportFile As StreamWriter

    
    Function splitSDDL(s_ssdl As String) As String
        ' Call Regex.Matches method.
        ' (S-1-5-21)(\-\d{8,10}){3}(\-\d{3,}){1}
        ' (S-1-5-21-)\d{8,10}-\d{8,10}-\d{8,10}-\d{3,8}
        ' S-1-5-21-[0-9]{10}-[0-9]{10}-[0-9\-]{0,}
        Dim matches As MatchCollection = Regex.Matches(s_ssdl, "((S-1-5-21)(\-\d{8,10}){3}(\-\d{3,}){1})")

        s_ssdl = s_ssdl

        ' Loop over matches.
        For Each m As Match In matches
            ' Loop over captures.
            For Each c As Capture In m.Captures
                ' Display.
                ' Console.WriteLine("Index={0}, Value={1}", c.Index, c.Value)
                If dic_sidmap.ContainsKey(c.Value) Then
                    '  s_foundsid = dic_sidmap(c.Value).ToString
                    s_ssdl = s_ssdl.Replace(c.Value, dic_sidmap(c.Value).ToString)
                Else
                    s_ssdl = s_ssdl
                End If
            Next
        Next
        Return s_ssdl
    End Function

    Sub importSDDLfile(s_ssdlFile As String, s_ssdlExportFile As String)
        ' Open file.txt with the Using statement.
        Try
            _exportFile = New StreamWriter(s_ssdlExportFile)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Try
            Using r As StreamReader = New StreamReader(s_ssdlFile)

                ' Store contents in this String.
                Dim line As String
                'Dim a_line As Array
                Dim _lcount As Double = 0
                Dim s_line As String
                ' Read first line.
                line = r.ReadLine

                ' Loop over each line in file, While list is Not Nothing.
                While Not line Is Nothing
                    _lcount += 1
                    If Not line = "" Then                      
                        s_line = splitSDDL(line)
                        _exportFile.WriteLine(s_line)
                    End If

                    ' Read in the next line.
                    line = r.ReadLine

                    'Exit is the line is empty
                    If line Is "" Then
                        line = Nothing
                    End If

                End While
            End Using
            _exportFile.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub loadSIDMap(s_sidMapFile As String)
        dic_sidmap.Clear()
        Try
            Using r As StreamReader = New StreamReader(s_sidMapFile)
                ' Store contents in this String.
                Dim line As String
                Dim a_line As Array

                ' Read first line.
                line = r.ReadLine

                ' Loop over each line in file, While list is Not Nothing.
                While Not line Is Nothing
                    If Not line = "" Then
                        ' Split the CSV file items and add it to the Dictionary
                        a_line = line.Split(",")
                        dic_sidmap.Add(a_line(0).ToString, a_line(1).ToString)
                    End If

                    ' Read in the next line.
                    line = r.ReadLine
                    ' Exit if line is emprty
                    If line = "" Then
                        line = Nothing
                    End If
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Function enableReplaceSSDLRun() As Boolean
        Dim i_enableRun As Integer = 0
        ' Dim b_isUri As Boolean
        Try
            If File.Exists(frmMain.txtSSDLFile.Text) Then
                i_enableRun += 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            If File.Exists(frmMain.txtBrowseSIDmap.Text) Then
                i_enableRun += 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            If Not frmMain.txtSaveOutput.Text.Length = 0 Then
                If Directory.Exists(Path.GetDirectoryName(frmMain.txtSaveOutput.Text)) Then
                    i_enableRun += 1
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If i_enableRun = 3 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function enableBackupSDDLRun() As Boolean
        Dim i_enableRun As Integer = 0

        If Not frmMain.txtBackupSDDLbckp.Text = "" Then
            i_enableRun += 1
        End If

        Try
            If Not frmMain.txtBackupSDDLon.Text.Length = 0 Then
                If Directory.Exists(frmMain.txtBackupSDDLon.Text) Then
                    i_enableRun += 1
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If i_enableRun = 2 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function enableRestoreSDDLRun() As Boolean
        Dim i_enableRun As Integer = 0

        Try
            If Not frmMain.txtRestoreSDDLon.Text = "" Then
                If Directory.Exists(frmMain.txtRestoreSDDLon.Text) Then
                    i_enableRun += 1
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If Not frmMain.txtRestoreSDDLbkcp.Text.Length = 0 Then
            i_enableRun += 1
        End If


        If i_enableRun = 2 Then
            Return True
        Else
            Return False
        End If
    End Function


    Function runSetACLBackupACL() As String
        'setacl -on d:\data -ot file -actn list -lst "f:sddl;w:d,s,o,g;i:y;oo:y" -rec cont -bckp d:\backup.txt -silent 
        Dim process As New Process()
        Dim s_command As String = frmMain.txtSettingsSetACLLocation.Text
        Dim s_arguments As String = makeSetACLBackupCommand()
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = s_command
        process.StartInfo.Arguments = s_arguments

        ' Raise Event on Exit
        process.EnableRaisingEvents = True

        ' Add an event handler.
        AddHandler process.Exited, AddressOf frmMain.ProcessExited

        'b Call setStateCMDRunBackupSDDL(False)
        ' start the Process
        process.Start()
        'frmMain.cmdRunBackupSDDL.Enabled = False

        Dim output As String = process.StandardOutput.ReadToEnd()

        Return output
    End Function

    Function runSetACLRestoreACL() As String
        'setacl -on d:\data -ot file -actn list -lst "f:sddl;w:d,s,o,g;i:y;oo:y" -rec cont -bckp d:\backup.txt -silent 
        Dim process As New Process()
        Dim s_command As String = frmMain.txtSettingsSetACLLocation.Text
        Dim s_arguments As String = makeSetACLRestoreCommand(frmMain.txtRestoreSDDLon.Text, frmMain.txtRestoreSDDLbkcp.Text)
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = s_command
        process.StartInfo.Arguments = s_arguments

        ' Raise Event on Exit
        process.EnableRaisingEvents = True

        ' Add an event handler.
        AddHandler process.Exited, AddressOf frmMain.ProcessExited

        'b Call setStateCMDRunBackupSDDL(False)
        ' start the Process
        process.Start()
        'frmMain.cmdRunBackupSDDL.Enabled = False

        Dim output As String = process.StandardOutput.ReadToEnd

        Return output
    End Function

    Sub setACLLocationNotSet()
        If frmMain.txtSettingsSetACLLocation.Text Is "" Then
            Call frmMain.selectSetACL()
        End If
    End Sub

    Function makeSetACLBackupCommand() As String
        Dim s_arguments As String = "-on """ + frmMain.txtBackupSDDLon.Text + """ -ot file -actn list -lst ""f:sddl;"
        Dim s_what As String = ""
        Dim s_listInherited As String = ""
        Dim s_orphanedOnly As String = ""
        Dim s_recursion As String = ""

        If frmMain.chkBackupSDDLdacl.Checked Then
            s_what &= "d,"
        End If
        If frmMain.chkBackupSDDLsacl.Checked Then
            s_what &= "s,"
        End If
        If frmMain.chkBackupSDDLOwner.Checked Then
            s_what &= "o,"
        End If
        If frmMain.chkBackupSDDLPrimaryGroup.Checked Then
            s_what &= "g"
        End If

        If s_what.EndsWith(",") Then
            s_what = s_what.Substring(0, (s_what.Length - 1))
        End If

        If s_what.Length >= 1 Then
            s_what = "w:" + s_what + ";"
        End If

        If frmMain.chkBackupSDDLi.Checked Then
            s_listInherited &= "i:y;"
        End If

        If frmMain.chkBackupSDDLoo.Checked Then
            s_orphanedOnly &= "oo:y"
        End If

        If frmMain.chkBackupSDDLcont.Checked Then
            s_recursion = " -rec cont"
        End If

        If frmMain.chkBackupSDDLobj.Checked Then
            s_recursion = " -rec obj"
        End If

        If frmMain.chkBackupSDDLcont_obj.Checked Then
            s_recursion = " -rec cont_obj"
        End If

        s_arguments = s_arguments + s_what + s_listInherited + s_orphanedOnly

        If s_arguments.EndsWith(";") Then
            s_arguments = s_arguments.Substring(0, (s_arguments.Length - 1))

        End If

        s_arguments = s_arguments + """" + s_recursion + " -bckp """ + frmMain.txtBackupSDDLbckp.Text + """ -silent"

        Return s_arguments

        s_arguments = Nothing
    End Function

    ' "-on """ + frmMain.txtRestoreSDDLon.Text + """ -ot file -actn restore -bckp """ + frmMain.txtRestoreSDDLbkcp.Text + """ -silent"
    Function makeSetACLRestoreCommand(s_RestoreSDDLon As String, s_txtRestoreSDDLbkcp As String) As String
        Dim s_arguments As String = "-on """ + s_RestoreSDDLon + """ -ot file -actn restore -bckp """ + s_txtRestoreSDDLbkcp + """{0}{1}{2}"
        Dim s_ignoreErr As String = ""
        Dim s_log As String = ""
        Dim s_silent As String = ""

        If frmMain.chkRestoreSDDLIgnoreerr.Checked Then
            s_ignoreErr &= " -ignoreerr"
        End If
        If frmMain.chkRestoreSDDLog.Checked Then
            s_log &= " -log """ + createFilename(s_txtRestoreSDDLbkcp) + """"
        End If
        If frmMain.chkRestoreSDDSilent.Checked Then
            s_silent &= " -silent"
        End If

        s_arguments = String.Format(s_arguments, s_ignoreErr, s_log, s_silent)

        Return s_arguments

    End Function

    Function createFilename(ByVal _filename As String) As String
        Dim count As Integer = 0
        Dim s_extension As String = ".log"

        ' s_extension = Path.GetExtension(_filename)
        _filename = Path.GetFileNameWithoutExtension(_filename)

        While True
            _filename = _filename + "." + count.ToString("0000") + "." + s_extension
            If Not IO.File.Exists(_filename) Then
                Return _filename
                Exit While
            End If
            count += 1
        End While

        Return ""
    End Function

    Public Sub setStateCMDRunBackupSDDL(ByVal b_state As Boolean)
        ' InvokeRequired required compares the thread ID of the'
        ' calling thread to the thread ID of the creating thread.'
        ' If these threads are different, it returns true.'       
        If frmMain.cmdBackupSDDLRun.InvokeRequired Then
            frmMain.Invoke(New _setState(AddressOf setStateCMDRunBackupSDDL), b_state)
        Else
            frmMain.cmdBackupSDDLRun.Enabled = b_state
        End If
    End Sub
    'Public Delegate Sub runToggleInvoker(ByVal value As Integer)
    'Public Sub runToggle(ByVal value As Integer)
    '    If Sandbox.Label1.InvokeRequired = True Then
    '        Sandbox.Label1.Invoke(New runToggleInvoker(AddressOf runToggle), value)
    '    Else
    '        Sandbox.Label1.Text = value
    '    End If
    'End Sub
End Module
