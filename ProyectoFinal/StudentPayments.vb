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

    'Used in the btnAW_Click Sub when figuring out which column the section we are trying to drop the student from is
    'in inside the CurrentTermEnrollment table
    Dim sectionid As String
    Dim coursecode As String

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

        ''Loads sections of instructor in sqlTableInstructor to sqlTableSections
        'sqlCmd.CommandText = "SELECT * From CourseSection WHERE InstructorId = '" & sqlTableInstructor.Rows(0).Item("PersonId") & "'"
        'sqlReader = sqlCmd.ExecuteReader
        'sqlTableSections.Load(sqlReader)

        'If sqlTableSections.Rows.Count > 0 Then
        '    For i = 0 To sqlTableSections.Rows.Count - 1
        '        sqlTableCourse.Clear()

        '        'Loads course information of the section from Course table (CourseCode and CourseName is all I need)
        '        sqlCmd.CommandText = "SELECT * From Course WHERE CourseCode = '" & sqlTableSections.Rows(i).Item("CourseCode") & "'"
        '        sqlReader = sqlCmd.ExecuteReader
        '        sqlTableCourse.Load(sqlReader)

        '        ddlAssignedSections.Items.Add("" & sqlTableSections.Rows(i).Item("SectionId") & "  " & sqlTableCourse.Rows(0).Item("CourseCode") & " - " & sqlTableCourse.Rows(0).Item("CourseName") & "")
        '    Next
        'End If
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

    '    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    '        LockAll()
    '        resetfields()
    '        btnApplyAid.Enabled = True
    '        ddlAssignedSections.Enabled = True
    '        ddlAssignedSections.BackColor = Drawing.Color.White
    '        ddlGradeDetail.Items.Clear()
    '    End Sub

    '    Private Sub btnLoadSection_Click(sender As Object, e As EventArgs) Handles btnApplyAid.Click
    '        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
    '            + "Password =" + password + ";" + "Database =" + database

    '        sqlTableDetail.Clear()
    '        sqlTableStudents.Clear()
    '        ddlEnrolled.Items.Clear()

    '        If ddlAssignedSections.Text = "Assigned Sections" Then
    '            MsgBox("Please choose a section to load.", 64, "Information")
    '        Else
    '            sqlConn.Open()
    '            sqlCmd.Connection = sqlConn

    '            sqlCmd.CommandText = "SELECT * FROM GradeDetail
    '            WHERE SectionId = '" & ddlAssignedSections.SelectedItem.ToString.Substring(0, 5) & "'
    '            AND DetailId like '%" & currentterm & "%'"
    '            sqlReader = sqlCmd.ExecuteReader
    '            sqlTableDetail.Load(sqlReader)

    '            For Each row As DataRow In sqlTableDetail.Rows
    '                sqlTableStudents.Clear()

    '                sqlCmd.CommandText = "SELECT * FROM Person WHERE PersonId = '" & row.Item("StudentId") & "'"
    '                sqlReader = sqlCmd.ExecuteReader
    '                sqlTableStudents.Load(sqlReader)

    '                ddlEnrolled.Items.Add("" & row.Item("StudentId") & " - " & sqlTableStudents.Rows(0).Item("FirstName") & " " & sqlTableStudents.Rows(0).Item("LastName") & "")
    '            Next

    '            btnApplyAid.Enabled = False
    '            ddlEnrolled.Enabled = True
    '            ddlEnrolled.BackColor = Drawing.Color.White
    '            btnCheckBalance.Enabled = True
    '            btnCancel.Enabled = True
    '            ddlAssignedSections.Enabled = False

    '            sqlReader.Close()
    '            sqlConn.Close()
    '        End If
    '    End Sub

    '    Private Sub btnLoadDetail_Click(sender As Object, e As EventArgs) Handles btnCheckBalance.Click
    '        'If a student has not been chosen from list
    '        If ddlEnrolled.Text = "" Then
    '            MsgBox("Please choose a student from the list", 64, "Information")

    '        Else
    '            'Clears ddl and table
    '            ddlGradeDetail.Items.Clear()
    '            ddlGradeDetail.Text = "" & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & " - Grade Detail"
    '            sqlTableGrades.Clear()

    '            sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
    '            + "Password =" + password + ";" + "Database =" + database

    '            sqlConn.Open()
    '            sqlCmd.Connection = sqlConn
    '            sqlCmd.CommandText = "SELECT * FROM GradeDetail
    '            WHERE StudentId = '" & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & "'
    '            AND SectionId = '" & ddlAssignedSections.SelectedItem.ToString.Substring(0, 5) & "'
    '            AND DetailId like '%" & currentterm & "%'"

    '            sqlReader = sqlCmd.ExecuteReader
    '            sqlTableGrades.Load(sqlReader)

    '            ddlGradeDetail.Items.Add("Grade1 - " & sqlTableGrades.Rows(0).Item("Grade1") & "")
    '            ddlGradeDetail.Items.Add("Grade2 - " & sqlTableGrades.Rows(0).Item("Grade2") & "")
    '            ddlGradeDetail.Items.Add("Grade3 - " & sqlTableGrades.Rows(0).Item("Grade3") & "")
    '            ddlGradeDetail.Items.Add("Grade4 - " & sqlTableGrades.Rows(0).Item("Grade4") & "")

    '            sqlReader.Close()
    '            sqlConn.Close()

    '            btnMakePayment.Enabled = True
    '            btnFinalGrade.Enabled = True
    '            btnAW.Enabled = True
    '        End If
    '    End Sub

    '    Private Sub btnEnterGrade_Click(sender As Object, e As EventArgs) Handles btnMakePayment.Click
    '        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
    '            + "Password =" + password + ";" + "Database =" + database

    '        sqlConn.Open()
    '        sqlCmd.Connection = sqlConn

    '        'If instructor has not chosen grade from list
    '        If ddlGradeDetail.Text.EndsWith("Detail") Then
    '            MsgBox("Please choose a grade to add or edit from the list.", 64, "Information")

    '            'if the text ends with "- " (i.e. Grade1 - ) that means instructor has not previously added a grade, we would
    '            'not ask the instructor if they are sure they want to update the grade
    '        Else
    '            If ddlGradeDetail.Text.EndsWith("- ") Then

    '                'Trying to gain a number string from the instructor and converting it to Double
    '                Try
    '                    enteredgrade = CDbl(InputBox("Enter grade:", "Search"))

    '                    'Handles exception if use enters something that can't be converted to double (even an empty space)
    '                    'gives them a message and exits the Sub
    '                Catch ex As InvalidCastException
    '                    MsgBox("Please only enter numbers", 64, "Information")
    '                    sqlReader.Close()
    '                    sqlConn.Close()
    '                    Exit Sub
    '                End Try

    '                sqlCmd.CommandText = "UPDATE GradeDetail
    '                SET " & ddlGradeDetail.SelectedItem.ToString.Substring(0, 6) & " = " & enteredgrade & "
    '                WHERE SectionId = '" & ddlAssignedSections.SelectedItem.ToString.Substring(0, 5) & "'
    '                AND DetailId like '%" & currentterm & "%'
    '                AND StudentId = '" & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & "'"
    '                sqlReader = sqlCmd.ExecuteReader

    '                MsgBox("Grade successfully added.", 64, "Information")

    '                'otherwise, if the text is not empty, and it does not end in "- " that means the instructor already added a
    '                'grade, we would ask the instructor if they are sure they want to update the grade
    '            Else
    '                If MsgBox("You have already added a value to this grade, are you sure you want to update it?",
    '                            MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then

    '                    'Trying to gain a number string from the instructor and converting it to Double
    '                    Try
    '                        enteredgrade = CDbl(InputBox("Enter grade:", "Search"))

    '                        'Handles exception if use enters something that can't be converted to double (even an empty space)
    '                        'gives them a message and exits the Sub
    '                    Catch ex As InvalidCastException
    '                        MsgBox("Please only enter numbers", 64, "Information")
    '                        sqlReader.Close()
    '                        sqlConn.Close()
    '                        Exit Sub
    '                    End Try

    '                    sqlCmd.CommandText = "UPDATE GradeDetail
    '                        SET " & ddlGradeDetail.SelectedItem.ToString.Substring(0, 6) & " = " & enteredgrade & "
    '                        WHERE SectionId = '" & ddlAssignedSections.SelectedItem.ToString.Substring(0, 5) & "'
    '                        AND DetailId like '%" & currentterm & "%'
    '                        AND StudentId = '" & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & "'"
    '                    sqlReader = sqlCmd.ExecuteReader

    '                    MsgBox("Grade successfully updated.", 64, "Information")
    '                End If
    '            End If

    '            'Refreshes the ddlGradeDetail to reflect grade changes
    '            sqlReader.Close()
    '            sqlTableGrades.Clear()
    '            ddlGradeDetail.Items.Clear()
    '            ddlGradeDetail.Text = "" & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & " - Grade Detail"
    '            sqlCmd.CommandText = "SELECT * FROM GradeDetail
    '            WHERE StudentId = '" & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & "'
    '            AND SectionId = '" & ddlAssignedSections.SelectedItem.ToString.Substring(0, 5) & "'
    '            AND DetailId like '%" & currentterm & "%'"
    '            sqlReader = sqlCmd.ExecuteReader
    '            sqlTableGrades.Load(sqlReader)

    '            ddlGradeDetail.Items.Add("Grade1 - " & sqlTableGrades.Rows(0).Item("Grade1") & "")
    '            ddlGradeDetail.Items.Add("Grade2 - " & sqlTableGrades.Rows(0).Item("Grade2") & "")
    '            ddlGradeDetail.Items.Add("Grade3 - " & sqlTableGrades.Rows(0).Item("Grade3") & "")
    '            ddlGradeDetail.Items.Add("Grade4 - " & sqlTableGrades.Rows(0).Item("Grade4") & "")
    '        End If

    '        sqlReader.Close()
    '        sqlConn.Close()
    '    End Sub

    '    'Assigns a FinalPercent and FinalGrade to student's record and calculates GPA to add to student's record in Person table
    '    Private Sub btnFinalGrade_Click(sender As Object, e As EventArgs) Handles btnFinalGrade.Click
    '        sqlTableFinishedCourses.Clear()
    '        sqlTableCourseCredits.Clear()
    '        credithourscounter = 0
    '        totalpointscounter = 0
    '        GPA = 0

    '        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
    '            + "Password =" + password + ";" + "Database =" + database

    '        sqlConn.Open()
    '        sqlCmd.Connection = sqlConn

    '        'If instructor still has not entered all of the course's grades
    '        If IsDBNull(sqlTableGrades.Rows(0).Item("Grade1")) Or
    '            IsDBNull(sqlTableGrades.Rows(0).Item("Grade2")) Or
    '            IsDBNull(sqlTableGrades.Rows(0).Item("Grade3")) Or
    '            IsDBNull(sqlTableGrades.Rows(0).Item("Grade4")) Then

    '            MsgBox("Please add all grades before calculating Final Grade.", 64, "Information")

    '        ElseIf Not IsDBNull(sqlTableGrades.Rows(0).Item("FinalGrade")) Then
    '            MsgBox("A Final Grade of '" & sqlTableGrades.Rows(0).Item("FinalGrade") & "' has already been calculated for this student.", 64, "Information")
    '        Else
    '            finalpercent = (sqlTableGrades.Rows(0).Item("Grade1") +
    '                            sqlTableGrades.Rows(0).Item("Grade2") +
    '                            sqlTableGrades.Rows(0).Item("Grade3") +
    '                            sqlTableGrades.Rows(0).Item("Grade4")) / 4

    '            If finalpercent >= 90 Then
    '                finalgrade = "A"
    '            ElseIf finalpercent >= 80 Then
    '                finalgrade = "B"
    '            ElseIf finalpercent >= 70 Then
    '                finalgrade = "C"
    '            ElseIf finalpercent >= 60 Then
    '                finalgrade = "D"
    '            Else
    '                finalgrade = "F"
    '            End If

    '            'Sets FinalPercent and FinalGrade on the specified DetailId on GradeDetail table
    '            sqlCmd.CommandText = "UPDATE GradeDetail 
    '            SET FinalPercent = " & finalpercent & ",
    '            FinalGrade = '" & finalgrade & "'
    '            WHERE StudentId = '" & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & "'
    '            AND SectionId = '" & ddlAssignedSections.SelectedItem.ToString.Substring(0, 5) & "'
    '            AND DetailId like '%" & currentterm & "%'"
    '            sqlReader = sqlCmd.ExecuteReader
    '            sqlReader.Close()

    '            'Retrieving all of the student's finished courses for GPA calculation
    '            sqlCmd.CommandText = "SELECT * FROM GradeDetail
    '            WHERE StudentId = '" & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & "'
    '            AND FinalGrade IS NOT NULL"
    '            sqlReader = sqlCmd.ExecuteReader
    '            sqlTableFinishedCourses.Load(sqlReader)
    '            sqlReader.Close()

    '            For Each row As DataRow In sqlTableFinishedCourses.Rows
    '                'Retrieving course credits for GPA calculation
    '                sqlCmd.CommandText = "SELECT * FROM Course
    '                WHERE CourseCode = '" & row.Item("CourseCode") & "'"
    '                sqlReader = sqlCmd.ExecuteReader
    '                sqlTableCourseCredits.Load(sqlReader)
    '                sqlReader.Close()

    '                'Accruing student's total credit hours
    '                credithourscounter += sqlTableCourseCredits.Rows(0).Item("Credits")

    '                If row.Item("FinalGrade") = "A" Then
    '                    totalpointscounter += 4 * sqlTableCourseCredits.Rows(0).Item("Credits")
    '                ElseIf row.Item("FinalGrade") = "B" Then
    '                    totalpointscounter += 3 * sqlTableCourseCredits.Rows(0).Item("Credits")
    '                ElseIf row.Item("FinalGrade") = "C" Then
    '                    totalpointscounter += 2 * sqlTableCourseCredits.Rows(0).Item("Credits")
    '                ElseIf row.Item("FinalGrade") = "D" Then
    '                    totalpointscounter += 1 * sqlTableCourseCredits.Rows(0).Item("Credits")
    '                    'If student got an F there's no need for any total points calculations, as an F is worth 0
    '                End If
    '            Next

    '            GPA = totalpointscounter / credithourscounter

    '            sqlCmd.CommandText = "UPDATE Person SET GPA = " & GPA & "
    '            WHERE PersonId = '" & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & "'"
    '            sqlReader = sqlCmd.ExecuteReader

    '            MsgBox("Final percentage of " & finalpercent & "% has been calculated." & vbNewLine & "Final grade = " & finalgrade & "", 64, "Information")
    '        End If

    '        sqlReader.Close()
    '        sqlConn.Close()
    '    End Sub

    '    'Assigns an AW to student, dropping them from the course, deletes the record off the DetailId table, and the
    '    'SectionId and CourseCode off the CurrentTermEnrollment table
    '    Private Sub btnAW_Click(sender As Object, e As EventArgs) Handles btnAW.Click
    '        sqlTableEnrollment.Clear()

    '        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
    '            + "Password =" + password + ";" + "Database =" + database

    '        sqlConn.Open()
    '        sqlCmd.Connection = sqlConn

    '        If MsgBox("You are about to DROP the student " & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & "
    'from this course, are you sure you want to proceed?",
    '                  MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then

    '            confirmdrop = InputBox("Please enter the student's ID:", "Confirm AW")

    '            'Checks that ID entered by instructor and student's ID is the same before giving AW
    '            If confirmdrop.ToString.ToUpper = ddlEnrolled.SelectedItem.ToString.Substring(0, 9) Then

    '                'Deleting record from GradeDetail table
    '                sqlCmd.CommandText = "DELETE FROM GradeDetail
    '                WHERE SectionId = '" & ddlAssignedSections.SelectedItem.ToString.Substring(0, 5) & "'
    '                AND DetailId like '%" & currentterm & "%'
    '                AND StudentId = '" & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & "'"
    '                sqlReader = sqlCmd.ExecuteReader
    '                sqlReader.Close()

    '                'Loading CurrentTermEnrollment table to be able to take the course off that table
    '                sqlCmd.CommandText = "SELECT * FROM CurrentTermEnrollment
    '                WHERE StudentId = '" & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & "'"
    '                sqlReader = sqlCmd.ExecuteReader
    '                sqlTableEnrollment.Load(sqlReader)

    '                'The course we are trying to take the student off can be enrolled in either the SectionId1, SectionId2,
    '                'SectionId3, or SectionId4 column of the student's record in the CurrentTermEnrollment table.  We are
    '                'using this IF statement to go through all possible columns where the course could be in.  If the column
    '                'is not null AND its SectionId is the same as the first 5 characters of the ddlAssignedSections (the SectionId)
    '                'then the section and course variable are given the correct column names to then be dropped from the
    '                'student's record in the CurrentTermEnrollment table.
    '                If Not IsDBNull(sqlTableEnrollment.Rows(0).Item("SectionId1")) And
    '                    ddlAssignedSections.SelectedItem.ToString.Substring(0, 5) = "" & sqlTableEnrollment.Rows(0).Item("SectionId1") & "" Then
    '                    sectionid = "SectionId1"
    '                    coursecode = "CourseCode1"

    '                ElseIf Not IsDBNull(sqlTableEnrollment.Rows(0).Item("SectionId2")) And
    '                    ddlAssignedSections.SelectedItem.ToString.Substring(0, 5) = "" & sqlTableEnrollment.Rows(0).Item("SectionId2") & "" Then
    '                    sectionid = "SectionId2"
    '                    coursecode = "CourseCode2"

    '                ElseIf Not IsDBNull(sqlTableEnrollment.Rows(0).Item("SectionId3")) And
    '                    ddlAssignedSections.SelectedItem.ToString.Substring(0, 5) = "" & sqlTableEnrollment.Rows(0).Item("SectionId3") & "" Then
    '                    sectionid = "SectionId3"
    '                    coursecode = "CourseCode3"

    '                Else
    '                    sectionid = "SectionId4"
    '                    coursecode = "CourseCode4"
    '                End If

    '                'Taking SectionId and CourseCode from the CurrentTermEnrollment table
    '                sqlCmd.CommandText = "UPDATE CurrentTermEnrollment
    '                SET " & sectionid & " = NULL, " & coursecode & " = NULL
    '                WHERE StudentId = '" & ddlEnrolled.SelectedItem.ToString.Substring(0, 9) & "'"
    '                sqlReader = sqlCmd.ExecuteReader

    '                'Need to do this because GradeDetail information stays on the ddlGradeDetail, and the student's ID and
    '                'name stay on the ddlEnrolled otherwise.  This makes the professor have to load the section again, at which
    '                'point the dropped student will no longer show up.
    '                'I also want to do this by design, assigning an AW should not be taken lightly and I want the instructor
    '                'to have to load the section again and take things slow when assigning AWs.
    '                LockAll()
    '                resetfields()
    '                btnApplyAid.Enabled = True
    '                ddlAssignedSections.Enabled = True
    '                ddlAssignedSections.BackColor = Drawing.Color.White
    '                ddlGradeDetail.Items.Clear()

    '                MsgBox("Student successfully dropped from course.", 64, "Information")

    '                'If entered ID noes not match student's ID
    '            Else
    '                MsgBox("The ID entered does not match the student's ID.", 48, "Error")
    '            End If
    '        End If

    '        sqlReader.Close()
    '        sqlConn.Close()
    '    End Sub

    '    'To avoid erroneous input of data, everytime the enrolled student is changed, the student's grade detail will
    '    'disappear from ddlGradeDetail, and the Enter Grade, Final Grade, and Enter AW buttons will be disabled.  We will
    '    'have to click the Load Student Grade Detail button again to enable them
    '    Private Sub ddlEnrolled_SelectedIndexChanged(sender As Object, e As EventArgs)
    '        ddlGradeDetail.Items.Clear()
    '        ddlGradeDetail.Text = ""
    '        btnMakePayment.Enabled = False
    '        btnFinalGrade.Enabled = False
    '        btnAW.Enabled = False
    '    End Sub

    '    'Does not let user write text on the drop down boxes, only select an option
    '    Private Sub ddl_KeyPress(sender As Object, e As KeyPressEventArgs)
    '        e.Handled = True
    '    End Sub

    '    Private Sub resetfields()
    '        Dim ctrl As Control = Me.GetNextControl(Me, True)
    '        Do Until ctrl Is Nothing
    '            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
    '                ctrl.Text = ""
    '            End If

    '            ddlAssignedSections.Text = "Assigned Sections"

    '            ctrl = Me.GetNextControl(ctrl, True)
    '        Loop
    '    End Sub

    '    'Gets all Label controls from the form and sets their color back to Black, in case they were turned red
    '    'from the user clicking Submit before they had entered information in a required textbox
    '    Private Sub resetlabelcolor()
    '        Dim ctrl As Control = Me.GetNextControl(Me, True)
    '        Do Until ctrl Is Nothing
    '            If TypeOf ctrl Is Label Then
    '                ctrl.ForeColor = Color.FromArgb(48, 48, 48)
    '            End If
    '            ctrl = Me.GetNextControl(ctrl, True)
    '        Loop
    '    End Sub

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