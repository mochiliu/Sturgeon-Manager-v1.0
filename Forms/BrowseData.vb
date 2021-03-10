Imports System.Windows.Forms.DataVisualization.Charting

Public Class BrowseData
    Public SourceXML As XDocument
    Private OriginalTable As DataTable 'this is the original Datatable
    Private isDragging As Boolean = False
    Private ChartDragged As Chart = Nothing
    Private DragHitTest As HitTestResult = Nothing

    Private Sub BrowseData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.CaviarFlatTable' table. You can move, or remove it, as needed.
        Me.CaviarFlatTableTableAdapter.Fill(Me.SturgeonDBDataSet.CaviarFlatTable)
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
        Me.Caviar_FishTableAdapter.Fill(Me.SturgeonDBDataSet.Caviar_Fish)

    End Sub

    Public Function LoadXML(ByVal Path As String) As Boolean
        Try
            SourceXML = XDocument.Load(Path)
            If SourceXML.Root.Name <> "SMBrowseXML" Then
                MsgBox("Incorrect XML format")
                Return False
            End If
            Me.Text = SourceXML.Root.Element("Name").Value


            Dim FilteredDataView As DataView = New DataView(SturgeonDBDataSet.Tables(SourceXML.Root.Element("DataTable").Value), SourceXML.Root.Element("Filter").Value, SourceXML.Root.Element("Sort").Value, DataViewRowState.CurrentRows)
            OriginalTable = FilteredDataView.ToTable

            'OriginalTable = SturgeonDBDataSet.Tables(SourceXML.Root.Element("DataTable").Value)
            Dim myFlowLayoutPanel As FlowLayoutPanel = GetNextFlowLayoutPlanel(Nothing, SourceXML.Root)
            AddChart(OriginalTable, myFlowLayoutPanel, DirectCast(DirectCast(myFlowLayoutPanel.Controls(0), Controls.AutoDropDownWidthComboBox).SelectedItem, ComboBoxObjectForBrowseData).ChartXElement, "ROOT")

        Catch ex As Exception
            MsgBox("XML loading error! " & ex.Message)
            Return False
        End Try
        Return True

    End Function

    Public Function GetNextFlowLayoutPlanel(ByRef CurrentFlowLayoutPlanel As FlowLayoutPanel, ByVal inputXMLElement As XElement) As FlowLayoutPanel
        If IsNothing(CurrentFlowLayoutPlanel) OrElse _
        MainFlowLayoutPanel.Controls.GetChildIndex(CurrentFlowLayoutPlanel) = MainFlowLayoutPanel.Controls.Count - 1 Then
            'form load or the current panel is the last one, make new panel
            Return NewFlowLayoutPlanel(inputXMLElement)
        Else
            Dim NextPanelIndex As Integer = MainFlowLayoutPanel.Controls.GetChildIndex(CurrentFlowLayoutPlanel) + 1
            If XNode.DeepEquals(DirectCast(DirectCast(MainFlowLayoutPanel.Controls(NextPanelIndex), FlowLayoutPanel).Tag, XElement), inputXMLElement) Then
                'if the next panel uses the same XML, simply use the next panel
                Return MainFlowLayoutPanel.Controls(NextPanelIndex)
            Else
                'delete the next panel and all subsequent panels
                For I As Integer = MainFlowLayoutPanel.Controls.Count - 1 To MainFlowLayoutPanel.Controls.GetChildIndex(CurrentFlowLayoutPlanel) Step -1
                    MainFlowLayoutPanel.Controls.RemoveAt(I)
                Next
                'make new panel
                Return NewFlowLayoutPlanel(inputXMLElement)
            End If
        End If
    End Function

    Public Function NewFlowLayoutPlanel(ByVal inputXMLElement As XElement) As FlowLayoutPanel
        'add a new flowlayout panel for displaying the first level of charts
        NewFlowLayoutPlanel = New FlowLayoutPanel
        NewFlowLayoutPlanel.AutoSize = True
        NewFlowLayoutPlanel.FlowDirection = FlowDirection.TopDown
        NewFlowLayoutPlanel.BorderStyle = BorderStyle.FixedSingle
        'Store the subcharts and this chart's properties as the tag
        NewFlowLayoutPlanel.Tag = inputXMLElement

        MainFlowLayoutPanel.Controls.Add(NewFlowLayoutPlanel)

        'add the chart selection AutoDropDownWidthComboBox
        Dim ChartTypeSelectionCombobox As New Controls.AutoDropDownWidthComboBox
        AddHandler ChartTypeSelectionCombobox.SelectedIndexChanged, AddressOf ChartTypeSelectionCombox_SelectedIndexChanged
        NewFlowLayoutPlanel.Controls.Add(ChartTypeSelectionCombobox)
        For Each XMLChart As XElement In inputXMLElement.Elements("Chart")
            'add the AutoDropDownWidthComboBox that allows the user to choose different chart types
            ChartTypeSelectionCombobox.Items.Add(New ComboBoxObjectForBrowseData(XMLChart.Element("ChartName").Value, XMLChart))
        Next
        ChartTypeSelectionCombobox.SelectedIndex = 0

        Return NewFlowLayoutPlanel
    End Function

    Public Function AddChart(ByVal FilteredTable As DataTable, ByRef myFlowLayoutPlanel As FlowLayoutPanel, ByVal XMLChart As XElement, Optional ByVal Title As String = "")
        'check if the chart already exists
        For Each Contrl In myFlowLayoutPlanel.Controls
            If TypeOf Contrl Is Chart AndAlso XNode.DeepEquals(DirectCast(DirectCast(Contrl, Chart).Tag, XElement), XMLChart) AndAlso TablesEqual(FilteredTable, DirectCast(DirectCast(Contrl, Chart).DataSource, DataTable)) Then
                MsgBox("Table is Displayed")
                Return False
            End If
        Next

        Dim myChartControl As Chart = New Chart
        'Store the subcharts and this chart's properties as the tag
        myChartControl.Tag = XMLChart

        myChartControl.DataSource = FilteredTable
        myChartControl.ChartAreas.Add("DefaultArea")
        Dim newTitle As New Title(Title, Docking.Top, New Font("Verdana", 12), Color.Black)
        myChartControl.Titles.Add(newTitle)
        'myChartControl.ChartAreas.Add("DisplayArea")

        myChartControl.Series.Add("DefaultSeries")
        myChartControl.Series("DefaultSeries").XValueMember = XMLChart.Element("XVar").Value
        myChartControl.Series("DefaultSeries").YValuesPerPoint = 1
        myChartControl.Series("DefaultSeries").YValueMembers = XMLChart.Element("YVar").Value
        myChartControl.Series("DefaultSeries").ChartArea = "DefaultArea"
        myChartControl.DataBind()

        'myChartControl.Series("DefaultSeries").YValuesPerPoint = 3
        Dim DataManipulation As XElement = XMLChart.Element("DataManipulation")
        If Not IsNothing(DataManipulation.Value) Then
            myChartControl.DataManipulator.Sort(DataVisualization.Charting.PointSortOrder.Ascending, "X", "DefaultSeries")
            myChartControl.DataManipulator.Group(DataManipulation.Element("Formula").Value, 1, GetIntervalType(DataManipulation.Element("IntervalType").Value), "DefaultSeries") ', "ProcessingSeries")
            'myChartControl.DataManipulator.Filter(CompareMethod.EqualTo, 1, "DefaultSeries", "DefaultSeries", "Grade")
            If Not IsNothing(DataManipulation.Element("XVarLabel")) Then
                'custom X axis labels
                For Each P In myChartControl.Series("DefaultSeries").Points
                    Dim R As DataRow() = FilteredTable.Select(XMLChart.Element("XVar").Value & " = " & P.XValue)
                    If Not IsNothing(R) Then
                        P.AxisLabel = R(0).Item(DataManipulation.Element("XVarLabel").Value)
                    End If
                Next
            End If
        End If


        myChartControl.Series("DefaultSeries").ChartType = GetChartType(XMLChart.Element("ChartType").Value)
        'For Each Point In myChartControl.Series("ProcessingSeries").Points
        '    myChartControl.Series("DefaultSeries").Points.AddXY(Point.XValue, Point.YValues(0))
        'Next

        'lengend
        myChartControl.Legends.Add("DefaultLegend")
        myChartControl.Legends("DefaultLegend").Enabled = True
        myChartControl.Legends("DefaultLegend").Docking = DataVisualization.Charting.Docking.Right
        myChartControl.Series("DefaultSeries").IsVisibleInLegend = True


        'set the appearance
        myChartControl.BackColor = Control.DefaultBackColor
        myChartControl.Legends("DefaultLegend").BackColor = Control.DefaultBackColor
        myChartControl.ChartAreas("DefaultArea").BackColor = Control.DefaultBackColor
        myChartControl.Width = 500
        myChartControl.Series("DefaultSeries").IsValueShownAsLabel = True
        myChartControl.Series("DefaultSeries").SmartLabelStyle.Enabled = True
        myChartControl.ChartAreas("DefaultArea").Area3DStyle.Enable3D = True
        myChartControl.AllowDrop = True

        'add event handling
        AddHandler myChartControl.MouseMove, AddressOf Chart_MouseMove
        AddHandler myChartControl.MouseDown, AddressOf Chart_MouseDown
        AddHandler myChartControl.GetToolTipText, AddressOf Chart_GetToolTipText
        AddHandler myChartControl.DragEnter, AddressOf Chart_DragEnter
        AddHandler myChartControl.DragDrop, AddressOf Chart_DragDrop
        AddHandler myChartControl.QueryContinueDrag, AddressOf Chart_QueryContinueDrag

        myFlowLayoutPlanel.Controls.Add(myChartControl)

        Return True
    End Function

