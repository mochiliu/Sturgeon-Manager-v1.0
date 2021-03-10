<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewFishInvoice
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
        Dim Shipping_NotesLabel As System.Windows.Forms.Label
        Dim FKBillingAddressIDLabel As System.Windows.Forms.Label
        Dim FKShippingAddressIDLabel As System.Windows.Forms.Label
        Dim InvoiceTypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewFishInvoice))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.InvoiceTypeComboBox = New System.Windows.Forms.ComboBox
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.InvoiceTypeSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddShippingAddressButton = New System.Windows.Forms.Button
        Me.AddBillingAddressButton = New System.Windows.Forms.Button
        Me.AddCustomerButton = New System.Windows.Forms.Button
        Me.FKBillingAddressIDComboBox = New Sturgeon_Manager_v1._0.Controls.AutoDropDownWidthComboBox
        Me.CustomersBillingAddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKShippingAddressIDComboBox = New Sturgeon_Manager_v1._0.Controls.AutoDropDownWidthComboBox
        Me.CustomersShippingAddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.PKInvoiceIDTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.FKCustomerIDComboBox = New Sturgeon_Manager_v1._0.Controls.AutoDropDownWidthComboBox
        Me.DateMyDateTimePicker = New Sturgeon_Manager_v1._0.Controls.MyDateTimePicker
        Me.PO_NumberTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.BoxesTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Shipping_NotesTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.CompleteInvoiceButton = New System.Windows.Forms.Button
        Me.InvoicesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoicesTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.Billing_AddressesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Billing_AddressesTableAdapter
        Me.Customer_PricingTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Customer_PricingTableAdapter
        Me.CustomersTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CustomersTableAdapter
        Me.InvoiceTypeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoiceTypeSelectionTableAdapter
        Me.Non_Inventory_Invoice_RecordsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Non_Inventory_Invoice_RecordsTableAdapter
        Me.ProductCategorySelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductCategorySelectionTableAdapter
        Me.ProductsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
        Me.Shipping_AddressesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Shipping_AddressesTableAdapter
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SavePreviewButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Non_Inventory_Invoice_RecordsDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Non_Inventory_Invoice_RecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Customer_PricingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductCategorySelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKProductIDColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.QuantityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceSoldAtColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        PKInvoiceIDLabel = New System.Windows.Forms.Label
        FKCustomerIDLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        PO_NumberLabel = New System.Windows.Forms.Label
        BoxesLabel = New System.Windows.Forms.Label
        Shipping_NotesLabel = New System.Windows.Forms.Label
        FKBillingAddressIDLabel = New System.Windows.Forms.Label
        FKShippingAddressIDLabel = New System.Windows.Forms.Label
        InvoiceTypeLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceTypeSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBillingAddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersShippingAddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoicesBindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Non_Inventory_Invoice_RecordsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Non_Inventory_Invoice_RecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_PricingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCategorySelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PKInvoiceIDLabel
        '
        PKInvoiceIDLabel.AutoSize = True
        PKInvoiceIDLabel.Location = New System.Drawing.Point(19, 49)
        PKInvoiceIDLabel.Name = "PKInvoiceIDLabel"
        PKInvoiceIDLabel.Size = New System.Drawing.Size(85, 13)
        PKInvoiceIDLabel.TabIndex = 0
        PKInvoiceIDLabel.Text = "Invoice Number:"
        '
        'FKCustomerIDLabel
        '
        FKCustomerIDLabel.AutoSize = True
        FKCustomerIDLabel.Location = New System.Drawing.Point(19, 75)
        FKCustomerIDLabel.Name = "FKCustomerIDLabel"
        FKCustomerIDLabel.Size = New System.Drawing.Size(54, 13)
        FKCustomerIDLabel.TabIndex = 2
        FKCustomerIDLabel.Text = "Customer:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(19, 103)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 4
        DateLabel.Text = "Date:"
        '
        'PO_NumberLabel
        '
        PO_NumberLabel.AutoSize = True
        PO_NumberLabel.Location = New System.Drawing.Point(19, 128)
        PO_NumberLabel.Name = "PO_NumberLabel"
        PO_NumberLabel.Size = New System.Drawing.Size(65, 13)
        PO_NumberLabel.TabIndex = 6
        PO_NumberLabel.Text = "PO Number:"
        '
        'BoxesLabel
        '
        BoxesLabel.AutoSize = True
        BoxesLabel.Location = New System.Drawing.Point(19, 154)
        BoxesLabel.Name = "BoxesLabel"
        BoxesLabel.Size = New System.Drawing.Size(39, 13)
        BoxesLabel.TabIndex = 8
        BoxesLabel.Text = "Boxes:"
        '
        'Shipping_NotesLabel
        '
        Shipping_NotesLabel.AutoSize = True
        Shipping_NotesLabel.Location = New System.Drawing.Point(19, 234)
        Shipping_NotesLabel.Name = "Shipping_NotesLabel"
        Shipping_NotesLabel.Size = New System.Drawing.Size(82, 13)
        Shipping_NotesLabel.TabIndex = 14
        Shipping_NotesLabel.Text = "Shipping Notes:"
        '
        'FKBillingAddressIDLabel
        '
        FKBillingAddressIDLabel.AutoSize = True
        FKBillingAddressIDLabel.Location = New System.Drawing.Point(19, 180)
        FKBillingAddressIDLabel.Name = "FKBillingAddressIDLabel"
        FKBillingAddressIDLabel.Size = New System.Drawing.Size(78, 13)
        FKBillingAddressIDLabel.TabIndex = 37
        FKBillingAddressIDLabel.Text = "Billing Address:"
        '
        'FKShippingAddressIDLabel
        '
        FKShippingAddressIDLabel.AutoSize = True
        FKShippingAddressIDLabel.Location = New System.Drawing.Point(19, 207)
        FKShippingAddressIDLabel.Name = "FKShippingAddressIDLabel"
        FKShippingAddressIDLabel.Size = New System.Drawing.Size(92, 13)
        FKShippingAddressIDLabel.TabIndex = 35
        FKShippingAddressIDLabel.Text = "Shipping Address:"
        '
        'InvoiceTypeLabel
        '
        InvoiceTypeLabel.AutoSize = True
        InvoiceTypeLabel.Location = New System.Drawing.Point(19, 260)
        InvoiceTypeLabel.Name = "InvoiceTypeLabel"
        InvoiceTypeLabel.Size = New System.Drawing.Size(72, 13)
        InvoiceTypeLabel.TabIndex = 41
        InvoiceTypeLabel.Text = "Invoice Type:"
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
        Me.GroupBox1.Controls.Add(Me.FKShippingAddressIDComboBox)
        Me.GroupBox1.Controls.Add(FKShippingAddressIDLabel)
        Me.GroupBox1.Controls.Add(Me.InvoiceInformationCompleteButton)
        Me.GroupBox1.Controls.Add(Me.InvoicesBindingNavigator)
        Me.GroupBox1.Controls.Add(PKInvoiceIDLabel)
        Me.GroupBox1.Controls.Add(Me.PKInvoiceIDTextBox)
        Me.GroupBox1.Controls.Add(FKCustomerIDLabel)
        Me.GroupBox1.Controls.Add(Me.FKCustomerIDComboBox)
        Me.GroupBox1.Controls.Add(DateLabel)
        Me.GroupBox1.Controls.Add(Me.DateMyDateTimePicker)
        Me.GroupBox1.Controls.Add(PO_NumberLabel)
        Me.GroupBox1.Controls.Add(Me.PO_NumberTextBox)
        Me.GroupBox1.Controls.Add(BoxesLabel)
        Me.GroupBox1.Controls.Add(Me.BoxesTextBox)
        Me.GroupBox1.Controls.Add(Shipping_NotesLabel)
        Me.GroupBox1.Controls.Add(Me.Shipping_NotesTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 424)
        Me.GroupBox1.TabIndex = 0
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
        Me.InvoiceTypeComboBox.Location = New System.Drawing.Point(117, 257)
        Me.InvoiceTypeComboBox.Name = "InvoiceTypeComboBox"
        Me.InvoiceTypeComboBox.Size = New System.Drawing.Size(148, 21)
        Me.InvoiceTypeComboBox.TabIndex = 42
        Me.InvoiceTypeComboBox.TabStop = False
        Me.InvoiceTypeComboBox.ValueMember = "PKTypeID"
        '
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "Invoices"
        Me.InvoicesBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoiceTypeSelectionBindingSource
        '
        Me.InvoiceTypeSelectionBindingSource.DataMember = "InvoiceTypeSelection"
        Me.InvoiceTypeSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'AddShippingAddressButton
        '
        Me.AddShippingAddressButton.Location = New System.Drawing.Point(223, 203)
        Me.AddShippingAddressButton.Name = "AddShippingAddressButton"
        Me.AddShippingAddressButton.Size = New System.Drawing.Size(42, 21)
        Me.AddShippingAddressButton.TabIndex = 41
        Me.AddShippingAddressButton.Text = "Add"
        Me.AddShippingAddressButton.UseVisualStyleBackColor = True
        '
        'AddBillingAddressButton
        '
        Me.AddBillingAddressButton.Location = New System.Drawing.Point(223, 176)
        Me.AddBillingAddressButton.Name = "AddBillingAddressButton"
        Me.AddBillingAddressButton.Size = New System.Drawing.Size(42, 21)
        Me.AddBillingAddressButton.TabIndex = 40
        Me.AddBillingAddressButton.Text = "Add"
        Me.AddBillingAddressButton.UseVisualStyleBackColor = True
        '
        'AddCustomerButton
        '
        Me.AddCustomerButton.Location = New System.Drawing.Point(223, 71)
        Me.AddCustomerButton.Name = "AddCustomerButton"
        Me.AddCustomerButton.Size = New System.Drawing.Size(42, 22)
        Me.AddCustomerButton.TabIndex = 39
        Me.AddCustomerButton.Text = "Add"
        Me.AddCustomerButton.UseVisualStyleBackColor = True
        '
        'FKBillingAddressIDComboBox
        '
        Me.FKBillingAddressIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InvoicesBindingSource, "FKBillingAddressID", True))
        Me.FKBillingAddressIDComboBox.DataSource = Me.CustomersBillingAddressesBindingSource
        Me.FKBillingAddressIDComboBox.DisplayMember = "FullAddress"
        Me.FKBillingAddressIDComboBox.FormattingEnabled = True
        Me.FKBillingAddressIDComboBox.Location = New System.Drawing.Point(117, 177)
        Me.FKBillingAddressIDComboBox.Name = "FKBillingAddressIDComboBox"
        Me.FKBillingAddressIDComboBox.Size = New System.Drawing.Size(99, 21)
        Me.FKBillingAddressIDComboBox.TabIndex = 6
        Me.FKBillingAddressIDComboBox.ValueMember = "BillingAddressID"
        '
        'CustomersBillingAddressesBindingSource
        '
        Me.CustomersBillingAddressesBindingSource.DataMember = "CustomersBilling Addresses"
        Me.CustomersBillingAddressesBindingSource.DataSource = Me.CustomersBindingSource
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'FKShippingAddressIDComboBox
        '
        Me.FKShippingAddressIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InvoicesBindingSource, "FKShippingAddressID", True))
        Me.FKShippingAddressIDComboBox.DataSource = Me.CustomersShippingAddressesBindingSource
        Me.FKShippingAddressIDComboBox.DisplayMember = "FullAddress"
        Me.FKShippingAddressIDComboBox.FormattingEnabled = True
        Me.FKShippingAddressIDComboBox.Location = New System.Drawing.Point(117, 204)
        Me.FKShippingAddressIDComboBox.Name = "FKShippingAddressIDComboBox"
        Me.FKShippingAddressIDComboBox.Size = New System.Drawing.Size(99, 21)
        Me.FKShippingAddressIDComboBox.TabIndex = 7
        Me.FKShippingAddressIDComboBox.ValueMember = "ShippingAddressID"
        '
        'CustomersShippingAddressesBindingSource
        '
        Me.CustomersShippingAddressesBindingSource.DataMember = "CustomersShipping Addresses"
        Me.CustomersShippingAddressesBindingSource.DataSource = Me.CustomersBindingSource
        '
        'InvoiceInformationCompleteButton
        '
        Me.InvoiceInformationCompleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InvoiceInformationCompleteButton.Location = New System.Drawing.Point(84, 347)
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
        Me.InvoicesBindingNavigator.Size = New System.Drawing.Size(286, 25)
        Me.InvoicesBindingNavigator.TabIndex = 16
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
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
        'PKInvoiceIDTextBox
        '
        Me.PKInvoiceIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "PKInvoiceID", True))
        Me.PKInvoiceIDTextBox.Location = New System.Drawing.Point(117, 46)
        Me.PKInvoiceIDTextBox.Name = "PKInvoiceIDTextBox"
        Me.PKInvoiceIDTextBox.Size = New System.Drawing.Size(148, 20)
        Me.PKInvoiceIDTextBox.TabIndex = 1
        '
        'FKCustomerIDComboBox
        '
        Me.FKCustomerIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FKCustomerIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FKCustomerIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InvoicesBindingSource, "FKCustomerID", True))
        Me.FKCustomerIDComboBox.DataSource = Me.CustomersBindingSource
        Me.FKCustomerIDComboBox.DisplayMember = "Company Name"
        Me.FKCustomerIDComboBox.FormattingEnabled = True
        Me.FKCustomerIDComboBox.Location = New System.Drawing.Point(117, 72)
        Me.FKCustomerIDComboBox.Name = "FKCustomerIDComboBox"
        Me.FKCustomerIDComboBox.Size = New System.Drawing.Size(99, 21)
        Me.FKCustomerIDComboBox.TabIndex = 2
        Me.FKCustomerIDComboBox.ValueMember = "PKCustomerID"
        '
        'DateMyDateTimePicker
        '
        Me.DateMyDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoicesBindingSource, "Date", True))
        Me.DateMyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateMyDateTimePicker.Location = New System.Drawing.Point(117, 99)
        Me.DateMyDateTimePicker.Name = "DateMyDateTimePicker"
        Me.DateMyDateTimePicker.Size = New System.Drawing.Size(148, 20)
        Me.DateMyDateTimePicker.TabIndex = 3
        '
        'PO_NumberTextBox
        '
        Me.PO_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "PO Number", True))
        Me.PO_NumberTextBox.Location = New System.Drawing.Point(117, 125)
        Me.PO_NumberTextBox.Name = "PO_NumberTextBox"
        Me.PO_NumberTextBox.Size = New System.Drawing.Size(148, 20)
        Me.PO_NumberTextBox.TabIndex = 4
        '
        'BoxesTextBox
        '
        Me.BoxesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Boxes", True))
        Me.BoxesTextBox.Location = New System.Drawing.Point(117, 151)
        Me.BoxesTextBox.Name = "BoxesTextBox"
        Me.BoxesTextBox.Size = New System.Drawing.Size(148, 20)
        Me.BoxesTextBox.TabIndex = 5
        '
        'Shipping_NotesTextBox
        '
        Me.Shipping_NotesTextBox.AutoCompleteCustomSource.AddRange(New String() {"Customer Will Pick up at MAP", "Via Refrigerated Express"})
        Me.Shipping_NotesTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Shipping_NotesTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Shipping_NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Shipping Notes", True))
        Me.Shipping_NotesTextBox.Location = New System.Drawing.Point(117, 231)
        Me.Shipping_NotesTextBox.Name = "Shipping_NotesTextBox"
        Me.Shipping_NotesTextBox.Size = New System.Drawing.Size(148, 20)
        Me.Shipping_NotesTextBox.TabIndex = 8
        '
        'CompleteInvoiceButton
        '
        Me.CompleteInvoiceButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CompleteInvoiceButton.Enabled = False
        Me.CompleteInvoiceButton.Location = New System.Drawing.Point(327, 378)
        Me.CompleteInvoiceButton.Name = "CompleteInvoiceButton"
        Me.CompleteInvoiceButton.Size = New System.Drawing.Size(92, 37)
        Me.CompleteInvoiceButton.TabIndex = 34
        Me.CompleteInvoiceButton.Text = "Complete Invoice"
        Me.CompleteInvoiceButton.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.Caviar_FishTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryInvoiceFlatTableTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryValueTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Customer_PricingTableAdapter = Me.Customer_PricingTableAdapter
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.FilterColumnsTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Me.InvoicesTableAdapter
        Me.TableAdapterManager.InvoiceTypeSelectionTableAdapter = Me.InvoiceTypeSelectionTableAdapter
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Me.Non_Inventory_Invoice_RecordsTableAdapter
        Me.TableAdapterManager.NonInventoryInvoiceFlatTableTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Me.ProductCategorySelectionTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.RepackLossTableAdapter = Nothing
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Me.Shipping_AddressesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Billing_AddressesTableAdapter
        '
        Me.Billing_AddressesTableAdapter.ClearBeforeFill = True
        '
        'Customer_PricingTableAdapter
        '
        Me.Customer_PricingTableAdapter.ClearBeforeFill = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.SavePreviewButton)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Non_Inventory_Invoice_RecordsDataGridView)
        Me.GroupBox2.Controls.Add(Me.TotalTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CompleteInvoiceButton)
        Me.GroupBox2.Location = New System.Drawing.Point(310, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(830, 424)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Items on Invoice (Step 2)"
        '
        'SavePreviewButton
        '
        Me.SavePreviewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SavePreviewButton.Enabled = False
        Me.SavePreviewButton.Location = New System.Drawing.Point(229, 378)
        Me.SavePreviewButton.Name = "SavePreviewButton"
        Me.SavePreviewButton.Size = New System.Drawing.Size(92, 37)
        Me.SavePreviewButton.TabIndex = 35
        Me.SavePreviewButton.Text = "Save and View Invoice"
        Me.SavePreviewButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(6, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Note: Ctrl+s calulates the shipping weight for selected Quantity cell"
        '
        'Non_Inventory_Invoice_RecordsDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Non_Inventory_Invoice_RecordsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Non_Inventory_Invoice_RecordsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Non_Inventory_Invoice_RecordsDataGridView.AutoGenerateColumns = False
        Me.Non_Inventory_Invoice_RecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Non_Inventory_Invoice_RecordsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FKProductIDColumn, Me.QuantityColumn, Me.PriceSoldAtColumn, Me.NotesColumn})
        Me.Non_Inventory_Invoice_RecordsDataGridView.DataSource = Me.Non_Inventory_Invoice_RecordsBindingSource
        Me.Non_Inventory_Invoice_RecordsDataGridView.Enabled = False
        Me.Non_Inventory_Invoice_RecordsDataGridView.Location = New System.Drawing.Point(9, 16)
        Me.Non_Inventory_Invoice_RecordsDataGridView.MultiSelect = False
        Me.Non_Inventory_Invoice_RecordsDataGridView.Name = "Non_Inventory_Invoice_RecordsDataGridView"
        Me.Non_Inventory_Invoice_RecordsDataGridView.ShowCellErrors = False
        Me.Non_Inventory_Invoice_RecordsDataGridView.Size = New System.Drawing.Size(818, 341)
        Me.Non_Inventory_Invoice_RecordsDataGridView.TabIndex = 0
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'Non_Inventory_Invoice_RecordsBindingSource
        '
        Me.Non_Inventory_Invoice_RecordsBindingSource.DataMember = "InvoicesNon-Inventory Invoice Records"
        Me.Non_Inventory_Invoice_RecordsBindingSource.DataSource = Me.InvoicesBindingSource
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoicesBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(100, 387)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Invoice Total:"
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
        'QuantityColumn
        '
        Me.QuantityColumn.DataPropertyName = "Quantity"
        Me.QuantityColumn.HeaderText = "Quantity"
        Me.QuantityColumn.Name = "QuantityColumn"
        '
        'PriceSoldAtColumn
        '
        Me.PriceSoldAtColumn.DataPropertyName = "PriceSoldAt"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PriceSoldAtColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PriceSoldAtColumn.HeaderText = "Extended Price"
        Me.PriceSoldAtColumn.Name = "PriceSoldAtColumn"
        '
        'NotesColumn
        '
        Me.NotesColumn.DataPropertyName = "Notes"
        Me.NotesColumn.HeaderText = "Notes"
        Me.NotesColumn.Name = "NotesColumn"
        Me.NotesColumn.Width = 475
        '
        'NewFishInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 443)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NewFishInvoice"
        Me.Text = "New Fish Invoice Guide"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceTypeSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBillingAddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersShippingAddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoicesBindingNavigator.ResumeLayout(False)
        Me.InvoicesBindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Non_Inventory_Invoice_RecordsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Non_Inventory_Invoice_RecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_PricingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCategorySelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents InvoicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoicesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents PKInvoiceIDTextBox As TabTextBox
    Friend WithEvents FKCustomerIDComboBox As Controls.AutoDropDownWidthComboBox
    Friend WithEvents DateMyDateTimePicker As Sturgeon_Manager_v1._0.Controls.MyDateTimePicker
    Friend WithEvents PO_NumberTextBox As TabTextBox
    Friend WithEvents BoxesTextBox As TabTextBox
    Friend WithEvents Shipping_NotesTextBox As TabTextBox
    Friend WithEvents Non_Inventory_Invoice_RecordsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Non_Inventory_Invoice_RecordsTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Non_Inventory_Invoice_RecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents CompleteInvoiceButton As System.Windows.Forms.Button
    Friend WithEvents InvoiceInformationCompleteButton As System.Windows.Forms.Button
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Customer_PricingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_PricingTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Customer_PricingTableAdapter
    Friend WithEvents CustomersShippingAddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Shipping_AddressesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Shipping_AddressesTableAdapter
    Friend WithEvents CustomersBillingAddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Billing_AddressesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Billing_AddressesTableAdapter
    Friend WithEvents FKBillingAddressIDComboBox As Controls.AutoDropDownWidthComboBox
    Friend WithEvents FKShippingAddressIDComboBox As Controls.AutoDropDownWidthComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddShippingAddressButton As System.Windows.Forms.Button
    Friend WithEvents AddBillingAddressButton As System.Windows.Forms.Button
    Friend WithEvents AddCustomerButton As System.Windows.Forms.Button
    Friend WithEvents ProductCategorySelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductCategorySelectionTableAdapter
    Friend WithEvents ProductCategorySelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Non_Inventory_Invoice_RecordsDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents InvoiceTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InvoiceTypeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoiceTypeSelectionTableAdapter
    Friend WithEvents InvoiceTypeSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SavePreviewButton As System.Windows.Forms.Button
    Friend WithEvents FKProductIDColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QuantityColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceSoldAtColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
