
'This form allows the user to enter fish and inventory data while at the "packing station" of the processing room
Public Class OldInventoryEntry
    Public FishCheckpoint As Boolean
    Public ProductCheckpoint As Boolean
    Public IsPrepacking As Boolean = False

#Region "Barcode Handling"
    'Barcodes will be read here. The formmating is "COMMAND:VALUE"
    Private Sub BarcodeInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BarcodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then 'enter key is pressed
            If IsNumeric(BarcodeInput.Text) Then 'new barcode is scanned
                If FishCheckpoint And ProductCheckpoint Then

                    'check if the barcode has been used
                    Dim I As Integer = 0
                    For I = 0 To SturgeonDBDataSet.Caviar_Inventory.Count - 1
                        If SturgeonDBDataSet.Caviar_Inventory.Rows(I).Item("PKBarcode") = Convert.ToInt32(BarcodeInput.Text) Then
                            MsgBox("Barcode already exists!")
                            BarcodeInput.Text = ""
                            BarcodeInput.BackColor = Color.Red
                            Exit Sub
                        End If
                    Next

                    Try
                        Caviar_InventoryBindingSource.AddNew()
                        CalculateTotalCaviar()
                    Catch ex As Exception
                        'vbNull to integer exception
                    End Try
                    PKBarcodeTextBox.Text = Convert.ToInt32(BarcodeInput.Text)
                    If IsPrepacking Then
                        InventoryStatusComboBox.SelectedValue = 5 'prepack
                    Else
                        InventoryStatusComboBox.SelectedValue = 1 'in inventory
                    End If
                    PreviousStatusComboBox.SelectedValue = 7 'harvested
                    DateStatusChangedDateTimePicker.Value = Harvest_DateDateTimePicker.Value
                    BarcodeInput.BackColor = Color.Lime
                Else
                    MsgBox("Information entered is not complete, please ensure all data is entered")
                    BarcodeInput.BackColor = Color.Red
                End If
            Else
                Dim ColonIndex = BarcodeInput.Text.IndexOf(":")
                If ColonIndex > -1 Then
                    'barcode input formmating recognized
                    Dim Command As String
                    Dim Value As String
                    Command = (BarcodeInput.Text.Split(":")(0)).ToUpper()
                    Value = (BarcodeInput.Text.Split(":")(1)).ToUpper()
                    ExecuteCommand(Command, Value)
                Else
                    'colon not found, assume it is a fish tag and filter
                    FishComplete()
                    Me.Caviar_FishBindingSource.Filter = "[Tag] like '%" & BarcodeInput.Text & "%'"
                    BarcodeInput.BackColor = Color.Lime
                End If
            End If
            BarcodeInput.Text = ""
        End If
    End Sub

    Public Sub ExecuteCommand(ByVal Command As String, ByVal Value As String)
        Select Case Command
            Case "END"
                FishComplete()
            Case "REFRESH"
                RefreshData()
            Case "SIZE"
                EggsizeTextBox.Text = Value
            Case "Size"
                EggsizeTextBox.Text = Value
            Case "FIRM"
                FirmnessTextBox.Text = Value
            Case "TASTE"
                TasteTextBox.Text = Value
            Case "GRADE"
                GradeComboBox.SelectedValue = IndexInDataRows(SturgeonDBDataSet.GradeSelection.Select(""), "Grade", "ID", Value)
            Case "PRDT"
                FKProductIDComboBox.SelectedValue = IndexInDataRows(SturgeonDBDataSet.Products.Select(""), "Product Name", "PKProductID", GradeComboBox.Text & Value)
            Case "COLOR"
                Egg_ColorTextBox.Text = Value
            Case "PREPACK"
                IsPrepacking = Not IsPrepacking 'toggle on and off
                If IsPrepacking Then
                    InventoryStatusComboBox.SelectedValue = 5 'prepack
                Else
                    InventoryStatusComboBox.SelectedValue = 1 'in inventory
                End If
            Case Else
                BarcodeInput.BackColor = Color.Red
                Exit Sub
        End Select
        BarcodeInput.BackColor = Color.Lime
    End Sub

#End Region


#Region "Events"
    Private Sub PackingStation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarStatusSelection' table. You can move, or remove it, as needed.
        Me.CaviarStatusSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarStatusSelection)
        RefreshData()
    End Sub

    Private Sub EggsizeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EggsizeTextBox.TextChanged
        GradeComboBox.SelectedValue = IndexInDataRows(SturgeonDBDataSet.GradeSelection.Select(""), "Grade", "ID", DetermineGrade(FirmnessTextBox.Text, EggsizeTextBox.Text))
        ValidateRequiredValues()
    End Sub

    Private Sub FirmnessTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmnessTextBox.TextChanged
        GradeComboBox.SelectedValue = IndexInDataRows(SturgeonDBDataSet.GradeSelection.Select(""), "Grade", "ID", DetermineGrade(FirmnessTextBox.Text, EggsizeTextBox.Text))
        ValidateRequiredValues()
    End Sub

    Private Sub TasteTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TasteTextBox.TextChanged
        ValidateRequiredValues()
    End Sub

    Private Sub Egg_ColorTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Egg_ColorTextBox.TextChanged
        ValidateRequiredValues()
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradeComboBox.SelectedIndexChanged
        ValidateRequiredValues()
    End Sub

    Private Sub PKBarcodeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PKBarcodeTextBox.TextChanged
        ValidateRequiredValues()
    End Sub

    Private Sub FKProductIDComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FKProductIDComboBox.SelectedIndexChanged
        FKProductIDComboBox.DataBindings("SelectedValue").WriteValue() 'update databinding
        ValidateRequiredValues()
        CalculateTotalCaviar()
    End Sub

    Private Sub Caviar_FishBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Caviar_FishBindingNavigatorSaveItem.Click
        FishComplete()
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        RefreshData()
    End Sub

    Private Sub Caviar_FishDataGridView_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Caviar_FishDataGridView.CellValidated
        Save()
    End Sub
