<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArchive
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArchive))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CheckBoxSearchbySnum = New System.Windows.Forms.CheckBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbComm = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh1 = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtSnum = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddd = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSM = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnPVE = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnSW = New System.Windows.Forms.Button()
        Me.ContextMenuStripEditor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnarch = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnDash = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ContextMenuStripEditor.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBoxSearchbySnum
        '
        Me.CheckBoxSearchbySnum.AutoSize = True
        Me.CheckBoxSearchbySnum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBoxSearchbySnum.Location = New System.Drawing.Point(9, 46)
        Me.CheckBoxSearchbySnum.Name = "CheckBoxSearchbySnum"
        Me.CheckBoxSearchbySnum.Size = New System.Drawing.Size(154, 17)
        Me.CheckBoxSearchbySnum.TabIndex = 3
        Me.CheckBoxSearchbySnum.Text = "Search by Student Number"
        Me.CheckBoxSearchbySnum.UseVisualStyleBackColor = True
        Me.CheckBoxSearchbySnum.Visible = False
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"- choose gender -", "Female", "Male"})
        Me.cmbGender.Location = New System.Drawing.Point(115, 198)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(179, 21)
        Me.cmbGender.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(67, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'cmbComm
        '
        Me.cmbComm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbComm.FormattingEnabled = True
        Me.cmbComm.Items.AddRange(New Object() {"- choose committee -", "Script Writing", "Directing", "Artist", "Layout", "Photo and Video Editing", "Social Media"})
        Me.cmbComm.Location = New System.Drawing.Point(115, 225)
        Me.cmbComm.Name = "cmbComm"
        Me.cmbComm.Size = New System.Drawing.Size(179, 21)
        Me.cmbComm.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(21, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(21, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Committee"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1093, 23)
        Me.Panel1.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Archive"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.LightBlue
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 24)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(392, 29)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(34, 16)
        Me.lblDate.TabIndex = 40
        Me.lblDate.Text = "date"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnRefresh1)
        Me.GroupBox4.Controls.Add(Me.btnRestore)
        Me.GroupBox4.Controls.Add(Me.btnDelete)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Location = New System.Drawing.Point(371, 55)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(218, 82)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        '
        'btnRefresh1
        '
        Me.btnRefresh1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRefresh1.Location = New System.Drawing.Point(145, 20)
        Me.btnRefresh1.Name = "btnRefresh1"
        Me.btnRefresh1.Size = New System.Drawing.Size(66, 48)
        Me.btnRefresh1.TabIndex = 2
        Me.btnRefresh1.Text = "Refresh"
        Me.btnRefresh1.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRestore.Location = New System.Drawing.Point(75, 20)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(64, 48)
        Me.btnRestore.TabIndex = 4
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(6, 20)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(63, 48)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(93, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Tools"
        '
        'pnlInfo
        '
        Me.pnlInfo.Controls.Add(Me.DateTimePicker1)
        Me.pnlInfo.Controls.Add(Me.cmbGender)
        Me.pnlInfo.Controls.Add(Me.cmbComm)
        Me.pnlInfo.Controls.Add(Me.Label5)
        Me.pnlInfo.Controls.Add(Me.Label11)
        Me.pnlInfo.Controls.Add(Me.Label9)
        Me.pnlInfo.Controls.Add(Me.Label8)
        Me.pnlInfo.Controls.Add(Me.Label3)
        Me.pnlInfo.Controls.Add(Me.Label7)
        Me.pnlInfo.Controls.Add(Me.Label6)
        Me.pnlInfo.Controls.Add(Me.Label4)
        Me.pnlInfo.Controls.Add(Me.txtAge)
        Me.pnlInfo.Controls.Add(Me.txtLname)
        Me.pnlInfo.Controls.Add(Me.txtMname)
        Me.pnlInfo.Controls.Add(Me.txtFname)
        Me.pnlInfo.Controls.Add(Me.txtSnum)
        Me.pnlInfo.Controls.Add(Me.btnCancel)
        Me.pnlInfo.Controls.Add(Me.btnAddd)
        Me.pnlInfo.Location = New System.Drawing.Point(595, 29)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(303, 341)
        Me.pnlInfo.TabIndex = 38
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 146)
        Me.DateTimePicker1.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(179, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(21, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Student Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(21, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Birthday"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(21, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Age"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(21, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(21, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(21, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "First Name"
        '
        'txtAge
        '
        Me.txtAge.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAge.Enabled = False
        Me.txtAge.Location = New System.Drawing.Point(115, 172)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(179, 20)
        Me.txtAge.TabIndex = 1
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(115, 120)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(179, 20)
        Me.txtLname.TabIndex = 1
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(115, 94)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(179, 20)
        Me.txtMname.TabIndex = 1
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(115, 68)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(179, 20)
        Me.txtFname.TabIndex = 1
        '
        'txtSnum
        '
        Me.txtSnum.Location = New System.Drawing.Point(115, 42)
        Me.txtSnum.Name = "txtSnum"
        Me.txtSnum.Size = New System.Drawing.Size(179, 20)
        Me.txtSnum.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancel.Location = New System.Drawing.Point(154, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 25)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnAddd
        '
        Me.btnAddd.Enabled = False
        Me.btnAddd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddd.Location = New System.Drawing.Point(38, 9)
        Me.btnAddd.Name = "btnAddd"
        Me.btnAddd.Size = New System.Drawing.Size(110, 25)
        Me.btnAddd.TabIndex = 0
        Me.btnAddd.Text = "Add Data"
        Me.btnAddd.UseVisualStyleBackColor = True
        Me.btnAddd.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(417, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(16, 20)
        Me.TextBox3.TabIndex = 42
        Me.TextBox3.Text = "0"
        Me.TextBox3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(395, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(16, 20)
        Me.TextBox2.TabIndex = 41
        Me.TextBox2.Text = "1"
        Me.TextBox2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxSearchbySnum)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(190, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 81)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 20)
        Me.TextBox1.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnSM)
        Me.GroupBox3.Controls.Add(Me.btnA)
        Me.GroupBox3.Controls.Add(Me.btnPVE)
        Me.GroupBox3.Controls.Add(Me.btnD)
        Me.GroupBox3.Controls.Add(Me.btnL)
        Me.GroupBox3.Controls.Add(Me.btnSW)
        Me.GroupBox3.Location = New System.Drawing.Point(595, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 107)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(119, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Committee"
        '
        'btnSM
        '
        Me.btnSM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSM.Location = New System.Drawing.Point(193, 57)
        Me.btnSM.Name = "btnSM"
        Me.btnSM.Size = New System.Drawing.Size(79, 37)
        Me.btnSM.TabIndex = 1
        Me.btnSM.Text = "Social Media"
        Me.btnSM.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnA.Location = New System.Drawing.Point(193, 12)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(79, 39)
        Me.btnA.TabIndex = 1
        Me.btnA.Text = "Artist"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnPVE
        '
        Me.btnPVE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPVE.Location = New System.Drawing.Point(108, 57)
        Me.btnPVE.Name = "btnPVE"
        Me.btnPVE.Size = New System.Drawing.Size(79, 37)
        Me.btnPVE.TabIndex = 1
        Me.btnPVE.Text = "Photo and Video Editing"
        Me.btnPVE.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnD.Location = New System.Drawing.Point(108, 12)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(79, 39)
        Me.btnD.TabIndex = 1
        Me.btnD.Text = "Directing"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnL
        '
        Me.btnL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnL.Location = New System.Drawing.Point(23, 57)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(79, 37)
        Me.btnL.TabIndex = 1
        Me.btnL.Text = "Layout"
        Me.btnL.UseVisualStyleBackColor = True
        '
        'btnSW
        '
        Me.btnSW.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSW.Location = New System.Drawing.Point(23, 12)
        Me.btnSW.Name = "btnSW"
        Me.btnSW.Size = New System.Drawing.Size(79, 39)
        Me.btnSW.TabIndex = 1
        Me.btnSW.Text = "ScriptWriting"
        Me.btnSW.UseVisualStyleBackColor = True
        '
        'ContextMenuStripEditor
        '
        Me.ContextMenuStripEditor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.RestoreToolStripMenuItem, Me.SelectAllToolStripMenuItem})
        Me.ContextMenuStripEditor.Name = "ContextMenuStripEditor"
        Me.ContextMenuStripEditor.Size = New System.Drawing.Size(123, 70)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTime.Location = New System.Drawing.Point(187, 26)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(32, 16)
        Me.lblTime.TabIndex = 39
        Me.lblTime.Text = "time"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStripEditor
        Me.DataGridView1.Location = New System.Drawing.Point(190, 143)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(701, 351)
        Me.DataGridView1.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btnarch)
        Me.Panel2.Controls.Add(Me.btnRecord)
        Me.Panel2.Controls.Add(Me.btnDash)
        Me.Panel2.ForeColor = System.Drawing.Color.Transparent
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 473)
        Me.Panel2.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(35, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnarch
        '
        Me.btnarch.BackColor = System.Drawing.Color.Silver
        Me.btnarch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnarch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnarch.ForeColor = System.Drawing.Color.Black
        Me.btnarch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnarch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnarch.Location = New System.Drawing.Point(-10, 307)
        Me.btnarch.Name = "btnarch"
        Me.btnarch.Size = New System.Drawing.Size(202, 60)
        Me.btnarch.TabIndex = 0
        Me.btnarch.Text = "ARCHIVE"
        Me.btnarch.UseVisualStyleBackColor = False
        Me.btnarch.Visible = False
        '
        'btnRecord
        '
        Me.btnRecord.BackColor = System.Drawing.Color.Transparent
        Me.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecord.ForeColor = System.Drawing.Color.Transparent
        Me.btnRecord.Image = CType(resources.GetObject("btnRecord.Image"), System.Drawing.Image)
        Me.btnRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRecord.Location = New System.Drawing.Point(-10, 241)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(202, 60)
        Me.btnRecord.TabIndex = 0
        Me.btnRecord.UseVisualStyleBackColor = False
        '
        'btnDash
        '
        Me.btnDash.BackColor = System.Drawing.Color.Transparent
        Me.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDash.ForeColor = System.Drawing.Color.Transparent
        Me.btnDash.Image = CType(resources.GetObject("btnDash.Image"), System.Drawing.Image)
        Me.btnDash.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDash.Location = New System.Drawing.Point(-10, 175)
        Me.btnDash.Name = "btnDash"
        Me.btnDash.Size = New System.Drawing.Size(202, 60)
        Me.btnDash.TabIndex = 0
        Me.btnDash.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 5000
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(190, 143)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(701, 333)
        Me.DataGridView2.TabIndex = 43
        '
        'frmArchive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(894, 475)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "frmArchive"
        Me.Text = "frmArchive"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ContextMenuStripEditor.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxSearchbySnum As CheckBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbComm As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnRefresh1 As Button
    Friend WithEvents btnRestore As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtSnum As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddd As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSM As Button
    Friend WithEvents btnA As Button
    Friend WithEvents btnPVE As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnL As Button
    Friend WithEvents btnSW As Button
    Friend WithEvents ContextMenuStripEditor As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTime As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnarch As Button
    Friend WithEvents btnRecord As Button
    Friend WithEvents btnDash As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
    Friend WithEvents DataGridView2 As DataGridView
End Class
