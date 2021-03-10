
'This form allows the user to enter caviar fish information at the "Salting Station" in the processing room
Public Class SaltingStation
    Public InformationComplete As Boolean 'This true/false value can be used to enforce correct data entry
    'Public DefaultPurgeTank As String
    Public isLoading As Boolean = True
    Public CurrentPercentSalt As Double = 3.7
    Public NetworkExceptionCount As Integer = 0 ' the number of consequtive exceptions the program runs into while updating

    Private Sub Caviar_FishBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Caviar_FishBindingSource.AddingNew
        Dim DefaultFishEntry As DataRowView = DirectCast(Caviar_FishBindingSource.List, DataView).AddNew()
        DefaultFishEntry.Row.Item("Harvest Date") = Date.Now
        DefaultFishEntry.Row.Item("PercentSalt") = CurrentPercentSalt
        'DefaultFishEntry.Row.Item("Purge Tank") = DefaultPurgeTank
        e.NewObject = DefaultFishEntry
        Caviar_FishBindingSource.Position = Caviar_FishBindingSource.Count - 1
        Caviar_FishBindingSource.ResetBindings(False) 'refresh the controls
        isLoading = False
    End Sub

#Region "Form Events"

    Private Sub SaltingStation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isLoading = True
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.ConcurrencyHandler' table. You can move, or remove it, as needed.
        Me.ConcurrencyHandlerTableAdapter.Fill(Me.SturgeonDBDataSet.ConcurrencyHandler)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Fish' table. You can move, or remove it, as needed.
        Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)

        Me.Caviar_FishBindingSource.Filter = String.Format("[Harvest Date] >= #{0:M/dd/yyyy} 00:00:00# AND [Harvest Date] <= #{1:M/dd/yyyy} 00:00:00#", Date.Now, Date.Now.AddDays(1)) & " AND [SaltingStationCompleted] = false" ' only display data from today
        'DefaultPurgeTank = ""
        Caviar_FishDataGridView.NoTabColumns.Add(SaltColumn)
        Caviar_FishDataGridView.NoTabColumns.Add(HarvestDateColumn)
        Caviar_FishDataGridView.NoTabColumns.Add(SpeciesColumn)
        Caviar_FishDataGridView.NoTabColumns.Add(NotesColumn)
        Caviar_FishDataGridView.NoTabColumns.Add(PercentSaltColumn)

        isLoading = False
        ColorCodeDGV(-1, -1)
        RecalculateSavedRecords()
        Try
            TagColumn.Mask = ">LA|9999"
        Catch ex As Exception
            'out of index exception that occurs. No reason found
        End Try
        ConcurrencyTimer.Enabled = True
    End Sub

#End Region

