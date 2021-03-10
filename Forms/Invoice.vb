
'This form allows the user to view and modify invoices that have been created
Public Class Invoice
    Public myFilter As Filter
    Public isReadOnly As Boolean = False
    Public CaviarNonInventoryProductsFilter As String = ""
    Public FishNonInventoryProductsFilter As String = ""
    Public CaviarProductsFilter As String = ""

#Region "Form Events"
    Private Sub Invoice_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myFilter.Close()
    End Sub

    Private Sub Invoice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isReadOnly Then
            Exit Sub
        End If
        Select Case MsgBox("Save the data entered?", MsgBoxStyle.YesNoCancel)
            Case vbYes 'Save
                InvoicesBindingNavigatorSaveItem_Click(Nothing, Nothing)
            Case vbCancel
                e.Cancel = True
            Case Else
                'do nothing
        End Select
    End Sub

    Private Sub Invoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.ProductCategorySelection' table. You can move, or remove it, as needed.
        Me.ProductCategorySelectionTableAdapter.Fill(Me.SturgeonDBDataSet.ProductCategorySelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.InvoiceTypeSelection' table. You can move, or remove it, as needed.
        Me.InvoiceTypeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.InvoiceTypeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.GradeSelection' table. You can move, or remove it, as needed.
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet._Non_Inventory_Invoice_Records' table. You can move, or remove it, as needed.
        Me.Non_Inventory_Invoice_RecordsTableAdapter.Fill(Me.SturgeonDBDataSet._Non_Inventory_Invoice_Records)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarStatusSelection' table. You can move, or remove it, as needed.
        Me.CaviarStatusSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarStatusSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Fish' table. You can move, or remove it, as needed.
        Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Inventory' table. You can move, or remove it, as needed.
        Me.Caviar_InventoryTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Inventory)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Billing_Addresses' table. You can move, or remove it, as needed.
        Me.Billing_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Billing_Addresses)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Shipping_Addresses' table. You can move, or remove it, as needed.
        Me.Shipping_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Shipping_Addresses)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.SturgeonDBDataSet.Customers)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Invoices' table. You can move, or remove it, as needed.
        Me.InvoicesTableAdapter.Fill(Me.SturgeonDBDataSet.Invoices)

        On Error Resume Next 'for when there is no invoice records
        myFilter = New Filter(Me, InvoicesBindingSource)

        'define what is the filter for non-inventory items section for a caviar invoice, i.e. display all products except for fish and caviar
        For Each ProductCategory As SturgeonDBDataSet.ProductCategorySelectionRow In SturgeonDBDataSet.ProductCategorySelection.Rows
            If ProductCategory.NonInventoryInCaviarInvoice Then
                If CaviarNonInventoryProductsFilter = "" Then
                    CaviarNonInventoryProductsFilter = "[ProductCategory] = " & ProductCategory.ProductCategoryID 'display all products except for those without pricing
                Else
                    CaviarNonInventoryProductsFilter = CaviarNonInventoryProductsFilter & " OR [ProductCategory] = " & ProductCategory.ProductCategoryID
                End If
            End If
        Next

        'define what is the filter for non-inventory items section for a fish invoice, i.e. display all products except caviar
        For Each ProductCategory As SturgeonDBDataSet.ProductCategorySelectionRow In SturgeonDBDataSet.ProductCategorySelection.Rows
            If ProductCategory.NonInventory Then
                If FishNonInventoryProductsFilter = "" Then
                    FishNonInventoryProductsFilter = "[ProductCategory] = " & ProductCategory.ProductCategoryID 'display all products except for those without pricing
                Else
                    FishNonInventoryProductsFilter = FishNonInventoryProductsFilter & " OR [ProductCategory] = " & ProductCategory.ProductCategoryID
                End If
            End If
        Next

        Caviar_InventoryDataGridView.Sort(OrderOnInvoice, System.ComponentModel.ListSortDirection.Ascending)
        CalculateTotals()


    End Sub
#End Region

