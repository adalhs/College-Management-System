Public Class FormCustomMsgBox
    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CustomMsgBoxCode = "1" Then
            lblDisplayInfo.Text = AdmissionsEnterStudent.txtStudentInfo.Text
        ElseIf CustomMsgBoxCode = "2" Then
            lblDisplayInfo.Text = AdmissionsUpdateStudent.txtStudentUpdate.Text
        End If
    End Sub

    Private Sub btnConfirmYes_Click(sender As Object, e As EventArgs) Handles btnConfirmYes.Click
        If CustomMsgBoxCode = "1" Then
            AdmissionsEnterStudent.EnterStudentInfo()
        ElseIf CustomMsgBoxCode = "2" Then
            AdmissionsUpdateStudent.UpdateStudentInfo()
        End If
    End Sub

    Private Sub btnConfirmNo_Click(sender As Object, e As EventArgs) Handles btnConfirmNo.Click
        Me.Close()
    End Sub
End Class