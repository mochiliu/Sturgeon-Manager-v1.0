<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Dim PKProductIDLabel As System.Windows.Forms.Label
        Dim GradeLabel As System.Windows.Forms.Label
        Dim Product_NameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim UnitWeightgmsLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim ProductCategoryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product))
        Dim PopularityScoreLabel As System.Windows.Forms.Label
        Me.ProductsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ProductsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FilterButton = New System.Windows.Forms.ToolStripButton
        Me.ProductReportButton = New System.Windows.Forms.ToolStripButton
        Me.ProductsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.GradeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
        Me.ProductCategorySelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductCategorySelectionTableAdapter
        Me.PKProductIDTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.GradeComboBox = New System.Windows.Forms.ComboBox
        Me.GradeSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_NameTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.UnitWeightgmsTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.PriceTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.ProductCategoryComboBox = New System.Windows.Forms.ComboBox
        Me.ProductCategorySelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PopularityScoreTextBox = New System.Windows.Forms.TextBox
        PKProductIDLabel = New System.Windows.Forms.Label
        GradeLabel = New System.Windows.Forms.Label
        Product_NameLabel = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        UnitWeightgmsLabel = New System.Windows.Forms.Label
        PriceLabel = New System.Windows.Forms.Label
        ProductCategoryLabel = New System.Windows.Forms.Label
        PopularityScoreLabel = New System.Windows.Forms.Label
        CType(Me.ProductsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductsBindingNavigator.SuspendLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCategorySelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PKProductIDLabel
        '
        PKProductIDLabel.AutoSize = True
        PKProductIDLabel.Location = New System.Drawing.Point(27, 38)
        PKProductIDLabel.Name = "PKProductIDLabel"
        PKProductIDLabel.Size = New System.Drawing.Size(75, 13)
        PKProductIDLabel.TabIndex = 1
        PKProductIDLabel.Text = "PKProduct ID:"
        PKProductIDLabel.Visible = False
        '
        'GradeLabel
        '
        GradeLabel.AutoSize = True
        GradeLabel.Location = New System.Drawing.Point(27, 116)
        GradeLabel.Name = "GradeLabel"
        GradeLabel.Size = New System.Drawing.Size(39, 13)
        GradeLabel.TabIndex = 7
        GradeLabel.Text = "Grade:"
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Location = New System.Drawing.Point(27, 64)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(75, 13)
        Product_NameLabel.TabIndex = 8
        Product_NameLabel.Text = "Product Code:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(27, 231)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 9
        DescriptionLabel.Text = "Description:"
        '
        'UnitWeightgmsLabel
        '
        UnitWeightgmsLabel.AutoSize = True
        UnitWeightgmsLabel.Location = New System.Drawing.Point(27, 143)
        UnitWeightgmsLabel.Name = "UnitWeightgmsLabel"
        UnitWeightgmsLabel.Size = New System.Drawing.Size(81, 13)
        UnitWeightgmsLabel.TabIndex = 10
        UnitWeightgmsLabel.Text = "Unit Weight (g):"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(27, 169)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(71, 13)
        PriceLabel.TabIndex = 11
        PriceLabel.Text = "Default Price:"
        '
        'ProductCategoryLabel
        '
        ProductCategoryLabel.AutoSize = True
        ProductCategoryLabel.Location = New System.Drawing.Point(27, 90)
        ProductCategoryLabel.Name = "ProductCategoryLabel"
        ProductCategoryLabel.Size = New System.Drawing.Size(92, 13)
        ProductCategoryLabel.TabIndex = 13
        ProductCategoryLabel.Text = "Product Category:"
        '
        'ProductsBindingNavigator
        '
        Me.ProductsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductsBindingNavigator.BindingSource = Me.ProductsBindingSource
        Me.ProductsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductsBindingNavigatorSaveItem, Me.FilterButton, Me.ProductReportButton})
        Me.ProductsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductsBindingNavigator.Name = "ProductsBindingNavigator"
        Me.ProductsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductsBindingNavigator.Size = New System.Drawing.Size(514, 25)
        Me.ProductsBindingNavigator.TabIndex = 0
        Me.ProductsBindingNavigator.Text = "BindingNavigator1"
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
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.SturgeonDBDataSet
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
        Me.BindingNavigatorPositionItem.ReadOnly = True
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
        'ProductsBindingNavigatorSaveItem
        '
        Me.ProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductsBindingNavigatorSaveItem.Name = "ProductsBindingNavigatorSaveItem"
        Me.ProductsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductsBindingNavigatorSaveItem.Text = "Save Data"
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
        'ProductReportButton
        '
        Me.ProductReportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductReportButton.Image = CType(resources.GetObject("ProductReportButton.Image"), System.Drawing.Image)
        Me.ProductReportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ProductReportButton.Name = "ProductReportButton"
        Me.ProductReportButton.Size = New System.Drawing.Size(23, 22)
        Me.ProductReportButton.Text = "Product Listing Crystal Report"
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Application_SettingsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_FishTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Customer_PricingTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.FilterColumnsTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Me.GradeSelectionTableAdapter
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTypeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Me.ProductCategorySelectionTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GradeSelectionTableAdapter
        '
        Me.GradeSelectionTableAdapter.ClearBeforeFill = True
        '
        'ProductCategorySelectionTableAdapter
        '
        Me.ProductCategorySelectionTableAdapter.ClearBeforeFill = True
        '
        'PKProductIDTextBox
        '
        Me.PKProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "PKProductID", True))
        Me.PKProductIDTextBox.Enabled = False
        Me.PKProductIDTextBox.Location = New System.Drawing.Point(125, 35)
        Me.PKProductIDTextBox.Name = "PKProductIDTextBox"
        Me.PKProductIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.PKProductIDTextBox.TabIndex = 0
        Me.PKProductIDTextBox.Visible = False
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductsBindingSource, "Grade", True))
        Me.GradeComboBox.DataSource = Me.GradeSelectionBindingSource
        Me.GradeComboBox.DisplayMember = "Grade"
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(125, 113)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(362, 21)
        Me.GradeComboBox.TabIndex = 3
        Me.GradeComboBox.ValueMember = "ID"
        '
        'GradeSelectionBindingSource
        '
        Me.GradeSelectionBindingSource.DataMember = "GradeSelection"
        Me.GradeSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'Product_NameTextBox
        '
        Me.Product_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Product Name", True))
        Me.Product_NameTextBox.Location = New System.Drawing.Point(125, 61)
        Me.Product_NameTextBox.Name = "Product_NameTextBox"
        Me.Product_NameTextBox.Size = New System.Drawing.Size(362, 20)
        Me.Product_NameTextBox.TabIndex = 1
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(125, 228)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(362, 122)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'UnitWeightgmsTextBox
        '
        Me.UnitWeightgmsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitWeightgms", True))
        Me.UnitWeightgmsTextBox.Location = New System.Drawing.Point(125, 140)
        Me.UnitWeightgmsTextBox.Name = "UnitWeightgmsTextBox"
        Me.UnitWeightgmsTextBox.Size = New System.Drawing.Size(362, 20)
        Me.UnitWeightgmsTextBox.TabIndex = 4
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(125, 166)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(362, 20)
        Me.PriceTextBox.TabIndex = 5
        '
        'ProductCategoryComboBox
        '
        Me.ProductCategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductsBindingSource, "ProductCategory", True))
        Me.ProductCategoryComboBox.DataSource = Me.ProductCategorySelectionBindingSource
        Me.ProductCategoryComboBox.DisplayMember = "Description"
        Me.ProductCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProductCategoryComboBox.FormattingEnabled = True
        Me.ProductCategoryComboBox.Location = New System.Drawing.Point(125, 87)
        Me.ProductCategoryComboBox.Name = "ProductCategoryComboBox"
        Me.ProductCategoryComboBox.Size = New System.Drawing.Size(362, 21)
        Me.ProductCategoryComboBox.TabIndex = 2
        Me.ProductCategoryComboBox.ValueMember = "ProductCategoryID"
        '
        'ProductCategorySelectionBindingSource
        '
        Me.ProductCategorySelectionBindingSource.DataMember = "ProductCategorySelection"
        Me.ProductCategorySelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'PopularityScoreLabel
        '
        PopularityScoreLabel.AutoSize = True
        PopularityScoreLabel.Location = New System.Drawing.Point(27, 195)
        PopularityScoreLabel.Name = "PopularityScoreLabel"
        PopularityScoreLabel.Size = New System.Drawing.Size(73, 26)
        PopularityScoreLabel.TabIndex = 15
        PopularityScoreLabel.Text = "Display Order:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Higher First)"
        '
        'PopularityScoreTextBox
        '
        Me.PopularityScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "PopularityScore", True))
        Me.PopularityScoreTextBox.Location = New System.Drawing.Point(125, 192)
        Me.PopularityScoreTextBox.Name = "PopularityScoreTextBox"
        Me.PopularityScoreTextBox.Size = New System.Drawing.Size(362, 20)
        Me.PopularityScoreTextBox.TabIndex = 16
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 372)
        Me.Controls.Add(PopularityScoreLabel)
        Me.Controls.Add(Me.PopularityScoreTextBox)
        Me.Controls.Add(ProductCategoryLabel)
        Me.Controls.Add(Me.ProductCategoryComboBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(UnitWeightgmsLabel)
        Me.Controls.Add(Me.UnitWeightgmsTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Product_NameLabel)
        Me.Controls.Add(Me.Product_NameTextBox)
        Me.Controls.Add(PKProductIDLabel)
        Me.Controls.Add(Me.PKProductIDTextBox)
        Me.Controls.Add(GradeLabel)
        Me.Controls.Add(Me.GradeComboBox)
        Me.Controls.Add(Me.ProductsBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "Product"
        Me.Text = "Edit Product"
        CType(Me.ProductsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductsBindingNavigator.ResumeLayout(False)
        Me.ProductsBindingNavigator.PerformLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCategorySelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProductsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GradeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
    Friend WithEvents PKProductIDTextBox As TabTextBox
    Friend WithEvents GradeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GradeSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Product_NameTextBox As TabTextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitWeightgmsTextBox As TabTextBox
    Friend WithEvents PriceTextBox As TabTextBox
    Friend WithEvents ProductCategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductCategorySelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductCategorySelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductCategorySelectionTableAdapter
    Friend WithEvents FilterButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductReportButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PopularityScoreTextBox As System.Windows.Forms.TextBox
End Class
