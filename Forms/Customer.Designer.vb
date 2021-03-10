<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim PKCustomerIDLabel As System.Windows.Forms.Label
        Dim Company_NameLabel As System.Windows.Forms.Label
        Dim Contact_NameLabel As System.Windows.Forms.Label
        Dim Fax_NumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim BillingAddressIDLabel As System.Windows.Forms.Label
        Dim Addr1Label As System.Windows.Forms.Label
        Dim Addr2Label As System.Windows.Forms.Label
        Dim Addr3Label As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateOrProvinceLabel As System.Windows.Forms.Label
        Dim PostalCodeLabel As System.Windows.Forms.Label
        Dim Country_RegionLabel As System.Windows.Forms.Label
        Dim FKCustomerIDLabel As System.Windows.Forms.Label
        Dim ShippingAddressIDLabel As System.Windows.Forms.Label
        Dim Addr1Label1 As System.Windows.Forms.Label
        Dim Addr2Label1 As System.Windows.Forms.Label
        Dim Addr3Label1 As System.Windows.Forms.Label
        Dim CityLabel1 As System.Windows.Forms.Label
        Dim StateOrProvinceLabel1 As System.Windows.Forms.Label
        Dim PostalCodeLabel1 As System.Windows.Forms.Label
        Dim Country_RegionLabel1 As System.Windows.Forms.Label
        Dim FKCustomerIDLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim ExtensionLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel1 As System.Windows.Forms.Label
        Dim ExtensionLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FilterButton = New System.Windows.Forms.ToolStripButton
        Me.NotesTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ExtensionTextBox = New System.Windows.Forms.TextBox
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton
        Me.BillingAddressGoogeMapsButton = New System.Windows.Forms.ToolStripButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ExtensionTextBox1 = New System.Windows.Forms.TextBox
        Me.PhoneNumberTextBox1 = New System.Windows.Forms.TextBox
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem2 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem2 = New System.Windows.Forms.ToolStripButton
        Me.BillingToShippingButton = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CustomersTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CustomersTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.Billing_AddressesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Billing_AddressesTableAdapter
        Me.Shipping_AddressesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Shipping_AddressesTableAdapter
        Me.Shipping_AddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Billing_AddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShippingAddressGoogeMapsButton = New System.Windows.Forms.ToolStripButton
        Me.EmailTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Fax_NumberTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.PKCustomerIDTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Company_NameTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Contact_NameTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.ShippingAddressCustomerNameTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.ShippingAddressIDTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Addr1TextBox1 = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Addr2TextBox1 = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Addr3TextBox1 = New Sturgeon_Manager_v1._0.TabTextBox
        Me.CityTextBox1 = New Sturgeon_Manager_v1._0.TabTextBox
        Me.StateOrProvinceTextBox1 = New Sturgeon_Manager_v1._0.TabTextBox
        Me.PostalCodeTextBox1 = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Country_RegionTextBox1 = New Sturgeon_Manager_v1._0.TabTextBox
        Me.FKCustomerIDTextBox1 = New Sturgeon_Manager_v1._0.TabTextBox
        Me.BillingAddressCustomerNameTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.BillingAddressIDTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Addr1TextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Addr2TextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Addr3TextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.CityTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.StateOrProvinceTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.PostalCodeTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Country_RegionTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.FKCustomerIDTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        PKCustomerIDLabel = New System.Windows.Forms.Label
        Company_NameLabel = New System.Windows.Forms.Label
        Contact_NameLabel = New System.Windows.Forms.Label
        Fax_NumberLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        NotesLabel = New System.Windows.Forms.Label
        BillingAddressIDLabel = New System.Windows.Forms.Label
        Addr1Label = New System.Windows.Forms.Label
        Addr2Label = New System.Windows.Forms.Label
        Addr3Label = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        StateOrProvinceLabel = New System.Windows.Forms.Label
        PostalCodeLabel = New System.Windows.Forms.Label
        Country_RegionLabel = New System.Windows.Forms.Label
        FKCustomerIDLabel = New System.Windows.Forms.Label
        ShippingAddressIDLabel = New System.Windows.Forms.Label
        Addr1Label1 = New System.Windows.Forms.Label
        Addr2Label1 = New System.Windows.Forms.Label
        Addr3Label1 = New System.Windows.Forms.Label
        CityLabel1 = New System.Windows.Forms.Label
        StateOrProvinceLabel1 = New System.Windows.Forms.Label
        PostalCodeLabel1 = New System.Windows.Forms.Label
        Country_RegionLabel1 = New System.Windows.Forms.Label
        FKCustomerIDLabel1 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        PhoneNumberLabel = New System.Windows.Forms.Label
        ExtensionLabel = New System.Windows.Forms.Label
        PhoneNumberLabel1 = New System.Windows.Forms.Label
        ExtensionLabel1 = New System.Windows.Forms.Label
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Shipping_AddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Billing_AddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PKCustomerIDLabel
        '
        PKCustomerIDLabel.AutoSize = True
        PKCustomerIDLabel.Location = New System.Drawing.Point(16, 14)
        PKCustomerIDLabel.Name = "PKCustomerIDLabel"
        PKCustomerIDLabel.Size = New System.Drawing.Size(82, 13)
        PKCustomerIDLabel.TabIndex = 1
        PKCustomerIDLabel.Text = "PKCustomer ID:"
        PKCustomerIDLabel.Visible = False
        '
        'Company_NameLabel
        '
        Company_NameLabel.AutoSize = True
        Company_NameLabel.Location = New System.Drawing.Point(16, 40)
        Company_NameLabel.Name = "Company_NameLabel"
        Company_NameLabel.Size = New System.Drawing.Size(85, 13)
        Company_NameLabel.TabIndex = 3
        Company_NameLabel.Text = "Customer Name:"
        '
        'Contact_NameLabel
        '
        Contact_NameLabel.AutoSize = True
        Contact_NameLabel.Location = New System.Drawing.Point(16, 77)
        Contact_NameLabel.Name = "Contact_NameLabel"
        Contact_NameLabel.Size = New System.Drawing.Size(78, 13)
        Contact_NameLabel.TabIndex = 5
        Contact_NameLabel.Text = "Contact Name:"
        '
        'Fax_NumberLabel
        '
        Fax_NumberLabel.AutoSize = True
        Fax_NumberLabel.Location = New System.Drawing.Point(22, 109)
        Fax_NumberLabel.Name = "Fax_NumberLabel"
        Fax_NumberLabel.Size = New System.Drawing.Size(67, 13)
        Fax_NumberLabel.TabIndex = 13
        Fax_NumberLabel.Text = "Fax Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(280, 109)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "Email:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(22, 138)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(38, 13)
        NotesLabel.TabIndex = 17
        NotesLabel.Text = "Notes:"
        '
        'BillingAddressIDLabel
        '
        BillingAddressIDLabel.AutoSize = True
        BillingAddressIDLabel.Location = New System.Drawing.Point(7, 48)
        BillingAddressIDLabel.Name = "BillingAddressIDLabel"
        BillingAddressIDLabel.Size = New System.Drawing.Size(92, 13)
        BillingAddressIDLabel.TabIndex = 0
        BillingAddressIDLabel.Text = "Billing Address ID:"
        BillingAddressIDLabel.Visible = False
        '
        'Addr1Label
        '
        Addr1Label.AutoSize = True
        Addr1Label.Location = New System.Drawing.Point(7, 100)
        Addr1Label.Name = "Addr1Label"
        Addr1Label.Size = New System.Drawing.Size(29, 13)
        Addr1Label.TabIndex = 2
        Addr1Label.Text = "Attn:"
        '
        'Addr2Label
        '
        Addr2Label.AutoSize = True
        Addr2Label.Location = New System.Drawing.Point(7, 126)
        Addr2Label.Name = "Addr2Label"
        Addr2Label.Size = New System.Drawing.Size(38, 13)
        Addr2Label.TabIndex = 4
        Addr2Label.Text = "Addr2:"
        '
        'Addr3Label
        '
        Addr3Label.AutoSize = True
        Addr3Label.Location = New System.Drawing.Point(7, 152)
        Addr3Label.Name = "Addr3Label"
        Addr3Label.Size = New System.Drawing.Size(38, 13)
        Addr3Label.TabIndex = 6
        Addr3Label.Text = "Addr3:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(9, 183)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 8
        CityLabel.Text = "City:"
        '
        'StateOrProvinceLabel
        '
        StateOrProvinceLabel.AutoSize = True
        StateOrProvinceLabel.Location = New System.Drawing.Point(6, 209)
        StateOrProvinceLabel.Name = "StateOrProvinceLabel"
        StateOrProvinceLabel.Size = New System.Drawing.Size(94, 13)
        StateOrProvinceLabel.TabIndex = 10
        StateOrProvinceLabel.Text = "State Or Province:"
        '
        'PostalCodeLabel
        '
        PostalCodeLabel.AutoSize = True
        PostalCodeLabel.Location = New System.Drawing.Point(7, 235)
        PostalCodeLabel.Name = "PostalCodeLabel"
        PostalCodeLabel.Size = New System.Drawing.Size(67, 13)
        PostalCodeLabel.TabIndex = 12
        PostalCodeLabel.Text = "Postal Code:"
        '
        'Country_RegionLabel
        '
        Country_RegionLabel.AutoSize = True
        Country_RegionLabel.Location = New System.Drawing.Point(7, 261)
        Country_RegionLabel.Name = "Country_RegionLabel"
        Country_RegionLabel.Size = New System.Drawing.Size(83, 13)
        Country_RegionLabel.TabIndex = 14
        Country_RegionLabel.Text = "Country Region:"
        '
        'FKCustomerIDLabel
        '
        FKCustomerIDLabel.AutoSize = True
        FKCustomerIDLabel.Location = New System.Drawing.Point(7, 333)
        FKCustomerIDLabel.Name = "FKCustomerIDLabel"
        FKCustomerIDLabel.Size = New System.Drawing.Size(81, 13)
        FKCustomerIDLabel.TabIndex = 16
        FKCustomerIDLabel.Text = "FKCustomer ID:"
        FKCustomerIDLabel.Visible = False
        '
        'ShippingAddressIDLabel
        '
        ShippingAddressIDLabel.AutoSize = True
        ShippingAddressIDLabel.Location = New System.Drawing.Point(13, 48)
        ShippingAddressIDLabel.Name = "ShippingAddressIDLabel"
        ShippingAddressIDLabel.Size = New System.Drawing.Size(106, 13)
        ShippingAddressIDLabel.TabIndex = 0
        ShippingAddressIDLabel.Text = "Shipping Address ID:"
        ShippingAddressIDLabel.Visible = False
        '
        'Addr1Label1
        '
        Addr1Label1.AutoSize = True
        Addr1Label1.Location = New System.Drawing.Point(13, 100)
        Addr1Label1.Name = "Addr1Label1"
        Addr1Label1.Size = New System.Drawing.Size(29, 13)
        Addr1Label1.TabIndex = 2
        Addr1Label1.Text = "Attn:"
        '
        'Addr2Label1
        '
        Addr2Label1.AutoSize = True
        Addr2Label1.Location = New System.Drawing.Point(13, 126)
        Addr2Label1.Name = "Addr2Label1"
        Addr2Label1.Size = New System.Drawing.Size(38, 13)
        Addr2Label1.TabIndex = 4
        Addr2Label1.Text = "Addr2:"
        '
        'Addr3Label1
        '
        Addr3Label1.AutoSize = True
        Addr3Label1.Location = New System.Drawing.Point(13, 152)
        Addr3Label1.Name = "Addr3Label1"
        Addr3Label1.Size = New System.Drawing.Size(38, 13)
        Addr3Label1.TabIndex = 6
        Addr3Label1.Text = "Addr3:"
        '
        'CityLabel1
        '
        CityLabel1.AutoSize = True
        CityLabel1.Location = New System.Drawing.Point(13, 183)
        CityLabel1.Name = "CityLabel1"
        CityLabel1.Size = New System.Drawing.Size(27, 13)
        CityLabel1.TabIndex = 8
        CityLabel1.Text = "City:"
        '
        'StateOrProvinceLabel1
        '
        StateOrProvinceLabel1.AutoSize = True
        StateOrProvinceLabel1.Location = New System.Drawing.Point(13, 209)
        StateOrProvinceLabel1.Name = "StateOrProvinceLabel1"
        StateOrProvinceLabel1.Size = New System.Drawing.Size(94, 13)
        StateOrProvinceLabel1.TabIndex = 10
        StateOrProvinceLabel1.Text = "State Or Province:"
        '
        'PostalCodeLabel1
        '
        PostalCodeLabel1.AutoSize = True
        PostalCodeLabel1.Location = New System.Drawing.Point(13, 235)
        PostalCodeLabel1.Name = "PostalCodeLabel1"
        PostalCodeLabel1.Size = New System.Drawing.Size(67, 13)
        PostalCodeLabel1.TabIndex = 12
        PostalCodeLabel1.Text = "Postal Code:"
        '
        'Country_RegionLabel1
        '
        Country_RegionLabel1.AutoSize = True
        Country_RegionLabel1.Location = New System.Drawing.Point(13, 261)
        Country_RegionLabel1.Name = "Country_RegionLabel1"
        Country_RegionLabel1.Size = New System.Drawing.Size(83, 13)
        Country_RegionLabel1.TabIndex = 14
        Country_RegionLabel1.Text = "Country Region:"
        '
        'FKCustomerIDLabel1
        '
        FKCustomerIDLabel1.AutoSize = True
        FKCustomerIDLabel1.Location = New System.Drawing.Point(13, 333)
        FKCustomerIDLabel1.Name = "FKCustomerIDLabel1"
        FKCustomerIDLabel1.Size = New System.Drawing.Size(81, 13)
        FKCustomerIDLabel1.TabIndex = 16
        FKCustomerIDLabel1.Text = "FKCustomer ID:"
        FKCustomerIDLabel1.Visible = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(7, 74)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(85, 13)
        Label1.TabIndex = 19
        Label1.Text = "Customer Name:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(13, 74)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(85, 13)
        Label2.TabIndex = 21
        Label2.Text = "Customer Name:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(7, 287)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 21
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'ExtensionLabel
        '
        ExtensionLabel.AutoSize = True
        ExtensionLabel.Location = New System.Drawing.Point(7, 313)
        ExtensionLabel.Name = "ExtensionLabel"
        ExtensionLabel.Size = New System.Drawing.Size(56, 13)
        ExtensionLabel.TabIndex = 23
        ExtensionLabel.Text = "Extension:"
        '
        'PhoneNumberLabel1
        '
        PhoneNumberLabel1.AutoSize = True
        PhoneNumberLabel1.Location = New System.Drawing.Point(13, 287)
        PhoneNumberLabel1.Name = "PhoneNumberLabel1"
        PhoneNumberLabel1.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel1.TabIndex = 22
        PhoneNumberLabel1.Text = "Phone Number:"
        '
        'ExtensionLabel1
        '
        ExtensionLabel1.AutoSize = True
        ExtensionLabel1.Location = New System.Drawing.Point(13, 313)
        ExtensionLabel1.Name = "ExtensionLabel1"
        ExtensionLabel1.Size = New System.Drawing.Size(56, 13)
        ExtensionLabel1.TabIndex = 23
        ExtensionLabel1.Text = "Extension:"
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Nothing
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Nothing
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomersBindingNavigatorSaveItem, Me.FilterButton})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersBindingNavigator.MoveFirstItem = Nothing
        Me.CustomersBindingNavigator.MoveLastItem = Nothing
        Me.CustomersBindingNavigator.MoveNextItem = Nothing
        Me.CustomersBindingNavigator.MovePreviousItem = Nothing
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(669, 25)
        Me.CustomersBindingNavigator.TabIndex = 0
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.SturgeonDBDataSet
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
        Me.BindingNavigatorPositionItem.Enabled = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.ReadOnly = True
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'CustomersBindingNavigatorSaveItem
        '
        Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
        Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomersBindingNavigatorSaveItem.Text = "Save Data"
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
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Notes", True))
        Me.NotesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesTextBox.Location = New System.Drawing.Point(107, 133)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(525, 114)
        Me.NotesTextBox.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(ExtensionLabel)
        Me.GroupBox1.Controls.Add(Me.ExtensionTextBox)
        Me.GroupBox1.Controls.Add(PhoneNumberLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.BillingAddressCustomerNameTextBox)
        Me.GroupBox1.Controls.Add(Me.BindingNavigator1)
        Me.GroupBox1.Controls.Add(BillingAddressIDLabel)
        Me.GroupBox1.Controls.Add(Me.BillingAddressIDTextBox)
        Me.GroupBox1.Controls.Add(Addr1Label)
        Me.GroupBox1.Controls.Add(Me.Addr1TextBox)
        Me.GroupBox1.Controls.Add(Addr2Label)
        Me.GroupBox1.Controls.Add(Me.Addr2TextBox)
        Me.GroupBox1.Controls.Add(Addr3Label)
        Me.GroupBox1.Controls.Add(Me.Addr3TextBox)
        Me.GroupBox1.Controls.Add(CityLabel)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(StateOrProvinceLabel)
        Me.GroupBox1.Controls.Add(Me.StateOrProvinceTextBox)
        Me.GroupBox1.Controls.Add(PostalCodeLabel)
        Me.GroupBox1.Controls.Add(Me.PostalCodeTextBox)
        Me.GroupBox1.Controls.Add(Country_RegionLabel)
        Me.GroupBox1.Controls.Add(Me.Country_RegionTextBox)
        Me.GroupBox1.Controls.Add(FKCustomerIDLabel)
        Me.GroupBox1.Controls.Add(Me.FKCustomerIDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 292)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 380)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Billing Address"
        '
        'ExtensionTextBox
        '
        Me.ExtensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Billing_AddressesBindingSource, "Extension", True))
        Me.ExtensionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ExtensionTextBox.Location = New System.Drawing.Point(107, 305)
        Me.ExtensionTextBox.Name = "ExtensionTextBox"
        Me.ExtensionTextBox.Size = New System.Drawing.Size(146, 26)
        Me.ExtensionTextBox.TabIndex = 12
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Billing_AddressesBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(107, 279)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(146, 26)
        Me.PhoneNumberTextBox.TabIndex = 11
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Billing_AddressesBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.BillingAddressGoogeMapsButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(284, 25)
        Me.BindingNavigator1.TabIndex = 18
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
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
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
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
        'BillingAddressGoogeMapsButton
        '
        Me.BillingAddressGoogeMapsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BillingAddressGoogeMapsButton.Image = CType(resources.GetObject("BillingAddressGoogeMapsButton.Image"), System.Drawing.Image)
        Me.BillingAddressGoogeMapsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BillingAddressGoogeMapsButton.Name = "BillingAddressGoogeMapsButton"
        Me.BillingAddressGoogeMapsButton.Size = New System.Drawing.Size(23, 22)
        Me.BillingAddressGoogeMapsButton.Text = "Google Maps Check"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(ExtensionLabel1)
        Me.GroupBox2.Controls.Add(Me.ExtensionTextBox1)
        Me.GroupBox2.Controls.Add(PhoneNumberLabel1)
        Me.GroupBox2.Controls.Add(Me.PhoneNumberTextBox1)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.ShippingAddressCustomerNameTextBox)
        Me.GroupBox2.Controls.Add(Me.BindingNavigator2)
        Me.GroupBox2.Controls.Add(ShippingAddressIDLabel)
        Me.GroupBox2.Controls.Add(Me.ShippingAddressIDTextBox)
        Me.GroupBox2.Controls.Add(Addr1Label1)
        Me.GroupBox2.Controls.Add(Me.Addr1TextBox1)
        Me.GroupBox2.Controls.Add(Addr2Label1)
        Me.GroupBox2.Controls.Add(Me.Addr2TextBox1)
        Me.GroupBox2.Controls.Add(Addr3Label1)
        Me.GroupBox2.Controls.Add(Me.Addr3TextBox1)
        Me.GroupBox2.Controls.Add(CityLabel1)
        Me.GroupBox2.Controls.Add(Me.CityTextBox1)
        Me.GroupBox2.Controls.Add(StateOrProvinceLabel1)
        Me.GroupBox2.Controls.Add(Me.StateOrProvinceTextBox1)
        Me.GroupBox2.Controls.Add(PostalCodeLabel1)
        Me.GroupBox2.Controls.Add(Me.PostalCodeTextBox1)
        Me.GroupBox2.Controls.Add(Country_RegionLabel1)
        Me.GroupBox2.Controls.Add(Me.Country_RegionTextBox1)
        Me.GroupBox2.Controls.Add(FKCustomerIDLabel1)
        Me.GroupBox2.Controls.Add(Me.FKCustomerIDTextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(370, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 383)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Shipping Address"
        '
        'ExtensionTextBox1
        '
        Me.ExtensionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipping_AddressesBindingSource, "Extension", True))
        Me.ExtensionTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ExtensionTextBox1.Location = New System.Drawing.Point(125, 305)
        Me.ExtensionTextBox1.Name = "ExtensionTextBox1"
        Me.ExtensionTextBox1.Size = New System.Drawing.Size(146, 26)
        Me.ExtensionTextBox1.TabIndex = 21
        '
        'PhoneNumberTextBox1
        '
        Me.PhoneNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipping_AddressesBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PhoneNumberTextBox1.Location = New System.Drawing.Point(125, 279)
        Me.PhoneNumberTextBox1.Name = "PhoneNumberTextBox1"
        Me.PhoneNumberTextBox1.Size = New System.Drawing.Size(146, 26)
        Me.PhoneNumberTextBox1.TabIndex = 20
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.Shipping_AddressesBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.BindingNavigatorAddNewItem2, Me.BindingNavigatorDeleteItem2, Me.ShippingAddressGoogeMapsButton})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator2.Size = New System.Drawing.Size(283, 25)
        Me.BindingNavigator2.TabIndex = 18
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem2
        '
        Me.BindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem2.Image = CType(resources.GetObject("BindingNavigatorAddNewItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem2.Name = "BindingNavigatorAddNewItem2"
        Me.BindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem2.Text = "Add new"
        '
        'BindingNavigatorDeleteItem2
        '
        Me.BindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem2.Image = CType(resources.GetObject("BindingNavigatorDeleteItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem2.Name = "BindingNavigatorDeleteItem2"
        Me.BindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem2.Text = "Delete"
        '
        'BillingToShippingButton
        '
        Me.BillingToShippingButton.Location = New System.Drawing.Point(302, 408)
        Me.BillingToShippingButton.Name = "BillingToShippingButton"
        Me.BillingToShippingButton.Size = New System.Drawing.Size(62, 146)
        Me.BillingToShippingButton.TabIndex = 4
        Me.BillingToShippingButton.TabStop = False
        Me.BillingToShippingButton.Text = ">>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add Current Billing Address as a New Shipping Address"
        Me.BillingToShippingButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NotesTextBox)
        Me.GroupBox3.Controls.Add(NotesLabel)
        Me.GroupBox3.Controls.Add(Me.EmailTextBox)
        Me.GroupBox3.Controls.Add(EmailLabel)
        Me.GroupBox3.Controls.Add(PKCustomerIDLabel)
        Me.GroupBox3.Controls.Add(Me.Fax_NumberTextBox)
        Me.GroupBox3.Controls.Add(Me.PKCustomerIDTextBox)
        Me.GroupBox3.Controls.Add(Fax_NumberLabel)
        Me.GroupBox3.Controls.Add(Company_NameLabel)
        Me.GroupBox3.Controls.Add(Me.Company_NameTextBox)
        Me.GroupBox3.Controls.Add(Contact_NameLabel)
        Me.GroupBox3.Controls.Add(Me.Contact_NameTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(650, 258)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Information"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Application_SettingsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Me.Billing_AddressesTableAdapter
        Me.TableAdapterManager.Caviar_FishTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Customer_PricingTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.FilterColumnsTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTypeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Me.Shipping_AddressesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Billing_AddressesTableAdapter
        '
        Me.Billing_AddressesTableAdapter.ClearBeforeFill = True
        '
        'Shipping_AddressesTableAdapter
        '
        Me.Shipping_AddressesTableAdapter.ClearBeforeFill = True
        '
        'Shipping_AddressesBindingSource
        '
        Me.Shipping_AddressesBindingSource.DataMember = "CustomersShipping Addresses"
        Me.Shipping_AddressesBindingSource.DataSource = Me.CustomersBindingSource
        '
        'Billing_AddressesBindingSource
        '
        Me.Billing_AddressesBindingSource.DataMember = "CustomersBilling Addresses"
        Me.Billing_AddressesBindingSource.DataSource = Me.CustomersBindingSource
        '
        'ShippingAddressGoogeMapsButton
        '
        Me.ShippingAddressGoogeMapsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShippingAddressGoogeMapsButton.Image = CType(resources.GetObject("ShippingAddressGoogeMapsButton.Image"), System.Drawing.Image)
        Me.ShippingAddressGoogeMapsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShippingAddressGoogeMapsButton.Name = "ShippingAddressGoogeMapsButton"
        Me.ShippingAddressGoogeMapsButton.Size = New System.Drawing.Size(23, 22)
        Me.ShippingAddressGoogeMapsButton.Text = "Google Maps Check"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(330, 101)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(302, 26)
        Me.EmailTextBox.TabIndex = 24
        '
        'Fax_NumberTextBox
        '
        Me.Fax_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Fax Number", True))
        Me.Fax_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fax_NumberTextBox.Location = New System.Drawing.Point(107, 101)
        Me.Fax_NumberTextBox.Name = "Fax_NumberTextBox"
        Me.Fax_NumberTextBox.Size = New System.Drawing.Size(126, 26)
        Me.Fax_NumberTextBox.TabIndex = 23
        '
        'PKCustomerIDTextBox
        '
        Me.PKCustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "PKCustomerID", True))
        Me.PKCustomerIDTextBox.Enabled = False
        Me.PKCustomerIDTextBox.Location = New System.Drawing.Point(107, 11)
        Me.PKCustomerIDTextBox.Name = "PKCustomerIDTextBox"
        Me.PKCustomerIDTextBox.Size = New System.Drawing.Size(53, 20)
        Me.PKCustomerIDTextBox.TabIndex = 2
        Me.PKCustomerIDTextBox.Visible = False
        '
        'Company_NameTextBox
        '
        Me.Company_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Company Name", True))
        Me.Company_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company_NameTextBox.Location = New System.Drawing.Point(107, 37)
        Me.Company_NameTextBox.Name = "Company_NameTextBox"
        Me.Company_NameTextBox.Size = New System.Drawing.Size(525, 26)
        Me.Company_NameTextBox.TabIndex = 1
        '
        'Contact_NameTextBox
        '
        Me.Contact_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Contact Name", True))
        Me.Contact_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_NameTextBox.Location = New System.Drawing.Point(107, 69)
        Me.Contact_NameTextBox.Name = "Contact_NameTextBox"
        Me.Contact_NameTextBox.Size = New System.Drawing.Size(525, 26)
        Me.Contact_NameTextBox.TabIndex = 2
        '
        'ShippingAddressCustomerNameTextBox
        '
        Me.ShippingAddressCustomerNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShippingAddressCustomerNameTextBox.Location = New System.Drawing.Point(125, 71)
        Me.ShippingAddressCustomerNameTextBox.Name = "ShippingAddressCustomerNameTextBox"
        Me.ShippingAddressCustomerNameTextBox.ReadOnly = True
        Me.ShippingAddressCustomerNameTextBox.Size = New System.Drawing.Size(146, 26)
        Me.ShippingAddressCustomerNameTextBox.TabIndex = 22
        Me.ShippingAddressCustomerNameTextBox.TabStop = False
        '
        'ShippingAddressIDTextBox
        '
        Me.ShippingAddressIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipping_AddressesBindingSource, "ShippingAddressID", True))
        Me.ShippingAddressIDTextBox.Enabled = False
        Me.ShippingAddressIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShippingAddressIDTextBox.Location = New System.Drawing.Point(125, 45)
        Me.ShippingAddressIDTextBox.Name = "ShippingAddressIDTextBox"
        Me.ShippingAddressIDTextBox.Size = New System.Drawing.Size(146, 26)
        Me.ShippingAddressIDTextBox.TabIndex = 12
        Me.ShippingAddressIDTextBox.Visible = False
        '
        'Addr1TextBox1
        '
        Me.Addr1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipping_AddressesBindingSource, "Addr1", True))
        Me.Addr1TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addr1TextBox1.Location = New System.Drawing.Point(125, 97)
        Me.Addr1TextBox1.Name = "Addr1TextBox1"
        Me.Addr1TextBox1.Size = New System.Drawing.Size(146, 26)
        Me.Addr1TextBox1.TabIndex = 13
        '
        'Addr2TextBox1
        '
        Me.Addr2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipping_AddressesBindingSource, "Addr2", True))
        Me.Addr2TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addr2TextBox1.Location = New System.Drawing.Point(125, 123)
        Me.Addr2TextBox1.Name = "Addr2TextBox1"
        Me.Addr2TextBox1.Size = New System.Drawing.Size(146, 26)
        Me.Addr2TextBox1.TabIndex = 14
        '
        'Addr3TextBox1
        '
        Me.Addr3TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipping_AddressesBindingSource, "Addr3", True))
        Me.Addr3TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addr3TextBox1.Location = New System.Drawing.Point(125, 149)
        Me.Addr3TextBox1.Name = "Addr3TextBox1"
        Me.Addr3TextBox1.Size = New System.Drawing.Size(146, 26)
        Me.Addr3TextBox1.TabIndex = 15
        '
        'CityTextBox1
        '
        Me.CityTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipping_AddressesBindingSource, "City", True))
        Me.CityTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox1.Location = New System.Drawing.Point(125, 175)
        Me.CityTextBox1.Name = "CityTextBox1"
        Me.CityTextBox1.Size = New System.Drawing.Size(146, 26)
        Me.CityTextBox1.TabIndex = 16
        '
        'StateOrProvinceTextBox1
        '
        Me.StateOrProvinceTextBox1.AutoCompleteCustomSource.AddRange(New String() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.StateOrProvinceTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.StateOrProvinceTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.StateOrProvinceTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StateOrProvinceTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipping_AddressesBindingSource, "StateOrProvince", True))
        Me.StateOrProvinceTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateOrProvinceTextBox1.Location = New System.Drawing.Point(125, 201)
        Me.StateOrProvinceTextBox1.Name = "StateOrProvinceTextBox1"
        Me.StateOrProvinceTextBox1.Size = New System.Drawing.Size(146, 26)
        Me.StateOrProvinceTextBox1.TabIndex = 17
        '
        'PostalCodeTextBox1
        '
        Me.PostalCodeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipping_AddressesBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostalCodeTextBox1.Location = New System.Drawing.Point(125, 227)
        Me.PostalCodeTextBox1.Name = "PostalCodeTextBox1"
        Me.PostalCodeTextBox1.Size = New System.Drawing.Size(146, 26)
        Me.PostalCodeTextBox1.TabIndex = 18
        '
        'Country_RegionTextBox1
        '
        Me.Country_RegionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipping_AddressesBindingSource, "Country_Region", True))
        Me.Country_RegionTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Country_RegionTextBox1.Location = New System.Drawing.Point(125, 253)
        Me.Country_RegionTextBox1.Name = "Country_RegionTextBox1"
        Me.Country_RegionTextBox1.Size = New System.Drawing.Size(146, 26)
        Me.Country_RegionTextBox1.TabIndex = 19
        '
        'FKCustomerIDTextBox1
        '
        Me.FKCustomerIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shipping_AddressesBindingSource, "FKCustomerID", True))
        Me.FKCustomerIDTextBox1.Enabled = False
        Me.FKCustomerIDTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FKCustomerIDTextBox1.Location = New System.Drawing.Point(125, 330)
        Me.FKCustomerIDTextBox1.Name = "FKCustomerIDTextBox1"
        Me.FKCustomerIDTextBox1.Size = New System.Drawing.Size(146, 26)
        Me.FKCustomerIDTextBox1.TabIndex = 20
        Me.FKCustomerIDTextBox1.Visible = False
        '
        'BillingAddressCustomerNameTextBox
        '
        Me.BillingAddressCustomerNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillingAddressCustomerNameTextBox.Location = New System.Drawing.Point(107, 71)
        Me.BillingAddressCustomerNameTextBox.Name = "BillingAddressCustomerNameTextBox"
        Me.BillingAddressCustomerNameTextBox.ReadOnly = True
        Me.BillingAddressCustomerNameTextBox.Size = New System.Drawing.Size(146, 26)
        Me.BillingAddressCustomerNameTextBox.TabIndex = 20
        Me.BillingAddressCustomerNameTextBox.TabStop = False
        '
        'BillingAddressIDTextBox
        '
        Me.BillingAddressIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Billing_AddressesBindingSource, "BillingAddressID", True))
        Me.BillingAddressIDTextBox.Enabled = False
        Me.BillingAddressIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillingAddressIDTextBox.Location = New System.Drawing.Point(107, 45)
        Me.BillingAddressIDTextBox.Name = "BillingAddressIDTextBox"
        Me.BillingAddressIDTextBox.Size = New System.Drawing.Size(146, 26)
        Me.BillingAddressIDTextBox.TabIndex = 3
        Me.BillingAddressIDTextBox.Visible = False
        '
        'Addr1TextBox
        '
        Me.Addr1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Billing_AddressesBindingSource, "Addr1", True))
        Me.Addr1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addr1TextBox.Location = New System.Drawing.Point(107, 97)
        Me.Addr1TextBox.Name = "Addr1TextBox"
        Me.Addr1TextBox.Size = New System.Drawing.Size(146, 26)
        Me.Addr1TextBox.TabIndex = 4
        '
        'Addr2TextBox
        '
        Me.Addr2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Billing_AddressesBindingSource, "Addr2", True))
        Me.Addr2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addr2TextBox.Location = New System.Drawing.Point(107, 123)
        Me.Addr2TextBox.Name = "Addr2TextBox"
        Me.Addr2TextBox.Size = New System.Drawing.Size(146, 26)
        Me.Addr2TextBox.TabIndex = 5
        '
        'Addr3TextBox
        '
        Me.Addr3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Billing_AddressesBindingSource, "Addr3", True))
        Me.Addr3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addr3TextBox.Location = New System.Drawing.Point(107, 149)
        Me.Addr3TextBox.Name = "Addr3TextBox"
        Me.Addr3TextBox.Size = New System.Drawing.Size(146, 26)
        Me.Addr3TextBox.TabIndex = 6
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Billing_AddressesBindingSource, "City", True))
        Me.CityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(107, 175)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(146, 26)
        Me.CityTextBox.TabIndex = 7
        '
        'StateOrProvinceTextBox
        '
        Me.StateOrProvinceTextBox.AutoCompleteCustomSource.AddRange(New String() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.StateOrProvinceTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.StateOrProvinceTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.StateOrProvinceTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StateOrProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Billing_AddressesBindingSource, "StateOrProvince", True))
        Me.StateOrProvinceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateOrProvinceTextBox.Location = New System.Drawing.Point(107, 201)
        Me.StateOrProvinceTextBox.Name = "StateOrProvinceTextBox"
        Me.StateOrProvinceTextBox.Size = New System.Drawing.Size(146, 26)
        Me.StateOrProvinceTextBox.TabIndex = 8
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Billing_AddressesBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(107, 227)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(146, 26)
        Me.PostalCodeTextBox.TabIndex = 9
        '
        'Country_RegionTextBox
        '
        Me.Country_RegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Billing_AddressesBindingSource, "Country_Region", True))
        Me.Country_RegionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Country_RegionTextBox.Location = New System.Drawing.Point(107, 253)
        Me.Country_RegionTextBox.Name = "Country_RegionTextBox"
        Me.Country_RegionTextBox.Size = New System.Drawing.Size(146, 26)
        Me.Country_RegionTextBox.TabIndex = 10
        '
        'FKCustomerIDTextBox
        '
        Me.FKCustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Billing_AddressesBindingSource, "FKCustomerID", True))
        Me.FKCustomerIDTextBox.Enabled = False
        Me.FKCustomerIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FKCustomerIDTextBox.Location = New System.Drawing.Point(107, 330)
        Me.FKCustomerIDTextBox.Name = "FKCustomerIDTextBox"
        Me.FKCustomerIDTextBox.Size = New System.Drawing.Size(146, 26)
        Me.FKCustomerIDTextBox.TabIndex = 11
        Me.FKCustomerIDTextBox.Visible = False
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 676)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BillingToShippingButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "Customer"
        Me.Text = "Edit Customer Database"
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Shipping_AddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Billing_AddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CustomersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Billing_AddressesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Billing_AddressesTableAdapter
    Friend WithEvents PKCustomerIDTextBox As TabTextBox
    Friend WithEvents Company_NameTextBox As TabTextBox
    Friend WithEvents Contact_NameTextBox As TabTextBox
    Friend WithEvents Fax_NumberTextBox As TabTextBox
    Friend WithEvents EmailTextBox As TabTextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Billing_AddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillingAddressIDTextBox As TabTextBox
    Friend WithEvents Addr1TextBox As TabTextBox
    Friend WithEvents Addr2TextBox As TabTextBox
    Friend WithEvents Addr3TextBox As TabTextBox
    Friend WithEvents CityTextBox As TabTextBox
    Friend WithEvents StateOrProvinceTextBox As TabTextBox
    Friend WithEvents PostalCodeTextBox As TabTextBox
    Friend WithEvents Country_RegionTextBox As TabTextBox
    Friend WithEvents FKCustomerIDTextBox As TabTextBox
    Friend WithEvents Shipping_AddressesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Shipping_AddressesTableAdapter
    Friend WithEvents Shipping_AddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShippingAddressIDTextBox As TabTextBox
    Friend WithEvents Addr1TextBox1 As TabTextBox
    Friend WithEvents Addr2TextBox1 As TabTextBox
    Friend WithEvents Addr3TextBox1 As TabTextBox
    Friend WithEvents CityTextBox1 As TabTextBox
    Friend WithEvents StateOrProvinceTextBox1 As TabTextBox
    Friend WithEvents PostalCodeTextBox1 As TabTextBox
    Friend WithEvents Country_RegionTextBox1 As TabTextBox
    Friend WithEvents FKCustomerIDTextBox1 As TabTextBox
    Friend WithEvents BillingToShippingButton As System.Windows.Forms.Button
    Friend WithEvents FilterButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BillingAddressCustomerNameTextBox As TabTextBox
    Friend WithEvents ShippingAddressCustomerNameTextBox As TabTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ExtensionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExtensionTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BillingAddressGoogeMapsButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ShippingAddressGoogeMapsButton As System.Windows.Forms.ToolStripButton
End Class
