<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowseData
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
        Me.MainFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.Caviar_FishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.Billing_AddressesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Billing_AddressesTableAdapter
        Me.Caviar_InventoryTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
        Me.CaviarStatusSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
        Me.Customer_PricingTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Customer_PricingTableAdapter
        Me.CustomersTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CustomersTableAdapter
        Me.GradeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
        Me.InvoicesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoicesTableAdapter
        Me.InvoiceTypeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoiceTypeSelectionTableAdapter
        Me.Non_Inventory_Invoice_RecordsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Non_Inventory_Invoice_RecordsTableAdapter
        Me.ProductCategorySelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductCategorySelectionTableAdapter
        Me.ProductsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
        Me.Shipping_AddressesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Shipping_AddressesTableAdapter
        Me.CaviarFlatTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaviarFlatTableTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarFlatTableTableAdapter
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarFlatTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainFlowLayoutPanel
        '
        Me.MainFlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainFlowLayoutPanel.AutoScroll = True
        Me.MainFlowLayoutPanel.Location = New System.Drawing.Point(12, 12)
        Me.MainFlowLayoutPanel.Name = "MainFlowLayoutPanel"
        Me.MainFlowLayoutPanel.Size = New System.Drawing.Size(828, 378)
        Me.MainFlowLayoutPanel.TabIndex = 1
        Me.MainFlowLayoutPanel.WrapContents = False
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
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
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
        'CaviarFlatTableBindingSource
        '
        Me.CaviarFlatTableBindingSource.DataMember = "CaviarFlatTable"
        Me.CaviarFlatTableBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'CaviarFlatTableTableAdapter
        '
        Me.CaviarFlatTableTableAdapter.ClearBeforeFill = True
        '
        'BrowseData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 402)
        Me.Controls.Add(Me.MainFlowLayoutPanel)
        Me.Name = "BrowseData"
        Me.Text = "BrowseData"
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarFlatTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents Caviar_FishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Billing_AddressesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Billing_AddressesTableAdapter
    Friend WithEvents Caviar_InventoryTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
    Friend WithEvents CaviarStatusSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
    Friend WithEvents Customer_PricingTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Customer_PricingTableAdapter
    Friend WithEvents CustomersTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents GradeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
    Friend WithEvents InvoicesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents InvoiceTypeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoiceTypeSelectionTableAdapter
    Friend WithEvents Non_Inventory_Invoice_RecordsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Non_Inventory_Invoice_RecordsTableAdapter
    Friend WithEvents ProductCategorySelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductCategorySelectionTableAdapter
    Friend WithEvents ProductsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents Shipping_AddressesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Shipping_AddressesTableAdapter
    Friend WithEvents MainFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CaviarFlatTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarFlatTableTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarFlatTableTableAdapter
End Class
