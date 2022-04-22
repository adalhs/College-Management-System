Imports System.Data.SqlClient

Public Class FormAdmisions

    Dim sqlConn As New SqlConnection  'represents a unique session(connection) to a SQL Server data source
    Dim sqlCmd As New SqlCommand
    Dim sqlReader As SqlDataReader   'sqlReader is not an object, does not need "New"

    Dim server As String = "LAPTOP-11N7BEC8\SQLEXPRESS"
    Dim username As String = "sa"
    Dim password As String = "12345678"
    Dim database As String = "InterMetro"
    Private Sub FormAdmisions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Validation does not let user enter wrong information in these fields
        'Validation control is in TextBoxValidation.vb
        AssignValidation(Me.txtFirstName, ValidationType.Only_Characters)
        AssignValidation(Me.txtLastName, ValidationType.Only_Characters)
        AssignValidation(Me.txtAge, ValidationType.Only_Numbers)
        AssignValidation(Me.txtEmail, ValidationType.Only_Email)
        AssignValidation(Me.txtPhone, ValidationType.Phone_Number)
        AssignValidation(Me.txtCity, ValidationType.Only_Characters)
        AssignValidation(Me.txtZipcode, ValidationType.Only_Numbers)
        AssignValidation(Me.txtIncome, ValidationType.Only_Numbers)

        ddlSex.Text = "Choose one option:"
        ddlSex.Items.Add("Male")
        ddlSex.Items.Add("Female")

        ddlState.Text = "Choose one option:"
        ddlState.Items.Add("Alabama")
        ddlState.Items.Add("Alaska")
        ddlState.Items.Add("Arizona")
        ddlState.Items.Add("Arkansas")
        ddlState.Items.Add("California")
        ddlState.Items.Add("Colorado")

        ddlCountry.Text = "Choose one option:"
        ddlCountry.Items.Add("United States")
        ddlCountry.Items.Add("Canada")
        ddlCountry.Items.Add("Puerto Rico")

        ddlMajor.Text = "Choose one option:"
        ddlMajor.Items.Add("Undeclared")
        ddlMajor.Items.Add("Computer Science")
        ddlMajor.Items.Add("Chemistry")

        ddlCovid.Text = "Choose one option:"
        ddlCovid.Items.Add("No doses")
        ddlCovid.Items.Add("1 dose")
        ddlCovid.Items.Add("2 doses")
        ddlCovid.Items.Add("3 doses")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAge.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        ddlSex.Text = "Choose one option:"
        txtAddress.Text = ""
        txtCity.Text = ""
        ddlState.Text = "Choose one option:"
        txtZipcode.Text = ""
        ddlCountry.Text = "Choose one option:"
        txtIncome.Text = ""
        ddlMajor.Text = "Choose one option:"
        ddlCovid.Text = "Choose one option:"

        Me.Dispose()
        FormLogin.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        'Gets all Label controls from the form and sets their color back to Black, in case they were turned red
        'from the user clicking Submit before they had entered information in a required textbox
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = Drawing.Color.Black
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop

        'Sets the color of labels of empty required textboxes to red
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or txtAge.Text = "" Or txtAddress.Text = "" Or ddlSex.Text = "Choose one option:" Or
           txtCity.Text = "" Or (ddlState.Text = "Choose one option:" And ddlCountry.Text = "United States") Or txtZipcode.Text = "" Or
           ddlCountry.Text = "Choose one option:" Or ddlMajor.Text = "Choose one option:" Or ddlCovid.Text = "Choose one option:" Then

            If txtFirstName.Text = "" Then
                lblFirstName.ForeColor = Drawing.Color.Red
            End If
            If txtLastName.Text = "" Then
                lblLastName.ForeColor = Drawing.Color.Red
            End If
            If txtAge.Text = "" Then
                lblAge.ForeColor = Drawing.Color.Red
            End If
            If ddlSex.Text = "Choose one option:" Then
                lblSex.ForeColor = Drawing.Color.Red
            End If
            If txtAddress.Text = "" Then
                lblAddress.ForeColor = Drawing.Color.Red
            End If
            If txtCity.Text = "" Then
                lblCity.ForeColor = Drawing.Color.Red
            End If
            If ddlState.Text = "Choose one option:" And ddlCountry.Text = "United States" Then
                lblState.ForeColor = Drawing.Color.Red
            End If
            If txtZipcode.Text = "" Then
                lblZipcode.ForeColor = Drawing.Color.Red
            End If
            If ddlCountry.Text = "Choose one option:" Then
                lblCountry.ForeColor = Drawing.Color.Red
            End If
            If ddlMajor.Text = "Choose one option:" Then
                lblMajor.ForeColor = Drawing.Color.Red
            End If
            If ddlCovid.Text = "Choose one option:" Then
                lblCovid.ForeColor = Drawing.Color.Red
            End If

            MsgBox("The fields highlighted in red are required.", 48, "Error")
        Else
            Dim rand As New Random          'Creates random number generator
            Dim randomnum As String         'Temporarily stores one random number generated in a string
            Dim randomid As String          'Accumulator of temporary string numbers
            Dim sqlTable As New DataTable   'invisible table for temporary data to see if randomid is already a PersonId in Person table
            Dim rows() As DataRow           'Row in the invisible sqlTable

            Do
                randomid = "M"   'All randomly generated IDs must start with M in the metro campus

                'Deleting previous query information from the sqlTable if I already iterated once through the Do Loop and randomid
                'is already a PersonId on the Person table.  Unlikely to happen, as random code will be between M00000000 and M99999999
                sqlTable.Clear()

                'Generates 8 random numbers between 0 and 9 and adds them to randomid after the "M" character to generate a random ID
                'number for the person we're adding to Person table that starts with "M" and then 8 random numbers (i.e. "M00522144)
                For count = 1 To 8
                    randomnum = rand.Next(0, 10)
                    randomid += randomnum
                Next

                sqlConn.Open()
                sqlCmd.Connection = sqlConn
                'If there's a record in Person table that already has randomly generated ID, selects it
                sqlCmd.CommandText = "SELECT * From Person WHERE (PersonId = '" & randomid & "')"
                sqlReader = sqlCmd.ExecuteReader

                'If there is a selected record, loads it into invisible sqlTable
                sqlTable.Load(sqlReader)
                sqlReader.Close()
                sqlConn.Close()

                'Adds a row to the sqlTable with the record from the Person table with the PersonId same as the randomid (very unlikely)
                rows = sqlTable.Select("[PersonId]= '" & randomid & "'")

                'If the invisible sqlTable has 1 row, this means that there is already a record with a PersonId the same as randomid, so
                'we cannot assign the randomly generated ID to the new person we are trying to add to the Person table.
                'The loop will run again until the row count is not > 0 (until the randomid is not a PersonId already in Person table)
            Loop While (rows.Count > 0)


            sqlConn.Open()
            sqlCmd.Connection = sqlConn
            sqlCmd.CommandText = "INSERT INTO Person(PersonId, FirstName, LastName, Age, Email, Telephone, Sex, Address, City, State,
            Zipcode, Country, HouseIncome, Major, Vaccination)
            VALUES('" & randomid & "','" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtAge.Text & "','" & txtEmail.Text & "',
            '" & txtPhone.Text & "','" & ddlSex.Text & "','" & txtAddress.Text & "','" & txtCity.Text & "','" & ddlState.Text & "',
            '" & txtZipcode.Text & "','" & ddlCountry.Text & "','" & txtIncome.Text & "','" & ddlMajor.Text & "','" & ddlCovid.Text & "')"

            sqlReader = sqlCmd.ExecuteReader
            sqlReader.Close()
            sqlConn.Close()

            MsgBox("Student's information has been submitted." & vbCrLf & "Student's ID number: '" & randomid & "' ", 64, "Information")
        End If
    End Sub

    'Turns the State dropdownlist on/off depending on whether the selected country is United States or not
    Private Sub ddlCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCountry.SelectedIndexChanged
        If ddlCountry.Text = "United States" And ddlState.Text = "" Then
            ddlState.Enabled = True
            ddlState.Text = "Choose one option:"
        ElseIf Not ddlCountry.Text = "United States" Then
            ddlState.Enabled = False
            ddlState.Text = ""
            lblState.ForeColor = Drawing.Color.Black
        End If
    End Sub

    'Does not let user write text on the drop down boxes, only select an option
    Private Sub ddl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlSex.KeyPress, ddlState.KeyPress,
    ddlCountry.KeyPress, ddlMajor.KeyPress, ddlCovid.KeyPress
        e.Handled = True
    End Sub
End Class