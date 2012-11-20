Imports System.Threading
Imports System.ComponentModel

Public Class frmMain
    Dim debugOption As Boolean = False
    Dim debugOutput As String

    Private Delegate Sub DoStuffDelegate(ByVal MsgString As String)

    Private Sub CompleteEventHandler(ByVal sender As Object, ByVal e As EventArgs)
        Me.BeginInvoke(New DoStuffDelegate(AddressOf DoStuff), "meh")
    End Sub

    Private Sub DoStuff(ByVal MsgString As String)
        frmSplash.ShowDialog()
    End Sub
    
    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.cont = Me.chkBackupSDDLcont.Checked

        My.Settings.Save()
        debugOutput = Nothing
        debugOption = Nothing

    End Sub

    Friend Sub ProcessExited(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim myProcess As Process = DirectCast(sender, Process)

        If Not debugOutput = "" Then
            MsgBox(debugOutput)      
        End If

        processThread.Close()
        
        myProcess.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Set properties and stuff

        My.Settings.Reload()

        Me.Text = "replaceSID Beta v" & My.Application.Info.Version.ToString

        Me.tabBackupSDDL.Text = "Backup ACL"
        Me.tabReplaceSID.Text = "Replace SID"
        Me.tabRestoreSDDL.Text = "Restore ACL"



        Me.lblBrowseSSDL.Text = "Open SSDL file to replace with SIDMap csv file"
        Me.lblBrowseSIDmap.Text = "Open SIDMap csv file"
        Me.lblSaveOutput.Text = "Save replaced SSDL file with SIDMap csv file"

        Me.cmdReplaceSIDRun.Text = "Run replace..."
        Me.cmdReplaceSIDRun.Enabled = False

        Me.chkBackupSDDLcont.Checked = My.Settings.cont
        Me.chkBackupSDDLobj.Checked = My.Settings.obj
        Me.chkBackupSDDLcont_obj.Checked = My.Settings.cont_obj
        Me.chkBackupSDDLdacl.Checked = My.Settings.dacl
        Me.chkBackupSDDLsacl.Checked = My.Settings.sacl
        Me.chkBackupSDDLOwner.Checked = My.Settings.owner
        Me.chkBackupSDDLPrimaryGroup.Checked = My.Settings.primaryGroup
        Me.chkBackupSDDLi.Checked = My.Settings.listInherited
        Me.chkBackupSDDLoo.Checked = My.Settings.orphanedOnly

        Me.cmdBrowseSIDmap.Text = "Browse..."
        Me.cmdBrowseSSDL.Text = "Browse..."
        Me.cmdSaveOutput.Text = "Browse..."

        Me.lblBackupSDDLWhat.Text = "What:"
        Me.lblBackupSDDLon.Text = "SetACL -on [Folder] -ot file -actn list"
        Me.lblSaveSDDLBackup.Text = "-bckp [Filename] -rec [Recursion] -silent"
        Me.lblBackupSDDLCL.Text = "-actn list [-lst ""f:Format;w:What;i:ListInherited;s:DisplaySID;oo:OrphanedOnly""]"
        Me.cmdBackupSDDLbckp.Text = "Browse..."
        Me.cmdBackupSDDLRun.Text = "Backup ACL..."
        Me.cmdBackupSDDLRun.Enabled = False

        Me.cmdRestoreSDDLRun.Text = "Restore ACL..."
        Me.lblRestoreSDDLon.Text = "SetACL -on [Folder] -ot file -actn restore"
        Me.lblRestoreSDDLbkcp.Text = "-bckp [Filename]"
        Me.cmdRestoreSDDLRun.Enabled = False

        Me.lblSettingsSetACLLocation.Text = "SetACL file locatoin"
        Me.cmdSettingsSetACLLocation.Text = "Browse..."
        Me.txtSettingsSetACLLocation.Text = My.Settings.SetACLLocation

        If debugOption Then
            Me.txtBackupSDDLbckp.Text = "C:\Users\admin.itvalue\Documents\backup.sddl.txt"
            Me.txtBackupSDDLon.Text = "C:\Python32"
            Me.cmdBackupSDDLRun.Enabled = True

            Me.txtSSDLFile.Text = "C:\Users\admin.itvalue\Documents\backup.sddl.txt"
            Me.txtBrowseSIDmap.Text = "C:\Users\admin.itvalue\Documents\SIDMap.csv"
            Me.txtSaveOutput.Text = "C:\Users\admin.itvalue\Documents\restore.sddl.txt"
            Me.cmdReplaceSIDRun.Enabled = True

            Me.txtRestoreSDDLbkcp.Text = "C:\Users\admin.itvalue\Documents\restore.sddl.txt"
            Me.txtRestoreSDDLon.Text = "C:\Python32"
            Me.cmdRestoreSDDLRun.Enabled = True
        End If

    End Sub

    ' *****************************************************************************************************************************************
    ' *****************************************************************************************************************************************

#Region "Command Buttons"
    Private Sub cmdRun_Click(sender As System.Object, e As System.EventArgs) Handles cmdReplaceSIDRun.Click

        bgwLoadSIDMap.RunWorkerAsync()

    End Sub

    Private Sub cmdBrowseSSDL_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowseSSDL.Click

        ofdSSDLFile.Title = "Open SSDL file to replace with SIDMap csv file"
        ofdSSDLFile.FileName = ""
        ofdSSDLFile.Filter = "Text (*.txt) |*.txt|All Files|*.*"

        If ofdSSDLFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.txtSSDLFile.Text = ofdSSDLFile.FileName
        End If
        Call enableRunreplace()
    End Sub

    Private Sub cmdBrowseSIDmap_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowseSIDmap.Click

        ofdSSDLFile.Title = "Open SIDMap csv file"
        ofdSSDLFile.FileName = ""
        ofdSSDLFile.Filter = "csv (*.csv)|*.csv|All Files|*.*"

        If ofdSSDLFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.txtBrowseSIDmap.Text = ofdSSDLFile.FileName
        End If
        Call enableRunreplace()
    End Sub

    Private Sub cmdSaveOutput_Click(sender As System.Object, e As System.EventArgs) Handles cmdSaveOutput.Click
        sfdSSDLFile.Title = "Save replaced SSDL file with SIDMap csv file"
        sfdSSDLFile.FileName = "restore.sddl.txt"
        sfdSSDLFile.Filter = "Text (*.txt) |*.txt"

        If sfdSSDLFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.txtSaveOutput.Text = sfdSSDLFile.FileName
        End If
        Call enableRunreplace()
    End Sub

    Private Sub cmdSaveSDDLBackup_Click(sender As System.Object, e As System.EventArgs) Handles cmdBackupSDDLbckp.Click
        sfdSSDLFile.Title = "Save SSDL backup file"
        sfdSSDLFile.FileName = "backup.sddl.txt"
        sfdSSDLFile.Filter = "Text (*.txt) |*.txt"

        If sfdSSDLFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.txtBackupSDDLbckp.Text = sfdSSDLFile.FileName
        End If

        Call enableRunBackupSDDL()
    End Sub

    Private Sub cmdRunBackupSDDL_Click(sender As System.Object, e As System.EventArgs) Handles cmdBackupSDDLRun.Click

        Call setACLLocationNotSet()
        processThread.Show("")
        debugOutput = runSetACLBackupACL()

    End Sub

    Private Sub cmdRestoreSDDLRun_Click(sender As System.Object, e As System.EventArgs) Handles cmdRestoreSDDLRun.Click

        Call setACLLocationNotSet()
        processThread.Show("")
        debugOutput = runSetACLRestoreACL()

    End Sub


    Private Sub cmdRestoreSDDLbkcp_Click(sender As System.Object, e As System.EventArgs) Handles cmdRestoreSDDLbkcp.Click
        ofdSSDLFile.Title = "Open SSDL file to restore"
        ofdSSDLFile.FileName = "restore.sddl.txt"
        ofdSSDLFile.Filter = "Text (*.txt) |*.txt|All Files|*.*"

        If ofdSSDLFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.txtRestoreSDDLbkcp.Text = ofdSSDLFile.FileName
        End If
        Call enableRestoreSDDLRun()
    End Sub

    Private Sub cmdSettingsSetACLLocation_Click(sender As System.Object, e As System.EventArgs) Handles cmdSettingsSetACLLocation.Click
        Me.ofdSSDLFile.Title = "Select SetACL"
        Me.ofdSSDLFile.FileName = "SetACL.exe"
        Me.ofdSSDLFile.Filter = "SetACL (*.exe) |*.exe"

        If ofdSSDLFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.txtSettingsSetACLLocation.Text = Me.ofdSSDLFile.FileName
            My.Settings.SetACLLocation = Me.txtSettingsSetACLLocation.Text
            My.Settings.Save()
        End If
    End Sub

    Sub selectSetACL()
        Me.ofdSSDLFile.Title = "Select SetACL"
        Me.ofdSSDLFile.FileName = "SetACL.exe"
        Me.ofdSSDLFile.Filter = "SetACL (*.exe) |*.exe"

        If ofdSSDLFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.txtSettingsSetACLLocation.Text = Me.ofdSSDLFile.FileName
            My.Settings.SetACLLocation = Me.txtSettingsSetACLLocation.Text
            My.Settings.Save()
        End If
    End Sub

#End Region

    ' *****************************************************************************************************************************************
    ' *****************************************************************************************************************************************

#Region "Checkbox"
    Private Sub chkBackupSDDLcont_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkBackupSDDLcont.CheckedChanged
        If Me.chkBackupSDDLcont.Checked Then
            Me.chkBackupSDDLcont_obj.Checked = False
            Me.chkBackupSDDLobj.Checked = False
        End If
    End Sub

    Private Sub chkBackupSDDLobj_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkBackupSDDLobj.CheckedChanged
        If Me.chkBackupSDDLobj.Checked Then
            Me.chkBackupSDDLcont_obj.Checked = False
            Me.chkBackupSDDLcont.Checked = False
        End If
    End Sub

    Private Sub chkBackupSDDLcont_obj_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkBackupSDDLcont_obj.CheckedChanged
        If Me.chkBackupSDDLcont_obj.Checked Then
            Me.chkBackupSDDLobj.Checked = False
            Me.chkBackupSDDLcont.Checked = False
        End If
    End Sub

#End Region

    ' *****************************************************************************************************************************************
    ' *****************************************************************************************************************************************

    Private Sub bgwLoadSIDMap_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwLoadSIDMap.DoWork
        Call loadSIDMap(Me.txtBrowseSIDmap.Text)
    End Sub

    Private Sub bgwReplaceSID_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwReplaceSID.DoWork
        Call processThread.Show("")
        Call importSDDLfile(Me.txtSSDLFile.Text, Me.txtSaveOutput.Text)
    End Sub

    Private Sub bgwLoadSIDMap_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwLoadSIDMap.RunWorkerCompleted
        bgwReplaceSID.RunWorkerAsync()
    End Sub

    Private Sub bgwReplaceSID_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReplaceSID.RunWorkerCompleted
        'MsgBox("Ready", MsgBoxStyle.Information, "Message")
        Call processThread.Close()
    End Sub
End Class
