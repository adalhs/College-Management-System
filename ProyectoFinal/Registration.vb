Imports System.Data.SqlClient

Public Class Registration

    Dim sqlConn As New SqlConnection  'represents a unique session(connection) to a SQL Server data source
    Dim sqlCmd As New SqlCommand
    Dim sqlReader As SqlDataReader   'sqlReader is not an object, does not need "New"

    Dim sqlTableStudent As New DataTable   'invisible table to hold data from Person table
    Dim sqlTableSection As New DataTable     'invisible table to hold course section data from CourseSection table
    Dim sqlTableInstructor As New DataTable   'invisible table to hold Instructor data (name is all I need) from Person table
    Dim sqlTableCourse As New DataTable      'invisible table to hold Course data (name is all I need) from the Course table

    Dim sqlTableEnrollment As New DataTable  'invisible table to hold Enrollment data to see what, if any classes student has already
    'enrolled in.  Student can only enroll in a maximum of 4 courses

    Dim sqlTableCourseForDrop As New DataTable  'This datatable will be used to load the course we are going to drop so we
    'can get its credits to take off the correct amount from BalanceDue when we drop the course. I had to create another
    'table for this because in the current way the program flows, TableCourse is filled with more than one course when
    'we get to the function that will drop the course from the CurrentTermEnrollment table (It's in the btnSubmit_Click Sub)
    'and there is no way to know which row of that table the course we want to take off is in, potentially leading to taking
    'off the incorrect amount of money due to different Credits from the Course table.

    Dim sqlTableGradeDetail As New DataTable   'invisible table to hold GradeDetail data so we can add a grade detail for the student
    'for that course in the GradeDetail table when we add a course, remove it when we drop a course, and to check if the student
    'fulfills PreRequisite classes for certain courses and obtained 60 or greater final grade in the Prerequisite course

    Dim server As String = "LAPTOP-11N7BEC8\SQLEXPRESS"
    Dim username As String = "sa"
    Dim password As String = "12345678"
    Dim database As String = "InterMetro"

    Dim idlookup As String   'holds StudentId entered by user
    Dim sectionlookup As String   'holds sectionid entered by user

    Dim currentterm As String = "-2022-23"    'to be used when assigning EnrollmentId in AddSection Sub

    'Used in AddSection Sub to see if student has room for another class (maximum of 4 classes per term allowed)
    Dim section As String
    Dim course As String

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddlMajor.Items.Add("Computer Science")
        ddlMajor.Items.Add("Chemistry")

        LockAll()

        'Disabled at form load, didn't put it in LockAll since it has to remain open as long as a record is open
        btnCloseRecord.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        PortalMenu.Show()
        Me.Close()
    End Sub

    'This function asks for a PersonId, if there is one, and it belongs to a student,
    'it opens up the rest of record options, if there isn't gives error message saying ID doesn't exist
    Private Sub btnOpenRecord_Click(sender As Object, e As EventArgs) Handles btnOpenRecord.Click
        LockAll()
        resetlabelcolor()
        resetfields()

        sqlTableStudent.Clear()    'Clears invisible table
        idlookup = InputBox("Enter ID:", "Search")

        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * From Person WHERE PersonId = '" & idlookup & "'"
        sqlReader = sqlCmd.ExecuteReader

        sqlTableStudent.Load(sqlReader)     'Loads record matching ID provided to invisible sqlTable
        sqlReader.Close()
        sqlConn.Close()

        'If user clicks Cancel button on the idlookup input box or presses OK button while the textbox is empty nothing happens
        If ReferenceEquals(idlookup, String.Empty) Then
            'Do Nothing

            'User entered something on the idlookup inputbox but it didn't match any PersonIds on the Person table
        ElseIf sqlTableStudent.Rows.Count = 0 Then
            MsgBox("ID: " & idlookup & " not found.", 64, "Information")

            'User entered something on the idlookup inputbox and it mached a PersonId in the Person table but person still
            'has not been assigned a Role by admin to tell whether this person is a student or not
        ElseIf sqlTableStudent.Rows.Count > 0 And IsDBNull((sqlTableStudent.Rows(0).Item("Role"))) Then
            MsgBox("ID: " & idlookup & " has not been assigned a role.  See admin.", 64, "Information")

            'User entered something on the idlookup inputbox and it matched a PersonId in the Person table but does not belong
            'to a record with Role = student
        ElseIf sqlTableStudent.Rows.Count > 0 And Not sqlTableStudent.Rows(0).Item("Role") = "student" Then
            MsgBox("ID: " & idlookup & " does not belong to a student.", 64, "Information")


        Else 'If ID exists and belongs to a student
            btnCloseRecord.Enabled = True

            'Disabled until user closes the currently open record
            btnOpenRecord.Enabled = False

            btnChangeMajor.Enabled = True
            btnAddCourse.Enabled = True
            btnDropCourse.Enabled = True
            lblPersonInfo.Visible = True
            lblPersonInfo.Text = "" & sqlTableStudent.Rows(0).Item("PersonId") & " - " & sqlTableStudent.Rows(0).Item("FirstName") & " " & sqlTableStudent.Rows(0).Item("LastName") & ""

            'User control
            btnOpenRecord.Enabled = False
        End If
    End Sub

    Private Sub btnCloseRecord_Click(sender As Object, e As EventArgs) Handles btnCloseRecord.Click
        LockAll()
        resetlabelcolor()
        resetfields()
        lblPersonInfo.Visible = False

        'Allows user to open another record
        btnOpenRecord.Enabled = True

        'Disabled until user opens another record
        btnCloseRecord.Enabled = False
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        'Clearing all tables used in this function
        sqlTableSection.Clear()
        sqlTableCourse.Clear()
        sqlTableInstructor.Clear()

        sectionlookup = InputBox("Enter Section ID:", "Search")

        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * From CourseSection WHERE SectionId = '" & sectionlookup & "'"
        sqlReader = sqlCmd.ExecuteReader

        sqlTableSection.Load(sqlReader)     'Loads info from the CourseSection table by matching the SectionId provided

        'If user clicks Cancel button on the idlookup input box or presses OK button while the textbox is empty nothing happens
        If ReferenceEquals(sectionlookup, String.Empty) Then
            'Do Nothing

            'User entered something on the sectionlookup inputbox but it didn't match any SectionIds on the CourseSection table
        ElseIf sqlTableSection.Rows.Count = 0 Then
            MsgBox("Section ID: " & sectionlookup & " not found.", 64, "Information")

        Else
            'Using the InstructorId to get the name of the instructor from the Person table
            sqlCmd.CommandText = "Select * From Person WHERE PersonId = '" & sqlTableSection.Rows(0).Item("InstructorId") & "'"
            sqlReader = sqlCmd.ExecuteReader
            sqlTableInstructor.Load(sqlReader)     'Loads instructor record from Person table to get their FirstName and LastName

            'Using the CourseCode to get the name of the course from the Course table
            sqlCmd.CommandText = "Select * From Course WHERE CourseCode = '" & sqlTableSection.Rows(0).Item("CourseCode") & "'"
            sqlReader = sqlCmd.ExecuteReader
            sqlTableCourse.Load(sqlReader)     'Loads Course record from the Course table to get the CourseName

            'If the Major the course belongs to is not the same Major as the student does not let them enroll in it
            If Not sqlTableCourse.Rows(0).Item("Major") = sqlTableStudent.Rows(0).Item("Major") Then
                MsgBox("Cannot add course to student record - Major Restriction", 48, "Error")
            Else
                'the information is saved to the Information text box
                txtInformation.Text = "Confirm course selection" & vbNewLine &
                                    "" & vbNewLine &
                                    "SECTION ID: " & sqlTableSection.Rows(0).Item("SectionId") & "" & vbNewLine &
                                    "COURSE NAME: " & sqlTableSection.Rows(0).Item("CourseCode") & " - " & sqlTableCourse.Rows(0).Item("CourseName") & "" & vbNewLine &
                                    "SCHEDULE: Days: " & sqlTableSection.Rows(0).Item("Days") & " / Time: " & sqlTableSection.Rows(0).Item("Time") & " / Room: " & sqlTableSection.Rows(0).Item("Classroom") & "" & vbNewLine &
                                    "INSTRUCTOR: " & sqlTableInstructor.Rows(0).Item("FirstName") & " " & sqlTableInstructor.Rows(0).Item("LastName") & ""

                'I am using this form as a custom MsgBox as the original MsgBox' font size is too small
                'In it I am putting the textbox string and setting it on a label and adjusting font size
                'I am putting a code on the public shared variable so that FormCustomMsgBox will return me here
                CustomMsgBoxCode = "3"
                FormCustomMsgBox.Show()
            End If
        End If

        sqlReader.Close()
        sqlConn.Close()
    End Sub

    Private Sub btnDropCourse_Click(sender As Object, e As EventArgs) Handles btnDropCourse.Click
        sqlTableEnrollment.Clear()
        sqlTableCourse.Clear()

        ddlEnrolled.Items.Clear()

        LockAll()

        lblPersonInfo.Visible = True
        btnSubmit.Enabled = True
        btnCancel.Enabled = True
        ddlEnrolled.Enabled = True
        ddlEnrolled.BackColor = Color.White

        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        'Loading student's enrollment record to get his classes
        sqlCmd.CommandText = "Select * FROM CurrentTermEnrollment WHERE StudentId = '" & idlookup & "'"
        sqlReader = sqlCmd.ExecuteReader
        sqlTableEnrollment.Load(sqlReader)

        'If student has been enrolled in at least one course and already has a record in Enrollment table
        If sqlTableEnrollment.Rows.Count > 0 Then

            'Goes through all possible 4 courses enrolled
            For i = 1 To 4

                'If there is a course actually in the slot
                If Not IsDBNull(sqlTableEnrollment.Rows(0).Item("SectionId" & i & "")) Then

                    'Loading Course table to be able to show the names of the enrolled courses
                    sqlCmd.CommandText = "Select * FROM Course WHERE CourseCode = '" & sqlTableEnrollment.Rows(0).Item("CourseCode" & i & "") & "'"
                    sqlReader = sqlCmd.ExecuteReader
                    sqlTableCourse.Load(sqlReader)

                    ddlEnrolled.Items.Add("" & sqlTableCourse.Rows(0).Item("CourseCode") & " - " & sqlTableCourse.Rows(0).Item("CourseName") & "")

                    sqlTableCourse.Clear()
                End If
            Next
        End If

        sqlReader.Close()
        sqlConn.Close()
    End Sub

    Private Sub btnChangeMajor_Click(sender As Object, e As EventArgs) Handles btnChangeMajor.Click
        sqlTableEnrollment.Clear()

        btnAddCourse.Enabled = False
        btnDropCourse.Enabled = False
        btnChangeMajor.Enabled = False
        btnSubmit.Enabled = True
        btnCancel.Enabled = True
        ddlMajor.Enabled = True
        ddlMajor.BackColor = Color.White

        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "Select * FROM CurrentTermEnrollment WHERE StudentId = '" & idlookup & "'"
        sqlReader = sqlCmd.ExecuteReader
        sqlTableEnrollment.Load(sqlReader)

        sqlReader.Close()
        sqlConn.Close()
    End Sub

    'Submit button will serve to both drop courses and change majors, it will decide which one to do depending on the .Enabled
    'state of each ddl.  If the Enrolled ddl is Enabled = True, then it will drop the selected course when clicked.  If the Major ddl
    'is Enabled = True, it will change Major of the student to selected one.  Must be careful to not allow both ddls to be Enabled = True
    'at the same time.
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        sqlTableCourseForDrop.Clear()

        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        'If I clicked Drop Course button, ddlEnrolled will be enabled and Submit button will serve to Drop Courses
        If ddlEnrolled.Enabled = True Then
            If ddlEnrolled.Text = "" Then
                lblEnrolled.ForeColor = Drawing.Color.Red
                MsgBox("You must choose a course to drop.", 48, "Error")

            Else
                'Goes through all 4 possible courses enrolled
                For i = 1 To 4

                    'If there is actually a course in the slot
                    If Not IsDBNull(sqlTableEnrollment.Rows(0).Item("CourseCode" & i & "")) Then

                        'If the CourseCode in the table matches the first 9 letters (the CourseCode) of the selected item on
                        'ddl Enrolled
                        If sqlTableEnrollment.Rows(0).Item("CourseCode" & i & "") = ddlEnrolled.SelectedItem.ToString.Substring(0, 9) Then

                            If MsgBox("Are you sure you want to DROP the course " & sqlTableEnrollment.Rows(0).Item("CourseCode" & i & "") & "?
Doing so will get rid of any grades the student has attained in this course and is an IRREVERSIBLE process.",
                            MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then

                                'Loads Credits of course to be taken off for BalanceDue calculations
                                sqlCmd.CommandText = "SELECT * FROM Course
                                WHERE CourseCode = '" & sqlTableEnrollment.Rows(0).Item("CourseCode" & i & "") & "'"
                                sqlReader = sqlCmd.ExecuteReader
                                sqlTableCourseForDrop.Load(sqlReader)
                                sqlReader.Close()

                                'Takes SectionId and CourseCode of the course off the CurrentTermEnrollment table and
                                'subtracts the amount owed for the course from BalanceDue.  Sets both Grant fields to 
                                'NULL since the student has changed the amount of credits they had.  They must re-apply
                                'for student aid in their portal.
                                sqlCmd.CommandText = "UPDATE CurrentTermEnrollment SET SectionId" & i & " = NULL,
                                CourseCode" & i & " = NULL,
                                BalanceDue = BalanceDue - 180 * " & sqlTableCourseForDrop.Rows(0).Item("Credits") & ",
                                GrantAmount = NULL,
                                GrantAvailable = NULL
                                WHERE StudentId = '" & idlookup & "'"
                                sqlReader = sqlCmd.ExecuteReader
                                sqlReader.Close()

                                'Dropping only the course entry from this currentterm, leaving any other records there may be of
                                'the student taking that class in previous terms intact in the GradeDetail table
                                sqlCmd.CommandText = "DELETE FROM GradeDetail
                                WHERE DetailId = '" & idlookup & "" & currentterm & "-" & sqlTableEnrollment.Rows(0).Item("CourseCode" & i & "") & "'"
                                sqlReader = sqlCmd.ExecuteReader

                                MsgBox("The course " & ddlEnrolled.Text & " has been successfully dropped.", 64, "Information")

                                resetfields()

                                btnAddCourse.Enabled = True
                                btnDropCourse.Enabled = True
                                btnChangeMajor.Enabled = True
                                btnSubmit.Enabled = False
                                btnCancel.Enabled = False
                                ddlEnrolled.Enabled = False
                            End If
                        End If
                    End If
                    resetlabelcolor()
                Next
            End If

            'If I clicked Change Major button, ddlMajor will be enabled and Submit button will be used to change student major
        Else
            If ddlMajor.Text = "" Then
                lblMajor.ForeColor = Drawing.Color.Red
                MsgBox("You must choose a major to change to.", 48, "Error")

                'Changing majors does not drop the student from his current classes automatically.  They must finish them
                'if they don't want their GPA to be affected, or they must be dropped manually.
            Else
                sqlCmd.CommandText = "UPDATE Person SET Major = '" & ddlMajor.Text & "' WHERE PersonId = '" & idlookup & "'"
                sqlReader = sqlCmd.ExecuteReader
                sqlReader.Close()

                'Clearing and reloading the sqlTableStudent because we changed data in the Person table, otherwise, we can run into
                'problems when adding courses to the student, it will still not allow us to enroll them in the new courses for his
                'major, or will still allow us to enroll them in courses for their old major because the sqlTableStudent will still
                'have the old Person table data in it.
                sqlTableStudent.Clear()
                sqlCmd.CommandText = "SELECT * From Person WHERE PersonId = '" & idlookup & "'"
                MsgBox("Student's major has been successfully changed to " & ddlMajor.Text & ".", 64, "Information")
                sqlReader = sqlCmd.ExecuteReader
                sqlTableStudent.Load(sqlReader)

                resetfields()
                resetlabelcolor()

                btnAddCourse.Enabled = True
                btnDropCourse.Enabled = True
                btnChangeMajor.Enabled = True
                btnSubmit.Enabled = False
                btnCancel.Enabled = False
                ddlMajor.Enabled = False
            End If
        End If

        sqlReader.Close()
        sqlConn.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ddlEnrolled.BackColor = Drawing.Color.Silver
        ddlEnrolled.Enabled = False
        ddlMajor.BackColor = Drawing.Color.Silver
        ddlMajor.Enabled = False

        resetfields()
        resetlabelcolor()

        'User control
        btnAddCourse.Enabled = True
        btnDropCourse.Enabled = True
        btnChangeMajor.Enabled = True
        btnSubmit.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Public Sub AddSection()
        sqlTableEnrollment.Clear()
        sqlTableGradeDetail.Clear()

        'Closing it here instead of its own vb code file because it flows better
        FormCustomMsgBox.Close()

        'Used in courses that have Prerequisites, set to True if student completed prereq with FinalPercent >= 60%, False otherwise
        Dim passedcourse As New Boolean

        section = ""
        course = ""

        sqlConn.ConnectionString = "Server =" + server + ";" + "User ID =" + username + ";" _
            + "Password =" + password + ";" + "Database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        'Loads record from CurrentTermEnrollment with StudentId = idlookup to be able to add sections to it
        sqlCmd.CommandText = "Select * FROM CurrentTermEnrollment WHERE StudentId = '" & idlookup & "'"
        sqlReader = sqlCmd.ExecuteReader
        sqlTableEnrollment.Load(sqlReader)

        'Loading information from GradeDetail table for purposes of knowing whether student completed the prerequisite 
        sqlCmd.CommandText = "Select * From GradeDetail WHERE StudentId = '" & idlookup & "'"
        sqlReader = sqlCmd.ExecuteReader
        sqlTableGradeDetail.Load(sqlReader)

        'Checking for prerequisite course completion if the selected course has one (If PreReq field in Course table is not empty)
        If Not sqlTableCourse.Rows(0).Item("PreReq") = "" Then
            For Each row As DataRow In sqlTableGradeDetail.Rows

                'Evaluates courses that are currently not in progress (Where FinalPercent has already been applied)
                'to check for prerequisite completion
                If Not IsDBNull(row.Item("FinalPercent")) Then

                    'If student completed PreReq with >= 60%
                    If row.Item("CourseCode") = sqlTableCourse.Rows(0).Item("PreReq") And row.Item("FinalPercent") >= 60 Then

                        'Sets passedcourse to True if student got FinalPercent >= 60.  It is possible, but very unlikely that the student
                        'may have passed the course and repeats it, then gets FinalPercent <60.  Triggering the lower ElseIf, having then to retake
                        'the prerequisite course.  This is normal functionality though, as in colleges only the latest grade applies, not
                        'the highest, so you CAN get a worse, or even failing grade on a repeat class.
                        passedcourse = True

                        'Student completed PreReq but obtained a FinalPercent < 60
                    ElseIf row.Item("CourseCode") = sqlTableCourse.Rows(0).Item("PreReq") And row.Item("FinalPercent") < 60 Then
                        passedcourse = False
                    End If

                    'If latest attempt at the course is in progress
                ElseIf IsDBNull(row.Item("FinalPercent")) Then
                    passedcourse = False
                End If
            Next row

            If passedcourse = False Then
                MsgBox("Student has not completed the prerequisite course " & sqlTableCourse.Rows(0).Item("PreReq") & " or must retake it.", 64, "Information")

                'Closing here because I'm exiting Sub so it won't get to the end where the .Close statements are
                sqlReader.Close()
                sqlConn.Close()
                Exit Sub
            End If
        End If

        'If student doesn't yet have a record in the CurrentTermEnrollment table
        If sqlTableEnrollment.Rows.Count = 0 Then
            section = "SectionId1"
            course = "CourseCode1"
            'If student doesn't have a class enrolled in Section1
        ElseIf IsDBNull(sqlTableEnrollment.Rows(0).Item("SectionId1")) Then
            section = "SectionId1"
            course = "CourseCode1"
            'If student doesn't have a class enrolled in Section2
        ElseIf IsDBNull(sqlTableEnrollment.Rows(0).Item("SectionId2")) Then
            section = "SectionId2"
            course = "CourseCode2"
            'If student doesn't have a class enrolled in Section3
        ElseIf IsDBNull(sqlTableEnrollment.Rows(0).Item("SectionId3")) Then
            section = "SectionId3"
            course = "CourseCode3"
            'If student doesn't have a class enrolled in Section4
        ElseIf IsDBNull(sqlTableEnrollment.Rows(0).Item("SectionId4")) Then
            section = "SectionId4"
            course = "CourseCode4"
        Else
            'If student has all 4 section columns of CurrentTermEnrollment table filled
            MsgBox("Student cannot enroll in any more courses for this term without faculty authorization.", 64, "Information")
        End If


        'If section has a value that means the student has a spot for a course open in the current term
        If Not section = "" Then

            'If student already has a record in the CurrentTermEnrollment table it adds only the SectionId and CourseCode to the table
            If sqlTableEnrollment.Rows.Count > 0 Then

                'Checks that the student hasn't already enrolled in another section offering the same course,
                'or is trying to enroll in the same section twice by mistake
                For i = 1 To 4
                    If sqlTableEnrollment.Rows(0)("CourseCode" & i & "").ToString.Contains(sqlTableSection.Rows(0).Item("CourseCode")) = True Then
                        MsgBox("Student is already enrolled in the course " & sqlTableSection.Rows(0).Item("CourseCode") & ".", 48, "Error")

                        'Closing here because I'm exiting Sub so it won't get to the end where the .Close statements are
                        sqlReader.Close()
                        sqlConn.Close()
                        Exit Sub
                    End If
                Next

                'If Student already has a record in the CurrentTermEnrollment table, it adds the SectionId and CourseCode
                'of the class to their record along with balance.  BalanceDue is updated with the course's cost, which is
                '$180.00 per credit, multiplied by the course's credit hours. Sets both Grant fields to 
                'NULL since the student has changed the amount of credits they had.  They must re-apply
                'for student aid in their portal.
                sqlCmd.CommandText = "UPDATE CurrentTermEnrollment
                SET " & section & " = '" & sqlTableSection.Rows(0).Item("SectionId") & "',
                " & course & " = '" & sqlTableSection.Rows(0).Item("CourseCode") & "',
                BalanceDue = BalanceDue + 180 * " & sqlTableCourse.Rows(0).Item("Credits") & ",
                GrantAmount = NULL,
                GrantAvailable = NULL
                WHERE StudentId = '" & idlookup & "'"
                sqlReader = sqlCmd.ExecuteReader

                'If student doesn't have a record in the CurrentTermEnrollment table, it adds the EnrollmentId and StudentId
                'along with the SectionId and CourseCode along with balance related fields.  This will be the first class added so
                'it is not necessary to do BalanceDue + 500 for the BalanceDue, like above, just 500 suffices. Sets both Grant fields to 
                'NULL since the student has changed the amount of credits they had.  They must re-apply
                'for student aid in their portal.
            Else
                sqlCmd.CommandText = "INSERT INTO CurrentTermEnrollment (EnrollmentId, StudentId, " & section & ", " & course & ", BalanceDue, GrantAmount, GrantAvailable)
                VALUES('" & idlookup & "" & currentterm & "',
                '" & idlookup & "',
                '" & sqlTableSection.Rows(0).Item("SectionId") & "',
                '" & sqlTableSection.Rows(0).Item("CourseCode") & "',
                180 * " & sqlTableCourse.Rows(0).Item("Credits") & ",
                NULL,
                NULL)"
                sqlReader = sqlCmd.ExecuteReader
            End If

            'Must close before opening new one, was throwing error if not
            sqlReader.Close()

            'Also opens a record for the student in the GradeDetail table for that Section
            'The DetailId I'm giving each record is "student number-current term-course code"
            'This arrangement of DetailId will allow me to delete the course only from the current term if a student decides to drop
            'from a course, leaving their previous record intact, as well as being useful for adjusting GPA of the student
            'by being able to reference the grade obtained in the previous term and comparing it to the one in the current term.  This
            'way, if a student repeats a course I will easily be able to remove the previous grade fro GPA before adding the new grade
            'to it.  Adjusting GPA, and everything grade related will be handled in the faculty form.
            sqlCmd.CommandText = "INSERT INTO GradeDetail (DetailId, SectionId, StudentId, CourseCode)
            VALUES('" & idlookup & "" & currentterm & "-" & sqlTableSection.Rows(0).Item("CourseCode") & "',
            '" & sqlTableSection.Rows(0).Item("SectionId") & "',
            '" & idlookup & "',
            '" & sqlTableSection.Rows(0).Item("CourseCode") & "')"
            sqlReader = sqlCmd.ExecuteReader

            MsgBox("Course successfully added.", 64, "Information")
        End If

        sqlReader.Close()
        sqlConn.Close()
    End Sub

    'Does not let user write text on the drop down boxes, only select an option
    Private Sub ddl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlMajor.KeyPress, ddlEnrolled.KeyPress
        e.Handled = True
    End Sub

    Private Sub resetfields()
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If

            'Not in this form
            'If TypeOf ctrl Is ComboBox Then
            '    ctrl.Text = "Choose one option:"
            'End If
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
        btnAddCourse.Enabled = False
        btnDropCourse.Enabled = False
        btnChangeMajor.Enabled = False
        btnSubmit.Enabled = False
        btnCancel.Enabled = False
        ddlEnrolled.Enabled = False
        ddlMajor.Enabled = False
        lblPersonInfo.Visible = False
    End Sub
End Class