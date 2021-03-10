'this form allows the user to process returns and repacks

Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Drawing.Printing

Public Class RepackReturns
    Public MyOperationMode As OperationMode = OperationMode.CaviarRepack
    Public SelectedBarcode As Integer = -1
    Public pd As New PrintDialog()
    Public NewCaviarItems As New List(Of Integer) 'keeps track of the new barcodes added

    Public Enum OperationMode
        CaviarRepack = 1
        CaviarReturn = 2
    End Enum

    Private Sub RepackReturns_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not (CompleteButton.Enabled = False And PrintButton.Enabled = True) Then
            If MsgBox("There may be unsaved changes made, exit anyway?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub RepackReturns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.RepackLoss' table. You can move, or remove it, as needed.
        Me.RepackLossTableAdapter.Fill(Me.SturgeonDBDataSet.RepackLoss)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarStatusSelection' table. You can move, or remove it, as needed.
        Me.CaviarStatusSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarStatusSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Inventory' table. You can move, or remove it, as needed.
        Me.Caviar_InventoryTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Inventory)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.GradeSelection' table. You can move, or remove it, as needed.
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Fish' table. You can move, or remove it, as needed.
        Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)

        Caviar_FishBindingSource.Filter = "PKFishID = -1"
        ProductsBindingSource.Filter = "[ProductCategory] = 1"
    End Sub

    'changes the display properties of the form to match the intended purpose
    Public Sub SetMode(ByVal Mode As OperationMode)
        MyOperationMode = Mode
        Select Case MyOperationMode
            Case OperationMode.CaviarRepack
                Me.Text = "Repack"
                AddButton.Visible = True
                Label2.Visible = True
                CountToAddNumericUpDown.Visible = True
                CompleteButton.Text = "Complete Repack"
                RepackDisplayDataGridView.Visible = True
                Label3.Visible = True
                DifferenceTextBox.Visible = True
                Label4.Visible = True
                RepackContainerSizeTextBox.Visible = True
            Case OperationMode.CaviarReturn
                Me.Text = "Return"
                AddButton.Visible = False
                Label2.Visible = False
                CountToAddNumericUpDown.Visible = False
                CompleteButton.Text = "Complete Return"
                RepackDisplayDataGridView.Visible = False
                Label3.Visible = False
                DifferenceTextBox.Visible = False
                Label4.Visible = False
                RepackContainerSizeTextBox.Visible = False
        End Select
        BarcodeTextBox.Focus()
    End Sub

    Private Sub BarcodeTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BarcodeTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then 'enter key is pressed
            If IsNumeric(BarcodeTextBox.Text) Then 'new barcode is scanned
                SelectBarcode(Convert.ToInt32(BarcodeTextBox.Text))
            End If
        End If
    End Sub

    'this sub selects a barcode for repack or return processing
    Public Sub SelectBarcode(ByVal Barcode As Integer)
        Dim BarcodeFound As Boolean = False

        If Not IsNothing(SturgeonDBDataSet.Caviar_Inventory.FindByPKBarcode(Barcode)) Then        'check if the barcode is valid
            'Get data related to the barcode
            Dim ContainerRow As SturgeonDBDataSet.Caviar_InventoryRow = SturgeonDBDataSet.Caviar_Inventory.FindByPKBarcode(Barcode)
            Dim CaviarStatusRow As SturgeonDBDataSet.CaviarStatusSelectionRow = ContainerRow.CaviarStatusSelectionRow
            If CaviarStatusRow.Description = "In Inventory" And MyOperationMode = OperationMode.CaviarRepack Then
                'Do nothing (continue)
            ElseIf CaviarStatusRow.Description = "Sold" And MyOperationMode = OperationMode.CaviarReturn Then
                'Do nothing (continue)
            Else
                'the current inventory status does not match expectation
                Select Case MyOperationMode
                    Case OperationMode.CaviarRepack
                        MsgBox("The item cannot be repacked because the status is " & CaviarStatusRow.Description)
                        GoTo ErrorFindingBarcode
                    Case OperationMode.CaviarReturn
                        MsgBox("The item cannot be returned because the status is " & CaviarStatusRow.Description)
                        GoTo ErrorFindingBarcode
                End Select
            End If

            'select the correct fish
            Caviar_FishBindingSource.Filter = "PKFishID = " & ContainerRow.FKFishID

            For Each Entry As DataGridViewRow In Caviar_InventoryDataGridView.Rows
                If Entry.Cells("PKBarcodeColumn").Value = Barcode Then 'the entry is found
                    Entry.Selected = True
                    Caviar_InventoryDataGridView.FirstDisplayedScrollingRowIndex = Entry.Index
                    SelectedBarcode = Barcode
                    Product_NameComboBox.SelectedValue = ContainerRow.FKProductID
                    BarcodeFound = True
                    Exit For
                End If
            Next
        Else

        End If

        If BarcodeFound = True Then
            ConfirmBarcodeButton.Enabled = True
            NotesTextBox.Enabled = False
            Product_NameComboBox.Enabled = False
            CountToAddNumericUpDown.Enabled = False
            AddButton.Enabled = False
            CompleteButton.Enabled = False
            PrintButton.Enabled = False
            ConfirmBarcodeButton.Focus()
        Else