#Region "Calculate Total"
    Public Sub CalculateTotals(Optional ByVal UpdateTotal As Boolean = False)

        Dim TotalSales As Decimal = 0
        If InvoicesBindingSource.List.Count > 0 Then
            For Each InvoiceRecord As DataRowView In InvoicesBindingSource.List
                TotalSales += InvoiceRecord.Item("Total")
            Next
            TotalSalesTextBox.Text = FormatCurrency(TotalSales)
            InvoiceCountTextBox.Text = InvoicesBindingSource.Count
        Else
            'no invoices
            TotalSalesTextBox.Text = FormatCurrency(TotalSales)
            InvoiceCountTextBox.Text = InvoicesBindingSource.Count
            NonInventoryProductBindingSource.Filter = ""
            Exit Sub
        End If


        Dim CaviarSubtotal As Decimal = 0.0

        If DirectCast(InvoicesBindingSource.Current, System.Data.DataRowView).Item("InvoiceType") = 1 Then 'The invoice is caviar invoice
            'display the caviar portion of the invoice
            InvoicedItemsSplitContainer.Panel1Collapsed = False
            EditFishInvoice.Visible = False
            NonInventoryProductBindingSource.Filter = CaviarNonInventoryProductsFilter 'display all products except for fish and caviar
            'CaviarGroupBox.Visible = True
            'NonInventoryGroupBox.Location = New Point(NonInventoryGroupBox.Location.X, CaviarGroupBox.Location.Y + CaviarGroupBox.Size.Height + 6)
            'NonInventoryGroupBox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            'NonInventoryGroupBox.Height = 168

            'Update the caviar subtotal
            Dim CaviarBoxOrder As New Dictionary(Of ProductBoxPair, CaviarSummaryEntry) 'caviar order is a dictionary of (productID,Box Name) key and CaviarOrderSummaryEntry value
            Dim CaviarOrder As New Dictionary(Of Integer, CaviarSummaryEntry)
            Dim SetOfBoxes As New List(Of String) 'this is a list of all the shipping boxes

            For Each Entry As DataGridViewRow In Caviar_InventoryDataGridView.Rows
                If Not IsNothing(Entry.Cells("CaviarPriceSoldAtColumn").Value) AndAlso Not IsDBNull(Entry.Cells("CaviarPriceSoldAtColumn").Value) AndAlso Not IsNothing(Entry.Cells("PackingBoxNumberColumn").Value) AndAlso Not IsDBNull(Entry.Cells("PackingBoxNumberColumn").Value) Then
                    Dim ContainerRow As SturgeonDBDataSet.Caviar_InventoryRow = SturgeonDBDataSet.Caviar_Inventory.FindByPKBarcode(Entry.Cells("PKBarcodeColumn").Value)
                    Dim ProductRow As SturgeonDBDataSet.ProductsRow = ContainerRow.ProductsRow
                    Dim currentKey As ProductBoxPair
                    currentKey.ProductID = ProductRow.PKProductID
                    currentKey.BoxName = Entry.Cells("PackingBoxNumberColumn").Value

                    'keep track of all items
                    If CaviarOrder.ContainsKey(ProductRow.PKProductID) Then
                        'product entry already exists, add a count
                        CaviarOrder(ProductRow.PKProductID).Add()
                    Else
                        'product entry does not exist, add an entry
                        CaviarOrder.Add(ProductRow.PKProductID, New CaviarSummaryEntry(ProductRow.Product_Name, ProductRow.UnitWeightgms, Entry.Cells("CaviarPriceSoldAtColumn").Value, "Order Total"))
                    End If

                    'keep track of items in terms of boxes
                    If CaviarBoxOrder.ContainsKey(currentKey) Then
                        'product, box entry already exists, add a count
                        CaviarBoxOrder(currentKey).Add()
                    Else
                        'product, box entry does not exist, add an entry
                        CaviarBoxOrder.Add(currentKey, New CaviarSummaryEntry(ProductRow.Product_Name, ProductRow.UnitWeightgms, Entry.Cells("CaviarPriceSoldAtColumn").Value, Entry.Cells("PackingBoxNumberColumn").Value))
                    End If

                    Entry.Cells("PricePerItemColumn").Value = Entry.Cells("CaviarPriceSoldAtColumn").Value * ProductRow.UnitWeightgms / 1000
                    CaviarSubtotal = CaviarSubtotal + FormatNumber(Entry.Cells("PricePerItemColumn").Value)

                    'keep track of a list of packing boxes
                    If Not SetOfBoxes.Contains(Entry.Cells("PackingBoxNumberColumn").Value) Then
                        SetOfBoxes.Add(Entry.Cells("PackingBoxNumberColumn").Value)
                    End If
                End If
            Next

            SetOfBoxes.Sort() 'sort the box names
            CaviarOrderDisplayDataGridView.Rows.Clear() 'clear the order display dgv

            'update the order display dgv starting with the boxes
            For Each BoxName As String In SetOfBoxes 'loop through the boxes
                Dim BoxTotal As CaviarSummaryEntry = New CaviarSummaryEntry("Box " & BoxName & " Total", 0, 0, BoxName, 0)
                Dim BoxGradeSubTotal As CaviarSummaryEntry = New CaviarSummaryEntry("", 0, 0, BoxName, 0)
                For Each Product As DataRow In SturgeonDBDataSet.Products
                    'add the entries in the order of the product table

                    'create the key of product and boxname pair
                    Dim currentKey As ProductBoxPair
                    currentKey.ProductID = Product.Item("PKProductID")
                    currentKey.BoxName = BoxName

                    If CaviarBoxOrder.ContainsKey(currentKey) Then
                        Dim Entry As CaviarSummaryEntry = CaviarBoxOrder(currentKey)

                        Dim GradeRow As DataRow = SturgeonDBDataSet.GradeSelection.FindByID(Product.Item("Grade"))
                        If Not GradeRow.Item("Grade") = BoxGradeSubTotal.ProductCode Then
                            'display the grade subtotal if the we are no longer in the same grade
                            If BoxGradeSubTotal.ProductCode <> "" Then
                                CaviarOrderDisplayDataGridView.Rows.Add()
                                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = "Box " & BoxGradeSubTotal.BoxName & " Grade " & BoxGradeSubTotal.ProductCode & " Subtotal"
                                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = BoxGradeSubTotal.Count
                                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = BoxGradeSubTotal.TotalKgs
                                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("SubTotalCaviarOrderDisplayColumn").Value = BoxGradeSubTotal.TotalPrice
                                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("BoxNameCaviarOrderDisplayColumn").Value = BoxGradeSubTotal.BoxName
                            End If
                            'reinitialize
                            BoxGradeSubTotal = New CaviarSummaryEntry(GradeRow.Item("Grade"), 0, 0, BoxName, 0)
                        End If

                        CaviarOrderDisplayDataGridView.Rows.Add()
                        'edit the last row added
                        CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = Entry.ProductCode
                        CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = Entry.Count
                        CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("PriceSoldAtCaviarOrderDisplayColumn").Value = Entry.PricePerKg
                        CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = Entry.TotalKgs
                        CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("SubTotalCaviarOrderDisplayColumn").Value = Entry.TotalPrice
                        CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("BoxNameCaviarOrderDisplayColumn").Value = Entry.BoxName

                        'add to subtotal is the entry is still in the same grade
                        BoxGradeSubTotal.Count += Entry.Count
                        BoxGradeSubTotal.TotalKgs += Entry.TotalKgs
                        BoxGradeSubTotal.TotalPrice += Entry.TotalPrice
                        BoxTotal.Count += Entry.Count
                        BoxTotal.TotalKgs += Entry.TotalKgs
                        BoxTotal.TotalPrice += Entry.TotalPrice
                    End If
                Next
                'display the last subtotal row (if it exists)
                If BoxGradeSubTotal.ProductCode <> "" Then
                    CaviarOrderDisplayDataGridView.Rows.Add()
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = "Box " & BoxGradeSubTotal.BoxName & " Grade " & BoxGradeSubTotal.ProductCode & " Subtotal"
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = BoxGradeSubTotal.Count
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = BoxGradeSubTotal.TotalKgs
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("SubTotalCaviarOrderDisplayColumn").Value = BoxGradeSubTotal.TotalPrice
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("BoxNameCaviarOrderDisplayColumn").Value = BoxGradeSubTotal.BoxName
                End If
                CaviarOrderDisplayDataGridView.Rows.Add()
                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = BoxTotal.ProductCode
                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = BoxTotal.Count
                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = BoxTotal.TotalKgs
                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("SubTotalCaviarOrderDisplayColumn").Value = BoxTotal.TotalPrice
                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("BoxNameCaviarOrderDisplayColumn").Value = BoxTotal.BoxName
                CaviarOrderDisplayDataGridView.Rows.Add() 'add an empty row to separate boxes
            Next

            'add the total counts disregarding boxes
            Dim CaviarOrderTotal As CaviarSummaryEntry = New CaviarSummaryEntry("Caviar Total", 0, 0, "Order Total", 0)
            Dim CaviarGradeSubTotal As CaviarSummaryEntry = New CaviarSummaryEntry("", 0, 0, "Order Total", 0)
            For Each Product As DataRow In SturgeonDBDataSet.Products
                'this adds the entries in the order of the product table
                If CaviarOrder.ContainsKey(Product.Item("PKProductID")) Then
                    Dim Entry As CaviarSummaryEntry = CaviarOrder(Product.Item("PKProductID"))
                    Dim GradeRow As DataRow = SturgeonDBDataSet.GradeSelection.FindByID(Product.Item("Grade"))
                    If Not GradeRow.Item("Grade") = CaviarGradeSubTotal.ProductCode Then
                        'display the grade subtotal if the we are no longer in the same grade
                        If CaviarGradeSubTotal.ProductCode <> "" Then
                            CaviarOrderDisplayDataGridView.Rows.Add()
                            CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = "Grade " & CaviarGradeSubTotal.ProductCode & " Subtotal"
                            CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.Count
                            CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.TotalKgs
                            CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("SubTotalCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.TotalPrice
                            CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("BoxNameCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.BoxName
                        End If
                        'reinitialize
                        CaviarGradeSubTotal = New CaviarSummaryEntry(GradeRow.Item("Grade"), 0, 0, "Order Total", 0)
                    End If

                    CaviarOrderDisplayDataGridView.Rows.Add()
                    'edit the last row added
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = Entry.ProductCode
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = Entry.Count
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("PriceSoldAtCaviarOrderDisplayColumn").Value = Entry.PricePerKg
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = Entry.TotalKgs
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("SubTotalCaviarOrderDisplayColumn").Value = Entry.TotalPrice
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("BoxNameCaviarOrderDisplayColumn").Value = Entry.BoxName

                    'add to subtotal is the entry is still in the same grade
                    CaviarGradeSubTotal.Count += Entry.Count
                    CaviarGradeSubTotal.TotalKgs += Entry.TotalKgs
                    CaviarGradeSubTotal.TotalPrice += Entry.TotalPrice
                    CaviarOrderTotal.Count += Entry.Count
                    CaviarOrderTotal.TotalKgs += Entry.TotalKgs
                    CaviarOrderTotal.TotalPrice += Entry.TotalPrice
                End If
            Next
            'display the total row and the last subtotal row (if it exists)
            Try
                If CaviarGradeSubTotal.ProductCode <> "" Then
                    CaviarOrderDisplayDataGridView.Rows.Add()
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = "Grade " & CaviarGradeSubTotal.ProductCode & " Subtotal"
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.Count
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.TotalKgs
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("SubTotalCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.TotalPrice
                    CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("BoxNameCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.BoxName
                End If
                CaviarOrderDisplayDataGridView.Rows.Add()
                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = CaviarOrderTotal.ProductCode
                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = CaviarOrderTotal.Count
                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = CaviarOrderTotal.TotalKgs
                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("SubTotalCaviarOrderDisplayColumn").Value = CaviarOrderTotal.TotalPrice
                CaviarOrderDisplayDataGridView.Rows(CaviarOrderDisplayDataGridView.Rows.Count - 1).Cells("BoxNameCaviarOrderDisplayColumn").Value = CaviarOrderTotal.BoxName

                CaviarSubtotal = CaviarOrderTotal.TotalPrice
                CaviarSubtotalTextBox.Text = FormatCurrency(CaviarSubtotal)
            Catch ex As Exception
                'catches when the form first loads (before columns has been added)
            End Try
        Else
            'hide the caviar portion of the form if the invoice is not a caviar invoice
            InvoicedItemsSplitContainer.Panel1Collapsed = True
            If Not isReadOnly Then
                EditFishInvoice.Visible = True
            End If
            NonInventoryProductBindingSource.Filter = FishNonInventoryProductsFilter ' AND [ProductCategory] <> 4" 'display all products except for caviar and no price
            'CaviarGroupBox.Visible = False
            'NonInventoryGroupBox.Location = New Point(NonInventoryGroupBox.Location.X, 2)
            'NonInventoryGroupBox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
            'NonInventoryGroupBox.Height = InvoiceGroupBox.Height
        End If

        'Update non-inventory costs subtotal
        Dim OthersSubtotal As Decimal = 0.0
        For Each Entry As DataGridViewRow In Non_Inventory_Invoice_RecordsDataGridView.Rows
            If Not IsNothing(Entry.Cells("NonInventoryPriceSoldAtColumn").Value) And Not IsDBNull(Entry.Cells("NonInventoryPriceSoldAtColumn").Value) Then
                OthersSubtotal = OthersSubtotal + FormatNumber(Entry.Cells("NonInventoryPriceSoldAtColumn").Value)
            End If
        Next
        OthersSubtotalTextBox.Text = FormatCurrency(OthersSubtotal)
        OthersCountTextBox.Text = Non_Inventory_Invoice_RecordsBindingSource.Count

        If UpdateTotal Then 'when non-inventory items are changed, update the total
            TotalTextBox.Text = Convert.ToDecimal(FormatCurrency(CaviarSubtotal + OthersSubtotal, , , TriState.False).ToString.Replace("$", ""))
        End If

        'update record total
        If Not TotalTextBox.Text = "" Then
            If Convert.ToDecimal(TotalTextBox.Text) = Convert.ToDecimal(FormatCurrency(CaviarSubtotal + OthersSubtotal, , , TriState.False).ToString.Replace("$", "")) Then
                TotalTextBox.BackColor = Color.Lime
                CalculatedTotalLabel.Visible = False
                CalculatedTotalTextBox.Visible = False
            Else
                TotalTextBox.BackColor = Color.Red
                CalculatedTotalTextBox.Text = FormatCurrency(CaviarSubtotal + OthersSubtotal)
                CalculatedTotalLabel.Visible = True
                CalculatedTotalTextBox.Visible = True
            End If
        End If
    End Sub

    Private Sub InvoicesBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoicesBindingSource.CurrentChanged
        On Error Resume Next 'for initialling form
        CalculateTotals()
        Caviar_InventoryDataGridView.Sort(OrderOnInvoice, System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub InvoicesBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles InvoicesBindingSource.PositionChanged
        On Error Resume Next 'for initialling form
        CalculateTotals()
        Caviar_InventoryDataGridView.Sort(OrderOnInvoice, System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    'Private Sub Caviar_InventoryDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Caviar_InventoryDataGridView.CellValueChanged
    '    CalculateTotals()
    'End Sub

    Private Sub Non_Inventory_Invoice_RecordsDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Non_Inventory_Invoice_RecordsDataGridView.CellValueChanged
        CalculateTotals(True)
    End Sub

    Private Sub TotalTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TotalTextBox.Validated
        CalculateTotals()
    End Sub


    Private Sub Non_Inventory_Invoice_RecordsDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles Non_Inventory_Invoice_RecordsDataGridView.UserDeletedRow
        CalculateTotals(True)
    End Sub

    Private Sub InvoicesDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles InvoicesDataGridView.UserDeletedRow
        CalculateTotals()
    End Sub

#End Region

#Region "Button Events"
    Private Sub InvoicesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoicesBindingNavigatorSaveItem.Click
        Save()
    End Sub

    Private Sub FilterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterButton.Click
        Save()
        myFilter.Show()
    End Sub

    Private Sub ExportExcelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportExcelButton.Click
        Try
            ExcelExport(InvoicesDataGridView)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Public Sub LoadReadOnly()
        isReadOnly = True
        With Me
            .InvoicesBindingNavigatorSaveItem.Enabled = False
            .InvoicesBindingNavigatorSaveItem.Visible = False
            .BindingNavigatorAddNewItem.Visible = False
            .EditCaviarInvoiceButton.Enabled = False
            .EditCaviarInvoiceButton.Visible = False

            .TotalTextBox.ReadOnly = True
            .InvoicesDataGridView.ReadOnly = True
            .Caviar_InventoryDataGridView.ReadOnly = True
            .Non_Inventory_Invoice_RecordsDataGridView.ReadOnly = True

            .Text = "View Invoices"
        End With
    End Sub
    Public Function Save() As Boolean
        Using (New WaitCursor) 'Load Hourglass
            Dim currentIndex As Integer
            currentIndex = InvoicesBindingSource.Position
            Try
                Me.Validate()
                Me.InvoicesBindingSource.EndEdit()
                Me.InvoicesTableAdapter.Update(Me.SturgeonDBDataSet.Invoices)
                Me.Non_Inventory_Invoice_RecordsBindingSource.EndEdit()
                Me.Non_Inventory_Invoice_RecordsTableAdapter.Update(Me.SturgeonDBDataSet._Non_Inventory_Invoice_Records)
                Me.Caviar_InventoryBindingSource.EndEdit()
                Me.Caviar_InventoryTableAdapter.Update(Me.SturgeonDBDataSet.Caviar_Inventory)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

            InvoicesBindingSource.Position = currentIndex
            Return True
        End Using
    End Function
    Private Sub InvoicesDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles InvoicesDataGridView.DataError
        If e.ColumnIndex = InvoicesDataGridView.Columns("FKBillingAddressIDColumn").Index Or InvoicesDataGridView.Columns("FKShippingAddressIDColumn").Index Then
            e.Cancel = True 'this lets the billing or shipping address have null values
        End If
    End Sub

    Private Sub GenerateAllInvoicesDisplayedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Using New WaitCursor
            ReportViewer.DisplayReport(ReportType.CaviarInvoiceReport, myFilter.CrystalReportSelectionFormula)
            ReportViewer.Show()
            ReportViewer.CrystalReportViewer.ShowLastPage()
            ReportViewer.CrystalReportViewer.ShowFirstPage()
        End Using
    End Sub


    Private Sub InvoicesDataGridView_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles InvoicesDataGridView.UserDeletingRow
        Select Case MsgBox("Deleting this invoice causes all inventoried items to move back to 'In Inventory' status. Continue?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                If Not Save() Then
                    Exit Sub
                End If

                Dim Rows() As DataRow = SturgeonDBDataSet.Caviar_Inventory.Select("FKInvoiceID=" & DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("PKInvoiceID"))
                For Each Row In Rows

                    Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(Row.Item("FKProductID"))
                    Dim ProductCategorySelectionRow As SturgeonDBDataSet.ProductCategorySelectionRow = ProductRow.ProductCategorySelectionRow
                    If ProductCategorySelectionRow.Sample Then
                        Row.Item("FKProductID") = IndexInDataRows(SturgeonDBDataSet.Products.Select(""), "Product Name", "PKProductID", GetProductNameFromSample(ProductRow.Product_Name))
                    End If

                    Row.Item("InventoryStatus") = 1
                    Row.Item("PriceSoldAt") = DBNull.Value
                    Row.Item("PackingBoxNumber") = DBNull.Value
                    Row.Item("FKInvoiceID") = DBNull.Value
                    Row.Item("OrderOnInvoice") = DBNull.Value
                Next

                Caviar_InventoryTableAdapter.Update(Rows)
                Me.Caviar_InventoryTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Inventory)

            Case MsgBoxResult.No
                e.Cancel = True
        End Select
    End Sub

    Private Sub EditCaviarInvoiceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCaviarInvoiceButton.Click
        If Not Save() Then
            Exit Sub
        End If
        Using (New WaitCursor) 'Load Hourglass
            Dim CaviarToTransfer As New List(Of Integer) 'list of barcodes to appear on the edit
            Dim HighestBoxNumber As Integer = 0
            Dim Rows() As DataRow = SturgeonDBDataSet.Caviar_Inventory.Select("FKInvoiceID=" & DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("PKInvoiceID"))
            For Each Row In Rows
                Row.Item("InventoryStatus") = 1
                Row.Item("PriceSoldAt") = DBNull.Value
                Row.Item("FKInvoiceID") = DBNull.Value
                If AlphaNumericValue.StringToValue(Row.Item("PackingBoxNumber")) > HighestBoxNumber Then
                    HighestBoxNumber = AlphaNumericValue.StringToValue(Row.Item("PackingBoxNumber"))
                End If
                CaviarToTransfer.Add(Row.Item("PKBarcode"))
            Next
            Caviar_InventoryTableAdapter.Update(Rows)
            Me.Caviar_InventoryTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Inventory)

            NewCaviarInvoice.Show()
            NewCaviarInvoice.isEditing = True
            NewCaviarInvoice.Text = "Edit Caviar Invoice"
            NewCaviarInvoice.LoadInvoice(DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("PKInvoiceID"))
            NewCaviarInvoice.InvoiceInformationCompleteButton_Click(Nothing, Nothing)
            NewCaviarInvoice.CaviarToInvoice.Clear()
            For Each Barcode As Integer In CaviarToTransfer
                NewCaviarInvoice.AddToInvoice(Barcode, True)
            Next
            For i = 0 To HighestBoxNumber - 1
                NewCaviarInvoice.NewBoxButton_Click(Nothing, Nothing)
            Next
            NewCaviarInvoice.CalculateTotals()
            isReadOnly = True 'exist without save prompt
            Me.Close()
        End Using
    End Sub

    Private Sub EditFishInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditFishInvoice.Click
        If Not Save() Then
            Exit Sub
        End If
        Using (New WaitCursor) 'Load Hourglass
            NewFishInvoice.Show()
            NewFishInvoice.isEditing = True
            NewFishInvoice.Text = "Edit Caviar Invoice"
            NewFishInvoice.LoadInvoice(DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("PKInvoiceID"))
            NewFishInvoice.InvoiceInformationCompleteButton_Click(Nothing, Nothing)
            isReadOnly = True 'exist without save prompt
            Me.Close()
        End Using
    End Sub

    Public Sub LoadInvoice(ByVal InvoiceNumber As Integer)
        Dim index = 0
        For Each InvoiceRow As DataRowView In InvoicesBindingSource.List
            If InvoiceRow("PKInvoiceID") = InvoiceNumber Then
                InvoicesBindingSource.Position = index
                Exit Sub
            End If
            index += 1
        Next
        MsgBox("The invoice cannot be found")
    End Sub

#Region "Expand datagridview combobox dropdown"
    Private Sub InvoicesDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles InvoicesDataGridView.EditingControlShowing
        Dim cmb As ComboBox = TryCast(e.Control, ComboBox)
        If cmb IsNot Nothing Then
            RemoveHandler cmb.DropDown, AddressOf cmb_DropDown
            AddHandler cmb.DropDown, AddressOf cmb_DropDown
        End If
    End Sub

    Private Sub cmb_DropDown(ByVal sender As Object, ByVal e As EventArgs)
        Dim cmb As ComboBox = TryCast(sender, ComboBox)
        If Not cmb Is Nothing Then
            Dim width As Integer = cmb.DropDownWidth
            Dim g As Graphics = cmb.CreateGraphics()
            Dim font As Font = cmb.Font
            Dim vertScrollBarWidth As Integer = If((cmb.Items.Count > cmb.MaxDropDownItems), SystemInformation.VerticalScrollBarWidth, 0)
            Dim newWidth As Integer
            For Each item As Object In cmb.Items
                ' instead of treating an item as a string, treat it as an object and use GetItemText to fetch the item's textvalue
                Dim s As String = cmb.GetItemText(item)
                newWidth = CInt(g.MeasureString(s, font).Width) + vertScrollBarWidth
                If width < newWidth Then
                    width = newWidth
                End If
            Next
            cmb.DropDownWidth = width
        Else
            MsgBox("Error")
        End If
    End Sub
#End Region

    Private Sub CurrentInvoiceItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentInvoiceItem.Click
        Using New WaitCursor
            Select Case DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("InvoiceType")
                Case 1 'caviar invoice
                    ReportViewer.DisplayReport(ReportType.CaviarInvoiceReport, "{Invoices.PKInvoiceID} = " & DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("PKInvoiceID"))
                Case 2 'other invoice
                    ReportViewer.DisplayReport(ReportType.OtherInvoiceReport, "{Invoices.PKInvoiceID} = " & DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("PKInvoiceID"))
            End Select
            ReportViewer.Show()
            ReportViewer.CrystalReportViewer.ShowLastPage()
            ReportViewer.CrystalReportViewer.ShowFirstPage()
        End Using
    End Sub

    Private Sub GenerateCurrentPackingSlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateCurrentPackingSlipToolStripMenuItem.Click
        Select Case DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("InvoiceType")
            Case 1 'caviar invoice
                ReportViewer.DisplayReport(ReportType.CaviarPackingReport, "{Invoices.PKInvoiceID} = " & DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("PKInvoiceID"))
            Case 2 'other invoice
                ReportViewer.DisplayReport(ReportType.OtherPackingReport, "{Invoices.PKInvoiceID} = " & DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("PKInvoiceID"))
        End Select
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer.ShowLastPage()
        ReportViewer.CrystalReportViewer.ShowFirstPage()
    End Sub

End Class