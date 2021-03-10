<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintingPackingStation
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
        Dim EggsizeLabel As System.Windows.Forms.Label
        Dim TasteLabel As System.Windows.Forms.Label
        Dim FirmnessLabel As System.Windows.Forms.Label
        Dim Egg_ColorLabel As System.Windows.Forms.Label
        Dim GradeLabel As System.Windows.Forms.Label
        Dim Egg_WtLabel As System.Windows.Forms.Label
        Dim Harvest_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintingPackingStation))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.BarcodeInput = New System.Windows.Forms.TextBox
        Me.FishGroupBox = New System.Windows.Forms.GroupBox
        Me.Harvest_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Caviar_FishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.Egg_WtTextBox = New System.Windows.Forms.TextBox
        Me.CompletedCheckBox = New System.Windows.Forms.CheckBox
        Me.GradeComboBox = New System.Windows.Forms.ComboBox
        Me.GradeSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Egg_ColorTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.FirmnessTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.TasteTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.EggsizeTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Caviar_FishBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Caviar_FishBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.RefreshButton = New System.Windows.Forms.ToolStripButton
        Me.Caviar_FishDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaltingStationCompletedColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ProductGroupBox = New System.Windows.Forms.GroupBox
        Me.Caviar_InventoryDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.PKBarcodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKProductIDColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryStatusColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CaviarStatusSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaviarInventoryNotesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateStatusChanged = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PreviousStatus = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Caviar_InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DifferenceTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CaviarTotalTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Caviar_InventoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.PrintAllFishLabelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintSelectedLabelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Caviar_FishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.Caviar_InventoryTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
        Me.CaviarStatusSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
        Me.ConcurrencyHandlerTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ConcurrencyHandlerTableAdapter
        Me.GradeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
        Me.ProductsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
        Me.SplitContainer = New System.Windows.Forms.SplitContainer
        Me.ConcurrencyTimer = New System.Windows.Forms.Timer(Me.components)
        EggsizeLabel = New System.Windows.Forms.Label
        TasteLabel = New System.Windows.Forms.Label
        FirmnessLabel = New System.Windows.Forms.Label
        Egg_ColorLabel = New System.Windows.Forms.Label
        GradeLabel = New System.Windows.Forms.Label
        Egg_WtLabel = New System.Windows.Forms.Label
        Harvest_DateLabel = New System.Windows.Forms.Label
        Me.FishGroupBox.SuspendLayout()
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caviar_FishBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Caviar_FishBindingNavigator.SuspendLayout()
        CType(Me.Caviar_FishDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductGroupBox.SuspendLayout()
        CType(Me.Caviar_InventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caviar_InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caviar_InventoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Caviar_InventoryBindingNavigator.SuspendLayout()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'EggsizeLabel
        '
        EggsizeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        EggsizeLabel.AutoSize = True
        EggsizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EggsizeLabel.Location = New System.Drawing.Point(48, 336)
        EggsizeLabel.Name = "EggsizeLabel"
        EggsizeLabel.Size = New System.Drawing.Size(83, 24)
        EggsizeLabel.TabIndex = 25
        EggsizeLabel.Text = "Eggsize:"
        '
        'TasteLabel
        '
        TasteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        TasteLabel.AutoSize = True
        TasteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TasteLabel.Location = New System.Drawing.Point(48, 371)
        TasteLabel.Name = "TasteLabel"
        TasteLabel.Size = New System.Drawing.Size(61, 24)
        TasteLabel.TabIndex = 26
        TasteLabel.Text = "Taste:"
        '
        'FirmnessLabel
        '
        FirmnessLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        FirmnessLabel.AutoSize = True
        FirmnessLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirmnessLabel.Location = New System.Drawing.Point(48, 406)
        FirmnessLabel.Name = "FirmnessLabel"
        FirmnessLabel.Size = New System.Drawing.Size(93, 24)
        FirmnessLabel.TabIndex = 27
        FirmnessLabel.Text = "Firmness:"
        '
        'Egg_ColorLabel
        '
        Egg_ColorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Egg_ColorLabel.AutoSize = True
        Egg_ColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Egg_ColorLabel.Location = New System.Drawing.Point(48, 440)
        Egg_ColorLabel.Name = "Egg_ColorLabel"
        Egg_ColorLabel.Size = New System.Drawing.Size(100, 24)
        Egg_ColorLabel.TabIndex = 28
        Egg_ColorLabel.Text = "Egg Color:"
        '
        'GradeLabel
        '
        GradeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        GradeLabel.AutoSize = True
        GradeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GradeLabel.Location = New System.Drawing.Point(48, 475)
        GradeLabel.Name = "GradeLabel"
        GradeLabel.Size = New System.Drawing.Size(67, 24)
        GradeLabel.TabIndex = 29
        GradeLabel.Text = "Grade:"
        '
        'Egg_WtLabel
        '
        Egg_WtLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Egg_WtLabel.AutoSize = True
        Egg_WtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Egg_WtLabel.Location = New System.Drawing.Point(48, 518)
        Egg_WtLabel.Name = "Egg_WtLabel"
        Egg_WtLabel.Size = New System.Drawing.Size(77, 24)
        Egg_WtLabel.TabIndex = 31
        Egg_WtLabel.Text = "Egg Wt:"
        '
        'Harvest_DateLabel
        '
        Harvest_DateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Harvest_DateLabel.AutoSize = True
        Harvest_DateLabel.Location = New System.Drawing.Point(345, 496)
        Harvest_DateLabel.Name = "Harvest_DateLabel"
        Harvest_DateLabel.Size = New System.Drawing.Size(73, 13)
        Harvest_DateLabel.TabIndex = 32
        Harvest_DateLabel.Text = "Harvest Date:"
        Harvest_DateLabel.Visible = False
        '
        'BarcodeInput
        '
        Me.BarcodeInput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BarcodeInput.BackColor = System.Drawing.Color.Red
        Me.BarcodeInput.Location = New System.Drawing.Point(170, 12)
        Me.BarcodeInput.Name = "BarcodeInput"
        Me.BarcodeInput.Size = New System.Drawing.Size(690, 20)
        Me.BarcodeInput.TabIndex = 0
        '
        'FishGroupBox
        '
        Me.FishGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FishGroupBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FishGroupBox.Controls.Add(Harvest_DateLabel)
        Me.FishGroupBox.Controls.Add(Me.Harvest_DateDateTimePicker)
        Me.FishGroupBox.Controls.Add(Egg_WtLabel)
        Me.FishGroupBox.Controls.Add(Me.Egg_WtTextBox)
        Me.FishGroupBox.Controls.Add(Me.CompletedCheckBox)
        Me.FishGroupBox.Controls.Add(GradeLabel)
        Me.FishGroupBox.Controls.Add(Me.GradeComboBox)
        Me.FishGroupBox.Controls.Add(Egg_ColorLabel)
        Me.FishGroupBox.Controls.Add(Me.Egg_ColorTextBox)
        Me.FishGroupBox.Controls.Add(FirmnessLabel)
        Me.FishGroupBox.Controls.Add(Me.FirmnessTextBox)
        Me.FishGroupBox.Controls.Add(TasteLabel)
        Me.FishGroupBox.Controls.Add(Me.TasteTextBox)
        Me.FishGroupBox.Controls.Add(EggsizeLabel)
        Me.FishGroupBox.Controls.Add(Me.EggsizeTextBox)
        Me.FishGroupBox.Controls.Add(Me.Caviar_FishBindingNavigator)
        Me.FishGroupBox.Controls.Add(Me.Caviar_FishDataGridView)
        Me.FishGroupBox.Location = New System.Drawing.Point(1, -2)
        Me.FishGroupBox.Name = "FishGroupBox"
        Me.FishGroupBox.Size = New System.Drawing.Size(491, 563)
        Me.FishGroupBox.TabIndex = 1
        Me.FishGroupBox.TabStop = False
        Me.FishGroupBox.Text = "Caviar Fish"
        '
        'Harvest_DateDateTimePicker
        '
        Me.Harvest_DateDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Harvest_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Caviar_FishBindingSource, "Harvest Date", True))
        Me.Harvest_DateDateTimePicker.Location = New System.Drawing.Point(424, 492)
        Me.Harvest_DateDateTimePicker.Name = "Harvest_DateDateTimePicker"
        Me.Harvest_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Harvest_DateDateTimePicker.TabIndex = 33
        Me.Harvest_DateDateTimePicker.Visible = False
        '
        'Caviar_FishBindingSource
        '
        Me.Caviar_FishBindingSource.DataMember = "Caviar Fish"
        Me.Caviar_FishBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Egg_WtTextBox
        '
        Me.Egg_WtTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Egg_WtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Egg Wt", True))
        Me.Egg_WtTextBox.Enabled = False
        Me.Egg_WtTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Egg_WtTextBox.Location = New System.Drawing.Point(155, 513)
        Me.Egg_WtTextBox.Name = "Egg_WtTextBox"
        Me.Egg_WtTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Egg_WtTextBox.TabIndex = 32
        '
        'CompletedCheckBox
        '
        Me.CompletedCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompletedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Caviar_FishBindingSource, "Completed", True))
        Me.CompletedCheckBox.Enabled = False
        Me.CompletedCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompletedCheckBox.Location = New System.Drawing.Point(348, 514)
        Me.CompletedCheckBox.Name = "CompletedCheckBox"
        Me.CompletedCheckBox.Size = New System.Drawing.Size(110, 25)
        Me.CompletedCheckBox.TabIndex = 31
        Me.CompletedCheckBox.Text = "Completed"
        Me.CompletedCheckBox.UseVisualStyleBackColor = True
        '
        'GradeComboBox
        '
        Me.GradeComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GradeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Caviar_FishBindingSource, "Grade", True))
        Me.GradeComboBox.DataSource = Me.GradeSelectionBindingSource
        Me.GradeComboBox.DisplayMember = "Grade"
        Me.GradeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(155, 472)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(164, 32)
        Me.GradeComboBox.TabIndex = 30
        Me.GradeComboBox.ValueMember = "ID"
        '
        'GradeSelectionBindingSource
        '
        Me.GradeSelectionBindingSource.DataMember = "GradeSelection"
        Me.GradeSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'Egg_ColorTextBox
        '
        Me.Egg_ColorTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Egg_ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Egg Color", True))
        Me.Egg_ColorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Egg_ColorTextBox.Location = New System.Drawing.Point(155, 437)
        Me.Egg_ColorTextBox.Name = "Egg_ColorTextBox"
        Me.Egg_ColorTextBox.Size = New System.Drawing.Size(164, 29)
        Me.Egg_ColorTextBox.TabIndex = 29
        '
        'FirmnessTextBox
        '
        Me.FirmnessTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FirmnessTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Firmness", True))
        Me.FirmnessTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirmnessTextBox.Location = New System.Drawing.Point(155, 401)
        Me.FirmnessTextBox.Name = "FirmnessTextBox"
        Me.FirmnessTextBox.Size = New System.Drawing.Size(164, 29)
        Me.FirmnessTextBox.TabIndex = 28
        '
        'TasteTextBox
        '
        Me.TasteTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TasteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Taste", True))
        Me.TasteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TasteTextBox.Location = New System.Drawing.Point(155, 366)
        Me.TasteTextBox.Name = "TasteTextBox"
        Me.TasteTextBox.Size = New System.Drawing.Size(164, 29)
        Me.TasteTextBox.TabIndex = 27
        '
        'EggsizeTextBox
        '
        Me.EggsizeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EggsizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Eggsize", True))
        Me.EggsizeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EggsizeTextBox.Location = New System.Drawing.Point(155, 331)
        Me.EggsizeTextBox.Name = "EggsizeTextBox"
        Me.EggsizeTextBox.Size = New System.Drawing.Size(164, 29)
        Me.EggsizeTextBox.TabIndex = 26
        '
        'Caviar_FishBindingNavigator
        '
        Me.Caviar_FishBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Caviar_FishBindingNavigator.BindingSource = Me.Caviar_FishBindingSource
        Me.Caviar_FishBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Caviar_FishBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Caviar_FishBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Caviar_FishBindingNavigatorSaveItem, Me.RefreshButton})
        Me.Caviar_FishBindingNavigator.Location = New System.Drawing.Point(3, 16)
        Me.Caviar_FishBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Caviar_FishBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Caviar_FishBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Caviar_FishBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Caviar_FishBindingNavigator.Name = "Caviar_FishBindingNavigator"
        Me.Caviar_FishBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Caviar_FishBindingNavigator.Size = New System.Drawing.Size(485, 25)
        Me.Caviar_FishBindingNavigator.TabIndex = 25
        Me.Caviar_FishBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorDeleteItem.Enabled = False
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
        'Caviar_FishBindingNavigatorSaveItem
        '
        Me.Caviar_FishBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Caviar_FishBindingNavigatorSaveItem.Image = CType(resources.GetObject("Caviar_FishBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Caviar_FishBindingNavigatorSaveItem.Name = "Caviar_FishBindingNavigatorSaveItem"
        Me.Caviar_FishBindingNavigatorSaveItem.Size = New System.Drawing.Size(87, 22)
        Me.Caviar_FishBindingNavigatorSaveItem.Text = "Fish Complete"
        '
        'RefreshButton
        '
        Me.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RefreshButton.Image = CType(resources.GetObject("RefreshButton.Image"), System.Drawing.Image)
        Me.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(50, 22)
        Me.RefreshButton.Text = "Refresh"
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
        Me.Caviar_FishDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn19, Me.SaltingStationCompletedColumn})
        Me.Caviar_FishDataGridView.DataSource = Me.Caviar_FishBindingSource
        Me.Caviar_FishDataGridView.Location = New System.Drawing.Point(3, 44)
        Me.Caviar_FishDataGridView.MultiSelect = False
        Me.Caviar_FishDataGridView.Name = "Caviar_FishDataGridView"
        Me.Caviar_FishDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Caviar_FishDataGridView.Size = New System.Drawing.Size(482, 281)
        Me.Caviar_FishDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tag"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tag"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Harvest Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Harvest Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Purge Tank"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Purge Tank"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Live Wt"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Live Weight"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Gutted Wt"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Gutted Weight"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Ovary Tot"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Ovary Weight"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Ovary Waste"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Ovary Waste"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Egg Wt"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Eggs Weight"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Salt"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Salt Added"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Cycled"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Cycled"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'SaltingStationCompletedColumn
        '
        Me.SaltingStationCompletedColumn.DataPropertyName = "SaltingStationCompleted"
        Me.SaltingStationCompletedColumn.HeaderText = "SaltingStationCompleted"
        Me.SaltingStationCompletedColumn.Name = "SaltingStationCompletedColumn"
        Me.SaltingStationCompletedColumn.ReadOnly = True
        '
        'ProductGroupBox
        '
        Me.ProductGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductGroupBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ProductGroupBox.Controls.Add(Me.Caviar_InventoryDataGridView)
        Me.ProductGroupBox.Controls.Add(Me.DifferenceTextBox)
        Me.ProductGroupBox.Controls.Add(Me.Label3)
        Me.ProductGroupBox.Controls.Add(Me.CaviarTotalTextBox)
        Me.ProductGroupBox.Controls.Add(Me.Label2)
        Me.ProductGroupBox.Controls.Add(Me.Caviar_InventoryBindingNavigator)
        Me.ProductGroupBox.Location = New System.Drawing.Point(2, -2)
        Me.ProductGroupBox.Name = "ProductGroupBox"
        Me.ProductGroupBox.Size = New System.Drawing.Size(375, 565)
        Me.ProductGroupBox.TabIndex = 23
        Me.ProductGroupBox.TabStop = False
        Me.ProductGroupBox.Text = "Container Information"
        '
        'Caviar_InventoryDataGridView
        '
        Me.Caviar_InventoryDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Caviar_InventoryDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Caviar_InventoryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Caviar_InventoryDataGridView.AutoGenerateColumns = False
        Me.Caviar_InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Caviar_InventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PKBarcodeColumn, Me.FKProductIDColumn, Me.InventoryStatusColumn, Me.CaviarInventoryNotesColumn, Me.DateStatusChanged, Me.PreviousStatus})
        Me.Caviar_InventoryDataGridView.DataSource = Me.Caviar_InventoryBindingSource
        Me.Caviar_InventoryDataGridView.Location = New System.Drawing.Point(6, 44)
        Me.Caviar_InventoryDataGridView.Name = "Caviar_InventoryDataGridView"
        Me.Caviar_InventoryDataGridView.Size = New System.Drawing.Size(367, 433)
        Me.Caviar_InventoryDataGridView.TabIndex = 20
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
        Me.FKProductIDColumn.HeaderText = "Product Code"
        Me.FKProductIDColumn.Name = "FKProductIDColumn"
        Me.FKProductIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FKProductIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FKProductIDColumn.ValueMember = "PKProductID"
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'InventoryStatusColumn
        '
        Me.InventoryStatusColumn.DataPropertyName = "InventoryStatus"
        Me.InventoryStatusColumn.DataSource = Me.CaviarStatusSelectionBindingSource
        Me.InventoryStatusColumn.DisplayMember = "Description"
        Me.InventoryStatusColumn.HeaderText = "Inventory Status"
        Me.InventoryStatusColumn.Name = "InventoryStatusColumn"
        Me.InventoryStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.InventoryStatusColumn.ValueMember = "PKStatusID"
        '
        'CaviarStatusSelectionBindingSource
        '
        Me.CaviarStatusSelectionBindingSource.DataMember = "CaviarStatusSelection"
        Me.CaviarStatusSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
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
        Me.DateStatusChanged.ReadOnly = True
        '
        'PreviousStatus
        '
        Me.PreviousStatus.DataPropertyName = "PreviousStatus"
        Me.PreviousStatus.DataSource = Me.CaviarStatusSelectionBindingSource
        Me.PreviousStatus.DisplayMember = "Description"
        Me.PreviousStatus.HeaderText = "Previous Status"
        Me.PreviousStatus.Name = "PreviousStatus"
        Me.PreviousStatus.ReadOnly = True
        Me.PreviousStatus.ValueMember = "PKStatusID"
        '
        'Caviar_InventoryBindingSource
        '
        Me.Caviar_InventoryBindingSource.DataMember = "Caviar FishCaviar Inventory"
        Me.Caviar_InventoryBindingSource.DataSource = Me.Caviar_FishBindingSource
        '
        'DifferenceTextBox
        '
        Me.DifferenceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DifferenceTextBox.Enabled = False
        Me.DifferenceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DifferenceTextBox.Location = New System.Drawing.Point(192, 516)
        Me.DifferenceTextBox.Name = "DifferenceTextBox"
        Me.DifferenceTextBox.Size = New System.Drawing.Size(101, 29)
        Me.DifferenceTextBox.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 515)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Over/Under Pack:"
        '
        'CaviarTotalTextBox
        '
        Me.CaviarTotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CaviarTotalTextBox.Enabled = False
        Me.CaviarTotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaviarTotalTextBox.Location = New System.Drawing.Point(192, 483)
        Me.CaviarTotalTextBox.Name = "CaviarTotalTextBox"
        Me.CaviarTotalTextBox.Size = New System.Drawing.Size(101, 29)
        Me.CaviarTotalTextBox.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 488)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Total Caviar Packed:"
        '
        'Caviar_InventoryBindingNavigator
        '
        Me.Caviar_InventoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.Caviar_InventoryBindingNavigator.BindingSource = Me.Caviar_InventoryBindingSource
        Me.Caviar_InventoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem1
        Me.Caviar_InventoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.Caviar_InventoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorDeleteItem1, Me.BindingNavigatorAddNewItem1, Me.PrintButton})
        Me.Caviar_InventoryBindingNavigator.Location = New System.Drawing.Point(3, 16)
        Me.Caviar_InventoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.Caviar_InventoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.Caviar_InventoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.Caviar_InventoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.Caviar_InventoryBindingNavigator.Name = "Caviar_InventoryBindingNavigator"
        Me.Caviar_InventoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem1
        Me.Caviar_InventoryBindingNavigator.Size = New System.Drawing.Size(369, 25)
        Me.Caviar_InventoryBindingNavigator.TabIndex = 16
        Me.Caviar_InventoryBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        Me.BindingNavigatorAddNewItem1.Visible = False
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Scan Barcode Here:"
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
        Me.TableAdapterManager.CaviarInventoryInvoiceFlatTableTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryValueTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Me.CaviarStatusSelectionTableAdapter
        Me.TableAdapterManager.ConcurrencyHandlerTableAdapter = Me.ConcurrencyHandlerTableAdapter
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
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.RepackLossTableAdapter = Nothing
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeightConversionConstantsTableAdapter = Nothing
        '
        'Caviar_InventoryTableAdapter
        '
        Me.Caviar_InventoryTableAdapter.ClearBeforeFill = True
        '
        'CaviarStatusSelectionTableAdapter
        '
        Me.CaviarStatusSelectionTableAdapter.ClearBeforeFill = True
        '
        'ConcurrencyHandlerTableAdapter
        '
        Me.ConcurrencyHandlerTableAdapter.ClearBeforeFill = True
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
        Me.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer.Location = New System.Drawing.Point(-1, 38)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.AutoScroll = True
        Me.SplitContainer.Panel1.Controls.Add(Me.FishGroupBox)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.ProductGroupBox)
        Me.SplitContainer.Size = New System.Drawing.Size(879, 565)
        Me.SplitContainer.SplitterDistance = 496
        Me.SplitContainer.TabIndex = 24
        '
        'ConcurrencyTimer
        '
        Me.ConcurrencyTimer.Enabled = True
        Me.ConcurrencyTimer.Interval = 1000
        '
        'PrintingPackingStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 604)
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BarcodeInput)
        Me.Name = "PrintingPackingStation"
        Me.Text = "Packing Station"
        Me.FishGroupBox.ResumeLayout(False)
        Me.FishGroupBox.PerformLayout()
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caviar_FishBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Caviar_FishBindingNavigator.ResumeLayout(False)
        Me.Caviar_FishBindingNavigator.PerformLayout()
        CType(Me.Caviar_FishDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductGroupBox.ResumeLayout(False)
        Me.ProductGroupBox.PerformLayout()
        CType(Me.Caviar_InventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caviar_InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caviar_InventoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Caviar_InventoryBindingNavigator.ResumeLayout(False)
        Me.Caviar_InventoryBindingNavigator.PerformLayout()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarcodeInput As System.Windows.Forms.TextBox
    Friend WithEvents FishGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ProductGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents Caviar_FishBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caviar_FishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Caviar_FishBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Caviar_FishBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Caviar_InventoryTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
    Friend WithEvents Caviar_InventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradeSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
    Friend WithEvents Caviar_InventoryBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents GradeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Egg_ColorTextBox As TabTextBox
    Friend WithEvents FirmnessTextBox As TabTextBox
    Friend WithEvents TasteTextBox As TabTextBox
    Friend WithEvents EggsizeTextBox As TabTextBox
    Friend WithEvents RefreshButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CompletedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CaviarTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DifferenceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Egg_WtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CaviarStatusSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarStatusSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
    Friend WithEvents Caviar_FishDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents Caviar_InventoryDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents Harvest_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents PrintButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PrintAllFishLabelsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSelectedLabelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConcurrencyHandlerTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ConcurrencyHandlerTableAdapter
    Friend WithEvents ConcurrencyTimer As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaltingStationCompletedColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PKBarcodeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKProductIDColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents InventoryStatusColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CaviarInventoryNotesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateStatusChanged As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreviousStatus As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
