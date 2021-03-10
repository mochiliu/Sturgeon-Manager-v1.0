Public Class ExtraFishInventory
    Public isReadOnly As Boolean = False

#Region "Form Events"
    Private Sub FemaleInventory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub FemaleInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.FemaleFishInventory' table. You can move, or remove it, as needed.
        Me.FemaleFishInventoryTableAdapter.Fill(Me.SturgeonDBDataSet.FemaleFishInventory)
    End Sub
#End Region


#Region "Button Events"
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        If Save() Then
            FemaleFishInventoryBindingSource.AddNew()
            FemaleFishInventoryMyDataGridView.Rows(FemaleFishInventoryMyDataGridView.Rows.Count - 1).Cells("InventoryDateColumn").Selected = True
        End If
    End Sub

    Private Sub FemaleFishInventoryBindingNavigator_SaveItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FemaleFishInventoryBindingNavigatorSaveItem.Click
        Save()
    End Sub

    Private Sub ExportExcelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportExcelButton.Click
        Try
            ExcelExport(FemaleFishInventoryMyDataGridView)
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
                Me.FemaleFishInventoryBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Me.FemaleFishInventoryTableAdapter.Fill(Me.SturgeonDBDataSet.FemaleFishInventory)
            FemaleFishInventoryBindingSource.MoveLast()
            Return True
        End Using
    End Function

    Public Sub LoadReadOnly()
        isReadOnly = True
        With Me
            .FemaleFishInventoryMyDataGridView.ReadOnly = True
            .Text = "View Male Harvests"
            BindingNavigatorDeleteItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = False
            FemaleFishInventoryBindingNavigatorSaveItem.Enabled = False
        End With
    End Sub
#End Region

    Private Sub FemaleFishInventoryBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles FemaleFishInventoryBindingSource.AddingNew
        Dim DefaultEntry As DataRowView = DirectCast(FemaleFishInventoryBindingSource.List, DataView).AddNew()
        DefaultEntry.Row.Item("InventoryDate") = Date.Now
        e.NewObject = DefaultEntry
        FemaleFishInventoryBindingSource.ResetBindings(False) 'refresh the controls
    End Sub

End Class