#Region "Helper Subs"
    Public Sub ColorCodeDGV(ByVal selectedRow As Integer, ByVal selectedColumn As Integer)
        If isLoading Then
            Exit Sub
        End If
        Try
            For Each row As DataGridViewRow In Caviar_FishDataGridView.Rows
                If row.IsNewRow Then 'skip the last row
                    Continue For
                End If

                Dim isSaved As Boolean = False
                For Each bindingsourceRow As DataRowView In Caviar_FishBindingSource.List
                    If Not IsNothing(row.Cells("TagColumn").Value) AndAlso Not IsDBNull(row.Cells("TagColumn").Value) AndAlso Not IsNothing(DirectCast(bindingsourceRow.Row, SturgeonDBDataSet.Caviar_FishRow).Tag) AndAlso Not IsDBNull(DirectCast(bindingsourceRow.Row, SturgeonDBDataSet.Caviar_FishRow).Tag) AndAlso row.Cells("TagColumn").Value = DirectCast(bindingsourceRow.Row, SturgeonDBDataSet.Caviar_FishRow).Tag Then
                        'find the corresponding row in the bindingsource
                        If DirectCast(bindingsourceRow.Row, SturgeonDBDataSet.Caviar_FishRow).PKFishID < 0 Then
                            'the row is not saved
                            isSaved = False
                        Else
                            isSaved = True
                        End If
                        Exit For
                    End If
                Next


                For Each cell As DataGridViewCell In row.Cells
                    'for every cell in the datagridview
                    Select Case Caviar_FishDataGridView.Columns(cell.ColumnIndex).Name
                        Case "TagColumn", "SpeciesColumn", "HarvestDateColumn"
                            If cell.FormattedValue = "" Then
                                cell.Style.BackColor = GetColor("ERROR", isSaved)
                            Else
                                cell.Style.BackColor = GetColor("VALID", isSaved)
                            End If
                        Case "NotesColumn"
                            cell.Style.BackColor = GetColor("VALID", isSaved)
                        Case "OvaryTotColumn"
                            Select Case ValidateDataGridViewCellNumber(cell, 500, 4000)
                                Case "NULL"
                                    cell.Style.BackColor = GetColor("ERROR", isSaved)
                                Case "NOT_NUMBER"
                                    cell.Style.BackColor = GetColor("ERROR", isSaved)
                                Case "LOW"
                                    If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Ovary Total is less than 500g.")
                                    cell.Style.BackColor = GetColor("WARNING", isSaved)
                                Case "HIGH"
                                    If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Ovary Total is more than 4000 g.")
                                    cell.Style.BackColor = GetColor("WARNING", isSaved)
                                Case "OUT_OF_RANGE"
                                    cell.Style.BackColor = GetColor("WARNING", isSaved)
                                Case "VALID"
                                    cell.Style.BackColor = GetColor("VALID", isSaved)
                            End Select
                        Case "OvaryWasteColumn"
                            If Not IsNothing(row.Cells("OvaryTotColumn").Value) AndAlso Not IsDBNull(row.Cells("OvaryTotColumn").Value) Then
                                Select Case ValidateDataGridViewCellNumber(cell, 100, row.Cells("OvaryTotColumn").Value)
                                    Case "NULL"
                                        cell.Style.BackColor = GetColor("ERROR", isSaved)
                                    Case "NOT_NUMBER"
                                        cell.Style.BackColor = GetColor("ERROR", isSaved)
                                    Case "LOW"
                                        If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Ovary Waste is less than 100g.")
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                    Case "HIGH"
                                        If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Ovary Waste is more than Ovary Total.")
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                    Case "OUT_OF_RANGE"
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                    Case "VALID"
                                        cell.Style.BackColor = GetColor("VALID", isSaved)
                                End Select
                            Else
                                Select Case ValidateDataGridViewCellNumber(cell, 100, 4000)
                                    Case "NULL"
                                        cell.Style.BackColor = GetColor("ERROR", isSaved)
                                    Case "NOT_NUMBER"
                                        cell.Style.BackColor = GetColor("ERROR", isSaved)
                                    Case "LOW"
                                        If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Ovary Waste is less than 100g.")
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                    Case "HIGH"
                                        If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Ovary Waste is more than 4000g.")
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                    Case "OUT_OF_RANGE"
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                    Case "VALID"
                                        cell.Style.BackColor = GetColor("VALID", isSaved)
                                End Select
                            End If

                        Case "CycledColumn"
                            'If Caviar_FishDataGridView.Rows(cell.RowIndex).Cells("CycledEnteredColumn").Value = False Then
                            '    cell.Style.BackColor = Color.Red
                            'Else
                            cell.Style.BackColor = GetColor("VALID", isSaved)
                            'End If
                        Case "EggWeightColumn"
                            If Not IsNothing(row.Cells("OvaryTotColumn").Value) AndAlso Not IsDBNull(row.Cells("OvaryTotColumn").Value) AndAlso Not IsNothing(row.Cells("OvaryWasteColumn").Value) AndAlso Not IsDBNull(row.Cells("OvaryWasteColumn").Value) Then
                                Select Case ValidateDataGridViewCellNumber(cell, 500, row.Cells("OvaryTotColumn").Value - row.Cells("OvaryWasteColumn").Value)
                                    Case "NULL"
                                        cell.Style.BackColor = GetColor("ERROR", isSaved)
                                    Case "NOT_NUMBER"
                                        cell.Style.BackColor = GetColor("ERROR", isSaved)
                                    Case "LOW"
                                        If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Egg Weight is less than than 500g.")
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                    Case "HIGH"
                                        If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Egg Weight is more than Ovary Total minus Ovary Waste.")
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                    Case "OUT_OF_RANGE"
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                    Case "VALID"
                                        cell.Style.BackColor = GetColor("VALID", isSaved)
                                End Select
                            Else
                                Select Case ValidateDataGridViewCellNumber(cell, 500, 4000)
                                    Case "NULL"
                                        cell.Style.BackColor = GetColor("ERROR", isSaved)
                                    Case "NOT_NUMBER"
                                        cell.Style.BackColor = GetColor("ERROR", isSaved)
                                    Case "LOW"
                                        If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Egg Weight is less than than 500g.")
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                    Case "HIGH"
                                        If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Egg Weight is more than 4000g.")
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                    Case "OUT_OF_RANGE"
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                    Case "VALID"
                                        cell.Style.BackColor = GetColor("WARNING", isSaved)
                                End Select
                            End If

                        Case "SaltColumn"
                            Select Case ValidateDataGridViewCellNumber(cell, 0, 400)
                                Case "NULL"
                                    cell.Style.BackColor = GetColor("ERROR", isSaved)
                                Case "NOT_NUMBER"
                                    cell.Style.BackColor = GetColor("ERROR", isSaved)
                                Case "LOW"
                                    If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Salt is less than than 0g.")
                                    cell.Style.BackColor = GetColor("WARNING", isSaved)
                                Case "HIGH"
                                    If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Salt is more than 400g.")
                                    cell.Style.BackColor = GetColor("WARNING", isSaved)
                                Case "OUT_OF_RANGE"
                                    cell.Style.BackColor = GetColor("WARNING", isSaved)
                                Case "VALID"
                                    cell.Style.BackColor = GetColor("VALID", isSaved)
                            End Select
                        Case "PercentSaltColumn"
                            Select Case ValidateDataGridViewCellNumber(cell, 0, 10)
                                Case "NULL"
                                    cell.Style.BackColor = GetColor("ERROR", isSaved)
                                Case "NOT_NUMBER"
                                    cell.Style.BackColor = GetColor("ERROR", isSaved)
                                Case "LOW"
                                    If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Percent Salt is less than than 0%.")
                                    cell.Style.BackColor = GetColor("WARNING", isSaved)
                                Case "HIGH"
                                    If selectedRow = row.Index And selectedColumn = cell.ColumnIndex Then MsgBox("WARNING: Percent Salt is more than 10%.")
                                    cell.Style.BackColor = GetColor("WARNING", isSaved)
                                Case "OUT_OF_RANGE"
                                    cell.Style.BackColor = GetColor("WARNING", isSaved)
                                Case "VALID"
                                    cell.Style.BackColor = GetColor("VALID", isSaved)
                            End Select
                    End Select
                Next
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Function GetColor(ByVal Status As String, ByVal isSaved As Boolean) As Color
        Select Case Status
            Case "ERROR"
                If isSaved Then
                    Return Color.Salmon
                Else
                    Return Color.Red
                End If

            Case "VALID"
                If isSaved Then
                    Return Color.LightGreen
                Else
                    Return Color.LimeGreen
                End If
            Case "WARNING"
                If isSaved Then
                    Return Color.Moccasin
                Else
                    Return Color.Orange
                End If
        End Select
    End Function

    'saves the current record
    Public Function SaveRecord() As Boolean
        Using (New WaitCursor) 'Load Hourglass
            Dim currentIndex As Integer = Caviar_FishBindingSource.Position
            Try
                Me.Validate()
                Me.Caviar_FishBindingSource.EndEdit()
                Me.Caviar_FishTableAdapter.Update(DirectCast(Caviar_FishBindingSource.Current, DataRowView).Row)
                Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)

                'request update for printing packing station
                SturgeonDBDataSet.ConcurrencyHandler.FindByFormName("PackingStation").UpdateRequested = True
                Me.ConcurrencyHandlerTableAdapter.Update(Me.SturgeonDBDataSet.ConcurrencyHandler)

                Caviar_FishBindingSource.Position = currentIndex
                RecalculateSavedRecords()
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Return True
        End Using
    End Function

    Public Function SaveAll() As Boolean
        Using (New WaitCursor) 'Load Hourglass
            Dim currentIndex As Integer = Caviar_FishBindingSource.Position
            Try
                Me.Validate()
                Me.Caviar_FishBindingSource.EndEdit()
                Me.Caviar_FishTableAdapter.Update(Me.SturgeonDBDataSet.Caviar_Fish)
                Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)

                'request update for printing packing station
                SturgeonDBDataSet.ConcurrencyHandler.FindByFormName("PackingStation").UpdateRequested = True
                Me.ConcurrencyHandlerTableAdapter.Update(Me.SturgeonDBDataSet.ConcurrencyHandler)

                Caviar_FishBindingSource.Position = currentIndex
                RecalculateSavedRecords()
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Return True
        End Using
    End Function

    Public Function Save() As Boolean
        Using (New WaitCursor) 'Load Hourglass
            Dim currentIndex As Integer = Caviar_FishBindingSource.Position
            Try
                Me.Validate()
                Me.Caviar_FishBindingSource.EndEdit()
                For Each FishRecord As DataRowView In Caviar_FishBindingSource.List
                    If Not IsDBNull(FishRecord.Row.Item("Tag")) Then
                        'do not save if the record has no tag
                        Me.Caviar_FishTableAdapter.Update(FishRecord.Row)
                    End If
                Next
                Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)

                'request update for printing packing station
                SturgeonDBDataSet.ConcurrencyHandler.FindByFormName("PackingStation").UpdateRequested = True
                Me.ConcurrencyHandlerTableAdapter.Update(Me.SturgeonDBDataSet.ConcurrencyHandler)

                Caviar_FishBindingSource.Position = currentIndex
                RecalculateSavedRecords()
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Return True
        End Using
    End Function
    Public Sub RecalculateSavedRecords()
        For Each row As DataGridViewRow In Caviar_FishDataGridView.Rows
            'For Each cell As DataGridViewCell In row.Cells

            '    If cell.Style.BackColor = Color.Red And Caviar_FishDataGridView.Columns(cell.ColumnIndex).Name <> "Cycled" Then
            '        'there is a piece besides cycled missing (the row has not been saved)
            '        Exit Sub
            '    End If
            'Next
            If Not IsNothing(row.Cells("EggWeightColumn").Value) AndAlso Not IsDBNull(row.Cells("EggWeightColumn").Value) AndAlso Not IsNothing(row.Cells("SaltColumn").Value) AndAlso Not IsDBNull(row.Cells("SaltColumn").Value) Then
                row.Cells("PercentSaltColumn").Value = Math.Round(row.Cells("SaltColumn").Value / row.Cells("EggWeightColumn").Value * 100.0, 1)
            ElseIf Not row.IsNewRow Then
                row.Cells("PercentSaltColumn").Value = CurrentPercentSalt
            End If
            'row.Cells("CycledEnteredColumn").Value = True
        Next
    End Sub

