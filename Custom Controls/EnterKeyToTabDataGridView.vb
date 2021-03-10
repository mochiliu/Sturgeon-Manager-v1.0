'This custom DataGridView control processes the enter key as the tab key

Imports System.Diagnostics
Public Class MyDataGridView
    Inherits DataGridView
    Public NoTabColumns As New List(Of DataGridViewColumn)
    Public Tabbing As Boolean = False
    Public AllowTabbing As Boolean = True

    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        If AllowTabbing And (keyData = Keys.Enter Or keyData = Keys.Tab) Then
            MyBase.ProcessTabKey(Keys.Tab)
            Do While NoTabColumns.Contains(Me.Columns(Me.CurrentCell.ColumnIndex)) And AllowTabbing
                Tabbing = True
                MyBase.ProcessTabKey(Keys.Tab)
            Loop
            Tabbing = False
            Return True
        End If
        Return MyBase.ProcessDialogKey(keyData)
    End Function

    Protected Overrides Function ProcessDataGridViewKey(ByVal e As KeyEventArgs) As Boolean
        If AllowTabbing And (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            MyBase.ProcessTabKey(Keys.Tab)
            Do While NoTabColumns.Contains(Me.Columns(Me.CurrentCell.ColumnIndex))
                Tabbing = True
                MyBase.ProcessTabKey(Keys.Tab)
            Loop
            Tabbing = False
            Return True
        End If
        Return MyBase.ProcessDataGridViewKey(e)
    End Function

    Protected Overrides Sub OnUserDeletingRow(ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs)
        MyBase.OnUserDeletingRow(e)
        If e.Cancel = False Then
            Me.AllowUserToAddRows = False 'this is needed because of a bug in MS Datagridview
        End If
    End Sub

    Protected Overrides Sub OnUserDeletedRow(ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)
        MyBase.OnUserDeletedRow(e)
        Me.AllowUserToAddRows = True 'this is needed because of a bug in MS Datagridview
    End Sub

End Class