ErrorFindingBarcode:

            SelectedBarcode = -1
            Caviar_FishBindingSource.Filter = "PKFishID = -1"
            ConfirmBarcodeButton.Enabled = False
            NotesTextBox.Enabled = False
            Product_NameComboBox.Enabled = False
            CountToAddNumericUpDown.Enabled = False
            AddButton.Enabled = False
            CompleteButton.Enabled = False
            PrintButton.Enabled = False
            BarcodeTextBox.SelectAll()
        End If

        NewCaviarItems.Clear()
    End Sub

    Public Function GetBarcode() As Integer
        Dim LargesBarcode As Integer = 0
        Dim I As Integer = 0
        For I = 0 To SturgeonDBDataSet.Caviar_Inventory.Count - 1
            If SturgeonDBDataSet.Caviar_Inventory.Rows(I).Item("PKBarcode") > LargesBarcode Then
                LargesBarcode = SturgeonDBDataSet.Caviar_Inventory.Rows(I).Item("PKBarcode")
            End If
        Next
        Return LargesBarcode + 1
    End Function

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        For I = 1 To CountToAddNumericUpDown.Value
            Try
                Caviar_InventoryBindingSource.AddNew()
            Catch ex As Exception
                'vbNull to integer exception
            End Try

            Caviar_InventoryDataGridView.CurrentRow.Cells("PKBarcodeColumn").Value = GetBarcode()
            Caviar_InventoryDataGridView.CurrentRow.Cells("FKProductIDColumn").Value = Product_NameComboBox.SelectedValue
            Caviar_InventoryDataGridView.CurrentRow.Cells("CurrentStatusColumn").Value = 1 'in inventory
            Caviar_InventoryDataGridView.CurrentRow.Cells("DateStatusChangedColumn").Value = Date.Now

            Select Case MyOperationMode
                Case OperationMode.CaviarRepack
                    Caviar_InventoryDataGridView.CurrentRow.Cells("PreviousStatusColumn").Value = 3 'repacked
                    Caviar_InventoryDataGridView.CurrentRow.Cells("InventoryNotesColumn").Value = Convert.ToString(Caviar_InventoryDataGridView.CurrentRow.Cells("InventoryNotesColumn").Value & " Repackaged from barcode " & SelectedBarcode & ".").Trim
                Case OperationMode.CaviarReturn
                    Caviar_InventoryDataGridView.CurrentRow.Cells("PreviousStatusColumn").Value = 8 'sold but returned
                    Caviar_InventoryDataGridView.CurrentRow.Cells("InventoryNotesColumn").Value = Convert.ToString(Caviar_InventoryDataGridView.CurrentRow.Cells("InventoryNotesColumn").Value & " Returned from barcode " & SelectedBarcode & ".").Trim
            End Select
        Next
        CountToAddNumericUpDown.Value = 1

        RefreshQuickSummary()

    End Sub

    Public Function Save() As Boolean
        Using (New WaitCursor)
            Try
                Caviar_InventoryBindingSource.AddNew() 'the last item is not saved for some reason, so add a placeholder
                Caviar_InventoryBindingSource.RemoveCurrent() 'delete the newly added item
                Me.Validate()
                Me.Caviar_FishBindingSource.EndEdit()
                Me.Caviar_InventoryBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Return True
        End Using
    End Function

    Private Sub ConfirmBarcodeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmBarcodeButton.Click
        If SelectedBarcode > 0 Then
            NotesTextBox.Enabled = True
            Product_NameComboBox.Enabled = True
            CountToAddNumericUpDown.Enabled = True
            AddButton.Enabled = True
            CompleteButton.Enabled = True
            PrintButton.Enabled = False
            BarcodeTextBox.Enabled = False
            ConfirmBarcodeButton.Enabled = False

            'change the status of the barcode to be repacked or returned
            For Each Entry As DataGridViewRow In Caviar_InventoryDataGridView.Rows
                If Entry.Cells("PKBarcodeColumn").Value = SelectedBarcode Then 'the entry is found
                    Entry.Selected = True
                    Caviar_InventoryDataGridView.FirstDisplayedScrollingRowIndex = Entry.Index

                    Select Case MyOperationMode
                        Case OperationMode.CaviarRepack
                            Entry.Cells("CurrentStatusColumn").Value = 3 'repacked
                            RepackContainerSizeTextBox.Text = Entry.Cells("ContainerSizeColumn").FormattedValue
                        Case OperationMode.CaviarReturn
                            Entry.Cells("CurrentStatusColumn").Value = 8 'sold but returned
                    End Select

                    Entry.Cells("DateStatusChangedColumn").Value = Date.Now
                    'load the previous inventory status from the time last saved
                    Dim CaviarInventoryRow As SturgeonDBDataSet.Caviar_InventoryRow = SturgeonDBDataSet.Caviar_Inventory.FindByPKBarcode(SelectedBarcode)
                    Entry.Cells("PreviousStatusColumn").Value = CaviarInventoryRow("InventoryStatus", DataRowVersion.Original)

                    Exit For
                End If
            Next

            'if a inventory status is changed, store the time and the previous state


            Product_NameComboBox.Focus()
        End If
    End Sub

    Private Sub CompleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteButton.Click
        If MyOperationMode = OperationMode.CaviarReturn Then
            'there is no adding process for returns so add the new item here
            CountToAddNumericUpDown.Value = 1
            AddButton_Click(Nothing, Nothing)
        End If
        RefreshQuickSummary()

        If Save() Then
            If MyOperationMode = OperationMode.CaviarRepack Then
                'save the repack loss
                RepackLossTableAdapter.Insert(SelectedBarcode, Convert.ToDouble(DifferenceTextBox.Text))
            End If

            ConfirmBarcodeButton.Enabled = False
            NotesTextBox.Enabled = False
            Product_NameComboBox.Enabled = False
            CountToAddNumericUpDown.Enabled = False
            AddButton.Enabled = False
            CompleteButton.Enabled = False

            PrintButton.Enabled = True
        End If
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        pd.PrinterSettings = New PrinterSettings()
        pd.ShowDialog()
        For Each Item As DataRowView In Caviar_InventoryBindingSource.List
            If NewCaviarItems.Contains(Item("PKBarcode")) Then
                PrintLabel(Item, Caviar_FishBindingSource.Current, SturgeonDBDataSet.Products.FindByPKProductID(Item("FKProductID")).Item("Product Name"), pd)
            End If
        Next

        BarcodeTextBox.Enabled = True
        BarcodeTextBox.Focus()
    End Sub

    Public Sub RefreshQuickSummary()

        'update the caviar quick summary
        Dim GramsOfCaviar As Double = 0
        Dim DisplayedCaviarInventory As New Dictionary(Of Integer, CaviarSummaryEntry) 'caviar order is a dictionary of (productID, CaviarOrderSummaryEntry)

        Caviar_InventoryBindingSource.EndEdit() 'push the last row entered into the bindingsource
        NewCaviarItems.Clear() 'reset the new items list

        For I = 0 To Caviar_InventoryDataGridView.Rows.Count - 1
            With Caviar_InventoryDataGridView.Rows(I)
                Dim CaviarInventoryRow As SturgeonDBDataSet.Caviar_InventoryRow = SturgeonDBDataSet.Caviar_Inventory.FindByPKBarcode(.Cells("PKBarcodeColumn").Value)
                If CaviarInventoryRow.RowState = DataRowState.Added Then
                    'The datarow has just been added during repack/return, so count it
                    NewCaviarItems.Add(CaviarInventoryRow.PKBarcode)
                    Dim ProductRow As SturgeonDBDataSet.ProductsRow = SturgeonDBDataSet.Products.FindByPKProductID(.Cells("FKProductIDColumn").Value)
                    If DisplayedCaviarInventory.ContainsKey(ProductRow.PKProductID) Then
                        'product entry already exists, add a count
                        DisplayedCaviarInventory(ProductRow.PKProductID).Add()
                    Else
                        'product entry does not exist, add an entry
                        DisplayedCaviarInventory.Add(ProductRow.PKProductID, New CaviarSummaryEntry(ProductRow.Product_Name, ProductRow.UnitWeightgms, 0, ""))
                    End If
                End If
            End With

        Next

        'update the order display dgv
        RepackDisplayDataGridView.Rows.Clear()
        Dim CaviarInventoryTotal As CaviarSummaryEntry = New CaviarSummaryEntry("Repack Total", 0, 0, "", 0)
        Dim CaviarGradeSubTotal As CaviarSummaryEntry = New CaviarSummaryEntry("", 0, 0, "", 0)
        For Each Product As DataRow In SturgeonDBDataSet.Products
            'this adds the entries in the order of the product table
            If DisplayedCaviarInventory.ContainsKey(Product.Item("PKProductID")) Then
                Dim Entry As CaviarSummaryEntry = DisplayedCaviarInventory(Product.Item("PKProductID"))

                Dim GradeRow As DataRow = SturgeonDBDataSet.GradeSelection.FindByID(Product.Item("Grade"))
                If Not GradeRow.Item("Grade") = CaviarGradeSubTotal.ProductCode Then
                    'display the grade subtotal if the we are no longer in the same grade
                    If CaviarGradeSubTotal.ProductCode <> "" Then
                        RepackDisplayDataGridView.Rows.Add()
                        RepackDisplayDataGridView.Rows(RepackDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = "Grade " & CaviarGradeSubTotal.ProductCode & " Subtotal"
                        RepackDisplayDataGridView.Rows(RepackDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.Count
                        RepackDisplayDataGridView.Rows(RepackDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.TotalKgs
                    End If
                    'reinitialize
                    CaviarGradeSubTotal = New CaviarSummaryEntry(GradeRow.Item("Grade"), 0, 0, "", 0)
                End If

                RepackDisplayDataGridView.Rows.Add()
                'edit the last row added
                RepackDisplayDataGridView.Rows(RepackDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = Entry.ProductCode
                RepackDisplayDataGridView.Rows(RepackDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = Entry.Count
                RepackDisplayDataGridView.Rows(RepackDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = Entry.TotalKgs

                'add to subtotal is the entry is still in the same grade
                CaviarGradeSubTotal.Count += Entry.Count
                CaviarGradeSubTotal.TotalKgs += Entry.TotalKgs
                CaviarInventoryTotal.Count += Entry.Count
                CaviarInventoryTotal.TotalKgs += Entry.TotalKgs
            End If
        Next
        'display the total row and the last subtotal row (if it exists)
        Try
            If CaviarGradeSubTotal.ProductCode <> "" Then
                RepackDisplayDataGridView.Rows.Add()
                RepackDisplayDataGridView.Rows(RepackDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = "Grade " & CaviarGradeSubTotal.ProductCode & " Subtotal"
                RepackDisplayDataGridView.Rows(RepackDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.Count
                RepackDisplayDataGridView.Rows(RepackDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = CaviarGradeSubTotal.TotalKgs
            End If
            RepackDisplayDataGridView.Rows.Add()
            RepackDisplayDataGridView.Rows(RepackDisplayDataGridView.Rows.Count - 1).Cells("ProductNameCaviarOrderDisplayColumn").Value = CaviarInventoryTotal.ProductCode
            RepackDisplayDataGridView.Rows(RepackDisplayDataGridView.Rows.Count - 1).Cells("CountCaviarOrderDisplayColumn").Value = CaviarInventoryTotal.Count
            RepackDisplayDataGridView.Rows(RepackDisplayDataGridView.Rows.Count - 1).Cells("TotalKgsCaviarOrderDisplayColumn").Value = CaviarInventoryTotal.TotalKgs

            DifferenceTextBox.Text = Convert.ToDouble(RepackContainerSizeTextBox.Text) - (CaviarInventoryTotal.TotalKgs * 1000)
            'possible overpack or underpack code here
            If Convert.ToDouble(DifferenceTextBox.Text) < 0 Then
                'overpack
                DifferenceTextBox.BackColor = Color.Red
            ElseIf Convert.ToDouble(DifferenceTextBox.Text) / (CaviarInventoryTotal.TotalKgs * 1000) > 0.1 Then
                'underpack
                DifferenceTextBox.BackColor = Color.Red
            Else
                DifferenceTextBox.BackColor = Color.Green
            End If
        Catch ex As Exception
            'catches when the form first loads (before columns has been added)
        End Try
    End Sub

End Class