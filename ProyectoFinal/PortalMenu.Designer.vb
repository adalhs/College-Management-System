<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PortalMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PortalMenu))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblMenuName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnAcademicRecord = New System.Windows.Forms.Button()
        Me.btnFaculty = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAdmissions = New System.Windows.Forms.Button()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Controls.Add(Me.lblMenuName)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(30, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1285, 98)
        Me.Panel2.TabIndex = 7
        '
        'lblMenuName
        '
        Me.lblMenuName.AutoSize = True
        Me.lblMenuName.Font = New System.Drawing.Font("Dubai", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblMenuName.Location = New System.Drawing.Point(199, 31)
        Me.lblMenuName.Name = "lblMenuName"
        Me.lblMenuName.Size = New System.Drawing.Size(429, 67)
        Me.lblMenuName.TabIndex = 7
        Me.lblMenuName.Text = "Menu Name Placeholder"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BackgroundImage = Global.ProyectoFinal.My.Resources.Resources.menu_background
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.btnPayments)
        Me.Panel1.Controls.Add(Me.btnAcademicRecord)
        Me.Panel1.Controls.Add(Me.btnFaculty)
        Me.Panel1.Controls.Add(Me.btnRegistrar)
        Me.Panel1.Controls.Add(Me.btnAdmin)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnAdmissions)
        Me.Panel1.Location = New System.Drawing.Point(30, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 714)
        Me.Panel1.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(357, 30)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(602, 65)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.Visible = False
        '
        'btnAcademicRecord
        '
        Me.btnAcademicRecord.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAcademicRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcademicRecord.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcademicRecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAcademicRecord.Location = New System.Drawing.Point(260, 188)
        Me.btnAcademicRecord.Name = "btnAcademicRecord"
        Me.btnAcademicRecord.Size = New System.Drawing.Size(765, 60)
        Me.btnAcademicRecord.TabIndex = 13
        Me.btnAcademicRecord.Text = "VIEW ACADEMIC RECORD"
        Me.btnAcademicRecord.UseVisualStyleBackColor = False
        Me.btnAcademicRecord.Visible = False
        '
        'btnFaculty
        '
        Me.btnFaculty.BackColor = System.Drawing.Color.Gainsboro
        Me.btnFaculty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFaculty.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaculty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnFaculty.Location = New System.Drawing.Point(260, 188)
        Me.btnFaculty.Name = "btnFaculty"
        Me.btnFaculty.Size = New System.Drawing.Size(765, 60)
        Me.btnFaculty.TabIndex = 13
        Me.btnFaculty.Text = "GRADE DETAIL MANAGEMENT"
        Me.btnFaculty.UseVisualStyleBackColor = False
        Me.btnFaculty.Visible = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnRegistrar.Location = New System.Drawing.Point(260, 188)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(765, 60)
        Me.btnRegistrar.TabIndex = 13
        Me.btnRegistrar.Text = "STUDENT RECORD MANAGEMENT"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        Me.btnRegistrar.Visible = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmin.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAdmin.Location = New System.Drawing.Point(260, 188)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(765, 60)
        Me.btnAdmin.TabIndex = 13
        Me.btnAdmin.Text = "ACCOUNT MANAGEMENT"
        Me.btnAdmin.UseVisualStyleBackColor = False
        Me.btnAdmin.Visible = False
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
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(260, 452)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(765, 60)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAdmissions
        '
        Me.btnAdmissions.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAdmissions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmissions.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdmissions.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmissions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAdmissions.Location = New System.Drawing.Point(260, 188)
        Me.btnAdmissions.Name = "btnAdmissions"
        Me.btnAdmissions.Size = New System.Drawing.Size(765, 60)
        Me.btnAdmissions.TabIndex = 8
        Me.btnAdmissions.Text = "STUDENT INFORMATION MANAGEMENT"
        Me.btnAdmissions.UseVisualStyleBackColor = False
        Me.btnAdmissions.Visible = False
        '
        'btnPayments
        '
        Me.btnPayments.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayments.Font = New System.Drawing.Font("Dubai", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnPayments.Location = New System.Drawing.Point(260, 318)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(765, 60)
        Me.btnPayments.TabIndex = 13
        Me.btnPayments.Text = "PAYMENTS MANAGEMENT SYSTEM"
        Me.btnPayments.UseVisualStyleBackColor = False
        Me.btnPayments.Visible = False
        '
        'PortalMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(1348, 853)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PortalMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InterMetro Information System"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblMenuName As Label
    Friend WithEvents btnAdmissions As Button
    Friend WithEvents btnLogout As Button
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnFaculty As Button
    Friend WithEvents btnAcademicRecord As Button
    Friend WithEvents btnPayments As Button
End Class
