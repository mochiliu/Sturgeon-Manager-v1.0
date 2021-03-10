
'This form allows the user to create new caviar invoices in addition to modifying them via the edit invoices menu choice
Public Class NewCaviarInvoice

    Public CaviarToInvoice As New List(Of Integer) 'stores all the barcodes to be invoiced
    Public isLoading As Boolean = True
    Public isEditing As Boolean = False
    Public isComplete As Boolean = False
    Public isSaved As Boolean = False
    Public ItemCount As Integer = 0
    Public myCursor As WaitCursor
    Public CaviarNonInventoryProductsFilter As String = ""

    Private Sub NewCaviarInvoice_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myCursor.Dispose()
    End Sub
    'Public CaviarOrderSummary As String = ""

    Private Sub NewCaviarInvoice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isEditing Then
            Select Case MsgBox("Closing the window without saving results in the invoice being left in an incomplete state. All previously invoiced items will be returned to the inventory. Complete the invoice?", MsgBoxStyle.OkCancel)
                Case MsgBoxResult.Ok
                    isEditing = False
                    CompleteInvoiceButton_Click(Nothing, Nothing)
                Case MsgBoxResult.Cancel
                    e.Cancel = True
            End Select
        Else
            If (e.CloseReason = CloseReason.UserClosing Or e.CloseReason = CloseReason.FormOwnerClosing) And Not isComplete Then
                If Not isSaved Then
                    'user has not saved by viewing invoice
                    If MsgBox("You are about to delete all the data you entered on this invoice.  Continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        e.Cancel = True
                    End If
                Else
                    MsgBox("The invoice has been saved already. Please complete the invoice and delete it in edit invoice.", MsgBoxStyle.Information)
                    e.Cancel = True
                End If
            End If
        End If
        If e.Cancel = False Then
            myCursor = New WaitCursor
        End If
    End Sub

    Private Sub NewInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.InvoiceTypeSelection' table. You can move, or remove it, as needed.
        Me.InvoiceTypeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.InvoiceTypeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.ProductCategorySelection' table. You can move, or remove it, as needed.
        Me.ProductCategorySelectionTableAdapter.Fill(Me.SturgeonDBDataSet.ProductCategorySelection)
        Me.Customer_PricingTableAdapter.Fill(Me.SturgeonDBDataSet.Customer_Pricing)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarStatusSelection' table. You can move, or remove it, as needed.
        Me.CaviarStatusSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarStatusSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Fish' table. You can move, or remove it, as needed.
        Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.GradeSelection' table. You can move, or remove it, as needed.
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Inventory' table. You can move, or remove it, as needed.
        Me.Caviar_InventoryTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Inventory)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet._Non_Inventory_Invoice_Records' table. You can move, or remove it, as needed.
        Me.Non_Inventory_Invoice_RecordsTableAdapter.Fill(Me.SturgeonDBDataSet._Non_Inventory_Invoice_Records)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Invoices' table. You can move, or remove it, as needed.
        Me.InvoicesTableAdapter.Fill(Me.SturgeonDBDataSet.Invoices)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.SturgeonDBDataSet.Customers)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Shipping_Addresses' table. You can move, or remove it, as needed.
        Me.Shipping_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Shipping_Addresses)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Billing_Addresses' table. You can move, or remove it, as needed.
        Me.Billing_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Billing_Addresses)

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
        NonInventoryProductBindingSource.Filter = CaviarNonInventoryProductsFilter 'display all products except for fish and caviar


        RefreshCaviarDGV()
        Caviar_InventoryDataGridView.Sort(OrderOnInvoice, System.ComponentModel.ListSortDirection.Descending)
        InvoicesBindingSource.ResetBindings(False) 'required for not screwing up the first invoice
        NewBoxButton_Click(Nothing, Nothing) 'add default box A
        isLoading = False
    End Sub


    Private Sub BarcodeTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BarcodeTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then 'enter key is pressed
            If IsNumeric(BarcodeTextBox.Text) Then 'new barcode is scanned
                AddToInvoice(Convert.ToInt32(BarcodeTextBox.Text))
                BarcodeTextBox.Text = ""
            End If
        End If
    End Sub

