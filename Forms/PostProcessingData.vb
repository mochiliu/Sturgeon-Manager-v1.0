
'This form allows users to add the fish information unable to be entered during processing
Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Drawing.Printing

Public Class PostProcessingData
    Public myFilter As Filter
    Public isReadOnly As Boolean = False
    Public pd As New PrintDialog()
    Public isLoading As Boolean = True

#Region "Form Events"
    Private Sub PostProcessingData_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myFilter.Close()
    End Sub

    Private Sub PostProcessingData_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isReadOnly Then
            Exit Sub
        End If

        Select Case MsgBox("Save the data entered?", MsgBoxStyle.YesNoCancel)
            Case vbYes 'Save
                If Not Save() Then
                    e.Cancel = True
                End If
            Case vbCancel
                e.Cancel = True
            Case Else
                'do nothing
        End Select
    End Sub

    Private Sub PostProcessingData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Fish' table. You can move, or remove it, as needed.
        Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)

        myFilter = New Filter(Me, Caviar_FishBindingSource)
        isLoading = False
    End Sub
#End Region

#Region "Button Events"

    Private Sub ExportExcelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportExcelButton.Click
        Try
            ExcelExport(Caviar_FishDataGridView)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FilterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterButton.Click
        Save()
        myFilter.Show()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Select Case MsgBox("Deleting a fish also removes the tins of caviar associated with it (including those already been invoiced). Continue?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Caviar_FishBindingSource.RemoveCurrent()
        End Select
    End Sub

    Private Sub Caviar_FishBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Caviar_FishBindingNavigatorSaveItem.Click
        Save()
    End Sub

    Public Function Save() As Boolean
        Using (New WaitCursor)
            Try
                Me.Validate()
                Me.Caviar_FishBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Return True
        End Using
    End Function

#End Region


    Public Sub LoadReadOnly()
        isReadOnly = True
        With Me
            .Caviar_FishBindingNavigatorSaveItem.Enabled = False
            .Caviar_FishBindingNavigatorSaveItem.Visible = False
            .BindingNavigatorAddNewItem.Visible = False
            .BindingNavigatorDeleteItem.Visible = False

            .Caviar_FishDataGridView.ReadOnly = True

            .Text = "View Fish and Inventory"
        End With
    End Sub

    Private Sub Caviar_FishDataGridView_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles Caviar_FishDataGridView.UserDeletingRow
        Select Case MsgBox("Deleting a fish also removes the tins of caviar associated with it (including those already been invoiced). Continue?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.No
                e.Cancel = True
        End Select
    End Sub

End Class