<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.TextIO = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSubtract = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.ButtonEquals = New System.Windows.Forms.Button()
        Me.ButtonDigit3 = New System.Windows.Forms.Button()
        Me.ButtonDigit6 = New System.Windows.Forms.Button()
        Me.ButtonDigit9 = New System.Windows.Forms.Button()
        Me.ButtonDigit7 = New System.Windows.Forms.Button()
        Me.ButtonDigit4 = New System.Windows.Forms.Button()
        Me.ButtonDigit2 = New System.Windows.Forms.Button()
        Me.ButtonDigit5 = New System.Windows.Forms.Button()
        Me.ButtonDigit8 = New System.Windows.Forms.Button()
        Me.ButtonDigit0 = New System.Windows.Forms.Button()
        Me.ButtonDigit1 = New System.Windows.Forms.Button()
        Me.FirstOperandLabel = New System.Windows.Forms.Label()
        Me.OperationLabel = New System.Windows.Forms.Label()
        Me.ButtonBackspace = New System.Windows.Forms.Button()
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.ButtonCE = New System.Windows.Forms.Button()
        Me.ButtonPower = New System.Windows.Forms.Button()
        Me.ButtonPeriod = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextIO
        '
        Me.TextIO.Location = New System.Drawing.Point(310, 82)
        Me.TextIO.Name = "TextIO"
        Me.TextIO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextIO.Size = New System.Drawing.Size(234, 20)
        Me.TextIO.TabIndex = 0
        Me.TextIO.Text = "0"
        Me.TextIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(490, 154)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(54, 40)
        Me.ButtonAdd.TabIndex = 1
        Me.ButtonAdd.Text = "+"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSubtract
        '
        Me.ButtonSubtract.Location = New System.Drawing.Point(490, 200)
        Me.ButtonSubtract.Name = "ButtonSubtract"
        Me.ButtonSubtract.Size = New System.Drawing.Size(54, 40)
        Me.ButtonSubtract.TabIndex = 2
        Me.ButtonSubtract.Text = "-"
        Me.ButtonSubtract.UseVisualStyleBackColor = True
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.Location = New System.Drawing.Point(490, 246)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(54, 40)
        Me.ButtonMultiply.TabIndex = 3
        Me.ButtonMultiply.Text = "*"
        Me.ButtonMultiply.UseVisualStyleBackColor = True
        '
        'ButtonDivide
        '
        Me.ButtonDivide.Location = New System.Drawing.Point(490, 292)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(54, 40)
        Me.ButtonDivide.TabIndex = 4
        Me.ButtonDivide.Text = "/"
        Me.ButtonDivide.UseVisualStyleBackColor = True
        '
        'ButtonEquals
        '
        Me.ButtonEquals.Location = New System.Drawing.Point(430, 246)
        Me.ButtonEquals.Name = "ButtonEquals"
        Me.ButtonEquals.Size = New System.Drawing.Size(54, 40)
        Me.ButtonEquals.TabIndex = 5
        Me.ButtonEquals.Text = "="
        Me.ButtonEquals.UseVisualStyleBackColor = True
        '
        'ButtonDigit3
        '
        Me.ButtonDigit3.Location = New System.Drawing.Point(430, 108)
        Me.ButtonDigit3.Name = "ButtonDigit3"
        Me.ButtonDigit3.Size = New System.Drawing.Size(54, 40)
        Me.ButtonDigit3.TabIndex = 6
        Me.ButtonDigit3.Text = "3"
        Me.ButtonDigit3.UseVisualStyleBackColor = True
        '
        'ButtonDigit6
        '
        Me.ButtonDigit6.Location = New System.Drawing.Point(430, 154)
        Me.ButtonDigit6.Name = "ButtonDigit6"
        Me.ButtonDigit6.Size = New System.Drawing.Size(54, 40)
        Me.ButtonDigit6.TabIndex = 7
        Me.ButtonDigit6.Text = "6"
        Me.ButtonDigit6.UseVisualStyleBackColor = True
        '
        'ButtonDigit9
        '
        Me.ButtonDigit9.Location = New System.Drawing.Point(430, 200)
        Me.ButtonDigit9.Name = "ButtonDigit9"
        Me.ButtonDigit9.Size = New System.Drawing.Size(54, 40)
        Me.ButtonDigit9.TabIndex = 8
        Me.ButtonDigit9.Text = "9"
        Me.ButtonDigit9.UseVisualStyleBackColor = True
        '
        'ButtonDigit7
        '
        Me.ButtonDigit7.Location = New System.Drawing.Point(310, 200)
        Me.ButtonDigit7.Name = "ButtonDigit7"
        Me.ButtonDigit7.Size = New System.Drawing.Size(54, 40)
        Me.ButtonDigit7.TabIndex = 9
        Me.ButtonDigit7.Text = "7"
        Me.ButtonDigit7.UseVisualStyleBackColor = True
        '
        'ButtonDigit4
        '
        Me.ButtonDigit4.Location = New System.Drawing.Point(310, 154)
        Me.ButtonDigit4.Name = "ButtonDigit4"
        Me.ButtonDigit4.Size = New System.Drawing.Size(54, 40)
        Me.ButtonDigit4.TabIndex = 10
        Me.ButtonDigit4.Text = "4"
        Me.ButtonDigit4.UseVisualStyleBackColor = True
        '
        'ButtonDigit2
        '
        Me.ButtonDigit2.Location = New System.Drawing.Point(370, 108)
        Me.ButtonDigit2.Name = "ButtonDigit2"
        Me.ButtonDigit2.Size = New System.Drawing.Size(54, 40)
        Me.ButtonDigit2.TabIndex = 11
        Me.ButtonDigit2.Text = "2"
        Me.ButtonDigit2.UseVisualStyleBackColor = True
        '
        'ButtonDigit5
        '
        Me.ButtonDigit5.Location = New System.Drawing.Point(370, 154)
        Me.ButtonDigit5.Name = "ButtonDigit5"
        Me.ButtonDigit5.Size = New System.Drawing.Size(54, 40)
        Me.ButtonDigit5.TabIndex = 12
        Me.ButtonDigit5.Text = "5"
        Me.ButtonDigit5.UseVisualStyleBackColor = True
        '
        'ButtonDigit8
        '
        Me.ButtonDigit8.Location = New System.Drawing.Point(370, 200)
        Me.ButtonDigit8.Name = "ButtonDigit8"
        Me.ButtonDigit8.Size = New System.Drawing.Size(54, 40)
        Me.ButtonDigit8.TabIndex = 13
        Me.ButtonDigit8.Text = "8"
        Me.ButtonDigit8.UseVisualStyleBackColor = True
        '
        'ButtonDigit0
        '
        Me.ButtonDigit0.Location = New System.Drawing.Point(370, 246)
        Me.ButtonDigit0.Name = "ButtonDigit0"
        Me.ButtonDigit0.Size = New System.Drawing.Size(54, 40)
        Me.ButtonDigit0.TabIndex = 14
        Me.ButtonDigit0.Text = "0"
        Me.ButtonDigit0.UseVisualStyleBackColor = True
        '
        'ButtonDigit1
        '
        Me.ButtonDigit1.Location = New System.Drawing.Point(310, 108)
        Me.ButtonDigit1.Name = "ButtonDigit1"
        Me.ButtonDigit1.Size = New System.Drawing.Size(54, 40)
        Me.ButtonDigit1.TabIndex = 15
        Me.ButtonDigit1.Text = "1"
        Me.ButtonDigit1.UseVisualStyleBackColor = True
        '
        'FirstOperandLabel
        '
        Me.FirstOperandLabel.AutoSize = True
        Me.FirstOperandLabel.Location = New System.Drawing.Point(286, 55)
        Me.FirstOperandLabel.Name = "FirstOperandLabel"
        Me.FirstOperandLabel.Size = New System.Drawing.Size(13, 13)
        Me.FirstOperandLabel.TabIndex = 16
        Me.FirstOperandLabel.Text = "0"
        '
        'OperationLabel
        '
        Me.OperationLabel.AutoSize = True
        Me.OperationLabel.Location = New System.Drawing.Point(286, 82)
        Me.OperationLabel.Name = "OperationLabel"
        Me.OperationLabel.Size = New System.Drawing.Size(0, 13)
        Me.OperationLabel.TabIndex = 18
        '
        'ButtonBackspace
        '
        Me.ButtonBackspace.Location = New System.Drawing.Point(310, 292)
        Me.ButtonBackspace.Name = "ButtonBackspace"
        Me.ButtonBackspace.Size = New System.Drawing.Size(54, 40)
        Me.ButtonBackspace.TabIndex = 19
        Me.ButtonBackspace.Text = "<-"
        Me.ButtonBackspace.UseVisualStyleBackColor = True
        '
        'ButtonC
        '
        Me.ButtonC.Location = New System.Drawing.Point(370, 292)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(54, 40)
        Me.ButtonC.TabIndex = 20
        Me.ButtonC.Text = "C"
        Me.ButtonC.UseVisualStyleBackColor = True
        '
        'ButtonCE
        '
        Me.ButtonCE.Location = New System.Drawing.Point(430, 292)
        Me.ButtonCE.Name = "ButtonCE"
        Me.ButtonCE.Size = New System.Drawing.Size(54, 40)
        Me.ButtonCE.TabIndex = 21
        Me.ButtonCE.Text = "CE"
        Me.ButtonCE.UseVisualStyleBackColor = True
        '
        'ButtonPower
        '
        Me.ButtonPower.Location = New System.Drawing.Point(490, 108)
        Me.ButtonPower.Name = "ButtonPower"
        Me.ButtonPower.Size = New System.Drawing.Size(54, 40)
        Me.ButtonPower.TabIndex = 22
        Me.ButtonPower.Text = "x^y"
        Me.ButtonPower.UseVisualStyleBackColor = True
        '
        'ButtonPeriod
        '
        Me.ButtonPeriod.Location = New System.Drawing.Point(310, 246)
        Me.ButtonPeriod.Name = "ButtonPeriod"
        Me.ButtonPeriod.Size = New System.Drawing.Size(54, 40)
        Me.ButtonPeriod.TabIndex = 23
        Me.ButtonPeriod.Text = "."
        Me.ButtonPeriod.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonPeriod)
        Me.Controls.Add(Me.ButtonPower)
        Me.Controls.Add(Me.ButtonCE)
        Me.Controls.Add(Me.ButtonC)
        Me.Controls.Add(Me.ButtonBackspace)
        Me.Controls.Add(Me.OperationLabel)
        Me.Controls.Add(Me.FirstOperandLabel)
        Me.Controls.Add(Me.ButtonDigit1)
        Me.Controls.Add(Me.ButtonDigit0)
        Me.Controls.Add(Me.ButtonDigit8)
        Me.Controls.Add(Me.ButtonDigit5)
        Me.Controls.Add(Me.ButtonDigit2)
        Me.Controls.Add(Me.ButtonDigit4)
        Me.Controls.Add(Me.ButtonDigit7)
        Me.Controls.Add(Me.ButtonDigit9)
        Me.Controls.Add(Me.ButtonDigit6)
        Me.Controls.Add(Me.ButtonDigit3)
        Me.Controls.Add(Me.ButtonEquals)
        Me.Controls.Add(Me.ButtonDivide)
        Me.Controls.Add(Me.ButtonMultiply)
        Me.Controls.Add(Me.ButtonSubtract)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextIO)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextIO As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonSubtract As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivide As Button
    Friend WithEvents ButtonEquals As Button
    Friend WithEvents ButtonDigit3 As Button
    Friend WithEvents ButtonDigit6 As Button
    Friend WithEvents ButtonDigit9 As Button
    Friend WithEvents ButtonDigit7 As Button
    Friend WithEvents ButtonDigit4 As Button
    Friend WithEvents ButtonDigit2 As Button
    Friend WithEvents ButtonDigit5 As Button
    Friend WithEvents ButtonDigit8 As Button
    Friend WithEvents ButtonDigit0 As Button
    Friend WithEvents ButtonDigit1 As Button
    Friend WithEvents FirstOperandLabel As Label
    Friend WithEvents OperationLabel As Label
    Friend WithEvents ButtonBackspace As Button
    Friend WithEvents ButtonC As Button
    Friend WithEvents ButtonCE As Button
    Friend WithEvents ButtonPower As Button
    Friend WithEvents ButtonPeriod As Button
End Class
