'This form edits the per kg values used by the monthly inventory report.

Public Class EditInventoryValue
    Public isLoading As Boolean = True

#Region "Form Events"
    Private Sub EditInventoryValue_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case MsgBox("Save the data entered?", MsgBoxStyle.YesNoCancel)
            Case vbYes 'Save
                If Not Save() Then
                    e.Cancel = True
                End If
            Case vbCancel
                e.Cancel = True
            Case Else
                'do nothing
        End Select
    End Sub

    Private Sub EditInventoryValue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.GradeSelection' table. You can move, or remove it, as needed.
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarInventoryValue' table. You can move, or remove it, as needed.
        Me.CaviarInventoryValueTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarInventoryValue)
        RecalculateSavedRecords()
    End Sub
#End Region

    Private Sub CaviarInventoryValueMyDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles CaviarInventoryValueMyDataGridView.CellValidating
        If isLoading = True Then
            Exit Sub
        End If
        isLoading = True
        Select Case CaviarInventoryValueMyDataGridView.Columns(e.ColumnIndex).Name
            Case "YearColumn"
                If CaviarInventoryValueMyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).IsInEditMode Then
                    Dim TextBoxToValidate As TextBox = DirectCast(CaviarInventoryValueMyDataGridView.EditingControl, TextBox)
                    If TextBoxToValidate.Text = "" Or Not IsNumeric(TextBoxToValidate.Text) Then
                        'empty year or non numeric year not acceptable
                        e.Cancel = True
                    Else
                        TextBoxToValidate.Text = Convert.ToInt32(TextBoxToValidate.Text) 'round
                        CaviarInventoryValueMyDataGridView.Rows(e.RowIndex).Cells("EffectiveYearColumn").Value = New Date(Convert.ToInt32(TextBoxToValidate.Text), 1, 1)
                    End If
                End If
        End Select
        isLoading = False
    End Sub

#Region "BindingNavagator Events"
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        isLoading = True
        CaviarInventoryValueBindingSource.AddNew()
    End Sub

    Private Sub CaviarInventoryValueBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles CaviarInventoryValueBindingSource.AddingNew
        Dim DefaultFishEntry As DataRowView = DirectCast(CaviarInventoryValueBindingSource.List, DataView).AddNew()
        DefaultFishEntry.Row.Item("EffectiveYear") = New Date(Date.Now.Year, 1, 1)
        DefaultFishEntry.Row.Item("FKGradeID") = 1
        e.NewObject = DefaultFishEntry
        CaviarInventoryValueBindingSource.Position = CaviarInventoryValueBindingSource.Count - 1
        CaviarInventoryValueBindingSource.ResetBindings(False)
        RecalculateSavedRecords()
        isLoading = False
    End Sub

    Private Sub ExportExcelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportExcelButton.Click
        If Save() Then
            ExcelExport(CaviarInventoryValueMyDataGridView)
        End If
    End Sub

    Private Sub CaviarInventoryValueBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaviarInventoryValueBindingNavigatorSaveItem.Click
        Save()
    End Sub
#End Region

#Region "Helper Subs"
    Public Sub RecalculateSavedRecords()
        isLoading = True
        For Each row As DataGridViewRow In CaviarInventoryValueMyDataGridView.Rows
            If Not IsNothing(row.Cells("EffectiveYearColumn").Value) AndAlso Not IsDBNull(row.Cells("EffectiveYearColumn").Value) Then
                row.Cells("YearColumn").Value = Convert.ToDateTime(row.Cells("EffectiveYearColumn").Value).Year.ToString
            End If
        Next
        isLoading = False
    End Sub


    Public Function Save() As Boolean
        Using (New WaitCursor) 'Load Hourglass
            Dim currentIndex As Integer = CaviarInventoryValueBindingSource.Position
            Try
                Me.Validate()
                Me.CaviarInventoryValueBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet)
                Me.CaviarInventoryValueTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarInventoryValue)
                RecalculateSavedRecords()
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Return True
        End Using
    End Function
#End Region

End Class