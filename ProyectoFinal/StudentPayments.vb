Imports System.Data.SqlClient

Public Class StudentPayments

    Dim sqlConn As New SqlConnection  'represents a unique session(connection) to a SQL Server data source
    Dim sqlCmd As New SqlCommand
    Dim sqlReader As SqlDataReader   'sqlReader is not an object, does not need "New"

    Dim sqlTableStudent As New DataTable 'invisible table to hold student info, mainly HouseIncome, GPA, FirstName, and LastName
    Dim sqlTableEnrollment As New DataTable  'holds student enrollment data (mostly for balance due and assigning grant)

    Dim server As String = "LAPTOP-11N7BEC8\SQLEXPRESS"
    Dim username As String = "sa"
    Dim password As String = "12345678"
    Dim database As String = "InterMetro"

    Dim currentterm As String = "-2022-23"    'to be used when loading section, want to load section number of current term only

    Dim payment As Double
    Dim balancedue As Double
    Dim newbalance As Double

    'On form load we load the student's record from the Person table to get their ID to display at the top and their
    'HouseIncome for financial aid purposes
    Private Sub StudentPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        LockAll()

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        'Gets the student's record from the Person table using the username and password provided by the student upon login
        sqlCmd.CommandText = "SELECT * FROM Person
        WHERE Username = '" & user & "'
        AND Password = '" & pass & "'"
        sqlReader = sqlCmd.ExecuteReader
        sqlTableStudent.Load(sqlReader)

        'Gets the student's enrollment data for balance and financial aid
        sqlCmd.CommandText = "SELECT * From CurrentTermEnrollment
        WHERE StudentId = '" & sqlTableStudent.Rows(0).Item("PersonId") & "'"
        sqlReader = sqlCmd.ExecuteReader
        sqlTableEnrollment.Load(sqlReader)

        sqlReader.Close()
        sqlConn.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        PortalMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnApplyAid_Click(sender As Object, e As EventArgs) Handles btnApplyAid.Click
        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        If Not IsDBNull(sqlTableEnrollment.Rows(0).Item("GrantAmount")) Then
            MsgBox("You have already been awarded financial aid for this term.", 64, "Information")
        Else
            If sqlTableStudent.Rows(0).Item("HouseIncome") = "" Then
                MsgBox("Your income data has not been entered yet." & vbNewLine & "Unable to determine Aid eligibility.", 64, "Information")
            ElseIf sqlTableStudent.Rows(0).Item("HouseIncome") > 30000 Then
                MsgBox("You do not qualify for financial aid." & vbNewLine & "Reason - Income threshold exceeded.", 64, "Information")
            Else
                'Financial Aid equaling 70% of student's costs (BalanceDue) is granted
                sqlCmd.CommandText = "UPDATE CurrentTermEnrollment
            SET GrantAmount = .7 * " & sqlTableEnrollment.Rows(0).Item("BalanceDue") & ",
            GrantAvailable = .7 * " & sqlTableEnrollment.Rows(0).Item("BalanceDue") & "
            WHERE StudentId = '" & sqlTableStudent.Rows(0).Item("PersonId") & "'
            AND EnrollmentId like '%" & currentterm & "%'"
                sqlReader = sqlCmd.ExecuteReader
                sqlReader.Close()

                'Clearing previous data in table to include new Grant data
                sqlTableEnrollment.Clear()
                sqlCmd.CommandText = "SELECT * From CurrentTermEnrollment
            WHERE StudentId = '" & sqlTableStudent.Rows(0).Item("PersonId") & "'"
                sqlReader = sqlCmd.ExecuteReader
                sqlTableEnrollment.Load(sqlReader)

                MsgBox("Student Aid has been awarded.", 64, "Information")
            End If
        End If

        sqlReader.Close()
        sqlConn.Close()
    End Sub

    Private Sub btnCheckBalance_Click(sender As Object, e As EventArgs) Handles btnCheckBalance.Click
        txtBalanceDue.Text = "" & sqlTableEnrollment.Rows(0).Item("BalanceDue") & ""
        txtAidAwarded.Text = "" & sqlTableEnrollment.Rows(0).Item("GrantAmount") & ""
        txtAidAvailable.Text = "" & sqlTableEnrollment.Rows(0).Item("GrantAvailable") & ""
    End Sub

    Private Sub btnMakePayment_Click(sender As Object, e As EventArgs) Handles btnMakePayment.Click
        txtBalanceDue.Text = "" & sqlTableEnrollment.Rows(0).Item("BalanceDue") & ""
        txtAidAwarded.Text = "" & sqlTableEnrollment.Rows(0).Item("GrantAmount") & ""
        txtAidAvailable.Text = "" & sqlTableEnrollment.Rows(0).Item("GrantAvailable") & ""

        payment = 0
        balancedue = sqlTableEnrollment.Rows(0).Item("BalanceDue")
        newbalance = 0

        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        'If student has financial aid it is applied automatically, unless it's 0.00 which meanas they
        'already used all of it and it won't tell them it will apply it again for subsequent payments
        If Not IsDBNull(sqlTableEnrollment.Rows(0).Item("GrantAvailable")) And Not sqlTableEnrollment.Rows(0).Item("GrantAvailable") = 0.00 Then
            MsgBox("Your financial aid of " & sqlTableEnrollment.Rows(0).Item("GrantAvailable") & "
will be automatically applied towards your Balance Due.", 64, "Information")

            'Gets new balance after applying available grant and sets text boxes to new values
            newbalance = balancedue - sqlTableEnrollment.Rows(0).Item("GrantAvailable")
            txtBalanceDue.Text = "" & newbalance & ""
            txtAidAvailable.Text = "0"

            MsgBox("Your new Balance Due is " & newbalance & ".", 64, "Information")

            Try
                payment = CDbl(InputBox("Enter amount to pay:", "Search"))

                'Handles exception if use enters something that can't be converted to double (even an empty space)
                'gives them a message and exits the Sub
            Catch ex As InvalidCastException
                MsgBox("Please only enter numbers", 64, "Information")

                'Resets these fields to previous values if user does not successfully enter a payment
                txtBalanceDue.Text = "" & sqlTableEnrollment.Rows(0).Item("BalanceDue") & ""
                txtAidAvailable.Text = "" & sqlTableEnrollment.Rows(0).Item("GrantAvailable") & ""

                sqlReader.Close()
                sqlConn.Close()
                Exit Sub
            End Try

            If payment > newbalance Then
                MsgBox("You cannot pay more than your Balance Due.", 64, "Information")
                'Resets these fields to previous values if user does not successfully enter a payment
                txtBalanceDue.Text = "" & sqlTableEnrollment.Rows(0).Item("BalanceDue") & ""
                txtAidAvailable.Text = "" & sqlTableEnrollment.Rows(0).Item("GrantAvailable") & ""
            Else
                'newbalance = newbalance - payment
                newbalance -= payment

                sqlCmd.CommandText = "UPDATE CurrentTermEnrollment
                    SET BalanceDue = " & newbalance & ",
                    GrantAvailable = " & 0.00 & "
                    WHERE StudentId = '" & sqlTableStudent.Rows(0).Item("PersonId") & "'"
                sqlReader = sqlCmd.ExecuteReader
                sqlReader.Close()

                sqlTableEnrollment.Clear()
                sqlCmd.CommandText = "SELECT * FROM CurrentTermEnrollment
                    WHERE StudentId = '" & sqlTableStudent.Rows(0).Item("PersonId") & "'"
                sqlReader = sqlCmd.ExecuteReader
                sqlTableEnrollment.Load(sqlReader)

                txtBalanceDue.Text = "" & sqlTableEnrollment.Rows(0).Item("BalanceDue") & ""
                txtAidAvailable.Text = "" & sqlTableEnrollment.Rows(0).Item("GrantAvailable") & ""
                MsgBox("Payment received.  Your new balance is $" & newbalance & ".", 64, "Information")
            End If

            'If student does not have financial aid or declines having it applied to BalanceDue
        Else
            Try
                payment = CDbl(InputBox("Enter amount to pay:", "Search"))

                'Handles exception if use enters something that can't be converted to double (even an empty space)
                'gives them a message and exits the Sub
            Catch ex As InvalidCastException
                MsgBox("Please only enter numbers", 64, "Information")

                sqlReader.Close()
                sqlConn.Close()
                Exit Sub
            End Try

            If payment > balancedue Then
                MsgBox("You cannot pay more than your Balance Due.", 64, "Information")
            Else
                'newbalance = newbalance - payment
                newbalance = balancedue - payment

                sqlCmd.CommandText = "UPDATE CurrentTermEnrollment
                    SET BalanceDue = " & newbalance & "
                    WHERE StudentId = '" & sqlTableStudent.Rows(0).Item("PersonId") & "'"
                sqlReader = sqlCmd.ExecuteReader
                sqlReader.Close()

                sqlTableEnrollment.Clear()
                sqlCmd.CommandText = "SELECT * FROM CurrentTermEnrollment
                    WHERE StudentId = '" & sqlTableStudent.Rows(0).Item("PersonId") & "'"
                sqlReader = sqlCmd.ExecuteReader
                sqlTableEnrollment.Load(sqlReader)

                txtBalanceDue.Text = "" & sqlTableEnrollment.Rows(0).Item("BalanceDue") & ""
                MsgBox("Payment received.  Your new balance is $" & newbalance & ".", 64, "Information")
            End If
        End If

        sqlReader.Close()
        sqlConn.Close()
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
        btnCancel.Enabled = False
        txtBalanceDue.Enabled = False
        txtBalanceDue.BackColor = Drawing.Color.White
        txtAidAvailable.BackColor = Drawing.Color.White
        txtAidAwarded.BackColor = Drawing.Color.White
    End Sub
End Class