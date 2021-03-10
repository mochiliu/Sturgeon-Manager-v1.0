<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditInventory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CaviarInventoryJoinCaviarFishBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.CaviarInventoryJoinCaviarFishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
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
        Me.CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FilterButton = New System.Windows.Forms.ToolStripButton
        Me.ExportExcelButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.ExportInventoryDisplayedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportQuickSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintButton = New System.Windows.Forms.ToolStripButton
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaviarStatusSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradeSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaviarInventoryJoinCaviarFishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarInventoryJoinCaviarFishTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.Caviar_InventoryTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
        Me.CaviarStatusSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
        Me.GradeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
        Me.ProductsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
        Me.SplitContainer = New System.Windows.Forms.SplitContainer
        Me.CaviarInventoryJoinCaviarFishDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.PKBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKProductID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ProductUnitWeightColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.InventoryStatus = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.FKInvoiceID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceSoldAt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PackingBoxNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateStatusChanged = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PreviousStatus = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.FishTag = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HarvestDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Species = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Eggsize = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Taste = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Firmness = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EggColor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Grade = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.GrowoutTank = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PurgeTank = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FishYC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LiveWt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GuttedWt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OvaryTot = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OvaryWaste = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EggWt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Salt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cycled = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Completed = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.TotalKgsCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CountCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductNameCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaviarInventoryDisplayDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.CaviarInventoryJoinCaviarFishBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.SuspendLayout()
        CType(Me.CaviarInventoryJoinCaviarFishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.CaviarInventoryJoinCaviarFishDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarInventoryDisplayDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CaviarInventoryJoinCaviarFishBindingNavigator
        '
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.BindingSource = Me.CaviarInventoryJoinCaviarFishBindingSource
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem, Me.FilterButton, Me.ExportExcelButton, Me.PrintButton})
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.Name = "CaviarInventoryJoinCaviarFishBindingNavigator"
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.Size = New System.Drawing.Size(693, 25)
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.TabIndex = 0
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'CaviarInventoryJoinCaviarFishBindingSource
        '
        Me.CaviarInventoryJoinCaviarFishBindingSource.DataMember = "CaviarInventoryJoinCaviarFish"
        Me.CaviarInventoryJoinCaviarFishBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem
        '
        Me.CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem.Image = CType(resources.GetObject("CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem.Name = "CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem"
        Me.CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem.Text = "Save Data"
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
        Me.ExportExcelButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportInventoryDisplayedToolStripMenuItem, Me.ExportQuickSummaryToolStripMenuItem})
        Me.ExportExcelButton.Image = CType(resources.GetObject("ExportExcelButton.Image"), System.Drawing.Image)
        Me.ExportExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportExcelButton.Name = "ExportExcelButton"
        Me.ExportExcelButton.Size = New System.Drawing.Size(29, 22)
        Me.ExportExcelButton.Text = "Export to Excel"
        '
        'ExportInventoryDisplayedToolStripMenuItem
        '
        Me.ExportInventoryDisplayedToolStripMenuItem.Name = "ExportInventoryDisplayedToolStripMenuItem"
        Me.ExportInventoryDisplayedToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ExportInventoryDisplayedToolStripMenuItem.Text = "Export Inventory Displayed"
        '
        'ExportQuickSummaryToolStripMenuItem
        '
        Me.ExportQuickSummaryToolStripMenuItem.Name = "ExportQuickSummaryToolStripMenuItem"
        Me.ExportQuickSummaryToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ExportQuickSummaryToolStripMenuItem.Text = "Export Quick Summary"
        '
        'PrintButton
        '
        Me.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintButton.Image = CType(resources.GetObject("PrintButton.Image"), System.Drawing.Image)
        Me.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintButton.Text = "Print Label"
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'CaviarStatusSelectionBindingSource
        '
        Me.CaviarStatusSelectionBindingSource.DataMember = "CaviarStatusSelection"
        Me.CaviarStatusSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'GradeSelectionBindingSource
        '
        Me.GradeSelectionBindingSource.DataMember = "GradeSelection"
        Me.GradeSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'CaviarInventoryJoinCaviarFishTableAdapter
        '
        Me.CaviarInventoryJoinCaviarFishTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Application_SettingsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_FishTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Me.Caviar_InventoryTableAdapter
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Me.CaviarInventoryJoinCaviarFishTableAdapter
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Me.CaviarStatusSelectionTableAdapter
        Me.TableAdapterManager.Customer_PricingTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.FilterColumnsTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Me.GradeSelectionTableAdapter
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTypeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Caviar_InventoryTableAdapter
        '
        Me.Caviar_InventoryTableAdapter.ClearBeforeFill = True
        '
        'CaviarStatusSelectionTableAdapter
        '
        Me.CaviarStatusSelectionTableAdapter.ClearBeforeFill = True
        '
        'GradeSelectionTableAdapter
        '
        Me.GradeSelectionTableAdapter.ClearBeforeFill = True
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'SplitContainer
        '
        Me.SplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.CaviarInventoryJoinCaviarFishDataGridView)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer.Size = New System.Drawing.Size(693, 552)
        Me.SplitContainer.SplitterDistance = 276
        Me.SplitContainer.TabIndex = 6
        '
        'CaviarInventoryJoinCaviarFishDataGridView
        '
        Me.CaviarInventoryJoinCaviarFishDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CaviarInventoryJoinCaviarFishDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CaviarInventoryJoinCaviarFishDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaviarInventoryJoinCaviarFishDataGridView.AutoGenerateColumns = False
        Me.CaviarInventoryJoinCaviarFishDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CaviarInventoryJoinCaviarFishDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PKBarcode, Me.FKProductID, Me.ProductUnitWeightColumn, Me.InventoryStatus, Me.FKInvoiceID, Me.PriceSoldAt, Me.PackingBoxNumber, Me.Notes, Me.DateStatusChanged, Me.PreviousStatus, Me.FishTag, Me.HarvestDate, Me.Species, Me.Eggsize, Me.Taste, Me.Firmness, Me.EggColor, Me.Grade, Me.GrowoutTank, Me.PurgeTank, Me.FishYC, Me.LiveWt, Me.GuttedWt, Me.OvaryTot, Me.OvaryWaste, Me.EggWt, Me.Salt, Me.Cycled, Me.Completed})
        Me.CaviarInventoryJoinCaviarFishDataGridView.DataSource = Me.CaviarInventoryJoinCaviarFishBindingSource
        Me.CaviarInventoryJoinCaviarFishDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CaviarInventoryJoinCaviarFishDataGridView.MultiSelect = False
        Me.CaviarInventoryJoinCaviarFishDataGridView.Name = "CaviarInventoryJoinCaviarFishDataGridView"
        Me.CaviarInventoryJoinCaviarFishDataGridView.Size = New System.Drawing.Size(689, 269)
        Me.CaviarInventoryJoinCaviarFishDataGridView.TabIndex = 1
        '
        'PKBarcode
        '
        Me.PKBarcode.DataPropertyName = "PKBarcode"
        Me.PKBarcode.HeaderText = "Barcode"
        Me.PKBarcode.Name = "PKBarcode"
        Me.PKBarcode.Width = 72
        '
        'FKProductID
        '
        Me.FKProductID.DataPropertyName = "FKProductID"
        Me.FKProductID.DataSource = Me.ProductsBindingSource
        Me.FKProductID.DisplayMember = "Product Name"
        Me.FKProductID.HeaderText = "ProductCode"
        Me.FKProductID.Name = "FKProductID"
        Me.FKProductID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FKProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FKProductID.ValueMember = "PKProductID"
        Me.FKProductID.Width = 94
        '
        'ProductUnitWeightColumn
        '
        Me.ProductUnitWeightColumn.DataPropertyName = "FKProductID"
        Me.ProductUnitWeightColumn.DataSource = Me.ProductsBindingSource
        Me.ProductUnitWeightColumn.DisplayMember = "UnitWeightgms"
        Me.ProductUnitWeightColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ProductUnitWeightColumn.HeaderText = "Unit Weight (grams)"
        Me.ProductUnitWeightColumn.Name = "ProductUnitWeightColumn"
        Me.ProductUnitWeightColumn.ReadOnly = True
        Me.ProductUnitWeightColumn.ValueMember = "PKProductID"
        Me.ProductUnitWeightColumn.Width = 96
        '
        'InventoryStatus
        '
        Me.InventoryStatus.DataPropertyName = "InventoryStatus"
        Me.InventoryStatus.DataSource = Me.CaviarStatusSelectionBindingSource
        Me.InventoryStatus.DisplayMember = "Description"
        Me.InventoryStatus.HeaderText = "Inventory Status"
        Me.InventoryStatus.Name = "InventoryStatus"
        Me.InventoryStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.InventoryStatus.ValueMember = "PKStatusID"
        '
        'FKInvoiceID
        '
        Me.FKInvoiceID.DataPropertyName = "FKInvoiceID"
        Me.FKInvoiceID.HeaderText = "Invoice Number"
        Me.FKInvoiceID.Name = "FKInvoiceID"
        '
        'PriceSoldAt
        '
        Me.PriceSoldAt.DataPropertyName = "PriceSoldAt"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PriceSoldAt.DefaultCellStyle = DataGridViewCellStyle2
        Me.PriceSoldAt.HeaderText = "Price Per Kg Sold At"
        Me.PriceSoldAt.Name = "PriceSoldAt"
        '
        'PackingBoxNumber
        '
        Me.PackingBoxNumber.DataPropertyName = "PackingBoxNumber"
        Me.PackingBoxNumber.HeaderText = "PackingBoxNumber"
        Me.PackingBoxNumber.Name = "PackingBoxNumber"
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "Inventory Notes"
        Me.Notes.Name = "Notes"
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
        Me.PreviousStatus.ValueMember = "PKStatusID"
        '
        'FishTag
        '
        Me.FishTag.DataPropertyName = "Tag"
        Me.FishTag.HeaderText = "Fish Tag"
        Me.FishTag.Name = "FishTag"
        Me.FishTag.ReadOnly = True
        '
        'HarvestDate
        '
        Me.HarvestDate.DataPropertyName = "Harvest Date"
        Me.HarvestDate.HeaderText = "Harvest Date"
        Me.HarvestDate.Name = "HarvestDate"
        Me.HarvestDate.ReadOnly = True
        '
        'Species
        '
        Me.Species.DataPropertyName = "Species"
        Me.Species.HeaderText = "Species"
        Me.Species.Name = "Species"
        Me.Species.ReadOnly = True
        '
        'Eggsize
        '
        Me.Eggsize.DataPropertyName = "Eggsize"
        Me.Eggsize.HeaderText = "Eggsize"
        Me.Eggsize.Name = "Eggsize"
        Me.Eggsize.ReadOnly = True
        '
        'Taste
        '
        Me.Taste.DataPropertyName = "Taste"
        Me.Taste.HeaderText = "Taste"
        Me.Taste.Name = "Taste"
        Me.Taste.ReadOnly = True
        '
        'Firmness
        '
        Me.Firmness.DataPropertyName = "Firmness"
        Me.Firmness.HeaderText = "Firmness"
        Me.Firmness.Name = "Firmness"
        Me.Firmness.ReadOnly = True
        '
        'EggColor
        '
        Me.EggColor.DataPropertyName = "Egg Color"
        Me.EggColor.HeaderText = "Egg Color"
        Me.EggColor.Name = "EggColor"
        Me.EggColor.ReadOnly = True
        '
        'Grade
        '
        Me.Grade.DataPropertyName = "Grade"
        Me.Grade.DataSource = Me.GradeSelectionBindingSource
        Me.Grade.DisplayMember = "Grade"
        Me.Grade.HeaderText = "Grade"
        Me.Grade.Name = "Grade"
        Me.Grade.ReadOnly = True
        Me.Grade.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Grade.ValueMember = "ID"
        '
        'GrowoutTank
        '
        Me.GrowoutTank.DataPropertyName = "Growout Tank"
        Me.GrowoutTank.HeaderText = "Growout Tank"
        Me.GrowoutTank.Name = "GrowoutTank"
        Me.GrowoutTank.ReadOnly = True
        '
        'PurgeTank
        '
        Me.PurgeTank.DataPropertyName = "Purge Tank"
        Me.PurgeTank.HeaderText = "Purge Tank"
        Me.PurgeTank.Name = "PurgeTank"
        Me.PurgeTank.ReadOnly = True
        '
        'FishYC
        '
        Me.FishYC.DataPropertyName = "Fish YC"
        Me.FishYC.HeaderText = "Fish YC"
        Me.FishYC.Name = "FishYC"
        Me.FishYC.ReadOnly = True
        '
        'LiveWt
        '
        Me.LiveWt.DataPropertyName = "Live Wt"
        Me.LiveWt.HeaderText = "Live Wt"
        Me.LiveWt.Name = "LiveWt"
        Me.LiveWt.ReadOnly = True
        '
        'GuttedWt
        '
        Me.GuttedWt.DataPropertyName = "Gutted Wt"
        Me.GuttedWt.HeaderText = "Gutted Wt"
        Me.GuttedWt.Name = "GuttedWt"
        Me.GuttedWt.ReadOnly = True
        '
        'OvaryTot
        '
        Me.OvaryTot.DataPropertyName = "Ovary Tot"
        Me.OvaryTot.HeaderText = "Ovary Tot"
        Me.OvaryTot.Name = "OvaryTot"
        Me.OvaryTot.ReadOnly = True
        '
        'OvaryWaste
        '
        Me.OvaryWaste.DataPropertyName = "Ovary Waste"
        Me.OvaryWaste.HeaderText = "Ovary Waste"
        Me.OvaryWaste.Name = "OvaryWaste"
        Me.OvaryWaste.ReadOnly = True
        '
        'EggWt
        '
        Me.EggWt.DataPropertyName = "Egg Wt"
        Me.EggWt.HeaderText = "Egg Wt"
        Me.EggWt.Name = "EggWt"
        Me.EggWt.ReadOnly = True
        '
        'Salt
        '
        Me.Salt.DataPropertyName = "Salt"
        Me.Salt.HeaderText = "Salt"
        Me.Salt.Name = "Salt"
        Me.Salt.ReadOnly = True
        '
        'Cycled
        '
        Me.Cycled.DataPropertyName = "Cycled"
        Me.Cycled.HeaderText = "Cycled"
        Me.Cycled.Name = "Cycled"
        Me.Cycled.ReadOnly = True
        '
        'Completed
        '
        Me.Completed.DataPropertyName = "Completed"
        Me.Completed.HeaderText = "Completed"
        Me.Completed.Name = "Completed"
        Me.Completed.ReadOnly = True
        '
        'TotalKgsCaviarOrderDisplayColumn
        '
        Me.TotalKgsCaviarOrderDisplayColumn.HeaderText = "Total Kgs"
        Me.TotalKgsCaviarOrderDisplayColumn.Name = "TotalKgsCaviarOrderDisplayColumn"
        Me.TotalKgsCaviarOrderDisplayColumn.ReadOnly = True
        '
        'CountCaviarOrderDisplayColumn
        '
        Me.CountCaviarOrderDisplayColumn.HeaderText = "Count"
        Me.CountCaviarOrderDisplayColumn.Name = "CountCaviarOrderDisplayColumn"
        Me.CountCaviarOrderDisplayColumn.ReadOnly = True
        '
        'ProductNameCaviarOrderDisplayColumn
        '
        Me.ProductNameCaviarOrderDisplayColumn.HeaderText = "Product Code"
        Me.ProductNameCaviarOrderDisplayColumn.Name = "ProductNameCaviarOrderDisplayColumn"
        Me.ProductNameCaviarOrderDisplayColumn.ReadOnly = True
        '
        'CaviarInventoryDisplayDataGridView
        '
        Me.CaviarInventoryDisplayDataGridView.AllowUserToAddRows = False
        Me.CaviarInventoryDisplayDataGridView.AllowUserToDeleteRows = False
        Me.CaviarInventoryDisplayDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CaviarInventoryDisplayDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.CaviarInventoryDisplayDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaviarInventoryDisplayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CaviarInventoryDisplayDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductNameCaviarOrderDisplayColumn, Me.CountCaviarOrderDisplayColumn, Me.TotalKgsCaviarOrderDisplayColumn})
        Me.CaviarInventoryDisplayDataGridView.Location = New System.Drawing.Point(0, 19)
        Me.CaviarInventoryDisplayDataGridView.Name = "CaviarInventoryDisplayDataGridView"
        Me.CaviarInventoryDisplayDataGridView.ReadOnly = True
        Me.CaviarInventoryDisplayDataGridView.Size = New System.Drawing.Size(683, 237)
        Me.CaviarInventoryDisplayDataGridView.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CaviarInventoryDisplayDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 262)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quick Summary"
        '
        'EditInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 580)
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.CaviarInventoryJoinCaviarFishBindingNavigator)
        Me.Name = "EditInventory"
        Me.Text = "Edit Inventory"
        CType(Me.CaviarInventoryJoinCaviarFishBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.ResumeLayout(False)
        Me.CaviarInventoryJoinCaviarFishBindingNavigator.PerformLayout()
        CType(Me.CaviarInventoryJoinCaviarFishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.CaviarInventoryJoinCaviarFishDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarInventoryDisplayDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents CaviarInventoryJoinCaviarFishBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarInventoryJoinCaviarFishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarInventoryJoinCaviarFishTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CaviarInventoryJoinCaviarFishBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CaviarInventoryJoinCaviarFishBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents CaviarStatusSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarStatusSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
    Friend WithEvents GradeSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
    Friend WithEvents FilterButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExportExcelButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExportInventoryDisplayedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportQuickSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaviarInventoryJoinCaviarFishDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents PKBarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKProductID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ProductUnitWeightColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents InventoryStatus As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FKInvoiceID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceSoldAt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PackingBoxNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateStatusChanged As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreviousStatus As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FishTag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HarvestDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Species As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eggsize As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Taste As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Firmness As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EggColor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grade As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents GrowoutTank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurgeTank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FishYC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LiveWt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuttedWt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OvaryTot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OvaryWaste As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EggWt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cycled As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Completed As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Caviar_InventoryTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents PrintButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CaviarInventoryDisplayDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents ProductNameCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalKgsCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
