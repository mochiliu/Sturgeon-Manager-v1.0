'This form dynamically generates controls for an user to modify the filterstring of a bindingsource
'It also generates the selectionformula for a crystal report
Public Class Filter
    Private ParentWindow As Form 'this is the form that the filter is being applied to
    Private ParentBindingSource As BindingSource 'this is the bindingsource that we are filtering
    Private TableDisplayed As DataTable 'this is the datatable being displayed by the parent window
    Private TableDisplayedName As String 'this is the name of the table (use in CR)
    Private DataBoundColumns As New List(Of DataBoundColumnForFilter) 'this contains all the databound columns such as grade, products, etc
    Public CrystalReportSelectionFormula As String = ""

#Region "Form Events"
    'custom constructor to link to parent form
    Public Sub New(ByRef myParent As Form, ByRef myBindinSource As BindingSource)
        InitializeComponent() ' This call is required by the Windows Form Designer.
        ParentWindow = myParent
        ParentBindingSource = myBindinSource
    End Sub

    Private Sub Filter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'do not close unless EditFishInventory is closed
        For Each OpenWindow In My.Application.OpenForms()
            If DirectCast(OpenWindow, Form).Name = ParentWindow.Name Then
                'parentwindow is still open
                e.Cancel = True
                Me.Hide()
            End If
        Next
    End Sub

    Private Sub Filter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FilterColumnsTableAdapter.Fill(Me.SturgeonDBDataSet.FilterColumns)
        Me.InvoiceTypeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.InvoiceTypeSelection)
        Me.Shipping_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Shipping_Addresses)
        Me.ProductCategorySelectionTableAdapter.Fill(Me.SturgeonDBDataSet.ProductCategorySelection)
        Me.Non_Inventory_Invoice_RecordsTableAdapter.Fill(Me.SturgeonDBDataSet._Non_Inventory_Invoice_Records)
        Me.InvoicesTableAdapter.Fill(Me.SturgeonDBDataSet.Invoices)
        Me.CustomersTableAdapter.Fill(Me.SturgeonDBDataSet.Customers)
        Me.Customer_PricingTableAdapter.Fill(Me.SturgeonDBDataSet.Customer_Pricing)
        Me.Caviar_InventoryTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Inventory)
        Me.Billing_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Billing_Addresses)
        Me.CaviarStatusSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarStatusSelection)
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
        Me.CaviarStatusSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarStatusSelection)
        Me.CaviarInventoryJoinCaviarFishTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarInventoryJoinCaviarFish)
        Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)

        'Determine what the parent form need us to filter for:
        Select Case ParentWindow.Name
            Case "EditFishInventory"
                TableDisplayed = SturgeonDBDataSet.Caviar_Fish
                TableDisplayedName = "Caviar Fish"
                DataBoundColumns.Add(New DataBoundColumnForFilter("Grade", SturgeonDBDataSet.GradeSelection, "ID", "Grade"))
            Case "EditInventory"
                TableDisplayed = SturgeonDBDataSet.CaviarInventoryJoinCaviarFish
                TableDisplayedName = "CaviarInventoryJoinCaviarFish"
                DataBoundColumns.Add(New DataBoundColumnForFilter("Grade", SturgeonDBDataSet.GradeSelection, "ID", "Grade"))
                DataBoundColumns.Add(New DataBoundColumnForFilter("FKProductID", SturgeonDBDataSet.Products, "PKProductID", "Product Name"))
                DataBoundColumns.Add(New DataBoundColumnForFilter("InventoryStatus", SturgeonDBDataSet.CaviarStatusSelection, "PKStatusID", "Description"))
                DataBoundColumns.Add(New DataBoundColumnForFilter("PreviousStatus", SturgeonDBDataSet.CaviarStatusSelection, "PKStatusID", "Description"))
            Case "Pricing"
                TableDisplayed = SturgeonDBDataSet.Customers
                TableDisplayedName = "Customers"
            Case "Customer"
                TableDisplayed = SturgeonDBDataSet.Customers
                TableDisplayedName = "Customers"
            Case "Product"
                TableDisplayed = SturgeonDBDataSet.Products
                TableDisplayedName = "Products"
                DataBoundColumns.Add(New DataBoundColumnForFilter("Grade", SturgeonDBDataSet.GradeSelection, "ID", "Grade"))
                DataBoundColumns.Add(New DataBoundColumnForFilter("ProductCategory", SturgeonDBDataSet.ProductCategorySelection, "ProductCategoryID", "Description"))
            Case "Invoice"
                TableDisplayed = SturgeonDBDataSet.Invoices
                TableDisplayedName = "Invoices"
                DataBoundColumns.Add(New DataBoundColumnForFilter("FKCustomerID", SturgeonDBDataSet.Customers, "PKCustomerID", "Company Name"))
                DataBoundColumns.Add(New DataBoundColumnForFilter("FKBillingAddressID", SturgeonDBDataSet.Billing_Addresses, "PKBillingAddressID", "FullAddress"))
                DataBoundColumns.Add(New DataBoundColumnForFilter("FKShippingAddressID", SturgeonDBDataSet.Shipping_Addresses, "PKShippingAddressID", "FullAddress"))
                DataBoundColumns.Add(New DataBoundColumnForFilter("InvoiceType", SturgeonDBDataSet.InvoiceTypeSelection, "PKTypeID", "Description"))
            Case "PostProcessingData"
                TableDisplayed = SturgeonDBDataSet.Caviar_Fish
                TableDisplayedName = "Caviar Fish"
                DataBoundColumns.Add(New DataBoundColumnForFilter("Grade", SturgeonDBDataSet.GradeSelection, "ID", "Grade"))
        End Select

        InitializeComboBox()
    End Sub
    'this populates the combobox with a list of columns as choices for the user to filter
    Private Sub InitializeComboBox()
        Dim I As Integer
        Dim ScoredColumns() As SturgeonDBDataSet.FilterColumnsRow = SturgeonDBDataSet.FilterColumns.Select("TableName = '" & TableDisplayedName & "'")
        Dim ColumnsAccountedFor As New List(Of String) 'these are the columns that have been processed already

        For Each ScoredColumn In ScoredColumns
            'add the columns with popularity scores first
            If ScoredColumn.Displayed And TableDisplayed.Columns.Contains(ScoredColumn.ColumnName) Then
                Try
                    FilterSelectionComboBox.Items.Add(New ComboBoxObjectForFilter(ScoredColumn.ColumnName, ScoredColumn.DisplayedColumnName))
                Catch ex As System.Data.StrongTypingException
                    'dbnull for scoredcolumn.displayedcolumnname
                    FilterSelectionComboBox.Items.Add(New ComboBoxObjectForFilter(ScoredColumn.ColumnName, ScoredColumn.ColumnName))
                End Try
            End If
            ColumnsAccountedFor.Add(ScoredColumn.ColumnName)
        Next

        For I = 0 To TableDisplayed.Columns.Count - 1
            'add the rest of the columns (nor scored) only if it was not added before
            If Not ColumnsAccountedFor.Contains(TableDisplayed.Columns(I).ColumnName) Then
                FilterSelectionComboBox.Items.Add(New ComboBoxObjectForFilter(TableDisplayed.Columns(I).ColumnName, TableDisplayed.Columns(I).ColumnName))
            End If
        Next
        FilterSelectionComboBox.SelectedIndex = 0
    End Sub

