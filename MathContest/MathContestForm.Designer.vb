<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StudentGradeLabel = New System.Windows.Forms.Label()
        Me.StudentAgeLabel = New System.Windows.Forms.Label()
        Me.StudentNameLabel = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.MathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StudentGradeLabel)
        Me.GroupBox1.Controls.Add(Me.StudentAgeLabel)
        Me.GroupBox1.Controls.Add(Me.StudentNameLabel)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.StudentNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'StudentGradeLabel
        '
        Me.StudentGradeLabel.AutoSize = True
        Me.StudentGradeLabel.Location = New System.Drawing.Point(567, 55)
        Me.StudentGradeLabel.Name = "StudentGradeLabel"
        Me.StudentGradeLabel.Size = New System.Drawing.Size(71, 25)
        Me.StudentGradeLabel.TabIndex = 5
        Me.StudentGradeLabel.Text = "Grade"
        '
        'StudentAgeLabel
        '
        Me.StudentAgeLabel.AutoSize = True
        Me.StudentAgeLabel.Location = New System.Drawing.Point(477, 55)
        Me.StudentAgeLabel.Name = "StudentAgeLabel"
        Me.StudentAgeLabel.Size = New System.Drawing.Size(50, 25)
        Me.StudentAgeLabel.TabIndex = 4
        Me.StudentAgeLabel.Text = "Age"
        '
        'StudentNameLabel
        '
        Me.StudentNameLabel.AutoSize = True
        Me.StudentNameLabel.Location = New System.Drawing.Point(28, 55)
        Me.StudentNameLabel.Name = "StudentNameLabel"
        Me.StudentNameLabel.Size = New System.Drawing.Size(68, 25)
        Me.StudentNameLabel.TabIndex = 3
        Me.StudentNameLabel.Text = "Name"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(588, 83)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(35, 31)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(482, 83)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(35, 31)
        Me.TextBox2.TabIndex = 1
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.Location = New System.Drawing.Point(26, 83)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(396, 31)
        Me.StudentNameTextBox.TabIndex = 0
        '
        'MathProblemGroupBox
        '
        Me.MathProblemGroupBox.Location = New System.Drawing.Point(31, 239)
        Me.MathProblemGroupBox.Name = "MathProblemGroupBox"
        Me.MathProblemGroupBox.Size = New System.Drawing.Size(678, 479)
        Me.MathProblemGroupBox.TabIndex = 1
        Me.MathProblemGroupBox.TabStop = False
        Me.MathProblemGroupBox.Text = "Current Math Problem"
        '
        'MathContestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1736, 1093)
        Me.Controls.Add(Me.MathProblemGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MathContestForm"
        Me.Text = "Math Contest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StudentNameLabel As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents StudentNameTextBox As TextBox
    Friend WithEvents StudentGradeLabel As Label
    Friend WithEvents StudentAgeLabel As Label
    Friend WithEvents MathProblemGroupBox As GroupBox
End Class
