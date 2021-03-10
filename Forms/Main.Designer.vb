<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Process Caviar", 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("New Caviar Invoice")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("New Fish Invoice")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Edit Invoices")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Item Return")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Aged Inventory")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Current Inventory")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Salting Station")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Packing Station")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Edit Fish")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Edit Caviar Inventory")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Repack")
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Today's Fish")
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Caviar Made Today")
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("View Invoices")
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Run Sales Report")
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("View Fish Inventory")
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("View Caviar Inventory")
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("View Repack Loss")
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Freezer Audit")
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("View Customers")
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("View Products")
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("View Pricing Table")
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Inventory Value Report")
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Daily Male Harvest")
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Extra Fish Inventory")
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Edit Customer Pricing")
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Add New Customer")
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Edit Customers")
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Add New Product")
        Dim ListViewItem31 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Edit Products")
        Dim ListViewItem32 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Edit Sales Report Constants")
        Dim ListViewItem33 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Edit Inventory Values")
        Dim ListViewItem34 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Post Processing Data Entry")
        Dim ListViewItem35 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Back Up")
        Dim ListViewItem36 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Restore Back Up")
        Dim ListViewItem37 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Close All Users")
        Dim ListViewItem38 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Align Printer")
        Me.Toolbar = New System.Windows.Forms.ToolStrip
        Me.InvoicingButton = New System.Windows.Forms.ToolStripButton
        Me.ProcessingButton = New System.Windows.Forms.ToolStripButton
        Me.ReportsAnalyticsButton = New System.Windows.Forms.ToolStripButton
        Me.TableMaintenanceButton = New System.Windows.Forms.ToolStripButton
        Me.UtilitiesButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.IconList = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.BackUpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.Application_SettingsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Application_SettingsTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.RemoteShutDownCheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.InvoicingPanel = New System.Windows.Forms.Panel
        Me.InvoicingListView = New System.Windows.Forms.ListView
        Me.ProcessingPanel = New System.Windows.Forms.Panel
        Me.ProcessingListView = New System.Windows.Forms.ListView
        Me.ReportsAnalyticsPanel = New System.Windows.Forms.Panel
        Me.DisplayTabControl = New System.Windows.Forms.TabControl
        Me.InvoicingTab = New System.Windows.Forms.TabPage
        Me.ReportsAnalyticsInvoicingListView = New System.Windows.Forms.ListView
        Me.ProcessingTab = New System.Windows.Forms.TabPage
        Me.ReportsAnalyticsProcessingListView = New System.Windows.Forms.ListView
        Me.BusinessTab = New System.Windows.Forms.TabPage
        Me.ReportsAnalyticsBusinessListView = New System.Windows.Forms.ListView
        Me.TableMaintenancePanel = New System.Windows.Forms.Panel
        Me.TableMaintenaceListView = New System.Windows.Forms.ListView
        Me.UtilitiesPanel = New System.Windows.Forms.Panel
        Me.UtilitiesListView = New System.Windows.Forms.ListView
        Me.Toolbar.SuspendLayout()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoicingPanel.SuspendLayout()
        Me.ProcessingPanel.SuspendLayout()
        Me.ReportsAnalyticsPanel.SuspendLayout()
        Me.DisplayTabControl.SuspendLayout()
        Me.InvoicingTab.SuspendLayout()
        Me.ProcessingTab.SuspendLayout()
        Me.BusinessTab.SuspendLayout()
        Me.TableMaintenancePanel.SuspendLayout()
        Me.UtilitiesPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvoicingButton, Me.ProcessingButton, Me.ReportsAnalyticsButton, Me.TableMaintenanceButton, Me.UtilitiesButton, Me.ToolStripSeparator1, Me.AboutButton, Me.ToolStripButton1})
        Me.Toolbar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(782, 50)
        Me.Toolbar.TabIndex = 1
        '
        'InvoicingButton
        '
        Me.InvoicingButton.CheckOnClick = True
        Me.InvoicingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.InvoicingButton.Image = CType(resources.GetObject("InvoicingButton.Image"), System.Drawing.Image)
        Me.InvoicingButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.InvoicingButton.Name = "InvoicingButton"
        Me.InvoicingButton.Size = New System.Drawing.Size(60, 47)
        Me.InvoicingButton.Text = "Invoicing"
        Me.InvoicingButton.ToolTipText = "Create and edit invoices"
        '
        'ProcessingButton
        '
        Me.ProcessingButton.CheckOnClick = True
        Me.ProcessingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ProcessingButton.Image = CType(resources.GetObject("ProcessingButton.Image"), System.Drawing.Image)
        Me.ProcessingButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ProcessingButton.Name = "ProcessingButton"
        Me.ProcessingButton.Size = New System.Drawing.Size(68, 47)
        Me.ProcessingButton.Text = "Processing"
        Me.ProcessingButton.ToolTipText = "Processing Related Data Entry"
        '
        'ReportsAnalyticsButton
        '
        Me.ReportsAnalyticsButton.CheckOnClick = True
        Me.ReportsAnalyticsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ReportsAnalyticsButton.Image = CType(resources.GetObject("ReportsAnalyticsButton.Image"), System.Drawing.Image)
        Me.ReportsAnalyticsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReportsAnalyticsButton.Name = "ReportsAnalyticsButton"
        Me.ReportsAnalyticsButton.Size = New System.Drawing.Size(125, 47)
        Me.ReportsAnalyticsButton.Text = "Reports and Analytics"
        Me.ReportsAnalyticsButton.ToolTipText = "Report and Analytic Tools"
        '
        'TableMaintenanceButton
        '
        Me.TableMaintenanceButton.CheckOnClick = True
        Me.TableMaintenanceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TableMaintenanceButton.Image = CType(resources.GetObject("TableMaintenanceButton.Image"), System.Drawing.Image)
        Me.TableMaintenanceButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TableMaintenanceButton.Name = "TableMaintenanceButton"
        Me.TableMaintenanceButton.Size = New System.Drawing.Size(112, 47)
        Me.TableMaintenanceButton.Text = "Table Maintenance"
        Me.TableMaintenanceButton.ToolTipText = "Misc. Data Entry"
        '
        'UtilitiesButton
        '
        Me.UtilitiesButton.CheckOnClick = True
        Me.UtilitiesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.UtilitiesButton.Image = CType(resources.GetObject("UtilitiesButton.Image"), System.Drawing.Image)
        Me.UtilitiesButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UtilitiesButton.Name = "UtilitiesButton"
        Me.UtilitiesButton.Size = New System.Drawing.Size(50, 47)
        Me.UtilitiesButton.Text = "Utilities"
        Me.UtilitiesButton.ToolTipText = "Various Administrative Utilities"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'AboutButton
        '
        Me.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AboutButton.Image = CType(resources.GetObject("AboutButton.Image"), System.Drawing.Image)
        Me.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(44, 47)
        Me.AboutButton.Text = "About"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(37, 47)
        Me.ToolStripButton1.Text = "TEST"
        Me.ToolStripButton1.Visible = False
        '
        'IconList
        '
        Me.IconList.ImageStream = CType(resources.GetObject("IconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconList.TransparentColor = System.Drawing.Color.Transparent
        Me.IconList.Images.SetKeyName(0, "1372975810_contact-new.png")
        Me.IconList.Images.SetKeyName(1, "1372975779_contact.png")
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView1.LargeImageList = Me.IconList
        Me.ListView1.Location = New System.Drawing.Point(6, 13)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(395, 309)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'BackUpTimer
        '
        Me.BackUpTimer.Enabled = True
        Me.BackUpTimer.Interval = 3600000
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Application_SettingsTableAdapter
        '
        Me.Application_SettingsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Application_SettingsTableAdapter = Me.Application_SettingsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_FishTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryInvoiceFlatTableTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryValueTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Nothing
        Me.TableAdapterManager.ConcurrencyHandlerTableAdapter = Nothing
        Me.TableAdapterManager.Customer_PricingTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.FemaleFishInventoryTableAdapter = Nothing
        Me.TableAdapterManager.FilterColumnsTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTypeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.MaleFishHarvestTableAdapter = Nothing
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Nothing
        Me.TableAdapterManager.NonInventoryInvoiceFlatTableTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.RepackLossTableAdapter = Nothing
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeightConversionConstantsTableAdapter = Nothing
        '
        'RemoteShutDownCheckTimer
        '
        Me.RemoteShutDownCheckTimer.Enabled = True
        Me.RemoteShutDownCheckTimer.Interval = 60000
        '
        'InvoicingPanel
        '
        Me.InvoicingPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvoicingPanel.Controls.Add(Me.InvoicingListView)
        Me.InvoicingPanel.Location = New System.Drawing.Point(0, 53)
        Me.InvoicingPanel.Name = "InvoicingPanel"
        Me.InvoicingPanel.Size = New System.Drawing.Size(782, 390)
        Me.InvoicingPanel.TabIndex = 3
        '
        'InvoicingListView
        '
        Me.InvoicingListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvoicingListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7})
        Me.InvoicingListView.LargeImageList = Me.IconList
        Me.InvoicingListView.Location = New System.Drawing.Point(3, 3)
        Me.InvoicingListView.MultiSelect = False
        Me.InvoicingListView.Name = "InvoicingListView"
        Me.InvoicingListView.Size = New System.Drawing.Size(776, 384)
        Me.InvoicingListView.TabIndex = 8
        Me.InvoicingListView.UseCompatibleStateImageBehavior = False
        Me.InvoicingListView.View = System.Windows.Forms.View.Tile
        '
        'ProcessingPanel
        '
        Me.ProcessingPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProcessingPanel.Controls.Add(Me.ProcessingListView)
        Me.ProcessingPanel.Location = New System.Drawing.Point(3, 84)
        Me.ProcessingPanel.Name = "ProcessingPanel"
        Me.ProcessingPanel.Size = New System.Drawing.Size(779, 387)
        Me.ProcessingPanel.TabIndex = 4
        '
        'ProcessingListView
        '
        Me.ProcessingListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProcessingListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14})
        Me.ProcessingListView.LargeImageList = Me.IconList
        Me.ProcessingListView.Location = New System.Drawing.Point(3, 3)
        Me.ProcessingListView.MultiSelect = False
        Me.ProcessingListView.Name = "ProcessingListView"
        Me.ProcessingListView.Size = New System.Drawing.Size(773, 381)
        Me.ProcessingListView.TabIndex = 8
        Me.ProcessingListView.UseCompatibleStateImageBehavior = False
        Me.ProcessingListView.View = System.Windows.Forms.View.Tile
        '
        'ReportsAnalyticsPanel
        '
        Me.ReportsAnalyticsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportsAnalyticsPanel.Controls.Add(Me.DisplayTabControl)
        Me.ReportsAnalyticsPanel.Location = New System.Drawing.Point(0, 143)
        Me.ReportsAnalyticsPanel.Name = "ReportsAnalyticsPanel"
        Me.ReportsAnalyticsPanel.Size = New System.Drawing.Size(782, 390)
        Me.ReportsAnalyticsPanel.TabIndex = 9
        '
        'DisplayTabControl
        '
        Me.DisplayTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayTabControl.Controls.Add(Me.InvoicingTab)
        Me.DisplayTabControl.Controls.Add(Me.ProcessingTab)
        Me.DisplayTabControl.Controls.Add(Me.BusinessTab)
        Me.DisplayTabControl.Location = New System.Drawing.Point(3, 3)
        Me.DisplayTabControl.Multiline = True
        Me.DisplayTabControl.Name = "DisplayTabControl"
        Me.DisplayTabControl.SelectedIndex = 0
        Me.DisplayTabControl.Size = New System.Drawing.Size(779, 384)
        Me.DisplayTabControl.TabIndex = 2
        '
        'InvoicingTab
        '
        Me.InvoicingTab.Controls.Add(Me.ReportsAnalyticsInvoicingListView)
        Me.InvoicingTab.Location = New System.Drawing.Point(4, 22)
        Me.InvoicingTab.Name = "InvoicingTab"
        Me.InvoicingTab.Padding = New System.Windows.Forms.Padding(3)
        Me.InvoicingTab.Size = New System.Drawing.Size(771, 358)
        Me.InvoicingTab.TabIndex = 0
        Me.InvoicingTab.Text = "Invoicing"
        Me.InvoicingTab.UseVisualStyleBackColor = True
        '
        'ReportsAnalyticsInvoicingListView
        '
        Me.ReportsAnalyticsInvoicingListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportsAnalyticsInvoicingListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem15, ListViewItem16})
        Me.ReportsAnalyticsInvoicingListView.LargeImageList = Me.IconList
        Me.ReportsAnalyticsInvoicingListView.Location = New System.Drawing.Point(-4, 0)
        Me.ReportsAnalyticsInvoicingListView.MultiSelect = False
        Me.ReportsAnalyticsInvoicingListView.Name = "ReportsAnalyticsInvoicingListView"
        Me.ReportsAnalyticsInvoicingListView.Size = New System.Drawing.Size(775, 358)
        Me.ReportsAnalyticsInvoicingListView.TabIndex = 0
        Me.ReportsAnalyticsInvoicingListView.UseCompatibleStateImageBehavior = False
        Me.ReportsAnalyticsInvoicingListView.View = System.Windows.Forms.View.Tile
        '
        'ProcessingTab
        '
        Me.ProcessingTab.Controls.Add(Me.ReportsAnalyticsProcessingListView)
        Me.ProcessingTab.Location = New System.Drawing.Point(4, 22)
        Me.ProcessingTab.Name = "ProcessingTab"
        Me.ProcessingTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ProcessingTab.Size = New System.Drawing.Size(771, 358)
        Me.ProcessingTab.TabIndex = 1
        Me.ProcessingTab.Text = "Processing"
        Me.ProcessingTab.UseVisualStyleBackColor = True
        '
        'ReportsAnalyticsProcessingListView
        '
        Me.ReportsAnalyticsProcessingListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportsAnalyticsProcessingListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem17, ListViewItem18, ListViewItem19})
        Me.ReportsAnalyticsProcessingListView.LargeImageList = Me.IconList
        Me.ReportsAnalyticsProcessingListView.Location = New System.Drawing.Point(-2, 0)
        Me.ReportsAnalyticsProcessingListView.MultiSelect = False
        Me.ReportsAnalyticsProcessingListView.Name = "ReportsAnalyticsProcessingListView"
        Me.ReportsAnalyticsProcessingListView.Size = New System.Drawing.Size(773, 361)
        Me.ReportsAnalyticsProcessingListView.TabIndex = 1
        Me.ReportsAnalyticsProcessingListView.UseCompatibleStateImageBehavior = False
        Me.ReportsAnalyticsProcessingListView.View = System.Windows.Forms.View.Tile
        '
        'BusinessTab
        '
        Me.BusinessTab.Controls.Add(Me.ReportsAnalyticsBusinessListView)
        Me.BusinessTab.Location = New System.Drawing.Point(4, 22)
        Me.BusinessTab.Name = "BusinessTab"
        Me.BusinessTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BusinessTab.Size = New System.Drawing.Size(771, 358)
        Me.BusinessTab.TabIndex = 3
        Me.BusinessTab.Text = "Business"
        Me.BusinessTab.UseVisualStyleBackColor = True
        '
        'ReportsAnalyticsBusinessListView
        '
        Me.ReportsAnalyticsBusinessListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportsAnalyticsBusinessListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24})
        Me.ReportsAnalyticsBusinessListView.LargeImageList = Me.IconList
        Me.ReportsAnalyticsBusinessListView.Location = New System.Drawing.Point(-2, 0)
        Me.ReportsAnalyticsBusinessListView.MultiSelect = False
        Me.ReportsAnalyticsBusinessListView.Name = "ReportsAnalyticsBusinessListView"
        Me.ReportsAnalyticsBusinessListView.Size = New System.Drawing.Size(773, 365)
        Me.ReportsAnalyticsBusinessListView.TabIndex = 7
        Me.ReportsAnalyticsBusinessListView.UseCompatibleStateImageBehavior = False
        Me.ReportsAnalyticsBusinessListView.View = System.Windows.Forms.View.Tile
        '
        'TableMaintenancePanel
        '
        Me.TableMaintenancePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableMaintenancePanel.Controls.Add(Me.TableMaintenaceListView)
        Me.TableMaintenancePanel.Location = New System.Drawing.Point(0, 206)
        Me.TableMaintenancePanel.Name = "TableMaintenancePanel"
        Me.TableMaintenancePanel.Size = New System.Drawing.Size(782, 390)
        Me.TableMaintenancePanel.TabIndex = 10
        '
        'TableMaintenaceListView
        '
        Me.TableMaintenaceListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableMaintenaceListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem25, ListViewItem26, ListViewItem27, ListViewItem28, ListViewItem29, ListViewItem30, ListViewItem31, ListViewItem32, ListViewItem33, ListViewItem34})
        Me.TableMaintenaceListView.LargeImageList = Me.IconList
        Me.TableMaintenaceListView.Location = New System.Drawing.Point(3, 3)
        Me.TableMaintenaceListView.MultiSelect = False
        Me.TableMaintenaceListView.Name = "TableMaintenaceListView"
        Me.TableMaintenaceListView.Size = New System.Drawing.Size(776, 384)
        Me.TableMaintenaceListView.TabIndex = 8
        Me.TableMaintenaceListView.UseCompatibleStateImageBehavior = False
        Me.TableMaintenaceListView.View = System.Windows.Forms.View.Tile
        '
        'UtilitiesPanel
        '
        Me.UtilitiesPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UtilitiesPanel.Controls.Add(Me.UtilitiesListView)
        Me.UtilitiesPanel.Location = New System.Drawing.Point(0, 265)
        Me.UtilitiesPanel.Name = "UtilitiesPanel"
        Me.UtilitiesPanel.Size = New System.Drawing.Size(782, 390)
        Me.UtilitiesPanel.TabIndex = 11
        '
        'UtilitiesListView
        '
        Me.UtilitiesListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UtilitiesListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem35, ListViewItem36, ListViewItem37, ListViewItem38})
        Me.UtilitiesListView.LargeImageList = Me.IconList
        Me.UtilitiesListView.Location = New System.Drawing.Point(3, 3)
        Me.UtilitiesListView.MultiSelect = False
        Me.UtilitiesListView.Name = "UtilitiesListView"
        Me.UtilitiesListView.Size = New System.Drawing.Size(776, 384)
        Me.UtilitiesListView.TabIndex = 8
        Me.UtilitiesListView.UseCompatibleStateImageBehavior = False
        Me.UtilitiesListView.View = System.Windows.Forms.View.Tile
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(782, 445)
        Me.Controls.Add(Me.Toolbar)
        Me.Controls.Add(Me.UtilitiesPanel)
        Me.Controls.Add(Me.TableMaintenancePanel)
        Me.Controls.Add(Me.ReportsAnalyticsPanel)
        Me.Controls.Add(Me.ProcessingPanel)
        Me.Controls.Add(Me.InvoicingPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sturgeon Manager v1.0"
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoicingPanel.ResumeLayout(False)
        Me.ProcessingPanel.ResumeLayout(False)
        Me.ReportsAnalyticsPanel.ResumeLayout(False)
        Me.DisplayTabControl.ResumeLayout(False)
        Me.InvoicingTab.ResumeLayout(False)
        Me.ProcessingTab.ResumeLayout(False)
        Me.BusinessTab.ResumeLayout(False)
        Me.TableMaintenancePanel.ResumeLayout(False)
        Me.UtilitiesPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents InvoicingButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProcessingButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReportsAnalyticsButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IconList As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BackUpTimer As System.Windows.Forms.Timer
    Friend WithEvents AboutButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents Application_SettingsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Application_SettingsTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RemoteShutDownCheckTimer As System.Windows.Forms.Timer
    Friend WithEvents InvoicingPanel As System.Windows.Forms.Panel
    Friend WithEvents TableMaintenanceButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UtilitiesButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents InvoicingListView As System.Windows.Forms.ListView
    Friend WithEvents ProcessingPanel As System.Windows.Forms.Panel
    Friend WithEvents ProcessingListView As System.Windows.Forms.ListView
    Friend WithEvents ReportsAnalyticsPanel As System.Windows.Forms.Panel
    Friend WithEvents DisplayTabControl As System.Windows.Forms.TabControl
    Friend WithEvents InvoicingTab As System.Windows.Forms.TabPage
    Friend WithEvents ReportsAnalyticsInvoicingListView As System.Windows.Forms.ListView
    Friend WithEvents ProcessingTab As System.Windows.Forms.TabPage
    Friend WithEvents ReportsAnalyticsProcessingListView As System.Windows.Forms.ListView
    Friend WithEvents BusinessTab As System.Windows.Forms.TabPage
    Friend WithEvents ReportsAnalyticsBusinessListView As System.Windows.Forms.ListView
    Friend WithEvents TableMaintenancePanel As System.Windows.Forms.Panel
    Friend WithEvents TableMaintenaceListView As System.Windows.Forms.ListView
    Friend WithEvents UtilitiesPanel As System.Windows.Forms.Panel
    Friend WithEvents UtilitiesListView As System.Windows.Forms.ListView

End Class