#Region "Sample Handling"
    Private Sub Caviar_InventoryDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Caviar_InventoryDataGridView.CellValueChanged
        If isLoading Then
            Exit Sub
        End If

        If Caviar_InventoryDataGridView.Columns(e.ColumnIndex).Name = "SampleColumn" Then
            'sample checkbox is checked
            Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(Caviar_InventoryDataGridView.Rows(e.RowIndex).Cells("FKProductID").Value)
            Dim ProductCategorySelectionRow As SturgeonDBDataSet.ProductCategorySelectionRow = ProductRow.ProductCategorySelectionRow

            If Caviar_InventoryDataGridView.Rows(e.RowIndex).Cells("SampleColumn").Value = True Then
                'the item is a sample
                If Not ProductCategorySelectionRow.Sample Then
                    'make the product into a sample
                    Dim SampleProductID As Integer = IndexInDataRows(SturgeonDBDataSet.Products.Select(""), "Product Name", "PKProductID", GetSampleProductName(ProductRow.Product_Name))
                    If SampleProductID <> -1 Then
                        'sample product code is found
                        Dim SampleProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(SampleProductID)
                        Dim SampleProductCategorySelectionRow As SturgeonDBDataSet.ProductCategorySelectionRow = SampleProductRow.ProductCategorySelectionRow
                        If Not SampleProductCategorySelectionRow.Sample Then
                            'the category does not match
                            GoTo NoSampleCode
                        End If
                    Else
NoSampleCode:
                        isLoading = True
                        Caviar_InventoryDataGridView.Rows(e.RowIndex).Cells("SampleColumn").Value = False
                        isLoading = False
                        SpeakText("sample product code not found")
                        MsgBox("There no sample product code for this product")
                        Exit Sub
                    End If
                    Caviar_InventoryDataGridView.Rows(e.RowIndex).Cells("FKProductID").Value = IndexInDataRows(SturgeonDBDataSet.Products.Select(""), "Product Name", "PKProductID", GetSampleProductName(ProductRow.Product_Name))
                    Caviar_InventoryDataGridView.Rows(e.RowIndex).Cells("PriceSoldAt").Value = 0
                    CalculateTotals()
                End If
            Else
                'the item is not a sample
                If ProductCategorySelectionRow.Sample Then
                    'make the product into a sample
                    Dim CaviarProductID As Integer = IndexInDataRows(SturgeonDBDataSet.Products.Select(""), "Product Name", "PKProductID", GetProductNameFromSample(ProductRow.Product_Name))
                    Dim CaviarProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(CaviarProductID)
                    Dim CustomerPricingRow As SturgeonDBDataSet.Customer_PricingRow = SturgeonDBDataSet.Customer_Pricing.FindByFKCustomerIDFKProductID(FKCustomerIDComboBox.SelectedValue, CaviarProductRow.PKProductID)
                    If IsNothing(CustomerPricingRow) Then
                        isLoading = True
                        Caviar_InventoryDataGridView.Rows(e.RowIndex).Cells("SampleColumn").Value = True
                        isLoading = False
                        SpeakText("pricing not found")
                        MsgBox("There no pricing for this product")
                        Exit Sub
                    Else
                        Caviar_InventoryDataGridView.Rows(e.RowIndex).Cells("FKProductID").Value = CaviarProductID
                        Caviar_InventoryDataGridView.Rows(e.RowIndex).Cells("PriceSoldAt").Value = CustomerPricingRow.Price
                        CalculateTotals()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Caviar_InventoryDataGridView_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Caviar_InventoryDataGridView.CurrentCellDirtyStateChanged
        'required to push the value of the sample checkbox as soon as it is clicked
        If Caviar_InventoryDataGridView.IsCurrentCellDirty Then
            Caviar_InventoryDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Public Sub RefreshSamples()
        isLoading = True
        For Each row As DataGridViewRow In Caviar_InventoryDataGridView.Rows
            Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(row.Cells("FKProductID").Value)
            Dim ProductCategorySelectionRow As SturgeonDBDataSet.ProductCategorySelectionRow = ProductRow.ProductCategorySelectionRow
            If ProductCategorySelectionRow.Sample Then
                row.Cells("SampleColumn").Value = True
            Else
                row.Cells("SampleColumn").Value = False
            End If
        Next
        isLoading = False
    End Sub


    Private Sub Caviar_InventoryDataGridView_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Caviar_InventoryDataGridView.DataBindingComplete
        RefreshSamples()
    End Sub
