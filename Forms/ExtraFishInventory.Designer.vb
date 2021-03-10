<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExtraFishInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExtraFishInventory))
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.FemaleFishInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FemaleFishInventoryTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.FemaleFishInventoryTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.FemaleFishInventoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FemaleFishInventoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ExportExcelButton = New System.Windows.Forms.ToolStripButton
        Me.FemaleFishInventoryMyDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.InventoryDateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InventoryGuttedWeightColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FemaleFishInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FemaleFishInventoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FemaleFishInventoryBindingNavigator.SuspendLayout()
        CType(Me.FemaleFishInventoryMyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FemaleFishInventoryBindingSource
        '
        Me.FemaleFishInventoryBindingSource.DataMember = "FemaleFishInventory"
        Me.FemaleFishInventoryBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'FemaleFishInventoryTableAdapter
        '
        Me.FemaleFishInventoryTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Customer_PricingTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.FemaleFishInventoryTableAdapter = Me.FemaleFishInventoryTableAdapter
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
        'FemaleFishInventoryBindingNavigator
        '
        Me.FemaleFishInventoryBindingNavigator.AddNewItem = Nothing
        Me.FemaleFishInventoryBindingNavigator.BindingSource = Me.FemaleFishInventoryBindingSource
        Me.FemaleFishInventoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FemaleFishInventoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FemaleFishInventoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FemaleFishInventoryBindingNavigatorSaveItem, Me.ExportExcelButton})
        Me.FemaleFishInventoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FemaleFishInventoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FemaleFishInventoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FemaleFishInventoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FemaleFishInventoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FemaleFishInventoryBindingNavigator.Name = "FemaleFishInventoryBindingNavigator"
        Me.FemaleFishInventoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FemaleFishInventoryBindingNavigator.Size = New System.Drawing.Size(397, 25)
        Me.FemaleFishInventoryBindingNavigator.TabIndex = 0
        Me.FemaleFishInventoryBindingNavigator.Text = "BindingNavigator1"
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
        'FemaleFishInventoryBindingNavigatorSaveItem
        '
        Me.FemaleFishInventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FemaleFishInventoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("FemaleFishInventoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FemaleFishInventoryBindingNavigatorSaveItem.Name = "FemaleFishInventoryBindingNavigatorSaveItem"
        Me.FemaleFishInventoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FemaleFishInventoryBindingNavigatorSaveItem.Text = "Save Data"
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
        'FemaleFishInventoryMyDataGridView
        '
        Me.FemaleFishInventoryMyDataGridView.AllowUserToAddRows = False
        Me.FemaleFishInventoryMyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FemaleFishInventoryMyDataGridView.AutoGenerateColumns = False
        Me.FemaleFishInventoryMyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FemaleFishInventoryMyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InventoryDateColumn, Me.InventoryGuttedWeightColumn})
        Me.FemaleFishInventoryMyDataGridView.DataSource = Me.FemaleFishInventoryBindingSource
        Me.FemaleFishInventoryMyDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.FemaleFishInventoryMyDataGridView.MultiSelect = False
        Me.FemaleFishInventoryMyDataGridView.Name = "FemaleFishInventoryMyDataGridView"
        Me.FemaleFishInventoryMyDataGridView.Size = New System.Drawing.Size(373, 270)
        Me.FemaleFishInventoryMyDataGridView.TabIndex = 1
        '
        'InventoryDateColumn
        '
        Me.InventoryDateColumn.DataPropertyName = "InventoryDate"
        Me.InventoryDateColumn.HeaderText = "Inventory Date"
        Me.InventoryDateColumn.Name = "InventoryDateColumn"
        '
        'InventoryGuttedWeightColumn
        '
        Me.InventoryGuttedWeightColumn.DataPropertyName = "InventoryGuttedWeight"
        Me.InventoryGuttedWeightColumn.HeaderText = "Inventory Gutted Weight"
        Me.InventoryGuttedWeightColumn.Name = "InventoryGuttedWeightColumn"
        Me.InventoryGuttedWeightColumn.Width = 150
        '
        'FemaleInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 310)
        Me.Controls.Add(Me.FemaleFishInventoryMyDataGridView)
        Me.Controls.Add(Me.FemaleFishInventoryBindingNavigator)
        Me.Name = "FemaleInventory"
        Me.Text = "New Female Inventory"
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FemaleFishInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FemaleFishInventoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FemaleFishInventoryBindingNavigator.ResumeLayout(False)
        Me.FemaleFishInventoryBindingNavigator.PerformLayout()
        CType(Me.FemaleFishInventoryMyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents FemaleFishInventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FemaleFishInventoryTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.FemaleFishInventoryTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FemaleFishInventoryBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FemaleFishInventoryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FemaleFishInventoryMyDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents InventoryDateColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryGuttedWeightColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExportExcelButton As System.Windows.Forms.ToolStripButton
End Class
