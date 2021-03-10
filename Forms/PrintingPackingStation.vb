
'This form is a modified version of "PackingStation.vb" that allows the user to print the barcode labels instead of scanning them
Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Drawing.Printing

Public Class PrintingPackingStation
    Public FishCheckpoint As Boolean
    Public ProductCheckpoint As Boolean
    Public IsPrepacking As Boolean = False
    Public pd As New PrintDialog()
    Public AlreadyPrinted As Boolean = False
    Public isLoading As Boolean = False
    Public NetworkExceptionCount As Integer = 0 ' the number of consequtive exceptions the program runs into while updating


#Region "Barcode Handling"

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

    'Barcodes will be read here. The formmating is "COMMAND:VALUE"
    Private Sub BarcodeInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BarcodeInput.KeyDown
        If e.KeyCode = Keys.Enter Then 'enter key is pressed
            Dim ColonIndex = BarcodeInput.Text.IndexOf(":")
            If ColonIndex > -1 Then
                'barcode input formmating recognized
                Dim Command As String
                Dim Value As String
                Command = (BarcodeInput.Text.Split(":")(0)).ToUpper()
                Value = (BarcodeInput.Text.Split(":")(1)).ToUpper()
                ExecuteCommand(Command, Value)
            Else
                'colon not found
                BarcodeInput.Text = ""
                BarcodeInput.BackColor = Color.Red
                Exit Sub
            End If
            BarcodeInput.Text = ""
        End If
    End Sub

    Public Sub ExecuteCommand(ByVal Command As String, ByVal Value As String)
        Select Case Command
            Case "END"
                FishComplete()
            Case "REFRESH"
                SpeakText("Refreshing")
                RefreshData()
            Case "SIZE"
                SpeakText("Size " & Value)
                EggsizeTextBox.Text = Value
            Case "FIRM"
                SpeakText("Firmness " & Value)
                FirmnessTextBox.Text = Value
            Case "TASTE"
                SpeakText("Taste " & Value)
                TasteTextBox.Text = Value
            Case "GRADE"
                SpeakText("Grade " & Value)
                GradeComboBox.SelectedValue = IndexInDataRows(SturgeonDBDataSet.GradeSelection.Select(""), "Grade", "ID", Value)
            Case "COLOR"
                SpeakText("Color " & Value)
                Egg_ColorTextBox.Text = Value
            Case "PRDT"
                If FishCheckpoint Then
                    Dim FKProductID As Integer = IndexInDataRows(SturgeonDBDataSet.Products.Select(""), "Product Name", "PKProductID", GradeComboBox.Text & Value)
                    If FKProductID = -1 Then
                        'no product found
                        SpeakText("Product Not Found")
                        MsgBox("Product Not Found")
                        BarcodeInput.BackColor = Color.Red
                        Exit Sub
                    Else
                        SpeakProductCode(GradeComboBox.Text & Value)
                    End If

                    Try
                        Caviar_InventoryBindingSource.AddNew()
                    Catch ex As Exception
                        'vbNull to integer exception
                    End Try

                    Caviar_InventoryDataGridView.CurrentRow.Cells("PKBarcodeColumn").Value = GetBarcode()
                    Caviar_InventoryDataGridView.CurrentRow.Cells("FKProductIDColumn").Value = IndexInDataRows(SturgeonDBDataSet.Products.Select(""), "Product Name", "PKProductID", GradeComboBox.Text & Value)
                    Caviar_InventoryDataGridView.CurrentRow.Cells("PreviousStatus").Value = 7 'harvested

                    'If IsPrepacking Then
                    '    Caviar_InventoryDataGridView.CurrentRow.Cells("InventoryStatusColumn").Value = 5 'prepack
                    'Else
                    Caviar_InventoryDataGridView.CurrentRow.Cells("InventoryStatusColumn").Value = 1 'in inventory
                    'End If

                    If Not IsDBNull(Harvest_DateDateTimePicker.Value) Then
                        Caviar_InventoryDataGridView.CurrentRow.Cells("DateStatusChanged").Value = Harvest_DateDateTimePicker.Value
                    Else
                        Caviar_InventoryDataGridView.CurrentRow.Cells("DateStatusChanged").Value = Date.Now
                    End If

                    CalculateTotalCaviar()
                    ValidateRequiredValues()
                    AlreadyPrinted = False
                    BarcodeInput.BackColor = Color.Lime
                Else
                    MsgBox("Information entered is not complete, please ensure all data is entered")
                    BarcodeInput.BackColor = Color.Red
                End If

                'Case "PREPACK"
                '    IsPrepacking = Not IsPrepacking 'toggle on and off
                '    Try
                '        If IsPrepacking Then
                '            Caviar_InventoryDataGridView.CurrentRow.Cells("InventoryStatusColumn").Value = 5 'prepack
                '        Else
                '            Caviar_InventoryDataGridView.CurrentRow.Cells("InventoryStatusColumn").Value = 1 'in inventory
                '        End If
                '    Catch ex As Exception
                '        'catch the case when user begins prepacking with no entry in the datagridview
                '    End Try

            Case "PRINT"
                If Value = "SELECT" Then
                    PrintSelectedLabelToolStripMenuItem_Click(Nothing, Nothing)
                Else
                    PrintAllFishLabelsToolStripMenuItem_Click(Nothing, Nothing)
                End If
            Case Else
                SpeakText("Invalid barcode command")
                BarcodeInput.BackColor = Color.Red
                Exit Sub
        End Select
        BarcodeInput.BackColor = Color.Lime
    End Sub

