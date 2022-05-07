Public Class FormCustomMsgBox
    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'These two codes come from the Admissions Form
        If CustomMsgBoxCode = "1" Or CustomMsgBoxCode = "2" Then
            lblDisplayInfo.Text = Admissions.txtStudentInfo.Text

            'This code comes from the Registration Form
        ElseIf CustomMsgBoxCode = "3" Then
            lblDisplayInfo.Text = Registration.txtInformation.Text
        End If
    End Sub

    Private Sub btnConfirmYes_Click(sender As Object, e As EventArgs) Handles btnConfirmYes.Click
        If CustomMsgBoxCode = "1" Then
            Admissions.EnterStudentInfo()
        ElseIf CustomMsgBoxCode = "2" Then
            Admissions.UpdateStudentInfo()
        ElseIf CustomMsgBoxCode = "3" Then
            Registration.AddSection()
        End If
    End Sub

    Private Sub btnConfirmNo_Click(sender As Object, e As EventArgs) Handles btnConfirmNo.Click
        Me.Close()
    End Sub
End Class