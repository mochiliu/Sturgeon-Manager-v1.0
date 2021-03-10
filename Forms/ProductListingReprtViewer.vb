Public Class ProductListingReportViewer

    Private Sub ProductListReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.ProductCategorySelection' table. You can move, or remove it, as needed.
        Me.ProductCategorySelectionTableAdapter.Fill(Me.SturgeonDBDataSet.ProductCategorySelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.GradeSelection' table. You can move, or remove it, as needed.
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        Dim rpt As New ProductListing

        rpt.SetDataSource(SturgeonDBDataSet)

        Me.CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.SelectionFormula = "{Products.PKProductID} = 50"

    End Sub



End Class