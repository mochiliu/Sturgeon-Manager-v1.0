<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCaviarInvoice
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
        Dim PKInvoiceIDLabel As System.Windows.Forms.Label
        Dim FKCustomerIDLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim PO_NumberLabel As System.Windows.Forms.Label
        Dim BoxesLabel As System.Windows.Forms.Label
        Dim FKShippingAddressIDLabel As System.Windows.Forms.Label
        Dim Shipping_NotesLabel As System.Windows.Forms.Label
        Dim FKBillingAddressIDLabel As System.Windows.Forms.Label
        Dim InvoiceTypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewCaviarInvoice))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoicesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoicesTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.Billing_AddressesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Billing_AddressesTableAdapter
        Me.Caviar_FishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
        Me.Caviar_InventoryTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
        Me.CaviarStatusSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
        Me.Customer_PricingTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Customer_PricingTableAdapter
        Me.CustomersTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CustomersTableAdapter
        Me.GradeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
        Me.InvoiceTypeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoiceTypeSelectionTableAdapter
        Me.Non_Inventory_Invoice_RecordsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Non_Inventory_Invoice_RecordsTableAdapter
        Me.ProductCategorySelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductCategorySelectionTableAdapter
        Me.ProductsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
        Me.Shipping_AddressesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Shipping_AddressesTableAdapter
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersShippingAddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.InvoiceTypeComboBox = New System.Windows.Forms.ComboBox
        Me.InvoiceTypeSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddShippingAddressButton = New System.Windows.Forms.Button
        Me.AddBillingAddressButton = New System.Windows.Forms.Button
        Me.AddCustomerButton = New System.Windows.Forms.Button
        Me.FKBillingAddressIDComboBox = New Sturgeon_Manager_v1._0.Controls.AutoDropDownWidthComboBox
        Me.CustomersBillingAddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceInformationCompleteButton = New System.Windows.Forms.Button
        Me.InvoicesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.InvoicesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FKShippingAddressIDComboBox = New Sturgeon_Manager_v1._0.Controls.AutoDropDownWidthComboBox
        Me.Shipping_NotesTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.PKInvoiceIDTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.FKCustomerIDComboBox = New Sturgeon_Manager_v1._0.Controls.AutoDropDownWidthComboBox
        Me.DateMyDateTimePicker = New Sturgeon_Manager_v1._0.Controls.MyDateTimePicker
        Me.BoxesTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.PO_NumberTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.TotalTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CompleteInvoiceButton = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CaviarDetailsSplitContainer = New System.Windows.Forms.SplitContainer
        Me.NewBoxButton = New System.Windows.Forms.Button
        Me.BoxNameComboBox = New System.Windows.Forms.ComboBox
        Me.Caviar_InventoryDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaviarStatusSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Caviar_FishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Caviar_InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarcodeTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CaviarOrderDisplayDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.BoxNameCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductNameCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CountCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceSoldAtCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalKgsCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTotalCaviarOrderDisplayColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaviarInformationCompleteButton = New System.Windows.Forms.Button
        Me.CaviarSubtotalTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GradeSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SavePreviewButton = New System.Windows.Forms.Button
        Me.BackToCaviarButton = New System.Windows.Forms.Button
        Me.OthersSubtotalTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Non_Inventory_Invoice_RecordsDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.FKProductIDNonInventory = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.NonInventoryProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuantityNonInventory = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceSoldAtNonInventory = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotesNonInventory = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Non_Inventory_Invoice_RecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_PricingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductCategorySelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer
        Me.SampleColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PKBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderOnInvoice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKProductID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.InventoryStatus = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.FKFishID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewComboBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewComboBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CaviarNotes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PackingBoxNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceSoldAt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKInvoiceID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateStatusChanged = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PreviousStatus = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.PricePerItem = New System.Windows.Forms.DataGridViewTextBoxColumn
        PKInvoiceIDLabel = New System.Windows.Forms.Label
        FKCustomerIDLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        PO_NumberLabel = New System.Windows.Forms.Label
        BoxesLabel = New System.Windows.Forms.Label
        FKShippingAddressIDLabel = New System.Windows.Forms.Label
        Shipping_NotesLabel = New System.Windows.Forms.Label
        FKBillingAddressIDLabel = New System.Windows.Forms.Label
        InvoiceTypeLabel = New System.Windows.Forms.Label
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersShippingAddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InvoiceTypeSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBillingAddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoicesBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.CaviarDetailsSplitContainer.Panel1.SuspendLayout()
        Me.CaviarDetailsSplitContainer.Panel2.SuspendLayout()
        Me.CaviarDetailsSplitContainer.SuspendLayout()
        CType(Me.Caviar_InventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caviar_InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarOrderDisplayDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Non_Inventory_Invoice_RecordsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NonInventoryProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Non_Inventory_Invoice_RecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_PricingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCategorySelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer.Panel1.SuspendLayout()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PKInvoiceIDLabel
        '
        PKInvoiceIDLabel.AutoSize = True
        PKInvoiceIDLabel.Location = New System.Drawing.Point(19, 41)
        PKInvoiceIDLabel.Name = "PKInvoiceIDLabel"
        PKInvoiceIDLabel.Size = New System.Drawing.Size(85, 13)
        PKInvoiceIDLabel.TabIndex = 1
        PKInvoiceIDLabel.Text = "Invoice Number:"
        '
        'FKCustomerIDLabel
        '
        FKCustomerIDLabel.AutoSize = True
        FKCustomerIDLabel.Location = New System.Drawing.Point(19, 67)
        FKCustomerIDLabel.Name = "FKCustomerIDLabel"
        FKCustomerIDLabel.Size = New System.Drawing.Size(54, 13)
        FKCustomerIDLabel.TabIndex = 3
        FKCustomerIDLabel.Text = "Customer:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(19, 95)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(71, 13)
        DateLabel.TabIndex = 5
        DateLabel.Text = "Invoice Date:"
        '
        'PO_NumberLabel
        '
        PO_NumberLabel.AutoSize = True
        PO_NumberLabel.Location = New System.Drawing.Point(19, 120)
        PO_NumberLabel.Name = "PO_NumberLabel"
        PO_NumberLabel.Size = New System.Drawing.Size(65, 13)
        PO_NumberLabel.TabIndex = 7
        PO_NumberLabel.Text = "PO Number:"
        '
        'BoxesLabel
        '
        BoxesLabel.AutoSize = True
        BoxesLabel.Location = New System.Drawing.Point(19, 146)
        BoxesLabel.Name = "BoxesLabel"
        BoxesLabel.Size = New System.Drawing.Size(39, 13)
        BoxesLabel.TabIndex = 9
        BoxesLabel.Text = "Boxes:"
        '
        'FKShippingAddressIDLabel
        '
        FKShippingAddressIDLabel.AutoSize = True
        FKShippingAddressIDLabel.Location = New System.Drawing.Point(19, 199)
        FKShippingAddressIDLabel.Name = "FKShippingAddressIDLabel"
        FKShippingAddressIDLabel.Size = New System.Drawing.Size(92, 13)
        FKShippingAddressIDLabel.TabIndex = 13
        FKShippingAddressIDLabel.Text = "Shipping Address:"
        '
        'Shipping_NotesLabel
        '
        Shipping_NotesLabel.AutoSize = True
        Shipping_NotesLabel.Location = New System.Drawing.Point(19, 226)
        Shipping_NotesLabel.Name = "Shipping_NotesLabel"
        Shipping_NotesLabel.Size = New System.Drawing.Size(82, 13)
        Shipping_NotesLabel.TabIndex = 15
        Shipping_NotesLabel.Text = "Shipping Notes:"
        '
        'FKBillingAddressIDLabel
        '
        FKBillingAddressIDLabel.AutoSize = True
        FKBillingAddressIDLabel.Location = New System.Drawing.Point(19, 172)
        FKBillingAddressIDLabel.Name = "FKBillingAddressIDLabel"
        FKBillingAddressIDLabel.Size = New System.Drawing.Size(78, 13)
        FKBillingAddressIDLabel.TabIndex = 28
        FKBillingAddressIDLabel.Text = "Billing Address:"
        '
        'InvoiceTypeLabel
        '
        InvoiceTypeLabel.AutoSize = True
        InvoiceTypeLabel.Location = New System.Drawing.Point(19, 252)
        InvoiceTypeLabel.Name = "InvoiceTypeLabel"
        InvoiceTypeLabel.Size = New System.Drawing.Size(72, 13)
        InvoiceTypeLabel.TabIndex = 32
        InvoiceTypeLabel.Text = "Invoice Type:"
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "Invoices"
        Me.InvoicesBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Application_SettingsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Me.Billing_AddressesTableAdapter
        Me.TableAdapterManager.Caviar_FishTableAdapter = Me.Caviar_FishTableAdapter
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Me.Caviar_InventoryTableAdapter
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Me.CaviarStatusSelectionTableAdapter
        Me.TableAdapterManager.Customer_PricingTableAdapter = Me.Customer_PricingTableAdapter
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.FilterColumnsTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Me.GradeSelectionTableAdapter
        Me.TableAdapterManager.InvoicesTableAdapter = Me.InvoicesTableAdapter
        Me.TableAdapterManager.InvoiceTypeSelectionTableAdapter = Me.InvoiceTypeSelectionTableAdapter
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Me.Non_Inventory_Invoice_RecordsTableAdapter
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Me.ProductCategorySelectionTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Me.Shipping_AddressesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Billing_AddressesTableAdapter
        '
        Me.Billing_AddressesTableAdapter.ClearBeforeFill = True
        '
        'Caviar_FishTableAdapter
        '
        Me.Caviar_FishTableAdapter.ClearBeforeFill = True
        '
        'Caviar_InventoryTableAdapter
        '
        Me.Caviar_InventoryTableAdapter.ClearBeforeFill = True
        '
        'CaviarStatusSelectionTableAdapter
        '
        Me.CaviarStatusSelectionTableAdapter.ClearBeforeFill = True
        '
        'Customer_PricingTableAdapter
        '
        Me.Customer_PricingTableAdapter.ClearBeforeFill = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'GradeSelectionTableAdapter
        '
        Me.GradeSelectionTableAdapter.ClearBeforeFill = True
        '
        'InvoiceTypeSelectionTableAdapter
        '
        Me.InvoiceTypeSelectionTableAdapter.ClearBeforeFill = True
        '
        'Non_Inventory_Invoice_RecordsTableAdapter
        '
        Me.Non_Inventory_Invoice_RecordsTableAdapter.ClearBeforeFill = True
        '
        'ProductCategorySelectionTableAdapter
        '
        Me.ProductCategorySelectionTableAdapter.ClearBeforeFill = True
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'Shipping_AddressesTableAdapter
        '
        Me.Shipping_AddressesTableAdapter.ClearBeforeFill = True
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'CustomersShippingAddressesBindingSource
        '
        Me.CustomersShippingAddressesBindingSource.DataMember = "CustomersShipping Addresses"
        Me.CustomersShippingAddressesBindingSource.DataSource = Me.CustomersBindingSource
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(InvoiceTypeLabel)
        Me.GroupBox1.Controls.Add(Me.InvoiceTypeComboBox)
        Me.GroupBox1.Controls.Add(Me.AddShippingAddressButton)
        Me.GroupBox1.Controls.Add(Me.AddBillingAddressButton)
        Me.GroupBox1.Controls.Add(Me.AddCustomerButton)
        Me.GroupBox1.Controls.Add(FKBillingAddressIDLabel)
        Me.GroupBox1.Controls.Add(Me.FKBillingAddressIDComboBox)
        Me.GroupBox1.Controls.Add(Me.InvoiceInformationCompleteButton)
        Me.GroupBox1.Controls.Add(Me.InvoicesBindingNavigator)
        Me.GroupBox1.Controls.Add(Me.FKShippingAddressIDComboBox)
        Me.GroupBox1.Controls.Add(PKInvoiceIDLabel)
        Me.GroupBox1.Controls.Add(Me.Shipping_NotesTextBox)
        Me.GroupBox1.Controls.Add(Me.PKInvoiceIDTextBox)
        Me.GroupBox1.Controls.Add(Shipping_NotesLabel)
        Me.GroupBox1.Controls.Add(FKCustomerIDLabel)
        Me.GroupBox1.Controls.Add(FKShippingAddressIDLabel)
        Me.GroupBox1.Controls.Add(Me.FKCustomerIDComboBox)
        Me.GroupBox1.Controls.Add(DateLabel)
        Me.GroupBox1.Controls.Add(Me.DateMyDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.BoxesTextBox)
        Me.GroupBox1.Controls.Add(PO_NumberLabel)
        Me.GroupBox1.Controls.Add(BoxesLabel)
        Me.GroupBox1.Controls.Add(Me.PO_NumberTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 599)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoice Information (Step 1)"
        '
        'InvoiceTypeComboBox
        '
        Me.InvoiceTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InvoicesBindingSource, "InvoiceType", True))
        Me.InvoiceTypeComboBox.DataSource = Me.InvoiceTypeSelectionBindingSource
        Me.InvoiceTypeComboBox.DisplayMember = "Description"
        Me.InvoiceTypeComboBox.Enabled = False
        Me.InvoiceTypeComboBox.FormattingEnabled = True
        Me.InvoiceTypeComboBox.Location = New System.Drawing.Point(113, 249)
        Me.InvoiceTypeComboBox.Name = "InvoiceTypeComboBox"
        Me.InvoiceTypeComboBox.Size = New System.Drawing.Size(152, 21)
        Me.InvoiceTypeComboBox.TabIndex = 33
        Me.InvoiceTypeComboBox.TabStop = False
        Me.InvoiceTypeComboBox.ValueMember = "PKTypeID"
        '
        'InvoiceTypeSelectionBindingSource
        '
        Me.InvoiceTypeSelectionBindingSource.DataMember = "InvoiceTypeSelection"
        Me.InvoiceTypeSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'AddShippingAddressButton
        '
        Me.AddShippingAddressButton.Location = New System.Drawing.Point(223, 196)
        Me.AddShippingAddressButton.Name = "AddShippingAddressButton"
        Me.AddShippingAddressButton.Size = New System.Drawing.Size(42, 21)
        Me.AddShippingAddressButton.TabIndex = 32
        Me.AddShippingAddressButton.Text = "Add"
        Me.AddShippingAddressButton.UseVisualStyleBackColor = True
        '
        'AddBillingAddressButton
        '
        Me.AddBillingAddressButton.Location = New System.Drawing.Point(223, 169)
        Me.AddBillingAddressButton.Name = "AddBillingAddressButton"
        Me.AddBillingAddressButton.Size = New System.Drawing.Size(42, 21)
        Me.AddBillingAddressButton.TabIndex = 31
        Me.AddBillingAddressButton.Text = "Add"
        Me.AddBillingAddressButton.UseVisualStyleBackColor = True
        '
        'AddCustomerButton
        '
        Me.AddCustomerButton.Location = New System.Drawing.Point(223, 63)
        Me.AddCustomerButton.Name = "AddCustomerButton"
        Me.AddCustomerButton.Size = New System.Drawing.Size(42, 22)
        Me.AddCustomerButton.TabIndex = 30
        Me.AddCustomerButton.TabStop = False
        Me.AddCustomerButton.Text = "Add"
        Me.AddCustomerButton.UseVisualStyleBackColor = True
        '
        'FKBillingAddressIDComboBox
        '
        Me.FKBillingAddressIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InvoicesBindingSource, "FKBillingAddressID", True))
        Me.FKBillingAddressIDComboBox.DataSource = Me.CustomersBillingAddressesBindingSource
        Me.FKBillingAddressIDComboBox.DisplayMember = "FullAddress"
        Me.FKBillingAddressIDComboBox.DropDownWidth = 104
        Me.FKBillingAddressIDComboBox.FormattingEnabled = True
        Me.FKBillingAddressIDComboBox.Location = New System.Drawing.Point(113, 169)
        Me.FKBillingAddressIDComboBox.Name = "FKBillingAddressIDComboBox"
        Me.FKBillingAddressIDComboBox.Size = New System.Drawing.Size(104, 21)
        Me.FKBillingAddressIDComboBox.TabIndex = 7
        Me.FKBillingAddressIDComboBox.ValueMember = "BillingAddressID"
        '
        'CustomersBillingAddressesBindingSource
        '
        Me.CustomersBillingAddressesBindingSource.DataMember = "CustomersBilling Addresses"
        Me.CustomersBillingAddressesBindingSource.DataSource = Me.CustomersBindingSource
        '
        'InvoiceInformationCompleteButton
        '
        Me.InvoiceInformationCompleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InvoiceInformationCompleteButton.Location = New System.Drawing.Point(80, 555)
        Me.InvoiceInformationCompleteButton.Name = "InvoiceInformationCompleteButton"
        Me.InvoiceInformationCompleteButton.Size = New System.Drawing.Size(116, 38)
        Me.InvoiceInformationCompleteButton.TabIndex = 10
        Me.InvoiceInformationCompleteButton.Text = "Confirm Information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Continue to Step 2)"
        Me.InvoiceInformationCompleteButton.UseVisualStyleBackColor = True
        '
        'InvoicesBindingNavigator
        '
        Me.InvoicesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InvoicesBindingNavigator.BindingSource = Me.InvoicesBindingSource
        Me.InvoicesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InvoicesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InvoicesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InvoicesBindingNavigatorSaveItem})
        Me.InvoicesBindingNavigator.Location = New System.Drawing.Point(3, 16)
        Me.InvoicesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InvoicesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InvoicesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InvoicesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InvoicesBindingNavigator.Name = "InvoicesBindingNavigator"
        Me.InvoicesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InvoicesBindingNavigator.Size = New System.Drawing.Size(303, 25)
        Me.InvoicesBindingNavigator.TabIndex = 17
        Me.InvoicesBindingNavigator.Text = "BindingNavigator1"
        Me.InvoicesBindingNavigator.Visible = False
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
        'InvoicesBindingNavigatorSaveItem
        '
        Me.InvoicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InvoicesBindingNavigatorSaveItem.Image = CType(resources.GetObject("InvoicesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InvoicesBindingNavigatorSaveItem.Name = "InvoicesBindingNavigatorSaveItem"
        Me.InvoicesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InvoicesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FKShippingAddressIDComboBox
        '
        Me.FKShippingAddressIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InvoicesBindingSource, "FKShippingAddressID", True))
        Me.FKShippingAddressIDComboBox.DataSource = Me.CustomersShippingAddressesBindingSource
        Me.FKShippingAddressIDComboBox.DisplayMember = "FullAddress"
        Me.FKShippingAddressIDComboBox.FormattingEnabled = True
        Me.FKShippingAddressIDComboBox.Location = New System.Drawing.Point(113, 196)
        Me.FKShippingAddressIDComboBox.Name = "FKShippingAddressIDComboBox"
        Me.FKShippingAddressIDComboBox.Size = New System.Drawing.Size(104, 21)
        Me.FKShippingAddressIDComboBox.TabIndex = 8
        Me.FKShippingAddressIDComboBox.ValueMember = "ShippingAddressID"
        '
        'Shipping_NotesTextBox
        '
        Me.Shipping_NotesTextBox.AutoCompleteCustomSource.AddRange(New String() {"Customer Will Pick up at MAP", "Via Refrigerated Express"})
        Me.Shipping_NotesTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Shipping_NotesTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Shipping_NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Shipping Notes", True))
        Me.Shipping_NotesTextBox.Location = New System.Drawing.Point(113, 223)
        Me.Shipping_NotesTextBox.Name = "Shipping_NotesTextBox"
        Me.Shipping_NotesTextBox.Size = New System.Drawing.Size(152, 20)
        Me.Shipping_NotesTextBox.TabIndex = 9
        '
        'PKInvoiceIDTextBox
        '
        Me.PKInvoiceIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "PKInvoiceID", True))
        Me.PKInvoiceIDTextBox.Location = New System.Drawing.Point(113, 38)
        Me.PKInvoiceIDTextBox.Name = "PKInvoiceIDTextBox"
        Me.PKInvoiceIDTextBox.Size = New System.Drawing.Size(152, 20)
        Me.PKInvoiceIDTextBox.TabIndex = 2
        '
        'FKCustomerIDComboBox
        '
        Me.FKCustomerIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.FKCustomerIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FKCustomerIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InvoicesBindingSource, "FKCustomerID", True))
        Me.FKCustomerIDComboBox.DataSource = Me.CustomersBindingSource
        Me.FKCustomerIDComboBox.DisplayMember = "Company Name"
        Me.FKCustomerIDComboBox.FormattingEnabled = True
        Me.FKCustomerIDComboBox.Location = New System.Drawing.Point(113, 64)
        Me.FKCustomerIDComboBox.Name = "FKCustomerIDComboBox"
        Me.FKCustomerIDComboBox.Size = New System.Drawing.Size(104, 21)
        Me.FKCustomerIDComboBox.TabIndex = 3
        Me.FKCustomerIDComboBox.ValueMember = "PKCustomerID"
        '
        'DateMyDateTimePicker
        '
        Me.DateMyDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoicesBindingSource, "Date", True))
        Me.DateMyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateMyDateTimePicker.Location = New System.Drawing.Point(113, 91)
        Me.DateMyDateTimePicker.Name = "DateMyDateTimePicker"
        Me.DateMyDateTimePicker.Size = New System.Drawing.Size(152, 20)
        Me.DateMyDateTimePicker.TabIndex = 4
        '
        'BoxesTextBox
        '
        Me.BoxesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Boxes", True))
        Me.BoxesTextBox.Enabled = False
        Me.BoxesTextBox.Location = New System.Drawing.Point(113, 143)
        Me.BoxesTextBox.Name = "BoxesTextBox"
        Me.BoxesTextBox.Size = New System.Drawing.Size(152, 20)
        Me.BoxesTextBox.TabIndex = 6
        Me.BoxesTextBox.TabStop = False
        '
        'PO_NumberTextBox
        '
        Me.PO_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "PO Number", True))
        Me.PO_NumberTextBox.Location = New System.Drawing.Point(113, 117)
        Me.PO_NumberTextBox.Name = "PO_NumberTextBox"
        Me.PO_NumberTextBox.Size = New System.Drawing.Size(152, 20)
        Me.PO_NumberTextBox.TabIndex = 5
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(134, 515)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(109, 20)
        Me.TotalTextBox.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 518)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Invoice Total:"
        '
        'CompleteInvoiceButton
        '
        Me.CompleteInvoiceButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CompleteInvoiceButton.Enabled = False
        Me.CompleteInvoiceButton.Location = New System.Drawing.Point(220, 550)
        Me.CompleteInvoiceButton.Name = "CompleteInvoiceButton"
        Me.CompleteInvoiceButton.Size = New System.Drawing.Size(98, 38)
        Me.CompleteInvoiceButton.TabIndex = 30
        Me.CompleteInvoiceButton.Text = "Complete Invoice"
        Me.CompleteInvoiceButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CaviarDetailsSplitContainer)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 597)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Caviar Details (Step 2)"
        '
        'CaviarDetailsSplitContainer
        '
        Me.CaviarDetailsSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaviarDetailsSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CaviarDetailsSplitContainer.Location = New System.Drawing.Point(0, 19)
        Me.CaviarDetailsSplitContainer.Name = "CaviarDetailsSplitContainer"
        Me.CaviarDetailsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'CaviarDetailsSplitContainer.Panel1
        '
        Me.CaviarDetailsSplitContainer.Panel1.Controls.Add(Me.NewBoxButton)
        Me.CaviarDetailsSplitContainer.Panel1.Controls.Add(Me.BoxNameComboBox)
        Me.CaviarDetailsSplitContainer.Panel1.Controls.Add(Me.Caviar_InventoryDataGridView)
        Me.CaviarDetailsSplitContainer.Panel1.Controls.Add(Me.BarcodeTextBox)
        Me.CaviarDetailsSplitContainer.Panel1.Controls.Add(Me.Label1)
        Me.CaviarDetailsSplitContainer.Panel1.Controls.Add(Me.Label2)
        Me.CaviarDetailsSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'CaviarDetailsSplitContainer.Panel2
        '
        Me.CaviarDetailsSplitContainer.Panel2.Controls.Add(Me.CaviarOrderDisplayDataGridView)
        Me.CaviarDetailsSplitContainer.Panel2.Controls.Add(Me.CaviarInformationCompleteButton)
        Me.CaviarDetailsSplitContainer.Panel2.Controls.Add(Me.CaviarSubtotalTextBox)
        Me.CaviarDetailsSplitContainer.Panel2.Controls.Add(Me.Label3)
        Me.CaviarDetailsSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CaviarDetailsSplitContainer.Size = New System.Drawing.Size(359, 578)
        Me.CaviarDetailsSplitContainer.SplitterDistance = 289
        Me.CaviarDetailsSplitContainer.TabIndex = 34
        '
        'NewBoxButton
        '
        Me.NewBoxButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewBoxButton.Enabled = False
        Me.NewBoxButton.Location = New System.Drawing.Point(279, 15)
        Me.NewBoxButton.Name = "NewBoxButton"
        Me.NewBoxButton.Size = New System.Drawing.Size(72, 21)
        Me.NewBoxButton.TabIndex = 35
        Me.NewBoxButton.Text = "New Box"
        Me.NewBoxButton.UseVisualStyleBackColor = True
        '
        'BoxNameComboBox
        '
        Me.BoxNameComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoxNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoxNameComboBox.Enabled = False
        Me.BoxNameComboBox.FormattingEnabled = True
        Me.BoxNameComboBox.Location = New System.Drawing.Point(116, 15)
        Me.BoxNameComboBox.Name = "BoxNameComboBox"
        Me.BoxNameComboBox.Size = New System.Drawing.Size(157, 21)
        Me.BoxNameComboBox.TabIndex = 34
        '
        'Caviar_InventoryDataGridView
        '
        Me.Caviar_InventoryDataGridView.AllowUserToAddRows = False
        Me.Caviar_InventoryDataGridView.AllowUserToDeleteRows = False
        Me.Caviar_InventoryDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Caviar_InventoryDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Caviar_InventoryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Caviar_InventoryDataGridView.AutoGenerateColumns = False
        Me.Caviar_InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Caviar_InventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SampleColumn, Me.PKBarcode, Me.OrderOnInvoice, Me.FKProductID, Me.InventoryStatus, Me.FKFishID, Me.DataGridViewComboBoxColumn1, Me.DataGridViewComboBoxColumn2, Me.DataGridViewComboBoxColumn3, Me.DataGridViewComboBoxColumn4, Me.CaviarNotes, Me.PackingBoxNumber, Me.PriceSoldAt, Me.FKInvoiceID, Me.DateStatusChanged, Me.PreviousStatus, Me.PricePerItem})
        Me.Caviar_InventoryDataGridView.DataSource = Me.Caviar_InventoryBindingSource
        Me.Caviar_InventoryDataGridView.Enabled = False
        Me.Caviar_InventoryDataGridView.Location = New System.Drawing.Point(0, 70)
        Me.Caviar_InventoryDataGridView.MultiSelect = False
        Me.Caviar_InventoryDataGridView.Name = "Caviar_InventoryDataGridView"
        Me.Caviar_InventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Caviar_InventoryDataGridView.Size = New System.Drawing.Size(355, 212)
        Me.Caviar_InventoryDataGridView.TabIndex = 18
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
        'Caviar_FishBindingSource
        '
        Me.Caviar_FishBindingSource.DataMember = "Caviar Fish"
        Me.Caviar_FishBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'Caviar_InventoryBindingSource
        '
        Me.Caviar_InventoryBindingSource.DataMember = "Caviar Inventory"
        Me.Caviar_InventoryBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'BarcodeTextBox
        '
        Me.BarcodeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BarcodeTextBox.Enabled = False
        Me.BarcodeTextBox.Location = New System.Drawing.Point(116, 41)
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.Size = New System.Drawing.Size(235, 20)
        Me.BarcodeTextBox.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Scan Barcode Here:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Box Name:"
        '
        'CaviarOrderDisplayDataGridView
        '
        Me.CaviarOrderDisplayDataGridView.AllowUserToAddRows = False
        Me.CaviarOrderDisplayDataGridView.AllowUserToDeleteRows = False
        Me.CaviarOrderDisplayDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CaviarOrderDisplayDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.CaviarOrderDisplayDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaviarOrderDisplayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CaviarOrderDisplayDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BoxNameCaviarOrderDisplayColumn, Me.ProductNameCaviarOrderDisplayColumn, Me.CountCaviarOrderDisplayColumn, Me.PriceSoldAtCaviarOrderDisplayColumn, Me.TotalKgsCaviarOrderDisplayColumn, Me.SubTotalCaviarOrderDisplayColumn})
        Me.CaviarOrderDisplayDataGridView.Location = New System.Drawing.Point(0, 1)
        Me.CaviarOrderDisplayDataGridView.Name = "CaviarOrderDisplayDataGridView"
        Me.CaviarOrderDisplayDataGridView.ReadOnly = True
        Me.CaviarOrderDisplayDataGridView.Size = New System.Drawing.Size(357, 233)
        Me.CaviarOrderDisplayDataGridView.TabIndex = 26
        '
        'BoxNameCaviarOrderDisplayColumn
        '
        Me.BoxNameCaviarOrderDisplayColumn.HeaderText = "Box Name"
        Me.BoxNameCaviarOrderDisplayColumn.Name = "BoxNameCaviarOrderDisplayColumn"
        Me.BoxNameCaviarOrderDisplayColumn.ReadOnly = True
        Me.BoxNameCaviarOrderDisplayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ProductNameCaviarOrderDisplayColumn
        '
        Me.ProductNameCaviarOrderDisplayColumn.HeaderText = "Product Code"
        Me.ProductNameCaviarOrderDisplayColumn.Name = "ProductNameCaviarOrderDisplayColumn"
        Me.ProductNameCaviarOrderDisplayColumn.ReadOnly = True
        Me.ProductNameCaviarOrderDisplayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CountCaviarOrderDisplayColumn
        '
        Me.CountCaviarOrderDisplayColumn.HeaderText = "Count"
        Me.CountCaviarOrderDisplayColumn.Name = "CountCaviarOrderDisplayColumn"
        Me.CountCaviarOrderDisplayColumn.ReadOnly = True
        Me.CountCaviarOrderDisplayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PriceSoldAtCaviarOrderDisplayColumn
        '
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.PriceSoldAtCaviarOrderDisplayColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PriceSoldAtCaviarOrderDisplayColumn.HeaderText = "Price Per Kg"
        Me.PriceSoldAtCaviarOrderDisplayColumn.Name = "PriceSoldAtCaviarOrderDisplayColumn"
        Me.PriceSoldAtCaviarOrderDisplayColumn.ReadOnly = True
        Me.PriceSoldAtCaviarOrderDisplayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TotalKgsCaviarOrderDisplayColumn
        '
        Me.TotalKgsCaviarOrderDisplayColumn.HeaderText = "Total Kgs"
        Me.TotalKgsCaviarOrderDisplayColumn.Name = "TotalKgsCaviarOrderDisplayColumn"
        Me.TotalKgsCaviarOrderDisplayColumn.ReadOnly = True
        Me.TotalKgsCaviarOrderDisplayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SubTotalCaviarOrderDisplayColumn
        '
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.SubTotalCaviarOrderDisplayColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.SubTotalCaviarOrderDisplayColumn.HeaderText = "Sub Total"
        Me.SubTotalCaviarOrderDisplayColumn.Name = "SubTotalCaviarOrderDisplayColumn"
        Me.SubTotalCaviarOrderDisplayColumn.ReadOnly = True
        Me.SubTotalCaviarOrderDisplayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CaviarInformationCompleteButton
        '
        Me.CaviarInformationCompleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaviarInformationCompleteButton.Enabled = False
        Me.CaviarInformationCompleteButton.Location = New System.Drawing.Point(203, 240)
        Me.CaviarInformationCompleteButton.Name = "CaviarInformationCompleteButton"
        Me.CaviarInformationCompleteButton.Size = New System.Drawing.Size(148, 38)
        Me.CaviarInformationCompleteButton.TabIndex = 33
        Me.CaviarInformationCompleteButton.Text = "Confirm Caviar Information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Continue to Step 3)"
        Me.CaviarInformationCompleteButton.UseVisualStyleBackColor = True
        '
        'CaviarSubtotalTextBox
        '
        Me.CaviarSubtotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CaviarSubtotalTextBox.Location = New System.Drawing.Point(96, 250)
        Me.CaviarSubtotalTextBox.Name = "CaviarSubtotalTextBox"
        Me.CaviarSubtotalTextBox.ReadOnly = True
        Me.CaviarSubtotalTextBox.Size = New System.Drawing.Size(93, 20)
        Me.CaviarSubtotalTextBox.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Caviar Subtotal:"
        '
        'GradeSelectionBindingSource
        '
        Me.GradeSelectionBindingSource.DataMember = "GradeSelection"
        Me.GradeSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.SavePreviewButton)
        Me.GroupBox3.Controls.Add(Me.BackToCaviarButton)
        Me.GroupBox3.Controls.Add(Me.CompleteInvoiceButton)
        Me.GroupBox3.Controls.Add(Me.OthersSubtotalTextBox)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Non_Inventory_Invoice_RecordsDataGridView)
        Me.GroupBox3.Controls.Add(Me.TotalTextBox)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(332, 594)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Additional Costs  (Step3)"
        '
        'SavePreviewButton
        '
        Me.SavePreviewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SavePreviewButton.Enabled = False
        Me.SavePreviewButton.Location = New System.Drawing.Point(116, 550)
        Me.SavePreviewButton.Name = "SavePreviewButton"
        Me.SavePreviewButton.Size = New System.Drawing.Size(98, 38)
        Me.SavePreviewButton.TabIndex = 35
        Me.SavePreviewButton.Text = "Save and View Invoice"
        Me.SavePreviewButton.UseVisualStyleBackColor = True
        '
        'BackToCaviarButton
        '
        Me.BackToCaviarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackToCaviarButton.Enabled = False
        Me.BackToCaviarButton.Location = New System.Drawing.Point(15, 550)
        Me.BackToCaviarButton.Name = "BackToCaviarButton"
        Me.BackToCaviarButton.Size = New System.Drawing.Size(95, 38)
        Me.BackToCaviarButton.TabIndex = 34
        Me.BackToCaviarButton.Text = "Change Caviar Information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Back to Step 2)"
        Me.BackToCaviarButton.UseVisualStyleBackColor = True
        '
        'OthersSubtotalTextBox
        '
        Me.OthersSubtotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OthersSubtotalTextBox.Location = New System.Drawing.Point(134, 489)
        Me.OthersSubtotalTextBox.Name = "OthersSubtotalTextBox"
        Me.OthersSubtotalTextBox.ReadOnly = True
        Me.OthersSubtotalTextBox.Size = New System.Drawing.Size(109, 20)
        Me.OthersSubtotalTextBox.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 492)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Others Subtotal:"
        '
        'Non_Inventory_Invoice_RecordsDataGridView
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Non_Inventory_Invoice_RecordsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Non_Inventory_Invoice_RecordsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Non_Inventory_Invoice_RecordsDataGridView.AutoGenerateColumns = False
        Me.Non_Inventory_Invoice_RecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Non_Inventory_Invoice_RecordsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FKProductIDNonInventory, Me.QuantityNonInventory, Me.PriceSoldAtNonInventory, Me.NotesNonInventory})
        Me.Non_Inventory_Invoice_RecordsDataGridView.DataSource = Me.Non_Inventory_Invoice_RecordsBindingSource
        Me.Non_Inventory_Invoice_RecordsDataGridView.Enabled = False
        Me.Non_Inventory_Invoice_RecordsDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.Non_Inventory_Invoice_RecordsDataGridView.MultiSelect = False
        Me.Non_Inventory_Invoice_RecordsDataGridView.Name = "Non_Inventory_Invoice_RecordsDataGridView"
        Me.Non_Inventory_Invoice_RecordsDataGridView.Size = New System.Drawing.Size(320, 463)
        Me.Non_Inventory_Invoice_RecordsDataGridView.TabIndex = 0
        '
        'FKProductIDNonInventory
        '
        Me.FKProductIDNonInventory.DataPropertyName = "FKProductID"
        Me.FKProductIDNonInventory.DataSource = Me.NonInventoryProductBindingSource
        Me.FKProductIDNonInventory.DisplayMember = "Product Name"
        Me.FKProductIDNonInventory.HeaderText = "Product Code"
        Me.FKProductIDNonInventory.Name = "FKProductIDNonInventory"
        Me.FKProductIDNonInventory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FKProductIDNonInventory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FKProductIDNonInventory.ValueMember = "PKProductID"
        '
        'NonInventoryProductBindingSource
        '
        Me.NonInventoryProductBindingSource.DataMember = "Products"
        Me.NonInventoryProductBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'QuantityNonInventory
        '
        Me.QuantityNonInventory.DataPropertyName = "Quantity"
        Me.QuantityNonInventory.HeaderText = "Quantity"
        Me.QuantityNonInventory.Name = "QuantityNonInventory"
        '
        'PriceSoldAtNonInventory
        '
        Me.PriceSoldAtNonInventory.DataPropertyName = "PriceSoldAt"
        Me.PriceSoldAtNonInventory.HeaderText = "Price"
        Me.PriceSoldAtNonInventory.Name = "PriceSoldAtNonInventory"
        '
        'NotesNonInventory
        '
        Me.NotesNonInventory.DataPropertyName = "Notes"
        Me.NotesNonInventory.HeaderText = "Notes"
        Me.NotesNonInventory.Name = "NotesNonInventory"
        '
        'Non_Inventory_Invoice_RecordsBindingSource
        '
        Me.Non_Inventory_Invoice_RecordsBindingSource.DataMember = "InvoicesNon-Inventory Invoice Records"
        Me.Non_Inventory_Invoice_RecordsBindingSource.DataSource = Me.InvoicesBindingSource
        '
        'Customer_PricingBindingSource
        '
        Me.Customer_PricingBindingSource.DataMember = "Customer Pricing"
        Me.Customer_PricingBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'ProductCategorySelectionBindingSource
        '
        Me.ProductCategorySelectionBindingSource.DataMember = "ProductCategorySelection"
        Me.ProductCategorySelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.MainSplitContainer.Location = New System.Drawing.Point(300, 12)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.Controls.Add(Me.GroupBox2)
        Me.MainSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.GroupBox3)
        Me.MainSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MainSplitContainer.Size = New System.Drawing.Size(707, 599)
        Me.MainSplitContainer.SplitterDistance = 366
        Me.MainSplitContainer.TabIndex = 20
        '
        'SampleColumn
        '
        Me.SampleColumn.HeaderText = "Sample"
        Me.SampleColumn.Name = "SampleColumn"
        '
        'PKBarcode
        '
        Me.PKBarcode.DataPropertyName = "PKBarcode"
        Me.PKBarcode.HeaderText = "Barcode"
        Me.PKBarcode.Name = "PKBarcode"
        Me.PKBarcode.ReadOnly = True
        '
        'OrderOnInvoice
        '
        Me.OrderOnInvoice.DataPropertyName = "OrderOnInvoice"
        Me.OrderOnInvoice.HeaderText = "OrderOnInvoice"
        Me.OrderOnInvoice.Name = "OrderOnInvoice"
        Me.OrderOnInvoice.ReadOnly = True
        Me.OrderOnInvoice.Visible = False
        '
        'FKProductID
        '
        Me.FKProductID.DataPropertyName = "FKProductID"
        Me.FKProductID.DataSource = Me.ProductsBindingSource
        Me.FKProductID.DisplayMember = "Product Name"
        Me.FKProductID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FKProductID.HeaderText = "Product Code"
        Me.FKProductID.Name = "FKProductID"
        Me.FKProductID.ReadOnly = True
        Me.FKProductID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FKProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FKProductID.ValueMember = "PKProductID"
        '
        'InventoryStatus
        '
        Me.InventoryStatus.DataPropertyName = "InventoryStatus"
        Me.InventoryStatus.DataSource = Me.CaviarStatusSelectionBindingSource
        Me.InventoryStatus.DisplayMember = "Description"
        Me.InventoryStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.InventoryStatus.HeaderText = "Inventory Status"
        Me.InventoryStatus.Name = "InventoryStatus"
        Me.InventoryStatus.ReadOnly = True
        Me.InventoryStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.InventoryStatus.ValueMember = "PKStatusID"
        '
        'FKFishID
        '
        Me.FKFishID.DataPropertyName = "FKFishID"
        Me.FKFishID.DataSource = Me.Caviar_FishBindingSource
        Me.FKFishID.DisplayMember = "Tag"
        Me.FKFishID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FKFishID.HeaderText = "Fish Tag"
        Me.FKFishID.Name = "FKFishID"
        Me.FKFishID.ReadOnly = True
        Me.FKFishID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FKFishID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FKFishID.ValueMember = "PKFishID"
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "FKFishID"
        Me.DataGridViewComboBoxColumn1.DataSource = Me.Caviar_FishBindingSource
        Me.DataGridViewComboBoxColumn1.DisplayMember = "Eggsize"
        Me.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn1.HeaderText = "Egg Size"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.ReadOnly = True
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.ValueMember = "PKFishID"
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.DataPropertyName = "FKFishID"
        Me.DataGridViewComboBoxColumn2.DataSource = Me.Caviar_FishBindingSource
        Me.DataGridViewComboBoxColumn2.DisplayMember = "Egg Color"
        Me.DataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn2.HeaderText = "Egg Color"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.ReadOnly = True
        Me.DataGridViewComboBoxColumn2.ValueMember = "PKFishID"
        '
        'DataGridViewComboBoxColumn3
        '
        Me.DataGridViewComboBoxColumn3.DataPropertyName = "FKFishID"
        Me.DataGridViewComboBoxColumn3.DataSource = Me.Caviar_FishBindingSource
        Me.DataGridViewComboBoxColumn3.DisplayMember = "Firmness"
        Me.DataGridViewComboBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn3.HeaderText = "Egg Firmness"
        Me.DataGridViewComboBoxColumn3.Name = "DataGridViewComboBoxColumn3"
        Me.DataGridViewComboBoxColumn3.ReadOnly = True
        Me.DataGridViewComboBoxColumn3.ValueMember = "PKFishID"
        '
        'DataGridViewComboBoxColumn4
        '
        Me.DataGridViewComboBoxColumn4.DataPropertyName = "FKFishID"
        Me.DataGridViewComboBoxColumn4.DataSource = Me.Caviar_FishBindingSource
        Me.DataGridViewComboBoxColumn4.DisplayMember = "Taste"
        Me.DataGridViewComboBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn4.HeaderText = "Egg Taste"
        Me.DataGridViewComboBoxColumn4.Name = "DataGridViewComboBoxColumn4"
        Me.DataGridViewComboBoxColumn4.ReadOnly = True
        Me.DataGridViewComboBoxColumn4.ValueMember = "PKFishID"
        '
        'CaviarNotes
        '
        Me.CaviarNotes.DataPropertyName = "Notes"
        Me.CaviarNotes.HeaderText = "Notes"
        Me.CaviarNotes.Name = "CaviarNotes"
        Me.CaviarNotes.ReadOnly = True
        '
        'PackingBoxNumber
        '
        Me.PackingBoxNumber.DataPropertyName = "PackingBoxNumber"
        Me.PackingBoxNumber.HeaderText = "Packing Box Number"
        Me.PackingBoxNumber.Name = "PackingBoxNumber"
        Me.PackingBoxNumber.ReadOnly = True
        '
        'PriceSoldAt
        '
        Me.PriceSoldAt.DataPropertyName = "PriceSoldAt"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PriceSoldAt.DefaultCellStyle = DataGridViewCellStyle2
        Me.PriceSoldAt.HeaderText = "Price Per Kilo"
        Me.PriceSoldAt.Name = "PriceSoldAt"
        Me.PriceSoldAt.ReadOnly = True
        '
        'FKInvoiceID
        '
        Me.FKInvoiceID.DataPropertyName = "FKInvoiceID"
        Me.FKInvoiceID.HeaderText = "FKInvoiceID"
        Me.FKInvoiceID.Name = "FKInvoiceID"
        Me.FKInvoiceID.ReadOnly = True
        Me.FKInvoiceID.Visible = False
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
        Me.PreviousStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.PreviousStatus.HeaderText = "Previous Status"
        Me.PreviousStatus.Name = "PreviousStatus"
        Me.PreviousStatus.ReadOnly = True
        Me.PreviousStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PreviousStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PreviousStatus.ValueMember = "PKStatusID"
        '
        'PricePerItem
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PricePerItem.DefaultCellStyle = DataGridViewCellStyle3
        Me.PricePerItem.HeaderText = "Price Per Item"
        Me.PricePerItem.Name = "PricePerItem"
        Me.PricePerItem.ReadOnly = True
        '
        'NewCaviarInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1008, 614)
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "NewCaviarInvoice"
        Me.Text = "New Caviar Invoice Guide"
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersShippingAddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InvoiceTypeSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBillingAddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoicesBindingNavigator.ResumeLayout(False)
        Me.InvoicesBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.CaviarDetailsSplitContainer.Panel1.ResumeLayout(False)
        Me.CaviarDetailsSplitContainer.Panel1.PerformLayout()
        Me.CaviarDetailsSplitContainer.Panel2.ResumeLayout(False)
        Me.CaviarDetailsSplitContainer.Panel2.PerformLayout()
        Me.CaviarDetailsSplitContainer.ResumeLayout(False)
        CType(Me.Caviar_InventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caviar_InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarOrderDisplayDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Non_Inventory_Invoice_RecordsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NonInventoryProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Non_Inventory_Invoice_RecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_PricingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCategorySelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        Me.MainSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents InvoicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoicesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PKInvoiceIDTextBox As TabTextBox
    Friend WithEvents FKCustomerIDComboBox As Controls.AutoDropDownWidthComboBox
    Friend WithEvents DateMyDateTimePicker As Sturgeon_Manager_v1._0.Controls.MyDateTimePicker
    Friend WithEvents PO_NumberTextBox As TabTextBox
    Friend WithEvents BoxesTextBox As TabTextBox
    Friend WithEvents FKShippingAddressIDComboBox As Controls.AutoDropDownWidthComboBox
    Friend WithEvents Shipping_NotesTextBox As TabTextBox
    Friend WithEvents CustomersTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents InvoicesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents InvoicesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Caviar_InventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caviar_InventoryTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BarcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents GradeSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
    Friend WithEvents Caviar_FishBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caviar_FishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
    Friend WithEvents CaviarStatusSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarStatusSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CaviarSubtotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Non_Inventory_Invoice_RecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Non_Inventory_Invoice_RecordsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Non_Inventory_Invoice_RecordsTableAdapter
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OthersSubtotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Customer_PricingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_PricingTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Customer_PricingTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceInformationCompleteButton As System.Windows.Forms.Button
    Friend WithEvents CustomersShippingAddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Shipping_AddressesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Shipping_AddressesTableAdapter
    Friend WithEvents FKBillingAddressIDComboBox As Controls.AutoDropDownWidthComboBox
    Friend WithEvents CustomersBillingAddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Billing_AddressesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Billing_AddressesTableAdapter
    Friend WithEvents CompleteInvoiceButton As System.Windows.Forms.Button
    Friend WithEvents AddShippingAddressButton As System.Windows.Forms.Button
    Friend WithEvents AddBillingAddressButton As System.Windows.Forms.Button
    Friend WithEvents AddCustomerButton As System.Windows.Forms.Button
    Friend WithEvents Caviar_InventoryDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents Non_Inventory_Invoice_RecordsDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents CaviarOrderDisplayDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents ProductCategorySelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductCategorySelectionTableAdapter
    Friend WithEvents ProductCategorySelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarInformationCompleteButton As System.Windows.Forms.Button
    Friend WithEvents BackToCaviarButton As System.Windows.Forms.Button
    Friend WithEvents InvoiceTypeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoiceTypeSelectionTableAdapter
    Friend WithEvents InvoiceTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InvoiceTypeSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SavePreviewButton As System.Windows.Forms.Button
    Friend WithEvents NonInventoryProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FKProductIDNonInventory As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QuantityNonInventory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceSoldAtNonInventory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesNonInventory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewBoxButton As System.Windows.Forms.Button
    Friend WithEvents BoxNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BoxNameCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNameCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceSoldAtCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalKgsCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalCaviarOrderDisplayColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaviarDetailsSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents MainSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents SampleColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PKBarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderOnInvoice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKProductID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents InventoryStatus As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FKFishID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CaviarNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PackingBoxNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceSoldAt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FKInvoiceID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateStatusChanged As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreviousStatus As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PricePerItem As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
