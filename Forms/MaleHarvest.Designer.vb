<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaleHarvest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaleHarvest))
        Me.MaleFishHarvestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.MaleFishHarvestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.MaleFishHarvestBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ExportExcelButton = New System.Windows.Forms.ToolStripButton
        Me.MaleFishHarvestTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.MaleFishHarvestTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.MaleFishHarvestDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.HarvestDateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FishCountColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalLiveWeightColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FromTankColumn = New Microsoft.Samples.Windows.Forms.DataGridViewCustomColumn.MaskedTextBoxColumn
        CType(Me.MaleFishHarvestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaleFishHarvestBindingNavigator.SuspendLayout()
        CType(Me.MaleFishHarvestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaleFishHarvestDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaleFishHarvestBindingNavigator
        '
        Me.MaleFishHarvestBindingNavigator.AddNewItem = Nothing
        Me.MaleFishHarvestBindingNavigator.BindingSource = Me.MaleFishHarvestBindingSource
        Me.MaleFishHarvestBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MaleFishHarvestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MaleFishHarvestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MaleFishHarvestBindingNavigatorSaveItem, Me.ExportExcelButton})
        Me.MaleFishHarvestBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MaleFishHarvestBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MaleFishHarvestBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MaleFishHarvestBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MaleFishHarvestBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MaleFishHarvestBindingNavigator.Name = "MaleFishHarvestBindingNavigator"
        Me.MaleFishHarvestBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MaleFishHarvestBindingNavigator.Size = New System.Drawing.Size(531, 25)
        Me.MaleFishHarvestBindingNavigator.TabIndex = 0
        Me.MaleFishHarvestBindingNavigator.Text = "BindingNavigator1"
        '
        'MaleFishHarvestBindingSource
        '
        Me.MaleFishHarvestBindingSource.DataMember = "MaleFishHarvest"
        Me.MaleFishHarvestBindingSource.DataSource = Me.SturgeonDBDataSet
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'MaleFishHarvestBindingNavigatorSaveItem
        '
        Me.MaleFishHarvestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MaleFishHarvestBindingNavigatorSaveItem.Image = CType(resources.GetObject("MaleFishHarvestBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MaleFishHarvestBindingNavigatorSaveItem.Name = "MaleFishHarvestBindingNavigatorSaveItem"
        Me.MaleFishHarvestBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MaleFishHarvestBindingNavigatorSaveItem.Text = "Save Data"
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
        'MaleFishHarvestTableAdapter
        '
        Me.MaleFishHarvestTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Application_SettingsTableAdapter = Nothing
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
        Me.TableAdapterManager.MaleFishHarvestTableAdapter = Me.MaleFishHarvestTableAdapter
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Nothing
        Me.TableAdapterManager.NonInventoryInvoiceFlatTableTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.RepackLossTableAdapter = Nothing
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeightConversionConstantsTableAdapter = Nothing
        '
        'MaleFishHarvestDataGridView
        '
        Me.MaleFishHarvestDataGridView.AllowUserToAddRows = False
        Me.MaleFishHarvestDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaleFishHarvestDataGridView.AutoGenerateColumns = False
        Me.MaleFishHarvestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaleFishHarvestDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HarvestDateColumn, Me.FishCountColumn, Me.TotalLiveWeightColumn, Me.FromTankColumn})
        Me.MaleFishHarvestDataGridView.DataSource = Me.MaleFishHarvestBindingSource
        Me.MaleFishHarvestDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.MaleFishHarvestDataGridView.MultiSelect = False
        Me.MaleFishHarvestDataGridView.Name = "MaleFishHarvestDataGridView"
        Me.MaleFishHarvestDataGridView.Size = New System.Drawing.Size(507, 530)
        Me.MaleFishHarvestDataGridView.TabIndex = 1
        '
        'HarvestDateColumn
        '
        Me.HarvestDateColumn.DataPropertyName = "HarvestDate"
        Me.HarvestDateColumn.HeaderText = "Harvest Date"
        Me.HarvestDateColumn.Name = "HarvestDateColumn"
        '
        'FishCountColumn
        '
        Me.FishCountColumn.DataPropertyName = "FishCount"
        Me.FishCountColumn.HeaderText = "Fish Count"
        Me.FishCountColumn.Name = "FishCountColumn"
        '
        'TotalLiveWeightColumn
        '
        Me.TotalLiveWeightColumn.DataPropertyName = "TotalLiveWeight"
        Me.TotalLiveWeightColumn.HeaderText = "Total Live Weight"
        Me.TotalLiveWeightColumn.Name = "TotalLiveWeightColumn"
        Me.TotalLiveWeightColumn.Width = 150
        '
        'FromTankColumn
        '
        Me.FromTankColumn.DataPropertyName = "FromTank"
        Me.FromTankColumn.HeaderText = "FromTank"
        Me.FromTankColumn.IncludeLiterals = False
        Me.FromTankColumn.IncludePrompt = False
        Me.FromTankColumn.Mask = Nothing
        Me.FromTankColumn.Name = "FromTankColumn"
        Me.FromTankColumn.PromptChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FromTankColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FromTankColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FromTankColumn.ValidatingType = Nothing
        '
        'MaleHarvest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 570)
        Me.Controls.Add(Me.MaleFishHarvestDataGridView)
        Me.Controls.Add(Me.MaleFishHarvestBindingNavigator)
        Me.Name = "MaleHarvest"
        Me.Text = "New Male Harvest"
        CType(Me.MaleFishHarvestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaleFishHarvestBindingNavigator.ResumeLayout(False)
        Me.MaleFishHarvestBindingNavigator.PerformLayout()
        CType(Me.MaleFishHarvestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaleFishHarvestDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents MaleFishHarvestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaleFishHarvestTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.MaleFishHarvestTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MaleFishHarvestBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MaleFishHarvestBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MaleFishHarvestDataGridView As MyDataGridView
    Friend WithEvents ExportExcelButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents HarvestDateColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FishCountColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalLiveWeightColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FromTankColumn As Microsoft.Samples.Windows.Forms.DataGridViewCustomColumn.MaskedTextBoxColumn
End Class
