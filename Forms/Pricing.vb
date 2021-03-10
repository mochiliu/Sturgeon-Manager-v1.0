'This form allows the user to enter pricing information in 2 different ways: by customer (using bindingsourcenavigator) or by a pricing grid.
Public Class Pricing
    Private IsLoading As Boolean
    Public myFilter As Filter
    Dim PrimaryKeyViolation As Boolean = False 'Happens when the same product is entered for the same customer
    Public isReadOnly As Boolean = False
    Public DefaultRecordID As Integer = -1
    Public listOfProductsPricedByCustomer As New List(Of Integer)

#Region "Form Events"
    Private Sub Pricing_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myFilter.Close()
    End Sub

    Private Sub Pricing_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isReadOnly Then
            Exit Sub
        End If
        Select Case MsgBox("Save the data entered?", MsgBoxStyle.YesNoCancel)
            Case vbYes 'Save
                CustomersBindingNavigatorSaveItem_Click(Nothing, Nothing)
            Case vbCancel
                e.Cancel = True
            Case Else
                'do nothing
        End Select
    End Sub

    Private Sub Pricing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using (New WaitCursor)
            'TODO: This line of code loads data into the 'SturgeonDBDataSet.ProductCategorySelection' table. You can move, or remove it, as needed.
            Me.ProductCategorySelectionTableAdapter.Fill(Me.SturgeonDBDataSet.ProductCategorySelection)
            'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
            Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
            'TODO: This line of code loads data into the 'SturgeonDBDataSet.Customer_Pricing' table. You can move, or remove it, as needed.
            Me.Customer_PricingTableAdapter.Fill(Me.SturgeonDBDataSet.Customer_Pricing)
            'TODO: This line of code loads data into the 'SturgeonDBDataSet.Customers' table. You can move, or remove it, as needed.
            Me.CustomersTableAdapter.Fill(Me.SturgeonDBDataSet.Customers)

            'Me.Customer_PricingDataGridView.Columns.Add("Description", "Description")
            'Me.SturgeonDBDataSet.Customer_Pricing.Columns.Add("Description", Type.GetType("String"), "Parent.Description")
            'Me.Customer_PricingDataGridView.Columns(2).DataPropertyName = "Description"
            IsLoading = True

            myFilter = New Filter(Me, CustomersBindingSource)

            For Each ProductCategory As SturgeonDBDataSet.ProductCategorySelectionRow In SturgeonDBDataSet.ProductCategorySelection.Rows
                If ProductCategory.PricedByCustomer Then
                    If ProductsBindingSource.Filter = "" Then
                        ProductsBindingSource.Filter = "[ProductCategory] = " & ProductCategory.ProductCategoryID 'display all products except for those without pricing
                    Else
                        ProductsBindingSource.Filter = ProductsBindingSource.Filter & " OR [ProductCategory] = " & ProductCategory.ProductCategoryID
                    End If
                    listOfProductsPricedByCustomer.Add(ProductCategory.ProductCategoryID)
                End If
            Next

            SetUpColumnsAndRows()
            FillPricingDGV()


            'move the bindingsource position to the customer passed in by the customers form
            Dim index = 0
            For Each CustomerRow As DataRowView In CustomersBindingSource.List
                If CustomerRow("PKCustomerID") = DefaultRecordID Then
                    CustomersBindingSource.Position = index
                    Exit For
                End If
                index += 1
            Next

            IsLoading = False
        End Using
    End Sub
#End Region

#Region "Button Events"
    Private Sub CustomersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Save()
    End Sub

    Private Sub FilterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterButton.Click
        myFilter.Show()
    End Sub

    Private Sub ExportExcelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportExcelButton.Click
        If Save() Then
            FillPricingDGV()
            ExcelExport(PricingDGV, True)
        End If
    End Sub
#End Region

