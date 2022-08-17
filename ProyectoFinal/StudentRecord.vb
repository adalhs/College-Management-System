Imports System.Data.SqlClient

Public Class StudentRecord

    Dim sqlConn As New SqlConnection  'represents a unique session(connection) to a SQL Server data source
    Dim sqlCmd As New SqlCommand
    Dim sqlReader As SqlDataReader   'sqlReader is not an object, does not need "New"

    Dim sqlTableStudent As New DataTable
    Dim sqlTableEnrollment As New DataTable
    Dim sqlTableCourse As New DataTable
    Dim sqlTableCourses As New DataTable
    Dim sqlTableGradeDetail As New DataTable

    Dim currentterm As String = "-2022-23"    'to be used when loading section, want to load section number of current term only

    Private Sub StudentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlConn.ConnectionString = connString

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        'Loads student's record from Person to get their student number
        sqlCmd.CommandText = "SELECT * From Person WHERE Username = '" & user & "' AND Password = '" & pass & "'"
        sqlReader = sqlCmd.ExecuteReader
        sqlTableStudent.Load(sqlReader)

        'Loads student's record from CurrentTermEnrollment to get their currently enrolled courses
        sqlCmd.CommandText = "SELECT * From CurrentTermEnrollment
        WHERE StudentId = '" & sqlTableStudent.Rows(0).Item("PersonId") & "'
        AND EnrollmentId like '%" & currentterm & "%'"
        sqlReader = sqlCmd.ExecuteReader
        sqlTableEnrollment.Load(sqlReader)

        'Loads courses from Course table to get their names
        sqlCmd.CommandText = "SELECT * From Course"
        sqlReader = sqlCmd.ExecuteReader
        sqlTableCourses.Load(sqlReader)

        'Loads student's record from GradeDetail table to get grades from current and past courses
        sqlCmd.CommandText = "SELECT * From GradeDetail
        WHERE StudentId = '" & sqlTableStudent.Rows(0).Item("PersonId") & "'"
        sqlReader = sqlCmd.ExecuteReader
        sqlTableGradeDetail.Load(sqlReader)

        sqlReader.Close()
        sqlConn.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        PortalMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnEnrolledProgress_Click(sender As Object, e As EventArgs) Handles btnEnrolledProgress.Click
        ddlCourses.Items.Clear()
        ddlCourses.Text = "Enrolled Courses"
        ddlGradeDetail.Items.Clear()
        ddlGradeDetail.Text = ""

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        For Each row As DataRow In sqlTableGradeDetail.Rows
            sqlTableCourses.Clear()

            sqlCmd.CommandText = "SELECT * From Course
            WHERE CourseCode = '" & row.Item("CourseCode") & "'"
            sqlReader = sqlCmd.ExecuteReader
            sqlTableCourses.Load(sqlReader)


            'If this is a currently enrolled course, where FinalGrade has not yet been given a value.
            If IsDBNull(row.Item("FinalGrade")) Then
                ddlCourses.Items.Add("" & row.Item("CourseCode") & " - " & sqlTableCourses.Rows(0).Item("CourseName") & "")
            End If
        Next

        sqlReader.Close()
        sqlConn.Close()
    End Sub

    Private Sub btnPastGrades_Click(sender As Object, e As EventArgs) Handles btnPastGrades.Click
        ddlCourses.Items.Clear()
        ddlCourses.Text = "Past Courses"
        ddlGradeDetail.Items.Clear()
        ddlGradeDetail.Text = ""

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        For Each row As DataRow In sqlTableGradeDetail.Rows
            sqlTableCourses.Clear()

            sqlCmd.CommandText = "SELECT * From Course
            WHERE CourseCode = '" & row.Item("CourseCode") & "'"
            sqlReader = sqlCmd.ExecuteReader
            sqlTableCourses.Load(sqlReader)


            'If this is a past course, where FinalGrade has been given a value.
            If Not IsDBNull(row.Item("FinalGrade")) Then
                ddlCourses.Items.Add("" & row.Item("CourseCode") & " - " & sqlTableCourses.Rows(0).Item("CourseName") & "")
            End If
        Next

        sqlReader.Close()
        sqlConn.Close()
    End Sub

    Private Sub ddlCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCourses.SelectedIndexChanged
        sqlTableCourse.Clear()

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        If Not ddlCourses.Text = "" Then
            ddlGradeDetail.Items.Clear()
            ddlGradeDetail.Text = ""

            sqlCmd.CommandText = "SELECT * From GradeDetail
            WHERE CourseCode = '" & ddlCourses.SelectedItem.ToString.Substring(0, 9) & "'
            AND StudentId = '" & sqlTableStudent.Rows(0).Item("PersonId") & "'"
            sqlReader = sqlCmd.ExecuteReader
            sqlTableCourse.Load(sqlReader)

            ddlGradeDetail.Text = "" & sqlTableCourse.Rows(0).Item("CourseCode") & " Grade Detail"
            For i = 1 To 4
                ddlGradeDetail.Items.Add("Grade " & i & " - " & sqlTableCourse.Rows(0).Item("Grade" & i & "") & "")
            Next

            'If final grade has been assigned
            If Not IsDBNull(sqlTableCourse.Rows(0).Item("FinalGrade")) Then
                ddlGradeDetail.Items.Add("Final Grade - " & sqlTableCourse.Rows(0).Item("FinalGrade") & "")
            End If
        End If

        sqlReader.Close()
        sqlConn.Close()
    End Sub

    'Does not let user write text on the drop down boxes, only select an option
    Private Sub ddl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlGradeDetail.KeyPress, ddlCourses.KeyPress
        e.Handled = True
    End Sub
End Class