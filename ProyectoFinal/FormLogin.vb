Imports System.Data.SqlClient

Public Class FormLogin
    Dim sqlConn As New SqlConnection  'represents a unique session(connection) to a SQL Server data source
    Dim sqlCmd As New SqlCommand
    Dim sqlReader As SqlDataReader   'sqlReader is not an object, does not need "New"
    Dim sqlTable As New DataTable
    Dim sqlAdapter As New SqlDataAdapter
    Dim sqlQuery As String

    Dim server As String = "LAPTOP-11N7BEC8\SQLEXPRESS"
    Dim username As String = "sa"
    Dim password As String = "12345678"
    Dim database As String = "InterMetro"

    'Visual management of the login boxes
    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        'Deletes the text on the username textbox when user clicks on it if it contains the placeholder text "Username"
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If

        'Writes the placeholder text "Password" on the password textbox if the user
        'deleted it and left the textbox empty when user clicks the username textbox
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.SlateGray
        End If
    End Sub

    'Visual management of the login boxes
    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        'Deletes the text on the password textbox when user clicks on it if it contains the placeholder text "Password"
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "*"
            txtPassword.ForeColor = Color.Black
        End If

        'Writes the placeholder text "Username" on the username textbox if the user
        'deleted it and left the textbox empty when user clicks the password textbox
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.SlateGray
        End If
    End Sub

    'Logs the user in and verifies their Role in the Person table to take the page of their office or portal
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Deleting previous query information from the table so we can use another user's login information
        'This is an invisible table only used to store data for the process of verifying user's Role
        sqlTable.Clear()

        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * From Person WHERE (Username = '" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "')"
        sqlReader = sqlCmd.ExecuteReader

        'This is an invisible table only used to store the query and to see what Role the record with the Username and Password
        'specified has to take them to their respective page.  If for any reason I need to see this table, I can add a
        'DataGridView to the form and add DataGridView1.DataSource = sqlTable.
        sqlTable.Load(sqlReader)
        sqlReader.Close()
        sqlConn.Close()

        'An invisible row is created with the record that has what the user wrote on txtUsername on its Username
        'column in the Person table, if there is no record with that Username on the table, the row is not created
        Dim rows() As DataRow = sqlTable.Select("[Username]= '" & txtUsername.Text.Trim & "'")

        'Returns the login textboxes to their default
        txtUsername.Text = "Username"
        txtUsername.ForeColor = Color.SlateGray
        txtPassword.Text = "Password"
        txtPassword.PasswordChar = ""
        txtPassword.ForeColor = Color.SlateGray

        'If a row is ot created, it means that that user does not exist in the table Person or user wrote
        'entered wrong information
        If rows.Count = 0 Then
            MessageBox.Show("Incorrect username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'If the row is created the user exists, and program proceeds to compare what that record has
            'on its Role column to guide the user to the corresponding page on the program
        ElseIf rows.Count > 0 Then
            If sqlTable.Rows(0).Item("Role") = "admissions" Then
                Me.Hide()
                FormAdmisions.Show()
            ElseIf sqlTable.Rows(0).Item("Role") = "Registrador" Then
                Me.Hide()
                FormRegistrarOffice.Show()
            ElseIf sqlTable.Rows(0).Item("Role") = "Asistencia" Then
                Me.Hide()
                FormFinancAssist.Show()
            ElseIf sqlTable.Rows(0).Item("Role") = "administrator" Then
                Me.Hide()
                FormAdmin.Show()
            ElseIf sqlTable.Rows(0).Item("Role") = "Facultad" Then
                Me.Hide()
                FormFaculty.Show()
            ElseIf sqlTable.Rows(0).Item("Role") = "Estudiante" Then
                Me.Hide()
                FormEstudiantes.Show()
            End If
        End If
    End Sub
End Class