#End Region

    Private Sub Caviar_InventoryDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Caviar_InventoryDataGridView.KeyDown
        If e.KeyCode = Keys.Delete Then
            For Each SelectedRow As DataGridViewRow In Caviar_InventoryDataGridView.SelectedRows
                DeleteFromInvoice(SelectedRow.Cells("PKBarcode").Value) 'delete the barcode from being invoiced
            Next
        End If
    End Sub

    Private Sub Non_Inventory_Invoice_RecordsDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Non_Inventory_Invoice_RecordsDataGridView.CellValueChanged
        If isLoading Then
            Exit Sub
        End If
        Select Case e.ColumnIndex
            Case Non_Inventory_Invoice_RecordsDataGridView.Columns("FKProductIDNonInventory").Index
                'a product selection has changed, update to customer's price

                'get the appropriate data
                Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Dim CustomerPricingRow As SturgeonDBDataSet.Customer_PricingRow = SturgeonDBDataSet.Customer_Pricing.FindByFKCustomerIDFKProductID(FKCustomerIDComboBox.SelectedValue, ProductRow.PKProductID)
                Dim ProductCategoryRow As SturgeonDBDataSet.ProductCategorySelectionRow = SturgeonDBDataSet.ProductCategorySelection.FindByProductCategoryID(ProductRow.ProductCategory)
                If Not IsNothing(ProductCategoryRow) AndAlso Not IsDBNull(ProductCategoryRow) AndAlso ProductCategoryRow.PricedAt0 Then
                    'the item is priced at 0
                    isLoading = True
                    'reset the quantity and price for a item without price of 0
                    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityNonInventory").Value = 1
                    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("PriceSoldAtNonInventory").Value = 0
                    isLoading = False
                ElseIf Not IsNothing(ProductCategoryRow) AndAlso Not IsDBNull(ProductCategoryRow) AndAlso Not ProductCategoryRow.PricedByCustomer Then
                    'no pricing needed
                    isLoading = True
                    'reset the quantity and price for a item without a price in the pricing table
                    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityNonInventory").Value = DBNull.Value
                    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("PriceSoldAtNonInventory").Value = DBNull.Value
                    isLoading = False
                ElseIf IsNothing(CustomerPricingRow) Then
                    'no pricing found
                    Dim response = MsgBox("The customer has no set pricing for this product. Add the product to order anyway? Entry will be deleted otherwise.", MsgBoxStyle.YesNo)
                    If response = vbNo Then
                        'delete the row
                        Non_Inventory_Invoice_RecordsBindingSource.RemoveCurrent()
                    Else
                        isLoading = True
                        Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityNonInventory").Value = DBNull.Value
                        Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("PriceSoldAtNonInventory").Value = DBNull.Value
                        isLoading = False
                    End If
                Else
                    'princing found
                    If Not IsDBNull(Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityNonInventory").Value) Then
                        'there is a quantity entered, calculate the total price
                    Else
                        'no quantity entered, default to 1
                        Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityNonInventory").Value = 1
                    End If
                    'calculate the price
                    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("PriceSoldAtNonInventory").Value = Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityNonInventory").Value * CustomerPricingRow.Price
                End If

            Case Non_Inventory_Invoice_RecordsDataGridView.Columns("QuantityNonInventory").Index
                'a quantity has changed, update to customer's price
                'get the appropriate data
                If Not IsDBNull(Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("FKProductIDNonInventory").Value) And Not IsNothing(Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("FKProductIDNonInventory").Value) And Not IsDBNull(Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityNonInventory").Value) Then
                    Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("FKProductIDNonInventory").Value)
                    If Not IsNothing(ProductRow) Then
                        Dim CustomerPricingRow As SturgeonDBDataSet.Customer_PricingRow = SturgeonDBDataSet.Customer_Pricing.FindByFKCustomerIDFKProductID(FKCustomerIDComboBox.SelectedValue, ProductRow.PKProductID)
                        If Not IsNothing(CustomerPricingRow) Then
                            'calculate the price as pricing is found
                            Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("PriceSoldAtNonInventory").Value = Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityNonInventory").Value * CustomerPricingRow.Price
                        End If
                    End If
                End If

        End Select
        CalculateTotals()
    End Sub

    'this function adds a barcode to the order
    Public Sub AddToInvoice(ByVal Barcode As Integer, Optional ByVal EditingInvoice As Boolean = False)
        'check for duplicate value
        For Each Value In CaviarToInvoice
            If Value = Barcode Then
                SpeakText("Barcode is already selected")
                MsgBox("Barcode is already selected")
                Exit Sub
            End If
        Next
        If Not IsNothing(SturgeonDBDataSet.Caviar_Inventory.FindByPKBarcode(Barcode)) Then
            'Get data related to the barcode
            Dim ContainerRow As SturgeonDBDataSet.Caviar_InventoryRow = SturgeonDBDataSet.Caviar_Inventory.FindByPKBarcode(Barcode)
            Dim ProductRow As SturgeonDBDataSet.ProductsRow = ContainerRow.ProductsRow
            'Dim GradeRow As SturgeonDBDataSet.GradeSelectionRow = ProductRow.GradeSelectionRow
            'Dim CaviarFishRow As SturgeonDBDataSet.Caviar_FishRow = ContainerRow.Caviar_FishRow
            'Dim CustomerRow As SturgeonDBDataSet.CustomersRow = SturgeonDBDataSet.Customers.FindByPKCustomerID(FKCustomerIDComboBox.SelectedIndex)
            Dim ProductCategorySelectionRow As SturgeonDBDataSet.ProductCategorySelectionRow = ProductRow.ProductCategorySelectionRow
            Dim CustomerPricingRow As SturgeonDBDataSet.Customer_PricingRow = SturgeonDBDataSet.Customer_Pricing.FindByFKCustomerIDFKProductID(FKCustomerIDComboBox.SelectedValue, ProductRow.PKProductID)
            If Not ProductCategorySelectionRow.Sample And IsNothing(CustomerPricingRow) Then
                SpeakText("Product pricing not found")
                MsgBox("Customer does not have a valid price assigned for this product. The item cannot be added.")
                Exit Sub
            Else
                CaviarToInvoice.Add(Barcode)
                RefreshCaviarDGV()
                For Each Entry As DataGridViewRow In Caviar_InventoryDataGridView.Rows
                    If Entry.Cells("PKBarcode").Value = Barcode Then 'the entry is found
                        Dim CaviarStatusRow As SturgeonDBDataSet.CaviarStatusSelectionRow = SturgeonDBDataSet.CaviarStatusSelection.FindByPKStatusID(Entry.Cells("InventoryStatus").Value)
                        Select Case Entry.Cells("InventoryStatus").Value
                            Case 1
                                Exit Select 'continue if the status is in inventory
                            Case 6 'allow add if the item is missing
                                SpeakText("The item is not in inventory and the status is " & CaviarStatusRow.Description)
                                If MsgBox("The item is not in inventory and the status is " & CaviarStatusRow.Description & ". Continue?", MsgBoxStyle.YesNo) = vbNo Then
                                    'remove it from the list and quit this sub
                                    CaviarToInvoice.Remove(Barcode)
                                    RefreshCaviarDGV()
                                    CalculateTotals()
                                    Exit Sub
                                End If
                            Case Else 'all other statuses besides in inventory and missing cannot be added
                                SpeakText("The item is not in inventory and the status is " & CaviarStatusRow.Description)
                                MsgBox("The item is not in inventory and the status is " & CaviarStatusRow.Description & ". It cannot be added to this order.")
                                CaviarToInvoice.Remove(Barcode)
                                RefreshCaviarDGV()
                                CalculateTotals()
                                Exit Sub
                        End Select
                        If Not Entry.Cells("InventoryStatus").Value = 1 Then
                            'the item is not in inventory

                        End If

                        If Not EditingInvoice Then
                            'assign the entry with a box number if entered from the form
                            Entry.Cells("PackingBoxNumber").Value = DirectCast(BoxNameComboBox.SelectedItem, AlphaNumericValue).ToString
                            SpeakProductCode(ProductRow.Product_Name) 'speak the product code only if it is entered in new caviar invoice
                        End If
                        'assign the entry with the proper price
                        If ProductCategorySelectionRow.Sample Then
                            Entry.Cells("PriceSoldAt").Value = 0
                        Else
                            Entry.Cells("PriceSoldAt").Value = CustomerPricingRow.Price
                        End If
                        'assign the proper invoice number
                        Entry.Cells("FKInvoiceID").Value = Convert.ToInt32(PKInvoiceIDTextBox.Text)
                        Entry.Cells("OrderOnInvoice").Value = ItemCount
                        ItemCount += 1
                        Caviar_InventoryBindingSource.EndEdit()
                        Exit For
                    End If
                Next
                If Not EditingInvoice Then CalculateTotals()
                Caviar_InventoryDataGridView.FirstDisplayedScrollingRowIndex = 0     'scroll the dgv to the top after a new item is added
            End If
        Else
            SpeakText("Barcode does not exist")
            MsgBox("Barcode does not exist")
        End If

    End Sub


    'this sub removes an caviar tin from the invoice
    Public Sub DeleteFromInvoice(ByVal Barcode As Integer)

        'remove the information entered when the container is added
        For Each Entry As DataGridViewRow In Caviar_InventoryDataGridView.Rows
            If Entry.Cells("PKBarcode").Value = Barcode Then
                'chage the product code back from sample if necessary
                Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(Entry.Cells("FKProductID").Value)
                Dim ProductCategorySelectionRow As SturgeonDBDataSet.ProductCategorySelectionRow = ProductRow.ProductCategorySelectionRow
                If ProductCategorySelectionRow.Sample Then
                    Entry.Cells("FKProductID").Value = IndexInDataRows(SturgeonDBDataSet.Products.Select(""), "Product Name", "PKProductID", GetProductNameFromSample(ProductRow.Product_Name))
                End If

                'delete the price for entry
                Entry.Cells("PriceSoldAt").Value = DBNull.Value
                'delete the box number for entry
                Entry.Cells("PackingBoxNumber").Value = DBNull.Value
                'delete the invoice order
                Entry.Cells("OrderOnInvoice").Value = DBNull.Value
                'delete the invoice number
                Entry.Cells("FKInvoiceID").Value = DBNull.Value
                'update the bindingsource
                Caviar_InventoryBindingSource.EndEdit()
                Exit For
            End If
        Next

        CaviarToInvoice.Remove(Barcode)
        RefreshCaviarDGV()

        CalculateTotals()
    End Sub

    'this selects only the caviar to be invoiced for display
    Public Sub RefreshCaviarDGV()
        'Display only the selected items
        Dim FilterString As String = "PKBarcode = -1" 'display nothing to begin
        For Each Value As Integer In CaviarToInvoice
            FilterString = FilterString & " OR PKBarcode = " & Value.ToString
        Next
        Caviar_InventoryBindingSource.Filter = FilterString

    End Sub

    Public Sub CalculateTotals()
        'Update the caviar subtotal
        Dim CaviarSubtotal As Decimal = 0.0
        Dim CaviarBoxOrder As New Dictionary(Of ProductBoxPair, CaviarSummaryEntry) 'caviar order is a dictionary of (productID,Box Name) key and CaviarOrderSummaryEntry value
        Dim CaviarOrder As New Dictionary(Of Integer, CaviarSummaryEntry)
        Dim SetOfBoxes As New List(Of String) 'this is a list of all the shipping boxes

        For Each Entry As DataGridViewRow In Caviar_InventoryDataGridView.Rows
            If Not IsNothing(Entry.Cells("PriceSoldAt").Value) AndAlso Not IsDBNull(Entry.Cells("PriceSoldAt").Value) AndAlso Not IsNothing(Entry.Cells("PackingBoxNumber").Value) AndAlso Not IsDBNull(Entry.Cells("PackingBoxNumber").Value) Then
                Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(Entry.Cells("FKProductID").Value)
                Dim currentKey As ProductBoxPair
                currentKey.ProductID = ProductRow.PKProductID
                currentKey.BoxName = Entry.Cells("PackingBoxNumber").Value

                'keep track of all items
                If CaviarOrder.ContainsKey(ProductRow.PKProductID) Then
                    'product entry already exists, add a count
                    CaviarOrder(ProductRow.PKProductID).Add()
                Else
                    'product entry does not exist, add an entry
                    CaviarOrder.Add(ProductRow.PKProductID, New CaviarSummaryEntry(ProductRow.Product_Name, ProductRow.UnitWeightgms, Entry.Cells("PriceSoldAt").Value, "Order Total"))
                End If

                'keep track of items in terms of boxes
                If CaviarBoxOrder.ContainsKey(currentKey) Then
                    'product, box entry already exists, add a count
                    CaviarBoxOrder(currentKey).Add()
                Else
                    'product, box entry does not exist, add an entry
                    CaviarBoxOrder.Add(currentKey, New CaviarSummaryEntry(ProductRow.Product_Name, ProductRow.UnitWeightgms, Entry.Cells("PriceSoldAt").Value, Entry.Cells("PackingBoxNumber").Value))
                End If

                Entry.Cells("PricePerItem").Value = Entry.Cells("PriceSoldAt").Value * ProductRow.UnitWeightgms / 1000
                CaviarSubtotal = CaviarSubtotal + FormatNumber(Entry.Cells("PricePerItem").Value)

                'keep track of a list of packing boxes
                If Not SetOfBoxes.Contains(Entry.Cells("PackingBoxNumber").Value) Then
                    SetOfBoxes.Add(Entry.Cells("PackingBoxNumber").Value)
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

        'Update non-inventory costs subtotal
        Dim OthersSubtotal As Decimal = 0.0
        For Each Entry As DataGridViewRow In Non_Inventory_Invoice_RecordsDataGridView.Rows
            If Not IsNothing(Entry.Cells("PriceSoldAtNonInventory").Value) And Not IsDBNull(Entry.Cells("PriceSoldAtNonInventory").Value) Then
                OthersSubtotal = OthersSubtotal + FormatNumber(Entry.Cells("PriceSoldAtNonInventory").Value)
            End If
        Next
        OthersSubtotalTextBox.Text = FormatCurrency(OthersSubtotal)

        TotalTextBox.Text = FormatCurrency(CaviarSubtotal + OthersSubtotal)
        BoxesTextBox.Text = SetOfBoxes.Count
    End Sub

    Private Sub Non_Inventory_Invoice_RecordsBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Non_Inventory_Invoice_RecordsBindingSource.CurrentItemChanged
        CalculateTotals()
    End Sub

    Private Sub InvoicesBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles InvoicesBindingSource.AddingNew
        Dim DefaultInvoice As DataRowView = DirectCast(InvoicesBindingSource.List, DataView).AddNew()
        DefaultInvoice.Row.Item("PKInvoiceID") = GetInvoiceNumber()
        DefaultInvoice.Row.Item("Date") = Date.Now
        e.NewObject = DefaultInvoice
        InvoicesBindingSource.Position = InvoicesBindingSource.Count - 1
        InvoicesBindingSource.ResetBindings(False) 'refresh the controls
    End Sub

    Public Function GetInvoiceNumber() As Integer
        Dim LargestInvoiceNumber As Integer = 0
        Dim I As Integer = 0
        For I = 0 To SturgeonDBDataSet.Invoices.Count - 1
            If SturgeonDBDataSet.Invoices.Rows(I).Item("PKInvoiceID") > LargestInvoiceNumber Then
                LargestInvoiceNumber = SturgeonDBDataSet.Invoices.Rows(I).Item("PKInvoiceID")
            End If
        Next
        Return LargestInvoiceNumber + 1
    End Function

    Private Sub InvoicesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoicesBindingNavigatorSaveItem.Click
        Save()
    End Sub

#Region "Step Navigation"
    Public Sub InvoiceInformationCompleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceInformationCompleteButton.Click
        'check if values are valid
        isLoading = True
        Try
            Me.Validate()
            InvoicesBindingSource.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        If FKCustomerIDComboBox.SelectedIndex < 0 Then
            MsgBox("Please Enter A Customer")
            Exit Sub
        End If
        If FKBillingAddressIDComboBox.SelectedIndex < 0 Then
            MsgBox("Please Enter A Billing Address")
            Exit Sub
        End If
        If FKShippingAddressIDComboBox.SelectedIndex < 0 Then
            MsgBox("Please Enter A Shipping Address")
            Exit Sub
        End If

        'disable changing the invoice properties
        PKInvoiceIDTextBox.Enabled = False
        FKCustomerIDComboBox.Enabled = False
        DateMyDateTimePicker.Enabled = False
        PO_NumberTextBox.Enabled = False
        BoxesTextBox.Enabled = False
        FKBillingAddressIDComboBox.Enabled = False
        FKShippingAddressIDComboBox.Enabled = False
        Shipping_NotesTextBox.Enabled = False
        InvoiceInformationCompleteButton.Enabled = False
        AddCustomerButton.Enabled = False
        AddBillingAddressButton.Enabled = False
        AddShippingAddressButton.Enabled = False

        'enable adding controls in step 2
        BarcodeTextBox.Enabled = True
        BoxNameComboBox.Enabled = True
        NewBoxButton.Enabled = True
        Caviar_InventoryDataGridView.Enabled = True
        CaviarInformationCompleteButton.Enabled = True

        BarcodeTextBox.Focus()
        isLoading = False
    End Sub

    Private Sub CaviarInformationCompleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaviarInformationCompleteButton.Click
        'disable controls in step 2
        BarcodeTextBox.Enabled = False
        BoxNameComboBox.Enabled = False
        NewBoxButton.Enabled = False
        Caviar_InventoryDataGridView.Enabled = False
        CaviarInformationCompleteButton.Enabled = False

        'enable controls in step 3
        Non_Inventory_Invoice_RecordsDataGridView.Enabled = True
        CompleteInvoiceButton.Enabled = True
        BackToCaviarButton.Enabled = True
        SavePreviewButton.Enabled = True
    End Sub

    Private Sub BackToCaviarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToCaviarButton.Click
        'enable controls in step 2
        BarcodeTextBox.Enabled = True
        BoxNameComboBox.Enabled = True
        NewBoxButton.Enabled = True
        Caviar_InventoryDataGridView.Enabled = True
        CaviarInformationCompleteButton.Enabled = True

        'disable controls in step 3
        Non_Inventory_Invoice_RecordsDataGridView.Enabled = False
        CompleteInvoiceButton.Enabled = False
        BackToCaviarButton.Enabled = False
        SavePreviewButton.Enabled = False

        BarcodeTextBox.Focus()
    End Sub

    Private Sub CompleteInvoiceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteInvoiceButton.Click
        Using (New WaitCursor) 'Load Hourglass
            isLoading = True
            If Save() Then
                If isEditing Then
                    Invoice.Show()
                    Invoice.LoadInvoice(Convert.ToInt32(PKInvoiceIDTextBox.Text))
                    isEditing = False
                    isComplete = True
                    Me.Close()
                Else
                    isComplete = True
                    Me.Close()
                    If MsgBox("Another Invoice?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Main.ShowNewCaviarInvoice()
                    End If
                End If
            End If
            isLoading = False
        End Using
    End Sub
#End Region

    Public Function Save() As Boolean

        Dim currentIndex As Integer
        currentIndex = InvoicesBindingSource.Position
        Me.Caviar_InventoryBindingSource.EndEdit()

        Try
            Me.Validate()
            Me.InvoicesBindingSource.EndEdit()
            Me.InvoicesTableAdapter.Update(Me.SturgeonDBDataSet.Invoices)
            Me.Non_Inventory_Invoice_RecordsBindingSource.EndEdit()
            Me.Non_Inventory_Invoice_RecordsTableAdapter.Update(Me.SturgeonDBDataSet._Non_Inventory_Invoice_Records)
            Me.Caviar_InventoryBindingSource.EndEdit()
            Me.Caviar_InventoryTableAdapter.Update(Me.SturgeonDBDataSet.Caviar_Inventory)

            'find all caviar entries from this invoice and change their status to sold and store the previous status
            Dim Rows() As DataRow = SturgeonDBDataSet.Caviar_Inventory.Select("FKInvoiceID=" & DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("PKInvoiceID"))
            For Each Row In Rows
                'also save the previous status along with the time of the invoice
                Row.Item("DateStatusChanged") = DateMyDateTimePicker.Value
                Row.Item("PreviousStatus") = Row.Item("InventoryStatus")
                Row.Item("InventoryStatus") = 2 'mark the item as sold
            Next
            Caviar_InventoryTableAdapter.Update(Rows)
            isSaved = True
            'Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet) 'Does not work
            Me.Non_Inventory_Invoice_RecordsTableAdapter.Fill(Me.SturgeonDBDataSet._Non_Inventory_Invoice_Records)
            Me.InvoicesTableAdapter.Fill(Me.SturgeonDBDataSet.Invoices)
            InvoicesBindingSource.Position = currentIndex
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try


    End Function

    Private Sub Non_Inventory_Invoice_RecordsBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Non_Inventory_Invoice_RecordsBindingSource.AddingNew
        Dim DefaultEntry As DataRowView = DirectCast(Non_Inventory_Invoice_RecordsBindingSource.List, DataView).AddNew()
        Try
            DefaultEntry.Row.Item("FKProductID") = DirectCast(NonInventoryProductBindingSource.List.Item(0), DataRowView).Item("PKProductID")
            Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(DefaultEntry.Row.Item("FKProductID"))
            If Not IsNothing(ProductRow) Then
                Dim CustomerPricingRow As SturgeonDBDataSet.Customer_PricingRow = SturgeonDBDataSet.Customer_Pricing.FindByFKCustomerIDFKProductID(FKCustomerIDComboBox.SelectedValue, ProductRow.PKProductID)
                If Not IsNothing(CustomerPricingRow) Then
                    'display the price for 1 item if pricing is found
                    DefaultEntry.Row.Item("Quantity") = 1
                    DefaultEntry.Row.Item("PriceSoldAt") = DefaultEntry.Row.Item("Quantity") * CustomerPricingRow.Price
                End If
            End If

            e.NewObject = DefaultEntry
            Non_Inventory_Invoice_RecordsBindingSource.ResetBindings(False) 'refresh the controls
            Non_Inventory_Invoice_RecordsBindingSource.Position = Non_Inventory_Invoice_RecordsBindingSource.Count - 1
            Non_Inventory_Invoice_RecordsBindingSource.EndEdit() 'required to put the row into the binding source
            CalculateTotals()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadInvoice(ByVal InvoiceNumber As Integer)
        Dim index = 0
        For Each InvoiceRow As DataRowView In InvoicesBindingSource.List
            If InvoiceRow("PKInvoiceID") = InvoiceNumber Then
                InvoicesBindingSource.Position = index
                InvoicesBindingSource.ResetBindings(False)
                CustomersBillingAddressesBindingSource.ResetBindings(False)
                CustomersShippingAddressesBindingSource.ResetBindings(False)
                Exit Sub
            End If
            index += 1
        Next
        MsgBox("The invoice cannot be found")
    End Sub


#Region "Add Buttons"
    Private Sub AddCustomerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomerButton.Click
        Dim newCustomerForm As New Customer With {.ShowDialogOption = Customer.ShowDialogOptions.AddNewCustomer}
        Try
            newCustomerForm.ShowDialog()
        Finally
            Me.CustomersTableAdapter.Fill(Me.SturgeonDBDataSet.Customers)
            Me.Shipping_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Shipping_Addresses)
            Me.Billing_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Billing_Addresses)
            Me.Customer_PricingTableAdapter.Fill(Me.SturgeonDBDataSet.Customer_Pricing)

            'find the customer last saved
            Dim index = 0
            For Each CustomerRow As DataRowView In CustomersBindingSource.List
                If CustomerRow("PKCustomerID") = newCustomerForm.DefaultRecordID Then
                    CustomersBindingSource.Position = index
                End If
                index += 1
            Next

            newCustomerForm.Dispose()
        End Try
    End Sub

    Private Sub AddBillingAddressButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBillingAddressButton.Click
        Dim newCustomerForm As New Customer
        With newCustomerForm
            .ShowDialogOption = Customer.ShowDialogOptions.AddNewBillingAddress
            .DefaultRecordID = FKCustomerIDComboBox.SelectedValue
        End With
        Try
            newCustomerForm.ShowDialog()
        Finally
            Me.CustomersTableAdapter.Fill(Me.SturgeonDBDataSet.Customers)
            Me.Shipping_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Shipping_Addresses)
            Me.Billing_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Billing_Addresses)

            'find the customer last saved
            Dim index = 0
            For Each CustomerRow As DataRowView In CustomersBindingSource.List
                If CustomerRow("PKCustomerID") = newCustomerForm.DefaultRecordID Then
                    CustomersBindingSource.Position = index
                End If
                index += 1
            Next

            newCustomerForm.Dispose()
        End Try
    End Sub

    Private Sub AddShippingAddressButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddShippingAddressButton.Click
        Dim newCustomerForm As New Customer
        With newCustomerForm
            .ShowDialogOption = Customer.ShowDialogOptions.AddNewShippingAddress
            .DefaultRecordID = FKCustomerIDComboBox.SelectedValue
        End With
        Try
            newCustomerForm.ShowDialog()
        Finally
            Me.CustomersTableAdapter.Fill(Me.SturgeonDBDataSet.Customers)
            Me.Shipping_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Shipping_Addresses)
            Me.Billing_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Billing_Addresses)

            'find the customer last saved
            Dim index = 0
            For Each CustomerRow As DataRowView In CustomersBindingSource.List
                If CustomerRow("PKCustomerID") = newCustomerForm.DefaultRecordID Then
                    CustomersBindingSource.Position = index
                End If
                index += 1
            Next

            newCustomerForm.Dispose()
        End Try
    End Sub