#End Region


#Region "Events"
    Private Sub PackingStation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.ConcurrencyHandler' table. You can move, or remove it, as needed.
        Me.ConcurrencyHandlerTableAdapter.Fill(Me.SturgeonDBDataSet.ConcurrencyHandler)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarStatusSelection' table. You can move, or remove it, as needed.
        Me.CaviarStatusSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarStatusSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Customers' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.GradeSelection' table. You can move, or remove it, as needed.
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)

        pd.PrinterSettings = New PrinterSettings()
        pd.ShowDialog()

        RefreshData()
        'ConcurrencyTimer.Enabled = True
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

    Private Sub Caviar_FishBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Caviar_FishBindingNavigatorSaveItem.Click
        FishComplete()
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        RefreshData()
    End Sub
#End Region


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
        'ProductCheckpoint = ProductCheckpoint And ValidateTextbox(PKBarcodeTextBox)
        'ProductCheckpoint = ProductCheckpoint And ValidateCombobox(FKProductIDComboBox)

        If Not DifferenceTextBox.Text = String.Empty AndAlso Convert.ToDouble(DifferenceTextBox.Text) > 50 And Caviar_InventoryBindingSource.Count <> 0 Then
            ProductCheckpoint = False
        Else
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
        Using (New WaitCursor) 'Load Hourglass
            Me.Caviar_FishTableAdapter.ClearBeforeFill = False
            Me.Caviar_InventoryTableAdapter.ClearBeforeFill = True
            'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Inventory' table. You can move, or remove it, as needed.
            Me.Caviar_InventoryTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Inventory)
            'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Fish' table. You can move, or remove it, as needed.
            Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)

            'Me.Caviar_FishBindingSource.Filter = "[Tag] is not null AND [Egg Wt] is not null AND [Ovary Tot] is not null AND [Ovary Waste] is not null AND ([Taste] is null OR [Firmness] is null OR [Egg Color] is null OR [Grade] is null OR [Completed] = false)"
            Me.Caviar_FishBindingSource.Filter = "[Tag] is not null AND [Egg Wt] is not null AND ([Taste] is null OR [Firmness] is null OR [Egg Color] is null OR [Grade] is null OR [Completed] = false)"
            ValidateRequiredValues()
            CalculateTotalCaviar()
            SaltingStationComplete()
        End Using
    End Sub

    'take the fish off the list at salting station
    Public Sub SaltingStationComplete()
        For Each FishRow As DataGridViewRow In Caviar_FishDataGridView.Rows
            FishRow.Cells("SaltingStationCompletedColumn").Value = True
        Next
        Me.Caviar_FishBindingSource.EndEdit()

        'request salting stationg to update
        Me.ConcurrencyHandlerTableAdapter.Fill(Me.SturgeonDBDataSet.ConcurrencyHandler) 'get concurrency data
        SturgeonDBDataSet.ConcurrencyHandler.FindByFormName("SaltingStation").UpdateRequested = True
        Me.TableAdapterManager.Caviar_FishTableAdapter.Update(SturgeonDBDataSet.Caviar_Fish)
        Me.TableAdapterManager.ConcurrencyHandlerTableAdapter.Update(SturgeonDBDataSet.ConcurrencyHandler)
    End Sub

    Public Sub FishComplete()
        Using (New WaitCursor) 'Load Hourglass

            ValidateRequiredValues()
            If FishCheckpoint And ProductCheckpoint Then
                If Not AlreadyPrinted Then
                    PrintAllFishLabelsToolStripMenuItem_Click(Nothing, Nothing)
                End If
                If DifferenceTextBox.BackColor = Color.Red Then 'possible under or over pack
                    SpeakText("warning possible over or under pack")
                    Select Case MsgBox("The current fish might be over or under packed. Continue?", MsgBoxStyle.YesNo)
                        Case vbNo
                            Exit Sub
                    End Select
                End If
                CompletedCheckBox.Checked = True
                ConcurrencyTimer_Tick(Nothing, Nothing)
                Save()
                RefreshData()
                AlreadyPrinted = False
                SpeakText("Fish complete")
            ElseIf FishCheckpoint And Not ProductCheckpoint Then
                SpeakText("over pack")
                MsgBox("The current Fish is Overpacked. The fish cannot be completed until you resolve the Overpack issue.")
            Else
                SpeakText("incomplete information")
                MsgBox("Information Not Complete: could not save to database.")
            End If
        End Using
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

            'request salting stationg to update
            Me.ConcurrencyHandlerTableAdapter.Fill(Me.SturgeonDBDataSet.ConcurrencyHandler) 'get concurrency data
            SturgeonDBDataSet.ConcurrencyHandler.FindByFormName("SaltingStation").UpdateRequested = True

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
            DifferenceTextBox.Text = TotalCaviar - Convert.ToDouble(Egg_WtTextBox.Text)
            'possible overpack or underpack code here
            If Convert.ToDouble(DifferenceTextBox.Text) > 0 Then
                'overpack
                DifferenceTextBox.BackColor = Color.Red
            ElseIf Convert.ToDouble(DifferenceTextBox.Text) / Convert.ToDouble(Egg_WtTextBox.Text) < -0.1 Then
                'underpack
                DifferenceTextBox.BackColor = Color.Red
            Else
                DifferenceTextBox.BackColor = Color.Green
            End If
        Else
            'MsgBox("Egg Weight is empty") 'debug purposes only
        End If
    End Sub

    Private Sub Caviar_FishDataGridView_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Caviar_FishDataGridView.CellValidated
        Save()
    End Sub

    Private Sub PrintAllFishLabelsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintAllFishLabelsToolStripMenuItem.Click
        Try
            Caviar_InventoryBindingSource.AddNew() 'the last item is not saved for some reason, so add a placeholder
            Caviar_InventoryBindingSource.RemoveCurrent() 'delete the newly added placeholder
            Caviar_FishBindingSource.EndEdit()
            Caviar_InventoryBindingSource.EndEdit()
            For Each Item As DataRowView In Caviar_InventoryBindingSource.List
                PrintLabel(Item, Caviar_FishBindingSource.Current, SturgeonDBDataSet.Products.FindByPKProductID(Item("FKProductID")).Item("Product Name"), pd)
                AlreadyPrinted = True
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PrintSelectedLabelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSelectedLabelToolStripMenuItem.Click
        PrintLabel(Caviar_InventoryBindingSource.Current, Caviar_FishBindingSource.Current, SturgeonDBDataSet.Products.FindByPKProductID(Caviar_InventoryBindingSource.Current("FKProductID")).Item("Product Name"), pd)
    End Sub

    Private Sub Caviar_InventoryDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Caviar_InventoryDataGridView.CellValueChanged
        Try
            If e.ColumnIndex = Caviar_InventoryDataGridView.Columns("FKProductIDColumn").Index Then
                ValidateRequiredValues()
                CalculateTotalCaviar()
                AlreadyPrinted = False
            End If
        Catch ex As Exception
            'form load
        End Try
    End Sub


    Private Sub Caviar_InventoryBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles Caviar_InventoryBindingSource.ListChanged
        CalculateTotalCaviar()
    End Sub

    Private Sub ConcurrencyTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConcurrencyTimer.Tick
        Try
            If Not isLoading Then
                Me.ConcurrencyHandlerTableAdapter.Fill(Me.SturgeonDBDataSet.ConcurrencyHandler) 'get concurrency data
                ConcurrencyTimer.Enabled = True
                NetworkExceptionCount = 0
            End If
        Catch ex As Exception
            If NetworkExceptionCount > 0 Then 'notify the user if timed out twice
                ConcurrencyTimer.Enabled = False
                If MsgBox("It appears that the computer is disconnected from the network. Some data entry may be lost. It is recommended to restart Sturgeon Manager after the network is reconnected. Press Retry to reconnect. Press Cancel to exit this form.", MsgBoxStyle.RetryCancel) = MsgBoxResult.Retry Then
                    ConcurrencyTimer_Tick(Nothing, Nothing)
                Else
                    Me.Close()
                End If
            Else
                NetworkExceptionCount += 1
                ConcurrencyTimer_Tick(Nothing, Nothing)
            End If
        Finally

        End Try


        'If SturgeonDBDataSet.ConcurrencyHandler.FindByFormName("PackingStation").UpdateRequested Then

        '    Dim currentIndex As Integer = Caviar_FishBindingSource.Position
        '    Me.Caviar_FishTableAdapter.ClearBeforeFill = False
        '    Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)
        '    Me.Caviar_FishTableAdapter.ClearBeforeFill = True
        '    Caviar_FishBindingSource.Position = currentIndex

        '    'reset the update request
        '    SturgeonDBDataSet.ConcurrencyHandler.FindByFormName("PackingStation").UpdateRequested = False
        '    ConcurrencyHandlerTableAdapter.Update(SturgeonDBDataSet.ConcurrencyHandler)
        'End If
    End Sub

    Private Sub Caviar_InventoryDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Caviar_InventoryDataGridView.DataError
        MsgBox(e.Exception.Message)
        e.Cancel = True
    End Sub

    Private Sub Caviar_FishDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Caviar_FishDataGridView.DataError
        MsgBox(e.Exception.Message)
        e.Cancel = True
    End Sub
End Class