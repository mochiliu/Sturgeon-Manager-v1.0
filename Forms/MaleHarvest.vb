Public Class MaleHarvest
    Public isReadOnly As Boolean = False


#Region "Form Events"
    Private Sub MaleHarvest_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub MaleHarvest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.MaleFishHarvest' table. You can move, or remove it, as needed.
        Me.MaleFishHarvestTableAdapter.Fill(Me.SturgeonDBDataSet.MaleFishHarvest)

        Try
            FromTankColumn.Mask = ">L|99"
        Catch ex As Exception
            'out of index exception that occurs. No reason found
        End Try
    End Sub
#End Region

#Region "Button Events"
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        If Save() Then
            MaleFishHarvestBindingSource.AddNew()
            MaleFishHarvestDataGridView.Rows(MaleFishHarvestDataGridView.Rows.Count - 1).Cells("HarvestDateColumn").Selected = True
        End If
    End Sub

    Private Sub MaleFishHarvestBindingNavigator_SaveItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaleFishHarvestBindingNavigatorSaveItem.Click
        Save()
    End Sub

    Private Sub ExportExcelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportExcelButton.Click
        Try
            ExcelExport(MaleFishHarvestDataGridView)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Helper Subs"
    Public Function Save() As Boolean
        Using (New WaitCursor) 'Load Hourglass
            Try
                Me.Validate()
                Me.MaleFishHarvestBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Me.MaleFishHarvestTableAdapter.Fill(Me.SturgeonDBDataSet.MaleFishHarvest)
            MaleFishHarvestBindingSource.MoveLast()
            Return True
        End Using
    End Function

    Public Sub LoadReadOnly()
        isReadOnly = True
        With Me
            .MaleFishHarvestDataGridView.ReadOnly = True
            .Text = "View Male Harvests"
            BindingNavigatorDeleteItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = False
            MaleFishHarvestBindingNavigatorSaveItem.Enabled = False
        End With
    End Sub
#End Region

    Private Sub MaleFishHarvestBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MaleFishHarvestBindingSource.AddingNew
        Dim DefaultEntry As DataRowView = DirectCast(MaleFishHarvestBindingSource.List, DataView).AddNew()
        DefaultEntry.Row.Item("HarvestDate") = Date.Now
        e.NewObject = DefaultEntry
        MaleFishHarvestBindingSource.ResetBindings(False) 'refresh the controls
    End Sub


End Class