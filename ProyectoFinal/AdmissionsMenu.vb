Public Class AdmissionsMenu
    Private Sub btnEnterStudent_Click(sender As Object, e As EventArgs) Handles btnEnterStudent.Click
        AdmissionsEnterStudent.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdateStudent_Click(sender As Object, e As EventArgs) Handles btnUpdateStudent.Click
        AdmissionsUpdateStudent.Show()
        Me.Close()
    End Sub

    Private Sub btnAdmissionsLogout_Click(sender As Object, e As EventArgs) Handles btnAdmissionsLogout.Click
        FormLogin.Show()
        Me.Close()
    End Sub
End Class