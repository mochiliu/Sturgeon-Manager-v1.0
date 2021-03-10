
'This form allows the user to create new fish invoices
Public Class NewFishInvoice
    Public isLoading As Boolean = True
    Public isComplete As Boolean = False
    Public isSaved As Boolean = False
    Public isEditing As Boolean = False
    Public FishNonInventoryProductsFilter As String = ""


    Private Sub NewFishInvoice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If isEditing And Not isComplete Then
                Select Case MsgBox("Closing the window without saving results in the invoice being left in an incomplete state. Complete the invoice?", MsgBoxStyle.OkCancel)
                    Case MsgBoxResult.Ok
                        isEditing = False
                        CompleteInvoiceButton_Click(Nothing, Nothing)
                    Case MsgBoxResult.Cancel
                        e.Cancel = True
                End Select
            Else
                If isSaved And Not isComplete Then
                    'user has previewed the invoice but has not completed it
                    MsgBox("The invoice has been saved already. Please complete the invoice and delete it in edit invoice.", MsgBoxStyle.Information)
                    e.Cancel = True
                ElseIf Not isComplete AndAlso MsgBox("Close without completing invoice? Invoice will not be saved.", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    'user has not completed the invoice nor saved
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub NewFishInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.InvoiceTypeSelection' table. You can move, or remove it, as needed.
        Me.InvoiceTypeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.InvoiceTypeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.ProductCategorySelection' table. You can move, or remove it, as needed.
        Me.ProductCategorySelectionTableAdapter.Fill(Me.SturgeonDBDataSet.ProductCategorySelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Billing_Addresses' table. You can move, or remove it, as needed.
        Me.Billing_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Billing_Addresses)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Shipping_Addresses' table. You can move, or remove it, as needed.
        Me.Shipping_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Shipping_Addresses)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Customer_Pricing' table. You can move, or remove it, as needed.
        Me.Customer_PricingTableAdapter.Fill(Me.SturgeonDBDataSet.Customer_Pricing)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.SturgeonDBDataSet.Customers)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet._Non_Inventory_Invoice_Records' table. You can move, or remove it, as needed.
        Me.Non_Inventory_Invoice_RecordsTableAdapter.Fill(Me.SturgeonDBDataSet._Non_Inventory_Invoice_Records)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Invoices' table. You can move, or remove it, as needed.
        Me.InvoicesTableAdapter.Fill(Me.SturgeonDBDataSet.Invoices)

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
        ProductsBindingSource.Filter = FishNonInventoryProductsFilter

        InvoicesBindingSource.ResetBindings(False)
        isLoading = False
    End Sub

    Public Sub InvoiceInformationCompleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceInformationCompleteButton.Click
        'check if values are valid
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

        'enable adding products and complete invoice
        Non_Inventory_Invoice_RecordsDataGridView.Enabled = True
        CompleteInvoiceButton.Enabled = True
        SavePreviewButton.Enabled = True
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

    Public Function Save() As Boolean
        Dim currentIndex As Integer
        currentIndex = InvoicesBindingSource.Position

        Try
            Me.Validate()
            Me.InvoicesBindingSource.EndEdit()
            Me.InvoicesTableAdapter.Update(Me.SturgeonDBDataSet.Invoices)
            Me.Non_Inventory_Invoice_RecordsBindingSource.EndEdit()
            Me.Non_Inventory_Invoice_RecordsTableAdapter.Update(Me.SturgeonDBDataSet._Non_Inventory_Invoice_Records)
            'Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet) 'Does not work
            Me.Non_Inventory_Invoice_RecordsTableAdapter.Fill(Me.SturgeonDBDataSet._Non_Inventory_Invoice_Records)
            Me.InvoicesTableAdapter.Fill(Me.SturgeonDBDataSet.Invoices)
            InvoicesBindingSource.Position = currentIndex
            isSaved = True
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

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
                        Main.ShowNewFishInvoice()
                    End If
                End If
            End If
            isLoading = False
        End Using
    End Sub

    Public Sub CalculateTotals()
        'Update Total cost
        Dim OthersSubtotal As Decimal = 0.0
        For Each Entry As DataGridViewRow In Non_Inventory_Invoice_RecordsDataGridView.Rows
            If Not IsNothing(Entry.Cells("PriceSoldAtColumn").Value) And Not IsDBNull(Entry.Cells("PriceSoldAtColumn").Value) Then
                OthersSubtotal = OthersSubtotal + FormatNumber(Entry.Cells("PriceSoldAtColumn").Value)
            End If
        Next
        TotalTextBox.Text = FormatCurrency(OthersSubtotal)
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

    Private Sub Non_Inventory_Invoice_RecordsDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Non_Inventory_Invoice_RecordsDataGridView.CellValueChanged
        If isLoading Then
            Exit Sub
        End If
        Select Case e.ColumnIndex
            Case Non_Inventory_Invoice_RecordsDataGridView.Columns("FKProductIDColumn").Index
                'a product selection has changed, update to customer's price
                'get the appropriate data
                Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Dim CustomerPricingRow As SturgeonDBDataSet.Customer_PricingRow = SturgeonDBDataSet.Customer_Pricing.FindByFKCustomerIDFKProductID(FKCustomerIDComboBox.SelectedValue, ProductRow.PKProductID)
                Dim ProductCategoryRow As SturgeonDBDataSet.ProductCategorySelectionRow = SturgeonDBDataSet.ProductCategorySelection.FindByProductCategoryID(ProductRow.ProductCategory)
                If Not IsNothing(ProductCategoryRow) AndAlso Not IsDBNull(ProductCategoryRow) AndAlso ProductCategoryRow.PricedAt0 Then
                    'the item is priced at 0
                    isLoading = True
                    'reset the quantity and price for a item without a price in the pricing table
                    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityColumn").Value = 1
                    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("PriceSoldAtColumn").Value = 0
                    isLoading = False
                ElseIf Not IsNothing(ProductCategoryRow) AndAlso Not IsDBNull(ProductCategoryRow) AndAlso Not ProductCategoryRow.PricedByCustomer Then
                    'no pricing needed
                    isLoading = True
                    'reset the quantity and price for a item without a price in the pricing table
                    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityColumn").Value = DBNull.Value
                    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("PriceSoldAtColumn").Value = DBNull.Value
                    isLoading = False
                ElseIf IsNothing(CustomerPricingRow) Then
                    'no pricing found
                    Dim response = MsgBox("The customer has no set pricing for this product. Add the product to order anyway? Entry will be deleted otherwise.", MsgBoxStyle.YesNo)
                    If response = vbNo Then
                        'delete the row
                        Non_Inventory_Invoice_RecordsBindingSource.RemoveCurrent()
                    End If
                    isLoading = True
                    'reset the quantity and price for a item without a price in the pricing table
                    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityColumn").Value = DBNull.Value
                    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("PriceSoldAtColumn").Value = DBNull.Value
                    isLoading = False
                Else
                    'princing found
                    If Not IsDBNull(Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityColumn").Value) Then
                        'there is a quantity entered, calculate the total price
                    Else
                        'no quantity entered, default to 1
                        Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityColumn").Value = 1
                    End If
                    'calculate the price
                    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("PriceSoldAtColumn").Value = Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityColumn").Value * CustomerPricingRow.Price
                End If

            Case Non_Inventory_Invoice_RecordsDataGridView.Columns("QuantityColumn").Index
                'a quantity has changed, update to customer's price
                'get the appropriate data
                If Not IsNothing(Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("FKProductIDColumn").Value) AndAlso Not IsDBNull(Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("FKProductIDColumn").Value) And Not IsDBNull(Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityColumn").Value) Then
                    Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("FKProductIDColumn").Value)
                    If Not IsNothing(ProductRow) Then
                        Dim CustomerPricingRow As SturgeonDBDataSet.Customer_PricingRow = SturgeonDBDataSet.Customer_Pricing.FindByFKCustomerIDFKProductID(FKCustomerIDComboBox.SelectedValue, ProductRow.PKProductID)
                        If Not IsNothing(CustomerPricingRow) Then
                            'calculate the price as pricing is found
                            Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("PriceSoldAtColumn").Value = Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("QuantityColumn").Value * CustomerPricingRow.Price
                        End If
                    End If
                End If

        End Select
        CalculateTotals()
    End Sub


    'Private Sub Non_Inventory_Invoice_RecordsDataGridView_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles Non_Inventory_Invoice_RecordsDataGridView.UserAddedRow
    '    'If IsNothing(Non_Inventory_Invoice_RecordsDataGridView.Item("FKProductIDColumn", e.RowIndex).Value) Or IsDBNull(Non_Inventory_Invoice_RecordsDataGridView.Item("FKProductIDColumn", e.RowIndex).Value) Then
    '    '    MsgBox("A product is required!")
    '    '    Non_Inventory_Invoice_RecordsDataGridView.Rows(e.RowIndex).Cells("FKProductIDColumn").Value = DirectCast(ProductsBindingSource.List.Item(0), DataRowView).Item("PKProductID")
    '    'End If
    '    If IsNothing(e.Row.Cells("FKProductIDColumn").Value) Or IsDBNull(e.Row.Cells("FKProductIDColumn").Value) Then
    '        MsgBox("A product is required!")
    '        e.Row.Cells("FKProductIDColumn").Value = DirectCast(ProductsBindingSource.List.Item(0), DataRowView).Item("PKProductID")
    '    End If
    'End Sub

    Private Sub Non_Inventory_Invoice_RecordsBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Non_Inventory_Invoice_RecordsBindingSource.AddingNew
        Dim DefaultEntry As DataRowView = DirectCast(Non_Inventory_Invoice_RecordsBindingSource.List, DataView).AddNew()
        Try
            DefaultEntry.Row.Item("FKProductID") = DirectCast(ProductsBindingSource.List.Item(0), DataRowView).Item("PKProductID")
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


    'handles summing up the quantity column for shipping weight when ctrl+s is pressed
    Private Sub Non_Inventory_Invoice_RecordsDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Non_Inventory_Invoice_RecordsDataGridView.KeyDown
        If Non_Inventory_Invoice_RecordsDataGridView.CurrentCell.ColumnIndex = Non_Inventory_Invoice_RecordsDataGridView.Columns("QuantityColumn").Index Then
            If e.Control And e.KeyCode = Keys.S Then 'control + s is pressed
                Dim ShippingWeight As Double = 0
                Dim I As Integer = 0
                For I = 0 To Non_Inventory_Invoice_RecordsDataGridView.CurrentCell.RowIndex - 1
                    Try
                        ShippingWeight += Non_Inventory_Invoice_RecordsDataGridView.Rows(I).Cells("QuantityColumn").Value
                    Catch ex As Exception
                    End Try
                Next
                Non_Inventory_Invoice_RecordsDataGridView.CurrentCell.Value = ShippingWeight
            End If
        End If
    End Sub

    Private Sub Non_Inventory_Invoice_RecordsBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Non_Inventory_Invoice_RecordsBindingSource.CurrentItemChanged
        CalculateTotals()
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

#Region "more than one shipping or shipping addresses warning"
    Private Sub CustomersShippingAddressesBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles CustomersShippingAddressesBindingSource.ListChanged
        If Not isLoading AndAlso CustomersShippingAddressesBindingSource.List.Count > 1 AndAlso Not isEditing Then
            MsgBox("Customer Has Multiple Shipping addresses.  Please choose the correct one", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub CustomersBillingAddressesBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles CustomersBillingAddressesBindingSource.ListChanged
        If Not isLoading AndAlso CustomersBillingAddressesBindingSource.List.Count > 1 AndAlso Not isEditing Then
            MsgBox("Customer Has Multiple Billing addresses.  Please choose the correct one", MsgBoxStyle.OkOnly)
        End If
    End Sub
#End Region

    Private Sub SavePreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavePreviewButton.Click
        Using New WaitCursor
            If Save() Then
                ReportViewer.DisplayReport(ReportType.OtherInvoiceReport, "{Invoices.PKInvoiceID} = " & DirectCast(InvoicesBindingSource.Current, DataRowView).Row.Item("PKInvoiceID"))
                ReportViewer.Show()
                ReportViewer.CrystalReportViewer.ShowLastPage()
                ReportViewer.CrystalReportViewer.ShowFirstPage()
            End If
        End Using

    End Sub

    'prevent automatically adding a row when the last row is deleted
    Private Sub Non_Inventory_Invoice_RecordsDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles Non_Inventory_Invoice_RecordsDataGridView.UserDeletedRow
        If Non_Inventory_Invoice_RecordsDataGridView.Rows.Count = 0 Then
            TotalTextBox.Focus()
        End If
    End Sub

    Private Sub Non_Inventory_Invoice_RecordsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Non_Inventory_Invoice_RecordsDataGridView.CellContentClick

    End Sub
End Class