Public Class FormCustomMsgBox
    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisplayInfo.Text = FormAdmisions.txtStudentInfo.Text
    End Sub

    Private Sub btnConfirmYes_Click(sender As Object, e As EventArgs) Handles btnConfirmYes.Click
        FormAdmisions.EnterStudentInfo()
    End Sub

    Private Sub btnConfirmNo_Click(sender As Object, e As EventArgs) Handles btnConfirmNo.Click
        Me.Close()
    End Sub
End Class