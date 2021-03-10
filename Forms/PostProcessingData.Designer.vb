<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostProcessingData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PostProcessingData))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.Caviar_FishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Caviar_FishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
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
        Me.Caviar_FishDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.TagColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HarvestDateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrowoutTankColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PurgeTankColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FishYCColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LiveWtColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GuttedWtColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FishNotesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Caviar_FishBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Caviar_FishBindingNavigator.SuspendLayout()
        CType(Me.Caviar_FishDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Customer_PricingTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.FilterColumnsTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTypeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Caviar_FishBindingNavigator)
        Me.GroupBox1.Controls.Add(Me.Caviar_FishDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1102, 498)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caviar Fish Data"
        '
        'Caviar_FishBindingNavigator
        '
        Me.Caviar_FishBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Caviar_FishBindingNavigator.BindingSource = Me.Caviar_FishBindingSource
        Me.Caviar_FishBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Caviar_FishBindingNavigator.DeleteItem = Nothing
        Me.Caviar_FishBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Caviar_FishBindingNavigatorSaveItem, Me.FilterButton, Me.ExportExcelButton})
        Me.Caviar_FishBindingNavigator.Location = New System.Drawing.Point(3, 16)
        Me.Caviar_FishBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Caviar_FishBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Caviar_FishBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Caviar_FishBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Caviar_FishBindingNavigator.Name = "Caviar_FishBindingNavigator"
        Me.Caviar_FishBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Caviar_FishBindingNavigator.Size = New System.Drawing.Size(1096, 25)
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
        'Caviar_FishDataGridView
        '
        Me.Caviar_FishDataGridView.AllowUserToAddRows = False
        Me.Caviar_FishDataGridView.AllowUserToDeleteRows = False
        Me.Caviar_FishDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Caviar_FishDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Caviar_FishDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Caviar_FishDataGridView.AutoGenerateColumns = False
        Me.Caviar_FishDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Caviar_FishDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TagColumn, Me.HarvestDateColumn, Me.GrowoutTankColumn, Me.PurgeTankColumn, Me.FishYCColumn, Me.LiveWtColumn, Me.GuttedWtColumn, Me.FishNotesColumn})
        Me.Caviar_FishDataGridView.DataSource = Me.Caviar_FishBindingSource
        Me.Caviar_FishDataGridView.Location = New System.Drawing.Point(6, 44)
        Me.Caviar_FishDataGridView.MultiSelect = False
        Me.Caviar_FishDataGridView.Name = "Caviar_FishDataGridView"
        Me.Caviar_FishDataGridView.Size = New System.Drawing.Size(1090, 448)
        Me.Caviar_FishDataGridView.TabIndex = 1
        '
        'TagColumn
        '
        Me.TagColumn.DataPropertyName = "Tag"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TagColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TagColumn.HeaderText = "Tag"
        Me.TagColumn.Name = "TagColumn"
        Me.TagColumn.ReadOnly = True
        Me.TagColumn.Width = 130
        '
        'HarvestDateColumn
        '
        Me.HarvestDateColumn.DataPropertyName = "Harvest Date"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HarvestDateColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.HarvestDateColumn.HeaderText = "Harvest Date"
        Me.HarvestDateColumn.Name = "HarvestDateColumn"
        Me.HarvestDateColumn.ReadOnly = True
        Me.HarvestDateColumn.Width = 130
        '
        'GrowoutTankColumn
        '
        Me.GrowoutTankColumn.DataPropertyName = "Growout Tank"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrowoutTankColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.GrowoutTankColumn.HeaderText = "Growout Tank"
        Me.GrowoutTankColumn.Name = "GrowoutTankColumn"
        Me.GrowoutTankColumn.Width = 130
        '
        'PurgeTankColumn
        '
        Me.PurgeTankColumn.DataPropertyName = "Purge Tank"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurgeTankColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PurgeTankColumn.HeaderText = "Purge Tank"
        Me.PurgeTankColumn.Name = "PurgeTankColumn"
        Me.PurgeTankColumn.Width = 130
        '
        'FishYCColumn
        '
        Me.FishYCColumn.DataPropertyName = "Fish YC"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishYCColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.FishYCColumn.HeaderText = "Fish Year Class"
        Me.FishYCColumn.Name = "FishYCColumn"
        Me.FishYCColumn.Width = 130
        '
        'LiveWtColumn
        '
        Me.LiveWtColumn.DataPropertyName = "Live Wt"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LiveWtColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.LiveWtColumn.HeaderText = "Live Weight"
        Me.LiveWtColumn.Name = "LiveWtColumn"
        Me.LiveWtColumn.Width = 130
        '
        'GuttedWtColumn
        '
        Me.GuttedWtColumn.DataPropertyName = "Gutted Wt"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuttedWtColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.GuttedWtColumn.HeaderText = "Gutted Weight"
        Me.GuttedWtColumn.Name = "GuttedWtColumn"
        Me.GuttedWtColumn.Width = 130
        '
        'FishNotesColumn
        '
        Me.FishNotesColumn.DataPropertyName = "Notes"
        Me.FishNotesColumn.HeaderText = "Notes"
        Me.FishNotesColumn.Name = "FishNotesColumn"
        Me.FishNotesColumn.Width = 130
        '
        'PostProcessingData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 495)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PostProcessingData"
        Me.Text = "Post Processing Data Entry Form"
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Caviar_FishBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Caviar_FishBindingNavigator.ResumeLayout(False)
        Me.Caviar_FishBindingNavigator.PerformLayout()
        CType(Me.Caviar_FishDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents Caviar_FishBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caviar_FishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents ExportExcelButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Caviar_FishDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents TagColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HarvestDateColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrowoutTankColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurgeTankColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FishYCColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LiveWtColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuttedWtColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FishNotesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
