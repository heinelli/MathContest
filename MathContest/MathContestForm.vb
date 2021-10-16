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
    End Sub



    Private Sub ExitCommand(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AgeCheck(sender As Object, e As EventArgs) Handles StudentAgeTextBox.Leave
        Try
            If CInt(StudentAgeTextBox.Text) < 7 Or CInt(StudentAgeTextBox.Text) > 11 Then
                MsgBox("Student not eligible to compete.")
                StudentAgeTextBox.Text = ""
                StudentAgeTextBox.Select()
            End If
        Catch ex As Exception
            StudentAgeTextBox.Text = ""
            StudentAgeTextBox.Select()
        End Try
    End Sub

    Private Sub GradeCheck(sender As Object, e As EventArgs) Handles StudentGradeTextBox.Leave
        Try
            If CInt(StudentGradeTextBox.Text) < 1 Or CInt(StudentGradeTextBox.Text) > 4 Then
                MsgBox("Student not eligible to compete.")
                StudentGradeTextBox.Text = ""
                StudentGradeTextBox.Select()
            End If
        Catch ex As Exception
            StudentGradeTextBox.Text = ""
            StudentGradeTextBox.Select()
        End Try
    End Sub

    Function RandomNumber() As Integer
        Dim rndNumber As Integer
        Randomize()
        rndNumber = CInt(System.Math.Floor(Rnd() * (20 + 1)))
        Return rndNumber
    End Function

    'Function RandomOperator() As Integer
    '    Dim rndOperator As Integer
    '    Randomize()
    '    rndOperator = CInt(System.Math.Floor(Rnd() * (3 + 1)))
    '    Return rndOperator
    'End Function

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim correctAnswer As Integer
        Dim roundedNumber As Double
        Dim firstNumberCheck As Integer
        Dim secondNumberCheck As Integer
        Dim answerCheck As Integer

        Try
            answerCheck = CInt(StudentAnswerTextBox.Text)
            If AddRadioButton.Checked = True Then
                correctAnswer = CInt(FirstNumberTextBox.Text) + CInt(SecondNumberTextBox.Text)
            ElseIf SubtractRadioButton.Checked = True Then
                correctAnswer = CInt(FirstNumberTextBox.Text) - CInt(SecondNumberTextBox.Text)
            ElseIf MultiplyRadioButton.Checked = True Then
                correctAnswer = CInt(FirstNumberTextBox.Text) * CInt(SecondNumberTextBox.Text)
            ElseIf DivideRadioButton.Checked = True Then
                roundedNumber = Math.Round((CInt(FirstNumberTextBox.Text) / CInt(SecondNumberTextBox.Text)), MidpointRounding.AwayFromZero)
                correctAnswer = CInt(roundedNumber)
            End If
            If StudentAnswerTextBox.Text = CStr(correctAnswer) Then
                MsgBox("Congratulations!")
                SuccessfulAnswer += 1
            Else
                MsgBox("Wrong!
The correct answer is " & correctAnswer)
            End If
            QuestionCount += 1
        Catch
            MsgBox("Enter whole numbers please.")

            Try
                firstNumberCheck = CInt(FirstNumberTextBox.Text)
            Catch ex As Exception
                FirstNumberTextBox.Text = ""
            End Try

            Try
                secondNumberCheck = CInt(SecondNumberTextBox.Text)
            Catch ex As Exception
                SecondNumberTextBox.Text = ""
            End Try

            Try
                answerCheck = CInt(StudentAnswerTextBox.Text)
            Catch ex As Exception
                StudentAnswerTextBox.Text = ""
            End Try

        End Try

        'If TypeOf FirstNumberTextBox.Text Is String Then
        '    FirstNumberTextBox.Text = ""
        'End If




    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        AddRadioButton.Checked = True
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        StudentNameTextBox.Text = ""
        StudentAgeTextBox.Text = ""
        StudentGradeTextBox.Text = ""
        QuestionCount = 0
        SuccessfulAnswer = 0
    End Sub

    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.Click
        MsgBox("Round any value at 0.5 or greater up. Round any value less than 0.5 down.")
    End Sub

    Private QuestionCount As Integer = 0
    Private SuccessfulAnswer As Integer = 0

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MsgBox(SuccessfulAnswer & " out of " & QuestionCount & " questions correct.")
    End Sub
End Class
