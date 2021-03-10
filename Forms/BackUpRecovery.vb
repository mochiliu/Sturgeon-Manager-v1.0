'This Form allows users to recover form auto generated back up files
Public Class BackUpRecovery
    Private sortColumn As Integer = 1

    Private Sub BackUpRecovery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' make a reference to a directory
        Dim di As New IO.DirectoryInfo(My.Application.Info.DirectoryPath & "\BackUp")
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo

        'list the names of all files in the specified directory
        For Each dra In diar1
            Dim NewEntry = BackUpFilesListView.Items.Add(dra.Name)
            NewEntry.SubItems.Add(BackUpTextToTime(dra.Name))
        Next
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        Me.BackUpFilesListView.ListViewItemSorter = New ListViewItemComparer(sortColumn, SortOrder.Descending)
        ' Call the sort method to manually sort.
        BackUpFilesListView.Sort()
    End Sub


    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub RecoverButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecoverButton.Click
        If BackUpFilesListView.SelectedItems.Count = 1 Then
            Try
                BackUp()
                My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\BackUp\" & BackUpFilesListView.SelectedItems(0).Text, My.Application.Info.DirectoryPath & "\SturgeonDB.mdb", True)
                MsgBox("Recovery Successful")
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please Select the file to recover")
        End If
    End Sub
End Class