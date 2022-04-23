<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomMsgBox
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
        Me.btnConfirmYes = New System.Windows.Forms.Button()
        Me.lblDisplayInfo = New System.Windows.Forms.Label()
        Me.btnConfirmNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConfirmYes
        '
        Me.btnConfirmYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmYes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnConfirmYes.Location = New System.Drawing.Point(192, 450)
        Me.btnConfirmYes.Name = "btnConfirmYes"
        Me.btnConfirmYes.Size = New System.Drawing.Size(94, 40)
        Me.btnConfirmYes.TabIndex = 1
        Me.btnConfirmYes.Text = "Ok"
        Me.btnConfirmYes.UseVisualStyleBackColor = True
        '
        'lblDisplayInfo
        '
        Me.lblDisplayInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplayInfo.AutoSize = True
        Me.lblDisplayInfo.Font = New System.Drawing.Font("Dubai", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblDisplayInfo.Location = New System.Drawing.Point(40, 29)
        Me.lblDisplayInfo.MaximumSize = New System.Drawing.Size(704, 0)
        Me.lblDisplayInfo.Name = "lblDisplayInfo"
        Me.lblDisplayInfo.Size = New System.Drawing.Size(61, 30)
        Me.lblDisplayInfo.TabIndex = 0
        Me.lblDisplayInfo.Text = "Label1"
        '
        'btnConfirmNo
        '
        Me.btnConfirmNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnConfirmNo.Location = New System.Drawing.Point(505, 450)
        Me.btnConfirmNo.Name = "btnConfirmNo"
        Me.btnConfirmNo.Size = New System.Drawing.Size(90, 40)
        Me.btnConfirmNo.TabIndex = 2
        Me.btnConfirmNo.Text = "Cancel"
        Me.btnConfirmNo.UseVisualStyleBackColor = True
        '
        'FormCustomMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 547)
        Me.Controls.Add(Me.btnConfirmNo)
        Me.Controls.Add(Me.btnConfirmYes)
        Me.Controls.Add(Me.lblDisplayInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormCustomMsgBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirmYes As Button
    Friend WithEvents lblDisplayInfo As Label
    Friend WithEvents btnConfirmNo As Button
End Class
