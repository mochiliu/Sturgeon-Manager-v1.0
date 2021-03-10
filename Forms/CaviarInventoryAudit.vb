Imports Microsoft.Office.Interop.Excel
'This form is used to conduct periodic audits of caviar inventory


Public Class CaviarInventoryAudit
    Public CaviarNoted As New List(Of Integer) 'flagged for error
    Public CaviarInDB As New List(Of Integer) 'caviar that exists in the database and is not missing (although not necessarily error free)
    Public CaviarAccepted As New List(Of Integer) 'caviar that is error free
    Public CaviarExtra As New List(Of Integer) 'extra caviar turned up
    Public CaviarNotInDB As New List(Of Integer) 'barcode not in db
    Public CaviarMissing As New List(Of Integer) 'caviar in inventory but never scanned
    Public LastAcceptedBarcode As Integer = -1 'if this value is >0 when the next barcode is scanned, the 
    Public MissingDGVSelecteIndex As Integer = -1
    Public LoadingSelection As Boolean = False
    Public KeyValueDictionary As New Dictionary(Of String, Object)
    Public myEndAuditOption As EndAuditOptions
    Public Enum EndAuditOptions
        EndAudit
        CancelEndAudit
        QuitAudit
    End Enum


    Private Sub CaviarInventoryAudit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshMissingDGV()
        RefreshNotesDGV()
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.GradeSelection' table. You can move, or remove it, as needed.
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarStatusSelection' table. You can move, or remove it, as needed.
        Me.CaviarStatusSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarStatusSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarInventoryJoinCaviarFish' table. You can move, or remove it, as needed.
        Me.CaviarInventoryJoinCaviarFishTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarInventoryJoinCaviarFish)


        IntializeDictionary()
        ResetMissingDGVSelection()
        BarcodeInput.Focus()
    End Sub

    'Barcodes will be read here. The formmating is "COMMAND:VALUE"
    Private Sub BarcodeInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BarcodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then 'enter key is pressed
            AcceptButton_Click(Nothing, Nothing)

            If IsNumeric(BarcodeInput.Text) Then
                Dim Barcode As Integer = Convert.ToInt32(BarcodeInput.Text)
                Dim ContainerRow As SturgeonDBDataSet.CaviarInventoryJoinCaviarFishRow = SturgeonDBDataSet.CaviarInventoryJoinCaviarFish.FindByPKBarcode(Barcode)
                If IsNothing(ContainerRow) Then
                    'no barcode in the database
                    CaviarNotInDB.Add(Barcode)
                    RefreshFoundList()
                    SpeakText("Barcode not found in database", AudioSpeedTrackBar.Value)
                    BarcodeInput.BackColor = Color.Orange
                Else
                    'barcode is in the database
                    Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(ContainerRow.FKProductID)
                    Dim StatusRow As SturgeonDBDataSet.CaviarStatusSelectionRow = SturgeonDBDataSet.CaviarStatusSelection.FindByPKStatusID(ContainerRow.InventoryStatus)
                    Dim Acceptable As Boolean = True

                    If StatusRow.Description = "In Inventory" Then
                        'in inventory, there is no need to speak the status
                    Else
                        'not in inventory, speak the status, automatically flag
                        SpeakText(StatusRow.Description, AudioSpeedTrackBar.Value)
                        Flag(Barcode, "In Inventory but marked as " & StatusRow.Description)
                        CaviarExtra.Add(Barcode)
                        Acceptable = False
                    End If

                    SpeakProductCode(ProductRow.Product_Name, AudioSpeedTrackBar.Value)

                    If CaviarInDB.Contains(Barcode) Then
                        'duplicate found, prompt if need to flag, add it to extras
                        SpeakText("Item already scanned", AudioSpeedTrackBar.Value)
                        If MsgBox("Is this item an duplicate?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
                            Flag(Barcode, "Duplicate Found")
                            CaviarExtra.Add(Barcode)
                            Acceptable = False
                        End If
                    End If

                    CaviarInDB.Add(Barcode) ' add the item as scanned

                    If Acceptable Then
                        'no errors detected so far
                        LastAcceptedBarcode = Barcode
                        BarcodeInput.BackColor = Color.Green
                        SelectContainer(Barcode)
                        AcceptButton.Enabled = True
                        NoteButton.Enabled = True
                        EndAuditButton.Enabled = False
                    Else
                        BarcodeInput.BackColor = Color.Orange
                    End If
                End If

            Else
                'invalid barcode, not numeric input
                SpeakText("Invalid Barcode", AudioSpeedTrackBar.Value)
                BarcodeInput.BackColor = Color.Red
            End If
            BarcodeInput.Text = ""
        End If
    End Sub

#Region "Helper Subs"
    Private Sub IntializeDictionary()
        KeyValueDictionary.Clear()
        KeyValueDictionary.Add("AuditDate", Date.Now)
        KeyValueDictionary.Add("MissingCount", New Integer)
        KeyValueDictionary.Add("MissingKg", New Double)
        KeyValueDictionary.Add("ExtraCount", New Integer)
        KeyValueDictionary.Add("ExtraKg", New Double)
    End Sub


    'this selects only the the flagged caviar to display
    Public Sub RefreshNotesDGV()
        'Display only the selected items
        Dim FilterString As String = "PKBarcode = -1" 'display nothing to begin
        For Each Value As Integer In CaviarNoted
            FilterString = FilterString & " OR PKBarcode = " & Value.ToString
        Next
        NotesCaviarInventoryJoinCaviarFishBindingSource.Filter = FilterString
    End Sub

    Public Sub RefreshMissingDGV()
        'Display only the items in inventory but not scanned
        LoadingSelection = True
        Dim FilterString As String = "[InventoryStatus] = 1 AND (PKBarcode <> -1" 'display all items in inventory
        For Each Value As Integer In CaviarInDB
            FilterString = FilterString & " AND PKBarcode <> " & Value.ToString
        Next
        FilterString = FilterString & ")"
        MissingCaviarInventoryJoinCaviarFishBindingSource.Filter = FilterString
        LoadingSelection = False
    End Sub

    Public Sub RefreshFoundList()
        NotFoundTextBox.Text = ""
        For Each Value As Integer In CaviarNotInDB
            NotFoundTextBox.Text = NotFoundTextBox.Text & Chr(13) & Value.ToString
        Next
    End Sub


    Public Sub Flag(ByVal Barcode As Integer, ByVal Reason As String)
        If CaviarNoted.Contains(Barcode) Then
            'has already been noted
            SpeakText("Item Flagged Again", AudioSpeedTrackBar.Value)
        Else
            'new caviar to be noted
            CaviarNoted.Add(Barcode)
            RefreshNotesDGV()
            SpeakText("New Item Flagged", AudioSpeedTrackBar.Value)
        End If
        For Each Row As DataGridViewRow In NotesCaviarInventoryJoinCaviarFishMyDataGridView.Rows
            If Row.Cells("NotesPKBarcodeColumn").Value = Barcode Then
                'barcode found
                Dim Note As String = ""
                If IsDBNull(Row.Cells("NotesNotesColumn").Value) OrElse Row.Cells("NotesNotesColumn").Value = "" Then
                    Note = Date.Now.ToShortDateString & " Audit: " & Reason
                Else
                    Note = Row.Cells("NotesNotesColumn").Value & " , " & Date.Now.ToShortDateString & " Audit: " & Reason
                End If
                Dim Response As String = InputBox("Please update the note to resolve the error later", "Caviar Note", Note)
                Row.Cells("NotesNotesColumn").Value = Response
                AcceptButton.Enabled = False
                NoteButton.Enabled = False
                EndAuditButton.Enabled = True
                Exit For
            End If
        Next
    End Sub

    Public Sub ResetMissingDGVSelection() 'makes the dgv select nothing
        LoadingSelection = True
        MissingDGVSelecteIndex = -1
        MissingCaviarInventoryJoinCaviarFishMyDataGridView.ClearSelection()
        LoadingSelection = False
    End Sub

#End Region

#Region "Button Events"

    Private Sub AcceptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcceptButton.Click
        If LastAcceptedBarcode > 0 Then
            'accept the last barcode accepted
            CaviarAccepted.Add(LastAcceptedBarcode)
            RefreshMissingDGV()
            ResetMissingDGVSelection()
            AcceptButton.Enabled = False
            NoteButton.Enabled = False
            EndAuditButton.Enabled = True
        End If
    End Sub

    Private Sub NoteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoteButton.Click
        If LastAcceptedBarcode > 0 AndAlso MsgBox("Flag this item?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
            'flag the item
            Flag(LastAcceptedBarcode, "")
            LastAcceptedBarcode = -1
            ResetMissingDGVSelection()
        End If
    End Sub


    Private Sub EndAuditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndAuditButton.Click
        myEndAuditOption = EndAuditOptions.CancelEndAudit
        EndAuditOption.ShowDialog()
        If myEndAuditOption = EndAuditOptions.EndAudit Then
            Using (New WaitCursor) 'Load Hourglass

                Try
                    'save the flagged items
                    Me.Validate()
                    Me.NotesCaviarInventoryJoinCaviarFishBindingSource.EndEdit()
                    Me.CaviarInventoryJoinCaviarFishTableAdapter.Update(SturgeonDBDataSet.CaviarInventoryJoinCaviarFish)
                    Me.CaviarInventoryJoinCaviarFishTableAdapter.Fill(SturgeonDBDataSet.CaviarInventoryJoinCaviarFish)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try

                'calculate the dictionary variables
                'count everything not in the freezer but appears to be "in inventory", and put in the notes field as missing
                For Each Row As DataGridViewRow In MissingCaviarInventoryJoinCaviarFishMyDataGridView.Rows
                    Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(Row.Cells("MissingFKProductIDColumn").Value)
                    If ProductRow IsNot Nothing Then
                        KeyValueDictionary("MissingKg") += ProductRow.UnitWeightgms / 1000
                        KeyValueDictionary("MissingCount") += 1
                    End If
                    If IsDBNull(Row.Cells("MissingNotesColumn").Value) OrElse Row.Cells("MissingNotesColumn").Value = "" Then
                        Row.Cells("MissingNotesColumn").Value = Date.Now.ToShortDateString & " Audit: Not In Freezer"
                    Else
                        Row.Cells("MissingNotesColumn").Value = Row.Cells("MissingNotesColumn").Value & " , " & Date.Now.ToShortDateString & " Audit: Not In Freezer"
                    End If
                Next

                Try
                    'save the items marked as missing
                    Me.Validate()
                    Me.MissingCaviarInventoryJoinCaviarFishBindingSource.EndEdit()
                    Me.CaviarInventoryJoinCaviarFishTableAdapter.Update(SturgeonDBDataSet.CaviarInventoryJoinCaviarFish)
                    Me.CaviarInventoryJoinCaviarFishTableAdapter.Fill(SturgeonDBDataSet.CaviarInventoryJoinCaviarFish)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try

                'count everything extra
                For Each ExtraContainerBarcode As Integer In CaviarExtra
                    Dim ContainerRow As SturgeonDBDataSet.CaviarInventoryJoinCaviarFishRow = SturgeonDBDataSet.CaviarInventoryJoinCaviarFish.FindByPKBarcode(ExtraContainerBarcode)
                    Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(ContainerRow.FKProductID)
                    If ProductRow IsNot Nothing Then
                        KeyValueDictionary("ExtraKg") += ProductRow.UnitWeightgms / 1000
                        KeyValueDictionary("ExtraCount") += 1
                    End If
                Next

                'load the excel template
                Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.ApplicationClass
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Open(My.Application.Info.DirectoryPath & "\Excel Templates\Audit Report.xlsx")
                Try
                    My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\Excel Templates\Temp.xlsx", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                Catch ex As Exception
                End Try
                xlWorkBook.SaveAs(My.Application.Info.DirectoryPath & "\Excel Templates\Temp.xlsx")

                'load the summary sheet
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = xlWorkBook.Sheets("Summary")
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
                                        'key not found, skip
                                        Continue For
                                    End If
                                Loop
                                .Cells(i, j) = FinalText
                            End If
                        Next
                    Next
                End With

                'load the not found in freezer sheet
                xlWorkSheet = xlWorkBook.Sheets("Not Found In Freezer")
                With xlWorkSheet
                    'find the last column and row
                    Dim lCol As Integer = .UsedRange.SpecialCells(XlCellType.xlCellTypeLastCell).Column
                    Dim lRow As Integer = .UsedRange.SpecialCells(XlCellType.xlCellTypeLastCell).Row
                    Dim BeginCol As Integer = 1
                    Dim BeginRow As Integer = 1
                    'load the keywords
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
                                    ElseIf Key = "Begin" Then
                                        BeginCol = j
                                        BeginRow = i
                                        Continue For
                                    Else
                                        'key not found, skip
                                        Continue For
                                    End If
                                Loop
                                .Cells(i, j) = FinalText
                            End If
                        Next
                    Next
                    'load the datagridview
                    For Each column As DataGridViewColumn In MissingCaviarInventoryJoinCaviarFishMyDataGridView.Columns
                        .Cells(BeginRow, column.Index + BeginCol) = column.HeaderText
                    Next
                    For i = 1 To MissingCaviarInventoryJoinCaviarFishMyDataGridView.RowCount
                        If MissingCaviarInventoryJoinCaviarFishMyDataGridView.Rows(i - 1).IsNewRow Then 'skip displaying the new row
                            Continue For
                        End If
                        For j = 0 To MissingCaviarInventoryJoinCaviarFishMyDataGridView.Columns.Count - 1
                            .Cells(i + BeginRow, j + BeginCol) = MissingCaviarInventoryJoinCaviarFishMyDataGridView.Rows(i - 1).Cells(j).FormattedValue
                        Next
                    Next
                End With

                'load the extra found in freezer dgv
                xlWorkSheet = xlWorkBook.Sheets("Extras In Freezer")
                With xlWorkSheet
                    'find the last column and row
                    Dim lCol As Integer = .UsedRange.SpecialCells(XlCellType.xlCellTypeLastCell).Column
                    Dim lRow As Integer = .UsedRange.SpecialCells(XlCellType.xlCellTypeLastCell).Row
                    Dim BeginCol As Integer = 1
                    Dim BeginRow As Integer = 1
                    'load the keywords
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
                                    ElseIf Key = "Begin" Then
                                        BeginCol = j
                                        BeginRow = i
                                        Continue For
                                    Else
                                        'key not found, skip
                                        Continue For
                                    End If
                                Loop
                                .Cells(i, j) = FinalText
                            End If
                        Next
                    Next
                    'load the datagridview
                    For Each column As DataGridViewColumn In NotesCaviarInventoryJoinCaviarFishMyDataGridView.Columns
                        .Cells(BeginRow, column.Index + BeginCol) = column.HeaderText
                    Next
                    Dim CurrentExcelRow As Integer = BeginRow + 1
                    For i = 1 To NotesCaviarInventoryJoinCaviarFishMyDataGridView.RowCount
                        If NotesCaviarInventoryJoinCaviarFishMyDataGridView.Rows(i - 1).IsNewRow Then 'skip displaying the new row
                            Continue For
                        End If
                        If CaviarExtra.Contains(NotesCaviarInventoryJoinCaviarFishMyDataGridView.Rows(i - 1).Cells("NotesPKBarcodeColumn").Value) Then
                            'only export the rows that are marked as extra
                            For j = 0 To NotesCaviarInventoryJoinCaviarFishMyDataGridView.Columns.Count - 1
                                .Cells(CurrentExcelRow, j + BeginCol) = NotesCaviarInventoryJoinCaviarFishMyDataGridView.Rows(i - 1).Cells(j).FormattedValue
                            Next
                            CurrentExcelRow += 1
                        End If
                    Next
                End With

                'load the other flagged items
                xlWorkSheet = xlWorkBook.Sheets("Other Flagged Containers")
                With xlWorkSheet
                    'find the last column and row
                    Dim lCol As Integer = .UsedRange.SpecialCells(XlCellType.xlCellTypeLastCell).Column
                    Dim lRow As Integer = .UsedRange.SpecialCells(XlCellType.xlCellTypeLastCell).Row
                    Dim BeginCol As Integer = 1
                    Dim BeginRow As Integer = 1
                    'load the keywords
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
                                    ElseIf Key = "Begin" Then
                                        BeginCol = j
                                        BeginRow = i
                                        Continue For
                                    Else
                                        'key not found, skip
                                        Continue For
                                    End If
                                Loop
                                .Cells(i, j) = FinalText
                            End If
                        Next
                    Next
                    'load the datagridview
                    For Each column As DataGridViewColumn In NotesCaviarInventoryJoinCaviarFishMyDataGridView.Columns
                        .Cells(BeginRow, column.Index + BeginCol) = column.HeaderText
                    Next
                    Dim CurrentExcelRow As Integer = BeginRow + 1
                    For i = 1 To NotesCaviarInventoryJoinCaviarFishMyDataGridView.RowCount
                        If NotesCaviarInventoryJoinCaviarFishMyDataGridView.Rows(i - 1).IsNewRow Then 'skip displaying the new row
                            Continue For
                        End If
                        If Not CaviarExtra.Contains(NotesCaviarInventoryJoinCaviarFishMyDataGridView.Rows(i - 1).Cells("NotesPKBarcodeColumn").Value) Then
                            'only export the rows that are flagged but are not extra
                            For j = 0 To NotesCaviarInventoryJoinCaviarFishMyDataGridView.Columns.Count - 1
                                .Cells(CurrentExcelRow, j + BeginCol) = NotesCaviarInventoryJoinCaviarFishMyDataGridView.Rows(i - 1).Cells(j).FormattedValue
                            Next
                            CurrentExcelRow += 1
                        End If
                    Next
                End With

                'load barcodes that are not found in the database
                xlWorkSheet = xlWorkBook.Sheets("Barcode Not In DB")
                With xlWorkSheet
                    'find the last column and row
                    Dim lCol As Integer = .UsedRange.SpecialCells(XlCellType.xlCellTypeLastCell).Column
                    Dim lRow As Integer = .UsedRange.SpecialCells(XlCellType.xlCellTypeLastCell).Row
                    Dim BeginCol As Integer = 1
                    Dim BeginRow As Integer = 1
                    'load the keywords
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
                                    ElseIf Key = "Begin" Then
                                        BeginCol = j
                                        BeginRow = i
                                        Continue For
                                    Else
                                        'key not found, skip
                                        Continue For
                                    End If
                                Loop
                                .Cells(i, j) = FinalText
                            End If
                        Next
                    Next
                    'load the barcodes not found
                    Dim CurrentExcelRow As Integer = BeginRow
                    If CaviarNotInDB.Count = 0 Then
                        .Cells(CurrentExcelRow, BeginCol) = "None"
                    Else
                        For Each BarcodeNotFound As Integer In CaviarNotInDB
                            .Cells(CurrentExcelRow, BeginCol) = BarcodeNotFound
                            CurrentExcelRow += 1
                        Next
                    End If
                End With

                xlApp.Visible = True 'show the excel form

            End Using
            Me.Close()
        ElseIf myEndAuditOption = EndAuditOptions.QuitAudit Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "Selection Events"
    Public Sub SelectContainer(ByVal Barcode As Integer)
        MissingDGVSelecteIndex = -1
        For Each Row As DataGridViewRow In MissingCaviarInventoryJoinCaviarFishMyDataGridView.Rows
            If Row.Cells("MissingPKBarcodeColumn").Value = Barcode Then
                'barcode found
                Row.Selected = True
                MissingDGVSelecteIndex = Row.Index
                Exit For
            End If
        Next
        MissingCaviarInventoryJoinCaviarFishMyDataGridView_SelectionChanged(Nothing, Nothing) 'update selection
        If MissingDGVSelecteIndex > 0 Then
            'move the scrolled to item to newly found item
            MissingCaviarInventoryJoinCaviarFishMyDataGridView.FirstDisplayedScrollingRowIndex = MissingDGVSelecteIndex
        End If
    End Sub
    Private Sub MissingCaviarInventoryJoinCaviarFishMyDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MissingCaviarInventoryJoinCaviarFishMyDataGridView.SelectionChanged
        If Not LoadingSelection Then
            LoadingSelection = True 'make sure this event does not call itself

            If MissingDGVSelecteIndex = -1 Then 'there should be nothing selected
                MissingCaviarInventoryJoinCaviarFishMyDataGridView.ClearSelection()
            Else
                MissingCaviarInventoryJoinCaviarFishMyDataGridView.Rows(MissingDGVSelecteIndex).Selected = True
            End If
            LoadingSelection = False
        End If
    End Sub
#End Region

End Class