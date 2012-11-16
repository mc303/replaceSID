<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ofdSSDLFile = New System.Windows.Forms.OpenFileDialog()
        Me.bgwReplaceSID = New System.ComponentModel.BackgroundWorker()
        Me.bgwLoadSIDMap = New System.ComponentModel.BackgroundWorker()
        Me.sfdSSDLFile = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBackupSDDL = New System.Windows.Forms.TabPage()
        Me.lblBackupSDDLCL = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.lblBackupSDDLs = New System.Windows.Forms.Label()
        Me.chkBackupSDDLsacl = New System.Windows.Forms.CheckBox()
        Me.chkBackupSDDLOwner = New System.Windows.Forms.CheckBox()
        Me.chkBackupSDDLPrimaryGroup = New System.Windows.Forms.CheckBox()
        Me.chkBackupSDDLdacl = New System.Windows.Forms.CheckBox()
        Me.lblBackupSDDLWhat = New System.Windows.Forms.Label()
        Me.cmdRunBackupSDDL = New System.Windows.Forms.Button()
        Me.txtSaveSDDLBackup = New System.Windows.Forms.TextBox()
        Me.lblSaveSDDLBackup = New System.Windows.Forms.Label()
        Me.cmdSaveSDDLBackup = New System.Windows.Forms.Button()
        Me.tabReplaceSID = New System.Windows.Forms.TabPage()
        Me.lblSaveOutput = New System.Windows.Forms.Label()
        Me.txtSSDLFile = New System.Windows.Forms.TextBox()
        Me.lblBrowseSIDmap = New System.Windows.Forms.Label()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.lblBrowseSSDL = New System.Windows.Forms.Label()
        Me.cmdBrowseSSDL = New System.Windows.Forms.Button()
        Me.cmdSaveOutput = New System.Windows.Forms.Button()
        Me.txtBrowseSIDmap = New System.Windows.Forms.TextBox()
        Me.txtSaveOutput = New System.Windows.Forms.TextBox()
        Me.cmdBrowseSIDmap = New System.Windows.Forms.Button()
        Me.tabRestoreSDDL = New System.Windows.Forms.TabPage()
        Me.bgwBackupSDDL = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1.SuspendLayout()
        Me.tabBackupSDDL.SuspendLayout()
        Me.tabReplaceSID.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofdSSDLFile
        '
        Me.ofdSSDLFile.FileName = "OpenFileDialog1"
        '
        'bgwReplaceSID
        '
        '
        'bgwLoadSIDMap
        '
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tabBackupSDDL)
        Me.TabControl1.Controls.Add(Me.tabReplaceSID)
        Me.TabControl1.Controls.Add(Me.tabRestoreSDDL)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(522, 256)
        Me.TabControl1.TabIndex = 11
        '
        'tabBackupSDDL
        '
        Me.tabBackupSDDL.Controls.Add(Me.lblBackupSDDLCL)
        Me.tabBackupSDDL.Controls.Add(Me.CheckBox1)
        Me.tabBackupSDDL.Controls.Add(Me.Label1)
        Me.tabBackupSDDL.Controls.Add(Me.CheckBox2)
        Me.tabBackupSDDL.Controls.Add(Me.lblBackupSDDLs)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLsacl)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLOwner)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLPrimaryGroup)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLdacl)
        Me.tabBackupSDDL.Controls.Add(Me.lblBackupSDDLWhat)
        Me.tabBackupSDDL.Controls.Add(Me.cmdRunBackupSDDL)
        Me.tabBackupSDDL.Controls.Add(Me.txtSaveSDDLBackup)
        Me.tabBackupSDDL.Controls.Add(Me.lblSaveSDDLBackup)
        Me.tabBackupSDDL.Controls.Add(Me.cmdSaveSDDLBackup)
        Me.tabBackupSDDL.Location = New System.Drawing.Point(4, 25)
        Me.tabBackupSDDL.Name = "tabBackupSDDL"
        Me.tabBackupSDDL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBackupSDDL.Size = New System.Drawing.Size(514, 227)
        Me.tabBackupSDDL.TabIndex = 1
        Me.tabBackupSDDL.Text = "Backup SDDL"
        Me.tabBackupSDDL.UseVisualStyleBackColor = True
        '
        'lblBackupSDDLCL
        '
        Me.lblBackupSDDLCL.AutoSize = True
        Me.lblBackupSDDLCL.Location = New System.Drawing.Point(3, 54)
        Me.lblBackupSDDLCL.Name = "lblBackupSDDLCL"
        Me.lblBackupSDDLCL.Size = New System.Drawing.Size(473, 13)
        Me.lblBackupSDDLCL.TabIndex = 43
        Me.lblBackupSDDLCL.Text = "-actn list [-lst ""f:Format;w:What;i:ListInherited;s:DisplaySID;oo:OrphanedOnly""] " & _
    ""
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(156, 133)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox1.TabIndex = 42
        Me.CheckBox1.Text = "Yes"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "OrphanedOnly:"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(156, 90)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox2.TabIndex = 40
        Me.CheckBox2.Text = "Yes"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'lblBackupSDDLs
        '
        Me.lblBackupSDDLs.AutoSize = True
        Me.lblBackupSDDLs.Location = New System.Drawing.Point(142, 74)
        Me.lblBackupSDDLs.Name = "lblBackupSDDLs"
        Me.lblBackupSDDLs.Size = New System.Drawing.Size(83, 13)
        Me.lblBackupSDDLs.TabIndex = 39
        Me.lblBackupSDDLs.Text = "ListInherited:"
        '
        'chkBackupSDDLsacl
        '
        Me.chkBackupSDDLsacl.AutoSize = True
        Me.chkBackupSDDLsacl.Location = New System.Drawing.Point(23, 113)
        Me.chkBackupSDDLsacl.Name = "chkBackupSDDLsacl"
        Me.chkBackupSDDLsacl.Size = New System.Drawing.Size(57, 17)
        Me.chkBackupSDDLsacl.TabIndex = 38
        Me.chkBackupSDDLsacl.Text = "SACL"
        Me.chkBackupSDDLsacl.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLOwner
        '
        Me.chkBackupSDDLOwner.AutoSize = True
        Me.chkBackupSDDLOwner.Location = New System.Drawing.Point(23, 136)
        Me.chkBackupSDDLOwner.Name = "chkBackupSDDLOwner"
        Me.chkBackupSDDLOwner.Size = New System.Drawing.Size(63, 17)
        Me.chkBackupSDDLOwner.TabIndex = 37
        Me.chkBackupSDDLOwner.Text = "Owner"
        Me.chkBackupSDDLOwner.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLPrimaryGroup
        '
        Me.chkBackupSDDLPrimaryGroup.AutoSize = True
        Me.chkBackupSDDLPrimaryGroup.Location = New System.Drawing.Point(23, 159)
        Me.chkBackupSDDLPrimaryGroup.Name = "chkBackupSDDLPrimaryGroup"
        Me.chkBackupSDDLPrimaryGroup.Size = New System.Drawing.Size(110, 17)
        Me.chkBackupSDDLPrimaryGroup.TabIndex = 36
        Me.chkBackupSDDLPrimaryGroup.Text = "Primery Group"
        Me.chkBackupSDDLPrimaryGroup.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLdacl
        '
        Me.chkBackupSDDLdacl.AutoSize = True
        Me.chkBackupSDDLdacl.Location = New System.Drawing.Point(23, 90)
        Me.chkBackupSDDLdacl.Name = "chkBackupSDDLdacl"
        Me.chkBackupSDDLdacl.Size = New System.Drawing.Size(58, 17)
        Me.chkBackupSDDLdacl.TabIndex = 35
        Me.chkBackupSDDLdacl.Text = "DACL"
        Me.chkBackupSDDLdacl.UseVisualStyleBackColor = True
        '
        'lblBackupSDDLWhat
        '
        Me.lblBackupSDDLWhat.AutoSize = True
        Me.lblBackupSDDLWhat.Location = New System.Drawing.Point(8, 74)
        Me.lblBackupSDDLWhat.Name = "lblBackupSDDLWhat"
        Me.lblBackupSDDLWhat.Size = New System.Drawing.Size(41, 13)
        Me.lblBackupSDDLWhat.TabIndex = 34
        Me.lblBackupSDDLWhat.Text = "What:"
        '
        'cmdRunBackupSDDL
        '
        Me.cmdRunBackupSDDL.FlatAppearance.BorderSize = 0
        Me.cmdRunBackupSDDL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRunBackupSDDL.Location = New System.Drawing.Point(384, 194)
        Me.cmdRunBackupSDDL.Name = "cmdRunBackupSDDL"
        Me.cmdRunBackupSDDL.Size = New System.Drawing.Size(127, 30)
        Me.cmdRunBackupSDDL.TabIndex = 33
        Me.cmdRunBackupSDDL.Text = "Run merge..."
        Me.cmdRunBackupSDDL.UseVisualStyleBackColor = True
        '
        'txtSaveSDDLBackup
        '
        Me.txtSaveSDDLBackup.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSaveSDDLBackup.Location = New System.Drawing.Point(8, 23)
        Me.txtSaveSDDLBackup.Name = "txtSaveSDDLBackup"
        Me.txtSaveSDDLBackup.ReadOnly = True
        Me.txtSaveSDDLBackup.Size = New System.Drawing.Size(398, 21)
        Me.txtSaveSDDLBackup.TabIndex = 30
        '
        'lblSaveSDDLBackup
        '
        Me.lblSaveSDDLBackup.AutoSize = True
        Me.lblSaveSDDLBackup.Location = New System.Drawing.Point(5, 7)
        Me.lblSaveSDDLBackup.Name = "lblSaveSDDLBackup"
        Me.lblSaveSDDLBackup.Size = New System.Drawing.Size(94, 13)
        Me.lblSaveSDDLBackup.TabIndex = 32
        Me.lblSaveSDDLBackup.Text = "-bckp Filename"
        '
        'cmdSaveSDDLBackup
        '
        Me.cmdSaveSDDLBackup.FlatAppearance.BorderSize = 0
        Me.cmdSaveSDDLBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSaveSDDLBackup.Location = New System.Drawing.Point(410, 23)
        Me.cmdSaveSDDLBackup.Name = "cmdSaveSDDLBackup"
        Me.cmdSaveSDDLBackup.Size = New System.Drawing.Size(101, 21)
        Me.cmdSaveSDDLBackup.TabIndex = 31
        Me.cmdSaveSDDLBackup.Text = "Browse"
        Me.cmdSaveSDDLBackup.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSaveSDDLBackup.UseVisualStyleBackColor = True
        '
        'tabReplaceSID
        '
        Me.tabReplaceSID.Controls.Add(Me.lblSaveOutput)
        Me.tabReplaceSID.Controls.Add(Me.txtSSDLFile)
        Me.tabReplaceSID.Controls.Add(Me.lblBrowseSIDmap)
        Me.tabReplaceSID.Controls.Add(Me.cmdRun)
        Me.tabReplaceSID.Controls.Add(Me.lblBrowseSSDL)
        Me.tabReplaceSID.Controls.Add(Me.cmdBrowseSSDL)
        Me.tabReplaceSID.Controls.Add(Me.cmdSaveOutput)
        Me.tabReplaceSID.Controls.Add(Me.txtBrowseSIDmap)
        Me.tabReplaceSID.Controls.Add(Me.txtSaveOutput)
        Me.tabReplaceSID.Controls.Add(Me.cmdBrowseSIDmap)
        Me.tabReplaceSID.Location = New System.Drawing.Point(4, 25)
        Me.tabReplaceSID.Name = "tabReplaceSID"
        Me.tabReplaceSID.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReplaceSID.Size = New System.Drawing.Size(514, 227)
        Me.tabReplaceSID.TabIndex = 0
        Me.tabReplaceSID.Text = "Replace SID"
        Me.tabReplaceSID.UseVisualStyleBackColor = True
        '
        'lblSaveOutput
        '
        Me.lblSaveOutput.AutoSize = True
        Me.lblSaveOutput.Location = New System.Drawing.Point(5, 97)
        Me.lblSaveOutput.Name = "lblSaveOutput"
        Me.lblSaveOutput.Size = New System.Drawing.Size(239, 13)
        Me.lblSaveOutput.TabIndex = 31
        Me.lblSaveOutput.Text = "Save SSDL file merged with SIDMap File"
        '
        'txtSSDLFile
        '
        Me.txtSSDLFile.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSSDLFile.Location = New System.Drawing.Point(8, 23)
        Me.txtSSDLFile.Name = "txtSSDLFile"
        Me.txtSSDLFile.ReadOnly = True
        Me.txtSSDLFile.Size = New System.Drawing.Size(398, 21)
        Me.txtSSDLFile.TabIndex = 23
        '
        'lblBrowseSIDmap
        '
        Me.lblBrowseSIDmap.AutoSize = True
        Me.lblBrowseSIDmap.Location = New System.Drawing.Point(5, 52)
        Me.lblBrowseSIDmap.Name = "lblBrowseSIDmap"
        Me.lblBrowseSIDmap.Size = New System.Drawing.Size(130, 13)
        Me.lblBrowseSIDmap.TabIndex = 30
        Me.lblBrowseSIDmap.Text = "Open SIDMap csv file"
        '
        'cmdRun
        '
        Me.cmdRun.FlatAppearance.BorderSize = 0
        Me.cmdRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRun.Location = New System.Drawing.Point(384, 194)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(127, 30)
        Me.cmdRun.TabIndex = 22
        Me.cmdRun.Text = "Run merge..."
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'lblBrowseSSDL
        '
        Me.lblBrowseSSDL.AutoSize = True
        Me.lblBrowseSSDL.Location = New System.Drawing.Point(5, 7)
        Me.lblBrowseSSDL.Name = "lblBrowseSSDL"
        Me.lblBrowseSSDL.Size = New System.Drawing.Size(269, 13)
        Me.lblBrowseSSDL.TabIndex = 29
        Me.lblBrowseSSDL.Text = "Open SSDL file to merge with SIDMap csv file"
        '
        'cmdBrowseSSDL
        '
        Me.cmdBrowseSSDL.FlatAppearance.BorderSize = 0
        Me.cmdBrowseSSDL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowseSSDL.Location = New System.Drawing.Point(410, 23)
        Me.cmdBrowseSSDL.Name = "cmdBrowseSSDL"
        Me.cmdBrowseSSDL.Size = New System.Drawing.Size(101, 21)
        Me.cmdBrowseSSDL.TabIndex = 24
        Me.cmdBrowseSSDL.Text = "Browse"
        Me.cmdBrowseSSDL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdBrowseSSDL.UseVisualStyleBackColor = True
        '
        'cmdSaveOutput
        '
        Me.cmdSaveOutput.FlatAppearance.BorderSize = 0
        Me.cmdSaveOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSaveOutput.Location = New System.Drawing.Point(410, 113)
        Me.cmdSaveOutput.Name = "cmdSaveOutput"
        Me.cmdSaveOutput.Size = New System.Drawing.Size(101, 21)
        Me.cmdSaveOutput.TabIndex = 28
        Me.cmdSaveOutput.Text = "Browse"
        Me.cmdSaveOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSaveOutput.UseVisualStyleBackColor = True
        '
        'txtBrowseSIDmap
        '
        Me.txtBrowseSIDmap.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtBrowseSIDmap.Location = New System.Drawing.Point(8, 68)
        Me.txtBrowseSIDmap.Name = "txtBrowseSIDmap"
        Me.txtBrowseSIDmap.ReadOnly = True
        Me.txtBrowseSIDmap.Size = New System.Drawing.Size(398, 21)
        Me.txtBrowseSIDmap.TabIndex = 25
        '
        'txtSaveOutput
        '
        Me.txtSaveOutput.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSaveOutput.Location = New System.Drawing.Point(8, 113)
        Me.txtSaveOutput.Name = "txtSaveOutput"
        Me.txtSaveOutput.ReadOnly = True
        Me.txtSaveOutput.Size = New System.Drawing.Size(398, 21)
        Me.txtSaveOutput.TabIndex = 27
        '
        'cmdBrowseSIDmap
        '
        Me.cmdBrowseSIDmap.FlatAppearance.BorderSize = 0
        Me.cmdBrowseSIDmap.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowseSIDmap.Location = New System.Drawing.Point(410, 68)
        Me.cmdBrowseSIDmap.Name = "cmdBrowseSIDmap"
        Me.cmdBrowseSIDmap.Size = New System.Drawing.Size(101, 21)
        Me.cmdBrowseSIDmap.TabIndex = 26
        Me.cmdBrowseSIDmap.Text = "Browse"
        Me.cmdBrowseSIDmap.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdBrowseSIDmap.UseVisualStyleBackColor = True
        '
        'tabRestoreSDDL
        '
        Me.tabRestoreSDDL.Location = New System.Drawing.Point(4, 25)
        Me.tabRestoreSDDL.Name = "tabRestoreSDDL"
        Me.tabRestoreSDDL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRestoreSDDL.Size = New System.Drawing.Size(514, 227)
        Me.tabRestoreSDDL.TabIndex = 2
        Me.tabRestoreSDDL.Text = "Restore SDDL"
        Me.tabRestoreSDDL.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 256)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.tabBackupSDDL.ResumeLayout(False)
        Me.tabBackupSDDL.PerformLayout()
        Me.tabReplaceSID.ResumeLayout(False)
        Me.tabReplaceSID.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofdSSDLFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bgwReplaceSID As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwLoadSIDMap As System.ComponentModel.BackgroundWorker
    Friend WithEvents sfdSSDLFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabReplaceSID As System.Windows.Forms.TabPage
    Friend WithEvents tabBackupSDDL As System.Windows.Forms.TabPage
    Friend WithEvents tabRestoreSDDL As System.Windows.Forms.TabPage
    Friend WithEvents lblSaveOutput As System.Windows.Forms.Label
    Friend WithEvents lblBrowseSIDmap As System.Windows.Forms.Label
    Friend WithEvents lblBrowseSSDL As System.Windows.Forms.Label
    Friend WithEvents cmdSaveOutput As System.Windows.Forms.Button
    Friend WithEvents txtSaveOutput As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowseSIDmap As System.Windows.Forms.Button
    Friend WithEvents txtBrowseSIDmap As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowseSSDL As System.Windows.Forms.Button
    Friend WithEvents txtSSDLFile As System.Windows.Forms.TextBox
    Friend WithEvents cmdRun As System.Windows.Forms.Button
    Friend WithEvents txtSaveSDDLBackup As System.Windows.Forms.TextBox
    Friend WithEvents lblSaveSDDLBackup As System.Windows.Forms.Label
    Friend WithEvents cmdSaveSDDLBackup As System.Windows.Forms.Button
    Friend WithEvents cmdRunBackupSDDL As System.Windows.Forms.Button
    Friend WithEvents bgwBackupSDDL As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblBackupSDDLWhat As System.Windows.Forms.Label
    Friend WithEvents lblBackupSDDLCL As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents lblBackupSDDLs As System.Windows.Forms.Label
    Friend WithEvents chkBackupSDDLsacl As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupSDDLOwner As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupSDDLPrimaryGroup As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupSDDLdacl As System.Windows.Forms.CheckBox

End Class
