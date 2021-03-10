<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditFishInventory
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
        Dim Egg_WtLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditFishInventory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.Caviar_FishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Caviar_FishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.Caviar_InventoryTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
        Me.CaviarStatusSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
        Me.GradeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
        Me.ProductsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
        Me.GradeSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Caviar_InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaviarStatusSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TotEggsTextBox = New System.Windows.Forms.TextBox
        Me.TotKgsFishTextBox = New System.Windows.Forms.TextBox
        Me.ProcessedFishCountTextBox = New System.Windows.Forms.TextBox
        Me.TotalFishCountTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Caviar_FishBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.Caviar_FishBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FilterButton = New System.Windows.Forms.ToolStripButton
        Me.ExportExcelButton = New System.Windows.Forms.ToolStripButton
        Me.PrintButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.PrintAllFishLabelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintSelectedLabelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Caviar_FishDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.TagColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HarvestDateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpeciesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EggsizeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TasteColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirmnessColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EggColorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GradeColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.GrowoutTankColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PurgeTankColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FishYCColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OvaryTotColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OvaryWasteColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EggWtColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LiveWtColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GuttedWtColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaltColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CycledColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.FishNotesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompletedColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PKFishIDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Egg_WtTextBox = New System.Windows.Forms.TextBox
        Me.TinsPackedTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TotalCaviarPackedTextBox = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Caviar_InventoryDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.PKBarcodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKProductIDColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ProductUnitWeightColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.InventoryStatusColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.FKInvoiceIDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceSoldAtColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaviarInventoryNotesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateStatusChanged = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PreviousStatus = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.SplitContainer = New System.Windows.Forms.SplitContainer
        Egg_WtLabel = New System.Windows.Forms.Label
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caviar_InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Caviar_FishBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Caviar_FishBindingNavigator.SuspendLayout()
        CType(Me.Caviar_FishDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Caviar_InventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Egg_WtLabel
        '
        Egg_WtLabel.AutoSize = True
        Egg_WtLabel.Location = New System.Drawing.Point(71, 96)
        Egg_WtLabel.Name = "Egg_WtLabel"
        Egg_WtLabel.Size = New System.Drawing.Size(103, 13)
        Egg_WtLabel.TabIndex = 6
        Egg_WtLabel.Text = "Fish Egg Weight (g):"
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Caviar_FishBindingSource
        '
        Me.Caviar_FishBindingSource.DataMember = "Caviar Fish"
        Me.Caviar_FishBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'Caviar_FishTableAdapter
        '
        Me.Caviar_FishTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Application_SettingsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_FishTableAdapter = Me.Caviar_FishTableAdapter
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Me.Caviar_InventoryTableAdapter
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryValueTableAdapter = Nothing
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
        'GradeSelectionBindingSource
        '
        Me.GradeSelectionBindingSource.DataMember = "GradeSelection"
        Me.GradeSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'Caviar_InventoryBindingSource
        '
        Me.Caviar_InventoryBindingSource.DataMember = "Caviar FishCaviar Inventory"
        Me.Caviar_InventoryBindingSource.DataSource = Me.Caviar_FishBindingSource
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Caviar_FishBindingNavigator)
        Me.GroupBox1.Controls.Add(Me.Caviar_FishDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 484)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caviar Fish Data"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TotEggsTextBox)
        Me.GroupBox3.Controls.Add(Me.TotKgsFishTextBox)
        Me.GroupBox3.Controls.Add(Me.ProcessedFishCountTextBox)
        Me.GroupBox3.Controls.Add(Me.TotalFishCountTextBox)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 330)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(376, 148)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Quick Summary"
        '
        'TotEggsTextBox
        '
        Me.TotEggsTextBox.Location = New System.Drawing.Point(190, 89)
        Me.TotEggsTextBox.Name = "TotEggsTextBox"
        Me.TotEggsTextBox.ReadOnly = True
        Me.TotEggsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotEggsTextBox.TabIndex = 7
        '
        'TotKgsFishTextBox
        '
        Me.TotKgsFishTextBox.Location = New System.Drawing.Point(190, 63)
        Me.TotKgsFishTextBox.Name = "TotKgsFishTextBox"
        Me.TotKgsFishTextBox.ReadOnly = True
        Me.TotKgsFishTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotKgsFishTextBox.TabIndex = 6
        '
        'ProcessedFishCountTextBox
        '
        Me.ProcessedFishCountTextBox.Location = New System.Drawing.Point(190, 37)
        Me.ProcessedFishCountTextBox.Name = "ProcessedFishCountTextBox"
        Me.ProcessedFishCountTextBox.ReadOnly = True
        Me.ProcessedFishCountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProcessedFishCountTextBox.TabIndex = 5
        '
        'TotalFishCountTextBox
        '
        Me.TotalFishCountTextBox.Location = New System.Drawing.Point(190, 13)
        Me.TotalFishCountTextBox.Name = "TotalFishCountTextBox"
        Me.TotalFishCountTextBox.ReadOnly = True
        Me.TotalFishCountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalFishCountTextBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Grams of Eggs Processed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Kgs of Live Fish Processed:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Fish Processed:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Fish Entered:"
        '
        'Caviar_FishBindingNavigator
        '
        Me.Caviar_FishBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Caviar_FishBindingNavigator.BindingSource = Me.Caviar_FishBindingSource
        Me.Caviar_FishBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Caviar_FishBindingNavigator.DeleteItem = Nothing
        Me.Caviar_FishBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Caviar_FishBindingNavigatorSaveItem, Me.FilterButton, Me.ExportExcelButton, Me.PrintButton})
        Me.Caviar_FishBindingNavigator.Location = New System.Drawing.Point(3, 16)
        Me.Caviar_FishBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Caviar_FishBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Caviar_FishBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Caviar_FishBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Caviar_FishBindingNavigator.Name = "Caviar_FishBindingNavigator"
        Me.Caviar_FishBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Caviar_FishBindingNavigator.Size = New System.Drawing.Size(385, 25)
        Me.Caviar_FishBindingNavigator.TabIndex = 2
        Me.Caviar_FishBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Caviar_FishBindingNavigatorSaveItem
        '
        Me.Caviar_FishBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Caviar_FishBindingNavigatorSaveItem.Image = CType(resources.GetObject("Caviar_FishBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Caviar_FishBindingNavigatorSaveItem.Name = "Caviar_FishBindingNavigatorSaveItem"
        Me.Caviar_FishBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Caviar_FishBindingNavigatorSaveItem.Text = "Save Data"
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
        'PrintButton
        '
        Me.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAllFishLabelsToolStripMenuItem, Me.PrintSelectedLabelToolStripMenuItem})
        Me.PrintButton.Image = CType(resources.GetObject("PrintButton.Image"), System.Drawing.Image)
        Me.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(29, 22)
        Me.PrintButton.Text = "Print Labels"
        '
        'PrintAllFishLabelsToolStripMenuItem
        '
        Me.PrintAllFishLabelsToolStripMenuItem.Name = "PrintAllFishLabelsToolStripMenuItem"
        Me.PrintAllFishLabelsToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PrintAllFishLabelsToolStripMenuItem.Text = "Print All Fish Labels"
        '
        'PrintSelectedLabelToolStripMenuItem
        '
        Me.PrintSelectedLabelToolStripMenuItem.Name = "PrintSelectedLabelToolStripMenuItem"
        Me.PrintSelectedLabelToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PrintSelectedLabelToolStripMenuItem.Text = "Print Selected Label"
        '
        'Caviar_FishDataGridView
        '
        Me.Caviar_FishDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Caviar_FishDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Caviar_FishDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Caviar_FishDataGridView.AutoGenerateColumns = False
        Me.Caviar_FishDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Caviar_FishDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TagColumn, Me.HarvestDateColumn, Me.SpeciesColumn, Me.EggsizeColumn, Me.TasteColumn, Me.FirmnessColumn, Me.EggColorColumn, Me.GradeColumn, Me.GrowoutTankColumn, Me.PurgeTankColumn, Me.FishYCColumn, Me.OvaryTotColumn, Me.OvaryWasteColumn, Me.EggWtColumn, Me.LiveWtColumn, Me.GuttedWtColumn, Me.SaltColumn, Me.CycledColumn, Me.FishNotesColumn, Me.CompletedColumn, Me.PKFishIDColumn})
        Me.Caviar_FishDataGridView.DataSource = Me.Caviar_FishBindingSource
        Me.Caviar_FishDataGridView.Location = New System.Drawing.Point(6, 44)
        Me.Caviar_FishDataGridView.MultiSelect = False
        Me.Caviar_FishDataGridView.Name = "Caviar_FishDataGridView"
        Me.Caviar_FishDataGridView.Size = New System.Drawing.Size(379, 280)
        Me.Caviar_FishDataGridView.TabIndex = 1
        '
        'TagColumn
        '
        Me.TagColumn.DataPropertyName = "Tag"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TagColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TagColumn.Frozen = True
        Me.TagColumn.HeaderText = "Tag"
        Me.TagColumn.Name = "TagColumn"
        '
        'HarvestDateColumn
        '
        Me.HarvestDateColumn.DataPropertyName = "Harvest Date"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HarvestDateColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.HarvestDateColumn.HeaderText = "Harvest Date"
        Me.HarvestDateColumn.Name = "HarvestDateColumn"
        '
        'SpeciesColumn
        '
        Me.SpeciesColumn.DataPropertyName = "Species"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeciesColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SpeciesColumn.HeaderText = "Species"
        Me.SpeciesColumn.Name = "SpeciesColumn"
        '
        'EggsizeColumn
        '
        Me.EggsizeColumn.DataPropertyName = "Eggsize"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N1"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.EggsizeColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.EggsizeColumn.HeaderText = "Eggsize"
        Me.EggsizeColumn.Name = "EggsizeColumn"
        '
        'TasteColumn
        '
        Me.TasteColumn.DataPropertyName = "Taste"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TasteColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.TasteColumn.HeaderText = "Taste"
        Me.TasteColumn.Name = "TasteColumn"
        '
        'FirmnessColumn
        '
        Me.FirmnessColumn.DataPropertyName = "Firmness"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirmnessColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.FirmnessColumn.HeaderText = "Firmness"
        Me.FirmnessColumn.Name = "FirmnessColumn"
        '
        'EggColorColumn
        '
        Me.EggColorColumn.DataPropertyName = "Egg Color"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EggColorColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.EggColorColumn.HeaderText = "Egg Color"
        Me.EggColorColumn.Name = "EggColorColumn"
        '
        'GradeColumn
        '
        Me.GradeColumn.DataPropertyName = "Grade"
        Me.GradeColumn.DataSource = Me.GradeSelectionBindingSource
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.GradeColumn.DisplayMember = "Grade"
        Me.GradeColumn.HeaderText = "Grade"
        Me.GradeColumn.Name = "GradeColumn"
        Me.GradeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GradeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.GradeColumn.ValueMember = "ID"
        '
        'GrowoutTankColumn
        '
        Me.GrowoutTankColumn.DataPropertyName = "Growout Tank"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrowoutTankColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.GrowoutTankColumn.HeaderText = "Growout Tank"
        Me.GrowoutTankColumn.Name = "GrowoutTankColumn"
        '
        'PurgeTankColumn
        '
        Me.PurgeTankColumn.DataPropertyName = "Purge Tank"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurgeTankColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.PurgeTankColumn.HeaderText = "Purge Tank"
        Me.PurgeTankColumn.Name = "PurgeTankColumn"
        '
        'FishYCColumn
        '
        Me.FishYCColumn.DataPropertyName = "Fish YC"
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishYCColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.FishYCColumn.HeaderText = "Fish YC"
        Me.FishYCColumn.Name = "FishYCColumn"
        '
        'OvaryTotColumn
        '
        Me.OvaryTotColumn.DataPropertyName = "Ovary Tot"
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OvaryTotColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.OvaryTotColumn.HeaderText = "Ovary Tot"
        Me.OvaryTotColumn.Name = "OvaryTotColumn"
        '
        'OvaryWasteColumn
        '
        Me.OvaryWasteColumn.DataPropertyName = "Ovary Waste"
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OvaryWasteColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.OvaryWasteColumn.HeaderText = "Ovary Waste"
        Me.OvaryWasteColumn.Name = "OvaryWasteColumn"
        '
        'EggWtColumn
        '
        Me.EggWtColumn.DataPropertyName = "Egg Wt"
        Me.EggWtColumn.HeaderText = "Egg Wt"
        Me.EggWtColumn.Name = "EggWtColumn"
        '
        'LiveWtColumn
        '
        Me.LiveWtColumn.DataPropertyName = "Live Wt"
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LiveWtColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.LiveWtColumn.HeaderText = "Live Wt"
        Me.LiveWtColumn.Name = "LiveWtColumn"
        '
        'GuttedWtColumn
        '
        Me.GuttedWtColumn.DataPropertyName = "Gutted Wt"
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuttedWtColumn.DefaultCellStyle = DataGridViewCellStyle16
        Me.GuttedWtColumn.HeaderText = "Gutted Wt"
        Me.GuttedWtColumn.Name = "GuttedWtColumn"
        '
        'SaltColumn
        '
        Me.SaltColumn.DataPropertyName = "Salt"
        Me.SaltColumn.HeaderText = "Salt"
        Me.SaltColumn.Name = "SaltColumn"
        '
        'CycledColumn
        '
        Me.CycledColumn.DataPropertyName = "Cycled"
        Me.CycledColumn.HeaderText = "Cycled"
        Me.CycledColumn.Name = "CycledColumn"
        '
        'FishNotesColumn
        '
        Me.FishNotesColumn.DataPropertyName = "Notes"
        Me.FishNotesColumn.HeaderText = "Notes"
        Me.FishNotesColumn.Name = "FishNotesColumn"
        '
        'CompletedColumn
        '
        Me.CompletedColumn.DataPropertyName = "Completed"
        Me.CompletedColumn.HeaderText = "Completed"
        Me.CompletedColumn.Name = "CompletedColumn"
        '
        'PKFishIDColumn
        '
        Me.PKFishIDColumn.DataPropertyName = "PKFishID"
        Me.PKFishIDColumn.HeaderText = "FishID"
        Me.PKFishIDColumn.Name = "PKFishIDColumn"
        Me.PKFishIDColumn.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Caviar_InventoryDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 481)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Caviar Tins for Selected Fish"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Egg_WtLabel)
        Me.GroupBox4.Controls.Add(Me.Egg_WtTextBox)
        Me.GroupBox4.Controls.Add(Me.TinsPackedTextBox)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TotalCaviarPackedTextBox)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 327)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(539, 148)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Quick Summary"
        '
        'Egg_WtTextBox
        '
        Me.Egg_WtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Egg Wt", True))
        Me.Egg_WtTextBox.Location = New System.Drawing.Point(193, 92)
        Me.Egg_WtTextBox.Name = "Egg_WtTextBox"
        Me.Egg_WtTextBox.ReadOnly = True
        Me.Egg_WtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Egg_WtTextBox.TabIndex = 7
        '
        'TinsPackedTextBox
        '
        Me.TinsPackedTextBox.Location = New System.Drawing.Point(193, 37)
        Me.TinsPackedTextBox.Name = "TinsPackedTextBox"
        Me.TinsPackedTextBox.ReadOnly = True
        Me.TinsPackedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TinsPackedTextBox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total tins of Caviar Packed:"
        '
        'TotalCaviarPackedTextBox
        '
        Me.TotalCaviarPackedTextBox.Location = New System.Drawing.Point(193, 63)
        Me.TotalCaviarPackedTextBox.Name = "TotalCaviarPackedTextBox"
        Me.TotalCaviarPackedTextBox.ReadOnly = True
        Me.TotalCaviarPackedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalCaviarPackedTextBox.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Grams of Caviar Packed:"
        '
        'Caviar_InventoryDataGridView
        '
        Me.Caviar_InventoryDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Caviar_InventoryDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.Caviar_InventoryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Caviar_InventoryDataGridView.AutoGenerateColumns = False
        Me.Caviar_InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Caviar_InventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PKBarcodeColumn, Me.FKProductIDColumn, Me.ProductUnitWeightColumn, Me.InventoryStatusColumn, Me.FKInvoiceIDColumn, Me.PriceSoldAtColumn, Me.CaviarInventoryNotesColumn, Me.DateStatusChanged, Me.PreviousStatus})
        Me.Caviar_InventoryDataGridView.DataSource = Me.Caviar_InventoryBindingSource
        Me.Caviar_InventoryDataGridView.Location = New System.Drawing.Point(9, 16)
        Me.Caviar_InventoryDataGridView.MultiSelect = False
        Me.Caviar_InventoryDataGridView.Name = "Caviar_InventoryDataGridView"
        Me.Caviar_InventoryDataGridView.Size = New System.Drawing.Size(539, 305)
        Me.Caviar_InventoryDataGridView.TabIndex = 2
        '
        'PKBarcodeColumn
        '
        Me.PKBarcodeColumn.DataPropertyName = "PKBarcode"
        Me.PKBarcodeColumn.HeaderText = "Barcode"
        Me.PKBarcodeColumn.Name = "PKBarcodeColumn"
        '
        'FKProductIDColumn
        '
        Me.FKProductIDColumn.DataPropertyName = "FKProductID"
        Me.FKProductIDColumn.DataSource = Me.ProductsBindingSource
        Me.FKProductIDColumn.DisplayMember = "Product Name"
        Me.FKProductIDColumn.HeaderText = "Product"
        Me.FKProductIDColumn.Name = "FKProductIDColumn"
        Me.FKProductIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FKProductIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FKProductIDColumn.ValueMember = "PKProductID"
        '
        'ProductUnitWeightColumn
        '
        Me.ProductUnitWeightColumn.DataPropertyName = "FKProductID"
        Me.ProductUnitWeightColumn.DataSource = Me.ProductsBindingSource
        Me.ProductUnitWeightColumn.DisplayMember = "UnitWeightgms"
        Me.ProductUnitWeightColumn.HeaderText = "Product Unit Weight (g)"
        Me.ProductUnitWeightColumn.Name = "ProductUnitWeightColumn"
        Me.ProductUnitWeightColumn.ReadOnly = True
        Me.ProductUnitWeightColumn.ValueMember = "PKProductID"
        '
        'InventoryStatusColumn
        '
        Me.InventoryStatusColumn.DataPropertyName = "InventoryStatus"
        Me.InventoryStatusColumn.DataSource = Me.CaviarStatusSelectionBindingSource
        Me.InventoryStatusColumn.DisplayMember = "Description"
        Me.InventoryStatusColumn.HeaderText = "Inventory Status"
        Me.InventoryStatusColumn.Name = "InventoryStatusColumn"
        Me.InventoryStatusColumn.ValueMember = "PKStatusID"
        '
        'FKInvoiceIDColumn
        '
        Me.FKInvoiceIDColumn.DataPropertyName = "FKInvoiceID"
        Me.FKInvoiceIDColumn.HeaderText = "InvoiceID"
        Me.FKInvoiceIDColumn.Name = "FKInvoiceIDColumn"
        '
        'PriceSoldAtColumn
        '
        Me.PriceSoldAtColumn.DataPropertyName = "PriceSoldAt"
        Me.PriceSoldAtColumn.HeaderText = "PriceSoldAt"
        Me.PriceSoldAtColumn.Name = "PriceSoldAtColumn"
        '
        'CaviarInventoryNotesColumn
        '
        Me.CaviarInventoryNotesColumn.DataPropertyName = "Notes"
        Me.CaviarInventoryNotesColumn.HeaderText = "Notes"
        Me.CaviarInventoryNotesColumn.Name = "CaviarInventoryNotesColumn"
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
        'SplitContainer
        '
        Me.SplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer.Size = New System.Drawing.Size(969, 492)
        Me.SplitContainer.SplitterDistance = 401
        Me.SplitContainer.TabIndex = 5
        '
        'EditFishInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 495)
        Me.Controls.Add(Me.SplitContainer)
        Me.Name = "EditFishInventory"
        Me.Text = "Edit Inventory and Fish"
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caviar_InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Caviar_FishBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Caviar_FishBindingNavigator.ResumeLayout(False)
        Me.Caviar_FishBindingNavigator.PerformLayout()
        CType(Me.Caviar_FishDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Caviar_InventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents Caviar_FishBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caviar_FishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Caviar_InventoryTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
    Friend WithEvents Caviar_InventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradeSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents CaviarStatusSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarStatusSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Caviar_FishBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Caviar_FishBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FilterButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ExportExcelButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProcessedFishCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalFishCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotEggsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotKgsFishTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalCaviarPackedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TinsPackedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Egg_WtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TagColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HarvestDateColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpeciesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EggsizeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TasteColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirmnessColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EggColorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradeColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents GrowoutTankColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurgeTankColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FishYCColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OvaryTotColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OvaryWasteColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EggWtColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LiveWtColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuttedWtColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaltColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CycledColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FishNotesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompletedColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PKFishIDColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PKBarcodeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKProductIDColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ProductUnitWeightColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents InventoryStatusColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FKInvoiceIDColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceSoldAtColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaviarInventoryNotesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateStatusChanged As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreviousStatus As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Caviar_FishDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents Caviar_InventoryDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents PrintButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PrintAllFishLabelsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSelectedLabelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
