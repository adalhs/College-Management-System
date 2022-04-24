<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdmissionsEnterStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAddNewInfo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStudId = New System.Windows.Forms.Label()
        Me.btnUpdateStudent = New System.Windows.Forms.Button()
        Me.btnSearchStudId = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudentInfo = New System.Windows.Forms.TextBox()
        Me.ddlCovid = New System.Windows.Forms.ComboBox()
        Me.lblCovid = New System.Windows.Forms.Label()
        Me.ddlCountry = New System.Windows.Forms.ComboBox()
        Me.ddlState = New System.Windows.Forms.ComboBox()
        Me.txtZipcode = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblZipcode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.ddlSex = New System.Windows.Forms.ComboBox()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnSubmitInfo = New System.Windows.Forms.Button()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.ddlMajor = New System.Windows.Forms.ComboBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(1061, 544)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 47)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Information"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Dubai", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(20, 93)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(137, 42)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(504, 93)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(134, 42)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Last Name:"
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblMajor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblMajor.Location = New System.Drawing.Point(490, 419)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(84, 42)
        Me.lblMajor.TabIndex = 4
        Me.lblMajor.Text = "Major:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.btnAddNewInfo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblStudId)
        Me.Panel1.Controls.Add(Me.btnUpdateStudent)
        Me.Panel1.Controls.Add(Me.btnSearchStudId)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtStudentInfo)
        Me.Panel1.Controls.Add(Me.ddlCovid)
        Me.Panel1.Controls.Add(Me.lblCovid)
        Me.Panel1.Controls.Add(Me.ddlCountry)
        Me.Panel1.Controls.Add(Me.ddlState)
        Me.Panel1.Controls.Add(Me.txtZipcode)
        Me.Panel1.Controls.Add(Me.txtCity)
        Me.Panel1.Controls.Add(Me.lblCountry)
        Me.Panel1.Controls.Add(Me.lblZipcode)
        Me.Panel1.Controls.Add(Me.lblState)
        Me.Panel1.Controls.Add(Me.lblCity)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.ddlSex)
        Me.Panel1.Controls.Add(Me.lblSex)
        Me.Panel1.Controls.Add(Me.txtAge)
        Me.Panel1.Controls.Add(Me.lblAge)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblPhone)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.btnSubmitInfo)
        Me.Panel1.Controls.Add(Me.txtIncome)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.ddlMajor)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.lblIncome)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblMajor)
        Me.Panel1.Controls.Add(Me.lblFirstName)
        Me.Panel1.Controls.Add(Me.lblLastName)
        Me.Panel1.Location = New System.Drawing.Point(30, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 714)
        Me.Panel1.TabIndex = 5
        '
        'btnAddNewInfo
        '
        Me.btnAddNewInfo.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAddNewInfo.Location = New System.Drawing.Point(81, 544)
        Me.btnAddNewInfo.Name = "btnAddNewInfo"
        Me.btnAddNewInfo.Size = New System.Drawing.Size(136, 47)
        Me.btnAddNewInfo.TabIndex = 40
        Me.btnAddNewInfo.Text = "Add New"
        Me.btnAddNewInfo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(977, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "invisible until search loads an id"
        Me.Label3.Visible = False
        '
        'lblStudId
        '
        Me.lblStudId.AutoSize = True
        Me.lblStudId.Font = New System.Drawing.Font("Dubai", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblStudId.Location = New System.Drawing.Point(910, 13)
        Me.lblStudId.Name = "lblStudId"
        Me.lblStudId.Size = New System.Drawing.Size(355, 55)
        Me.lblStudId.TabIndex = 38
        Me.lblStudId.Text = "Student ID: M00522144"
        Me.lblStudId.Visible = False
        '
        'btnUpdateStudent
        '
        Me.btnUpdateStudent.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnUpdateStudent.Location = New System.Drawing.Point(821, 544)
        Me.btnUpdateStudent.Name = "btnUpdateStudent"
        Me.btnUpdateStudent.Size = New System.Drawing.Size(136, 47)
        Me.btnUpdateStudent.TabIndex = 37
        Me.btnUpdateStudent.Text = "Update"
        Me.btnUpdateStudent.UseVisualStyleBackColor = True
        '
        'btnSearchStudId
        '
        Me.btnSearchStudId.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchStudId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSearchStudId.Location = New System.Drawing.Point(578, 544)
        Me.btnSearchStudId.Name = "btnSearchStudId"
        Me.btnSearchStudId.Size = New System.Drawing.Size(136, 47)
        Me.btnSearchStudId.TabIndex = 36
        Me.btnSearchStudId.Text = "Search"
        Me.btnSearchStudId.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1037, 657)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Invisible textbox to store student info"
        Me.Label2.Visible = False
        '
        'txtStudentInfo
        '
        Me.txtStudentInfo.Location = New System.Drawing.Point(1082, 676)
        Me.txtStudentInfo.Multiline = True
        Me.txtStudentInfo.Name = "txtStudentInfo"
        Me.txtStudentInfo.Size = New System.Drawing.Size(100, 22)
        Me.txtStudentInfo.TabIndex = 34
        Me.txtStudentInfo.Visible = False
        '
        'ddlCovid
        '
        Me.ddlCovid.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlCovid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ddlCovid.FormattingEnabled = True
        Me.ddlCovid.Location = New System.Drawing.Point(1016, 418)
        Me.ddlCovid.Name = "ddlCovid"
        Me.ddlCovid.Size = New System.Drawing.Size(239, 42)
        Me.ddlCovid.TabIndex = 33
        '
        'lblCovid
        '
        Me.lblCovid.AutoSize = True
        Me.lblCovid.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblCovid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblCovid.Location = New System.Drawing.Point(893, 419)
        Me.lblCovid.Name = "lblCovid"
        Me.lblCovid.Size = New System.Drawing.Size(129, 42)
        Me.lblCovid.TabIndex = 32
        Me.lblCovid.Text = "COVID-19:"
        '
        'ddlCountry
        '
        Me.ddlCountry.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ddlCountry.FormattingEnabled = True
        Me.ddlCountry.Location = New System.Drawing.Point(991, 340)
        Me.ddlCountry.Name = "ddlCountry"
        Me.ddlCountry.Size = New System.Drawing.Size(264, 42)
        Me.ddlCountry.TabIndex = 30
        '
        'ddlState
        '
        Me.ddlState.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ddlState.FormattingEnabled = True
        Me.ddlState.Location = New System.Drawing.Point(403, 340)
        Me.ddlState.Name = "ddlState"
        Me.ddlState.Size = New System.Drawing.Size(215, 42)
        Me.ddlState.TabIndex = 29
        '
        'txtZipcode
        '
        Me.txtZipcode.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtZipcode.Location = New System.Drawing.Point(745, 341)
        Me.txtZipcode.Multiline = True
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.Size = New System.Drawing.Size(131, 43)
        Me.txtZipcode.TabIndex = 28
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtCity.Location = New System.Drawing.Point(72, 340)
        Me.txtCity.Multiline = True
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(245, 43)
        Me.txtCity.TabIndex = 27
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblCountry.Location = New System.Drawing.Point(893, 341)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(105, 42)
        Me.lblCountry.TabIndex = 26
        Me.lblCountry.Text = "Country:"
        '
        'lblZipcode
        '
        Me.lblZipcode.AutoSize = True
        Me.lblZipcode.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblZipcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblZipcode.Location = New System.Drawing.Point(640, 340)
        Me.lblZipcode.Name = "lblZipcode"
        Me.lblZipcode.Size = New System.Drawing.Size(114, 42)
        Me.lblZipcode.TabIndex = 25
        Me.lblZipcode.Text = "Zip Code:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblState.Location = New System.Drawing.Point(333, 341)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(79, 42)
        Me.lblState.TabIndex = 24
        Me.lblState.Text = "State:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblCity.Location = New System.Drawing.Point(20, 340)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(63, 42)
        Me.lblCity.TabIndex = 23
        Me.lblCity.Text = "City:"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(190, 258)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(1065, 43)
        Me.txtAddress.TabIndex = 22
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(20, 259)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(179, 42)
        Me.lblAddress.TabIndex = 21
        Me.lblAddress.Text = "Street Address:"
        '
        'ddlSex
        '
        Me.ddlSex.Font = New System.Drawing.Font("Dubai", 12.0!)
        Me.ddlSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ddlSex.FormattingEnabled = True
        Me.ddlSex.Location = New System.Drawing.Point(1050, 173)
        Me.ddlSex.Name = "ddlSex"
        Me.ddlSex.Size = New System.Drawing.Size(205, 42)
        Me.ddlSex.TabIndex = 20
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblSex.Location = New System.Drawing.Point(996, 174)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(60, 42)
        Me.lblSex.TabIndex = 18
        Me.lblSex.Text = "Sex:"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Dubai", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtAge.Location = New System.Drawing.Point(1050, 92)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 43)
        Me.txtAge.TabIndex = 17
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(993, 93)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(63, 42)
        Me.lblAge.TabIndex = 16
        Me.lblAge.Text = "Age:"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtPhone.Location = New System.Drawing.Point(627, 171)
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(320, 45)
        Me.txtPhone.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(92, 173)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(377, 43)
        Me.txtEmail.TabIndex = 14
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(504, 174)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(131, 42)
        Me.lblPhone.TabIndex = 13
        Me.lblPhone.Text = "Telephone:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(20, 173)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(80, 42)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "Email:"
        '
        'btnSubmitInfo
        '
        Me.btnSubmitInfo.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSubmitInfo.Location = New System.Drawing.Point(333, 544)
        Me.btnSubmitInfo.Name = "btnSubmitInfo"
        Me.btnSubmitInfo.Size = New System.Drawing.Size(136, 47)
        Me.btnSubmitInfo.TabIndex = 11
        Me.btnSubmitInfo.Text = "Submit"
        Me.btnSubmitInfo.UseVisualStyleBackColor = True
        '
        'txtIncome
        '
        Me.txtIncome.Font = New System.Drawing.Font("Dubai", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtIncome.Location = New System.Drawing.Point(326, 415)
        Me.txtIncome.Multiline = True
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(143, 44)
        Me.txtIncome.TabIndex = 10
        '
        'ddlMajor
        '
        Me.ddlMajor.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlMajor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ddlMajor.FormattingEnabled = True
        Me.ddlMajor.Location = New System.Drawing.Point(567, 418)
        Me.ddlMajor.Name = "ddlMajor"
        Me.ddlMajor.Size = New System.Drawing.Size(309, 42)
        Me.ddlMajor.TabIndex = 9
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Dubai", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(632, 92)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(315, 43)
        Me.txtLastName.TabIndex = 7
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirstName.Font = New System.Drawing.Font("Dubai", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(150, 92)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(319, 43)
        Me.txtFirstName.TabIndex = 6
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblIncome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblIncome.Location = New System.Drawing.Point(20, 418)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(310, 42)
        Me.lblIncome.TabIndex = 5
        Me.lblIncome.Text = "Yearly Household Income:  $"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(30, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1285, 97)
        Me.Panel2.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(196, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(587, 67)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Student Information Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ProyectoFinal.My.Resources.Resources.intermetro_logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 78)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'AdmissionsEnterStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(1348, 853)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AdmissionsEnterStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inter Metro Information System - Admissions Portal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblMajor As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblIncome As Label
    Friend WithEvents ddlMajor As ComboBox
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents btnSubmitInfo As Button
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ddlSex As ComboBox
    Friend WithEvents lblSex As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents ddlCountry As ComboBox
    Friend WithEvents ddlState As ComboBox
    Friend WithEvents txtZipcode As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblZipcode As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents ddlCovid As ComboBox
    Friend WithEvents lblCovid As Label
    Friend WithEvents txtStudentInfo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUpdateStudent As Button
    Friend WithEvents btnSearchStudId As Button
    Friend WithEvents lblStudId As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddNewInfo As Button
End Class
