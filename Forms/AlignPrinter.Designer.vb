<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlignPrinter
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
        Me.XAxisNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.YAxisNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.TestButton = New System.Windows.Forms.Button
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.XInchLabel = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.YInchLabel = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.XAxisNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YAxisNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XAxisNumericUpDown
        '
        Me.XAxisNumericUpDown.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.XAxisNumericUpDown.Location = New System.Drawing.Point(138, 24)
        Me.XAxisNumericUpDown.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.XAxisNumericUpDown.Minimum = New Decimal(New Integer() {500, 0, 0, -2147483648})
        Me.XAxisNumericUpDown.Name = "XAxisNumericUpDown"
        Me.XAxisNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.XAxisNumericUpDown.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Horizontal Alignment:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Left is negative)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Vertical Alignment:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Up is negative)"
        '
        'YAxisNumericUpDown
        '
        Me.YAxisNumericUpDown.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.YAxisNumericUpDown.Location = New System.Drawing.Point(138, 68)
        Me.YAxisNumericUpDown.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.YAxisNumericUpDown.Minimum = New Decimal(New Integer() {300, 0, 0, -2147483648})
        Me.YAxisNumericUpDown.Name = "YAxisNumericUpDown"
        Me.YAxisNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.YAxisNumericUpDown.TabIndex = 2
        '
        'TestButton
        '
        Me.TestButton.Location = New System.Drawing.Point(58, 136)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(103, 48)
        Me.TestButton.TabIndex = 4
        Me.TestButton.Text = "Test"
        Me.TestButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(216, 136)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(103, 48)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Dots/"
        '
        'XInchLabel
        '
        Me.XInchLabel.AutoSize = True
        Me.XInchLabel.Location = New System.Drawing.Point(294, 26)
        Me.XInchLabel.Name = "XInchLabel"
        Me.XInchLabel.Size = New System.Drawing.Size(13, 13)
        Me.XInchLabel.TabIndex = 8
        Me.XInchLabel.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "inch"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "inch"
        '
        'YInchLabel
        '
        Me.YInchLabel.AutoSize = True
        Me.YInchLabel.Location = New System.Drawing.Point(294, 70)
        Me.YInchLabel.Name = "YInchLabel"
        Me.YInchLabel.Size = New System.Drawing.Size(13, 13)
        Me.YInchLabel.TabIndex = 11
        Me.YInchLabel.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Dots/"
        '
        'AlignPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 230)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.YInchLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.XInchLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.TestButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.YAxisNumericUpDown)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.XAxisNumericUpDown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AlignPrinter"
        Me.Text = "Align Zebra Printer"
        CType(Me.XAxisNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YAxisNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XAxisNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents YAxisNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TestButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XInchLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents YInchLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
