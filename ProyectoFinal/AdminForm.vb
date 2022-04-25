Imports System.Data.SqlClient

Public Class AdminForm

    Dim sqlConn As New SqlConnection  'represents a unique session(connection) to a SQL Server data source
    Dim sqlCmd As New SqlCommand
    Dim sqlReader As SqlDataReader   'sqlReader is not an object, does not need "New"
    Dim sqlTable As New DataTable   'invisible table to hold temporary data

    Dim server As String = "LAPTOP-11N7BEC8\SQLEXPRESS"
    Dim username As String = "sa"
    Dim password As String = "12345678"
    Dim database As String = "InterMetro"

    Dim idlookup As String   'holds PersonId entered by user

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddlPermissions.Text = "Choose one option:"
        ddlPermissions.Items.Add("administrator")
        ddlPermissions.Items.Add("admissions")
        ddlPermissions.Items.Add("registrar")
        ddlPermissions.Items.Add("financialaid")
        ddlPermissions.Items.Add("bursar")
        ddlPermissions.Items.Add("student")
        ddlPermissions.Items.Add("faculty")

        LockAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        PortalMenu.Show()
        Me.Close()
    End Sub

    'This function asks for a PersonId, if there is one, it opens up the username, password and permission fields,
    'if there isn't gives error message saying ID doesn't exist
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        LockAll()
        resetlabelcolor()
        resetfields()

        sqlTable.Clear()    'Clears invisible table
        idlookup = InputBox("Enter ID:", "Search")

        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * From Person WHERE PersonId = '" & idlookup & "'"
        sqlReader = sqlCmd.ExecuteReader

        sqlTable.Load(sqlReader)     'Loads record matching ID provided to invisible sqlTable
        sqlReader.Close()
        sqlConn.Close()

        If sqlTable.Rows.Count > 0 Then
            'If ID exists but that record already has a username assigned (Username column in Person table is not null)
            If IsDBNull(sqlTable.Rows(0).Item("Username")) = False Then
                MsgBox("" & sqlTable.Rows(0).Item("PersonId") & " already has an account.", 64, "Information")
            Else
                'Enables the Submit button if there is a PersonId from Person table in idlookup variable
                'also shows record's ID, first name, and last name in the lblPersonInfo
                btnSubmit.Enabled = True
                lblPersonInfo.Visible = True
                lblPersonInfo.Text = "User: " & sqlTable.Rows(0).Item("FirstName") & " " & sqlTable.Rows(0).Item("LastName") & ""

                'Enables Input in textbox And comboboxes (dropdownlists)
                Dim ctrl As Control = Me.GetNextControl(Me, True)
                Do Until ctrl Is Nothing
                    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                        ctrl.BackColor = Drawing.Color.White
                        ctrl.Enabled = True
                    End If
                    ctrl = Me.GetNextControl(ctrl, True)
                Loop
            End If

            'If user clicks Cancel button on the idlookup input box or presses OK button while the textbox is empty nothing happens
        ElseIf ReferenceEquals(idlookup, String.Empty) Then
            'Do Nothing

        Else 'User entered something on the idlookup inputbox but it didn't match any PersonIds on the Person table
            MsgBox("ID: " & idlookup & " not found.", 64, "Information")
        End If
    End Sub

    'Inserts username, password, and role we enter into the Person table in the record with selected PersonId (held in idlookup variable)
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlTable.Clear()

        'Gets all Label controls from the form and sets their color back to Black, in case they were turned red
        'from the user clicking Submit before they had entered information in a required textbox
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = Color.FromArgb(48, 48, 48)
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop

        'Sets the color of labels of empty required textboxes to red
        If txtUsername.Text = "" Or txtPassword.Text = "" Or ddlPermissions.Text = "Choose one option:" Then

            If txtUsername.Text = "" Then
                lblUsername.ForeColor = Drawing.Color.Red
            End If
            If txtPassword.Text = "" Then
                lblPassword.ForeColor = Drawing.Color.Red
            End If
            If ddlPermissions.Text = "Choose one option:" Then
                lblPermissions.ForeColor = Drawing.Color.Red
            End If

            MsgBox("The fields highlighted in red are required.", 48, "Error")
        Else
            sqlConn.Open()
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "UPDATE Person SET Username = '" & txtUsername.Text & "', Password = '" & txtPassword.Text & "',
            Role = '" & ddlPermissions.Text & "' WHERE PersonId = '" & idlookup & "'"

            sqlReader = sqlCmd.ExecuteReader
            sqlReader.Close()
            sqlConn.Close()

            MsgBox("Account created successfully.", 64, "Information")

            LockAll()
        End If
    End Sub

    Private Sub btnChangePermissions_Click(sender As Object, e As EventArgs) Handles btnChangePermissions.Click
        resetfields()
        resetlabelcolor()
        LockAll()

        sqlTable.Clear()
        idlookup = InputBox("Enter ID:", "Search")

        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * From Person WHERE PersonId = '" & idlookup & "'"
        sqlReader = sqlCmd.ExecuteReader

        sqlTable.Load(sqlReader)     'Loads record matching ID provided to invisible sqlTable
        sqlReader.Close()
        sqlConn.Close()

        If sqlTable.Rows.Count > 0 Then
            'Enables the Update button if there is a PersonId from Person table in idlookup variable
            'also shows record's ID, first name, and last name in the lblPersonInfo
            btnUpdate.Enabled = True
            lblPersonInfo.Visible = True
            lblPersonInfo.Text = "User: " & sqlTable.Rows(0).Item("FirstName") & " " & sqlTable.Rows(0).Item("LastName") & ""

            'Enables Permissions ddl for changes
            ddlPermissions.Enabled = True
            ddlPermissions.BackColor = Drawing.Color.White
            ddlPermissions.Text = sqlTable.Rows(0).Item("Role")

            'If user clicks Cancel button on the idlookup input box or presses OK button while the textbox is empty nothing happens
        ElseIf ReferenceEquals(idlookup, String.Empty) Then
            LockAll()

        Else 'User entered something on the idlookup inputbox but it didn't match any PersonIds on the Person table
            LockAll()
            MsgBox("ID: " & idlookup & " not found.", 64, "Information")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateUserInfo()
    End Sub

    'Deletes Username, Password from a user's record
    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        resetfields()
        resetlabelcolor()
        LockAll()

        sqlTable.Clear()
        idlookup = InputBox("Enter username for deletion:", "Delete Account")

        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * From Person WHERE Username = '" & idlookup & "'"
        sqlReader = sqlCmd.ExecuteReader

        sqlTable.Load(sqlReader)     'Loads record matching ID provided to invisible sqlTable

        'Username entered exists in Person table
        If sqlTable.Rows.Count > 0 Then
            If MsgBox("Are you sure you want to DELETE the account '" & sqlTable.Rows(0).Item("Username") & "' belonging to " & sqlTable.Rows(0).Item("FirstName") & " " & sqlTable.Rows(0).Item("LastName") & "?",
                      MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then

                'Setting it to NULL and not "" because of the check with IsDBNull in the btnAddUser_Click Sub
                sqlCmd.CommandText = "UPDATE Person Set Username = NULL, Password = NULL WHERE Username = '" & idlookup & "'"
                sqlReader = sqlCmd.ExecuteReader

                MsgBox("The account '" & sqlTable.Rows(0).Item("Username") & "' has been deleted.", 64, "Information")
            End If

            'If user clicks Cancel button on the idlookup input box or presses OK button while the textbox is empty nothing happens
        ElseIf ReferenceEquals(idlookup, String.Empty) Then
            'Nothing happens

        Else   'User entered something but didn't match any username in Person table
            MsgBox("Username not found.", 48, "Error")
        End If

        'Closed at the end because I use the reader twice with two sqlCmd.CommandTexts
        sqlReader.Close()
        sqlConn.Close()
    End Sub

    Public Sub UpdateUserInfo()
        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "UPDATE Person SET Role = '" & ddlPermissions.Text & "'
        WHERE PersonId = '" & idlookup & "'"

        sqlReader = sqlCmd.ExecuteReader
        sqlReader.Close()
        sqlConn.Close()
        MsgBox("The permissions of account '" & sqlTable.Rows(0).Item("Username") & "' have been successfully changed to '" & ddlPermissions.Text & "'.", 64, "Information")

        resetfields()
        LockAll()
    End Sub

    'Does not let user write text on the drop down boxes, only select an option
    Private Sub ddl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlPermissions.KeyPress
        e.Handled = True
    End Sub

    Private Sub resetfields()
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = "Choose one option:"
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop
    End Sub

    'Gets all Label controls from the form and sets their color back to Black, in case they were turned red
    'from the user clicking Submit before they had entered information in a required textbox
    Private Sub resetlabelcolor()
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = Color.FromArgb(48, 48, 48)
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop
    End Sub

    Private Sub LockAll()
        'Input in textbox and comboboxes (dropdownlists) is disabled when form loads until user clicks an appropriate button
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.BackColor = Drawing.Color.Silver
                ctrl.Enabled = False
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop

        'User flow control
        btnSubmit.Enabled = False
        btnUpdate.Enabled = False
        ddlPermissions.Enabled = False
        lblPersonInfo.Visible = False
    End Sub
End Class