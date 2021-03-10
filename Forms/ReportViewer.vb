
'This form displays all crystal reports, including invoices
Public Class ReportViewer

    Private Sub ReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarInventoryValue' table. You can move, or remove it, as needed.
        Me.CaviarInventoryValueTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarInventoryValue)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Shipping_Addresses' table. You can move, or remove it, as needed.
        Me.Shipping_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Shipping_Addresses)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.ProductCategorySelection' table. You can move, or remove it, as needed.
        Me.ProductCategorySelectionTableAdapter.Fill(Me.SturgeonDBDataSet.ProductCategorySelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet._Non_Inventory_Invoice_Records' table. You can move, or remove it, as needed.
        Me.Non_Inventory_Invoice_RecordsTableAdapter.Fill(Me.SturgeonDBDataSet._Non_Inventory_Invoice_Records)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Invoices' table. You can move, or remove it, as needed.
        Me.InvoicesTableAdapter.Fill(Me.SturgeonDBDataSet.Invoices)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.GradeSelection' table. You can move, or remove it, as needed.
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.SturgeonDBDataSet.Customers)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Customer_Pricing' table. You can move, or remove it, as needed.
        Me.Customer_PricingTableAdapter.Fill(Me.SturgeonDBDataSet.Customer_Pricing)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarStatusSelection' table. You can move, or remove it, as needed.
        Me.CaviarStatusSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarStatusSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Inventory' table. You can move, or remove it, as needed.
        Me.Caviar_InventoryTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Inventory)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Fish' table. You can move, or remove it, as needed.
        Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Billing_Addresses' table. You can move, or remove it, as needed.
        Me.Billing_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Billing_Addresses)

    End Sub

    Public Sub DisplayReport(ByVal RType As ReportType, Optional ByVal SelectionString As String = "")
        Select Case RType
            Case ReportType.CaviarInvoiceReport
                Dim rpt As New CaviarInvoiceReport 'This line needs to be redefined for each new type of report
                rpt.SetDataSource(SturgeonDBDataSet) 'This is common code to all types of reports
                Me.CrystalReportViewer.ReportSource = rpt 'This is common code to all types of reports

            Case ReportType.CaviarPackingReport
                Dim rpt As New CaviarPackingReport
                rpt.SetDataSource(SturgeonDBDataSet)
                Me.CrystalReportViewer.ReportSource = rpt

            Case ReportType.OtherInvoiceReport
                Dim rpt As New FishInvoiceReport
                rpt.SetDataSource(SturgeonDBDataSet)
                Me.CrystalReportViewer.ReportSource = rpt

            Case ReportType.OtherPackingReport
                Dim rpt As New FishPackingReport
                rpt.SetDataSource(SturgeonDBDataSet)
                Me.CrystalReportViewer.ReportSource = rpt

            Case ReportType.ProductListingReport
                Dim rpt As New ProductListing
                rpt.SetDataSource(SturgeonDBDataSet)
                Me.CrystalReportViewer.ReportSource = rpt

            Case ReportType.CustomerList
                Dim rpt As New CustomersReport
                rpt.SetDataSource(SturgeonDBDataSet)
                Me.CrystalReportViewer.ReportSource = rpt

            Case ReportType.InventoryValue
                Dim rpt As New InventoryValueReport
                rpt.SetDataSource(SturgeonDBDataSet)
                Me.CrystalReportViewer.ReportSource = rpt

        End Select
        CrystalReportViewer.SelectionFormula = SelectionString
    End Sub

    Private Sub CaviarInventoryValueBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CaviarInventoryValueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet)

    End Sub
End Class