<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditInventoryValue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditInventoryValue))
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.CaviarInventoryValueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaviarInventoryValueTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarInventoryValueTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.GradeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
        Me.CaviarInventoryValueBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CaviarInventoryValueBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CaviarInventoryValueMyDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.YearColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKGradeIDColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.GradeSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValuePerKgColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EffectiveYearColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExportExcelButton = New System.Windows.Forms.ToolStripButton
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarInventoryValueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarInventoryValueBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CaviarInventoryValueBindingNavigator.SuspendLayout()
        CType(Me.CaviarInventoryValueMyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CaviarInventoryValueBindingSource
        '
        Me.CaviarInventoryValueBindingSource.DataMember = "CaviarInventoryValue"
        Me.CaviarInventoryValueBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'CaviarInventoryValueTableAdapter
        '
        Me.CaviarInventoryValueTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CaviarInventoryValueTableAdapter = Me.CaviarInventoryValueTableAdapter
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Nothing
        Me.TableAdapterManager.ConcurrencyHandlerTableAdapter = Nothing
        Me.TableAdapterManager.Customer_PricingTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.FemaleFishInventoryTableAdapter = Nothing
        Me.TableAdapterManager.FilterColumnsTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Me.GradeSelectionTableAdapter
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
        'GradeSelectionTableAdapter
        '
        Me.GradeSelectionTableAdapter.ClearBeforeFill = True
        '
        'CaviarInventoryValueBindingNavigator
        '
        Me.CaviarInventoryValueBindingNavigator.AddNewItem = Nothing
        Me.CaviarInventoryValueBindingNavigator.BindingSource = Me.CaviarInventoryValueBindingSource
        Me.CaviarInventoryValueBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CaviarInventoryValueBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CaviarInventoryValueBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CaviarInventoryValueBindingNavigatorSaveItem, Me.ExportExcelButton})
        Me.CaviarInventoryValueBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CaviarInventoryValueBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CaviarInventoryValueBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CaviarInventoryValueBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CaviarInventoryValueBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CaviarInventoryValueBindingNavigator.Name = "CaviarInventoryValueBindingNavigator"
        Me.CaviarInventoryValueBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CaviarInventoryValueBindingNavigator.Size = New System.Drawing.Size(513, 25)
        Me.CaviarInventoryValueBindingNavigator.TabIndex = 0
        Me.CaviarInventoryValueBindingNavigator.Text = "BindingNavigator1"
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
        'CaviarInventoryValueBindingNavigatorSaveItem
        '
        Me.CaviarInventoryValueBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CaviarInventoryValueBindingNavigatorSaveItem.Image = CType(resources.GetObject("CaviarInventoryValueBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CaviarInventoryValueBindingNavigatorSaveItem.Name = "CaviarInventoryValueBindingNavigatorSaveItem"
        Me.CaviarInventoryValueBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CaviarInventoryValueBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CaviarInventoryValueMyDataGridView
        '
        Me.CaviarInventoryValueMyDataGridView.AllowUserToAddRows = False
        Me.CaviarInventoryValueMyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaviarInventoryValueMyDataGridView.AutoGenerateColumns = False
        Me.CaviarInventoryValueMyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CaviarInventoryValueMyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.YearColumn, Me.FKGradeIDColumn, Me.ValuePerKgColumn, Me.EffectiveYearColumn})
        Me.CaviarInventoryValueMyDataGridView.DataSource = Me.CaviarInventoryValueBindingSource
        Me.CaviarInventoryValueMyDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.CaviarInventoryValueMyDataGridView.MultiSelect = False
        Me.CaviarInventoryValueMyDataGridView.Name = "CaviarInventoryValueMyDataGridView"
        Me.CaviarInventoryValueMyDataGridView.Size = New System.Drawing.Size(513, 326)
        Me.CaviarInventoryValueMyDataGridView.TabIndex = 1
        '
        'YearColumn
        '
        Me.YearColumn.HeaderText = "Year"
        Me.YearColumn.Name = "YearColumn"
        '
        'FKGradeIDColumn
        '
        Me.FKGradeIDColumn.DataPropertyName = "FKGradeID"
        Me.FKGradeIDColumn.DataSource = Me.GradeSelectionBindingSource
        Me.FKGradeIDColumn.DisplayMember = "Grade"
        Me.FKGradeIDColumn.HeaderText = "Grade"
        Me.FKGradeIDColumn.Name = "FKGradeIDColumn"
        Me.FKGradeIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FKGradeIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FKGradeIDColumn.ValueMember = "ID"
        '
        'GradeSelectionBindingSource
        '
        Me.GradeSelectionBindingSource.DataMember = "GradeSelection"
        Me.GradeSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'ValuePerKgColumn
        '
        Me.ValuePerKgColumn.DataPropertyName = "ValuePerKg"
        Me.ValuePerKgColumn.HeaderText = "Value Per Kg ($)"
        Me.ValuePerKgColumn.Name = "ValuePerKgColumn"
        Me.ValuePerKgColumn.Width = 120
        '
        'EffectiveYearColumn
        '
        Me.EffectiveYearColumn.DataPropertyName = "EffectiveYear"
        Me.EffectiveYearColumn.HeaderText = "Effective Year"
        Me.EffectiveYearColumn.Name = "EffectiveYearColumn"
        Me.EffectiveYearColumn.Visible = False
        '
        'ExportExcelButton
        '
        Me.ExportExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportExcelButton.Image = CType(resources.GetObject("ExportExcelButton.Image"), System.Drawing.Image)
        Me.ExportExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportExcelButton.Name = "ExportExcelButton"
        Me.ExportExcelButton.Size = New System.Drawing.Size(23, 22)
        Me.ExportExcelButton.Text = "Export Pricing Grid to Excel"
        '
        'EditInventoryValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 356)
        Me.Controls.Add(Me.CaviarInventoryValueMyDataGridView)
        Me.Controls.Add(Me.CaviarInventoryValueBindingNavigator)
        Me.Name = "EditInventoryValue"
        Me.Text = "EditInventoryValue"
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarInventoryValueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarInventoryValueBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CaviarInventoryValueBindingNavigator.ResumeLayout(False)
        Me.CaviarInventoryValueBindingNavigator.PerformLayout()
        CType(Me.CaviarInventoryValueMyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents CaviarInventoryValueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarInventoryValueTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarInventoryValueTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CaviarInventoryValueBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CaviarInventoryValueBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GradeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
    Friend WithEvents CaviarInventoryValueMyDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents GradeSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YearColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKGradeIDColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ValuePerKgColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EffectiveYearColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExportExcelButton As System.Windows.Forms.ToolStripButton
End Class
