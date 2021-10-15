'Elliot Heiner
'RCET 0265
'Fall 2021
'Math Contest
'https://github.com/heinelli/MathContest.git

Option Strict On
Option Explicit On
Public Class MathContestForm
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim num1 As Integer = RandomNumber()
        Dim num2 As Integer = RandomNumber()
        Dim correctAnswer As Integer = num1 + num2

        AddRadioButton.Checked = True
        FirstNumberTextBox.Text = CStr(num1)
        SecondNumberTextBox.Text = CStr(num2)
    End Sub



    Private Sub ExitCommand(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AgeCheck(sender As Object, e As EventArgs) Handles StudentAgeTextBox.Leave
        Try
            If CInt(StudentAgeTextBox.Text) < 7 Or CInt(StudentAgeTextBox.Text) > 11 Then
                MsgBox("Student not eligible to compete.")
                StudentAgeTextBox.Text = ""
                StudentAgeTextBox.Focus()
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
                StudentGradeTextBox.Focus()
            End If
        Catch ex As Exception
            StudentGradeTextBox.Text = ""
            StudentGradeTextBox.Focus()
        End Try
    End Sub

    Function RandomNumber() As Integer
        Dim rndNumber As Integer
        Randomize()
        rndNumber = CInt(System.Math.Floor(Rnd() * (20 + 1)))
        Return rndNumber
    End Function

    Function RandomOperator() As Integer
        Dim rndOperator As Integer
        Randomize()
        rndOperator = CInt(System.Math.Floor(Rnd() * (3 + 1)))
        Return rndOperator
    End Function

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim operationType As Integer = RandomOperator()
        If operationType = 0 Then
            AddRadioButton.Checked = True
        ElseIf operationType = 1 Then
            SubtractRadioButton.Checked = True
        ElseIf operationType = 2 Then
            MultiplyRadioButton.Checked = True
        Else
            DivideRadioButton.Checked = True
        End If
    End Sub
End Class