#Region "Pricing Grid"
    Public Sub SetUpColumnsAndRows()
        PricingDGV.Rows.Clear()
        PricingDGV.Columns.Clear()

        Dim I As Integer
        'set up columns as products
        If SturgeonDBDataSet.Products.Count = 0 Then
            Exit Sub
        End If
        For I = 0 To SturgeonDBDataSet.Products.Count - 1
            If listOfProductsPricedByCustomer.Contains(SturgeonDBDataSet.Products.Rows(I).Item("ProductCategory")) Then
                'the product has a pricing option, so add it as a column
                PricingDGV.Columns.Add(SturgeonDBDataSet.Products.Rows(I).Item("PKProductID"), SturgeonDBDataSet.Products.Rows(I).Item("Product Name"))
                PricingDGV.Columns(PricingDGV.Columns.Count - 1).Tag = SturgeonDBDataSet.Products.Rows(I).Item("PKProductID")
            End If
        Next

        'set up the rows as customers
        For I = 0 To SturgeonDBDataSet.Customers.Count - 1
            PricingDGV.Rows.Add()
            PricingDGV.Rows(I).HeaderCell.Value = SturgeonDBDataSet.Customers.Rows(I).Item("Company Name")
            PricingDGV.Rows(I).Tag = SturgeonDBDataSet.Customers.Rows(I).Item("PKCustomerID")
        Next

    End Sub
    Public Sub FillPricingDGV()
        Dim I As Integer
        'get existing data
        For I = 0 To SturgeonDBDataSet.Customer_Pricing.Count - 1
            Dim customerID = SturgeonDBDataSet.Customer_Pricing.Rows(I).Item("FKCustomerID")
            Dim productID = SturgeonDBDataSet.Customer_Pricing.Rows(I).Item("FKProductID")

            'get the corresponding column and row numbers
            Dim RowNo As Integer = -1
            Dim ColumnNo As Integer = -1
            Dim J As Integer

            ' identify which column represents the correct product
            For J = 0 To PricingDGV.Columns.Count - 1
                If PricingDGV.Columns(J).Tag = productID Then
                    ColumnNo = J
                    GoTo ColumnFound
                End If
            Next
            Continue For 'could not find column
ColumnFound:
            ' identify which row represents the correct customer
            For J = 0 To PricingDGV.Rows.Count - 1
                If PricingDGV.Rows(J).Tag = customerID Then
                    RowNo = J
                    GoTo Rowfound
                End If
            Next
            Continue For 'could not find row
