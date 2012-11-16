Imports System.Text.RegularExpressions
Imports System.Collections.Generic
Imports System.IO

Module modMain
    Public dic_sidmap As New Dictionary(Of String, String)
    Public _exportFile As StreamWriter

    Function splitSDDL(s_ssdl As String) As String
        ' Call Regex.Matches method.
        Dim matches As MatchCollection = Regex.Matches(s_ssdl, "S-1-5-21-[0-9]{10}-[0-9]{10}-[0-9\-]{0,}")

        If matches.Count = 0 Then
            s_ssdl = s_ssdl
        End If
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
                Dim a_line As Array
                Dim _lcount As Double = 0
                Dim s_line As String
                ' Read first line.
                line = r.ReadLine

                ' Loop over each line in file, While list is Not Nothing.
                While Not line Is Nothing
                    _lcount += 1
                    If Not line = "" Then
                        ' Display to console.
                        a_line = line.Split(",")
                        'Console.WriteLine(a_line(2))
                        'Console.WriteLine(splitSDDL(a_line(2)))
                        s_line = a_line(0) + "," + a_line(1) + "," + splitSDDL(a_line(2))
                        _exportFile.WriteLine(s_line)

                        'frmMain.lblCountLines.Text = _lcount
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

    Sub enableRunreplace()
        Dim i_enableRun As Integer = 0
        Dim b_isUri As Boolean

        If File.Exists(frmMain.txtSSDLFile.Text) Then
            i_enableRun += 1
        End If
        If File.Exists(frmMain.txtBrowseSIDmap.Text) Then
            i_enableRun += 1
        End If

        If Not frmMain.txtSaveOutput.Text = "" Then
            b_isUri = New Uri(frmMain.txtSaveOutput.Text).IsFile
        End If

        If b_isUri Then
            If Directory.Exists(Path.GetDirectoryName(frmMain.txtSaveOutput.Text)) Then
                i_enableRun += 1
            End If
        End If

        If i_enableRun = 3 Then
            frmMain.cmdRun.Enabled = True
        End If
    End Sub

    Function runSetACLBackupACL() As String
        'setacl -on d:\data -ot file -actn list -lst "f:sddl;w:d,s,o,g;i:y;oo:y" -rec cont -bckp d:\backup.txt -silent 
        Dim process As New Process()
        Dim FileName As String = "netstat"
        Dim Arguments As String = "-aon"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()

        Return output
    End Function

End Module
