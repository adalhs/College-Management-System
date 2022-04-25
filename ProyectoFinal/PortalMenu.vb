Public Class PortalMenu
    Private Sub AdmissionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MenuCode = "0" Then
            btnAdmin.Visible = True
            lblMenuName.Text = "Systems Administrator Portal"
        ElseIf MenuCode = "1" Then
            btnAdmissions.Visible = True
            lblMenuName.Text = "Admissions Office Portal"
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        btnAdmin.Visible = False
        btnAdmissions.Visible = False
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnAdmissions_Click(sender As Object, e As EventArgs) Handles btnAdmissions.Click
        Admissions.Show()
        Me.Close()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        AdminForm.Show()
        Me.Close()
    End Sub
End Class