RowFound:
            'update the corresponding information in the cell
            PricingDGV.Rows(RowNo).Cells(ColumnNo).Value = SturgeonDBDataSet.Customer_Pricing.Rows(I).Item("Price")
        Next
    End Sub

    Public Sub SavePriceDGV(ByVal ColumnNo As Integer, ByVal RowNo As Integer)
        If ColumnNo < 0 Or RowNo < 0 Then
            Exit Sub
        End If

        Dim DGVProductID = PricingDGV.Columns(ColumnNo).Tag
        Dim DGVCustomerID = PricingDGV.Rows(RowNo).Tag
        Dim R() As DataRow = SturgeonDBDataSet.Customer_Pricing.Select("FKCustomerID='" & DGVCustomerID & "' and FKProductID='" & DGVProductID & "'")
        Try
            If R.Count = 0 Then 'check if entry exists
                'no entry
                If Not PricingDGV.Rows(RowNo).Cells(ColumnNo).Value = Nothing Then 'check if there is a value in the cell
                    'a value has been added
                    Customer_PricingTableAdapter.Insert(DGVCustomerID, DGVProductID, Convert.ToDecimal(PricingDGV.Rows(RowNo).Cells(ColumnNo).Value))
                End If
            Else
                'entry already exists
                If Not PricingDGV.Rows(RowNo).Cells(ColumnNo).Value = Nothing Then 'check if there is a value in the cell
                    'a value has been changed, edit the value
                    If TypeOf (PricingDGV.Rows(RowNo).Cells(ColumnNo).Value) Is String Then
                        IsLoading = True
                        Dim StringArray As String() = PricingDGV.Rows(RowNo).Cells(ColumnNo).Value.ToString.Split("$")
                        If StringArray.Count > 1 Then
                            PricingDGV.Rows(RowNo).Cells(ColumnNo).Value = StringArray(1)
                        Else
                            PricingDGV.Rows(RowNo).Cells(ColumnNo).Value = StringArray(0)
                        End If

                        IsLoading = False
                    End If

                    R(0).Item("Price") = Convert.ToDecimal(PricingDGV.Rows(RowNo).Cells(ColumnNo).Value)
                    Customer_PricingTableAdapter.Update(R(0))
                Else
                    'a value has been deleted, delete the corresponding entry
                    Customer_PricingTableAdapter.Delete(DGVCustomerID, DGVProductID, R(0).Item("Price"))
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'update the datagridview
        Me.Customer_PricingTableAdapter.Fill(Me.SturgeonDBDataSet.Customer_Pricing)
        IsLoading = True
        FillPricingDGV()
        IsLoading = False
    End Sub

    Private Sub PricingDGV_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles PricingDGV.CellValidating
        If Not IsLoading And PricingDGV.IsCurrentCellInEditMode Then
            'check if the pricing is valid
            Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(PricingDGV.Columns(e.ColumnIndex).Tag)
            If IsNumeric(e.FormattedValue) Then
                If Not Math.Round(Convert.ToDecimal(e.FormattedValue.ToString.Substring(1, e.FormattedValue.ToString.Count - 1)) * 0.1 * ProductRow.UnitWeightgms, 4) = Convert.ToInt32((e.FormattedValue.ToString.Substring(1, e.FormattedValue.ToString.Count - 1)) * 0.1 * ProductRow.UnitWeightgms) Then
                    MsgBox("Pricing not valid because per unit price has a sub cent figure")
                    e.Cancel = True
                End If
            Else
                MsgBox("Please enter a number")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub PricingDGV_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PricingDGV.CellValueChanged
        Dim selectedColumn As Integer = 0
        Dim selectedRow As Integer = 0
        Try
            selectedColumn = PricingDGV.CurrentCell.ColumnIndex
            selectedRow = PricingDGV.CurrentCell.RowIndex
        Catch ex As Exception
            'current cell is null
        End Try
        If Not IsLoading Then
            SavePriceDGV(e.ColumnIndex, e.RowIndex)
        End If
        Try
            PricingDGV.CurrentCell = PricingDGV.Rows(selectedRow).Cells(selectedColumn)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged
        CustomersBindingNavigatorSaveItem_Click(Nothing, Nothing)
        IsLoading = True
        FillPricingDGV()
        IsLoading = False

    End Sub
#End Region