#End Region

#Region "Helper Subs"
    'this sub ensures that all necessary information are entered before proceeding
    Public Sub ValidateRequiredValues()
        FishCheckpoint = True
        ProductCheckpoint = True

        'fish Checkpoint
        FishCheckpoint = FishCheckpoint And ValidateTextbox(EggsizeTextBox)
        FishCheckpoint = FishCheckpoint And ValidateTextbox(FirmnessTextBox)
        FishCheckpoint = FishCheckpoint And ValidateTextbox(TasteTextBox)
        FishCheckpoint = FishCheckpoint And ValidateTextbox(Egg_ColorTextBox)
        FishCheckpoint = FishCheckpoint And ValidateCombobox(GradeComboBox)

        If Caviar_FishBindingSource.Count = 0 Then
            FishCheckpoint = True
        End If

        If FishCheckpoint = True Then
            FishGroupBox.BackColor = Color.LimeGreen
        Else
            FishGroupBox.BackColor = Color.Salmon
        End If

        'product check point
        ProductCheckpoint = ProductCheckpoint And ValidateTextbox(PKBarcodeTextBox)
        ProductCheckpoint = ProductCheckpoint And ValidateCombobox(FKProductIDComboBox)

        If Caviar_InventoryBindingSource.Count = 0 Then
            ProductCheckpoint = True
        End If

        If ProductCheckpoint = True Then
            ProductGroupBox.BackColor = Color.LimeGreen
        Else
            ProductGroupBox.BackColor = Color.Salmon
        End If

    End Sub

    'this grabs the current data edited by the other computer and displays only those missing information
    Public Sub RefreshData()
        Me.Caviar_FishTableAdapter.ClearBeforeFill = True
        Me.Caviar_InventoryTableAdapter.ClearBeforeFill = True
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Inventory' table. You can move, or remove it, as needed.
        Me.Caviar_InventoryTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Inventory)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Fish' table. You can move, or remove it, as needed.
        Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Customers' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.GradeSelection' table. You can move, or remove it, as needed.
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)

        'Me.Caviar_FishBindingSource.Filter = "[Taste] is null OR [Firmness] is null OR [Egg Color] is null OR [Grade] is null OR [Completed] = false"

        ValidateRequiredValues()
        CalculateTotalCaviar()
    End Sub

    Public Sub FishComplete()
        ValidateRequiredValues()
        If FishCheckpoint And ProductCheckpoint Then
            Save()
            RefreshData()
        Else
            MsgBox("Information Not Complete: could not save to database.")
        End If
    End Sub

    Public Function Save() As Boolean
        Dim currentIndex As Integer
        currentIndex = Caviar_FishBindingSource.Position
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
        Caviar_FishBindingSource.Position = currentIndex
        CalculateTotalCaviar()
        Return True
    End Function


    'this sub handles the calculation of total caviar amount in containers for the fish
    Public Sub CalculateTotalCaviar()
        'do not calculate if there is no fish to do
        If Caviar_FishBindingSource.Count = 0 Then
            Exit Sub
        End If
        Dim TotalCaviar As Double = 0
        'loop through the caviar containers for the current fish to find total container weight
        For Each Item As DataRowView In Caviar_InventoryBindingSource.List
            Try
                TotalCaviar += SturgeonDBDataSet.Products.FindByPKProductID(Item("FKProductID")).Item("UnitWeightgms")
            Catch ex As Exception
                'vbNull to integer exception
                'MsgBox(ex.Message)
            End Try
        Next
        CaviarTotalTextBox.Text = TotalCaviar
        If Not Egg_WtTextBox.Text = "" Then
            DifferenceTextBox.Text = Convert.ToDouble(Egg_WtTextBox.Text) - TotalCaviar
            'possible overpack or underpack code here
            If Convert.ToDouble(DifferenceTextBox.Text) < 0 Then
                'overpack
                DifferenceTextBox.BackColor = Color.Red
            ElseIf Convert.ToDouble(DifferenceTextBox.Text) / Convert.ToDouble(Egg_WtTextBox.Text) > 0.1 Then
                'underpack
                DifferenceTextBox.BackColor = Color.Red
            Else
                DifferenceTextBox.BackColor = Color.Green
            End If
        Else
            'MsgBox("Egg Weight is empty") 'debug purposes only
        End If
    End Sub
#End Region

    'Private Sub Caviar_InventoryBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Caviar_InventoryBindingSource.AddingNew
    '    Dim DefaultInventoryEntry As DataRowView = DirectCast(Caviar_InventoryBindingSource.List, DataView).AddNew()
    '    DefaultInventoryEntry.Row.Item("DateStatusChanged") = Date.Now
    '    DefaultInventoryEntry.Row.Item("PreviousStatus") = 7 'harvested
    '    e.NewObject = DefaultInventoryEntry
    '    Caviar_FishBindingSource.Position = Caviar_FishBindingSource.Count - 1
    'End Sub

End Class