#End Region

#Region "Filter Evemts"
    Private Sub AddFilterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFilterButton.Click
        AddToFilter(DirectCast(FilterSelectionComboBox.SelectedItem, ComboBoxObjectForFilter).OriginalColumnName)
        IncreaseColumnScore(DirectCast(FilterSelectionComboBox.SelectedItem, ComboBoxObjectForFilter).OriginalColumnName)
    End Sub

    'add to the popularity score of that column
    Public Sub IncreaseColumnScore(ByVal ColumnName As String)
        Dim ScoredColumns() As SturgeonDBDataSet.FilterColumnsRow = SturgeonDBDataSet.FilterColumns.Select("TableName = '" & TableDisplayedName & "' and ColumnName = '" & ColumnName & "'")
        If ScoredColumns.Count > 0 Then
            'only change the first entry if there are multiple entries
            ScoredColumns(0).PopularityScore += 1
            FilterColumnsTableAdapter.Update(ScoredColumns(0))
        End If
    End Sub

    'Adds a groupbox representing a filter for a specific column
    Public Function AddToFilter(ByVal ColumnName As String) As GroupBox

        'loop through all of Caviar Fish's columns and depending on different datatype, display different filter selections, but only if the column matches ColumnName provided
        Dim I As Integer
        For I = 0 To TableDisplayed.Columns.Count - 1

            If Not TableDisplayed.Columns(I).ColumnName = ColumnName Then
                Continue For 'skip to the next iteration if it is not the column specified
            End If

            Dim SpecialColumn As DataBoundColumnForFilter = Nothing
            'check if the data column is handled in a special manner (databinding)
            For Each Column In DataBoundColumns
                If TableDisplayed.Columns(I).ColumnName = Column.ColumnName Then
                    SpecialColumn = Column
                End If
            Next

            'add a new groupbox
            Dim newGroupBox As GroupBox = New GroupBox
            newGroupBox.Text = TableDisplayed.Columns(I).ColumnName
            newGroupBox.Width = 250
            FlowLayoutPanel.Controls.Add(newGroupBox)
            If IsNothing(SpecialColumn) Then
                newGroupBox.Tag = TableDisplayed.Columns(I).DataType() 'store the datatype stored in the groupbox
            Else
                newGroupBox.Tag = SpecialColumn 'store the special properties in the groupbox if the column is special
            End If

            'add the delete button for the groupbox (it is item(0))
            Dim DeleteButton As Button = New Button
            newGroupBox.Controls.Add(DeleteButton)
            DeleteButton.Location = New Point(150, 0)
            DeleteButton.Text = "Delete"
            AddHandler DeleteButton.Click, AddressOf DeleteButton_Click

            'add the logic combobox for the groupbox (it is item(1))
            Dim LogicComboBox As ComboBox = New ComboBox
            newGroupBox.Controls.Add(LogicComboBox)
            With LogicComboBox
                .Location = New Point(0, 50)
                .Items.Add(" OR ")
                .Items.Add(" AND ")
                .Items.Add(" ) OR ")
                .Items.Add(" ) AND ")
                .Items.Add(" OR ( ")
                .Items.Add(" AND ( ")
                .Items.Add(" ) OR ( ")
                .Items.Add(" ) AND ( ")
                .SelectedIndex = 0 'select AND operator by default
                .DropDownStyle = ComboBoxStyle.DropDownList
                .Width = 70
                AddHandler .SelectedIndexChanged, AddressOf RefreshFilterString
            End With

            'add different controls depending on the the datatype
            If Not IsNothing(SpecialColumn) Then
                'the column is a databound selection
                Dim newComboBox As ComboBox = New ComboBox
                newGroupBox.Controls.Add(newComboBox)
                With newComboBox 'it is item(2)
                    .Location = New Point(80, 50)
                    Dim myBindingSouce As BindingSource = New BindingSource()
                    myBindingSouce.DataSource = SpecialColumn.DataSource
                    .DataSource = myBindingSouce
                    .DisplayMember = SpecialColumn.DisplayMemberColumn
                    .ValueMember = SpecialColumn.ValueMemberColumn
                    .DropDownStyle = ComboBoxStyle.DropDown
                    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    .AutoCompleteSource = AutoCompleteSource.ListItems
                    .SelectedIndex = 0
                    AddHandler .SelectedIndexChanged, AddressOf RefreshFilterString
                    AddHandler .KeyDown, AddressOf FilterControlKeyDown
                End With

                Dim newLabel As Label = New Label
                newGroupBox.Controls.Add(newLabel)
                newLabel.Location = New Point(80, 30)
                newLabel.Text = "Search for:"

            ElseIf TableDisplayed.Columns(I).DataType() Is GetType(System.String) Then
                'if the datatype is a string, add a single textbox and a label
                Dim newTexBox As TextBox = New TextBox
                newGroupBox.Controls.Add(newTexBox)
                With newTexBox 'it is item(2)
                    .Location = New Point(80, 50)
                    AddHandler .TextChanged, AddressOf RefreshFilterString
                    AddHandler .KeyDown, AddressOf FilterControlKeyDown
                End With

                Dim newLabel As Label = New Label
                newGroupBox.Controls.Add(newLabel)
                newLabel.Location = New Point(80, 30)
                newLabel.Text = "Search for:"

            ElseIf TableDisplayed.Columns(I).DataType() Is GetType(System.DateTime) Then
                'adjust the groupbox size to fit
                newGroupBox.Width = 300
                newGroupBox.Height = 110
                'add two datetimepickers along with accompanying labels for start and end time for a datetime object
                Dim startTimePicker As DateTimePicker = New DateTimePicker
                newGroupBox.Controls.Add(startTimePicker)
                With startTimePicker 'it is item(2)
                    .Location = New Point(80, 40)
                    .Value = Date.Now
                    AddHandler .ValueChanged, AddressOf RefreshFilterString
                    AddHandler .KeyDown, AddressOf FilterControlKeyDown
                End With

                Dim endTimePicker As DateTimePicker = New DateTimePicker
                newGroupBox.Controls.Add(endTimePicker)
                With endTimePicker 'it is item(3)
                    .Location = New Point(80, 80)
                    .Value = Date.Now
                    AddHandler .ValueChanged, AddressOf RefreshFilterString
                    AddHandler .KeyDown, AddressOf FilterControlKeyDown
                End With

                Dim startTimeLabel As Label = New Label
                newGroupBox.Controls.Add(startTimeLabel)
                startTimeLabel.Location = New Point(80, 20)
                startTimeLabel.Text = "Pick a begin time:"

                Dim endTimeLabel As Label = New Label
                newGroupBox.Controls.Add(endTimeLabel)
                endTimeLabel.Location = New Point(80, 60)
                endTimeLabel.Text = "Pick a end time:"

            ElseIf TableDisplayed.Columns(I).DataType() Is GetType(System.Boolean) Then
                Dim newCheckBox As CheckBox = New CheckBox 'it is item(2)
                newGroupBox.Controls.Add(newCheckBox)
                With newCheckBox
                    .Location = New Point(80, 50)
                    .Text = "Is " & newGroupBox.Text
                    AddHandler .CheckedChanged, AddressOf RefreshFilterString
                End With

            Else 'type are numbers: Int32, Double
                newGroupBox.Height = 150 'expand the size of the groupbox

                Dim smallerThanTextBox As TextBox = New TextBox 'it is item(2)
                newGroupBox.Controls.Add(smallerThanTextBox)
                smallerThanTextBox.Location = New Point(80, 40)
                AddHandler smallerThanTextBox.TextChanged, AddressOf RefreshFilterString
                AddHandler smallerThanTextBox.KeyDown, AddressOf FilterControlKeyDown

                Dim largerThanTextBox As TextBox = New TextBox 'it is item(3)
                newGroupBox.Controls.Add(largerThanTextBox)
                largerThanTextBox.Location = New Point(80, 80)
                AddHandler largerThanTextBox.TextChanged, AddressOf RefreshFilterString
                AddHandler largerThanTextBox.KeyDown, AddressOf FilterControlKeyDown

                Dim equalToTextBox As TextBox = New TextBox 'it is item(4)
                newGroupBox.Controls.Add(equalToTextBox)
                equalToTextBox.Location = New Point(80, 120)
                AddHandler equalToTextBox.TextChanged, AddressOf RefreshFilterString
                AddHandler equalToTextBox.KeyDown, AddressOf FilterControlKeyDown

                Dim smallerThanLabel As Label = New Label
                newGroupBox.Controls.Add(smallerThanLabel)
                smallerThanLabel.Location = New Point(80, 20)
                smallerThanLabel.Width = 200
                smallerThanLabel.Text = "Smaller Than (not used when empty):"

                Dim largerThanLabel As Label = New Label
                newGroupBox.Controls.Add(largerThanLabel)
                largerThanLabel.Location = New Point(80, 60)
                largerThanLabel.Width = 200
                largerThanLabel.Text = "Larger Than (not used when empty):"

                Dim equalToLabel As Label = New Label
                newGroupBox.Controls.Add(equalToLabel)
                equalToLabel.Location = New Point(80, 100)
                equalToLabel.Width = 200
                equalToLabel.Text = "Equal To (not used when empty):"
            End If
            RefreshFilterString(Nothing, Nothing)
            newGroupBox.Controls(2).Focus() 'set the cursor to the first input control
            Return newGroupBox
        Next

        Return Nothing
    End Function

    'Deletes the entire groupbox along with its cotrols in the flowpanel
    Private Sub DeleteButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim myDeleteButton As Button = DirectCast(sender, Button)
        Dim myGroupBox As GroupBox = DirectCast(myDeleteButton.Parent, GroupBox)
        For Each myControl As Control In myGroupBox.Controls
            myGroupBox.Controls.Remove(myControl)
            myControl.Dispose()
        Next
        FlowLayoutPanel.Controls.Remove(myGroupBox)
        myGroupBox.Dispose()
        RefreshFilterString(Nothing, Nothing)
    End Sub

    Public Sub ApplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyButton.Click
        Try
            RefreshFilterString(Nothing, Nothing)
            If MatchParentheses(FilterStringTextBox.Text) Then
                ParentBindingSource.Filter = FilterStringTextBox.Text
                Me.Hide()
            Else
                MsgBox("Parenthesis do not match!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'KeyDown event for filter controls
    Private Sub FilterControlKeyDown(ByVal sender As Object, ByVal e As EventArgs)
        Dim eArgs As KeyEventArgs = DirectCast(e, KeyEventArgs)
        If eArgs.KeyCode = Keys.Enter Then
            ApplyButton_Click(Nothing, Nothing)
        End If
    End Sub

    'resets the filterstring display and hides the logic combobox of the first groupbox
    Private Sub RefreshFilterString(ByVal sender As Object, ByVal e As EventArgs)
        'loop through the groupboxes in flowlayoutpanel and hide the logic for the first groupbox
        Dim FirstOne As Boolean = True
        For Each CurrentGroupBox In FlowLayoutPanel.Controls
            If FirstOne Then
                DirectCast(DirectCast(CurrentGroupBox, GroupBox).Controls(1), ComboBox).Visible = False
                FirstOne = False
            Else
                DirectCast(DirectCast(CurrentGroupBox, GroupBox).Controls(1), ComboBox).Visible = True
            End If
        Next

        Dim FilterString As String = "("
        CrystalReportSelectionFormula = "("
        'loop through all the groupboxes in the flowcontrol
        For Each CurrentControl In FlowLayoutPanel.Controls
            Dim CurrentGroupBox As GroupBox = DirectCast(CurrentControl, GroupBox)
            Dim CurrentLogicComboBox As ComboBox = DirectCast(CurrentGroupBox.Controls.Item(1), ComboBox) 'the logic combobox is item(1)
            'add the operator if the logiccombobox (item(1)) is visible
            If CurrentLogicComboBox.Visible Then
                FilterString = FilterString & CurrentLogicComboBox.Text
                CrystalReportSelectionFormula = CrystalReportSelectionFormula & CurrentLogicComboBox.Text
            End If

            'filter differently depedning on what the groupbox datatype is
            If CurrentGroupBox.Tag.GetType Is GetType(DataBoundColumnForFilter) Then
                'use the equals filter to filter databound columns
                FilterString = FilterString & "[" & CurrentGroupBox.Text & "] = " & DirectCast(CurrentGroupBox.Controls.Item(2), ComboBox).SelectedValue & " " 'we know that the item(2) is a combobox in the special case
                CrystalReportSelectionFormula = CrystalReportSelectionFormula & "ToNumber({" & TableDisplayedName & "." & CurrentGroupBox.Text & "}) = " & DirectCast(CurrentGroupBox.Controls.Item(2), ComboBox).SelectedValue & " " 'we know that the item(2) is a combobox in the special case
            ElseIf CurrentGroupBox.Tag Is GetType(System.String) Then
                'use the like filter command for a string
                FilterString = FilterString & "[" & CurrentGroupBox.Text & "] like '%" & DirectCast(CurrentGroupBox.Controls.Item(2), TextBox).Text & "%'" 'we know that the item(2) is a textbox in the string case
                CrystalReportSelectionFormula = CrystalReportSelectionFormula & "{" & TableDisplayedName & "." & CurrentGroupBox.Text & "} LIKE '*" & DirectCast(CurrentGroupBox.Controls.Item(2), TextBox).Text & "*' " 'we know that the item(2) is a textbox in the string case
            ElseIf CurrentGroupBox.Tag Is GetType(System.DateTime) Then
                'filter between the two dates if the the groupbox contains time data
                Dim startTime As Date = DirectCast(CurrentGroupBox.Controls.Item(2), DateTimePicker).Value 'we know item(2) is startDateTimePicker
                Dim endTime As Date = DirectCast(CurrentGroupBox.Controls.Item(3), DateTimePicker).Value 'we know item(3) is endDateTimePicker
                FilterString = FilterString & "[" & CurrentGroupBox.Text & String.Format("] >= #{0:M/dd/yyyy} 00:00:00# AND [", startTime) & CurrentGroupBox.Text & String.Format("] < #{0:M/dd/yyyy} 00:00:00#", endTime.AddDays(1))
                CrystalReportSelectionFormula = CrystalReportSelectionFormula & "({" & TableDisplayedName & "." & CurrentGroupBox.Text & "} >= " & String.Format("#{0:M/dd/yyyy} 00:00:00#", startTime) & ") AND ({" & TableDisplayedName & "." & CurrentGroupBox.Text & "} <= " & String.Format("#{0:M/dd/yyyy} 00:00:00#", endTime.AddDays(1)) & ")"
            ElseIf CurrentGroupBox.Tag Is GetType(System.Boolean) Then
                'filter for the checked value
                FilterString = FilterString & "[" & CurrentGroupBox.Text & "] =" & DirectCast(CurrentGroupBox.Controls.Item(2), CheckBox).Checked.ToString 'we know that the item(2) is a checkbox
                CrystalReportSelectionFormula = CrystalReportSelectionFormula & "{" & TableDisplayedName & "." & CurrentGroupBox.Text & "} = " & DirectCast(CurrentGroupBox.Controls.Item(2), CheckBox).Checked.ToString 'we know that the item(2) is a checkbox
            Else 'numbers
                Dim tempFilterString As String = "" 'filter string for this numbers field only
                Dim tempSelectionFormulaString As String = "" 'crystal reports selection string
                'filter for smaller than
                Dim smallerThanValue As String = DirectCast(CurrentGroupBox.Controls.Item(2), TextBox).Text
                If Not smallerThanValue = "" Then ' if the field is not blank
                    tempFilterString = tempFilterString & "[" & CurrentGroupBox.Text & "] < " & smallerThanValue
                    tempSelectionFormulaString = tempSelectionFormulaString & "{" & TableDisplayedName & "." & CurrentGroupBox.Text & "} < " & smallerThanValue
                End If
                'filter for larger than
                Dim largerThanValue As String = DirectCast(CurrentGroupBox.Controls.Item(3), TextBox).Text
                If Not largerThanValue = "" Then ' if the field is not blank
                    If Not tempFilterString = "" Then
                        tempFilterString = tempFilterString & " AND "
                        tempSelectionFormulaString = tempSelectionFormulaString & " AND "
                    End If
                    tempFilterString = tempFilterString & "[" & CurrentGroupBox.Text & "] > " & largerThanValue
                    tempSelectionFormulaString = tempSelectionFormulaString & "{" & TableDisplayedName & "." & CurrentGroupBox.Text & "} > " & largerThanValue
                End If
                'filter for equal to
                Dim equalToValue As String = DirectCast(CurrentGroupBox.Controls.Item(4), TextBox).Text
                If Not equalToValue = "" Then ' if the field is not blank
                    If Not tempFilterString = "" Then
                        tempFilterString = tempFilterString & " AND "
                        tempSelectionFormulaString = tempSelectionFormulaString & " AND "
                    End If
                    tempFilterString = tempFilterString & "[" & CurrentGroupBox.Text & "] = " & equalToValue
                    tempSelectionFormulaString = tempSelectionFormulaString & "{" & TableDisplayedName & "." & CurrentGroupBox.Text & "} = " & equalToValue
                End If
                FilterString = FilterString & tempFilterString
                CrystalReportSelectionFormula = CrystalReportSelectionFormula & tempSelectionFormulaString
            End If
        Next
        FilterString = FilterString & ")"
        CrystalReportSelectionFormula = CrystalReportSelectionFormula & ")"
        If FilterString = "()" Then
            FilterString = ""
        End If
        If CrystalReportSelectionFormula = "()" Then
            CrystalReportSelectionFormula = ""
        End If
        FilterStringTextBox.Text = FilterString
        If MatchParentheses(FilterString) Then
            FilterStringTextBox.BackColor = Color.Lime
        Else
            FilterStringTextBox.BackColor = Color.Red
        End If
    End Sub
#End Region

End Class