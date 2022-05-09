<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Faculty
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
        Me.ddlAssignedSections = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInformation = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAW = New System.Windows.Forms.Button()
        Me.btnFinalGrade = New System.Windows.Forms.Button()
        Me.btnEnterGrade = New System.Windows.Forms.Button()
        Me.lblStudentInfo = New System.Windows.Forms.Label()
        Me.btnLoadDetail = New System.Windows.Forms.Button()
        Me.btnLoadSection = New System.Windows.Forms.Button()
        Me.ddlEnrolled = New System.Windows.Forms.ComboBox()
        Me.ddlGradeDetail = New System.Windows.Forms.ComboBox()
        Me.lblGradeDetail = New System.Windows.Forms.Label()
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
        Me.btnExit.Location = New System.Drawing.Point(35, 485)
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
        Me.Label1.Size = New System.Drawing.Size(297, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Instructor's Courses"
        '
        'lblEnrolled
        '
        Me.lblEnrolled.AutoSize = True
        Me.lblEnrolled.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnrolled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblEnrolled.Location = New System.Drawing.Point(563, 132)
        Me.lblEnrolled.Name = "lblEnrolled"
        Me.lblEnrolled.Size = New System.Drawing.Size(163, 34)
        Me.lblEnrolled.TabIndex = 2
        Me.lblEnrolled.Text = "Enrolled Students:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.ddlAssignedSections)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtInformation)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnAW)
        Me.Panel1.Controls.Add(Me.btnFinalGrade)
        Me.Panel1.Controls.Add(Me.btnEnterGrade)
        Me.Panel1.Controls.Add(Me.lblStudentInfo)
        Me.Panel1.Controls.Add(Me.btnLoadDetail)
        Me.Panel1.Controls.Add(Me.btnLoadSection)
        Me.Panel1.Controls.Add(Me.ddlEnrolled)
        Me.Panel1.Controls.Add(Me.ddlGradeDetail)
        Me.Panel1.Controls.Add(Me.lblGradeDetail)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblEnrolled)
        Me.Panel1.Location = New System.Drawing.Point(30, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 714)
        Me.Panel1.TabIndex = 5
        '
        'ddlAssignedSections
        '
        Me.ddlAssignedSections.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlAssignedSections.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ddlAssignedSections.FormattingEnabled = True
        Me.ddlAssignedSections.Location = New System.Drawing.Point(35, 126)
        Me.ddlAssignedSections.Name = "ddlAssignedSections"
        Me.ddlAssignedSections.Size = New System.Drawing.Size(486, 42)
        Me.ddlAssignedSections.TabIndex = 45
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
        Me.btnCancel.Location = New System.Drawing.Point(1107, 521)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(156, 47)
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
        'btnAW
        '
        Me.btnAW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAW.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAW.Location = New System.Drawing.Point(936, 521)
        Me.btnAW.Name = "btnAW"
        Me.btnAW.Size = New System.Drawing.Size(156, 47)
        Me.btnAW.TabIndex = 41
        Me.btnAW.Text = "Enter AW"
        Me.btnAW.UseVisualStyleBackColor = True
        '
        'btnFinalGrade
        '
        Me.btnFinalGrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalGrade.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalGrade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnFinalGrade.Location = New System.Drawing.Point(764, 521)
        Me.btnFinalGrade.Name = "btnFinalGrade"
        Me.btnFinalGrade.Size = New System.Drawing.Size(156, 47)
        Me.btnFinalGrade.TabIndex = 41
        Me.btnFinalGrade.Text = "Final Grade"
        Me.btnFinalGrade.UseVisualStyleBackColor = True
        '
        'btnEnterGrade
        '
        Me.btnEnterGrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnterGrade.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterGrade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEnterGrade.Location = New System.Drawing.Point(588, 521)
        Me.btnEnterGrade.Name = "btnEnterGrade"
        Me.btnEnterGrade.Size = New System.Drawing.Size(156, 47)
        Me.btnEnterGrade.TabIndex = 41
        Me.btnEnterGrade.Text = "Enter Grade"
        Me.btnEnterGrade.UseVisualStyleBackColor = True
        '
        'lblStudentInfo
        '
        Me.lblStudentInfo.AutoSize = True
        Me.lblStudentInfo.Font = New System.Drawing.Font("Dubai", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblStudentInfo.Location = New System.Drawing.Point(443, 13)
        Me.lblStudentInfo.Name = "lblStudentInfo"
        Me.lblStudentInfo.Size = New System.Drawing.Size(217, 55)
        Me.lblStudentInfo.TabIndex = 38
        Me.lblStudentInfo.Text = "ID Placeholder"
        Me.lblStudentInfo.Visible = False
        '
        'btnLoadDetail
        '
        Me.btnLoadDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadDetail.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnLoadDetail.Location = New System.Drawing.Point(833, 218)
        Me.btnLoadDetail.Name = "btnLoadDetail"
        Me.btnLoadDetail.Size = New System.Drawing.Size(296, 47)
        Me.btnLoadDetail.TabIndex = 36
        Me.btnLoadDetail.Text = "Load Student Grade Detail"
        Me.btnLoadDetail.UseVisualStyleBackColor = True
        '
        'btnLoadSection
        '
        Me.btnLoadSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSection.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnLoadSection.Location = New System.Drawing.Point(35, 390)
        Me.btnLoadSection.Name = "btnLoadSection"
        Me.btnLoadSection.Size = New System.Drawing.Size(296, 47)
        Me.btnLoadSection.TabIndex = 36
        Me.btnLoadSection.Text = "Load Section"
        Me.btnLoadSection.UseVisualStyleBackColor = True
        '
        'ddlEnrolled
        '
        Me.ddlEnrolled.Font = New System.Drawing.Font("Dubai", 12.0!)
        Me.ddlEnrolled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ddlEnrolled.FormattingEnabled = True
        Me.ddlEnrolled.Location = New System.Drawing.Point(723, 126)
        Me.ddlEnrolled.Name = "ddlEnrolled"
        Me.ddlEnrolled.Size = New System.Drawing.Size(529, 42)
        Me.ddlEnrolled.TabIndex = 20
        '
        'ddlGradeDetail
        '
        Me.ddlGradeDetail.Font = New System.Drawing.Font("Dubai", 12.0!)
        Me.ddlGradeDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ddlGradeDetail.FormattingEnabled = True
        Me.ddlGradeDetail.Location = New System.Drawing.Point(723, 299)
        Me.ddlGradeDetail.Name = "ddlGradeDetail"
        Me.ddlGradeDetail.Size = New System.Drawing.Size(529, 42)
        Me.ddlGradeDetail.TabIndex = 20
        '
        'lblGradeDetail
        '
        Me.lblGradeDetail.AutoSize = True
        Me.lblGradeDetail.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblGradeDetail.Location = New System.Drawing.Point(606, 302)
        Me.lblGradeDetail.Name = "lblGradeDetail"
        Me.lblGradeDetail.Size = New System.Drawing.Size(120, 34)
        Me.lblGradeDetail.TabIndex = 18
        Me.lblGradeDetail.Text = "Grade Detail:"
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
        Me.Label8.Size = New System.Drawing.Size(459, 67)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Grade Detail Management"
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
        'Faculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(1348, 853)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Faculty"
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ddlGradeDetail As ComboBox
    Friend WithEvents lblGradeDetail As Label
    Friend WithEvents lblStudentInfo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEnterGrade As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLoadSection As Button
    Friend WithEvents ddlEnrolled As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInformation As TextBox
    Friend WithEvents btnAW As Button
    Friend WithEvents btnFinalGrade As Button
    Friend WithEvents ddlAssignedSections As ComboBox
    Friend WithEvents btnLoadDetail As Button
End Class
