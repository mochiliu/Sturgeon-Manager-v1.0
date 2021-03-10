Public Class RepackLoss


    Private Sub RepackLoss_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarStatusSelection' table. You can move, or remove it, as needed.
        Me.CaviarStatusSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarStatusSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.RepackLossJoinCaviarInventory' table. You can move, or remove it, as needed.
        Me.RepackLossJoinCaviarInventoryTableAdapter.Fill(Me.SturgeonDBDataSet.RepackLossJoinCaviarInventory)

    End Sub

    Private Sub ExportExcelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportExcelButton.Click
        Try
            ExcelExport(RepackLossJoinCaviarInventoryDataGridView)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class