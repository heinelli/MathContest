'Elliot Heiner
'RCET 0265
'Fall 2021
'Math Contest
'https://github.com/heinelli/MathContest.git

Option Strict On
Option Explicit On
Public Class MathContestForm
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddRadioButton.Checked = True
    End Sub

    Private Sub ExitCommand(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AgeCheck(sender As Object, e As EventArgs) Handles StudentAgeTextBox.Leave
        Try
            If CInt(StudentAgeTextBox.Text) < 7 Or CInt(StudentAgeTextBox.Text) > 11 Then
                MsgBox("Student not eligible to compete.")
                StudentAgeTextBox.Text = ""
            End If
        Catch ex As Exception
            StudentAgeTextBox.Text = ""
            StudentAgeTextBox.Focus()
        End Try
    End Sub

    Private Sub GradeCheck(sender As Object, e As EventArgs) Handles StudentGradeTextBox.Leave
        Try
            If CInt(StudentGradeTextBox.Text) < 1 Or CInt(StudentGradeTextBox.Text) > 4 Then
                MsgBox("Student not eligible to compete.")
                StudentGradeTextBox.Text = ""
            End If
        Catch ex As Exception
            StudentGradeTextBox.Text = ""
        End Try
    End Sub
End Class
