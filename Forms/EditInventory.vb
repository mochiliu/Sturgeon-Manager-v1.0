Imports System.Drawing.Printing

'This form allows users to view and edit the inventory, including items that has been sold
Public Class EditInventory
    Public myFilter As Filter
    Public isReadOnly As Boolean = False
    Public isClosing As Boolean = False
    Public isLoading As Boolean = True
    Public pd As New PrintDialog()

#Region "Form Events"
    Private Sub EditInventory_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myFilter.Close()
    End Sub

    Private Sub EditInventory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
        isClosing = True
    End Sub

    Private Sub EditInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Inventory' table. You can move, or remove it, as needed.
        Me.Caviar_InventoryTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Inventory)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.GradeSelection' table. You can move, or remove it, as needed.
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarStatusSelection' table. You can move, or remove it, as needed.
        Me.CaviarStatusSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarStatusSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarInventoryJoinCaviarFish' table. You can move, or remove it, as needed.
        Me.CaviarInventoryJoinCaviarFishTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarInventoryJoinCaviarFish)

        myFilter = New Filter(Me, CaviarInventoryJoinCaviarFishBindingSource)
        isLoading = False
    End Sub

#End Region

#Region "Button Events"
    Private Sub CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem.Click
        Save()
    End Sub

    Private Sub FilterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterButton.Click
        Save()
        myFilter.Show()
    End Sub

    Private Sub ExportInventoryDisplayedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportInventoryDisplayedToolStripMenuItem.Click
        ExcelExport(CaviarInventoryJoinCaviarFishDataGridView)
    End Sub

    Private Sub ExportQuickSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportQuickSummaryToolStripMenuItem.Click
        ExcelExport(CaviarInventoryDisplayDataGridView)
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        pd.PrinterSettings = New PrinterSettings()
        pd.ShowDialog()
        PrintLabelDirectInput(CaviarInventoryJoinCaviarFishBindingSource.Current("PKBarcode"), CaviarInventoryJoinCaviarFishBindingSource.Current("Harvest Date"), CaviarInventoryJoinCaviarFishBindingSource.Current("Eggsize"), CaviarInventoryJoinCaviarFishBindingSource.Current("Egg Color"), CaviarInventoryJoinCaviarFishBindingSource.Current("Species"), SturgeonDBDataSet.Products.FindByPKProductID(CaviarInventoryJoinCaviarFishBindingSource.Current("FKProductID")).Item("Product Name"), pd)
    End Sub

#End Region

