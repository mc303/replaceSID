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
        Me.chkBackupSDDLown = New System.Windows.Forms.CheckBox()
        Me.chkBackupSDDLtab = New System.Windows.Forms.CheckBox()
        Me.chkBackupSDDLsddl = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkBackupSDDLDisplaySIDno = New System.Windows.Forms.CheckBox()
        Me.chkBackupSDDLDisplaySIDboth = New System.Windows.Forms.CheckBox()
        Me.chkBackupSDDLDisplaySIDyes = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkBackupSDDLobj = New System.Windows.Forms.CheckBox()
        Me.chkBackupSDDLcont_obj = New System.Windows.Forms.CheckBox()
        Me.chkBackupSDDLcont = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBackupSDDLon = New System.Windows.Forms.Label()
        Me.txtBackupSDDLon = New System.Windows.Forms.TextBox()
        Me.lblBackupSDDLCL = New System.Windows.Forms.Label()
        Me.chkBackupSDDLoo = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkBackupSDDLi = New System.Windows.Forms.CheckBox()
        Me.lblBackupSDDLs = New System.Windows.Forms.Label()
        Me.chkBackupSDDLsacl = New System.Windows.Forms.CheckBox()
        Me.chkBackupSDDLOwner = New System.Windows.Forms.CheckBox()
        Me.chkBackupSDDLPrimaryGroup = New System.Windows.Forms.CheckBox()
        Me.chkBackupSDDLdacl = New System.Windows.Forms.CheckBox()
        Me.lblBackupSDDLWhat = New System.Windows.Forms.Label()
        Me.cmdBackupSDDLRun = New System.Windows.Forms.Button()
        Me.txtBackupSDDLbckp = New System.Windows.Forms.TextBox()
        Me.lblSaveSDDLBackup = New System.Windows.Forms.Label()
        Me.cmdBackupSDDLbckp = New System.Windows.Forms.Button()
        Me.tabReplaceSID = New System.Windows.Forms.TabPage()
        Me.lblSaveOutput = New System.Windows.Forms.Label()
        Me.txtSSDLFile = New System.Windows.Forms.TextBox()
        Me.lblBrowseSIDmap = New System.Windows.Forms.Label()
        Me.cmdReplaceSIDRun = New System.Windows.Forms.Button()
        Me.lblBrowseSSDL = New System.Windows.Forms.Label()
        Me.cmdBrowseSSDL = New System.Windows.Forms.Button()
        Me.cmdSaveOutput = New System.Windows.Forms.Button()
        Me.txtBrowseSIDmap = New System.Windows.Forms.TextBox()
        Me.txtSaveOutput = New System.Windows.Forms.TextBox()
        Me.cmdBrowseSIDmap = New System.Windows.Forms.Button()
        Me.tabRestoreSDDL = New System.Windows.Forms.TabPage()
        Me.lblRestoreSDDLon = New System.Windows.Forms.Label()
        Me.txtRestoreSDDLon = New System.Windows.Forms.TextBox()
        Me.cmdRestoreSDDLRun = New System.Windows.Forms.Button()
        Me.txtRestoreSDDLbkcp = New System.Windows.Forms.TextBox()
        Me.lblRestoreSDDLbkcp = New System.Windows.Forms.Label()
        Me.cmdRestoreSDDLbkcp = New System.Windows.Forms.Button()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.txtSettingsSetACLLocation = New System.Windows.Forms.TextBox()
        Me.lblSettingsSetACLLocation = New System.Windows.Forms.Label()
        Me.cmdSettingsSetACLLocation = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmdListAllSDFileRun = New System.Windows.Forms.Button()
        Me.txtListSIDinSDDLFile = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdFindSIDSDDL = New System.Windows.Forms.Button()
        Me.bgwBackupSDDL = New System.ComponentModel.BackgroundWorker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCreateSDDLtoSIDFile = New System.Windows.Forms.TextBox()
        Me.cmdCreateSDDLtoSIDFile = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabBackupSDDL.SuspendLayout()
        Me.tabReplaceSID.SuspendLayout()
        Me.tabRestoreSDDL.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.TabPage1.SuspendLayout()
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
        Me.TabControl1.Controls.Add(Me.tabSettings)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(522, 256)
        Me.TabControl1.TabIndex = 11
        '
        'tabBackupSDDL
        '
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLown)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLtab)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLsddl)
        Me.tabBackupSDDL.Controls.Add(Me.Label4)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLDisplaySIDno)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLDisplaySIDboth)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLDisplaySIDyes)
        Me.tabBackupSDDL.Controls.Add(Me.Label3)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLobj)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLcont_obj)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLcont)
        Me.tabBackupSDDL.Controls.Add(Me.Label2)
        Me.tabBackupSDDL.Controls.Add(Me.lblBackupSDDLon)
        Me.tabBackupSDDL.Controls.Add(Me.txtBackupSDDLon)
        Me.tabBackupSDDL.Controls.Add(Me.lblBackupSDDLCL)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLoo)
        Me.tabBackupSDDL.Controls.Add(Me.Label1)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLi)
        Me.tabBackupSDDL.Controls.Add(Me.lblBackupSDDLs)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLsacl)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLOwner)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLPrimaryGroup)
        Me.tabBackupSDDL.Controls.Add(Me.chkBackupSDDLdacl)
        Me.tabBackupSDDL.Controls.Add(Me.lblBackupSDDLWhat)
        Me.tabBackupSDDL.Controls.Add(Me.cmdBackupSDDLRun)
        Me.tabBackupSDDL.Controls.Add(Me.txtBackupSDDLbckp)
        Me.tabBackupSDDL.Controls.Add(Me.lblSaveSDDLBackup)
        Me.tabBackupSDDL.Controls.Add(Me.cmdBackupSDDLbckp)
        Me.tabBackupSDDL.Location = New System.Drawing.Point(4, 25)
        Me.tabBackupSDDL.Name = "tabBackupSDDL"
        Me.tabBackupSDDL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBackupSDDL.Size = New System.Drawing.Size(514, 227)
        Me.tabBackupSDDL.TabIndex = 1
        Me.tabBackupSDDL.Text = "Backup SDDL"
        Me.tabBackupSDDL.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLown
        '
        Me.chkBackupSDDLown.AutoSize = True
        Me.chkBackupSDDLown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLown.Location = New System.Drawing.Point(121, 149)
        Me.chkBackupSDDLown.Name = "chkBackupSDDLown"
        Me.chkBackupSDDLown.Size = New System.Drawing.Size(70, 17)
        Me.chkBackupSDDLown.TabIndex = 59
        Me.chkBackupSDDLown.Text = "csv/own"
        Me.chkBackupSDDLown.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLtab
        '
        Me.chkBackupSDDLtab.AutoSize = True
        Me.chkBackupSDDLtab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLtab.Location = New System.Drawing.Point(121, 172)
        Me.chkBackupSDDLtab.Name = "chkBackupSDDLtab"
        Me.chkBackupSDDLtab.Size = New System.Drawing.Size(41, 17)
        Me.chkBackupSDDLtab.TabIndex = 58
        Me.chkBackupSDDLtab.Text = "tab"
        Me.chkBackupSDDLtab.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLsddl
        '
        Me.chkBackupSDDLsddl.AutoSize = True
        Me.chkBackupSDDLsddl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLsddl.Location = New System.Drawing.Point(121, 126)
        Me.chkBackupSDDLsddl.Name = "chkBackupSDDLsddl"
        Me.chkBackupSDDLsddl.Size = New System.Drawing.Size(46, 17)
        Me.chkBackupSDDLsddl.TabIndex = 57
        Me.chkBackupSDDLsddl.Text = "sddl"
        Me.chkBackupSDDLsddl.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Format:"
        '
        'chkBackupSDDLDisplaySIDno
        '
        Me.chkBackupSDDLDisplaySIDno.AutoSize = True
        Me.chkBackupSDDLDisplaySIDno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLDisplaySIDno.Location = New System.Drawing.Point(326, 149)
        Me.chkBackupSDDLDisplaySIDno.Name = "chkBackupSDDLDisplaySIDno"
        Me.chkBackupSDDLDisplaySIDno.Size = New System.Drawing.Size(38, 17)
        Me.chkBackupSDDLDisplaySIDno.TabIndex = 54
        Me.chkBackupSDDLDisplaySIDno.Text = "No"
        Me.chkBackupSDDLDisplaySIDno.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLDisplaySIDboth
        '
        Me.chkBackupSDDLDisplaySIDboth.AutoSize = True
        Me.chkBackupSDDLDisplaySIDboth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLDisplaySIDboth.Location = New System.Drawing.Point(326, 172)
        Me.chkBackupSDDLDisplaySIDboth.Name = "chkBackupSDDLDisplaySIDboth"
        Me.chkBackupSDDLDisplaySIDboth.Size = New System.Drawing.Size(49, 17)
        Me.chkBackupSDDLDisplaySIDboth.TabIndex = 53
        Me.chkBackupSDDLDisplaySIDboth.Text = "Both"
        Me.chkBackupSDDLDisplaySIDboth.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLDisplaySIDyes
        '
        Me.chkBackupSDDLDisplaySIDyes.AutoSize = True
        Me.chkBackupSDDLDisplaySIDyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLDisplaySIDyes.Location = New System.Drawing.Point(326, 126)
        Me.chkBackupSDDLDisplaySIDyes.Name = "chkBackupSDDLDisplaySIDyes"
        Me.chkBackupSDDLDisplaySIDyes.Size = New System.Drawing.Size(42, 17)
        Me.chkBackupSDDLDisplaySIDyes.TabIndex = 52
        Me.chkBackupSDDLDisplaySIDyes.Text = "Yes"
        Me.chkBackupSDDLDisplaySIDyes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(314, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "DisplaySID:"
        '
        'chkBackupSDDLobj
        '
        Me.chkBackupSDDLobj.AutoSize = True
        Me.chkBackupSDDLobj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLobj.Location = New System.Drawing.Point(20, 149)
        Me.chkBackupSDDLobj.Name = "chkBackupSDDLobj"
        Me.chkBackupSDDLobj.Size = New System.Drawing.Size(41, 17)
        Me.chkBackupSDDLobj.TabIndex = 50
        Me.chkBackupSDDLobj.Text = "obj"
        Me.chkBackupSDDLobj.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLcont_obj
        '
        Me.chkBackupSDDLcont_obj.AutoSize = True
        Me.chkBackupSDDLcont_obj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLcont_obj.Location = New System.Drawing.Point(20, 172)
        Me.chkBackupSDDLcont_obj.Name = "chkBackupSDDLcont_obj"
        Me.chkBackupSDDLcont_obj.Size = New System.Drawing.Size(72, 17)
        Me.chkBackupSDDLcont_obj.TabIndex = 49
        Me.chkBackupSDDLcont_obj.Text = "cont_obj"
        Me.chkBackupSDDLcont_obj.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLcont
        '
        Me.chkBackupSDDLcont.AutoSize = True
        Me.chkBackupSDDLcont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLcont.Location = New System.Drawing.Point(20, 126)
        Me.chkBackupSDDLcont.Name = "chkBackupSDDLcont"
        Me.chkBackupSDDLcont.Size = New System.Drawing.Size(47, 17)
        Me.chkBackupSDDLcont.TabIndex = 47
        Me.chkBackupSDDLcont.Text = "cont"
        Me.chkBackupSDDLcont.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Recursion:"
        '
        'lblBackupSDDLon
        '
        Me.lblBackupSDDLon.AutoSize = True
        Me.lblBackupSDDLon.Location = New System.Drawing.Point(5, 4)
        Me.lblBackupSDDLon.Name = "lblBackupSDDLon"
        Me.lblBackupSDDLon.Size = New System.Drawing.Size(221, 13)
        Me.lblBackupSDDLon.TabIndex = 45
        Me.lblBackupSDDLon.Text = "SetACL -on <folder> -ot file -actn list"
        '
        'txtBackupSDDLon
        '
        Me.txtBackupSDDLon.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtBackupSDDLon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBackupSDDLon.Location = New System.Drawing.Point(8, 22)
        Me.txtBackupSDDLon.Name = "txtBackupSDDLon"
        Me.txtBackupSDDLon.Size = New System.Drawing.Size(503, 21)
        Me.txtBackupSDDLon.TabIndex = 44
        '
        'lblBackupSDDLCL
        '
        Me.lblBackupSDDLCL.AutoSize = True
        Me.lblBackupSDDLCL.Location = New System.Drawing.Point(3, 90)
        Me.lblBackupSDDLCL.Name = "lblBackupSDDLCL"
        Me.lblBackupSDDLCL.Size = New System.Drawing.Size(473, 13)
        Me.lblBackupSDDLCL.TabIndex = 43
        Me.lblBackupSDDLCL.Text = "-actn list [-lst ""f:Format;w:What;i:ListInherited;s:DisplaySID;oo:OrphanedOnly""] " & _
    ""
        '
        'chkBackupSDDLoo
        '
        Me.chkBackupSDDLoo.AutoSize = True
        Me.chkBackupSDDLoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLoo.Location = New System.Drawing.Point(426, 162)
        Me.chkBackupSDDLoo.Name = "chkBackupSDDLoo"
        Me.chkBackupSDDLoo.Size = New System.Drawing.Size(42, 17)
        Me.chkBackupSDDLoo.TabIndex = 42
        Me.chkBackupSDDLoo.Text = "Yes"
        Me.chkBackupSDDLoo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(412, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "OrphanedOnly:"
        '
        'chkBackupSDDLi
        '
        Me.chkBackupSDDLi.AutoSize = True
        Me.chkBackupSDDLi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLi.Location = New System.Drawing.Point(426, 126)
        Me.chkBackupSDDLi.Name = "chkBackupSDDLi"
        Me.chkBackupSDDLi.Size = New System.Drawing.Size(42, 17)
        Me.chkBackupSDDLi.TabIndex = 40
        Me.chkBackupSDDLi.Text = "Yes"
        Me.chkBackupSDDLi.UseVisualStyleBackColor = True
        '
        'lblBackupSDDLs
        '
        Me.lblBackupSDDLs.AutoSize = True
        Me.lblBackupSDDLs.Location = New System.Drawing.Point(412, 110)
        Me.lblBackupSDDLs.Name = "lblBackupSDDLs"
        Me.lblBackupSDDLs.Size = New System.Drawing.Size(83, 13)
        Me.lblBackupSDDLs.TabIndex = 39
        Me.lblBackupSDDLs.Text = "ListInherited:"
        '
        'chkBackupSDDLsacl
        '
        Me.chkBackupSDDLsacl.AutoSize = True
        Me.chkBackupSDDLsacl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLsacl.Location = New System.Drawing.Point(210, 149)
        Me.chkBackupSDDLsacl.Name = "chkBackupSDDLsacl"
        Me.chkBackupSDDLsacl.Size = New System.Drawing.Size(54, 17)
        Me.chkBackupSDDLsacl.TabIndex = 38
        Me.chkBackupSDDLsacl.Text = "SACL"
        Me.chkBackupSDDLsacl.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLOwner
        '
        Me.chkBackupSDDLOwner.AutoSize = True
        Me.chkBackupSDDLOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLOwner.Location = New System.Drawing.Point(210, 172)
        Me.chkBackupSDDLOwner.Name = "chkBackupSDDLOwner"
        Me.chkBackupSDDLOwner.Size = New System.Drawing.Size(60, 17)
        Me.chkBackupSDDLOwner.TabIndex = 37
        Me.chkBackupSDDLOwner.Text = "Owner"
        Me.chkBackupSDDLOwner.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLPrimaryGroup
        '
        Me.chkBackupSDDLPrimaryGroup.AutoSize = True
        Me.chkBackupSDDLPrimaryGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLPrimaryGroup.Location = New System.Drawing.Point(210, 195)
        Me.chkBackupSDDLPrimaryGroup.Name = "chkBackupSDDLPrimaryGroup"
        Me.chkBackupSDDLPrimaryGroup.Size = New System.Drawing.Size(107, 17)
        Me.chkBackupSDDLPrimaryGroup.TabIndex = 36
        Me.chkBackupSDDLPrimaryGroup.Text = "Primery Group"
        Me.chkBackupSDDLPrimaryGroup.UseVisualStyleBackColor = True
        '
        'chkBackupSDDLdacl
        '
        Me.chkBackupSDDLdacl.AutoSize = True
        Me.chkBackupSDDLdacl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBackupSDDLdacl.Location = New System.Drawing.Point(210, 126)
        Me.chkBackupSDDLdacl.Name = "chkBackupSDDLdacl"
        Me.chkBackupSDDLdacl.Size = New System.Drawing.Size(55, 17)
        Me.chkBackupSDDLdacl.TabIndex = 35
        Me.chkBackupSDDLdacl.Text = "DACL"
        Me.chkBackupSDDLdacl.UseVisualStyleBackColor = True
        '
        'lblBackupSDDLWhat
        '
        Me.lblBackupSDDLWhat.AutoSize = True
        Me.lblBackupSDDLWhat.Location = New System.Drawing.Point(195, 110)
        Me.lblBackupSDDLWhat.Name = "lblBackupSDDLWhat"
        Me.lblBackupSDDLWhat.Size = New System.Drawing.Size(41, 13)
        Me.lblBackupSDDLWhat.TabIndex = 34
        Me.lblBackupSDDLWhat.Text = "What:"
        '
        'cmdBackupSDDLRun
        '
        Me.cmdBackupSDDLRun.FlatAppearance.BorderSize = 0
        Me.cmdBackupSDDLRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBackupSDDLRun.Location = New System.Drawing.Point(384, 193)
        Me.cmdBackupSDDLRun.Name = "cmdBackupSDDLRun"
        Me.cmdBackupSDDLRun.Size = New System.Drawing.Size(127, 30)
        Me.cmdBackupSDDLRun.TabIndex = 33
        Me.cmdBackupSDDLRun.Text = "Run merge..."
        Me.cmdBackupSDDLRun.UseVisualStyleBackColor = True
        '
        'txtBackupSDDLbckp
        '
        Me.txtBackupSDDLbckp.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtBackupSDDLbckp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBackupSDDLbckp.Location = New System.Drawing.Point(8, 65)
        Me.txtBackupSDDLbckp.Name = "txtBackupSDDLbckp"
        Me.txtBackupSDDLbckp.ReadOnly = True
        Me.txtBackupSDDLbckp.Size = New System.Drawing.Size(398, 21)
        Me.txtBackupSDDLbckp.TabIndex = 30
        '
        'lblSaveSDDLBackup
        '
        Me.lblSaveSDDLBackup.AutoSize = True
        Me.lblSaveSDDLBackup.Location = New System.Drawing.Point(5, 47)
        Me.lblSaveSDDLBackup.Name = "lblSaveSDDLBackup"
        Me.lblSaveSDDLBackup.Size = New System.Drawing.Size(235, 13)
        Me.lblSaveSDDLBackup.TabIndex = 32
        Me.lblSaveSDDLBackup.Text = "-bckp Filename -rec <recursion> -silent"
        '
        'cmdBackupSDDLbckp
        '
        Me.cmdBackupSDDLbckp.FlatAppearance.BorderSize = 0
        Me.cmdBackupSDDLbckp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBackupSDDLbckp.Location = New System.Drawing.Point(410, 65)
        Me.cmdBackupSDDLbckp.Name = "cmdBackupSDDLbckp"
        Me.cmdBackupSDDLbckp.Size = New System.Drawing.Size(101, 21)
        Me.cmdBackupSDDLbckp.TabIndex = 31
        Me.cmdBackupSDDLbckp.Text = "Browse"
        Me.cmdBackupSDDLbckp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdBackupSDDLbckp.UseVisualStyleBackColor = True
        '
        'tabReplaceSID
        '
        Me.tabReplaceSID.Controls.Add(Me.lblSaveOutput)
        Me.tabReplaceSID.Controls.Add(Me.txtSSDLFile)
        Me.tabReplaceSID.Controls.Add(Me.lblBrowseSIDmap)
        Me.tabReplaceSID.Controls.Add(Me.cmdReplaceSIDRun)
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
        Me.lblSaveOutput.Location = New System.Drawing.Point(5, 94)
        Me.lblSaveOutput.Name = "lblSaveOutput"
        Me.lblSaveOutput.Size = New System.Drawing.Size(239, 13)
        Me.lblSaveOutput.TabIndex = 31
        Me.lblSaveOutput.Text = "Save SSDL file merged with SIDMap File"
        '
        'txtSSDLFile
        '
        Me.txtSSDLFile.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSSDLFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSSDLFile.Location = New System.Drawing.Point(8, 22)
        Me.txtSSDLFile.Name = "txtSSDLFile"
        Me.txtSSDLFile.ReadOnly = True
        Me.txtSSDLFile.Size = New System.Drawing.Size(398, 21)
        Me.txtSSDLFile.TabIndex = 23
        '
        'lblBrowseSIDmap
        '
        Me.lblBrowseSIDmap.AutoSize = True
        Me.lblBrowseSIDmap.Location = New System.Drawing.Point(5, 49)
        Me.lblBrowseSIDmap.Name = "lblBrowseSIDmap"
        Me.lblBrowseSIDmap.Size = New System.Drawing.Size(130, 13)
        Me.lblBrowseSIDmap.TabIndex = 30
        Me.lblBrowseSIDmap.Text = "Open SIDMap csv file"
        '
        'cmdReplaceSIDRun
        '
        Me.cmdReplaceSIDRun.FlatAppearance.BorderSize = 0
        Me.cmdReplaceSIDRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdReplaceSIDRun.Location = New System.Drawing.Point(384, 193)
        Me.cmdReplaceSIDRun.Name = "cmdReplaceSIDRun"
        Me.cmdReplaceSIDRun.Size = New System.Drawing.Size(127, 30)
        Me.cmdReplaceSIDRun.TabIndex = 22
        Me.cmdReplaceSIDRun.Text = "Run merge..."
        Me.cmdReplaceSIDRun.UseVisualStyleBackColor = True
        '
        'lblBrowseSSDL
        '
        Me.lblBrowseSSDL.AutoSize = True
        Me.lblBrowseSSDL.Location = New System.Drawing.Point(5, 6)
        Me.lblBrowseSSDL.Name = "lblBrowseSSDL"
        Me.lblBrowseSSDL.Size = New System.Drawing.Size(269, 13)
        Me.lblBrowseSSDL.TabIndex = 29
        Me.lblBrowseSSDL.Text = "Open SSDL file to merge with SIDMap csv file"
        '
        'cmdBrowseSSDL
        '
        Me.cmdBrowseSSDL.FlatAppearance.BorderSize = 0
        Me.cmdBrowseSSDL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowseSSDL.Location = New System.Drawing.Point(410, 22)
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
        Me.cmdSaveOutput.Location = New System.Drawing.Point(410, 112)
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
        Me.txtBrowseSIDmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrowseSIDmap.Location = New System.Drawing.Point(8, 67)
        Me.txtBrowseSIDmap.Name = "txtBrowseSIDmap"
        Me.txtBrowseSIDmap.ReadOnly = True
        Me.txtBrowseSIDmap.Size = New System.Drawing.Size(398, 21)
        Me.txtBrowseSIDmap.TabIndex = 25
        '
        'txtSaveOutput
        '
        Me.txtSaveOutput.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSaveOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaveOutput.Location = New System.Drawing.Point(8, 112)
        Me.txtSaveOutput.Name = "txtSaveOutput"
        Me.txtSaveOutput.ReadOnly = True
        Me.txtSaveOutput.Size = New System.Drawing.Size(398, 21)
        Me.txtSaveOutput.TabIndex = 27
        '
        'cmdBrowseSIDmap
        '
        Me.cmdBrowseSIDmap.FlatAppearance.BorderSize = 0
        Me.cmdBrowseSIDmap.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowseSIDmap.Location = New System.Drawing.Point(410, 67)
        Me.cmdBrowseSIDmap.Name = "cmdBrowseSIDmap"
        Me.cmdBrowseSIDmap.Size = New System.Drawing.Size(101, 21)
        Me.cmdBrowseSIDmap.TabIndex = 26
        Me.cmdBrowseSIDmap.Text = "Browse"
        Me.cmdBrowseSIDmap.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdBrowseSIDmap.UseVisualStyleBackColor = True
        '
        'tabRestoreSDDL
        '
        Me.tabRestoreSDDL.Controls.Add(Me.lblRestoreSDDLon)
        Me.tabRestoreSDDL.Controls.Add(Me.txtRestoreSDDLon)
        Me.tabRestoreSDDL.Controls.Add(Me.cmdRestoreSDDLRun)
        Me.tabRestoreSDDL.Controls.Add(Me.txtRestoreSDDLbkcp)
        Me.tabRestoreSDDL.Controls.Add(Me.lblRestoreSDDLbkcp)
        Me.tabRestoreSDDL.Controls.Add(Me.cmdRestoreSDDLbkcp)
        Me.tabRestoreSDDL.Location = New System.Drawing.Point(4, 25)
        Me.tabRestoreSDDL.Name = "tabRestoreSDDL"
        Me.tabRestoreSDDL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRestoreSDDL.Size = New System.Drawing.Size(514, 227)
        Me.tabRestoreSDDL.TabIndex = 2
        Me.tabRestoreSDDL.Text = "Restore SDDL"
        Me.tabRestoreSDDL.UseVisualStyleBackColor = True
        '
        'lblRestoreSDDLon
        '
        Me.lblRestoreSDDLon.AutoSize = True
        Me.lblRestoreSDDLon.Location = New System.Drawing.Point(5, 4)
        Me.lblRestoreSDDLon.Name = "lblRestoreSDDLon"
        Me.lblRestoreSDDLon.Size = New System.Drawing.Size(237, 13)
        Me.lblRestoreSDDLon.TabIndex = 51
        Me.lblRestoreSDDLon.Text = "SetACL -on Foldername -ot file -actn list"
        '
        'txtRestoreSDDLon
        '
        Me.txtRestoreSDDLon.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtRestoreSDDLon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRestoreSDDLon.Location = New System.Drawing.Point(8, 22)
        Me.txtRestoreSDDLon.Name = "txtRestoreSDDLon"
        Me.txtRestoreSDDLon.Size = New System.Drawing.Size(503, 21)
        Me.txtRestoreSDDLon.TabIndex = 50
        '
        'cmdRestoreSDDLRun
        '
        Me.cmdRestoreSDDLRun.FlatAppearance.BorderSize = 0
        Me.cmdRestoreSDDLRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRestoreSDDLRun.Location = New System.Drawing.Point(384, 193)
        Me.cmdRestoreSDDLRun.Name = "cmdRestoreSDDLRun"
        Me.cmdRestoreSDDLRun.Size = New System.Drawing.Size(127, 30)
        Me.cmdRestoreSDDLRun.TabIndex = 49
        Me.cmdRestoreSDDLRun.Text = "Run merge..."
        Me.cmdRestoreSDDLRun.UseVisualStyleBackColor = True
        '
        'txtRestoreSDDLbkcp
        '
        Me.txtRestoreSDDLbkcp.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtRestoreSDDLbkcp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRestoreSDDLbkcp.Location = New System.Drawing.Point(8, 67)
        Me.txtRestoreSDDLbkcp.Name = "txtRestoreSDDLbkcp"
        Me.txtRestoreSDDLbkcp.ReadOnly = True
        Me.txtRestoreSDDLbkcp.Size = New System.Drawing.Size(398, 21)
        Me.txtRestoreSDDLbkcp.TabIndex = 46
        '
        'lblRestoreSDDLbkcp
        '
        Me.lblRestoreSDDLbkcp.AutoSize = True
        Me.lblRestoreSDDLbkcp.Location = New System.Drawing.Point(5, 51)
        Me.lblRestoreSDDLbkcp.Name = "lblRestoreSDDLbkcp"
        Me.lblRestoreSDDLbkcp.Size = New System.Drawing.Size(188, 13)
        Me.lblRestoreSDDLbkcp.TabIndex = 48
        Me.lblRestoreSDDLbkcp.Text = "-bckp Filename -rec cont -silent"
        '
        'cmdRestoreSDDLbkcp
        '
        Me.cmdRestoreSDDLbkcp.FlatAppearance.BorderSize = 0
        Me.cmdRestoreSDDLbkcp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRestoreSDDLbkcp.Location = New System.Drawing.Point(410, 67)
        Me.cmdRestoreSDDLbkcp.Name = "cmdRestoreSDDLbkcp"
        Me.cmdRestoreSDDLbkcp.Size = New System.Drawing.Size(101, 21)
        Me.cmdRestoreSDDLbkcp.TabIndex = 47
        Me.cmdRestoreSDDLbkcp.Text = "Browse"
        Me.cmdRestoreSDDLbkcp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdRestoreSDDLbkcp.UseVisualStyleBackColor = True
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.txtSettingsSetACLLocation)
        Me.tabSettings.Controls.Add(Me.lblSettingsSetACLLocation)
        Me.tabSettings.Controls.Add(Me.cmdSettingsSetACLLocation)
        Me.tabSettings.Location = New System.Drawing.Point(4, 25)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSettings.Size = New System.Drawing.Size(514, 227)
        Me.tabSettings.TabIndex = 3
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'txtSettingsSetACLLocation
        '
        Me.txtSettingsSetACLLocation.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSettingsSetACLLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSettingsSetACLLocation.Location = New System.Drawing.Point(8, 22)
        Me.txtSettingsSetACLLocation.Name = "txtSettingsSetACLLocation"
        Me.txtSettingsSetACLLocation.ReadOnly = True
        Me.txtSettingsSetACLLocation.Size = New System.Drawing.Size(398, 21)
        Me.txtSettingsSetACLLocation.TabIndex = 30
        '
        'lblSettingsSetACLLocation
        '
        Me.lblSettingsSetACLLocation.AutoSize = True
        Me.lblSettingsSetACLLocation.Location = New System.Drawing.Point(5, 6)
        Me.lblSettingsSetACLLocation.Name = "lblSettingsSetACLLocation"
        Me.lblSettingsSetACLLocation.Size = New System.Drawing.Size(269, 13)
        Me.lblSettingsSetACLLocation.TabIndex = 32
        Me.lblSettingsSetACLLocation.Text = "Open SSDL file to merge with SIDMap csv file"
        '
        'cmdSettingsSetACLLocation
        '
        Me.cmdSettingsSetACLLocation.FlatAppearance.BorderSize = 0
        Me.cmdSettingsSetACLLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSettingsSetACLLocation.Location = New System.Drawing.Point(410, 22)
        Me.cmdSettingsSetACLLocation.Name = "cmdSettingsSetACLLocation"
        Me.cmdSettingsSetACLLocation.Size = New System.Drawing.Size(101, 21)
        Me.cmdSettingsSetACLLocation.TabIndex = 31
        Me.cmdSettingsSetACLLocation.Text = "Browse"
        Me.cmdSettingsSetACLLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSettingsSetACLLocation.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtCreateSDDLtoSIDFile)
        Me.TabPage1.Controls.Add(Me.cmdCreateSDDLtoSIDFile)
        Me.TabPage1.Controls.Add(Me.cmdListAllSDFileRun)
        Me.TabPage1.Controls.Add(Me.txtListSIDinSDDLFile)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.cmdFindSIDSDDL)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(514, 227)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmdListAllSDFileRun
        '
        Me.cmdListAllSDFileRun.FlatAppearance.BorderSize = 0
        Me.cmdListAllSDFileRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdListAllSDFileRun.Location = New System.Drawing.Point(384, 193)
        Me.cmdListAllSDFileRun.Name = "cmdListAllSDFileRun"
        Me.cmdListAllSDFileRun.Size = New System.Drawing.Size(127, 30)
        Me.cmdListAllSDFileRun.TabIndex = 50
        Me.cmdListAllSDFileRun.Text = "Run merge..."
        Me.cmdListAllSDFileRun.UseVisualStyleBackColor = True
        '
        'txtListSIDinSDDLFile
        '
        Me.txtListSIDinSDDLFile.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtListSIDinSDDLFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtListSIDinSDDLFile.Location = New System.Drawing.Point(8, 22)
        Me.txtListSIDinSDDLFile.Name = "txtListSIDinSDDLFile"
        Me.txtListSIDinSDDLFile.ReadOnly = True
        Me.txtListSIDinSDDLFile.Size = New System.Drawing.Size(398, 21)
        Me.txtListSIDinSDDLFile.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Open SSDL file to merge with SIDMap csv file"
        '
        'cmdFindSIDSDDL
        '
        Me.cmdFindSIDSDDL.FlatAppearance.BorderSize = 0
        Me.cmdFindSIDSDDL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFindSIDSDDL.Location = New System.Drawing.Point(410, 22)
        Me.cmdFindSIDSDDL.Name = "cmdFindSIDSDDL"
        Me.cmdFindSIDSDDL.Size = New System.Drawing.Size(101, 21)
        Me.cmdFindSIDSDDL.TabIndex = 31
        Me.cmdFindSIDSDDL.Text = "Browse"
        Me.cmdFindSIDSDDL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFindSIDSDDL.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Open SIDMap csv file"
        '
        'txtCreateSDDLtoSIDFile
        '
        Me.txtCreateSDDLtoSIDFile.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCreateSDDLtoSIDFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCreateSDDLtoSIDFile.Location = New System.Drawing.Point(8, 67)
        Me.txtCreateSDDLtoSIDFile.Name = "txtCreateSDDLtoSIDFile"
        Me.txtCreateSDDLtoSIDFile.ReadOnly = True
        Me.txtCreateSDDLtoSIDFile.Size = New System.Drawing.Size(398, 21)
        Me.txtCreateSDDLtoSIDFile.TabIndex = 51
        '
        'cmdCreateSDDLtoSIDFile
        '
        Me.cmdCreateSDDLtoSIDFile.FlatAppearance.BorderSize = 0
        Me.cmdCreateSDDLtoSIDFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCreateSDDLtoSIDFile.Location = New System.Drawing.Point(410, 67)
        Me.cmdCreateSDDLtoSIDFile.Name = "cmdCreateSDDLtoSIDFile"
        Me.cmdCreateSDDLtoSIDFile.Size = New System.Drawing.Size(101, 21)
        Me.cmdCreateSDDLtoSIDFile.TabIndex = 52
        Me.cmdCreateSDDLtoSIDFile.Text = "Browse"
        Me.cmdCreateSDDLtoSIDFile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCreateSDDLtoSIDFile.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 256)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "replaceSID"
        Me.TabControl1.ResumeLayout(False)
        Me.tabBackupSDDL.ResumeLayout(False)
        Me.tabBackupSDDL.PerformLayout()
        Me.tabReplaceSID.ResumeLayout(False)
        Me.tabReplaceSID.PerformLayout()
        Me.tabRestoreSDDL.ResumeLayout(False)
        Me.tabRestoreSDDL.PerformLayout()
        Me.tabSettings.ResumeLayout(False)
        Me.tabSettings.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
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
    Friend WithEvents cmdReplaceSIDRun As System.Windows.Forms.Button
    Friend WithEvents txtBackupSDDLbckp As System.Windows.Forms.TextBox
    Friend WithEvents lblSaveSDDLBackup As System.Windows.Forms.Label
    Friend WithEvents cmdBackupSDDLbckp As System.Windows.Forms.Button
    Friend WithEvents cmdBackupSDDLRun As System.Windows.Forms.Button
    Friend WithEvents bgwBackupSDDL As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblBackupSDDLWhat As System.Windows.Forms.Label
    Friend WithEvents lblBackupSDDLCL As System.Windows.Forms.Label
    Friend WithEvents chkBackupSDDLoo As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkBackupSDDLi As System.Windows.Forms.CheckBox
    Friend WithEvents lblBackupSDDLs As System.Windows.Forms.Label
    Friend WithEvents chkBackupSDDLsacl As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupSDDLOwner As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupSDDLPrimaryGroup As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupSDDLdacl As System.Windows.Forms.CheckBox
    Friend WithEvents lblBackupSDDLon As System.Windows.Forms.Label
    Friend WithEvents txtBackupSDDLon As System.Windows.Forms.TextBox
    Friend WithEvents chkBackupSDDLobj As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupSDDLcont_obj As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupSDDLcont As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabSettings As System.Windows.Forms.TabPage
    Friend WithEvents lblRestoreSDDLon As System.Windows.Forms.Label
    Friend WithEvents txtRestoreSDDLon As System.Windows.Forms.TextBox
    Friend WithEvents cmdRestoreSDDLRun As System.Windows.Forms.Button
    Friend WithEvents txtRestoreSDDLbkcp As System.Windows.Forms.TextBox
    Friend WithEvents lblRestoreSDDLbkcp As System.Windows.Forms.Label
    Friend WithEvents cmdRestoreSDDLbkcp As System.Windows.Forms.Button
    Friend WithEvents txtSettingsSetACLLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblSettingsSetACLLocation As System.Windows.Forms.Label
    Friend WithEvents cmdSettingsSetACLLocation As System.Windows.Forms.Button
    Friend WithEvents chkBackupSDDLDisplaySIDno As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupSDDLDisplaySIDboth As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupSDDLDisplaySIDyes As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkBackupSDDLown As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupSDDLtab As System.Windows.Forms.CheckBox
    Friend WithEvents chkBackupSDDLsddl As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtListSIDinSDDLFile As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdFindSIDSDDL As System.Windows.Forms.Button
    Friend WithEvents cmdListAllSDFileRun As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCreateSDDLtoSIDFile As System.Windows.Forms.TextBox
    Friend WithEvents cmdCreateSDDLtoSIDFile As System.Windows.Forms.Button

End Class
