Imports Microsoft.Office.Interop.Excel

Public Class AgedInventoryReport
    Public KeyValueDictionary As New Dictionary(Of String, Object)


    Private Sub AgedInventoryReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using (New WaitCursor)
            'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarInventoryJoinCaviarFish' table. You can move, or remove it, as needed.
            Me.CaviarInventoryJoinCaviarFishTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarInventoryJoinCaviarFish)
            'TODO: This line of code loads data into the 'SturgeonDBDataSet.ProductCategorySelection' table. You can move, or remove it, as needed.
            Me.ProductCategorySelectionTableAdapter.Fill(Me.SturgeonDBDataSet.ProductCategorySelection)
            'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
            Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)

            IntializeDictionary()

            Dim FilterString As String = "[InventoryStatus] = 1"
            Dim CaviarRows As SturgeonDBDataSet.CaviarInventoryJoinCaviarFishRow() = SturgeonDBDataSet.CaviarInventoryJoinCaviarFish.Select(FilterString)


            Dim ThisMonth As New Date(Date.Now.Year, Date.Now.Month, 1) 'create a date that is the first of this month for comparisons
            For Each CaviarRow As SturgeonDBDataSet.CaviarInventoryJoinCaviarFishRow In CaviarRows
                'determine the difference in time between this month and the harvest month
                Dim MonthsAgo As Integer = DateDiff(DateInterval.Month, New Date(CaviarRow.Harvest_Date.Year, CaviarRow.Harvest_Date.Month, 1), ThisMonth)

                Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(CaviarRow.FKProductID)
                If MonthsAgo > 12 Then
                    '12 months or more
                    KeyValueDictionary("12+" & ProductRow.Product_Name & "Wt") += ProductRow.UnitWeightgms / 1000
                    KeyValueDictionary("12+" & ProductRow.Product_Name & "Ct") += 1
                ElseIf MonthsAgo >= 0 Then
                    'any other month
                    KeyValueDictionary(MonthsAgo & ProductRow.Product_Name & "Wt") += ProductRow.UnitWeightgms / 1000
                    KeyValueDictionary(MonthsAgo & ProductRow.Product_Name & "Ct") += 1
                End If
            Next

            PopulateExcel()
            Me.Close()
        End Using



    End Sub

    Private Sub IntializeDictionary()
        KeyValueDictionary.Clear()

        For MonthsAgo As Integer = 0 To 11
            KeyValueDictionary.Add(MonthsAgo & "MonthsAgo", Date.Now.AddMonths(-MonthsAgo).Month.ToString & "/" & Date.Now.AddMonths(-MonthsAgo).Year.ToString)
        Next
        KeyValueDictionary.Add("12+" & "MonthsAgo", "Over 12 Months")

        For Each CaviarProduct As SturgeonDBDataSet.ProductsRow In SturgeonDBDataSet.Products.Rows()
            If CaviarProduct.ProductCategorySelectionRow.CaviarInventory And Not CaviarProduct.ProductCategorySelectionRow.Sample Then
                'pick out all the products that are caviar and not sample
                For MonthsAgo As Integer = 0 To 11
                    KeyValueDictionary.Add(MonthsAgo & CaviarProduct.Product_Name & "Wt", New Double)
                    KeyValueDictionary.Add(MonthsAgo & CaviarProduct.Product_Name & "Ct", New Double)
                Next
                KeyValueDictionary.Add("12+" & CaviarProduct.Product_Name & "Wt", New Double)
                KeyValueDictionary.Add("12+" & CaviarProduct.Product_Name & "Ct", New Double)
            End If
        Next

    End Sub


    Private Sub PopulateExcel()
        Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Open(My.Application.Info.DirectoryPath & "\Excel Templates\Aged Inventory.xlsx")
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = xlWorkBook.Sheets("Sheet1")

        Try
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\Excel Templates\Temp.xlsx", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch ex As Exception

        End Try
        xlWorkBook.SaveAs(My.Application.Info.DirectoryPath & "\Excel Templates\Temp.xlsx")

        With xlWorkSheet
            'find the last column and row
            Dim lCol As Integer = .UsedRange.SpecialCells(XlCellType.xlCellTypeLastCell).Column
            Dim lRow As Integer = .UsedRange.SpecialCells(XlCellType.xlCellTypeLastCell).Row

            For i = 1 To lRow
                For j = 1 To lCol
                    Dim xlCells = .Cells(i, j)
                    Dim cell_text As String = CStr(xlCells.Value)

                    If cell_text IsNot Nothing AndAlso cell_text.Contains("[") Then 'there is a key word in the cell
                        'get the keyword
                        Dim FinalText As String = cell_text
                        Do While FinalText.Contains("[")
                            Dim KeyBegin As Integer = FinalText.IndexOf("["c)
                            Dim KeyEnd As Integer = FinalText.IndexOf("]"c, KeyBegin)
                            Dim Key As String = FinalText.Substring(KeyBegin + 1, KeyEnd - KeyBegin - 1)
                            If KeyValueDictionary.ContainsKey(Key) Then
                                If TypeOf (KeyValueDictionary(Key)) Is Date Then
                                    FinalText = FinalText.Replace("[" & Key & "]", DirectCast(KeyValueDictionary(Key), Date).ToShortDateString)
                                Else
                                    FinalText = FinalText.Replace("[" & Key & "]", KeyValueDictionary(Key))
                                End If
                            Else
                                'MsgBox("Key Not found! Aborting...")
                                'key not found, skip
                                Continue For
                            End If
                        Loop
                        .Cells(i, j) = FinalText
                    End If
                Next
            Next
        End With

        xlApp.Visible = True
    End Sub

End Class