<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentPayments
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
        Me.lblBalanceDue = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAidAvailable = New System.Windows.Forms.TextBox()
        Me.txtAidAwarded = New System.Windows.Forms.TextBox()
        Me.txtBalanceDue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInformation = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnMakePayment = New System.Windows.Forms.Button()
        Me.lblStudentInfo = New System.Windows.Forms.Label()
        Me.btnCheckBalance = New System.Windows.Forms.Button()
        Me.btnApplyAid = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.btnExit.Location = New System.Drawing.Point(80, 542)
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
        'lblBalanceDue
        '
        Me.lblBalanceDue.AutoSize = True
        Me.lblBalanceDue.Font = New System.Drawing.Font("Dubai", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceDue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblBalanceDue.Location = New System.Drawing.Point(538, 160)
        Me.lblBalanceDue.Name = "lblBalanceDue"
        Me.lblBalanceDue.Size = New System.Drawing.Size(188, 48)
        Me.lblBalanceDue.TabIndex = 2
        Me.lblBalanceDue.Text = "Balance Due: $"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.txtAidAvailable)
        Me.Panel1.Controls.Add(Me.txtAidAwarded)
        Me.Panel1.Controls.Add(Me.txtBalanceDue)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtInformation)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.btnMakePayment)
        Me.Panel1.Controls.Add(Me.lblStudentInfo)
        Me.Panel1.Controls.Add(Me.btnCheckBalance)
        Me.Panel1.Controls.Add(Me.btnApplyAid)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblBalanceDue)
        Me.Panel1.Location = New System.Drawing.Point(30, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 714)
        Me.Panel1.TabIndex = 5
        '
        'txtAidAvailable
        '
        Me.txtAidAvailable.Font = New System.Drawing.Font("Dubai", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAidAvailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtAidAvailable.Location = New System.Drawing.Point(731, 365)
        Me.txtAidAvailable.Multiline = True
        Me.txtAidAvailable.Name = "txtAidAvailable"
        Me.txtAidAvailable.Size = New System.Drawing.Size(243, 44)
        Me.txtAidAvailable.TabIndex = 45
        '
        'txtAidAwarded
        '
        Me.txtAidAwarded.Font = New System.Drawing.Font("Dubai", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAidAwarded.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtAidAwarded.Location = New System.Drawing.Point(836, 261)
        Me.txtAidAwarded.Multiline = True
        Me.txtAidAwarded.Name = "txtAidAwarded"
        Me.txtAidAwarded.Size = New System.Drawing.Size(242, 44)
        Me.txtAidAwarded.TabIndex = 45
        '
        'txtBalanceDue
        '
        Me.txtBalanceDue.Font = New System.Drawing.Font("Dubai", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalanceDue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtBalanceDue.Location = New System.Drawing.Point(723, 160)
        Me.txtBalanceDue.Multiline = True
        Me.txtBalanceDue.Name = "txtBalanceDue"
        Me.txtBalanceDue.Size = New System.Drawing.Size(242, 44)
        Me.txtBalanceDue.TabIndex = 45
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
        Me.btnCancel.Location = New System.Drawing.Point(963, 521)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(156, 47)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(495, 0)
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
        Me.btnSubmit.Location = New System.Drawing.Point(687, 521)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(156, 47)
        Me.btnSubmit.TabIndex = 41
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnMakePayment
        '
        Me.btnMakePayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMakePayment.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakePayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnMakePayment.Location = New System.Drawing.Point(80, 400)
        Me.btnMakePayment.Name = "btnMakePayment"
        Me.btnMakePayment.Size = New System.Drawing.Size(296, 47)
        Me.btnMakePayment.TabIndex = 41
        Me.btnMakePayment.Text = "Make Payment"
        Me.btnMakePayment.UseVisualStyleBackColor = True
        '
        'lblStudentInfo
        '
        Me.lblStudentInfo.AutoSize = True
        Me.lblStudentInfo.Font = New System.Drawing.Font("Dubai", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblStudentInfo.Location = New System.Drawing.Point(488, 13)
        Me.lblStudentInfo.Name = "lblStudentInfo"
        Me.lblStudentInfo.Size = New System.Drawing.Size(217, 55)
        Me.lblStudentInfo.TabIndex = 38
        Me.lblStudentInfo.Text = "ID Placeholder"
        Me.lblStudentInfo.Visible = False
        '
        'btnCheckBalance
        '
        Me.btnCheckBalance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckBalance.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnCheckBalance.Location = New System.Drawing.Point(80, 265)
        Me.btnCheckBalance.Name = "btnCheckBalance"
        Me.btnCheckBalance.Size = New System.Drawing.Size(296, 47)
        Me.btnCheckBalance.TabIndex = 36
        Me.btnCheckBalance.Text = "Check Balance Due / Aid"
        Me.btnCheckBalance.UseVisualStyleBackColor = True
        '
        'btnApplyAid
        '
        Me.btnApplyAid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApplyAid.Font = New System.Drawing.Font("Dubai", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyAid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnApplyAid.Location = New System.Drawing.Point(80, 132)
        Me.btnApplyAid.Name = "btnApplyAid"
        Me.btnApplyAid.Size = New System.Drawing.Size(296, 47)
        Me.btnApplyAid.TabIndex = 36
        Me.btnApplyAid.Text = "Apply for Student Aid"
        Me.btnApplyAid.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(542, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(301, 48)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Aid Awarded for Term: $"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(542, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 48)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Aid Available: $"
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
        Me.Label8.Size = New System.Drawing.Size(548, 67)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Payments Management System"
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
        'StudentPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(1348, 853)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StudentPayments"
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
    Friend WithEvents lblBalanceDue As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btnMakePayment As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnApplyAid As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInformation As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCheckBalance As Button
    Friend WithEvents txtBalanceDue As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAidAvailable As TextBox
    Friend WithEvents txtAidAwarded As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStudentInfo As Label
End Class
