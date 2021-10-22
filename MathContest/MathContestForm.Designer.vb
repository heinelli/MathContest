<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MathContestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentGradeLabel = New System.Windows.Forms.Label()
        Me.StudentAgeLabel = New System.Windows.Forms.Label()
        Me.StudentNameLabel = New System.Windows.Forms.Label()
        Me.StudentGradeTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAgeTextBox = New System.Windows.Forms.TextBox()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.MathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MathProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.SelectionButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.RoundingMessageLabel = New System.Windows.Forms.Label()
        Me.GeneralToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.MathProblemGroupBox.SuspendLayout()
        Me.MathProblemTypeGroupBox.SuspendLayout()
        Me.SelectionButtonsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.StudentGradeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.StudentAgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.StudentNameLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.StudentGradeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.StudentAgeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.StudentNameTextBox)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(16, 23)
        Me.StudentInfoGroupBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(339, 86)
        Me.StudentInfoGroupBox.TabIndex = 0
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'StudentGradeLabel
        '
        Me.StudentGradeLabel.AutoSize = True
        Me.StudentGradeLabel.Location = New System.Drawing.Point(284, 29)
        Me.StudentGradeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StudentGradeLabel.Name = "StudentGradeLabel"
        Me.StudentGradeLabel.Size = New System.Drawing.Size(36, 13)
        Me.StudentGradeLabel.TabIndex = 5
        Me.StudentGradeLabel.Text = "Grade"
        '
        'StudentAgeLabel
        '
        Me.StudentAgeLabel.AutoSize = True
        Me.StudentAgeLabel.Location = New System.Drawing.Point(238, 29)
        Me.StudentAgeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StudentAgeLabel.Name = "StudentAgeLabel"
        Me.StudentAgeLabel.Size = New System.Drawing.Size(26, 13)
        Me.StudentAgeLabel.TabIndex = 4
        Me.StudentAgeLabel.Text = "Age"
        '
        'StudentNameLabel
        '
        Me.StudentNameLabel.AutoSize = True
        Me.StudentNameLabel.Location = New System.Drawing.Point(14, 29)
        Me.StudentNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StudentNameLabel.Name = "StudentNameLabel"
        Me.StudentNameLabel.Size = New System.Drawing.Size(35, 13)
        Me.StudentNameLabel.TabIndex = 3
        Me.StudentNameLabel.Text = "Name"
        '
        'StudentGradeTextBox
        '
        Me.StudentGradeTextBox.Location = New System.Drawing.Point(294, 43)
        Me.StudentGradeTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StudentGradeTextBox.Name = "StudentGradeTextBox"
        Me.StudentGradeTextBox.Size = New System.Drawing.Size(20, 20)
        Me.StudentGradeTextBox.TabIndex = 2
        Me.GeneralToolTip.SetToolTip(Me.StudentGradeTextBox, "Type in student grade.")
        '
        'StudentAgeTextBox
        '
        Me.StudentAgeTextBox.Location = New System.Drawing.Point(241, 43)
        Me.StudentAgeTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StudentAgeTextBox.Name = "StudentAgeTextBox"
        Me.StudentAgeTextBox.Size = New System.Drawing.Size(20, 20)
        Me.StudentAgeTextBox.TabIndex = 1
        Me.GeneralToolTip.SetToolTip(Me.StudentAgeTextBox, "Type in student age.")
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.Location = New System.Drawing.Point(13, 43)
        Me.StudentNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StudentNameTextBox.TabIndex = 0
        Me.GeneralToolTip.SetToolTip(Me.StudentNameTextBox, "Type in student name.")
        '
        'MathProblemGroupBox
        '
        Me.MathProblemGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.MathProblemGroupBox.Location = New System.Drawing.Point(16, 124)
        Me.MathProblemGroupBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MathProblemGroupBox.Name = "MathProblemGroupBox"
        Me.MathProblemGroupBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MathProblemGroupBox.Size = New System.Drawing.Size(163, 188)
        Me.MathProblemGroupBox.TabIndex = 1
        Me.MathProblemGroupBox.TabStop = False
        Me.MathProblemGroupBox.Text = "Current Math Problem"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(14, 136)
        Me.StudentAnswerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(82, 13)
        Me.StudentAnswerLabel.TabIndex = 7
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(14, 84)
        Me.SecondNumberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(84, 13)
        Me.SecondNumberLabel.TabIndex = 6
        Me.SecondNumberLabel.Text = "Second Number"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(14, 33)
        Me.FirstNumberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(66, 13)
        Me.FirstNumberLabel.TabIndex = 5
        Me.FirstNumberLabel.Text = "First Number"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(13, 151)
        Me.StudentAnswerTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(136, 20)
        Me.StudentAnswerTextBox.TabIndex = 5
        Me.GeneralToolTip.SetToolTip(Me.StudentAnswerTextBox, "Type in answer.")
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(13, 99)
        Me.SecondNumberTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(136, 20)
        Me.SecondNumberTextBox.TabIndex = 4
        Me.GeneralToolTip.SetToolTip(Me.SecondNumberTextBox, "Type in second number.")
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(13, 47)
        Me.FirstNumberTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(136, 20)
        Me.FirstNumberTextBox.TabIndex = 3
        Me.GeneralToolTip.SetToolTip(Me.FirstNumberTextBox, "Type in first number.")
        '
        'MathProblemTypeGroupBox
        '
        Me.MathProblemTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathProblemTypeGroupBox.Location = New System.Drawing.Point(202, 123)
        Me.MathProblemTypeGroupBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MathProblemTypeGroupBox.Name = "MathProblemTypeGroupBox"
        Me.MathProblemTypeGroupBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MathProblemTypeGroupBox.Size = New System.Drawing.Size(152, 189)
        Me.MathProblemTypeGroupBox.TabIndex = 2
        Me.MathProblemTypeGroupBox.TabStop = False
        Me.MathProblemTypeGroupBox.Text = "Math Problem Type"
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(11, 135)
        Me.DivideRadioButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "&Divide"
        Me.GeneralToolTip.SetToolTip(Me.DivideRadioButton, "Divide second number from first number.")
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(11, 101)
        Me.MultiplyRadioButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "&Multiply"
        Me.GeneralToolTip.SetToolTip(Me.MultiplyRadioButton, "Multiply first and second number.")
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(11, 68)
        Me.SubtractRadioButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Su&btract"
        Me.GeneralToolTip.SetToolTip(Me.SubtractRadioButton, "Subtract second number from first number.")
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(11, 35)
        Me.AddRadioButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(44, 17)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "&Add"
        Me.GeneralToolTip.SetToolTip(Me.AddRadioButton, "Add first and second number.")
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'SelectionButtonsGroupBox
        '
        Me.SelectionButtonsGroupBox.Controls.Add(Me.ExitButton)
        Me.SelectionButtonsGroupBox.Controls.Add(Me.SummaryButton)
        Me.SelectionButtonsGroupBox.Controls.Add(Me.ClearButton)
        Me.SelectionButtonsGroupBox.Controls.Add(Me.SubmitButton)
        Me.SelectionButtonsGroupBox.Location = New System.Drawing.Point(374, 23)
        Me.SelectionButtonsGroupBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SelectionButtonsGroupBox.Name = "SelectionButtonsGroupBox"
        Me.SelectionButtonsGroupBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SelectionButtonsGroupBox.Size = New System.Drawing.Size(173, 289)
        Me.SelectionButtonsGroupBox.TabIndex = 3
        Me.SelectionButtonsGroupBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(15, 226)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(142, 48)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "&Exit"
        Me.GeneralToolTip.SetToolTip(Me.ExitButton, "End program.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(15, 160)
        Me.SummaryButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(142, 48)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "S&ummary"
        Me.GeneralToolTip.SetToolTip(Me.SummaryButton, "Display summary of questions answered.")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(15, 92)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(142, 48)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.GeneralToolTip.SetToolTip(Me.ClearButton, "Clear student data.")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(15, 23)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(142, 48)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "&Submit"
        Me.GeneralToolTip.SetToolTip(Me.SubmitButton, "Submit answer.")
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'RoundingMessageLabel
        '
        Me.RoundingMessageLabel.AutoSize = True
        Me.RoundingMessageLabel.Location = New System.Drawing.Point(13, 314)
        Me.RoundingMessageLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RoundingMessageLabel.Name = "RoundingMessageLabel"
        Me.RoundingMessageLabel.Size = New System.Drawing.Size(181, 26)
        Me.RoundingMessageLabel.TabIndex = 6
        Me.RoundingMessageLabel.Text = "Round any value at .5 or greater up. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Round any value less than .5 down."
        '
        'GeneralToolTip
        '
        Me.GeneralToolTip.AutomaticDelay = 300
        Me.GeneralToolTip.AutoPopDelay = 3000
        Me.GeneralToolTip.InitialDelay = 200
        Me.GeneralToolTip.ReshowDelay = 60
        '
        'MathContestForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(580, 358)
        Me.Controls.Add(Me.RoundingMessageLabel)
        Me.Controls.Add(Me.SelectionButtonsGroupBox)
        Me.Controls.Add(Me.MathProblemTypeGroupBox)
        Me.Controls.Add(Me.MathProblemGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MathContestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Math Contest"
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.MathProblemGroupBox.ResumeLayout(False)
        Me.MathProblemGroupBox.PerformLayout()
        Me.MathProblemTypeGroupBox.ResumeLayout(False)
        Me.MathProblemTypeGroupBox.PerformLayout()
        Me.SelectionButtonsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents StudentNameLabel As Label
    Friend WithEvents StudentGradeTextBox As TextBox
    Friend WithEvents StudentAgeTextBox As TextBox
    Friend WithEvents StudentNameTextBox As TextBox
    Friend WithEvents StudentGradeLabel As Label
    Friend WithEvents StudentAgeLabel As Label
    Friend WithEvents MathProblemGroupBox As GroupBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents MathProblemTypeGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SelectionButtonsGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents RoundingMessageLabel As Label
    Friend WithEvents GeneralToolTip As ToolTip
End Class
