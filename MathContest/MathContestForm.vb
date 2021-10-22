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
        RoundingMessageLabel.Visible = False
    End Sub

    Private Sub ExitCommand(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AgeCheck(sender As Object, e As EventArgs) Handles StudentAgeTextBox.Leave
        'Verify that correct age is typed into textbox. Erase input if value doesn't meet contest criteria.
        Try
            If CInt(StudentAgeTextBox.Text) < 7 Or CInt(StudentAgeTextBox.Text) > 11 Then
                MsgBox("Student not eligible to compete.")
                StudentAgeTextBox.Text = ""
                'StudentAgeTextBox.Select() 'this causes focus to be stuck on text box. not wrong but annoys user - TJR
            End If
        Catch ex As Exception
            StudentAgeTextBox.Text = ""
            'StudentAgeTextBox.Select() 'this causes focus to be stuck on text box. not wrong but annoys user - TJR
        End Try
    End Sub

    Private Sub GradeCheck(sender As Object, e As EventArgs) Handles StudentGradeTextBox.Leave
        'Verify that correct grade is typed into textbox. Erase input if value doesn't meet contest criteria.
        Try
            If CInt(StudentGradeTextBox.Text) < 1 Or CInt(StudentGradeTextBox.Text) > 4 Then
                MsgBox("Student not eligible to compete.")
                StudentGradeTextBox.Text = ""
                'StudentGradeTextBox.Select() 'this causes focus to be stuck on text box. not wrong but annoys user - TJR
            End If
        Catch ex As Exception
            StudentGradeTextBox.Text = ""
            'StudentGradeTextBox.Select() 'this causes focus to be stuck on text box. not wrong but annoys user - TJR
        End Try
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim correctAnswer As Integer
        Dim roundedNumber As Double
        Dim firstNumberCheck As Integer
        Dim secondNumberCheck As Integer
        Dim answerCheck As Integer

        If StudentNameTextBox.Text = "" Or StudentGradeTextBox.Text = "" Or StudentAgeTextBox.Text = "" Then
            MsgBox("Finish filling out student information.")
            If StudentNameTextBox.Text = "" Then
                StudentNameTextBox.Select()
            ElseIf StudentAgeTextBox.Text = "" Then
                StudentAgeTextBox.Select()
            Else
                StudentGradeTextBox.Select()
            End If
        Else
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
                    MsgBox("Incorrect.
The correct answer is " & correctAnswer)
                End If
                QuestionCount += 1
            Catch
                MsgBox("Enter whole numbers please.")

                'Catch statements used to clear input data in textboxes with incorrect data type.
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

                'Place cursor in textbox with incorrect data type.
                If FirstNumberTextBox.Text = "" Then
                    FirstNumberTextBox.Select()
                ElseIf SecondNumberTextBox.Text = "" Then
                    SecondNumberTextBox.Select()
                Else
                    StudentAnswerTextBox.Select()
                End If
            End Try
        End If


    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clear all data input from the user.
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

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MsgBox(SuccessfulAnswer & " out of " & QuestionCount & " questions correct.")
    End Sub

    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.Click
        'Display message to inform user how to round in program.
        RoundingMessageLabel.Visible = True
    End Sub

    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        'Disable rounding message.
        RoundingMessageLabel.Visible = False
    End Sub

    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        'Disable rounding message.
        RoundingMessageLabel.Visible = False
    End Sub

    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        'Disable rounding message.
        RoundingMessageLabel.Visible = False
    End Sub

    Private Sub StudentNameTextBox_Leave(sender As Object, e As EventArgs) Handles StudentNameTextBox.Leave
        'Prevent user from leaving textbox if no data is input.
        If StudentNameTextBox.Text = "" Then
            'StudentNameTextBox.Select() 'this causes focus to be stuck on text box. not wrong but annoys user - TJR
            StudentNameTextBox.BackColor = Color.LightYellow 'Try this instead - TJR
        End If
    End Sub

    'These are global/Class level variables not subs.  - TJR
    'keep variable declarations at the top of the scope Class, Sub, Function etc. -TJR 
    'Private subs used to count number of attempts and number of correct answers.
    Private QuestionCount As Integer = 0 'camelCase - TJR
    Private SuccessfulAnswer As Integer = 0 'camelCase - TJR
End Class
