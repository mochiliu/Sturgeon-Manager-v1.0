Imports Microsoft.Office.Interop.Excel

Public Class SalesReport
    Public KeyValueDictionary As New Dictionary(Of String, Object)

    Private Sub SalesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Fish' table. You can move, or remove it, as needed.
        Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.MaleFishHarvest' table. You can move, or remove it, as needed.
        Me.MaleFishHarvestTableAdapter.Fill(Me.SturgeonDBDataSet.MaleFishHarvest)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.FemaleFishInventory' table. You can move, or remove it, as needed.
        Me.FemaleFishInventoryTableAdapter.Fill(Me.SturgeonDBDataSet.FemaleFishInventory)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.WeightConversionConstants' table. You can move, or remove it, as needed.
        Me.WeightConversionConstantsTableAdapter.Fill(Me.SturgeonDBDataSet.WeightConversionConstants)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.NonInventoryInvoiceFlatTable' table. You can move, or remove it, as needed.
        Me.NonInventoryInvoiceFlatTableTableAdapter.Fill(Me.SturgeonDBDataSet.NonInventoryInvoiceFlatTable)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarInventoryInvoiceFlatTable' table. You can move, or remove it, as needed.
        Me.CaviarInventoryInvoiceFlatTableTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarInventoryInvoiceFlatTable)

        EndDateTimePicker.Value = GetThisWeekDay(DayOfWeek.Friday)
        BeginDateTimePicker.Value = EndDateTimePicker.Value.AddDays(-6)
    End Sub


    Private Sub GenerateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateButton.Click
        Using (New WaitCursor) 'Load Hourglass

            'filter for data for a particular date range
            Dim startTime As Date = BeginDateTimePicker.Value
            Dim endTime As Date = EndDateTimePicker.Value
            Dim FilterString As String = "[" & "Date" & String.Format("] >= #{0:M/dd/yyyy} 00:00:00# AND [", startTime) & "Date" & String.Format("] < #{0:M/dd/yyyy} 00:00:00#", endTime.AddDays(1))
            Dim CaviarRows As SturgeonDBDataSet.CaviarInventoryInvoiceFlatTableRow() = SturgeonDBDataSet.CaviarInventoryInvoiceFlatTable.Select(FilterString)
            Dim NonInventoryRows As SturgeonDBDataSet.NonInventoryInvoiceFlatTableRow() = SturgeonDBDataSet.NonInventoryInvoiceFlatTable.Select(FilterString)
            Dim ConversionConstants As SturgeonDBDataSet.WeightConversionConstantsRow = SturgeonDBDataSet.WeightConversionConstants.Rows(0)

            FilterString = "[" & "HarvestDate" & String.Format("] >= #{0:M/dd/yyyy} 00:00:00# AND [", startTime) & "HarvestDate" & String.Format("] < #{0:M/dd/yyyy} 00:00:00#", endTime.AddDays(1))
            Dim MaleHarvestRows As SturgeonDBDataSet.MaleFishHarvestRow() = SturgeonDBDataSet.MaleFishHarvest.Select(FilterString)

            FilterString = "[" & "Harvest Date" & String.Format("] >= #{0:M/dd/yyyy} 00:00:00# AND [", startTime) & "Harvest Date" & String.Format("] < #{0:M/dd/yyyy} 00:00:00#", endTime.AddDays(1))
            Dim FemaleHarvestRows As SturgeonDBDataSet.Caviar_FishRow() = SturgeonDBDataSet.Caviar_Fish.Select(FilterString)

            'get the last inventory entered during this period
            FilterString = "[" & "InventoryDate" & String.Format("] >= #{0:M/dd/yyyy} 00:00:00# AND [", startTime) & "InventoryDate" & String.Format("] < #{0:M/dd/yyyy} 00:00:00#", endTime.AddDays(1))
            Dim FemaleInventoryAfterRows As SturgeonDBDataSet.FemaleFishInventoryRow() = SturgeonDBDataSet.FemaleFishInventory.Select(FilterString)
            'get the last inventory entered the week (up to 11 days) before this period
            FilterString = "[" & "InventoryDate" & String.Format("] >= #{0:M/dd/yyyy} 00:00:00# AND [", startTime.AddDays(-4)) & "InventoryDate" & String.Format("] < #{0:M/dd/yyyy} 00:00:00#", startTime)
            Dim FemaleInventoryBeforeRows As SturgeonDBDataSet.FemaleFishInventoryRow() = SturgeonDBDataSet.FemaleFishInventory.Select(FilterString)

            'initialize dictionary
            IntializeDictionary()

            'get caviar data
            Dim CurrentInvoice As Integer = -1
            For Each CaviarRow As SturgeonDBDataSet.CaviarInventoryInvoiceFlatTableRow In CaviarRows
                If CaviarRow.Sample Then
                    'The caviar container sold is a sample
                    KeyValueDictionary(CaviarRow.Grade & "SampleWt") += CDbl(CaviarRow.UnitWeightgms / 1000)
                Else
                    'The caviar container sold is not a sample
                    KeyValueDictionary(CaviarRow.Grade & "Wt") += CDbl(CaviarRow.UnitWeightgms / 1000)
                    KeyValueDictionary(CaviarRow.Grade & "Sales") += CDbl(CaviarRow.PriceSoldAt * CaviarRow.UnitWeightgms / 1000)
                End If
                'KeyValueDictionary(CaviarRow.Grade & "TotalWt") += CDbl(CaviarRow.UnitWeightgms / 1000) 'add to the grade total weight
                'KeyValueDictionary("CaviarWt") += CDbl(CaviarRow.UnitWeightgms / 1000) 'add to the caviar total weight
                'KeyValueDictionary("CaviarSales") += CDbl(CaviarRow.PriceSoldAt * CaviarRow.UnitWeightgms / 1000) 'add to total sales
                If CaviarRow.PKInvoiceID <> CurrentInvoice Then
                    'new invoice has begun, add counter to the number of caviar invoices
                    KeyValueDictionary("CaviarInvoiceCount") += 1
                    CurrentInvoice = CaviarRow.PKInvoiceID
                    'also round the sales figures
                    KeyValueDictionary(CaviarRow.Grade & "Sales") = Math.Round(KeyValueDictionary(CaviarRow.Grade & "Sales"), 2)
                    'KeyValueDictionary("CaviarSales") = Math.Round(KeyValueDictionary("CaviarSales"), 2)
                End If
            Next

            'get non inventory data
            CurrentInvoice = -1
            For Each NonInventoryRow As SturgeonDBDataSet.NonInventoryInvoiceFlatTableRow In NonInventoryRows

                If NonInventoryRow.Product_Name = "Misc" Then
                    If Not IsDBNull(NonInventoryRow.PriceSoldAt) Then
                        KeyValueDictionary("MiscSales") += CDbl(NonInventoryRow.PriceSoldAt)
                    End If
                    Continue For
                End If

                Select Case NonInventoryRow.Description
                    Case "Fish" 'fish invoice
                        Select Case NonInventoryRow.Product_Name
                            Case "FB"
                                KeyValueDictionary("BulletWt") += CDbl(NonInventoryRow.Quantity)
                                KeyValueDictionary("BulletSales") += CDbl(NonInventoryRow.PriceSoldAt)
                            Case "FF"
                                KeyValueDictionary("FilletWt") += CDbl(NonInventoryRow.Quantity)
                                KeyValueDictionary("FilletSales") += CDbl(NonInventoryRow.PriceSoldAt)
                            Case "FW"
                                KeyValueDictionary("WholeGuttedWt") += CDbl(NonInventoryRow.Quantity)
                                KeyValueDictionary("WholeGuttedSales") += CDbl(NonInventoryRow.PriceSoldAt)
                            Case "FBS"
                                KeyValueDictionary("BulletSampleWt") += CDbl(NonInventoryRow.Quantity)
                            Case "FFS"
                                KeyValueDictionary("FilletSampleWt") += CDbl(NonInventoryRow.Quantity)
                            Case "FWS"
                                KeyValueDictionary("WholeGuttedSampleWt") += CDbl(NonInventoryRow.Quantity)
                            Case "FishCredit"
                                KeyValueDictionary("FishCredit") += CDbl(NonInventoryRow.PriceSoldAt)
                            Case Else
                                If NonInventoryRow.Shipping Then
                                    KeyValueDictionary("FishFreight") += CDbl(NonInventoryRow.PriceSoldAt)
                                End If
                        End Select
                        If NonInventoryRow.PKInvoiceID <> CurrentInvoice Then
                            'new invoice has begun, add counter to the number of fish invoices
                            KeyValueDictionary("FishInvoiceCount") += 1
                            CurrentInvoice = NonInventoryRow.PKInvoiceID
                        End If
                    Case "Caviar" 'caviar invoice
                        Select Case NonInventoryRow.Product_Name
                            Case "CaviarCredit"
                                KeyValueDictionary("CaviarCredit") += CDbl(NonInventoryRow.PriceSoldAt)
                        End Select
                        If NonInventoryRow.Shipping Then 'record the shipping costs
                            KeyValueDictionary("CaviarFreight") += NonInventoryRow.PriceSoldAt
                        End If
                End Select
            Next

            'get male fish hparvests
            For Each MaleHarvestRow As SturgeonDBDataSet.MaleFishHarvestRow In MaleHarvestRows
                KeyValueDictionary("MaleLiveWtHarvested") += MaleHarvestRow.TotalLiveWeight
            Next
            'get female fish harvets
            For Each FemaleHarvestRow As SturgeonDBDataSet.Caviar_FishRow In FemaleHarvestRows
                KeyValueDictionary("FemaleLiveWtHarvested") += FemaleHarvestRow.Live_Wt
            Next
            KeyValueDictionary("LiveWeightHarvested") = KeyValueDictionary("MaleLiveWtHarvested") + KeyValueDictionary("FemaleLiveWtHarvested")

            'get female inventory
            Dim FemaleInventoryAfter As Double = 0.0 'assume no inventory if data is missing
            Dim FemaleInventoryBefore As Double = 0.0 'assume no inventory if data is missing

            If FemaleInventoryAfterRows.Count > 0 Then
                'get the last inventory entered during the period and that is the inventory for this period
                FemaleInventoryAfter = FemaleInventoryAfterRows(FemaleInventoryAfterRows.Count - 1).InventoryGuttedWeight
                KeyValueDictionary("FemaleGuttedWeightInventory") = FemaleInventoryAfter
            End If
            If FemaleInventoryBeforeRows.Count > 0 Then
                'get the last inventory entered in the week before this period
                FemaleInventoryBefore = FemaleInventoryBeforeRows(FemaleInventoryBeforeRows.Count - 1).InventoryGuttedWeight
            End If


            'calculate whole gutted weight equivalent from sales
            KeyValueDictionary("WholeGuttedSold") = Math.Round(KeyValueDictionary("FilletWt") / ConversionConstants.FilletShrinkageCorrection, 0) / ConversionConstants.FilletToCWG '* 0.453592 
            KeyValueDictionary("WholeGuttedSold") += Math.Round(KeyValueDictionary("BulletWt") / ConversionConstants.BulletShrinkageCorrection, 0) / ConversionConstants.BulletToCWG '* 0.453592
            KeyValueDictionary("WholeGuttedSold") += Math.Round(KeyValueDictionary("WholeGuttedWt") / ConversionConstants.WholeGuttedShrinkageCorrection, 0) '* 0.453592
            'KeyValueDictionary("LiveWeightEquivalent") = KeyValueDictionary("WholeGuttedSold") * ConversionConstants.CWGToCLF

            'calculate gutted weight equivalents for each sed from live fish harvests and inventory
            KeyValueDictionary("MaleLiveWtSold") = KeyValueDictionary("MaleLiveWtHarvested")
            KeyValueDictionary("FemaleLiveWtSold") = Math.Max(KeyValueDictionary("FemaleLiveWtHarvested") + ((FemaleInventoryBefore - FemaleInventoryAfter) * ConversionConstants.FemaleCWGToCLF * 0.453592), 0)

            'KeyValueDictionary("FishSales") = KeyValueDictionary("BulletSales") + KeyValueDictionary("FilletSales") + KeyValueDictionary("WholeGuttedSales")
            'KeyValueDictionary("FishTot") = KeyValueDictionary("FishSales") + KeyValueDictionary("FishFreight") + KeyValueDictionary("FishCredit")
            'KeyValueDictionary("CaviarTot") = KeyValueDictionary("CaviarFreight") + KeyValueDictionary("CaviarSales") + KeyValueDictionary("CaviarCredit")
            'KeyValueDictionary("TotalSales") = KeyValueDictionary("FishTot") + KeyValueDictionary("CaviarTot")
            PopulateExcel()
        End Using
    End Sub


    Private Sub IntializeDictionary()
        KeyValueDictionary.Clear()

        'dates
        KeyValueDictionary.Add("BeginDate", BeginDateTimePicker.Value)
        KeyValueDictionary.Add("EndDate", EndDateTimePicker.Value)

        'caviar data
        KeyValueDictionary.Add("CaviarInvoiceCount", New Integer)

        KeyValueDictionary.Add("AWt", New Double)
        KeyValueDictionary.Add("ASales", New Double)
        KeyValueDictionary.Add("ASampleWt", New Double)
        'KeyValueDictionary.Add("ATotalWt", New Double)

        KeyValueDictionary.Add("BWt", New Double)
        KeyValueDictionary.Add("BSales", New Double)
        KeyValueDictionary.Add("BSampleWt", New Double)
        'KeyValueDictionary.Add("BTotalWt", New Double)

        KeyValueDictionary.Add("CWt", New Double)
        KeyValueDictionary.Add("CSales", New Double)
        KeyValueDictionary.Add("CSampleWt", New Double)
        'KeyValueDictionary.Add("CTotalWt", New Double)

        KeyValueDictionary.Add("DWt", New Double)
        KeyValueDictionary.Add("DSales", New Double)
        KeyValueDictionary.Add("DSampleWt", New Double)
        'KeyValueDictionary.Add("DTotalWt", New Double)

        KeyValueDictionary.Add("KWt", New Double)
        KeyValueDictionary.Add("KSales", New Double)
        KeyValueDictionary.Add("KSampleWt", New Double)

        'KeyValueDictionary.Add("CaviarWt", New Double)
        'KeyValueDictionary.Add("CaviarSales", New Double)

        KeyValueDictionary.Add("CaviarFreight", New Double)
        KeyValueDictionary.Add("CaviarCredit", New Double)
        'KeyValueDictionary.Add("CaviarTot", New Double)

        'fish data
        KeyValueDictionary.Add("FishInvoiceCount", New Integer)
        'KeyValueDictionary.Add("FishSales", New Double)

        KeyValueDictionary.Add("WholeGuttedWt", New Double)
        KeyValueDictionary.Add("WholeGuttedSampleWt", New Double)
        KeyValueDictionary.Add("WholeGuttedSales", New Double)

        KeyValueDictionary.Add("BulletWt", New Double)
        KeyValueDictionary.Add("BulletSampleWt", New Double)
        KeyValueDictionary.Add("BulletSales", New Double)

        KeyValueDictionary.Add("FilletWt", New Double)
        KeyValueDictionary.Add("FilletSampleWt", New Double)
        KeyValueDictionary.Add("FilletSales", New Double)

        KeyValueDictionary.Add("FishFreight", New Double)
        KeyValueDictionary.Add("FishCredit", New Double)
        'KeyValueDictionary.Add("FishTot", New Double)
        KeyValueDictionary.Add("WholeGuttedSold", New Double)

        'fish harvests
        KeyValueDictionary.Add("MaleLiveWtHarvested", New Double)
        KeyValueDictionary.Add("FemaleLiveWtHarvested", New Double)
        KeyValueDictionary.Add("LiveWeightHarvested", New Double)

        'estimated sales by sex
        KeyValueDictionary.Add("MaleLiveWtSold", New Double)
        KeyValueDictionary.Add("FemaleLiveWtSold", New Double)

        'female inventory
        KeyValueDictionary.Add("FemaleGuttedWeightInventory", New Double)

        'misc
        KeyValueDictionary.Add("MiscSales", New Double)

        'grandtotal
        'KeyValueDictionary.Add("TotalSales", New Double)
    End Sub

    Private Sub PopulateExcel()
        Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Open(My.Application.Info.DirectoryPath & "\Excel Templates\Sales Report.xlsx")
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