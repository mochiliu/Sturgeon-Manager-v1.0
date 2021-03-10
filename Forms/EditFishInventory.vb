
'This form allows users to edit the fish information in addition to the caviar inventory information associated with each fish
Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Drawing.Printing

Public Class EditFishInventory
    Public myFilter As Filter
    Public isReadOnly As Boolean = False
    Public pd As New PrintDialog()
    Public isLoading As Boolean = True

#Region "Form Events"
    Private Sub EditFishInventory_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myFilter.Close()
    End Sub

    Private Sub EditFishInventory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub EditInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarStatusSelection' table. You can move, or remove it, as needed.
        Me.CaviarStatusSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarStatusSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.GradeSelection' table. You can move, or remove it, as needed.
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Inventory' table. You can move, or remove it, as needed.
        Me.Caviar_InventoryTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Inventory)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Fish' table. You can move, or remove it, as needed.
        Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)

        myFilter = New Filter(Me, Caviar_FishBindingSource)
        isLoading = False
    End Sub
#End Region

#Region "Button Events"
    Private Sub Caviar_FishDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Caviar_FishDataGridView.DataError
        If e.ColumnIndex = Caviar_FishDataGridView.Columns("GradeColumn").Index Then
            e.Cancel = True 'this lets the grades have null values
        End If
    End Sub

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
                Me.Caviar_InventoryBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Return True
        End Using
    End Function

    Private Sub PrintAllFishLabelsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintAllFishLabelsToolStripMenuItem.Click
        pd.PrinterSettings = New PrinterSettings()
        pd.ShowDialog()

        For Each Item As DataRowView In Caviar_InventoryBindingSource.List
            PrintLabel(Item, Caviar_FishBindingSource.Current, SturgeonDBDataSet.Products.FindByPKProductID(Item("FKProductID")).Item("Product Name"), pd)
        Next
    End Sub

    Private Sub PrintSelectedLabelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSelectedLabelToolStripMenuItem.Click
        pd.PrinterSettings = New PrinterSettings()
        pd.ShowDialog()
        PrintLabel(Caviar_InventoryBindingSource.Current, Caviar_FishBindingSource.Current, SturgeonDBDataSet.Products.FindByPKProductID(Caviar_InventoryBindingSource.Current("FKProductID")).Item("Product Name"), pd)
    End Sub

#End Region

#Region "QuickSummary"
    Public Sub RefreshQuickSummary()
        'update the fish quick summary
        TotalFishCountTextBox.Text = Caviar_FishBindingSource.Count
        Dim I As Integer = 0
        Dim FishCompleted As Integer = 0
        Dim KgsOfLiveFish As Double = 0
        Dim GramsOfEggs As Double = 0
        'loop through the entire datagridview
        For I = 0 To Caviar_FishDataGridView.Rows.Count - 1
            With Caviar_FishDataGridView.Rows(I)
                If Not IsDBNull(.Cells("CompletedColumn").Value) And .Cells("CompletedColumn").Value = True Then
                    FishCompleted += 1
                End If
                If Not IsDBNull(.Cells("LiveWtColumn").Value) Then
                    KgsOfLiveFish += .Cells("LiveWtColumn").Value
                End If
                If Not IsDBNull(.Cells("EggWtColumn").Value) Then
                    GramsOfEggs += .Cells("EggWtColumn").Value
                End If
            End With
        Next
        ProcessedFishCountTextBox.Text = FishCompleted
        TotKgsFishTextBox.Text = KgsOfLiveFish
        TotEggsTextBox.Text = GramsOfEggs

        'update the caviar quick summary
        Dim GramsOfCaviar As Double = 0
        For I = 0 To Caviar_InventoryDataGridView.Rows.Count - 1
            With Caviar_InventoryDataGridView.Rows(I)
                If Not IsDBNull(.Cells("ProductUnitWeightColumn").FormattedValue) And Not IsNothing(.Cells("ProductUnitWeightColumn").FormattedValue) And Not .Cells("ProductUnitWeightColumn").FormattedValue = "" Then
                    GramsOfCaviar += Convert.ToDouble(.Cells("ProductUnitWeightColumn").FormattedValue)
                End If
            End With
        Next
        TotalCaviarPackedTextBox.Text = GramsOfCaviar
        TinsPackedTextBox.Text = Caviar_InventoryBindingSource.Count
    End Sub
    Private Sub Caviar_FishBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles Caviar_FishBindingSource.ListChanged
        RefreshQuickSummary()
    End Sub

    Private Sub Caviar_InventoryBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles Caviar_InventoryBindingSource.ListChanged
        RefreshQuickSummary()
    End Sub

    Private Sub Caviar_InventoryDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Caviar_InventoryDataGridView.CellValueChanged
        If Not isLoading AndAlso e.ColumnIndex = InventoryStatusColumn.Index Then
            'if a inventory status is changed, store the time and the previous state
            Caviar_InventoryDataGridView.Rows(e.RowIndex).Cells("DateStatusChanged").Value = Date.Now
            'load the previous inventory status from the time last saved
            Dim CaviarInventoryRow As SturgeonDBDataSet.Caviar_InventoryRow = SturgeonDBDataSet.Caviar_Inventory.FindByPKBarcode(Caviar_InventoryDataGridView.Rows(e.RowIndex).Cells("PKBarcodeColumn").Value)
            Caviar_InventoryDataGridView.Rows(e.RowIndex).Cells("PreviousStatus").Value = CaviarInventoryRow("InventoryStatus", DataRowVersion.Original)
            RefreshQuickSummary()
        End If
    End Sub

    Private Sub Caviar_FishDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Caviar_FishDataGridView.CellValueChanged
        RefreshQuickSummary()
    End Sub
#End Region

    Public Sub LoadReadOnly()
        isReadOnly = True
        With Me
            .Caviar_FishBindingNavigatorSaveItem.Enabled = False
            .Caviar_FishBindingNavigatorSaveItem.Visible = False
            .BindingNavigatorAddNewItem.Visible = False
            .BindingNavigatorDeleteItem.Visible = False

            .Caviar_FishDataGridView.ReadOnly = True
            .Caviar_InventoryDataGridView.ReadOnly = True

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