#End Region

    Private Sub SavePreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavePreviewButton.Click
        Using New WaitCursor
            isLoading = True
            If Save() Then
                ReportViewer.DisplayReport(ReportType.CaviarInvoiceReport, "{Invoices.PKInvoiceID} = " & DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("PKInvoiceID"))
                ReportViewer.Show()
                ReportViewer.CrystalReportViewer.ShowLastPage()
                ReportViewer.CrystalReportViewer.ShowFirstPage()
            End If
            isLoading = False
        End Using

    End Sub

    'add a new box to the boxes list
    Public Sub NewBoxButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBoxButton.Click
        'find the largest box number and add the next one
        Dim largestValue As Integer = -1
        For Each Box As AlphaNumericValue In BoxNameComboBox.Items
            If Box.Value > largestValue Then
                largestValue = Box.Value
            End If
        Next
        Dim newBox As AlphaNumericValue = New AlphaNumericValue(largestValue + 1)
        BoxNameComboBox.Items.Add(newBox)
        BoxNameComboBox.SelectedItem = newBox
    End Sub

#Region "more than one shipping or shipping addresses warning"
    Private Sub CustomersShippingAddressesBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles CustomersShippingAddressesBindingSource.ListChanged
        If InvoiceInformationCompleteButton.Enabled = True And Not isLoading AndAlso CustomersShippingAddressesBindingSource.List.Count > 1 AndAlso Not isEditing Then
            MsgBox("Customer Has Multiple Shipping addresses.  Please choose the correct one", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub CustomersBillingAddressesBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles CustomersBillingAddressesBindingSource.ListChanged
        If InvoiceInformationCompleteButton.Enabled = True And Not isLoading AndAlso CustomersBillingAddressesBindingSource.List.Count > 1 AndAlso Not isEditing Then
            MsgBox("Customer Has Multiple Billing addresses.  Please choose the correct one", MsgBoxStyle.OkOnly)
        End If
    End Sub
#End Region

    'prevent automatically adding a row when the last row is deleted
    Private Sub Non_Inventory_Invoice_RecordsDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles Non_Inventory_Invoice_RecordsDataGridView.UserDeletedRow
        If Non_Inventory_Invoice_RecordsDataGridView.Rows.Count = 0 Then
            TotalTextBox.Focus()
        End If
    End Sub

End Class