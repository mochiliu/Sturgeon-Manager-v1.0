
'This form allows the user to enter caviar fish information at the "Salting Station" in the processing room
Public Class OldSaltingStation
    Public InformationComplete As Boolean 'This true/false value can be used to enforce correct data entry
    Public DefaultPurgeTank As String
    Public isLoading As Boolean = True

#Region "Button Events"
    Private Sub Caviar_FishBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Caviar_FishBindingNavigatorSaveItem.Click
        Save()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        isLoading = True
        If Save() Then
            Caviar_FishBindingSource.AddNew()
        End If
    End Sub
#End Region

    Private Sub Caviar_FishBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Caviar_FishBindingSource.AddingNew
        Dim DefaultFishEntry As DataRowView = DirectCast(Caviar_FishBindingSource.List, DataView).AddNew()
        DefaultFishEntry.Row.Item("Harvest Date") = Date.Now
        DefaultFishEntry.Row.Item("Purge Tank") = DefaultPurgeTank
        e.NewObject = DefaultFishEntry
        Caviar_FishBindingSource.Position = Caviar_FishBindingSource.Count - 1
        Caviar_FishBindingSource.ResetBindings(False) 'refresh the controls
        TagTextBox.Focus()
        isLoading = False
    End Sub

#Region "Form Events"

    Private Sub OldSaltingStation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Caviar_Fish' table. You can move, or remove it, as needed.
        isLoading = True
        Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)
        Me.Caviar_FishBindingSource.Filter = String.Format("[Harvest Date] >= #{0:M/dd/yyyy} 00:00:00# AND [Harvest Date] <= #{1:M/dd/yyyy} 00:00:00#", Date.Now, Date.Now.AddDays(1)) ' only display data from today
        Harvest_DateMyDateTimePicker.BackColor = Color.Lime
        DefaultPurgeTank = ""

    End Sub

#End Region

#Region "Helper Subs"
    Public Function Save() As Boolean
        Using (New WaitCursor) 'Load Hourglass
            Dim currentIndex As Integer
            currentIndex = Caviar_FishBindingSource.Position
            Try
                Dim TagsToday As New List(Of String) 'list of tags processed today, to check for duplicate tags
                TagTextBox.DataBindings.Item("Text").WriteValue()
                For Each Fish As DataRowView In Me.Caviar_FishBindingSource
                    'DateTimePicker can be null even if the database does not exist for it, so put it is null, make it today
                    If IsDBNull(Fish.Row.Item("Harvest Date")) Then
                        Fish.Row.Item("Harvest Date") = Date.Now
                    End If

                    If IsDBNull(Fish.Row.Item("Tag")) Or Fish.Row.Item("Tag") = "" Then
                        MsgBox("Fish Tag is not entered! Please enter tag", MsgBoxStyle.Critical)
                        TagTextBox.Focus()
                        Return False
                    ElseIf TagsToday.Contains(Fish.Row.Item("Tag")) Then
                        MsgBox("Duplicate Tag for today found! Please double check", MsgBoxStyle.Critical)
                        TagTextBox.Focus()
                        TagTextBox.SelectAll()
                        Return False
                    Else
                        TagsToday.Add(Fish.Row.Item("Tag"))
                    End If

                Next

                Me.Validate()
                Me.Caviar_FishBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet)
                Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)
                Caviar_FishBindingSource.Position = currentIndex
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Return True
        End Using
    End Function

    'this sub ensures that all necessary information are entered before proceeding
    Public Sub ValidateRequiredValues()
        InformationComplete = True

        'InformationComplete = InformationComplete And ValidateTextbox(PKFishIDTextBox)
        InformationComplete = InformationComplete And ValidateTextbox(TagTextBox)
        'InformationComplete = InformationComplete And ValidateTextbox(Ovary_TotTextBox)
        'InformationComplete = InformationComplete And ValidateTextbox(Ovary_WasteTextBox)
        InformationComplete = InformationComplete And ValidateTextbox(Egg_WtTextBox)
        InformationComplete = InformationComplete And ValidateTextbox(PercentSaltTextbox)
        InformationComplete = InformationComplete And ValidateTextbox(Purge_TankTextBox)
        'InformationComplete = InformationComplete And ValidateTextbox(Live_WtTextBox)
        'InformationComplete = InformationComplete And ValidateTextbox(Gutted_WtTextBox)
        InformationComplete = InformationComplete And ValidateTextbox(SpeciesTextBox)
        If InformationComplete = True Then
            Me.BackColor = Color.LimeGreen
            BindingNavigatorAddNewItem.Enabled = True
        Else
            Me.BackColor = Color.Salmon
            BindingNavigatorAddNewItem.Enabled = False
        End If

    End Sub

#End Region

#Region "Textbox Events"
    Private Sub Purge_TankTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Purge_TankTextBox.TextChanged
        ValidateRequiredValues()
        If Not isLoading Then
            DefaultPurgeTank = Purge_TankTextBox.Text
        End If
    End Sub
    Private Sub TagTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TagTextBox.TextChanged
        ValidateRequiredValues()
    End Sub
    Private Sub Live_WtTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Live_WtTextBox.TextChanged
        ValidateRequiredValues()
    End Sub
    Private Sub Ovary_TotTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ovary_TotTextBox.TextChanged
        ValidateRequiredValues()
    End Sub
    Private Sub Ovary_WasteTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ovary_WasteTextBox.TextChanged
        ValidateRequiredValues()
    End Sub
    Private Sub Egg_WtTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Egg_WtTextBox.TextChanged
        Try
            If Not (Egg_WtTextBox.Text = "" Or PercentSaltTextbox.Text = "") Then
                SaltTextBox.Text = Math.Round(Convert.ToDecimal(PercentSaltTextbox.Text) * Convert.ToDecimal(Egg_WtTextBox.Text) / 100.0, 1)
            End If
            ValidateRequiredValues()
        Catch
        End Try
    End Sub
    Private Sub PercentSaltTextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PercentSaltTextbox.TextChanged
        Try
            If Not (Egg_WtTextBox.Text = "" Or PercentSaltTextbox.Text = "") Then
                SaltTextBox.Text = Math.Round(Convert.ToDecimal(PercentSaltTextbox.Text) * Convert.ToDecimal(Egg_WtTextBox.Text) / 100.0, 1)
            End If
            ValidateRequiredValues()
        Catch
        End Try
    End Sub
    Private Sub Gutted_WtTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gutted_WtTextBox.TextChanged
        ValidateRequiredValues()
    End Sub

    Private Sub SpeciesTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeciesTextBox.TextChanged
        ValidateRequiredValues()
    End Sub
    Private Sub Purge_TankTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Purge_TankTextBox.Validating
        If ValidateTextFormatFailed(sender, "^[A-Z]{1,2}\d{1,2}$", " 1 capital letter followed by 1 or 2 digits") Then
            e.Cancel = True
        End If
    End Sub

    Private Sub TagTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TagTextBox.Validating
        If ValidateTextFormatFailed(sender, "^[A-Z]{1,2}\d{1,4}$", " 1 capital letter followed by 1 to 4 digits") Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Live_WtTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Live_WtTextBox.Validating
        If ValidateNumberFailed(sender, 0, 100) Then
            e.Cancel = True
        End If
    End Sub
#End Region



    Private Sub Ovary_WasteTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
    Private Sub Ovary_TotTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
    Private Sub Gutted_WtTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
    Private Sub Live_WtTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
    Private Sub TagTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
    Private Sub Purge_TankTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
    Private Sub Egg_WtTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
End Class