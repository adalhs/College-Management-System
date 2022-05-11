<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentRecord
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
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInformation = New System.Windows.Forms.TextBox()
        Me.btnAcademicEvaluation = New System.Windows.Forms.Button()
        Me.btnWeeklySchedule = New System.Windows.Forms.Button()
        Me.btnPastGrades = New System.Windows.Forms.Button()
        Me.btnEnrolledProgress = New System.Windows.Forms.Button()
        Me.ddlCourses = New System.Windows.Forms.ComboBox()
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
        Me.btnExit.Location = New System.Drawing.Point(58, 530)
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
        Me.Label1.Size = New System.Drawing.Size(126, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Actions"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblCourse.Location = New System.Drawing.Point(652, 186)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(74, 34)
        Me.lblCourse.TabIndex = 2
        Me.lblCourse.Text = "Course:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtInformation)
        Me.Panel1.Controls.Add(Me.btnAcademicEvaluation)
        Me.Panel1.Controls.Add(Me.btnWeeklySchedule)
        Me.Panel1.Controls.Add(Me.btnPastGrades)
        Me.Panel1.Controls.Add(Me.btnEnrolledProgress)
        Me.Panel1.Controls.Add(Me.ddlCourses)
        Me.Panel1.Controls.Add(Me.ddlGradeDetail)
        Me.Panel1.Controls.Add(Me.lblGradeDetail)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblCourse)
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
        'btnAcademicEvaluation
        '
        Me.btnAcademicEvaluation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcademicEvaluation.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcademicEvaluation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAcademicEvaluation.Location = New System.Drawing.Point(58, 424)
        Me.btnAcademicEvaluation.Name = "btnAcademicEvaluation"
        Me.btnAcademicEvaluation.Size = New System.Drawing.Size(296, 47)
        Me.btnAcademicEvaluation.TabIndex = 36
        Me.btnAcademicEvaluation.Text = "Academic Evaluation"
        Me.btnAcademicEvaluation.UseVisualStyleBackColor = True
        '
        'btnWeeklySchedule
        '
        Me.btnWeeklySchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWeeklySchedule.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeeklySchedule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnWeeklySchedule.Location = New System.Drawing.Point(58, 320)
        Me.btnWeeklySchedule.Name = "btnWeeklySchedule"
        Me.btnWeeklySchedule.Size = New System.Drawing.Size(296, 47)
        Me.btnWeeklySchedule.TabIndex = 36
        Me.btnWeeklySchedule.Text = "Verify Weekly Schedule"
        Me.btnWeeklySchedule.UseVisualStyleBackColor = True
        '
        'btnPastGrades
        '
        Me.btnPastGrades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPastGrades.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPastGrades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnPastGrades.Location = New System.Drawing.Point(58, 219)
        Me.btnPastGrades.Name = "btnPastGrades"
        Me.btnPastGrades.Size = New System.Drawing.Size(296, 47)
        Me.btnPastGrades.TabIndex = 36
        Me.btnPastGrades.Text = "Completed Course Grades"
        Me.btnPastGrades.UseVisualStyleBackColor = True
        '
        'btnEnrolledProgress
        '
        Me.btnEnrolledProgress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnrolledProgress.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrolledProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEnrolledProgress.Location = New System.Drawing.Point(58, 119)
        Me.btnEnrolledProgress.Name = "btnEnrolledProgress"
        Me.btnEnrolledProgress.Size = New System.Drawing.Size(296, 47)
        Me.btnEnrolledProgress.TabIndex = 36
        Me.btnEnrolledProgress.Text = "Enrolled Course Progress"
        Me.btnEnrolledProgress.UseVisualStyleBackColor = True
        '
        'ddlCourses
        '
        Me.ddlCourses.Font = New System.Drawing.Font("Dubai", 12.0!)
        Me.ddlCourses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ddlCourses.FormattingEnabled = True
        Me.ddlCourses.Location = New System.Drawing.Point(723, 183)
        Me.ddlCourses.Name = "ddlCourses"
        Me.ddlCourses.Size = New System.Drawing.Size(529, 42)
        Me.ddlCourses.TabIndex = 20
        '
        'ddlGradeDetail
        '
        Me.ddlGradeDetail.Font = New System.Drawing.Font("Dubai", 12.0!)
        Me.ddlGradeDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ddlGradeDetail.FormattingEnabled = True
        Me.ddlGradeDetail.Location = New System.Drawing.Point(723, 379)
        Me.ddlGradeDetail.Name = "ddlGradeDetail"
        Me.ddlGradeDetail.Size = New System.Drawing.Size(529, 42)
        Me.ddlGradeDetail.TabIndex = 20
        '
        'lblGradeDetail
        '
        Me.lblGradeDetail.AutoSize = True
        Me.lblGradeDetail.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblGradeDetail.Location = New System.Drawing.Point(606, 382)
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
        Me.Label8.Size = New System.Drawing.Size(309, 67)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Academic Record"
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
        'StudentRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(1348, 853)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StudentRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InterMetro Information System - Student Portal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ddlGradeDetail As ComboBox
    Friend WithEvents lblGradeDetail As Label
    Friend WithEvents btnEnrolledProgress As Button
    Friend WithEvents ddlCourses As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInformation As TextBox
    Friend WithEvents btnPastGrades As Button
    Friend WithEvents btnWeeklySchedule As Button
    Friend WithEvents btnAcademicEvaluation As Button
End Class