#End Region

    Private Sub Caviar_FishDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Caviar_FishDataGridView.CellEnter
        Select Case Caviar_FishDataGridView.Columns(e.ColumnIndex).Name
            Case "EggWeightColumn"
                MsgBox("Please Tare")
        End Select
        Caviar_FishDataGridView.AllowTabbing = True
    End Sub

    Private Sub Caviar_FishDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles Caviar_FishDataGridView.CellValidating
        If Caviar_FishDataGridView.Tabbing Or isLoading Then
            'skip the validation process if continuously tabbing
            Exit Sub
        End If

        Select Case Caviar_FishDataGridView.Columns(e.ColumnIndex).Name
            Case "TagColumn"
                If ValidateDataGridViewTextFormatFailed(Caviar_FishDataGridView, "^[A-Z]{1,2}\d{1,4}$", " 1 capital letter followed by 1 to 4 digits", Not Caviar_FishDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).IsInEditMode) Then
                    e.Cancel = True
                Else
                    'determine if the Tag has been used already
                    Dim TagsToday As New List(Of String) 'list of tags processed today, to check for duplicate tags
                    For i = 0 To Caviar_FishDataGridView.Rows.Count - 1
                        If i = e.RowIndex Then
                            Continue For
                        ElseIf Not IsNothing(Caviar_FishDataGridView.Rows(i).Cells("TagColumn").Value) AndAlso Not IsDBNull(Caviar_FishDataGridView.Rows(i).Cells("TagColumn").Value) Then
                            TagsToday.Add(Caviar_FishDataGridView.Rows(i).Cells("TagColumn").Value.ToString)
                        End If
                    Next
                    If TagsToday.Contains(e.FormattedValue) Then
                        'duplicate found
                        MsgBox("Duplicate Tag for today found! Please double check")
                        Dim TextBoxToValidate As TextBox = DirectCast(Caviar_FishDataGridView.EditingControl, TextBox)
                        TextBoxToValidate.SelectAll()
                        e.Cancel = True
                    End If
                End If
            Case "OvaryTotColumn"
                If ValidateEditingDataGridViewNumber(Caviar_FishDataGridView, 500, 4000) = "NOT_NUMBER" Then
                    'validation failed
                    e.Cancel = True
                End If
            Case "OvaryWasteColumn"
                If ValidateEditingDataGridViewNumber(Caviar_FishDataGridView, 100, 4000) = "NOT_NUMBER" Then
                    'validation failed
                    e.Cancel = True
                End If
            Case "CycledColumn"
                'do nothing
            Case "EggWeightColumn"
                If ValidateEditingDataGridViewNumber(Caviar_FishDataGridView, 100, 4000) = "NOT_NUMBER" Then
                    'validation failed
                    e.Cancel = True
                End If
            Case "SaltColumn"
                If ValidateEditingDataGridViewNumber(Caviar_FishDataGridView, 0, 400) = "NOT_NUMBER" Then
                    'validation failed
                    e.Cancel = True
                End If
            Case "PercentSaltColumn"
                If ValidateEditingDataGridViewNumber(Caviar_FishDataGridView, 0, 10) = "NOT_NUMBER" Then
                    'validation failed
                    e.Cancel = True
                End If
        End Select
        If e.Cancel = True Then
            Caviar_FishDataGridView.AllowTabbing = False 'disable tabbing if there is an error
        End If
    End Sub

    Private Sub Caviar_FishDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles Caviar_FishDataGridView.RowsAdded
        ColorCodeDGV(e.RowIndex, 0)
    End Sub

    Private Sub Caviar_FishDataGridView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles Caviar_FishDataGridView.UserDeletedRow
        SaveAll()
    End Sub

    Private Sub Caviar_FishDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Caviar_FishDataGridView.CellValueChanged
        If Caviar_FishDataGridView.Tabbing Or isLoading Then
            Exit Sub
        End If
        Select Case Caviar_FishDataGridView.Columns(e.ColumnIndex).Name
            Case "TagColumn"

            Case "CycledColumn"
                'Caviar_FishDataGridView.Rows(e.RowIndex).Cells("CycledEnteredColumn").Value = True
            Case "EggWeightColumn"
                'calculate salt
                If Not IsNothing(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("EggWeightColumn").Value) AndAlso Not IsDBNull(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("EggWeightColumn").Value) AndAlso Not IsNothing(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("PercentSaltColumn").Value) AndAlso Not IsDBNull(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("PercentSaltColumn").Value) Then
                    Caviar_FishDataGridView.Rows(e.RowIndex).Cells("SaltColumn").Value = Math.Round(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("PercentSaltColumn").Value * Caviar_FishDataGridView.Rows(e.RowIndex).Cells("EggWeightColumn").Value / 100.0, 1)
                End If
            Case "SaltColumn"
                'calculate salt percent
                If Not IsNothing(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("EggWeightColumn").Value) AndAlso Not IsDBNull(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("EggWeightColumn").Value) AndAlso Not IsNothing(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("SaltColumn").Value) AndAlso Not IsDBNull(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("SaltColumn").Value) Then
                    Caviar_FishDataGridView.Rows(e.RowIndex).Cells("PercentSaltColumn").Value = Math.Round(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("SaltColumn").Value / Caviar_FishDataGridView.Rows(e.RowIndex).Cells("EggWeightColumn").Value * 100.0, 1)
                    CurrentPercentSalt = Caviar_FishDataGridView.Rows(e.RowIndex).Cells("PercentSaltColumn").Value
                End If
            Case "PercentSaltColumn"
                'calculate salt
                If Not IsNothing(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("EggWeightColumn").Value) AndAlso Not IsDBNull(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("EggWeightColumn").Value) AndAlso Not IsNothing(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("PercentSaltColumn").Value) AndAlso Not IsDBNull(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("PercentSaltColumn").Value) Then
                    Caviar_FishDataGridView.Rows(e.RowIndex).Cells("SaltColumn").Value = Math.Round(Caviar_FishDataGridView.Rows(e.RowIndex).Cells("PercentSaltColumn").Value * Caviar_FishDataGridView.Rows(e.RowIndex).Cells("EggWeightColumn").Value / 100.0, 1)
                    CurrentPercentSalt = Caviar_FishDataGridView.Rows(e.RowIndex).Cells("PercentSaltColumn").Value
                End If
        End Select

        isLoading = True
        Save()
        isLoading = False
        ColorCodeDGV(e.RowIndex, e.ColumnIndex)

    End Sub


    Private Sub ConcurrencyTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConcurrencyTimer.Tick
        Try
            If Not isLoading Then
                'do not fill when is loading
                Me.ConcurrencyHandlerTableAdapter.Fill(Me.SturgeonDBDataSet.ConcurrencyHandler) 'get concurrency data
                If SturgeonDBDataSet.ConcurrencyHandler.FindByFormName("SaltingStation").UpdateRequested Then
                    isLoading = True
                    If Caviar_FishDataGridView.IsCurrentCellInEditMode Then
                        MsgBox("The database has been updated by another station. Please reenter this data. To avoid this next time, move on to the next cell after typing in the data.")
                    End If
                    Dim currentIndex As Integer = Caviar_FishBindingSource.Position
                    Me.Caviar_FishTableAdapter.ClearBeforeFill = False
                    Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)
                    Me.Caviar_FishTableAdapter.ClearBeforeFill = True
                    Caviar_FishBindingSource.Position = currentIndex
                    RecalculateSavedRecords()
                    ColorCodeDGV(-1, -1)

                    'reset the update request
                    SturgeonDBDataSet.ConcurrencyHandler.FindByFormName("SaltingStation").UpdateRequested = False
                    ConcurrencyHandlerTableAdapter.Update(SturgeonDBDataSet.ConcurrencyHandler)
                    isLoading = False
                End If
                ConcurrencyTimer.Enabled = True
                NetworkExceptionCount = 0
            End If

        Catch ex As Exception
            'DB connection issue
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

    End Sub

    Private Sub Caviar_FishDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Caviar_FishDataGridView.DataError
        MsgBox(e.Exception.Message)
        e.Cancel = True
        Caviar_FishDataGridView.AllowTabbing = False
    End Sub
End Class