#Region "QuickSummary"
    Public Sub RefreshQuickSummary()

        'update the caviar quick summary
        Dim GramsOfCaviar As Double = 0
        Dim DisplayedCaviarInventory As New Dictionary(Of Integer, CaviarSummaryEntry) 'caviar order is a dictionary of (productID, CaviarOrderSummaryEntry)

        For I = 0 To CaviarInventoryJoinCaviarFishDataGridView.Rows.Count - 1
            With CaviarInventoryJoinCaviarFishDataGridView.Rows(I)
                If Not IsDBNull(.Cells("ProductUnitWeightColumn").FormattedValue) And Not IsNothing(.Cells("ProductUnitWeightColumn").FormattedValue) And Not .Cells("ProductUnitWeightColumn").FormattedValue = "" Then
                    Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(.Cells("FKProductID").Value)
                    If DisplayedCaviarInventory.ContainsKey(ProductRow.PKProductID) Then
                        'product entry already exists, add a count
                        DisplayedCaviarInventory(ProductRow.PKProductID).Add()
                    Else
                        'product entry does not exist, add an entry
                        DisplayedCaviarInventory.Add(ProductRow.PKProductID, New CaviarSummaryEntry(ProductRow.Product_Name, ProductRow.UnitWeightgms, 0, ""))
                    End If
                End If
            End With
        Next

        'update the order display dgv
        CaviarInventoryDisplayDataGridView.Rows.Clear()
        Dim CaviarInventoryTotal As CaviarSummaryEntry = New CaviarSummaryEntry("Displayed Inventory Total", 0, 0, "", 0)
        Dim CaviarGradeSubTotal As CaviarSummaryEntry = New CaviarSummaryEntry("", 0, 0, "", 0)
        For Each Product As DataRow In SturgeonDBDataSet.Products
            'this adds the entries in the order of the product table
            If DisplayedCaviarInventory.ContainsKey(Product.Item("PKProductID")) Then
                Dim Entry As CaviarSummaryEntry = DisplayedCaviarInventory(Product.Item("PKProductID"))

                Dim GradeRow As DataRow = SturgeonDBDataSet.GradeSelection.FindByID(Product.Item("Grade"))
                If Not GradeRow.Item("Grade") = CaviarGradeSubTotal.ProductCode Then
                    'display the grade subtotal if the we are no longer in the same grade
                    If CaviarGradeSubTotal.ProductCode <> "" Then
                        CaviarInventoryDisplayDataGridView.Rows.Add()
                        CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = "Grade " & CaviarGradeSubTotal.ProductCode & " Subtotal"
                        CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.Count
                        CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.TotalKgs
                        For Each Cell As DataGridViewCell In CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells
                            Cell.Style.Font = New Font(CaviarInventoryDisplayDataGridView.Font, FontStyle.Bold)
                        Next
                        CaviarInventoryDisplayDataGridView.Rows.Add() 'add an empty row after
                    End If
                    'reinitialize
                    CaviarGradeSubTotal = New CaviarSummaryEntry(GradeRow.Item("Grade"), 0, 0, "", 0)
                End If

                CaviarInventoryDisplayDataGridView.Rows.Add()
                'edit the last row added
                CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = Entry.ProductCode
                CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = Entry.Count
                CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = Entry.TotalKgs

                'add to subtotal is the entry is still in the same grade
                CaviarGradeSubTotal.Count += Entry.Count
                CaviarGradeSubTotal.TotalKgs += Entry.TotalKgs
                CaviarInventoryTotal.Count += Entry.Count
                CaviarInventoryTotal.TotalKgs += Entry.TotalKgs
            End If
        Next
        'display the total row and the last subtotal row (if it exists)
        Try
            If CaviarGradeSubTotal.ProductCode <> "" Then
                CaviarInventoryDisplayDataGridView.Rows.Add()
                CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = "Grade " & CaviarGradeSubTotal.ProductCode & " Subtotal"
                CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.Count
                CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.TotalKgs
                For Each Cell As DataGridViewCell In CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells
                    Cell.Style.Font = New Font(CaviarInventoryDisplayDataGridView.Font, FontStyle.Bold)
                Next
                CaviarInventoryDisplayDataGridView.Rows.Add() 'add an empty row after
            End If
            CaviarInventoryDisplayDataGridView.Rows.Add()
            CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = CaviarInventoryTotal.ProductCode
            CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = CaviarInventoryTotal.Count
            CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = CaviarInventoryTotal.TotalKgs
            For Each Cell As DataGridViewCell In CaviarInventoryDisplayDataGridView.Rows(CaviarInventoryDisplayDataGridView.Rows.Count - 1).Cells
                Cell.Style.Font = New Font(CaviarInventoryDisplayDataGridView.Font, FontStyle.Bold)
            Next
        Catch ex As Exception
            'catches when the form first loads (before columns has been added)
        End Try
    End Sub

    Private Sub CaviarInventoryJoinCaviarFishDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CaviarInventoryJoinCaviarFishDataGridView.CellValueChanged
        If Not isLoading AndAlso e.ColumnIndex = InventoryStatus.Index Then
            'if a inventory status is changed, store the time and the previous state
            CaviarInventoryJoinCaviarFishDataGridView.Rows(e.RowIndex).Cells("DateStatusChanged").Value = Date.Now
            'load the previous inventory status from the time last saved
            Dim CaviarInventoryRow As SturgeonDBDataSet.Caviar_InventoryRow = SturgeonDBDataSet.Caviar_Inventory.FindByPKBarcode(CaviarInventoryJoinCaviarFishDataGridView.Rows(e.RowIndex).Cells("PKBarcode").Value)
            CaviarInventoryJoinCaviarFishDataGridView.Rows(e.RowIndex).Cells("PreviousStatus").Value = CaviarInventoryRow("InventoryStatus")
            RefreshQuickSummary()
        End If
    End Sub

    Private Sub CaviarInventoryJoinCaviarFishBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles CaviarInventoryJoinCaviarFishBindingSource.ListChanged
        RefreshQuickSummary()
    End Sub
#End Region
    Public Sub LoadReadOnly()
        isReadOnly = True
        With Me
            .CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem.Enabled = False
            .CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem.Visible = False
            .BindingNavigatorAddNewItem.Visible = False
            .BindingNavigatorDeleteItem.Visible = False

            .CaviarInventoryJoinCaviarFishDataGridView.ReadOnly = True

            .Text = "View Inventory"
        End With
    End Sub

    Public Function Save()
        Using (New WaitCursor)
            Try
                Me.Validate()
                Me.CaviarInventoryJoinCaviarFishBindingSource.EndEdit()
                Me.CaviarInventoryJoinCaviarFishTableAdapter.Update(SturgeonDBDataSet.CaviarInventoryJoinCaviarFish)
                Me.CaviarInventoryJoinCaviarFishTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarInventoryJoinCaviarFish)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Return True
        End Using
    End Function

    Private Sub CaviarInventoryJoinCaviarFishDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles CaviarInventoryJoinCaviarFishDataGridView.DataError
        If isClosing Then
            e.Cancel = True
        End If
        'MsgBox(e.Exception.Message & e.ColumnIndex & "," & e.RowIndex)
    End Sub

End Class
