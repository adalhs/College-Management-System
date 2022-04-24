Imports System.Data.SqlClient

Public Class AdmissionsUpdateStudent

    Dim sqlConn As New SqlConnection  'represents a unique session(connection) to a SQL Server data source
    Dim sqlCmd As New SqlCommand
    Dim sqlReader As SqlDataReader    'sqlReader is not an object, does not need "New"
    Dim sqlTable As New DataTable     'invisible table to hold temporady data

    Dim server As String = "LAPTOP-11N7BEC8\SQLEXPRESS"
    Dim username As String = "sa"
    Dim password As String = "12345678"
    Dim database As String = "InterMetro"

    Dim idlookup As String     'saves PersonId entered by user in SearchStudId()

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

        'Update student disabled when form firsts load so user cannot click update without a PersonId from the Person
        'table in the idlookup variable, this would throw an error when trying to UPDATE a record with an empty PersonId
        btnUpdateStudent.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        AdmissionsMenu.Show()
        Me.Close()
    End Sub

    'Searches student record by providing ID number
    Private Sub btnSearchStudId_Click(sender As Object, e As EventArgs) Handles btnSearchStudId.Click
        sqlTable.Clear()    'Clears invisible table
        idlookup = InputBox("Enter Student's ID:", "Student Search")

        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * From Person WHERE PersonId = '" & idlookup & "'"
        sqlReader = sqlCmd.ExecuteReader

        sqlTable.Load(sqlReader)     'Loads record matching ID provided to invisible sqlTable
        sqlReader.Close()
        sqlConn.Close()

        'Loads sqlTable's record's data to the fields on form because a record on the Person table matched the ID provided to PersonId column
        If sqlTable.Rows.Count > 0 Then
            'Enables the Update button if there is a PersonId from Person table in idlookup variable
            btnUpdateStudent.Enabled = True

            Label1.Text = "Student's ID: " & sqlTable.Rows(0).Item("PersonId") & ""
            txtFirstName.Text = sqlTable.Rows(0).Item("FirstName")
            txtLastName.Text = sqlTable.Rows(0).Item("LastName")
            txtAge.Text = sqlTable.Rows(0).Item("Age")
            txtEmail.Text = sqlTable.Rows(0).Item("Email")
            txtPhone.Text = sqlTable.Rows(0).Item("Telephone")
            ddlSex.Text = sqlTable.Rows(0).Item("Sex")
            txtAddress.Text = sqlTable.Rows(0).Item("Address")
            txtCity.Text = sqlTable.Rows(0).Item("City")
            ddlState.Text = sqlTable.Rows(0).Item("State")
            txtZipcode.Text = sqlTable.Rows(0).Item("Zipcode")
            ddlCountry.Text = sqlTable.Rows(0).Item("Country")
            txtIncome.Text = sqlTable.Rows(0).Item("HouseIncome")
            ddlMajor.Text = sqlTable.Rows(0).Item("Major")
            ddlCovid.Text = sqlTable.Rows(0).Item("Vaccination")

            'If user clicks Cancel button on the idlookup input box or presses OK button while the textbox is empty nothing happens
        ElseIf ReferenceEquals(idlookup, String.Empty) Then

            'Disables update button so user cannot do an UPDATE with an empty or wrong string
            btnUpdateStudent.Enabled = False
            'Resets label, removing Student ID if there was one on it
            Label1.Text = "Update Student Information"

        Else 'User entered something on the idlookup inputbox but it didn't match any PersonIds on the Person table
            MsgBox("Student ID: " & idlookup & " not found.", 64, "Information")

            'Disables update button so user cannot do an UPDATE with an empty or wrong string
            btnUpdateStudent.Enabled = False
            'Resets label, removing Student ID if there was one on it
            Label1.Text = "Update Student Information"
        End If
    End Sub

    'Updates Person
    Private Sub btnUpdateStudent_Click(sender As Object, e As EventArgs) Handles btnUpdateStudent.Click
        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

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

            'To pass correct address to the ConfirmInfo function below depending on whether the person's country is United States or not
            Dim address As String
            If ddlState.Text = "" Then
                address = txtAddress.Text + ", " + txtCity.Text + ", " + ddlCountry.Text + " " + txtZipcode.Text
            Else
                address = txtAddress.Text + ", " + txtCity.Text + ", " + ddlState.Text + ", " + ddlCountry.Text + " " + txtZipcode.Text
            End If

            'If the user didn't leave any required fields empty, the information is saved to the StudentInfo text box
            txtStudentUpdate.Text = "Is this information correct?" & vbNewLine &
                                    "" & vbNewLine &
                                    "NAME: " & txtFirstName.Text & " " & txtLastName.Text & "" & vbNewLine &
                                    "AGE: " & txtAge.Text & "" & vbNewLine &
                                    "SEX: " & ddlSex.Text & "" & vbNewLine &
                                    "EMAIL: " & txtEmail.Text & "" & vbNewLine &
                                    "PHONE: " & txtPhone.Text & "" & vbNewLine &
                                    "ADDRESS: " & address & "" & vbNewLine &
                                    "MAJOR: " & ddlMajor.Text & "" & vbNewLine &
                                    "VACCINATION STATUS: " & ddlCovid.Text & "" & vbNewLine &
                                    "YEARLY HOUSEHOLD INCOME: $" & txtIncome.Text & ""

            'I am using this form as a custom MsgBox as the original MsgBox' font size is too small
            'In it I am putting StudentInfo's textbox string and setting it on a label and adjusting font size
            'I am putting a code on the public shared variable so that FormCustomMsgBox will return me here
            CustomMsgBoxCode = "2"
            FormCustomMsgBox.Show()
        End If
    End Sub

    Public Sub UpdateStudentInfo()
        'Closing it here instead of its own vb code file because it flows better
        FormCustomMsgBox.Close()

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        With sqlCmd

            .CommandText = "UPDATE Person set FirstName = @FirstName, LastName = @LastName, Age = @Age, Email = @Email,
            Telephone = @Telephone, Sex = @Sex, Address = @Address, City = @City, State = @State, Zipcode = @Zipcode, 
            Country = @Country, HouseIncome = @HouseIncome, Major = @Major, Vaccination = @Vaccination where PersonId = '" & idlookup & "'"

            .Parameters.Clear()   'Clears parameters values
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@LastName", txtLastName.Text)
            .Parameters.AddWithValue("@Age", txtAge.Text)
            .Parameters.AddWithValue("@Email", txtEmail.Text)
            .Parameters.AddWithValue("@Telephone", txtPhone.Text)
            .Parameters.AddWithValue("@Sex", ddlSex.Text)
            .Parameters.AddWithValue("@Address", txtAddress.Text)
            .Parameters.AddWithValue("@City", txtCity.Text)
            .Parameters.AddWithValue("@State", ddlState.Text)
            .Parameters.AddWithValue("@Zipcode", txtZipcode.Text)
            .Parameters.AddWithValue("@Country", ddlCountry.Text)
            .Parameters.AddWithValue("@HouseIncome", txtIncome.Text)
            .Parameters.AddWithValue("@Major", ddlMajor.Text)
            .Parameters.AddWithValue("@Vaccination", ddlCovid.Text)
        End With

        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        MsgBox("Student information successfully updated.", 64, "Information")
    End Sub

    'Does not let user write text on the drop down boxes, only select an option
    Private Sub ddl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlSex.KeyPress, ddlState.KeyPress,
    ddlCountry.KeyPress, ddlMajor.KeyPress, ddlCovid.KeyPress
        e.Handled = True
    End Sub

    'Turns the State dropdownlist on/off depending on whether the selected country is United States or not
    Private Sub ddlCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCountry.SelectedIndexChanged
        If ddlCountry.Text = "United States" And ddlState.Text = "" Then
            ddlState.Enabled = True
            ddlState.Text = "Choose one option:"
        ElseIf Not ddlCountry.Text = "United States" Then
            ddlState.Enabled = False
            ddlState.Text = ""
            lblState.ForeColor = Color.FromArgb(48, 48, 48)
        End If
    End Sub
End Class