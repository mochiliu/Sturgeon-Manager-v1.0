Public Class WeightConversionConstants
    Public isReadOnly As Boolean = False

#Region "Form Events"
    Private Sub WeightConversionConstants_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isReadOnly Then
            Exit Sub
        End If
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
    Private Sub WeightConversionConstants_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.WeightConversionConstants' table. You can move, or remove it, as needed.
        Me.WeightConversionConstantsTableAdapter.Fill(Me.SturgeonDBDataSet.WeightConversionConstants)
    End Sub
#End Region

#Region "Button Events"
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        If Save() Then
            WeightConversionConstantsBindingSource.AddNew()
        End If
    End Sub

    Private Sub WeightConversionConstantsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeightConversionConstantsBindingNavigatorSaveItem.Click
        Save()
    End Sub
#End Region

#Region "Helper Subs"
    Public Function Save() As Boolean
        Using (New WaitCursor) 'Load Hourglass
            Try
                Me.Validate()
                Me.WeightConversionConstantsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Me.WeightConversionConstantsTableAdapter.Fill(Me.SturgeonDBDataSet.WeightConversionConstants)
            Return True
        End Using
    End Function

    Public Sub LoadReadOnly()
        isReadOnly = True
        With Me
            .WeightConversionConstantsBindingNavigatorSaveItem.Enabled = False
            .WeightConversionConstantsBindingNavigatorSaveItem.Visible = False
            .BindingNavigatorAddNewItem.Visible = False
            .BindingNavigatorDeleteItem.Visible = False

            .EffectiveDateMyDateTimePicker.Enabled = False
            .FilletShrinkageCorrectionTextBox.ReadOnly = True
            .BulletShrinkageCorrectionTextBox.ReadOnly = True
            .WholeGuttedShrinkageCorrectionTextBox.ReadOnly = True
            .FilletToCWGTextBox.ReadOnly = True
            .BulletToCWGTextBox.ReadOnly = True
            .MaleCWGToCLFTextBox.ReadOnly = True
            .FemaleCWGToCLFTextBox.ReadOnly = True

            .Text = "View Weight Conversion Constants"
        End With
    End Sub
#End Region

    Private Sub WeightConversionConstantsBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles WeightConversionConstantsBindingSource.AddingNew
        Dim DefaultEntry As DataRowView = DirectCast(WeightConversionConstantsBindingSource.List, DataView).AddNew()
        Dim CurrentConstants As SturgeonDBDataSet.WeightConversionConstantsRow = SturgeonDBDataSet.WeightConversionConstants.Rows(0)
        DefaultEntry.Row.Item("EffectiveDate") = Date.Now
        DefaultEntry.Row.Item("FilletShrinkageCorrection") = CurrentConstants.FilletShrinkageCorrection
        DefaultEntry.Row.Item("BulletShrinkageCorrection") = CurrentConstants.BulletShrinkageCorrection
        DefaultEntry.Row.Item("FilletToCWG") = CurrentConstants.FilletToCWG
        DefaultEntry.Row.Item("BulletToCWG") = CurrentConstants.BulletToCWG
        DefaultEntry.Row.Item("MaleCWGToCLF") = CurrentConstants.MaleCWGToCLF
        DefaultEntry.Row.Item("FemaleCWGToCLF") = CurrentConstants.FemaleCWGToCLF
        DefaultEntry.Row.Item("WholeGuttedShrinkageCorrection") = CurrentConstants.WholeGuttedShrinkageCorrection

        e.NewObject = DefaultEntry
        WeightConversionConstantsBindingSource.ResetBindings(False) 'refresh the controls
        FilletShrinkageCorrectionTextBox.Focus()
    End Sub

End Class