<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepackReturns
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
        Dim TagLabel As System.Windows.Forms.Label
        Dim Harvest_DateLabel As System.Windows.Forms.Label
        Dim SpeciesLabel As System.Windows.Forms.Label
        Dim EggsizeLabel As System.Windows.Forms.Label
        Dim TasteLabel As System.Windows.Forms.Label
        Dim FirmnessLabel As System.Windows.Forms.Label
        Dim Egg_ColorLabel As System.Windows.Forms.Label
        Dim GradeLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim Product_NameLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer
        Me.InventoryGroupBox = New System.Windows.Forms.GroupBox
        Me.ConfirmBarcodeButton = New System.Windows.Forms.Button
        Me.BarcodeTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Caviar_InventoryDataGridView = New System.Windows.Forms.DataGridView
        Me.PKBarcodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrentStatusColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CaviarStatusSelectionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.PreviousStatusColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CaviarStatusSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateStatusChangedColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKProductIDColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContainerSizeColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.PriceSoldAtColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InventoryNotesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKInvoiceIDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PackingBoxNumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Caviar_InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Caviar_FishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FishandInventorySplitContainer = New System.Windows.Forms.SplitContainer
        Me.FishDetailsGroupBox = New System.Windows.Forms.GroupBox
        Me.NotesTextBox = New System.Windows.Forms.TextBox
        Me.GradeComboBox = New System.Windows.Forms.ComboBox
        Me.GradeSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Egg_ColorTextBox = New System.Windows.Forms.TextBox
        Me.FirmnessTextBox = New System.Windows.Forms.TextBox
        Me.TasteTextBox = New System.Windows.Forms.TextBox
        Me.EggsizeTextBox = New System.Windows.Forms.TextBox
        Me.SpeciesTextBox = New System.Windows.Forms.TextBox
        Me.Harvest_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TagTextBox = New System.Windows.Forms.TextBox
        Me.AddCaviarGroupBox = New System.Windows.Forms.GroupBox
        Me.RepackContainerSizeTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DifferenceTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.RepackDisplayDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.ProductNameCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CountCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalKgsCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrintButton = New System.Windows.Forms.Button
        Me.CompleteButton = New System.Windows.Forms.Button
        Me.AddButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.CountToAddNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Product_NameComboBox = New System.Windows.Forms.ComboBox
        Me.ProductToAddBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Caviar_FishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.Caviar_InventoryTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
        Me.CaviarStatusSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
        Me.GradeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
        Me.ProductsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
        Me.RepackLossTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.RepackLossTableAdapter
        TagLabel = New System.Windows.Forms.Label
        Harvest_DateLabel = New System.Windows.Forms.Label
        SpeciesLabel = New System.Windows.Forms.Label
        EggsizeLabel = New System.Windows.Forms.Label
        TasteLabel = New System.Windows.Forms.Label
        FirmnessLabel = New System.Windows.Forms.Label
        Egg_ColorLabel = New System.Windows.Forms.Label
        GradeLabel = New System.Windows.Forms.Label
        NotesLabel = New System.Windows.Forms.Label
        Product_NameLabel = New System.Windows.Forms.Label
        Me.MainSplitContainer.Panel1.SuspendLayout()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        Me.InventoryGroupBox.SuspendLayout()
        CType(Me.Caviar_InventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarStatusSelectionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caviar_InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FishandInventorySplitContainer.Panel1.SuspendLayout()
        Me.FishandInventorySplitContainer.Panel2.SuspendLayout()
        Me.FishandInventorySplitContainer.SuspendLayout()
        Me.FishDetailsGroupBox.SuspendLayout()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddCaviarGroupBox.SuspendLayout()
        CType(Me.RepackDisplayDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountToAddNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductToAddBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TagLabel
        '
        TagLabel.AutoSize = True
        TagLabel.Location = New System.Drawing.Point(64, 31)
        TagLabel.Name = "TagLabel"
        TagLabel.Size = New System.Drawing.Size(29, 13)
        TagLabel.TabIndex = 0
        TagLabel.Text = "Tag:"
        '
        'Harvest_DateLabel
        '
        Harvest_DateLabel.AutoSize = True
        Harvest_DateLabel.Location = New System.Drawing.Point(20, 58)
        Harvest_DateLabel.Name = "Harvest_DateLabel"
        Harvest_DateLabel.Size = New System.Drawing.Size(73, 13)
        Harvest_DateLabel.TabIndex = 2
        Harvest_DateLabel.Text = "Harvest Date:"
        '
        'SpeciesLabel
        '
        SpeciesLabel.AutoSize = True
        SpeciesLabel.Location = New System.Drawing.Point(45, 83)
        SpeciesLabel.Name = "SpeciesLabel"
        SpeciesLabel.Size = New System.Drawing.Size(48, 13)
        SpeciesLabel.TabIndex = 4
        SpeciesLabel.Text = "Species:"
        '
        'EggsizeLabel
        '
        EggsizeLabel.AutoSize = True
        EggsizeLabel.Location = New System.Drawing.Point(46, 109)
        EggsizeLabel.Name = "EggsizeLabel"
        EggsizeLabel.Size = New System.Drawing.Size(47, 13)
        EggsizeLabel.TabIndex = 6
        EggsizeLabel.Text = "Eggsize:"
        '
        'TasteLabel
        '
        TasteLabel.AutoSize = True
        TasteLabel.Location = New System.Drawing.Point(56, 135)
        TasteLabel.Name = "TasteLabel"
        TasteLabel.Size = New System.Drawing.Size(37, 13)
        TasteLabel.TabIndex = 8
        TasteLabel.Text = "Taste:"
        '
        'FirmnessLabel
        '
        FirmnessLabel.AutoSize = True
        FirmnessLabel.Location = New System.Drawing.Point(42, 161)
        FirmnessLabel.Name = "FirmnessLabel"
        FirmnessLabel.Size = New System.Drawing.Size(51, 13)
        FirmnessLabel.TabIndex = 10
        FirmnessLabel.Text = "Firmness:"
        '
        'Egg_ColorLabel
        '
        Egg_ColorLabel.AutoSize = True
        Egg_ColorLabel.Location = New System.Drawing.Point(37, 187)
        Egg_ColorLabel.Name = "Egg_ColorLabel"
        Egg_ColorLabel.Size = New System.Drawing.Size(56, 13)
        Egg_ColorLabel.TabIndex = 12
        Egg_ColorLabel.Text = "Egg Color:"
        '
        'GradeLabel
        '
        GradeLabel.AutoSize = True
        GradeLabel.Location = New System.Drawing.Point(54, 213)
        GradeLabel.Name = "GradeLabel"
        GradeLabel.Size = New System.Drawing.Size(39, 13)
        GradeLabel.TabIndex = 14
        GradeLabel.Text = "Grade:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(55, 240)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(38, 13)
        NotesLabel.TabIndex = 16
        NotesLabel.Text = "Notes:"
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Location = New System.Drawing.Point(29, 60)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(78, 13)
        Product_NameLabel.TabIndex = 0
        Product_NameLabel.Text = "Product Name:"
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MainSplitContainer.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.AutoScroll = True
        Me.MainSplitContainer.Panel1.Controls.Add(Me.InventoryGroupBox)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.FishandInventorySplitContainer)
        Me.MainSplitContainer.Size = New System.Drawing.Size(910, 458)
        Me.MainSplitContainer.SplitterDistance = 316
        Me.MainSplitContainer.TabIndex = 0
        '
        'InventoryGroupBox
        '
        Me.InventoryGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InventoryGroupBox.Controls.Add(Me.ConfirmBarcodeButton)
        Me.InventoryGroupBox.Controls.Add(Me.BarcodeTextBox)
        Me.InventoryGroupBox.Controls.Add(Me.Label1)
        Me.InventoryGroupBox.Controls.Add(Me.Caviar_InventoryDataGridView)
        Me.InventoryGroupBox.Location = New System.Drawing.Point(3, 5)
        Me.InventoryGroupBox.Name = "InventoryGroupBox"
        Me.InventoryGroupBox.Size = New System.Drawing.Size(306, 447)
        Me.InventoryGroupBox.TabIndex = 1
        Me.InventoryGroupBox.TabStop = False
        Me.InventoryGroupBox.Text = "Select Item (Inventory Details)"
        '
        'ConfirmBarcodeButton
        '
        Me.ConfirmBarcodeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfirmBarcodeButton.Enabled = False
        Me.ConfirmBarcodeButton.Location = New System.Drawing.Point(186, 389)
        Me.ConfirmBarcodeButton.Name = "ConfirmBarcodeButton"
        Me.ConfirmBarcodeButton.Size = New System.Drawing.Size(114, 50)
        Me.ConfirmBarcodeButton.TabIndex = 24
        Me.ConfirmBarcodeButton.Text = "Confirm Barcode"
        Me.ConfirmBarcodeButton.UseVisualStyleBackColor = True
        '
        'BarcodeTextBox
        '
        Me.BarcodeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BarcodeTextBox.Location = New System.Drawing.Point(119, 28)
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.Size = New System.Drawing.Size(181, 20)
        Me.BarcodeTextBox.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Scan Barcode Here:"
        '
        'Caviar_InventoryDataGridView
        '
        Me.Caviar_InventoryDataGridView.AllowUserToAddRows = False
        Me.Caviar_InventoryDataGridView.AllowUserToDeleteRows = False
        Me.Caviar_InventoryDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Caviar_InventoryDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Caviar_InventoryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Caviar_InventoryDataGridView.AutoGenerateColumns = False
        Me.Caviar_InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Caviar_InventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PKBarcodeColumn, Me.CurrentStatusColumn, Me.PreviousStatusColumn, Me.DateStatusChangedColumn, Me.FKProductIDColumn, Me.ContainerSizeColumn, Me.PriceSoldAtColumn, Me.InventoryNotesColumn, Me.FKInvoiceIDColumn, Me.PackingBoxNumberColumn})
        Me.Caviar_InventoryDataGridView.DataSource = Me.Caviar_InventoryBindingSource
        Me.Caviar_InventoryDataGridView.Location = New System.Drawing.Point(6, 57)
        Me.Caviar_InventoryDataGridView.MultiSelect = False
        Me.Caviar_InventoryDataGridView.Name = "Caviar_InventoryDataGridView"
        Me.Caviar_InventoryDataGridView.ReadOnly = True
        Me.Caviar_InventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Caviar_InventoryDataGridView.Size = New System.Drawing.Size(294, 326)
        Me.Caviar_InventoryDataGridView.TabIndex = 0
        '
        'PKBarcodeColumn
        '
        Me.PKBarcodeColumn.DataPropertyName = "PKBarcode"
        Me.PKBarcodeColumn.HeaderText = "Barcode"
        Me.PKBarcodeColumn.Name = "PKBarcodeColumn"
        Me.PKBarcodeColumn.ReadOnly = True
        '
        'CurrentStatusColumn
        '
        Me.CurrentStatusColumn.DataPropertyName = "InventoryStatus"
        Me.CurrentStatusColumn.DataSource = Me.CaviarStatusSelectionBindingSource1
        Me.CurrentStatusColumn.DisplayMember = "Description"
        Me.CurrentStatusColumn.HeaderText = "Current Inventory Status"
        Me.CurrentStatusColumn.Name = "CurrentStatusColumn"
        Me.CurrentStatusColumn.ReadOnly = True
        Me.CurrentStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CurrentStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CurrentStatusColumn.ValueMember = "PKStatusID"
        '
        'CaviarStatusSelectionBindingSource1
        '
        Me.CaviarStatusSelectionBindingSource1.DataMember = "CaviarStatusSelection"
        Me.CaviarStatusSelectionBindingSource1.DataSource = Me.SturgeonDBDataSet
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PreviousStatusColumn
        '
        Me.PreviousStatusColumn.DataPropertyName = "PreviousStatus"
        Me.PreviousStatusColumn.DataSource = Me.CaviarStatusSelectionBindingSource
        Me.PreviousStatusColumn.DisplayMember = "Description"
        Me.PreviousStatusColumn.HeaderText = "Previous Status"
        Me.PreviousStatusColumn.Name = "PreviousStatusColumn"
        Me.PreviousStatusColumn.ReadOnly = True
        Me.PreviousStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PreviousStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PreviousStatusColumn.ValueMember = "PKStatusID"
        '
        'CaviarStatusSelectionBindingSource
        '
        Me.CaviarStatusSelectionBindingSource.DataMember = "CaviarStatusSelection"
        Me.CaviarStatusSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'DateStatusChangedColumn
        '
        Me.DateStatusChangedColumn.DataPropertyName = "DateStatusChanged"
        Me.DateStatusChangedColumn.HeaderText = "Date Status Changed"
        Me.DateStatusChangedColumn.Name = "DateStatusChangedColumn"
        Me.DateStatusChangedColumn.ReadOnly = True
        '
        'FKProductIDColumn
        '
        Me.FKProductIDColumn.DataPropertyName = "FKProductID"
        Me.FKProductIDColumn.DataSource = Me.ProductsBindingSource
        Me.FKProductIDColumn.DisplayMember = "Product Name"
        Me.FKProductIDColumn.HeaderText = "Product Code"
        Me.FKProductIDColumn.Name = "FKProductIDColumn"
        Me.FKProductIDColumn.ReadOnly = True
        Me.FKProductIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FKProductIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FKProductIDColumn.ValueMember = "PKProductID"
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'ContainerSizeColumn
        '
        Me.ContainerSizeColumn.DataPropertyName = "FKProductID"
        Me.ContainerSizeColumn.DataSource = Me.ProductsBindingSource
        Me.ContainerSizeColumn.DisplayMember = "UnitWeightgms"
        Me.ContainerSizeColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ContainerSizeColumn.HeaderText = "Container Size"
        Me.ContainerSizeColumn.Name = "ContainerSizeColumn"
        Me.ContainerSizeColumn.ReadOnly = True
        Me.ContainerSizeColumn.ValueMember = "PKProductID"
        '
        'PriceSoldAtColumn
        '
        Me.PriceSoldAtColumn.DataPropertyName = "PriceSoldAt"
        Me.PriceSoldAtColumn.HeaderText = "Price Per Kg"
        Me.PriceSoldAtColumn.Name = "PriceSoldAtColumn"
        Me.PriceSoldAtColumn.ReadOnly = True
        '
        'InventoryNotesColumn
        '
        Me.InventoryNotesColumn.DataPropertyName = "Notes"
        Me.InventoryNotesColumn.HeaderText = "Notes"
        Me.InventoryNotesColumn.Name = "InventoryNotesColumn"
        Me.InventoryNotesColumn.ReadOnly = True
        '
        'FKInvoiceIDColumn
        '
        Me.FKInvoiceIDColumn.DataPropertyName = "FKInvoiceID"
        Me.FKInvoiceIDColumn.HeaderText = "Invoice Number"
        Me.FKInvoiceIDColumn.Name = "FKInvoiceIDColumn"
        Me.FKInvoiceIDColumn.ReadOnly = True
        '
        'PackingBoxNumberColumn
        '
        Me.PackingBoxNumberColumn.DataPropertyName = "PackingBoxNumber"
        Me.PackingBoxNumberColumn.HeaderText = "Packing Box"
        Me.PackingBoxNumberColumn.Name = "PackingBoxNumberColumn"
        Me.PackingBoxNumberColumn.ReadOnly = True
        '
        'Caviar_InventoryBindingSource
        '
        Me.Caviar_InventoryBindingSource.DataMember = "Caviar FishCaviar Inventory"
        Me.Caviar_InventoryBindingSource.DataSource = Me.Caviar_FishBindingSource
        '
        'Caviar_FishBindingSource
        '
        Me.Caviar_FishBindingSource.DataMember = "Caviar Fish"
        Me.Caviar_FishBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'FishandInventorySplitContainer
        '
        Me.FishandInventorySplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FishandInventorySplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FishandInventorySplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.FishandInventorySplitContainer.Name = "FishandInventorySplitContainer"
        '
        'FishandInventorySplitContainer.Panel1
        '
        Me.FishandInventorySplitContainer.Panel1.AutoScroll = True
        Me.FishandInventorySplitContainer.Panel1.Controls.Add(Me.FishDetailsGroupBox)
        '
        'FishandInventorySplitContainer.Panel2
        '
        Me.FishandInventorySplitContainer.Panel2.AutoScroll = True
        Me.FishandInventorySplitContainer.Panel2.Controls.Add(Me.AddCaviarGroupBox)
        Me.FishandInventorySplitContainer.Size = New System.Drawing.Size(586, 454)
        Me.FishandInventorySplitContainer.SplitterDistance = 276
        Me.FishandInventorySplitContainer.TabIndex = 0
        '
        'FishDetailsGroupBox
        '
        Me.FishDetailsGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FishDetailsGroupBox.Controls.Add(NotesLabel)
        Me.FishDetailsGroupBox.Controls.Add(Me.NotesTextBox)
        Me.FishDetailsGroupBox.Controls.Add(GradeLabel)
        Me.FishDetailsGroupBox.Controls.Add(Me.GradeComboBox)
        Me.FishDetailsGroupBox.Controls.Add(Egg_ColorLabel)
        Me.FishDetailsGroupBox.Controls.Add(Me.Egg_ColorTextBox)
        Me.FishDetailsGroupBox.Controls.Add(FirmnessLabel)
        Me.FishDetailsGroupBox.Controls.Add(Me.FirmnessTextBox)
        Me.FishDetailsGroupBox.Controls.Add(TasteLabel)
        Me.FishDetailsGroupBox.Controls.Add(Me.TasteTextBox)
        Me.FishDetailsGroupBox.Controls.Add(EggsizeLabel)
        Me.FishDetailsGroupBox.Controls.Add(Me.EggsizeTextBox)
        Me.FishDetailsGroupBox.Controls.Add(SpeciesLabel)
        Me.FishDetailsGroupBox.Controls.Add(Me.SpeciesTextBox)
        Me.FishDetailsGroupBox.Controls.Add(Harvest_DateLabel)
        Me.FishDetailsGroupBox.Controls.Add(Me.Harvest_DateDateTimePicker)
        Me.FishDetailsGroupBox.Controls.Add(Me.TagTextBox)
        Me.FishDetailsGroupBox.Controls.Add(TagLabel)
        Me.FishDetailsGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.FishDetailsGroupBox.Name = "FishDetailsGroupBox"
        Me.FishDetailsGroupBox.Size = New System.Drawing.Size(266, 447)
        Me.FishDetailsGroupBox.TabIndex = 2
        Me.FishDetailsGroupBox.TabStop = False
        Me.FishDetailsGroupBox.Text = "Fish Details"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Notes", True))
        Me.NotesTextBox.Enabled = False
        Me.NotesTextBox.Location = New System.Drawing.Point(99, 237)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(145, 146)
        Me.NotesTextBox.TabIndex = 17
        '
        'GradeComboBox
        '
        Me.GradeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Caviar_FishBindingSource, "Grade", True))
        Me.GradeComboBox.DataSource = Me.GradeSelectionBindingSource
        Me.GradeComboBox.DisplayMember = "Grade"
        Me.GradeComboBox.Enabled = False
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(99, 210)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(145, 21)
        Me.GradeComboBox.TabIndex = 15
        Me.GradeComboBox.ValueMember = "ID"
        '
        'GradeSelectionBindingSource
        '
        Me.GradeSelectionBindingSource.DataMember = "GradeSelection"
        Me.GradeSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'Egg_ColorTextBox
        '
        Me.Egg_ColorTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Egg_ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Egg Color", True))
        Me.Egg_ColorTextBox.Enabled = False
        Me.Egg_ColorTextBox.Location = New System.Drawing.Point(99, 184)
        Me.Egg_ColorTextBox.Name = "Egg_ColorTextBox"
        Me.Egg_ColorTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Egg_ColorTextBox.TabIndex = 13
        '
        'FirmnessTextBox
        '
        Me.FirmnessTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirmnessTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Firmness", True))
        Me.FirmnessTextBox.Enabled = False
        Me.FirmnessTextBox.Location = New System.Drawing.Point(99, 158)
        Me.FirmnessTextBox.Name = "FirmnessTextBox"
        Me.FirmnessTextBox.Size = New System.Drawing.Size(145, 20)
        Me.FirmnessTextBox.TabIndex = 11
        '
        'TasteTextBox
        '
        Me.TasteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TasteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Taste", True))
        Me.TasteTextBox.Enabled = False
        Me.TasteTextBox.Location = New System.Drawing.Point(99, 132)
        Me.TasteTextBox.Name = "TasteTextBox"
        Me.TasteTextBox.Size = New System.Drawing.Size(145, 20)
        Me.TasteTextBox.TabIndex = 9
        '
        'EggsizeTextBox
        '
        Me.EggsizeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EggsizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Eggsize", True))
        Me.EggsizeTextBox.Enabled = False
        Me.EggsizeTextBox.Location = New System.Drawing.Point(99, 106)
        Me.EggsizeTextBox.Name = "EggsizeTextBox"
        Me.EggsizeTextBox.Size = New System.Drawing.Size(145, 20)
        Me.EggsizeTextBox.TabIndex = 7
        '
        'SpeciesTextBox
        '
        Me.SpeciesTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpeciesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Species", True))
        Me.SpeciesTextBox.Enabled = False
        Me.SpeciesTextBox.Location = New System.Drawing.Point(99, 80)
        Me.SpeciesTextBox.Name = "SpeciesTextBox"
        Me.SpeciesTextBox.Size = New System.Drawing.Size(145, 20)
        Me.SpeciesTextBox.TabIndex = 5
        '
        'Harvest_DateDateTimePicker
        '
        Me.Harvest_DateDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Harvest_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Caviar_FishBindingSource, "Harvest Date", True))
        Me.Harvest_DateDateTimePicker.Enabled = False
        Me.Harvest_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Harvest_DateDateTimePicker.Location = New System.Drawing.Point(99, 54)
        Me.Harvest_DateDateTimePicker.Name = "Harvest_DateDateTimePicker"
        Me.Harvest_DateDateTimePicker.Size = New System.Drawing.Size(145, 20)
        Me.Harvest_DateDateTimePicker.TabIndex = 3
        '
        'TagTextBox
        '
        Me.TagTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TagTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Tag", True))
        Me.TagTextBox.Enabled = False
        Me.TagTextBox.Location = New System.Drawing.Point(99, 28)
        Me.TagTextBox.Name = "TagTextBox"
        Me.TagTextBox.Size = New System.Drawing.Size(145, 20)
        Me.TagTextBox.TabIndex = 1
        '
        'AddCaviarGroupBox
        '
        Me.AddCaviarGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddCaviarGroupBox.Controls.Add(Me.RepackContainerSizeTextBox)
        Me.AddCaviarGroupBox.Controls.Add(Me.Label4)
        Me.AddCaviarGroupBox.Controls.Add(Me.DifferenceTextBox)
        Me.AddCaviarGroupBox.Controls.Add(Me.Label3)
        Me.AddCaviarGroupBox.Controls.Add(Me.RepackDisplayDataGridView)
        Me.AddCaviarGroupBox.Controls.Add(Me.PrintButton)
        Me.AddCaviarGroupBox.Controls.Add(Me.CompleteButton)
        Me.AddCaviarGroupBox.Controls.Add(Me.AddButton)
        Me.AddCaviarGroupBox.Controls.Add(Me.Label2)
        Me.AddCaviarGroupBox.Controls.Add(Me.CountToAddNumericUpDown)
        Me.AddCaviarGroupBox.Controls.Add(Product_NameLabel)
        Me.AddCaviarGroupBox.Controls.Add(Me.Product_NameComboBox)
        Me.AddCaviarGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.AddCaviarGroupBox.Name = "AddCaviarGroupBox"
        Me.AddCaviarGroupBox.Size = New System.Drawing.Size(299, 447)
        Me.AddCaviarGroupBox.TabIndex = 0
        Me.AddCaviarGroupBox.TabStop = False
        Me.AddCaviarGroupBox.Text = "Add Additional Container(s)"
        '
        'RepackContainerSizeTextBox
        '
        Me.RepackContainerSizeTextBox.Location = New System.Drawing.Point(152, 110)
        Me.RepackContainerSizeTextBox.Name = "RepackContainerSizeTextBox"
        Me.RepackContainerSizeTextBox.ReadOnly = True
        Me.RepackContainerSizeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RepackContainerSizeTextBox.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Repack Container Size: "
        '
        'DifferenceTextBox
        '
        Me.DifferenceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DifferenceTextBox.Enabled = False
        Me.DifferenceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DifferenceTextBox.Location = New System.Drawing.Point(161, 356)
        Me.DifferenceTextBox.Name = "DifferenceTextBox"
        Me.DifferenceTextBox.Size = New System.Drawing.Size(91, 20)
        Me.DifferenceTextBox.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(29, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Over/Under Pack:"
        '
        'RepackDisplayDataGridView
        '
        Me.RepackDisplayDataGridView.AllowUserToAddRows = False
        Me.RepackDisplayDataGridView.AllowUserToDeleteRows = False
        Me.RepackDisplayDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RepackDisplayDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.RepackDisplayDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RepackDisplayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RepackDisplayDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductNameCaviarOrderDisplayColumn, Me.CountCaviarOrderDisplayColumn, Me.TotalKgsCaviarOrderDisplayColumn})
        Me.RepackDisplayDataGridView.Location = New System.Drawing.Point(6, 146)
        Me.RepackDisplayDataGridView.Name = "RepackDisplayDataGridView"
        Me.RepackDisplayDataGridView.ReadOnly = True
        Me.RepackDisplayDataGridView.Size = New System.Drawing.Size(287, 204)
        Me.RepackDisplayDataGridView.TabIndex = 29
        '
        'ProductNameCaviarOrderDisplayColumn
        '
        Me.ProductNameCaviarOrderDisplayColumn.HeaderText = "Product Code"
        Me.ProductNameCaviarOrderDisplayColumn.Name = "ProductNameCaviarOrderDisplayColumn"
        Me.ProductNameCaviarOrderDisplayColumn.ReadOnly = True
        '
        'CountCaviarOrderDisplayColumn
        '
        Me.CountCaviarOrderDisplayColumn.HeaderText = "Count"
        Me.CountCaviarOrderDisplayColumn.Name = "CountCaviarOrderDisplayColumn"
        Me.CountCaviarOrderDisplayColumn.ReadOnly = True
        '
        'TotalKgsCaviarOrderDisplayColumn
        '
        Me.TotalKgsCaviarOrderDisplayColumn.HeaderText = "Total Kgs"
        Me.TotalKgsCaviarOrderDisplayColumn.Name = "TotalKgsCaviarOrderDisplayColumn"
        Me.TotalKgsCaviarOrderDisplayColumn.ReadOnly = True
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.Enabled = False
        Me.PrintButton.Location = New System.Drawing.Point(186, 390)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(98, 50)
        Me.PrintButton.TabIndex = 6
        Me.PrintButton.Text = "Print Item(s)"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'CompleteButton
        '
        Me.CompleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CompleteButton.Enabled = False
        Me.CompleteButton.Location = New System.Drawing.Point(32, 390)
        Me.CompleteButton.Name = "CompleteButton"
        Me.CompleteButton.Size = New System.Drawing.Size(99, 50)
        Me.CompleteButton.TabIndex = 5
        Me.CompleteButton.Text = "Complete Repack"
        Me.CompleteButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddButton.Enabled = False
        Me.AddButton.Location = New System.Drawing.Point(204, 83)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(60, 23)
        Me.AddButton.TabIndex = 4
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "How Many?"
        '
        'CountToAddNumericUpDown
        '
        Me.CountToAddNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CountToAddNumericUpDown.Enabled = False
        Me.CountToAddNumericUpDown.Location = New System.Drawing.Point(113, 86)
        Me.CountToAddNumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.CountToAddNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CountToAddNumericUpDown.Name = "CountToAddNumericUpDown"
        Me.CountToAddNumericUpDown.Size = New System.Drawing.Size(85, 20)
        Me.CountToAddNumericUpDown.TabIndex = 2
        Me.CountToAddNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Product_NameComboBox
        '
        Me.Product_NameComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_NameComboBox.DataSource = Me.ProductToAddBindingSource
        Me.Product_NameComboBox.DisplayMember = "Product Name"
        Me.Product_NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Product_NameComboBox.Enabled = False
        Me.Product_NameComboBox.FormattingEnabled = True
        Me.Product_NameComboBox.Location = New System.Drawing.Point(113, 57)
        Me.Product_NameComboBox.Name = "Product_NameComboBox"
        Me.Product_NameComboBox.Size = New System.Drawing.Size(151, 21)
        Me.Product_NameComboBox.TabIndex = 1
        Me.Product_NameComboBox.ValueMember = "PKProductID"
        '
        'ProductToAddBindingSource
        '
        Me.ProductToAddBindingSource.DataMember = "Products"
        Me.ProductToAddBindingSource.DataSource = Me.SturgeonDBDataSet
        Me.ProductToAddBindingSource.Filter = ""
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
        Me.TableAdapterManager.RepackLossTableAdapter = Me.RepackLossTableAdapter
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
        'RepackLossTableAdapter
        '
        Me.RepackLossTableAdapter.ClearBeforeFill = True
        '
        'RepackReturns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 458)
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Name = "RepackReturns"
        Me.Text = "Repack and Return"
        Me.MainSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        Me.MainSplitContainer.ResumeLayout(False)
        Me.InventoryGroupBox.ResumeLayout(False)
        Me.InventoryGroupBox.PerformLayout()
        CType(Me.Caviar_InventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarStatusSelectionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caviar_InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FishandInventorySplitContainer.Panel1.ResumeLayout(False)
        Me.FishandInventorySplitContainer.Panel2.ResumeLayout(False)
        Me.FishandInventorySplitContainer.ResumeLayout(False)
        Me.FishDetailsGroupBox.ResumeLayout(False)
        Me.FishDetailsGroupBox.PerformLayout()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddCaviarGroupBox.ResumeLayout(False)
        Me.AddCaviarGroupBox.PerformLayout()
        CType(Me.RepackDisplayDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountToAddNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductToAddBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents FishandInventorySplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents Caviar_FishBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caviar_FishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FishDetailsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Harvest_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TagTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GradeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Egg_ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirmnessTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TasteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EggsizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpeciesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Caviar_InventoryTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
    Friend WithEvents Caviar_InventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventoryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Caviar_InventoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GradeSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
    Friend WithEvents ProductsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddCaviarGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Product_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductToAddBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CountToAddNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents CompleteButton As System.Windows.Forms.Button
    Friend WithEvents CaviarStatusSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
    Friend WithEvents CaviarStatusSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarStatusSelectionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ConfirmBarcodeButton As System.Windows.Forms.Button
    Friend WithEvents RepackDisplayDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents ProductNameCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalKgsCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DifferenceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RepackContainerSizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PKBarcodeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentStatusColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PreviousStatusColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DateStatusChangedColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKProductIDColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ContainerSizeColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PriceSoldAtColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryNotesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKInvoiceIDColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PackingBoxNumberColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RepackLossTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.RepackLossTableAdapter
End Class
