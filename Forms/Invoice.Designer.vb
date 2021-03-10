<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
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
        Dim TotalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillingAddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShippingAddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersBillingAddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersShippingAddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceGroupBox = New System.Windows.Forms.GroupBox
        Me.InvoicesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.InvoicesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FilterButton = New System.Windows.Forms.ToolStripButton
        Me.ExportExcelButton = New System.Windows.Forms.ToolStripButton
        Me.CrystalReportDropDownButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.CurrentInvoiceItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerateCurrentPackingSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TotalSalesTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.InvoiceCountTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CalculatedTotalTextBox = New System.Windows.Forms.TextBox
        Me.CalculatedTotalLabel = New System.Windows.Forms.Label
        Me.TotalTextBox = New System.Windows.Forms.TextBox
        Me.InvoicesDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.PKInvoiceIDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKCustomerIDColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.FKBillingAddressIDColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.FKShippingAddressIDColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.PONumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BoxesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalsColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InvoiceType = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.InvoiceTypeSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaviarGroupBox = New System.Windows.Forms.GroupBox
        Me.CaviarOrderDisplayDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.BoxNameCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductNameCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CountCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceSoldAtCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalKgsCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTotalCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaviarCountTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CaviarSubtotalTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.EditCaviarInvoiceButton = New System.Windows.Forms.Button
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaviarFishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaviarStatusSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Caviar_InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NonInventoryGroupBox = New System.Windows.Forms.GroupBox
        Me.OthersCountTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.OthersSubtotalTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Non_Inventory_Invoice_RecordsDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.NonInventoryFKProductIDColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.NonInventoryProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NonInventoryQuantityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NonInventoryPriceSoldAtColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NonInventoryNotesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Non_Inventory_Invoice_RecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoicesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoicesTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.Billing_AddressesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Billing_AddressesTableAdapter
        Me.Caviar_FishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
        Me.Caviar_InventoryTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
        Me.CaviarStatusSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
        Me.CustomersTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CustomersTableAdapter
        Me.GradeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
        Me.InvoiceTypeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoiceTypeSelectionTableAdapter
        Me.Non_Inventory_Invoice_RecordsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Non_Inventory_Invoice_RecordsTableAdapter
        Me.ProductCategorySelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductCategorySelectionTableAdapter
        Me.ProductsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
        Me.Shipping_AddressesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Shipping_AddressesTableAdapter
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer
        Me.InvoicedItemsSplitContainer = New System.Windows.Forms.SplitContainer
        Me.CaviarInvoicedSplitContainer = New System.Windows.Forms.SplitContainer
        Me.ListOfItemsInvoicedGroupBox = New System.Windows.Forms.GroupBox
        Me.Caviar_InventoryDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.PKBarcodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderOnInvoice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaviarFKProductIDColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.FishTagColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.HarvestDateColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.EggSizeColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TasteColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.FirmnessColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ColorColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CaviarPriceSoldAtColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PricePerItemColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InventoryStatusColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.PackingBoxNumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaviarNotesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKInvoiceIDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateStatusChanged = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PreviousStatus = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.EditFishInvoice = New System.Windows.Forms.Button
        TotalLabel = New System.Windows.Forms.Label
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingAddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippingAddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBillingAddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersShippingAddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoiceGroupBox.SuspendLayout()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoicesBindingNavigator.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.InvoicesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceTypeSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CaviarGroupBox.SuspendLayout()
        CType(Me.CaviarOrderDisplayDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarFishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caviar_InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NonInventoryGroupBox.SuspendLayout()
        CType(Me.Non_Inventory_Invoice_RecordsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NonInventoryProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Non_Inventory_Invoice_RecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer.Panel1.SuspendLayout()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        Me.InvoicedItemsSplitContainer.Panel1.SuspendLayout()
        Me.InvoicedItemsSplitContainer.Panel2.SuspendLayout()
        Me.InvoicedItemsSplitContainer.SuspendLayout()
        Me.CaviarInvoicedSplitContainer.Panel1.SuspendLayout()
        Me.CaviarInvoicedSplitContainer.Panel2.SuspendLayout()
        Me.CaviarInvoicedSplitContainer.SuspendLayout()
        Me.ListOfItemsInvoicedGroupBox.SuspendLayout()
        CType(Me.Caviar_InventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(6, 22)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(81, 13)
        TotalLabel.TabIndex = 0
        TotalLabel.Text = "Record Total: $"
        '
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "Invoices"
        Me.InvoicesBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'BillingAddressesBindingSource
        '
        Me.BillingAddressesBindingSource.DataMember = "Billing Addresses"
        Me.BillingAddressesBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'ShippingAddressesBindingSource
        '
        Me.ShippingAddressesBindingSource.DataMember = "Shipping Addresses"
        Me.ShippingAddressesBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'CustomersBillingAddressesBindingSource
        '
        Me.CustomersBillingAddressesBindingSource.DataMember = "CustomersBilling Addresses"
        Me.CustomersBillingAddressesBindingSource.DataSource = Me.CustomersBindingSource
        '
        'CustomersShippingAddressesBindingSource
        '
        Me.CustomersShippingAddressesBindingSource.DataMember = "CustomersShipping Addresses"
        Me.CustomersShippingAddressesBindingSource.DataSource = Me.CustomersBindingSource
        '
        'InvoiceGroupBox
        '
        Me.InvoiceGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvoiceGroupBox.Controls.Add(Me.InvoicesBindingNavigator)
        Me.InvoiceGroupBox.Controls.Add(Me.GroupBox4)
        Me.InvoiceGroupBox.Controls.Add(Me.InvoicesDataGridView)
        Me.InvoiceGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.InvoiceGroupBox.Name = "InvoiceGroupBox"
        Me.InvoiceGroupBox.Size = New System.Drawing.Size(385, 663)
        Me.InvoiceGroupBox.TabIndex = 2
        Me.InvoiceGroupBox.TabStop = False
        Me.InvoiceGroupBox.Text = "Invoices"
        '
        'InvoicesBindingNavigator
        '
        Me.InvoicesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InvoicesBindingNavigator.BindingSource = Me.InvoicesBindingSource
        Me.InvoicesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InvoicesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InvoicesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.InvoicesBindingNavigatorSaveItem, Me.BindingNavigatorDeleteItem, Me.FilterButton, Me.ExportExcelButton, Me.CrystalReportDropDownButton})
        Me.InvoicesBindingNavigator.Location = New System.Drawing.Point(3, 16)
        Me.InvoicesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InvoicesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InvoicesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InvoicesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InvoicesBindingNavigator.Name = "InvoicesBindingNavigator"
        Me.InvoicesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InvoicesBindingNavigator.Size = New System.Drawing.Size(379, 25)
        Me.InvoicesBindingNavigator.TabIndex = 3
        Me.InvoicesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'InvoicesBindingNavigatorSaveItem
        '
        Me.InvoicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InvoicesBindingNavigatorSaveItem.Image = CType(resources.GetObject("InvoicesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InvoicesBindingNavigatorSaveItem.Name = "InvoicesBindingNavigatorSaveItem"
        Me.InvoicesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InvoicesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FilterButton
        '
        Me.FilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FilterButton.Image = CType(resources.GetObject("FilterButton.Image"), System.Drawing.Image)
        Me.FilterButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FilterButton.Name = "FilterButton"
        Me.FilterButton.Size = New System.Drawing.Size(23, 22)
        Me.FilterButton.Text = "Filter Settings"
        '
        'ExportExcelButton
        '
        Me.ExportExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportExcelButton.Image = CType(resources.GetObject("ExportExcelButton.Image"), System.Drawing.Image)
        Me.ExportExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportExcelButton.Name = "ExportExcelButton"
        Me.ExportExcelButton.Size = New System.Drawing.Size(23, 22)
        Me.ExportExcelButton.Text = "Export to Excel"
        '
        'CrystalReportDropDownButton
        '
        Me.CrystalReportDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CrystalReportDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentInvoiceItem, Me.GenerateCurrentPackingSlipToolStripMenuItem})
        Me.CrystalReportDropDownButton.Image = CType(resources.GetObject("CrystalReportDropDownButton.Image"), System.Drawing.Image)
        Me.CrystalReportDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CrystalReportDropDownButton.Name = "CrystalReportDropDownButton"
        Me.CrystalReportDropDownButton.Size = New System.Drawing.Size(29, 22)
        Me.CrystalReportDropDownButton.Text = "ToolStripDropDownButton1"
        '
        'CurrentInvoiceItem
        '
        Me.CurrentInvoiceItem.Name = "CurrentInvoiceItem"
        Me.CurrentInvoiceItem.Size = New System.Drawing.Size(231, 22)
        Me.CurrentInvoiceItem.Text = "Generate Current Invoice"
        '
        'GenerateCurrentPackingSlipToolStripMenuItem
        '
        Me.GenerateCurrentPackingSlipToolStripMenuItem.Name = "GenerateCurrentPackingSlipToolStripMenuItem"
        Me.GenerateCurrentPackingSlipToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.GenerateCurrentPackingSlipToolStripMenuItem.Text = "Generate Current Packing Slip"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TotalSalesTextBox)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.InvoiceCountTextBox)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.CalculatedTotalTextBox)
        Me.GroupBox4.Controls.Add(Me.CalculatedTotalLabel)
        Me.GroupBox4.Controls.Add(TotalLabel)
        Me.GroupBox4.Controls.Add(Me.TotalTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 522)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(372, 133)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Quick Summary"
        '
        'TotalSalesTextBox
        '
        Me.TotalSalesTextBox.Location = New System.Drawing.Point(89, 71)
        Me.TotalSalesTextBox.Name = "TotalSalesTextBox"
        Me.TotalSalesTextBox.ReadOnly = True
        Me.TotalSalesTextBox.Size = New System.Drawing.Size(110, 20)
        Me.TotalSalesTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Sales: "
        '
        'InvoiceCountTextBox
        '
        Me.InvoiceCountTextBox.Location = New System.Drawing.Point(89, 45)
        Me.InvoiceCountTextBox.Name = "InvoiceCountTextBox"
        Me.InvoiceCountTextBox.ReadOnly = True
        Me.InvoiceCountTextBox.Size = New System.Drawing.Size(110, 20)
        Me.InvoiceCountTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. of Invoices: "
        '
        'CalculatedTotalTextBox
        '
        Me.CalculatedTotalTextBox.Location = New System.Drawing.Point(279, 19)
        Me.CalculatedTotalTextBox.Name = "CalculatedTotalTextBox"
        Me.CalculatedTotalTextBox.ReadOnly = True
        Me.CalculatedTotalTextBox.Size = New System.Drawing.Size(62, 20)
        Me.CalculatedTotalTextBox.TabIndex = 3
        Me.CalculatedTotalTextBox.Visible = False
        '
        'CalculatedTotalLabel
        '
        Me.CalculatedTotalLabel.AutoSize = True
        Me.CalculatedTotalLabel.Location = New System.Drawing.Point(157, 22)
        Me.CalculatedTotalLabel.Name = "CalculatedTotalLabel"
        Me.CalculatedTotalLabel.Size = New System.Drawing.Size(128, 13)
        Me.CalculatedTotalLabel.TabIndex = 2
        Me.CalculatedTotalLabel.Text = "Calculated Record Total: "
        Me.CalculatedTotalLabel.Visible = False
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(89, 19)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(62, 20)
        Me.TotalTextBox.TabIndex = 1
        '
        'InvoicesDataGridView
        '
        Me.InvoicesDataGridView.AllowUserToAddRows = False
        Me.InvoicesDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.InvoicesDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle31
        Me.InvoicesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvoicesDataGridView.AutoGenerateColumns = False
        Me.InvoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvoicesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PKInvoiceIDColumn, Me.DataGridViewTextBoxColumn1, Me.FKCustomerIDColumn, Me.FKBillingAddressIDColumn, Me.FKShippingAddressIDColumn, Me.PONumberColumn, Me.BoxesColumn, Me.DataGridViewTextBoxColumn8, Me.TotalsColumn, Me.InvoiceType})
        Me.InvoicesDataGridView.DataSource = Me.InvoicesBindingSource
        Me.InvoicesDataGridView.Location = New System.Drawing.Point(9, 44)
        Me.InvoicesDataGridView.MultiSelect = False
        Me.InvoicesDataGridView.Name = "InvoicesDataGridView"
        Me.InvoicesDataGridView.Size = New System.Drawing.Size(373, 472)
        Me.InvoicesDataGridView.TabIndex = 1
        '
        'PKInvoiceIDColumn
        '
        Me.PKInvoiceIDColumn.DataPropertyName = "PKInvoiceID"
        Me.PKInvoiceIDColumn.Frozen = True
        Me.PKInvoiceIDColumn.HeaderText = "Invoice Number"
        Me.PKInvoiceIDColumn.Name = "PKInvoiceIDColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Date"
        DataGridViewCellStyle32.Format = "d"
        DataGridViewCellStyle32.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'FKCustomerIDColumn
        '
        Me.FKCustomerIDColumn.DataPropertyName = "FKCustomerID"
        Me.FKCustomerIDColumn.DataSource = Me.CustomersBindingSource
        Me.FKCustomerIDColumn.DisplayMember = "Company Name"
        Me.FKCustomerIDColumn.HeaderText = "Customer"
        Me.FKCustomerIDColumn.Name = "FKCustomerIDColumn"
        Me.FKCustomerIDColumn.ReadOnly = True
        Me.FKCustomerIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FKCustomerIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FKCustomerIDColumn.ValueMember = "PKCustomerID"
        '
        'FKBillingAddressIDColumn
        '
        Me.FKBillingAddressIDColumn.DataPropertyName = "FKBillingAddressID"
        Me.FKBillingAddressIDColumn.DataSource = Me.BillingAddressesBindingSource
        Me.FKBillingAddressIDColumn.DisplayMember = "FullAddress"
        Me.FKBillingAddressIDColumn.HeaderText = "Billing Address"
        Me.FKBillingAddressIDColumn.Name = "FKBillingAddressIDColumn"
        Me.FKBillingAddressIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FKBillingAddressIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FKBillingAddressIDColumn.ValueMember = "BillingAddressID"
        '
        'FKShippingAddressIDColumn
        '
        Me.FKShippingAddressIDColumn.DataPropertyName = "FKShippingAddressID"
        Me.FKShippingAddressIDColumn.DataSource = Me.ShippingAddressesBindingSource
        Me.FKShippingAddressIDColumn.DisplayMember = "FullAddress"
        Me.FKShippingAddressIDColumn.HeaderText = "Shipping Address"
        Me.FKShippingAddressIDColumn.Name = "FKShippingAddressIDColumn"
        Me.FKShippingAddressIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FKShippingAddressIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FKShippingAddressIDColumn.ValueMember = "ShippingAddressID"
        '
        'PONumberColumn
        '
        Me.PONumberColumn.DataPropertyName = "PO Number"
        Me.PONumberColumn.HeaderText = "PO Number"
        Me.PONumberColumn.Name = "PONumberColumn"
        '
        'BoxesColumn
        '
        Me.BoxesColumn.DataPropertyName = "Boxes"
        Me.BoxesColumn.HeaderText = "Number of Boxes"
        Me.BoxesColumn.Name = "BoxesColumn"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Shipping Notes"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Shipping Notes"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'TotalsColumn
        '
        Me.TotalsColumn.DataPropertyName = "Total"
        DataGridViewCellStyle33.Format = "C2"
        DataGridViewCellStyle33.NullValue = Nothing
        Me.TotalsColumn.DefaultCellStyle = DataGridViewCellStyle33
        Me.TotalsColumn.HeaderText = "Total"
        Me.TotalsColumn.Name = "TotalsColumn"
        Me.TotalsColumn.ReadOnly = True
        '
        'InvoiceType
        '
        Me.InvoiceType.DataPropertyName = "InvoiceType"
        Me.InvoiceType.DataSource = Me.InvoiceTypeSelectionBindingSource
        Me.InvoiceType.DisplayMember = "Description"
        Me.InvoiceType.HeaderText = "InvoiceType"
        Me.InvoiceType.Name = "InvoiceType"
        Me.InvoiceType.ValueMember = "PKTypeID"
        '
        'InvoiceTypeSelectionBindingSource
        '
        Me.InvoiceTypeSelectionBindingSource.DataMember = "InvoiceTypeSelection"
        Me.InvoiceTypeSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'CaviarGroupBox
        '
        Me.CaviarGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaviarGroupBox.Controls.Add(Me.CaviarOrderDisplayDataGridView)
        Me.CaviarGroupBox.Controls.Add(Me.CaviarCountTextBox)
        Me.CaviarGroupBox.Controls.Add(Me.Label5)
        Me.CaviarGroupBox.Controls.Add(Me.CaviarSubtotalTextBox)
        Me.CaviarGroupBox.Controls.Add(Me.Label2)
        Me.CaviarGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.CaviarGroupBox.Name = "CaviarGroupBox"
        Me.CaviarGroupBox.Size = New System.Drawing.Size(776, 140)
        Me.CaviarGroupBox.TabIndex = 3
        Me.CaviarGroupBox.TabStop = False
        Me.CaviarGroupBox.Text = "Caviar Invoiced"
        '
        'CaviarOrderDisplayDataGridView
        '
        Me.CaviarOrderDisplayDataGridView.AllowUserToAddRows = False
        Me.CaviarOrderDisplayDataGridView.AllowUserToDeleteRows = False
        Me.CaviarOrderDisplayDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CaviarOrderDisplayDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle34
        Me.CaviarOrderDisplayDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaviarOrderDisplayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CaviarOrderDisplayDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BoxNameCaviarOrderDisplayColumn, Me.ProductNameCaviarOrderDisplayColumn, Me.CountCaviarOrderDisplayColumn, Me.PriceSoldAtCaviarOrderDisplayColumn, Me.TotalKgsCaviarOrderDisplayColumn, Me.SubTotalCaviarOrderDisplayColumn})
        Me.CaviarOrderDisplayDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.CaviarOrderDisplayDataGridView.Name = "CaviarOrderDisplayDataGridView"
        Me.CaviarOrderDisplayDataGridView.ReadOnly = True
        Me.CaviarOrderDisplayDataGridView.Size = New System.Drawing.Size(767, 125)
        Me.CaviarOrderDisplayDataGridView.TabIndex = 27
        '
        'BoxNameCaviarOrderDisplayColumn
        '
        Me.BoxNameCaviarOrderDisplayColumn.HeaderText = "Box Name"
        Me.BoxNameCaviarOrderDisplayColumn.Name = "BoxNameCaviarOrderDisplayColumn"
        Me.BoxNameCaviarOrderDisplayColumn.ReadOnly = True
        Me.BoxNameCaviarOrderDisplayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ProductNameCaviarOrderDisplayColumn
        '
        Me.ProductNameCaviarOrderDisplayColumn.HeaderText = "Product Code"
        Me.ProductNameCaviarOrderDisplayColumn.Name = "ProductNameCaviarOrderDisplayColumn"
        Me.ProductNameCaviarOrderDisplayColumn.ReadOnly = True
        Me.ProductNameCaviarOrderDisplayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CountCaviarOrderDisplayColumn
        '
        Me.CountCaviarOrderDisplayColumn.HeaderText = "Count"
        Me.CountCaviarOrderDisplayColumn.Name = "CountCaviarOrderDisplayColumn"
        Me.CountCaviarOrderDisplayColumn.ReadOnly = True
        Me.CountCaviarOrderDisplayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PriceSoldAtCaviarOrderDisplayColumn
        '
        DataGridViewCellStyle35.Format = "C2"
        DataGridViewCellStyle35.NullValue = Nothing
        Me.PriceSoldAtCaviarOrderDisplayColumn.DefaultCellStyle = DataGridViewCellStyle35
        Me.PriceSoldAtCaviarOrderDisplayColumn.HeaderText = "Price Per Kg"
        Me.PriceSoldAtCaviarOrderDisplayColumn.Name = "PriceSoldAtCaviarOrderDisplayColumn"
        Me.PriceSoldAtCaviarOrderDisplayColumn.ReadOnly = True
        Me.PriceSoldAtCaviarOrderDisplayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TotalKgsCaviarOrderDisplayColumn
        '
        Me.TotalKgsCaviarOrderDisplayColumn.HeaderText = "Total Kgs"
        Me.TotalKgsCaviarOrderDisplayColumn.Name = "TotalKgsCaviarOrderDisplayColumn"
        Me.TotalKgsCaviarOrderDisplayColumn.ReadOnly = True
        Me.TotalKgsCaviarOrderDisplayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SubTotalCaviarOrderDisplayColumn
        '
        DataGridViewCellStyle36.Format = "C2"
        DataGridViewCellStyle36.NullValue = Nothing
        Me.SubTotalCaviarOrderDisplayColumn.DefaultCellStyle = DataGridViewCellStyle36
        Me.SubTotalCaviarOrderDisplayColumn.HeaderText = "Sub Total"
        Me.SubTotalCaviarOrderDisplayColumn.Name = "SubTotalCaviarOrderDisplayColumn"
        Me.SubTotalCaviarOrderDisplayColumn.ReadOnly = True
        Me.SubTotalCaviarOrderDisplayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CaviarCountTextBox
        '
        Me.CaviarCountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaviarCountTextBox.Location = New System.Drawing.Point(528, 114)
        Me.CaviarCountTextBox.Name = "CaviarCountTextBox"
        Me.CaviarCountTextBox.ReadOnly = True
        Me.CaviarCountTextBox.Size = New System.Drawing.Size(89, 20)
        Me.CaviarCountTextBox.TabIndex = 6
        Me.CaviarCountTextBox.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(484, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Count:"
        Me.Label5.Visible = False
        '
        'CaviarSubtotalTextBox
        '
        Me.CaviarSubtotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaviarSubtotalTextBox.Location = New System.Drawing.Point(678, 114)
        Me.CaviarSubtotalTextBox.Name = "CaviarSubtotalTextBox"
        Me.CaviarSubtotalTextBox.ReadOnly = True
        Me.CaviarSubtotalTextBox.Size = New System.Drawing.Size(89, 20)
        Me.CaviarSubtotalTextBox.TabIndex = 4
        Me.CaviarSubtotalTextBox.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(623, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Subtotal:"
        Me.Label2.Visible = False
        '
        'EditCaviarInvoiceButton
        '
        Me.EditCaviarInvoiceButton.Location = New System.Drawing.Point(118, 0)
        Me.EditCaviarInvoiceButton.Name = "EditCaviarInvoiceButton"
        Me.EditCaviarInvoiceButton.Size = New System.Drawing.Size(112, 24)
        Me.EditCaviarInvoiceButton.TabIndex = 7
        Me.EditCaviarInvoiceButton.Text = "Edit"
        Me.EditCaviarInvoiceButton.UseVisualStyleBackColor = True
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'CaviarFishBindingSource
        '
        Me.CaviarFishBindingSource.DataMember = "Caviar Fish"
        Me.CaviarFishBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'CaviarStatusSelectionBindingSource
        '
        Me.CaviarStatusSelectionBindingSource.DataMember = "CaviarStatusSelection"
        Me.CaviarStatusSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'Caviar_InventoryBindingSource
        '
        Me.Caviar_InventoryBindingSource.DataMember = "InvoicesCaviar Inventory"
        Me.Caviar_InventoryBindingSource.DataSource = Me.InvoicesBindingSource
        '
        'NonInventoryGroupBox
        '
        Me.NonInventoryGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NonInventoryGroupBox.Controls.Add(Me.EditFishInvoice)
        Me.NonInventoryGroupBox.Controls.Add(Me.OthersCountTextBox)
        Me.NonInventoryGroupBox.Controls.Add(Me.Label6)
        Me.NonInventoryGroupBox.Controls.Add(Me.OthersSubtotalTextBox)
        Me.NonInventoryGroupBox.Controls.Add(Me.Label1)
        Me.NonInventoryGroupBox.Controls.Add(Me.Non_Inventory_Invoice_RecordsDataGridView)
        Me.NonInventoryGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.NonInventoryGroupBox.Name = "NonInventoryGroupBox"
        Me.NonInventoryGroupBox.Size = New System.Drawing.Size(778, 334)
        Me.NonInventoryGroupBox.TabIndex = 4
        Me.NonInventoryGroupBox.TabStop = False
        Me.NonInventoryGroupBox.Text = "Other Items Invoiced"
        '
        'OthersCountTextBox
        '
        Me.OthersCountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OthersCountTextBox.Location = New System.Drawing.Point(530, 306)
        Me.OthersCountTextBox.Name = "OthersCountTextBox"
        Me.OthersCountTextBox.ReadOnly = True
        Me.OthersCountTextBox.Size = New System.Drawing.Size(89, 20)
        Me.OthersCountTextBox.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(486, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Count:"
        '
        'OthersSubtotalTextBox
        '
        Me.OthersSubtotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OthersSubtotalTextBox.Location = New System.Drawing.Point(680, 306)
        Me.OthersSubtotalTextBox.Name = "OthersSubtotalTextBox"
        Me.OthersSubtotalTextBox.ReadOnly = True
        Me.OthersSubtotalTextBox.Size = New System.Drawing.Size(89, 20)
        Me.OthersSubtotalTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(625, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subtotal:"
        '
        'Non_Inventory_Invoice_RecordsDataGridView
        '
        Me.Non_Inventory_Invoice_RecordsDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Non_Inventory_Invoice_RecordsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle37
        Me.Non_Inventory_Invoice_RecordsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Non_Inventory_Invoice_RecordsDataGridView.AutoGenerateColumns = False
        Me.Non_Inventory_Invoice_RecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Non_Inventory_Invoice_RecordsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NonInventoryFKProductIDColumn, Me.NonInventoryQuantityColumn, Me.NonInventoryPriceSoldAtColumn, Me.NonInventoryNotesColumn})
        Me.Non_Inventory_Invoice_RecordsDataGridView.DataSource = Me.Non_Inventory_Invoice_RecordsBindingSource
        Me.Non_Inventory_Invoice_RecordsDataGridView.Location = New System.Drawing.Point(3, 25)
        Me.Non_Inventory_Invoice_RecordsDataGridView.MultiSelect = False
        Me.Non_Inventory_Invoice_RecordsDataGridView.Name = "Non_Inventory_Invoice_RecordsDataGridView"
        Me.Non_Inventory_Invoice_RecordsDataGridView.Size = New System.Drawing.Size(772, 275)
        Me.Non_Inventory_Invoice_RecordsDataGridView.TabIndex = 0
        '
        'NonInventoryFKProductIDColumn
        '
        Me.NonInventoryFKProductIDColumn.DataPropertyName = "FKProductID"
        Me.NonInventoryFKProductIDColumn.DataSource = Me.NonInventoryProductBindingSource
        Me.NonInventoryFKProductIDColumn.DisplayMember = "Product Name"
        Me.NonInventoryFKProductIDColumn.HeaderText = "Product Code"
        Me.NonInventoryFKProductIDColumn.Name = "NonInventoryFKProductIDColumn"
        Me.NonInventoryFKProductIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NonInventoryFKProductIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NonInventoryFKProductIDColumn.ValueMember = "PKProductID"
        '
        'NonInventoryProductBindingSource
        '
        Me.NonInventoryProductBindingSource.DataMember = "Products"
        Me.NonInventoryProductBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'NonInventoryQuantityColumn
        '
        Me.NonInventoryQuantityColumn.DataPropertyName = "Quantity"
        Me.NonInventoryQuantityColumn.HeaderText = "Quantity"
        Me.NonInventoryQuantityColumn.Name = "NonInventoryQuantityColumn"
        '
        'NonInventoryPriceSoldAtColumn
        '
        Me.NonInventoryPriceSoldAtColumn.DataPropertyName = "PriceSoldAt"
        DataGridViewCellStyle38.Format = "C2"
        DataGridViewCellStyle38.NullValue = Nothing
        Me.NonInventoryPriceSoldAtColumn.DefaultCellStyle = DataGridViewCellStyle38
        Me.NonInventoryPriceSoldAtColumn.HeaderText = "Price"
        Me.NonInventoryPriceSoldAtColumn.Name = "NonInventoryPriceSoldAtColumn"
        '
        'NonInventoryNotesColumn
        '
        Me.NonInventoryNotesColumn.DataPropertyName = "Notes"
        Me.NonInventoryNotesColumn.HeaderText = "Notes"
        Me.NonInventoryNotesColumn.Name = "NonInventoryNotesColumn"
        '
        'Non_Inventory_Invoice_RecordsBindingSource
        '
        Me.Non_Inventory_Invoice_RecordsBindingSource.DataMember = "InvoicesNon-Inventory Invoice Records"
        Me.Non_Inventory_Invoice_RecordsBindingSource.DataSource = Me.InvoicesBindingSource
        '
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Application_SettingsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Me.Billing_AddressesTableAdapter
        Me.TableAdapterManager.Caviar_FishTableAdapter = Me.Caviar_FishTableAdapter
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Me.Caviar_InventoryTableAdapter
        Me.TableAdapterManager.CaviarInventoryInvoiceFlatTableTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryValueTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Me.CaviarStatusSelectionTableAdapter
        Me.TableAdapterManager.ConcurrencyHandlerTableAdapter = Nothing
        Me.TableAdapterManager.Customer_PricingTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.FemaleFishInventoryTableAdapter = Nothing
        Me.TableAdapterManager.FilterColumnsTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Me.GradeSelectionTableAdapter
        Me.TableAdapterManager.InvoicesTableAdapter = Me.InvoicesTableAdapter
        Me.TableAdapterManager.InvoiceTypeSelectionTableAdapter = Me.InvoiceTypeSelectionTableAdapter
        Me.TableAdapterManager.MaleFishHarvestTableAdapter = Nothing
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Me.Non_Inventory_Invoice_RecordsTableAdapter
        Me.TableAdapterManager.NonInventoryInvoiceFlatTableTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Me.ProductCategorySelectionTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.RepackLossTableAdapter = Nothing
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Me.Shipping_AddressesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeightConversionConstantsTableAdapter = Nothing
        '
        'Billing_AddressesTableAdapter
        '
        Me.Billing_AddressesTableAdapter.ClearBeforeFill = True
        '
        'Caviar_FishTableAdapter
        '
        Me.Caviar_FishTableAdapter.ClearBeforeFill = True
        '
        'Caviar_InventoryTableAdapter
        '
        Me.Caviar_InventoryTableAdapter.ClearBeforeFill = True
        '
        'CaviarStatusSelectionTableAdapter
        '
        Me.CaviarStatusSelectionTableAdapter.ClearBeforeFill = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'GradeSelectionTableAdapter
        '
        Me.GradeSelectionTableAdapter.ClearBeforeFill = True
        '
        'InvoiceTypeSelectionTableAdapter
        '
        Me.InvoiceTypeSelectionTableAdapter.ClearBeforeFill = True
        '
        'Non_Inventory_Invoice_RecordsTableAdapter
        '
        Me.Non_Inventory_Invoice_RecordsTableAdapter.ClearBeforeFill = True
        '
        'ProductCategorySelectionTableAdapter
        '
        Me.ProductCategorySelectionTableAdapter.ClearBeforeFill = True
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'Shipping_AddressesTableAdapter
        '
        Me.Shipping_AddressesTableAdapter.ClearBeforeFill = True
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MainSplitContainer.Location = New System.Drawing.Point(2, 2)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.Controls.Add(Me.InvoiceGroupBox)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.InvoicedItemsSplitContainer)
        Me.MainSplitContainer.Size = New System.Drawing.Size(1186, 673)
        Me.MainSplitContainer.SplitterDistance = 395
        Me.MainSplitContainer.TabIndex = 5
        '
        'InvoicedItemsSplitContainer
        '
        Me.InvoicedItemsSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvoicedItemsSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InvoicedItemsSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.InvoicedItemsSplitContainer.Name = "InvoicedItemsSplitContainer"
        Me.InvoicedItemsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'InvoicedItemsSplitContainer.Panel1
        '
        Me.InvoicedItemsSplitContainer.Panel1.Controls.Add(Me.CaviarInvoicedSplitContainer)
        '
        'InvoicedItemsSplitContainer.Panel2
        '
        Me.InvoicedItemsSplitContainer.Panel2.Controls.Add(Me.NonInventoryGroupBox)
        Me.InvoicedItemsSplitContainer.Size = New System.Drawing.Size(785, 669)
        Me.InvoicedItemsSplitContainer.SplitterDistance = 324
        Me.InvoicedItemsSplitContainer.TabIndex = 0
        '
        'CaviarInvoicedSplitContainer
        '
        Me.CaviarInvoicedSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaviarInvoicedSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CaviarInvoicedSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.CaviarInvoicedSplitContainer.Name = "CaviarInvoicedSplitContainer"
        Me.CaviarInvoicedSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'CaviarInvoicedSplitContainer.Panel1
        '
        Me.CaviarInvoicedSplitContainer.Panel1.Controls.Add(Me.CaviarGroupBox)
        '
        'CaviarInvoicedSplitContainer.Panel2
        '
        Me.CaviarInvoicedSplitContainer.Panel2.AutoScroll = True
        Me.CaviarInvoicedSplitContainer.Panel2.Controls.Add(Me.ListOfItemsInvoicedGroupBox)
        Me.CaviarInvoicedSplitContainer.Size = New System.Drawing.Size(786, 321)
        Me.CaviarInvoicedSplitContainer.SplitterDistance = 150
        Me.CaviarInvoicedSplitContainer.TabIndex = 0
        '
        'ListOfItemsInvoicedGroupBox
        '
        Me.ListOfItemsInvoicedGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListOfItemsInvoicedGroupBox.Controls.Add(Me.EditCaviarInvoiceButton)
        Me.ListOfItemsInvoicedGroupBox.Controls.Add(Me.Caviar_InventoryDataGridView)
        Me.ListOfItemsInvoicedGroupBox.Location = New System.Drawing.Point(0, 3)
        Me.ListOfItemsInvoicedGroupBox.Name = "ListOfItemsInvoicedGroupBox"
        Me.ListOfItemsInvoicedGroupBox.Size = New System.Drawing.Size(782, 160)
        Me.ListOfItemsInvoicedGroupBox.TabIndex = 6
        Me.ListOfItemsInvoicedGroupBox.TabStop = False
        Me.ListOfItemsInvoicedGroupBox.Text = "List of Items Invoiced"
        '
        'Caviar_InventoryDataGridView
        '
        Me.Caviar_InventoryDataGridView.AllowUserToAddRows = False
        Me.Caviar_InventoryDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Caviar_InventoryDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle39
        Me.Caviar_InventoryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Caviar_InventoryDataGridView.AutoGenerateColumns = False
        Me.Caviar_InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Caviar_InventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PKBarcodeColumn, Me.OrderOnInvoice, Me.CaviarFKProductIDColumn, Me.FishTagColumn, Me.HarvestDateColumn, Me.EggSizeColumn, Me.TasteColumn, Me.FirmnessColumn, Me.ColorColumn, Me.CaviarPriceSoldAtColumn, Me.PricePerItemColumn, Me.InventoryStatusColumn, Me.PackingBoxNumberColumn, Me.CaviarNotesColumn, Me.FKInvoiceIDColumn, Me.DateStatusChanged, Me.PreviousStatus})
        Me.Caviar_InventoryDataGridView.DataSource = Me.Caviar_InventoryBindingSource
        Me.Caviar_InventoryDataGridView.Location = New System.Drawing.Point(0, 30)
        Me.Caviar_InventoryDataGridView.MultiSelect = False
        Me.Caviar_InventoryDataGridView.Name = "Caviar_InventoryDataGridView"
        Me.Caviar_InventoryDataGridView.Size = New System.Drawing.Size(782, 130)
        Me.Caviar_InventoryDataGridView.TabIndex = 0
        '
        'PKBarcodeColumn
        '
        Me.PKBarcodeColumn.DataPropertyName = "PKBarcode"
        Me.PKBarcodeColumn.HeaderText = "Barcode"
        Me.PKBarcodeColumn.Name = "PKBarcodeColumn"
        Me.PKBarcodeColumn.ReadOnly = True
        Me.PKBarcodeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'OrderOnInvoice
        '
        Me.OrderOnInvoice.DataPropertyName = "OrderOnInvoice"
        Me.OrderOnInvoice.HeaderText = "OrderOnInvoice"
        Me.OrderOnInvoice.Name = "OrderOnInvoice"
        Me.OrderOnInvoice.ReadOnly = True
        Me.OrderOnInvoice.Visible = False
        '
        'CaviarFKProductIDColumn
        '
        Me.CaviarFKProductIDColumn.DataPropertyName = "FKProductID"
        Me.CaviarFKProductIDColumn.DataSource = Me.ProductsBindingSource
        Me.CaviarFKProductIDColumn.DisplayMember = "Product Name"
        Me.CaviarFKProductIDColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.CaviarFKProductIDColumn.HeaderText = "Product Code"
        Me.CaviarFKProductIDColumn.Name = "CaviarFKProductIDColumn"
        Me.CaviarFKProductIDColumn.ReadOnly = True
        Me.CaviarFKProductIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CaviarFKProductIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CaviarFKProductIDColumn.ValueMember = "PKProductID"
        '
        'FishTagColumn
        '
        Me.FishTagColumn.DataPropertyName = "FKFishID"
        Me.FishTagColumn.DataSource = Me.CaviarFishBindingSource
        Me.FishTagColumn.DisplayMember = "Tag"
        Me.FishTagColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FishTagColumn.HeaderText = "Fish Tag"
        Me.FishTagColumn.Name = "FishTagColumn"
        Me.FishTagColumn.ReadOnly = True
        Me.FishTagColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FishTagColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FishTagColumn.ValueMember = "PKFishID"
        '
        'HarvestDateColumn
        '
        Me.HarvestDateColumn.DataPropertyName = "FKFishID"
        Me.HarvestDateColumn.DataSource = Me.CaviarFishBindingSource
        Me.HarvestDateColumn.DisplayMember = "Harvest Date"
        Me.HarvestDateColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.HarvestDateColumn.HeaderText = "Harvest Date"
        Me.HarvestDateColumn.Name = "HarvestDateColumn"
        Me.HarvestDateColumn.ReadOnly = True
        Me.HarvestDateColumn.ValueMember = "PKFishID"
        '
        'EggSizeColumn
        '
        Me.EggSizeColumn.DataPropertyName = "FKFishID"
        Me.EggSizeColumn.DataSource = Me.CaviarFishBindingSource
        Me.EggSizeColumn.DisplayMember = "Eggsize"
        Me.EggSizeColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.EggSizeColumn.HeaderText = "Egg Size"
        Me.EggSizeColumn.Name = "EggSizeColumn"
        Me.EggSizeColumn.ReadOnly = True
        Me.EggSizeColumn.ValueMember = "PKFishID"
        '
        'TasteColumn
        '
        Me.TasteColumn.DataPropertyName = "FKFishID"
        Me.TasteColumn.DataSource = Me.CaviarFishBindingSource
        Me.TasteColumn.DisplayMember = "Taste"
        Me.TasteColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.TasteColumn.HeaderText = "Taste"
        Me.TasteColumn.Name = "TasteColumn"
        Me.TasteColumn.ReadOnly = True
        Me.TasteColumn.ValueMember = "PKFishID"
        '
        'FirmnessColumn
        '
        Me.FirmnessColumn.DataPropertyName = "FKFishID"
        Me.FirmnessColumn.DataSource = Me.CaviarFishBindingSource
        Me.FirmnessColumn.DisplayMember = "Firmness"
        Me.FirmnessColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FirmnessColumn.HeaderText = "Firmness"
        Me.FirmnessColumn.Name = "FirmnessColumn"
        Me.FirmnessColumn.ReadOnly = True
        Me.FirmnessColumn.ValueMember = "PKFishID"
        '
        'ColorColumn
        '
        Me.ColorColumn.DataPropertyName = "FKFishID"
        Me.ColorColumn.DataSource = Me.CaviarFishBindingSource
        Me.ColorColumn.DisplayMember = "Egg Color"
        Me.ColorColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColorColumn.HeaderText = "Color"
        Me.ColorColumn.Name = "ColorColumn"
        Me.ColorColumn.ReadOnly = True
        Me.ColorColumn.ValueMember = "PKFishID"
        '
        'CaviarPriceSoldAtColumn
        '
        Me.CaviarPriceSoldAtColumn.DataPropertyName = "PriceSoldAt"
        DataGridViewCellStyle40.Format = "C2"
        DataGridViewCellStyle40.NullValue = Nothing
        Me.CaviarPriceSoldAtColumn.DefaultCellStyle = DataGridViewCellStyle40
        Me.CaviarPriceSoldAtColumn.HeaderText = "Price Per Kg"
        Me.CaviarPriceSoldAtColumn.Name = "CaviarPriceSoldAtColumn"
        Me.CaviarPriceSoldAtColumn.ReadOnly = True
        '
        'PricePerItemColumn
        '
        Me.PricePerItemColumn.HeaderText = "Price Per Item"
        Me.PricePerItemColumn.Name = "PricePerItemColumn"
        Me.PricePerItemColumn.ReadOnly = True
        '
        'InventoryStatusColumn
        '
        Me.InventoryStatusColumn.DataPropertyName = "InventoryStatus"
        Me.InventoryStatusColumn.DataSource = Me.CaviarStatusSelectionBindingSource
        Me.InventoryStatusColumn.DisplayMember = "Description"
        Me.InventoryStatusColumn.HeaderText = "Inventory Status"
        Me.InventoryStatusColumn.Name = "InventoryStatusColumn"
        Me.InventoryStatusColumn.ReadOnly = True
        Me.InventoryStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.InventoryStatusColumn.ValueMember = "PKStatusID"
        '
        'PackingBoxNumberColumn
        '
        Me.PackingBoxNumberColumn.DataPropertyName = "PackingBoxNumber"
        Me.PackingBoxNumberColumn.HeaderText = "PackingBoxNumber"
        Me.PackingBoxNumberColumn.Name = "PackingBoxNumberColumn"
        '
        'CaviarNotesColumn
        '
        Me.CaviarNotesColumn.DataPropertyName = "Notes"
        Me.CaviarNotesColumn.HeaderText = "Notes"
        Me.CaviarNotesColumn.Name = "CaviarNotesColumn"
        '
        'FKInvoiceIDColumn
        '
        Me.FKInvoiceIDColumn.DataPropertyName = "FKInvoiceID"
        Me.FKInvoiceIDColumn.HeaderText = "FKInvoiceID"
        Me.FKInvoiceIDColumn.Name = "FKInvoiceIDColumn"
        Me.FKInvoiceIDColumn.ReadOnly = True
        Me.FKInvoiceIDColumn.Visible = False
        '
        'DateStatusChanged
        '
        Me.DateStatusChanged.DataPropertyName = "DateStatusChanged"
        Me.DateStatusChanged.HeaderText = "Date Status Changed"
        Me.DateStatusChanged.Name = "DateStatusChanged"
        '
        'PreviousStatus
        '
        Me.PreviousStatus.DataPropertyName = "PreviousStatus"
        Me.PreviousStatus.DataSource = Me.CaviarStatusSelectionBindingSource
        Me.PreviousStatus.DisplayMember = "Description"
        Me.PreviousStatus.HeaderText = "Previous Status"
        Me.PreviousStatus.Name = "PreviousStatus"
        Me.PreviousStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PreviousStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PreviousStatus.ValueMember = "PKStatusID"
        '
        'EditFishInvoice
        '
        Me.EditFishInvoice.Location = New System.Drawing.Point(117, 0)
        Me.EditFishInvoice.Name = "EditFishInvoice"
        Me.EditFishInvoice.Size = New System.Drawing.Size(112, 24)
        Me.EditFishInvoice.TabIndex = 9
        Me.EditFishInvoice.Text = "Edit Fish Invoice"
        Me.EditFishInvoice.UseVisualStyleBackColor = True
        Me.EditFishInvoice.Visible = False
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 680)
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Name = "Invoice"
        Me.Text = "Edit Invoices"
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingAddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippingAddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBillingAddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersShippingAddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoiceGroupBox.ResumeLayout(False)
        Me.InvoiceGroupBox.PerformLayout()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoicesBindingNavigator.ResumeLayout(False)
        Me.InvoicesBindingNavigator.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.InvoicesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceTypeSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CaviarGroupBox.ResumeLayout(False)
        Me.CaviarGroupBox.PerformLayout()
        CType(Me.CaviarOrderDisplayDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarFishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caviar_InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NonInventoryGroupBox.ResumeLayout(False)
        Me.NonInventoryGroupBox.PerformLayout()
        CType(Me.Non_Inventory_Invoice_RecordsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NonInventoryProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Non_Inventory_Invoice_RecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        Me.MainSplitContainer.ResumeLayout(False)
        Me.InvoicedItemsSplitContainer.Panel1.ResumeLayout(False)
        Me.InvoicedItemsSplitContainer.Panel2.ResumeLayout(False)
        Me.InvoicedItemsSplitContainer.ResumeLayout(False)
        Me.CaviarInvoicedSplitContainer.Panel1.ResumeLayout(False)
        Me.CaviarInvoicedSplitContainer.Panel2.ResumeLayout(False)
        Me.CaviarInvoicedSplitContainer.ResumeLayout(False)
        Me.ListOfItemsInvoicedGroupBox.ResumeLayout(False)
        CType(Me.Caviar_InventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents InvoicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoicesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Shipping_AddressesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Shipping_AddressesTableAdapter
    Friend WithEvents CustomersShippingAddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Billing_AddressesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Billing_AddressesTableAdapter
    Friend WithEvents CustomersBillingAddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoiceGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Caviar_InventoryTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
    Friend WithEvents CaviarGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Caviar_InventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caviar_FishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
    Friend WithEvents CaviarFishBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarStatusSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
    Friend WithEvents CaviarStatusSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Non_Inventory_Invoice_RecordsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Non_Inventory_Invoice_RecordsTableAdapter
    Friend WithEvents NonInventoryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Non_Inventory_Invoice_RecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CaviarSubtotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OthersSubtotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CalculatedTotalLabel As System.Windows.Forms.Label
    Friend WithEvents CalculatedTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvoicesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InvoicesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FilterButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExportExcelButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents InvoiceCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalSalesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CurrentInvoiceItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingAddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShippingAddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OthersCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents EditCaviarInvoiceButton As System.Windows.Forms.Button
    Friend WithEvents GradeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
    Friend WithEvents InvoicesDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents Caviar_InventoryDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents Non_Inventory_Invoice_RecordsDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents CaviarOrderDisplayDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents PKBarcodeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderOnInvoice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaviarFKProductIDColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FishTagColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HarvestDateColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents EggSizeColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TasteColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FirmnessColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ColorColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CaviarPriceSoldAtColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PricePerItemColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryStatusColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PackingBoxNumberColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaviarNotesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKInvoiceIDColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateStatusChanged As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreviousStatus As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents InvoiceTypeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoiceTypeSelectionTableAdapter
    Friend WithEvents InvoiceTypeSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NonInventoryFKProductIDColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents NonInventoryProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NonInventoryQuantityColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NonInventoryPriceSoldAtColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NonInventoryNotesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BoxNameCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNameCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceSoldAtCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalKgsCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenerateCurrentPackingSlipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PKInvoiceIDColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKCustomerIDColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FKBillingAddressIDColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FKShippingAddressIDColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PONumberColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BoxesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalsColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents MainSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents InvoicedItemsSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents CaviarInvoicedSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents ListOfItemsInvoicedGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ProductCategorySelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductCategorySelectionTableAdapter
    Friend WithEvents EditFishInvoice As System.Windows.Forms.Button
End Class
