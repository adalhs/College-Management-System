Public Class PortalMenu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MenuCode = "0" Then
            btnAdmin.Visible = True
            lblMenuName.Text = "Systems Administrator Portal"
        ElseIf MenuCode = "1" Then
            btnAdmissions.Visible = True
            lblMenuName.Text = "Admissions Office Portal"
        ElseIf MenuCode = "2" Then
            btnRegistrar.Visible = True
            lblMenuName.Text = "Registration Office Portal"
        ElseIf MenuCode = "3" Then
            btnFaculty.Visible = True
            lblMenuName.Text = "Faculty Portal"
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        btnAdmin.Visible = False
        btnAdmissions.Visible = False
        btnRegistrar.Visible = False
        btnFaculty.Visible = False

        'Setting these global variables back to blank
        user = ""
        pass = ""

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

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Registration.Show()
        Me.Close()
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        Faculty.Show()
        Me.Close()
    End Sub
End Class