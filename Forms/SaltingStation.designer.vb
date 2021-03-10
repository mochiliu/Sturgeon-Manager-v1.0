<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaltingStation
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
        Me.Caviar_FishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.Caviar_FishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.ConcurrencyHandlerTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ConcurrencyHandlerTableAdapter
        Me.ConcurrencyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Caviar_FishDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.TagColumn = New Microsoft.Samples.Windows.Forms.DataGridViewCustomColumn.MaskedTextBoxColumn
        Me.OvaryTotColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OvaryWasteColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CycledColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.EggWeightColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaltColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HarvestDateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SpeciesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PercentSaltColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caviar_FishDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.CaviarInventoryInvoiceFlatTableTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryValueTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Nothing
        Me.TableAdapterManager.ConcurrencyHandlerTableAdapter = Me.ConcurrencyHandlerTableAdapter
        Me.TableAdapterManager.Customer_PricingTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.FemaleFishInventoryTableAdapter = Nothing
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
        'ConcurrencyHandlerTableAdapter
        '
        Me.ConcurrencyHandlerTableAdapter.ClearBeforeFill = True
        '
        'ConcurrencyTimer
        '
        Me.ConcurrencyTimer.Interval = 1000
        '
        'Caviar_FishDataGridView
        '
        Me.Caviar_FishDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Caviar_FishDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Caviar_FishDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Caviar_FishDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Caviar_FishDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TagColumn, Me.OvaryTotColumn, Me.OvaryWasteColumn, Me.CycledColumn, Me.EggWeightColumn, Me.SaltColumn, Me.HarvestDateColumn, Me.SpeciesColumn, Me.NotesColumn, Me.PercentSaltColumn})
        Me.Caviar_FishDataGridView.DataSource = Me.Caviar_FishBindingSource
        Me.Caviar_FishDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Caviar_FishDataGridView.Name = "Caviar_FishDataGridView"
        Me.Caviar_FishDataGridView.Size = New System.Drawing.Size(1054, 549)
        Me.Caviar_FishDataGridView.TabIndex = 0
        Me.Caviar_FishDataGridView.TabStop = False
        '
        'TagColumn
        '
        Me.TagColumn.DataPropertyName = "Tag"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TagColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TagColumn.HeaderText = "Tag"
        Me.TagColumn.IncludeLiterals = False
        Me.TagColumn.IncludePrompt = False
        Me.TagColumn.Mask = Nothing
        Me.TagColumn.Name = "TagColumn"
        Me.TagColumn.PromptChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TagColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TagColumn.ValidatingType = Nothing
        '
        'OvaryTotColumn
        '
        Me.OvaryTotColumn.DataPropertyName = "Ovary Tot"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.OvaryTotColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.OvaryTotColumn.HeaderText = "Ovary Weight"
        Me.OvaryTotColumn.Name = "OvaryTotColumn"
        Me.OvaryTotColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'OvaryWasteColumn
        '
        Me.OvaryWasteColumn.DataPropertyName = "Ovary Waste"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.OvaryWasteColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.OvaryWasteColumn.HeaderText = "Ovary Waste"
        Me.OvaryWasteColumn.Name = "OvaryWasteColumn"
        Me.OvaryWasteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CycledColumn
        '
        Me.CycledColumn.DataPropertyName = "Cycled"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle5.NullValue = False
        Me.CycledColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.CycledColumn.HeaderText = "Cycled"
        Me.CycledColumn.Name = "CycledColumn"
        '
        'EggWeightColumn
        '
        Me.EggWeightColumn.DataPropertyName = "Egg Wt"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.EggWeightColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.EggWeightColumn.HeaderText = "Egg Weight"
        Me.EggWeightColumn.Name = "EggWeightColumn"
        Me.EggWeightColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SaltColumn
        '
        Me.SaltColumn.DataPropertyName = "Salt"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle7.Format = "N1"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.SaltColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.SaltColumn.HeaderText = "Salt"
        Me.SaltColumn.Name = "SaltColumn"
        Me.SaltColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'HarvestDateColumn
        '
        Me.HarvestDateColumn.DataPropertyName = "Harvest Date"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.HarvestDateColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.HarvestDateColumn.HeaderText = "Process Date"
        Me.HarvestDateColumn.Name = "HarvestDateColumn"
        Me.HarvestDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SpeciesColumn
        '
        Me.SpeciesColumn.DataPropertyName = "Species"
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SpeciesColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.SpeciesColumn.HeaderText = "Species"
        Me.SpeciesColumn.Name = "SpeciesColumn"
        Me.SpeciesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'NotesColumn
        '
        Me.NotesColumn.DataPropertyName = "Notes"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NotesColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.NotesColumn.HeaderText = "Notes"
        Me.NotesColumn.Name = "NotesColumn"
        Me.NotesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PercentSaltColumn
        '
        Me.PercentSaltColumn.DataPropertyName = "PercentSalt"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle11.Format = "N1"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.PercentSaltColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.PercentSaltColumn.HeaderText = "Percent Salt"
        Me.PercentSaltColumn.Name = "PercentSaltColumn"
        Me.PercentSaltColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SaltingStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 573)
        Me.Controls.Add(Me.Caviar_FishDataGridView)
        Me.MaximizeBox = False
        Me.Name = "SaltingStation"
        Me.Text = "Salting Station"
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caviar_FishDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents Caviar_FishBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caviar_FishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Caviar_FishDataGridView As MyDataGridView
    Friend WithEvents ConcurrencyHandlerTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ConcurrencyHandlerTableAdapter
    Friend WithEvents ConcurrencyTimer As System.Windows.Forms.Timer
    Friend WithEvents TagColumn As Microsoft.Samples.Windows.Forms.DataGridViewCustomColumn.MaskedTextBoxColumn
    Friend WithEvents OvaryTotColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OvaryWasteColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CycledColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EggWeightColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaltColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HarvestDateColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpeciesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PercentSaltColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