#Region "Multi Select"
    Private Sub Customer_PricingDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles Customer_PricingDataGridView.CellValidating
        If PrimaryKeyViolation Then
            PrimaryKeyViolation = False
            e.Cancel = True
        End If
    End Sub

    Private Sub Customer_PricingDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Customer_PricingDataGridView.CellValueChanged
        EditMultiSelect()
    End Sub

    Private Sub EditMultiSelect()
        Using (New WaitCursor)
            Dim I As Integer = 0
            If CustomersDataGridView.SelectedRows.Count > 1 Then 'user is using multiselect
                'multiselect stategy: change all the selected customers to match the pricing of the current customer being edited
                Dim CurrentPKCustomerID As Integer = CustomersDataGridView.CurrentRow.Cells("PKCustomerIDColumn").Value 'the currently selected row in the customers dgv
                Me.Cursor = Cursors.WaitCursor
                'loop through to see if there are incomplete rows in the pricing dgv, if so, do not continue, otherwise, save
                For I = 0 To Customer_PricingDataGridView.Rows.Count - 1
                    Dim FKProductID = Customer_PricingDataGridView.Rows(I).Cells("FKProductIDColumn").Value
                    If Not IsDBNull(FKProductID) And Not IsNothing(FKProductID) And Not IsDBNull(Customer_PricingDataGridView.Rows(I).Cells("PriceColumn").Value) And Not IsNothing(Customer_PricingDataGridView.Rows(I).Cells("PriceColumn").Value) Or Customer_PricingDataGridView.Rows(I).IsNewRow Then
                    Else
                        Exit Sub
                    End If
                Next

                'save the bindngsource as to avoid conflict
                Customer_PricingBindingSource.EndEdit()
                Me.Customer_PricingTableAdapter.Update(SturgeonDBDataSet.Customer_Pricing)
                Me.Customer_PricingTableAdapter.Fill(Me.SturgeonDBDataSet.Customer_Pricing)

                For Each SelectedRow As DataGridViewRow In CustomersDataGridView.SelectedRows
                    Dim SelectedPKCustomerID As Integer = SelectedRow.Cells("PKCustomerIDColumn").Value

                    If SelectedPKCustomerID = CurrentPKCustomerID Then
                        'selected row is current row, skip the process
                        Continue For
                        'GoTo SkipDeleting
                    End If

                    'clear all pricing entries
                    For I = 0 To SturgeonDBDataSet.Products.Count - 1
                        Dim FKProductID As Integer = SturgeonDBDataSet.Products.Rows(I).Item("PKProductID")
                        Dim R() As DataRow = SturgeonDBDataSet.Customer_Pricing.Select("FKCustomerID='" & SelectedPKCustomerID & "' and FKProductID='" & FKProductID & "'")
                        If R.Count > 0 Then
                            'entry exists, so delete it
                            Customer_PricingTableAdapter.Delete(SelectedPKCustomerID, FKProductID, R(0).Item("Price"))
                        End If
                    Next
                    'SkipDeleting:
                    'add all of the current row's pricing entries
                    For I = 0 To Customer_PricingDataGridView.Rows.Count - 1
                        Dim FKProductID = Customer_PricingDataGridView.Rows(I).Cells("FKProductIDColumn").Value
                        If Not IsDBNull(FKProductID) And Not IsNothing(FKProductID) And Not IsDBNull(Customer_PricingDataGridView.Rows(I).Cells("PriceColumn").Value) And Not IsNothing(Customer_PricingDataGridView.Rows(I).Cells("PriceColumn").Value) Then
                            'the productID is populated, so add a entry in customer pricing
                            Customer_PricingTableAdapter.Insert(SelectedPKCustomerID, FKProductID, Customer_PricingDataGridView.Rows(I).Cells("PriceColumn").Value)
                        End If
                    Next
                Next
                Me.Customer_PricingTableAdapter.Fill(Me.SturgeonDBDataSet.Customer_Pricing)
                Me.Cursor = Cursors.Arrow
            End If
        End Using
    End Sub


    Private Sub Customer_PricingBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles Customer_PricingBindingSource.ListChanged
        If e.ListChangedType = System.ComponentModel.ListChangedType.ItemDeleted Then
            'if a pricing record is deleted, update the multiselect
            EditMultiSelect()
        End If
    End Sub

    Private Sub Customer_PricingDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Customer_PricingDataGridView.DataError
        MsgBox("Entry error! Please check if a pricing is already entered for this product or other errors")
        PrimaryKeyViolation = True
        e.Cancel = True
    End Sub
#End Region

    Public Function Save() As Boolean
        Using (New WaitCursor)
            Dim currentIndex As Integer
            currentIndex = CustomersBindingSource.Position
            Try
                Me.Validate()
                Me.CustomersBindingSource.EndEdit()
                Me.ProductsBindingSource.EndEdit()
                Me.Customer_PricingBindingSource.EndEdit()
                'Me.CustomersTableAdapter.Update(SturgeonDBDataSet.Customers)
                'Me.ProductsTableAdapter.Update(SturgeonDBDataSet.Products)
                'Me.Customer_PricingTableAdapter.Update(SturgeonDBDataSet.Customer_Pricing)
                Me.TableAdapterManager.UpdateAll(SturgeonDBDataSet)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
            Me.Customer_PricingTableAdapter.Fill(Me.SturgeonDBDataSet.Customer_Pricing)
            Me.CustomersTableAdapter.Fill(Me.SturgeonDBDataSet.Customers)
            CustomersBindingSource.Position = currentIndex
            Return True
        End Using
    End Function

    Public Sub LoadReadOnly()
        isReadOnly = True
        With Me
            .CustomersBindingNavigatorSaveItem.Enabled = False
            .CustomersBindingNavigatorSaveItem.Visible = False
            .BindingNavigatorAddNewItem.Visible = False
            .BindingNavigatorDeleteItem.Visible = False

            .Customer_PricingDataGridView.ReadOnly = True
            .PricingDGV.ReadOnly = True

            .Text = "View Pricing"
        End With
    End Sub

End Class