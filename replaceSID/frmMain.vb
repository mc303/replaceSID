Public Class frmMain
    Dim debugOption As Boolean = True

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Set properties and stuff
        If debugOption Then
            Me.txtSSDLFile.Text = "C:\Users\admin.itvalue\Documents\backup.1.txt"
            Me.txtBrowseSIDmap.Text = "C:\Users\admin.itvalue\Documents\SIDMap.csv"
            Me.txtSaveOutput.Text = "C:\Users\admin.itvalue\Documents\sddlExport.txt"
        End If

        Me.Text = "replaceSID Beta v" & My.Application.Info.Version.ToString

        tabBackupSDDL.Text = "Backup ACL"
        tabReplaceSID.Text = "Replace SID"
        tabRestoreSDDL.Text = "Restore ACL"

        cmdRunBackupSDDL.Enabled = False
        cmdRunBackupSDDL.Text = "Backup ACL..."

        lblBrowseSSDL.Text = "Open SSDL file to replace with SIDMap csv file"
        lblBrowseSIDmap.Text = "Open SIDMap csv file"
        lblSaveOutput.Text = "Save replaced SSDL file with SIDMap csv file"

        cmdRun.Text = "Run replace..."
        cmdRun.Enabled = False

        cmdBrowseSIDmap.Text = "Browse..."
        cmdBrowseSSDL.Text = "Browse..."
        cmdSaveOutput.Text = "Browse..."

        sfdSSDLFile.Title = "Save replaced SSDL file with SIDMap csv file"
        sfdSSDLFile.FileName = "sddlExport.txt"
        sfdSSDLFile.Filter = "Text (*.txt) |*.txt"

        lblBackupSDDLWhat.Text = "What:"
        lblSaveSDDLBackup.Text = "[-bckp Filename]"
        lblBackupSDDLCL.Text = "-actn list [-lst ""f:Format;w:What;i:ListInherited;s:DisplaySID;oo:OrphanedOnly""]"

    End Sub

    ' *****************************************************************************************************************************************
    ' *****************************************************************************************************************************************

#Region "Command Buttons"
    Private Sub cmdRun_Click(sender As System.Object, e As System.EventArgs) Handles cmdRun.Click
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
        If sfdSSDLFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.txtSaveOutput.Text = sfdSSDLFile.FileName
        End If
        Call enableRunreplace()
    End Sub
#End Region

    ' *****************************************************************************************************************************************
    ' *****************************************************************************************************************************************

    Private Sub bgwLoadSIDMap_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwLoadSIDMap.DoWork
        Call loadSIDMap(Me.txtBrowseSIDmap.Text)
    End Sub

    Private Sub bgwReplaceSID_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwReplaceSID.DoWork
        Call importSDDLfile(Me.txtSSDLFile.Text, Me.txtSaveOutput.Text)
    End Sub

    Private Sub bgwLoadSIDMap_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwLoadSIDMap.RunWorkerCompleted
        bgwReplaceSID.RunWorkerAsync()
    End Sub

    Private Sub bgwReplaceSID_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwReplaceSID.RunWorkerCompleted
        MsgBox("Ready", MsgBoxStyle.Information, "Message")
    End Sub
End Class
