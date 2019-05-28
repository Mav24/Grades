<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstStudentNames = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumericGrade = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblLetterGrade = New System.Windows.Forms.Label()
        Me.btnGetLetterGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Students"
        '
        'lstStudentNames
        '
        Me.lstStudentNames.FormattingEnabled = True
        Me.lstStudentNames.ItemHeight = 15
        Me.lstStudentNames.Location = New System.Drawing.Point(16, 51)
        Me.lstStudentNames.Name = "lstStudentNames"
        Me.lstStudentNames.Size = New System.Drawing.Size(120, 94)
        Me.lstStudentNames.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numeric Grade:"
        '
        'lblNumericGrade
        '
        Me.lblNumericGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumericGrade.Location = New System.Drawing.Point(250, 51)
        Me.lblNumericGrade.Name = "lblNumericGrade"
        Me.lblNumericGrade.Size = New System.Drawing.Size(39, 23)
        Me.lblNumericGrade.TabIndex = 5
        Me.lblNumericGrade.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Letter Grade:"
        '
        'lblLetterGrade
        '
        Me.lblLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLetterGrade.Location = New System.Drawing.Point(250, 91)
        Me.lblLetterGrade.Name = "lblLetterGrade"
        Me.lblLetterGrade.Size = New System.Drawing.Size(39, 23)
        Me.lblLetterGrade.TabIndex = 6
        Me.lblLetterGrade.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnGetLetterGrade
        '
        Me.btnGetLetterGrade.Location = New System.Drawing.Point(306, 91)
        Me.btnGetLetterGrade.Name = "btnGetLetterGrade"
        Me.btnGetLetterGrade.Size = New System.Drawing.Size(103, 23)
        Me.btnGetLetterGrade.TabIndex = 2
        Me.btnGetLetterGrade.Text = "&Get Letter Grade"
        Me.btnGetLetterGrade.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnGetLetterGrade
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 177)
        Me.Controls.Add(Me.btnGetLetterGrade)
        Me.Controls.Add(Me.lblLetterGrade)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNumericGrade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstStudentNames)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstStudentNames As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNumericGrade As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblLetterGrade As Label
    Friend WithEvents btnGetLetterGrade As Button
End Class
