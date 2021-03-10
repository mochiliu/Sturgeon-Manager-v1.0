<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackUpRecovery
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.CancelButton = New System.Windows.Forms.Button
        Me.RecoverButton = New System.Windows.Forms.Button
        Me.BackUpFilesListView = New System.Windows.Forms.ListView
        Me.FileNameColumn = New System.Windows.Forms.ColumnHeader
        Me.TimeCreatedColumn = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WARNING: All other Sturgeon Manager windows " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "must be closed before continuing to" & _
            " ensure" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "no data loss"
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(109, 365)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'RecoverButton
        '
        Me.RecoverButton.Location = New System.Drawing.Point(221, 365)
        Me.RecoverButton.Name = "RecoverButton"
        Me.RecoverButton.Size = New System.Drawing.Size(75, 23)
        Me.RecoverButton.TabIndex = 3
        Me.RecoverButton.Text = "Recover"
        Me.RecoverButton.UseVisualStyleBackColor = True
        '
        'BackUpFilesListView
        '
        Me.BackUpFilesListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileNameColumn, Me.TimeCreatedColumn})
        Me.BackUpFilesListView.FullRowSelect = True
        Me.BackUpFilesListView.GridLines = True
        Me.BackUpFilesListView.LabelWrap = False
        Me.BackUpFilesListView.Location = New System.Drawing.Point(12, 63)
        Me.BackUpFilesListView.MultiSelect = False
        Me.BackUpFilesListView.Name = "BackUpFilesListView"
        Me.BackUpFilesListView.Size = New System.Drawing.Size(402, 296)
        Me.BackUpFilesListView.TabIndex = 4
        Me.BackUpFilesListView.UseCompatibleStateImageBehavior = False
        Me.BackUpFilesListView.View = System.Windows.Forms.View.Details
        '
        'FileNameColumn
        '
        Me.FileNameColumn.Text = "File Name"
        Me.FileNameColumn.Width = 200
        '
        'TimeCreatedColumn
        '
        Me.TimeCreatedColumn.Text = "Time Created"
        Me.TimeCreatedColumn.Width = 200
        '
        'BackUpRecovery
        '
        Me.AcceptButton = Me.RecoverButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 400)
        Me.Controls.Add(Me.BackUpFilesListView)
        Me.Controls.Add(Me.RecoverButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BackUpRecovery"
        Me.Text = "Back Up Recovery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents RecoverButton As System.Windows.Forms.Button
    Friend WithEvents BackUpFilesListView As System.Windows.Forms.ListView
    Friend WithEvents FileNameColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents TimeCreatedColumn As System.Windows.Forms.ColumnHeader
End Class
