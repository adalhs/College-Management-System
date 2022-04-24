<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdmissionsMenu
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEnterStudent = New System.Windows.Forms.Button()
        Me.btnUpdateStudent = New System.Windows.Forms.Button()
        Me.btnAdmissionsLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(30, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1285, 98)
        Me.Panel2.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(200, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(356, 55)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Admissions Office Portal"
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
        'btnEnterStudent
        '
        Me.btnEnterStudent.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEnterStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnterStudent.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEnterStudent.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEnterStudent.Location = New System.Drawing.Point(260, 116)
        Me.btnEnterStudent.Name = "btnEnterStudent"
        Me.btnEnterStudent.Size = New System.Drawing.Size(765, 60)
        Me.btnEnterStudent.TabIndex = 8
        Me.btnEnterStudent.Text = "ENTER NEW STUDENT INFORMATION"
        Me.btnEnterStudent.UseVisualStyleBackColor = False
        '
        'btnUpdateStudent
        '
        Me.btnUpdateStudent.BackColor = System.Drawing.Color.Gainsboro
        Me.btnUpdateStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateStudent.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnUpdateStudent.Location = New System.Drawing.Point(260, 318)
        Me.btnUpdateStudent.Name = "btnUpdateStudent"
        Me.btnUpdateStudent.Size = New System.Drawing.Size(765, 60)
        Me.btnUpdateStudent.TabIndex = 9
        Me.btnUpdateStudent.Text = "UPDATE STUDENT INFORMATION"
        Me.btnUpdateStudent.UseVisualStyleBackColor = False
        '
        'btnAdmissionsLogout
        '
        Me.btnAdmissionsLogout.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAdmissionsLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmissionsLogout.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmissionsLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAdmissionsLogout.Location = New System.Drawing.Point(260, 502)
        Me.btnAdmissionsLogout.Name = "btnAdmissionsLogout"
        Me.btnAdmissionsLogout.Size = New System.Drawing.Size(765, 60)
        Me.btnAdmissionsLogout.TabIndex = 10
        Me.btnAdmissionsLogout.Text = "LOG OUT"
        Me.btnAdmissionsLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BackgroundImage = Global.ProyectoFinal.My.Resources.Resources.menu_background
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnAdmissionsLogout)
        Me.Panel1.Controls.Add(Me.btnUpdateStudent)
        Me.Panel1.Controls.Add(Me.btnEnterStudent)
        Me.Panel1.Location = New System.Drawing.Point(30, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 714)
        Me.Panel1.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Location = New System.Drawing.Point(114, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(114, 714)
        Me.Panel4.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Location = New System.Drawing.Point(1057, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(115, 714)
        Me.Panel3.TabIndex = 11
        '
        'AdmissionsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(1348, 853)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AdmissionsMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inter Metro Information System - Admissions Portal"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btnEnterStudent As Button
    Friend WithEvents btnUpdateStudent As Button
    Friend WithEvents btnAdmissionsLogout As Button
    Friend WithEvents Panel1 As Panel

    Private Sub ddl_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub ddlCountry_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
