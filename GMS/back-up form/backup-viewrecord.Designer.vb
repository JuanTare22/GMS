<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backup_viewrecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(backup_viewrecord))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCCemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblIT = New GMS.tblIT()
        Me.btnDash = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TblITTableAdapter = New GMS.tblITTableAdapters.tblITTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn1st = New System.Windows.Forms.Button()
        Me.btn4th = New System.Windows.Forms.Button()
        Me.btn3rd = New System.Windows.Forms.Button()
        Me.btn2nd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tools = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.txtCCCemail = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.txtSnum = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddd = New System.Windows.Forms.Button()
        Me.btnRegular = New System.Windows.Forms.Button()
        Me.btnWorking = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GMSDataSet = New GMS.GMSDataSet()
        Me.GMSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        CType(Me.GMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(-10, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(202, 60)
        Me.Button2.TabIndex = 0
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentNumberDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.CCCemailDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.YearLevelDataGridViewTextBoxColumn, Me.SectionDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblITBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(191, 143)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(631, 327)
        Me.DataGridView1.TabIndex = 15
        '
        'StudentNumberDataGridViewTextBoxColumn
        '
        Me.StudentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.Name = "StudentNumberDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'CCCemailDataGridViewTextBoxColumn
        '
        Me.CCCemailDataGridViewTextBoxColumn.DataPropertyName = "CCCemail"
        Me.CCCemailDataGridViewTextBoxColumn.HeaderText = "CCCemail"
        Me.CCCemailDataGridViewTextBoxColumn.Name = "CCCemailDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'YearLevelDataGridViewTextBoxColumn
        '
        Me.YearLevelDataGridViewTextBoxColumn.DataPropertyName = "YearLevel"
        Me.YearLevelDataGridViewTextBoxColumn.HeaderText = "YearLevel"
        Me.YearLevelDataGridViewTextBoxColumn.Name = "YearLevelDataGridViewTextBoxColumn"
        '
        'SectionDataGridViewTextBoxColumn
        '
        Me.SectionDataGridViewTextBoxColumn.DataPropertyName = "Section"
        Me.SectionDataGridViewTextBoxColumn.HeaderText = "Section"
        Me.SectionDataGridViewTextBoxColumn.Name = "SectionDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'TblITBindingSource
        '
        Me.TblITBindingSource.DataMember = "tblIT"
        Me.TblITBindingSource.DataSource = Me.TblIT
        '
        'TblIT
        '
        Me.TblIT.DataSetName = "tblIT"
        Me.TblIT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'cmbStatus
        '
        Me.cmbStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblITBindingSource, "Status", True))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Regular", "Irregular", "Working"})
        Me.cmbStatus.Location = New System.Drawing.Point(144, 252)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(133, 21)
        Me.cmbStatus.TabIndex = 3
        Me.cmbStatus.Text = "Select Status"
        '
        'cmbGender
        '
        Me.cmbGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblITBindingSource, "Gender", True))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cmbGender.Location = New System.Drawing.Point(144, 172)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(133, 21)
        Me.cmbGender.TabIndex = 3
        Me.cmbGender.Text = "Select Gender"
        '
        'cmbYear
        '
        Me.cmbYear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblITBindingSource, "YearLevel", True))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year"})
        Me.cmbYear.Location = New System.Drawing.Point(144, 199)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(133, 21)
        Me.cmbYear.TabIndex = 3
        Me.cmbYear.Text = "Select Year Level"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(25, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Student Number"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(25, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Status"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(25, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Section"
        '
        'TblITTableAdapter
        '
        Me.TblITTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn1st)
        Me.GroupBox2.Controls.Add(Me.btn4th)
        Me.GroupBox2.Controls.Add(Me.btn3rd)
        Me.GroupBox2.Controls.Add(Me.btn2nd)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(447, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 40)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'btn1st
        '
        Me.btn1st.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn1st.Location = New System.Drawing.Point(6, 12)
        Me.btn1st.Name = "btn1st"
        Me.btn1st.Size = New System.Drawing.Size(55, 23)
        Me.btn1st.TabIndex = 1
        Me.btn1st.Text = "1st"
        Me.btn1st.UseVisualStyleBackColor = True
        '
        'btn4th
        '
        Me.btn4th.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn4th.Location = New System.Drawing.Point(189, 12)
        Me.btn4th.Name = "btn4th"
        Me.btn4th.Size = New System.Drawing.Size(55, 23)
        Me.btn4th.TabIndex = 1
        Me.btn4th.Text = "4th"
        Me.btn4th.UseVisualStyleBackColor = True
        '
        'btn3rd
        '
        Me.btn3rd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn3rd.Location = New System.Drawing.Point(128, 12)
        Me.btn3rd.Name = "btn3rd"
        Me.btn3rd.Size = New System.Drawing.Size(55, 23)
        Me.btn3rd.TabIndex = 1
        Me.btn3rd.Text = "3rd"
        Me.btn3rd.UseVisualStyleBackColor = True
        '
        'btn2nd
        '
        Me.btn2nd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn2nd.Location = New System.Drawing.Point(67, 12)
        Me.btn2nd.Name = "btn2nd"
        Me.btn2nd.Size = New System.Drawing.Size(55, 23)
        Me.btn2nd.TabIndex = 1
        Me.btn2nd.Text = "2nd"
        Me.btn2nd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(96, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Year Level"
        '
        'btnAdd
        '
        Me.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdd.Location = New System.Drawing.Point(7, 45)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'Tools
        '
        Me.Tools.AutoSize = True
        Me.Tools.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Tools.Location = New System.Drawing.Point(109, 0)
        Me.Tools.Name = "Tools"
        Me.Tools.Size = New System.Drawing.Size(33, 13)
        Me.Tools.TabIndex = 0
        Me.Tools.Text = "Tools"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(25, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(25, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Year Level"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(25, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "CCC Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(25, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(25, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(25, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "First Name"
        '
        'btnDelete
        '
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(169, 45)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(88, 45)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtSection
        '
        Me.txtSection.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblITBindingSource, "Section", True))
        Me.txtSection.Location = New System.Drawing.Point(144, 226)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(133, 20)
        Me.txtSection.TabIndex = 1
        '
        'txtCCCemail
        '
        Me.txtCCCemail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblITBindingSource, "CCCemail", True))
        Me.txtCCCemail.Location = New System.Drawing.Point(144, 146)
        Me.txtCCCemail.Name = "txtCCCemail"
        Me.txtCCCemail.Size = New System.Drawing.Size(133, 20)
        Me.txtCCCemail.TabIndex = 1
        '
        'txtMname
        '
        Me.txtMname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblITBindingSource, "MiddleName", True))
        Me.txtMname.Location = New System.Drawing.Point(144, 94)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(133, 20)
        Me.txtMname.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(56, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(185, 20)
        Me.TextBox1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Tools)
        Me.GroupBox1.Location = New System.Drawing.Point(191, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 82)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'txtLname
        '
        Me.txtLname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblITBindingSource, "LastName", True))
        Me.txtLname.Location = New System.Drawing.Point(144, 120)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(133, 20)
        Me.txtLname.TabIndex = 1
        '
        'txtFname
        '
        Me.txtFname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblITBindingSource, "FirstName", True))
        Me.txtFname.Location = New System.Drawing.Point(144, 68)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(133, 20)
        Me.txtFname.TabIndex = 1
        '
        'pnlInfo
        '
        Me.pnlInfo.Controls.Add(Me.cmbStatus)
        Me.pnlInfo.Controls.Add(Me.cmbGender)
        Me.pnlInfo.Controls.Add(Me.cmbYear)
        Me.pnlInfo.Controls.Add(Me.Label5)
        Me.pnlInfo.Controls.Add(Me.Label12)
        Me.pnlInfo.Controls.Add(Me.Label10)
        Me.pnlInfo.Controls.Add(Me.Label11)
        Me.pnlInfo.Controls.Add(Me.Label9)
        Me.pnlInfo.Controls.Add(Me.Label8)
        Me.pnlInfo.Controls.Add(Me.Label7)
        Me.pnlInfo.Controls.Add(Me.Label6)
        Me.pnlInfo.Controls.Add(Me.Label4)
        Me.pnlInfo.Controls.Add(Me.txtSection)
        Me.pnlInfo.Controls.Add(Me.txtCCCemail)
        Me.pnlInfo.Controls.Add(Me.txtLname)
        Me.pnlInfo.Controls.Add(Me.txtMname)
        Me.pnlInfo.Controls.Add(Me.txtFname)
        Me.pnlInfo.Controls.Add(Me.txtSnum)
        Me.pnlInfo.Controls.Add(Me.btnCancel)
        Me.pnlInfo.Controls.Add(Me.btnAddd)
        Me.pnlInfo.Location = New System.Drawing.Point(523, 55)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(303, 315)
        Me.pnlInfo.TabIndex = 19
        '
        'txtSnum
        '
        Me.txtSnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblITBindingSource, "StudentNumber", True))
        Me.txtSnum.Location = New System.Drawing.Point(144, 42)
        Me.txtSnum.Name = "txtSnum"
        Me.txtSnum.Size = New System.Drawing.Size(133, 20)
        Me.txtSnum.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancel.Location = New System.Drawing.Point(154, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 25)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddd
        '
        Me.btnAddd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddd.Location = New System.Drawing.Point(38, 9)
        Me.btnAddd.Name = "btnAddd"
        Me.btnAddd.Size = New System.Drawing.Size(110, 25)
        Me.btnAddd.TabIndex = 0
        Me.btnAddd.Text = "Add Data"
        Me.btnAddd.UseVisualStyleBackColor = True
        '
        'btnRegular
        '
        Me.btnRegular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRegular.Location = New System.Drawing.Point(8, 12)
        Me.btnRegular.Name = "btnRegular"
        Me.btnRegular.Size = New System.Drawing.Size(74, 23)
        Me.btnRegular.TabIndex = 1
        Me.btnRegular.Text = "Regular"
        Me.btnRegular.UseVisualStyleBackColor = True
        '
        'btnWorking
        '
        Me.btnWorking.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnWorking.Location = New System.Drawing.Point(88, 12)
        Me.btnWorking.Name = "btnWorking"
        Me.btnWorking.Size = New System.Drawing.Size(74, 23)
        Me.btnWorking.TabIndex = 1
        Me.btnWorking.Text = "Irregular"
        Me.btnWorking.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button13.Location = New System.Drawing.Point(168, 12)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(74, 23)
        Me.Button13.TabIndex = 1
        Me.Button13.Text = "Working"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(87, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student Status"
        '
        'GMSDataSet
        '
        Me.GMSDataSet.DataSetName = "GMSDataSet"
        Me.GMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GMSDataSetBindingSource
        '
        Me.GMSDataSetBindingSource.DataSource = Me.GMSDataSet
        Me.GMSDataSetBindingSource.Position = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRegular)
        Me.GroupBox3.Controls.Add(Me.btnWorking)
        Me.GroupBox3.Controls.Add(Me.Button13)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(447, 97)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(250, 40)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 49)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnDash)
        Me.Panel2.ForeColor = System.Drawing.Color.Transparent
        Me.Panel2.Location = New System.Drawing.Point(1, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 473)
        Me.Panel2.TabIndex = 14
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(-10, 307)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(202, 60)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = False
        '
        'backup_viewrecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(826, 477)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "backup_viewrecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "backup_viewrecord"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        CType(Me.GMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CCCemailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblITBindingSource As BindingSource
    Friend WithEvents TblIT As tblIT
    Friend WithEvents btnDash As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TblITTableAdapter As tblITTableAdapters.tblITTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn1st As Button
    Friend WithEvents btn4th As Button
    Friend WithEvents btn3rd As Button
    Friend WithEvents btn2nd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Tools As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSection As TextBox
    Friend WithEvents txtCCCemail As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents txtSnum As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddd As Button
    Friend WithEvents btnRegular As Button
    Friend WithEvents btnWorking As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GMSDataSet As GMSDataSet
    Friend WithEvents GMSDataSetBindingSource As BindingSource
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
End Class
