
'This form is the first form that displays when the user enters the program.
Option Explicit On
Imports System
Imports System.Diagnostics
Imports System.ComponentModel

Public Class Main
    'test button
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        CaviarInventoryAudit.Show()
    End Sub

#Region "Back Up"

    Private Sub BackUpTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackUpTimer.Tick
        Try
            BackUp()
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Public Sub ShowNewFishInvoice()
        Using (New WaitCursor)
            NewFishInvoice.Show()
            NewFishInvoice.InvoicesBindingSource.AddNew()
            NewFishInvoice.InvoiceTypeComboBox.SelectedValue = 2 'invoice type is fish
        End Using
    End Sub
    Public Sub ShowNewCaviarInvoice()
        Using (New WaitCursor)
            NewCaviarInvoice.Show()
            NewCaviarInvoice.InvoicesBindingSource.AddNew()
            NewCaviarInvoice.InvoiceTypeComboBox.SelectedValue = 1 'invoice type is caviar
        End Using
    End Sub

#Region "Changing Modes"
    Public CurrentMode As OperatingMode
    Public Enum OperatingMode
        Invoicing = 1
        Processing = 2
        ReportsAnalytics = 3
        TableMaintenance = 4
        Utilities = 5
    End Enum

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Application.OpenForms().OfType(Of RemoteShutDown).Any Then
            SignOff() 'system is forced to shutdown
        Else
            If Application.OpenForms().Count > 1 AndAlso MsgBox("There are other unclosed windows. Continue exiting?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                e.Cancel = True
            Else
                SignOff()
            End If
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Application_Settings' table. You can move, or remove it, as needed.
        'Try
        Me.Application_SettingsTableAdapter.Fill(Me.SturgeonDBDataSet.Application_Settings)

        'reset the locations of the panels
        InvoicingPanel.Location = New Point(0, Me.Toolbar.Height)
        ProcessingPanel.Location = New Point(0, Me.Toolbar.Height)
        ReportsAnalyticsPanel.Location = New Point(0, Me.Toolbar.Height)
        TableMaintenancePanel.Location = New Point(0, Me.Toolbar.Height)
        UtilitiesPanel.Location = New Point(0, Me.Toolbar.Height)

        BackUp()

        SignOn()

        'LoadBrowseXMLFiles()

        'start in business mode
        ChangeMode(OperatingMode.Invoicing)


        'delete back up files past 30 days
        DeletePastBackUp(-30)
        'Catch ex As Exception
        '    MsgBox("Error loading on start up. Please check network connection and restart the program." & Chr(13) & ex.Message)
        'End Try

    End Sub
    Public Sub ChangeMode(ByVal NewMode As OperatingMode)
        'reset everything
        InvoicingButton.Checked = False
        ProcessingButton.Checked = False
        ReportsAnalyticsButton.Checked = False
        TableMaintenanceButton.Checked = False
        UtilitiesButton.Checked = False


        InvoicingPanel.Visible = False
        ProcessingPanel.Visible = False
        ReportsAnalyticsPanel.Visible = False
        TableMaintenancePanel.Visible = False
        UtilitiesPanel.Visible = False

        'change the GUI to reflect current setting
        Select Case NewMode
            Case OperatingMode.Invoicing
                InvoicingButton.Checked = True
                InvoicingPanel.Visible = True
            Case OperatingMode.Processing
                ProcessingButton.Checked = True
                ProcessingPanel.Visible = True
            Case OperatingMode.ReportsAnalytics
                ReportsAnalyticsButton.Checked = True
                ReportsAnalyticsPanel.Visible = True
            Case OperatingMode.TableMaintenance
                TableMaintenanceButton.Checked = True
                TableMaintenancePanel.Visible = True
            Case OperatingMode.Utilities
                UtilitiesButton.Checked = True
                UtilitiesPanel.Visible = True
        End Select

        CurrentMode = NewMode
    End Sub
    Private Sub InvoicingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoicingButton.Click
        ChangeMode(OperatingMode.Invoicing)
    End Sub
    Private Sub ProcessingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessingButton.Click
        ChangeMode(OperatingMode.Processing)
    End Sub
    Private Sub ReportsAnalyticsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsAnalyticsButton.Click
        ChangeMode(OperatingMode.ReportsAnalytics)
    End Sub
    Private Sub TableMaintenanceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TableMaintenanceButton.Click
        ChangeMode(OperatingMode.TableMaintenance)
    End Sub
    Private Sub UtilitiesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtilitiesButton.Click
        ChangeMode(OperatingMode.Utilities)
    End Sub
#End Region

#Region "Application Instances Management"
    'put the status as on for this machine, check if the application is running offline
    Public Sub SignOn()
        Try
            Dim CurrentDirectory As String = My.Application.Info.DirectoryPath
            If CurrentDirectory.StartsWith("\\") Then
                'running on a remote network computer
            Else
                'running locally, prompt for updating the offline databse
                If MsgBox("It appears that you are running Sturgeon Manager Offline. Retrieve the latest online version of the database?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim OnlineDBPath As String = InputBox("Where is the online sturgeon manager folder?", , "\\Amerigo\public\STURGEON FOLDER\Mochi\Sturgeon Manager v1.0")
                    If Not OnlineDBPath = "" Then
                        My.Computer.FileSystem.CopyFile(OnlineDBPath & "\SturgeonDB.mdb", CurrentDirectory & "\SturgeonDB.mdb", True)
                    End If
                End If
            End If
            Dim myApplicationSetting As SturgeonDBDataSet.Application_SettingsRow = SturgeonDBDataSet.Application_Settings.FindByComputerName(Environment.MachineName)
            If myApplicationSetting Is Nothing Then
                'no record exists for this computer, add one
                Application_SettingsTableAdapter.Insert(Environment.MachineName, True, False)
            Else
                'a record exists for this computer
                If myApplicationSetting.CloseApplication = True Then
                    MsgBox("System Maintenance in Progress, Please Be Patient. If you believe this message is displayed in error, please contact your system administrator", MsgBoxStyle.Critical)
                    Me.Close()
                End If
                myApplicationSetting.ApplicationRunning = True
                Application_SettingsTableAdapter.Update(myApplicationSetting)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    'put the status as off for this machine
    Public Sub SignOff()
        Try
            Using (New WaitCursor)
                Application_SettingsTableAdapter.Fill(Me.SturgeonDBDataSet.Application_Settings)
                Dim myApplicationSetting As SturgeonDBDataSet.Application_SettingsRow = SturgeonDBDataSet.Application_Settings.FindByComputerName(Environment.MachineName)
                If myApplicationSetting IsNot Nothing Then
                    'a record exists for this computer
                    myApplicationSetting.ApplicationRunning = False
                    myApplicationSetting.CloseApplication = False
                    Application_SettingsTableAdapter.Update(myApplicationSetting)
                End If
                Dim CurrentDirectory As String = My.Application.Info.DirectoryPath
                If CurrentDirectory.StartsWith("\\") Then
                Else
                    'running locally, prompt for updating the online database
                    If MsgBox("It appears that you worked with Sturgeon Manager Offline. Update the online version of the database? CAUTION: work done on the online version since your last offline update may be lost. A recovery file in the online copy will be generated now.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Dim OnlineDBPath As String = InputBox("Where is the online sturgeon manager folder?", , "\\Amerigo\public\STURGEON FOLDER\Mochi\Sturgeon Manager v1.0")
                        If Not OnlineDBPath = "" Then
                            BackUp(OnlineDBPath)
                            My.Computer.FileSystem.CopyFile(CurrentDirectory & "\SturgeonDB.mdb", OnlineDBPath & "\SturgeonDB.mdb", True)
                        End If
                    End If
                End If
            End Using


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RemoteShutDownCheckTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoteShutDownCheckTimer.Tick
        'check every minute to see if a shut down command has been sent
        Try
            Application_SettingsTableAdapter.Fill(Me.SturgeonDBDataSet.Application_Settings)
            Dim myApplicationSetting As SturgeonDBDataSet.Application_SettingsRow = SturgeonDBDataSet.Application_Settings.FindByComputerName(Environment.MachineName)
            If myApplicationSetting IsNot Nothing AndAlso myApplicationSetting.CloseApplication = True Then
                'a shutdown command has been issued
                RemoteShutDown.Show()
            End If
        Catch ex As Exception

        End Try

    End Sub
#End Region





#Region "View Data Events"
    Private Sub BusinessViewDataListVew_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs)
        Using (New WaitCursor) 'Load hourglass
            Select Case ReportsAnalyticsProcessingListView.Items(ReportsAnalyticsProcessingListView.SelectedIndices(0)).Text

                Case "View Conversion Constants"
                    WeightConversionConstants.Show()
                    WeightConversionConstants.LoadReadOnly()
                Case "Customer List"
                    ReportViewer.DisplayReport(ReportType.CustomerList, "")
                    ReportViewer.Show()
                Case "Product List"
                    ReportViewer.DisplayReport(ReportType.ProductListingReport, "")
                    ReportViewer.Show()

            End Select
        End Using
    End Sub

#End Region

#Region "Browse Data Events"
    'Public Sub LoadBrowseXMLFiles()
    '    'Load Prcessing XMLs
    '    Dim di As New IO.DirectoryInfo(My.Application.Info.DirectoryPath & "\Browse Data\Processing")
    '    Dim diar1 As IO.FileInfo() = di.GetFiles()

    '    'list the names of all files in the specified directory
    '    For Each dra As IO.FileInfo In diar1
    '        If dra.Extension = ".xml" Then
    '            ProcessingBrowseDataListView.Items.Add(dra.Name.Split("."c)(0))
    '        End If
    '    Next
    'End Sub

    'Private Sub ProcessingBrowseDataListView_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Using (New WaitCursor)
    '        BrowseData.Show()
    '        BrowseData.LoadXML(My.Application.Info.DirectoryPath & "\Browse Data\Processing\" & ProcessingBrowseDataListView.Items(ProcessingBrowseDataListView.SelectedIndices(0)).Text & ".xml")
    '    End Using
    'End Sub
#End Region


    Private Sub AboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutButton.Click
        About.ShowDialog()
    End Sub

    Private Sub InvoicingListView_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles InvoicingListView.ItemActivate
        Using (New WaitCursor) 'Load hourglass
            Select Case InvoicingListView.Items(InvoicingListView.SelectedIndices(0)).Text
                Case "New Caviar Invoice"
                    ShowNewCaviarInvoice()
                Case "New Fish Invoice"
                    ShowNewFishInvoice()
                Case "Edit Invoices"
                    Invoice.Show()
                Case "Item Return"
                    RepackReturns.Show()
                    RepackReturns.SetMode(RepackReturns.OperationMode.CaviarReturn)
                Case "Aged Inventory"
                    AgedInventoryReport.Show()
                Case "Current Inventory"
                    EditInventory.Show()
                    EditInventory.myFilter.Show()
                    Dim FilterGroupBox As GroupBox = EditInventory.myFilter.AddToFilter("InventoryStatus") 'apply a filter of inventory status
                    DirectCast(FilterGroupBox.Controls.Item(2), ComboBox).SelectedValue = 1 '1 is in inventory
                    'FilterGroupBox = EditInventory.myFilter.AddToFilter("InventoryStatus") 'apply a second filter of inventory status
                    'DirectCast(FilterGroupBox.Controls.Item(2), ComboBox).SelectedValue = 5  '5 is Prepack
                    'DirectCast(FilterGroupBox.Controls.Item(1), ComboBox).Text = " OR "
                    EditInventory.myFilter.ApplyButton_Click(Nothing, Nothing)
                    EditInventory.myFilter.Hide()
                    EditInventory.RefreshQuickSummary()
                    EditInventory.LoadReadOnly()
            End Select
        End Using
    End Sub

    Private Sub ProcessingListView_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProcessingListView.ItemActivate
        Using (New WaitCursor) 'Load hourglass
            Select Case ProcessingListView.Items(ProcessingListView.SelectedIndices(0)).Text
                Case "Salting Station"
                    If Application.OpenForms().OfType(Of EditFishInventory).Any Or Application.OpenForms().OfType(Of EditInventory).Any Or Application.OpenForms().OfType(Of PostProcessingData).Any Then
                        MsgBox("Sturgeon Manager cannot open Salting Station or Packing Station while Edit Inventory is open")
                    Else
                        SaltingStation.Show()
                    End If
                Case "Packing Station"
                    If Application.OpenForms().OfType(Of EditFishInventory).Any Or Application.OpenForms().OfType(Of EditInventory).Any Or Application.OpenForms().OfType(Of PostProcessingData).Any Then
                        MsgBox("Sturgeon Manager cannot open Salting Station or Packing Station while Edit Inventory is open")
                    Else
                        PrintingPackingStation.Show()
                    End If
                Case "Edit Fish"
                    'cannot edit inventory when salting or packing station is open
                    If Application.OpenForms().OfType(Of SaltingStation).Any Or Application.OpenForms().OfType(Of PrintingPackingStation).Any Or Application.OpenForms().OfType(Of EditFishInventory).Any Or Application.OpenForms().OfType(Of EditInventory).Any Or Application.OpenForms().OfType(Of PostProcessingData).Any Then
                        MsgBox("Sturgeon Manager cannot open edit inventory while inventory is in use")
                    Else
                        EditFishInventory.Show()
                        EditFishInventory.RefreshQuickSummary()
                    End If
                Case "Edit Caviar Inventory"
                    'cannot edit inventory when salting or packing station is open
                    If Application.OpenForms().OfType(Of SaltingStation).Any Or Application.OpenForms().OfType(Of PrintingPackingStation).Any Or Application.OpenForms().OfType(Of EditFishInventory).Any Or Application.OpenForms().OfType(Of EditInventory).Any Or Application.OpenForms().OfType(Of PostProcessingData).Any Then
                        MsgBox("Sturgeon Manager cannot open edit inventory while inventory is in use")
                    Else
                        EditInventory.Show()
                        EditInventory.RefreshQuickSummary()
                    End If
                Case "Repack"
                    RepackReturns.Show()
                    RepackReturns.SetMode(RepackReturns.OperationMode.CaviarRepack)
                Case "Today's Fish"
                    'cannot edit inventory when salting or packing station is open
                    If Application.OpenForms().OfType(Of SaltingStation).Any Or Application.OpenForms().OfType(Of PrintingPackingStation).Any Or Application.OpenForms().OfType(Of EditFishInventory).Any Or Application.OpenForms().OfType(Of EditInventory).Any Or Application.OpenForms().OfType(Of PostProcessingData).Any Then
                        MsgBox("Sturgeon Manager cannot open edit inventory while inventory is in use")
                    Else
                        EditFishInventory.Show()
                        EditFishInventory.myFilter.Show()
                        EditFishInventory.myFilter.AddToFilter("Harvest Date") 'apply a filter of harvest date, which defaults to today
                        EditFishInventory.myFilter.ApplyButton_Click(Nothing, Nothing)
                        EditFishInventory.myFilter.Hide()
                        EditFishInventory.RefreshQuickSummary()
                    End If
                Case "Caviar Made Today"
                    'cannot edit inventory when salting or packing station is open
                    If Application.OpenForms().OfType(Of SaltingStation).Any Or Application.OpenForms().OfType(Of PrintingPackingStation).Any Or Application.OpenForms().OfType(Of EditFishInventory).Any Or Application.OpenForms().OfType(Of EditInventory).Any Or Application.OpenForms().OfType(Of PostProcessingData).Any Then
                        MsgBox("Sturgeon Manager cannot open edit inventory while inventory is in use")
                    Else
                        EditInventory.Show()
                        EditInventory.myFilter.Show()
                        EditInventory.myFilter.AddToFilter("Harvest Date") 'apply a filter of harvest date, which defaults to today
                        EditInventory.myFilter.ApplyButton_Click(Nothing, Nothing)
                        EditInventory.myFilter.Hide()
                        EditInventory.RefreshQuickSummary()
                    End If
            End Select
        End Using
    End Sub

    Private Sub ReportsAnalyticsInvoicingListView_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportsAnalyticsInvoicingListView.ItemActivate
        Using (New WaitCursor) 'Load hourglass
            Select Case ReportsAnalyticsInvoicingListView.Items(ReportsAnalyticsInvoicingListView.SelectedIndices(0)).Text
                Case "View Invoices"
                    Invoice.Show()
                    Invoice.LoadReadOnly()
                Case "Run Sales Report"
                    SalesReport.Show()
            End Select
        End Using
    End Sub

    Private Sub ReportsAnalyticsProcessingListView_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportsAnalyticsProcessingListView.ItemActivate
        Using (New WaitCursor) 'Load hourglass
            Select Case ReportsAnalyticsProcessingListView.Items(ReportsAnalyticsProcessingListView.SelectedIndices(0)).Text
                Case "View Fish Inventory"
                    EditFishInventory.Show()
                    EditFishInventory.RefreshQuickSummary()
                    EditFishInventory.LoadReadOnly()
                Case "View Caviar Inventory"
                    EditInventory.Show()
                    EditInventory.RefreshQuickSummary()
                    EditInventory.LoadReadOnly()
                Case "View Repack Loss"
                    RepackLoss.Show()
            End Select
        End Using
    End Sub

    Private Sub ReportsAnalyticsBusinessListView_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportsAnalyticsBusinessListView.ItemActivate
        Using (New WaitCursor) 'Load hourglass
            Select Case ReportsAnalyticsBusinessListView.Items(ReportsAnalyticsBusinessListView.SelectedIndices(0)).Text
                Case "Freezer Audit"
                    CaviarInventoryAudit.Show()
                Case "View Customers"
                    Customer.Show()
                    Customer.LoadReadOnly()
                Case "View Products"
                    Product.Show()
                    Product.LoadReadOnly()
                Case "View Pricing Table"
                    Pricing.Show()
                    Pricing.LoadReadOnly()
                Case "Inventory Value Report"
                    'ReportViewer.DisplayReport(ReportType.InventoryValue, "")
                    Dim EndOfLastMonth As String = String.Format("#{0:M/dd/yyyy} 00:00:00#", (New Date(Date.Now.Year, Date.Now.Month, 1)))
                    'ReportViewer.DisplayReport(ReportType.InventoryValue, "{Caviar_Fish.Harvest Date} < " & EndOfLastMonth & " AND (({Caviar_Inventory.InventoryStatus} = 1 AND {Caviar_Inventory.PreviousStatus} = 7) OR ({Caviar_Inventory.PreviousStatus} = 1 AND {Caviar_Inventory.DateStatusChanged} >= " & EndOfLastMonth & "))")
                    ReportViewer.DisplayReport(ReportType.InventoryValue, "")
                    ReportViewer.Show()
            End Select
        End Using
    End Sub

    Private Sub TableMaintenaceListView_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles TableMaintenaceListView.ItemActivate
        Using (New WaitCursor) 'Load hourglass
            Select Case TableMaintenaceListView.Items(TableMaintenaceListView.SelectedIndices(0)).Text
                Case "Daily Male Harvest"
                    MaleHarvest.Show()
                    MaleHarvest.MaleFishHarvestBindingSource.AddNew()
                    MaleHarvest.MaleFishHarvestDataGridView.Rows(MaleHarvest.MaleFishHarvestDataGridView.Rows.Count - 1).Cells("FishCountColumn").Selected = True
                Case "Extra Fish Inventory"
                    ExtraFishInventory.Show()
                    ExtraFishInventory.FemaleFishInventoryBindingSource.AddNew()
                    ExtraFishInventory.FemaleFishInventoryMyDataGridView.Rows(ExtraFishInventory.FemaleFishInventoryMyDataGridView.Rows.Count - 1).Cells("InventoryGuttedWeightColumn").Selected = True
                Case "Edit Customer Pricing"
                    Pricing.Show()
                Case "Add New Customer"
                    Customer.Show()
                    Customer.isAddingNew = True
                    Customer.CustomersBindingSource.AddNew()
                    Customer.SavedAtLeastOnce = False
                Case "Edit Customers"
                    Customer.Show()
                Case "Add New Product"
                    Product.Show()
                    Product.ProductsBindingSource.AddNew()
                Case "Edit Products"
                    Product.Show()
                Case "Edit Sales Report Constants"
                    WeightConversionConstants.Show()
                    WeightConversionConstants.WeightConversionConstantsBindingSource.AddNew()
                    WeightConversionConstants.WeightConversionConstantsBindingSource.MoveLast()
                Case "Edit Inventory Values"
                    EditInventoryValue.Show()
                Case "Post Processing Data Entry"
                    If Application.OpenForms().OfType(Of EditFishInventory).Any Or Application.OpenForms().OfType(Of EditInventory).Any Or Application.OpenForms().OfType(Of PostProcessingData).Any Then
                        MsgBox("Sturgeon Manager cannot open Salting Station or Packing Station while Edit Inventory is open")
                    Else
                        PostProcessingData.Show()
                        PostProcessingData.myFilter.Show()
                        PostProcessingData.myFilter.AddToFilter("Harvest Date") 'apply a filter of harvest date, which defaults to today
                    End If
            End Select
        End Using
    End Sub

    Private Sub UtilitiesListView_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UtilitiesListView.ItemActivate
        Using (New WaitCursor) 'Load hourglass
            Select Case UtilitiesListView.Items(UtilitiesListView.SelectedIndices(0)).Text
                Case "Back Up"
                    BackUp()
                Case "Restore Back Up"
                    BackUpRecovery.Show()
                Case "Close All Users"
                    'system administrator issued a close all application instances command
                    Dim myApplications() As SturgeonDBDataSet.Application_SettingsRow = SturgeonDBDataSet.Application_Settings.Select("ApplicationRunning = true")
                    For Each ApplicationInstance In myApplications
                        'set the close application field to true for all currently running applications
                        ApplicationInstance.CloseApplication = True
                    Next
                    Application_SettingsTableAdapter.Update(myApplications)
                Case "Align Printer"
                    AlignPrinter.ShowDialog()
            End Select
        End Using

    End Sub

End Class
