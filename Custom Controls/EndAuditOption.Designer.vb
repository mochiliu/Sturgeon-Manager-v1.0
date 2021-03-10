<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndAuditOption
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
        Me.EndAuditButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CancelButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.QuitButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'EndAuditButton
        '
        Me.EndAuditButton.Location = New System.Drawing.Point(29, 26)
        Me.EndAuditButton.Name = "EndAuditButton"
        Me.EndAuditButton.Size = New System.Drawing.Size(85, 29)
        Me.EndAuditButton.TabIndex = 0
        Me.EndAuditButton.Text = "End Audit"
        Me.EndAuditButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "End Audit and note all items still In Inventory as ""Not In Freezer""."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Go back to the Form.  I want to keep working."
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(29, 66)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(85, 29)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(360, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "I want to quit, don’t record any of the changes I made so far in this session."
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(29, 107)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(85, 29)
        Me.QuitButton.TabIndex = 4
        Me.QuitButton.Text = "Quit Audit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'EndAuditOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 170)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EndAuditButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EndAuditOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "End Audit Options"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EndAuditButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents QuitButton As System.Windows.Forms.Button
End Class
