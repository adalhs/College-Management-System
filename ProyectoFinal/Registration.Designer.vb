<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registration
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
        Me.lblEnrolled = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInformation = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnOpenRecord = New System.Windows.Forms.Button()
        Me.lblPersonInfo = New System.Windows.Forms.Label()
        Me.btnChangeMajor = New System.Windows.Forms.Button()
        Me.btnDropCourse = New System.Windows.Forms.Button()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.ddlEnrolled = New System.Windows.Forms.ComboBox()
        Me.ddlMajor = New System.Windows.Forms.ComboBox()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.btnCloseRecord = New System.Windows.Forms.Button()
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
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(35, 551)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(296, 47)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Record Actions"
        '
        'lblEnrolled
        '
        Me.lblEnrolled.AutoSize = True
        Me.lblEnrolled.Font = New System.Drawing.Font("Dubai", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrolled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblEnrolled.Location = New System.Drawing.Point(446, 176)
        Me.lblEnrolled.Name = "lblEnrolled"
        Me.lblEnrolled.Size = New System.Drawing.Size(198, 42)
        Me.lblEnrolled.TabIndex = 2
        Me.lblEnrolled.Text = "Enrolled Courses:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtInformation)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.btnOpenRecord)
        Me.Panel1.Controls.Add(Me.lblPersonInfo)
        Me.Panel1.Controls.Add(Me.btnChangeMajor)
        Me.Panel1.Controls.Add(Me.btnDropCourse)
        Me.Panel1.Controls.Add(Me.btnAddCourse)
        Me.Panel1.Controls.Add(Me.ddlEnrolled)
        Me.Panel1.Controls.Add(Me.ddlMajor)
        Me.Panel1.Controls.Add(Me.lblMajor)
        Me.Panel1.Controls.Add(Me.btnCloseRecord)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblEnrolled)
        Me.Panel1.Location = New System.Drawing.Point(30, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 714)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(915, 650)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(357, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "invisible textbox to hold info to pass to FormCustomMsgBox"
        Me.Label2.Visible = False
        '
        'txtInformation
        '
        Me.txtInformation.Location = New System.Drawing.Point(1052, 669)
        Me.txtInformation.Name = "txtInformation"
        Me.txtInformation.Size = New System.Drawing.Size(100, 22)
        Me.txtInformation.TabIndex = 43
        Me.txtInformation.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(965, 521)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 47)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(450, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "invisible until search loads information"
        Me.Label3.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSubmit.Location = New System.Drawing.Point(676, 521)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(127, 47)
        Me.btnSubmit.TabIndex = 41
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnOpenRecord
        '
        Me.btnOpenRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenRecord.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenRecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnOpenRecord.Location = New System.Drawing.Point(35, 114)
        Me.btnOpenRecord.Name = "btnOpenRecord"
        Me.btnOpenRecord.Size = New System.Drawing.Size(296, 47)
        Me.btnOpenRecord.TabIndex = 40
        Me.btnOpenRecord.Text = "Open Record"
        Me.btnOpenRecord.UseVisualStyleBackColor = True
        '
        'lblPersonInfo
        '
        Me.lblPersonInfo.AutoSize = True
        Me.lblPersonInfo.Font = New System.Drawing.Font("Dubai", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblPersonInfo.Location = New System.Drawing.Point(443, 13)
        Me.lblPersonInfo.Name = "lblPersonInfo"
        Me.lblPersonInfo.Size = New System.Drawing.Size(217, 55)
        Me.lblPersonInfo.TabIndex = 38
        Me.lblPersonInfo.Text = "ID Placeholder"
        Me.lblPersonInfo.Visible = False
        '
        'btnChangeMajor
        '
        Me.btnChangeMajor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeMajor.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeMajor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnChangeMajor.Location = New System.Drawing.Point(35, 462)
        Me.btnChangeMajor.Name = "btnChangeMajor"
        Me.btnChangeMajor.Size = New System.Drawing.Size(296, 47)
        Me.btnChangeMajor.TabIndex = 36
        Me.btnChangeMajor.Text = "Change Major"
        Me.btnChangeMajor.UseVisualStyleBackColor = True
        '
        'btnDropCourse
        '
        Me.btnDropCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDropCourse.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDropCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnDropCourse.Location = New System.Drawing.Point(35, 376)
        Me.btnDropCourse.Name = "btnDropCourse"
        Me.btnDropCourse.Size = New System.Drawing.Size(296, 47)
        Me.btnDropCourse.TabIndex = 36
        Me.btnDropCourse.Text = "Drop Course"
        Me.btnDropCourse.UseVisualStyleBackColor = True
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCourse.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAddCourse.Location = New System.Drawing.Point(35, 287)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(296, 47)
        Me.btnAddCourse.TabIndex = 36
        Me.btnAddCourse.Text = "Add Course"
        Me.btnAddCourse.UseVisualStyleBackColor = True
        '
        'ddlEnrolled
        '
        Me.ddlEnrolled.Font = New System.Drawing.Font("Dubai", 12.0!)
        Me.ddlEnrolled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ddlEnrolled.FormattingEnabled = True
        Me.ddlEnrolled.Location = New System.Drawing.Point(637, 176)
        Me.ddlEnrolled.Name = "ddlEnrolled"
        Me.ddlEnrolled.Size = New System.Drawing.Size(615, 42)
        Me.ddlEnrolled.TabIndex = 20
        '
        'ddlMajor
        '
        Me.ddlMajor.Font = New System.Drawing.Font("Dubai", 12.0!)
        Me.ddlMajor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ddlMajor.FormattingEnabled = True
        Me.ddlMajor.Location = New System.Drawing.Point(637, 332)
        Me.ddlMajor.Name = "ddlMajor"
        Me.ddlMajor.Size = New System.Drawing.Size(615, 42)
        Me.ddlMajor.TabIndex = 20
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Dubai", 15.0!)
        Me.lblMajor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblMajor.Location = New System.Drawing.Point(560, 332)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(84, 42)
        Me.lblMajor.TabIndex = 18
        Me.lblMajor.Text = "Major:"
        '
        'btnCloseRecord
        '
        Me.btnCloseRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseRecord.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseRecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnCloseRecord.Location = New System.Drawing.Point(35, 198)
        Me.btnCloseRecord.Name = "btnCloseRecord"
        Me.btnCloseRecord.Size = New System.Drawing.Size(296, 47)
        Me.btnCloseRecord.TabIndex = 11
        Me.btnCloseRecord.Text = "Close Record"
        Me.btnCloseRecord.UseVisualStyleBackColor = True
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
        Me.Label8.Size = New System.Drawing.Size(508, 67)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Student Record Management"
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
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(1348, 853)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InterMetro Information System - Accounts Administration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEnrolled As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCloseRecord As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ddlMajor As ComboBox
    Friend WithEvents lblMajor As Label
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents lblPersonInfo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOpenRecord As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnChangeMajor As Button
    Friend WithEvents btnDropCourse As Button
    Friend WithEvents ddlEnrolled As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInformation As TextBox
End Class
