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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub StudentAgeTextBox_Leave(sender As Object, e As EventArgs) Handles StudentAgeTextBox.Leave
        If CInt(StudentAgeTextBox.Text) < 7 Or CInt(StudentAgeTextBox.Text) > 11 Then
            MsgBox("This isn't for your age.")
        Else
            MsgBox("We have a problem here.")
        End If
    End Sub
End Class