#Region "FlowEvents"

    Private Sub ChartTypeSelectionCombox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim CurrentComboBox = DirectCast(sender, Controls.AutoDropDownWidthComboBox)
        Dim CurrentFlowLayoutPlanel = DirectCast(CurrentComboBox.Parent, FlowLayoutPanel)

        'remove all flows after this one
        For I As Integer = MainFlowLayoutPanel.Controls.Count - 1 To MainFlowLayoutPanel.Controls.GetChildIndex(CurrentFlowLayoutPlanel) + 1 Step -1
            MainFlowLayoutPanel.Controls.RemoveAt(I)
        Next

        'remake all the charts using new selection
        For Each Contrl In CurrentFlowLayoutPlanel.Controls
            If TypeOf Contrl Is Chart Then
                If AddChart(DirectCast(Contrl, Chart).DataSource, CurrentFlowLayoutPlanel, DirectCast(CurrentComboBox.SelectedItem, ComboBoxObjectForBrowseData).ChartXElement) Then
                    CurrentFlowLayoutPlanel.Controls.Remove(Contrl)
                End If
            End If
        Next
    End Sub


#End Region


#Region "Chart Events"

    Private Sub Chart_GetToolTipText(ByVal sender As Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs)
        Select Case e.HitTestResult.ChartElementType
            Case ChartElementType.DataPoint
                If e.HitTestResult.PointIndex >= 0 Then
                    'Dim strKey As String = DirectCast(sender, Chart).Series("DefaultSeries").Points(e.HitTestResult.PointIndex).LegendText
                    Dim strKey As String = DirectCast(sender, Chart).Series("DefaultSeries").Points(e.HitTestResult.PointIndex).AxisLabel
                    Dim strValue As String = (DirectCast(sender, Chart).Series("DefaultSeries").Points(e.HitTestResult.PointIndex).YValues(0))
                    If strKey <> "" Then
                        e.Text = strKey & ", " & strValue
                    Else
                        e.Text = strValue
                    End If
                End If
        End Select
    End Sub

    Private Sub Chart_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        Dim htrResult As HitTestResult = sender.HitTest(e.X, e.Y)
        'Go through points setting design elements back to default
        For Each dp As DataPoint In sender.Series("DefaultSeries").Points
            dp.BackSecondaryColor = Color.White
            dp.BackHatchStyle = ChartHatchStyle.None
            dp.BorderWidth = 0
        Next dp
        'If users mouse hovers over a datapoint or it's equivalent Legend Item then set cursor to hand to indicate that it is a link
        'Also we use some design elements to indicate which DataPoint is active
        If htrResult.PointIndex >= 0 Then
            If htrResult.ChartElementType = ChartElementType.DataPoint Or htrResult.ChartElementType = ChartElementType.LegendItem Then
                Me.Cursor = Cursors.Hand
                Dim dpSelected As DataPoint
                dpSelected = sender.Series("DefaultSeries").Points(htrResult.PointIndex)
                dpSelected.BackSecondaryColor = Color.Black
                dpSelected.BorderColor = Color.White
                dpSelected.BorderWidth = 5
            End If
        Else
            'Set cursor back to default when leaving selected datapoint
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub Chart_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim myChart As Chart = DirectCast(sender, Chart)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isDragging = True
            ChartDragged = myChart
            DragHitTest = sender.HitTest(e.X, e.Y)
            myChart.DoDragDrop(myChart.Titles(0), DragDropEffects.Copy)
        End If
    End Sub

    Private Sub Chart_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim myChart As Chart = DirectCast(sender, Chart)
        If isDragging AndAlso myChart IsNot ChartDragged AndAlso myChart.Parent Is ChartDragged.Parent Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub Chart_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim myChart As Chart = DirectCast(sender, Chart)

        If isDragging AndAlso myChart IsNot ChartDragged AndAlso myChart.Parent Is ChartDragged.Parent Then
            'one chart is dragged into another belonging in the same tier
            Dim MergedTable As DataTable = DirectCast(myChart.DataSource, DataTable).Copy
            MergedTable.Merge(DirectCast(ChartDragged.DataSource, DataTable))
            AddChart(MergedTable, myChart.Parent, myChart.Tag, "")
            'DirectCast(myChart.Parent, FlowLayoutPanel).Controls.Remove(ChartDragged)
        End If
        ChartDragged = Nothing
        isDragging = False
        DragHitTest = Nothing
    End Sub


    Private Sub Chart_QueryContinueDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.QueryContinueDragEventArgs)
        'Dim myChart As Chart = DirectCast(sender, Chart)
        'Get rect of dragged chart
        Dim rect As New Rectangle(ChartDragged.PointToScreen(Point.Empty), New Size(ChartDragged.Width, ChartDragged.Height))

        'If the left mouse button is up and the mouse is currently over the dragged chart
        If Control.MouseButtons <> MouseButtons.Left AndAlso rect.Contains(Control.MousePosition) Then
            'Cancel the DragDrop Action
            e.Action = DragAction.Cancel
            Dim myChart As Chart = ChartDragged
            Dim htrResult As HitTestResult = DragHitTest
            If htrResult IsNot Nothing AndAlso htrResult.ChartElementType = ChartElementType.DataPoint AndAlso htrResult.PointIndex >= 0 Then
                Dim FilterString As String = ""
                Dim FormattedXValue As String = ""
                Dim XMLChart As XElement = DirectCast(myChart.Tag, XElement)
                If IsNothing(XMLChart.Element("Chart")) Then
                    Exit Sub
                End If
                Dim DataManipulation As XElement = XMLChart.Element("DataManipulation")
                If Not IsNothing(DataManipulation.Value) Then 'And XMLChart.Element("XType").Value = "date" Then
                    If XMLChart.Element("XType").Value = "date" Then
                        Dim StartDate As Date = Date.FromOADate(myChart.Series("DefaultSeries").Points(htrResult.PointIndex).XValue)
                        Dim EndDate As Date
                        Select Case DataManipulation.Element("IntervalType").Value
                            Case "year"
                                EndDate = StartDate.AddYears(Convert.ToDouble(DataManipulation.Element("Interval").Value))
                            Case "month"
                                EndDate = StartDate.AddMonths(Convert.ToDouble(DataManipulation.Element("Interval").Value))
                            Case "week"
                                EndDate = StartDate.AddDays(Convert.ToDouble(DataManipulation.Element("Interval").Value) * 7)
                            Case "day"
                                EndDate = StartDate.AddDays(Convert.ToDouble(DataManipulation.Element("Interval").Value))
                        End Select
                        FilterString = "[" & XMLChart.Element("XVar").Value & String.Format("] >= #{0:M/dd/yyyy} 00:00:00# AND ", StartDate) & "[" & XMLChart.Element("XVar").Value & String.Format("] <= #{0:M/dd/yyyy} 00:00:00#", EndDate)
                        FormattedXValue = "Between " & StartDate.ToShortDateString & " and " & EndDate.ToShortDateString
                    Else
                        FilterString = "[" & XMLChart.Element("XVar").Value & "] = " & myChart.Series("DefaultSeries").Points(htrResult.PointIndex).XValue
                        If myChart.Series("DefaultSeries").Points(htrResult.PointIndex).AxisLabel <> "" Then
                            FormattedXValue = myChart.Series("DefaultSeries").Points(htrResult.PointIndex).AxisLabel
                        Else
                            FormattedXValue = myChart.Series("DefaultSeries").Points(htrResult.PointIndex).XValue
                        End If
                    End If
                End If

                Dim FilteredDataView As DataView = New DataView(DirectCast(myChart.DataSource, DataTable), FilterString, "", DataViewRowState.CurrentRows)
                Dim FilteredDataTable As DataTable = FilteredDataView.ToTable

                Dim myFlowLayoutPanel As FlowLayoutPanel = GetNextFlowLayoutPlanel(myChart.Parent, XMLChart)
                AddChart(FilteredDataTable, myFlowLayoutPanel, DirectCast(DirectCast(myFlowLayoutPanel.Controls(0), Controls.AutoDropDownWidthComboBox).SelectedItem, ComboBoxObjectForBrowseData).ChartXElement, myChart.Titles(0).Text & " - " & XMLChart.Element("XVar").Value & " = " & FormattedXValue)
            End If

            ChartDragged = Nothing
            isDragging = False
            DragHitTest = Nothing
        End If
    End Sub
#End Region
End Class