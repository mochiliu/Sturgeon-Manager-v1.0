<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportViewer
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
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.Billing_AddressesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Billing_AddressesTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.Caviar_FishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
        Me.Caviar_InventoryTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
        Me.CaviarStatusSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
        Me.Customer_PricingTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Customer_PricingTableAdapter
        Me.CustomersTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CustomersTableAdapter
        Me.GradeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
        Me.InvoicesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoicesTableAdapter
        Me.Non_Inventory_Invoice_RecordsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Non_Inventory_Invoice_RecordsTableAdapter
        Me.ProductCategorySelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductCategorySelectionTableAdapter
        Me.ProductsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
        Me.Shipping_AddressesTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Shipping_AddressesTableAdapter
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.CaviarInventoryValueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaviarInventoryValueTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarInventoryValueTableAdapter
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarInventoryValueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Billing_AddressesTableAdapter
        '
        Me.Billing_AddressesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Application_SettingsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Me.Billing_AddressesTableAdapter
        Me.TableAdapterManager.Caviar_FishTableAdapter = Me.Caviar_FishTableAdapter
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Me.Caviar_InventoryTableAdapter
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryValueTableAdapter = Me.CaviarInventoryValueTableAdapter
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Me.CaviarStatusSelectionTableAdapter
        Me.TableAdapterManager.Customer_PricingTableAdapter = Me.Customer_PricingTableAdapter
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.FilterColumnsTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Me.GradeSelectionTableAdapter
        Me.TableAdapterManager.InvoicesTableAdapter = Me.InvoicesTableAdapter
        Me.TableAdapterManager.InvoiceTypeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Me.Non_Inventory_Invoice_RecordsTableAdapter
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Me.ProductCategorySelectionTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Me.Shipping_AddressesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
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
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = -1
        Me.CrystalReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.EnableDrillDown = False
        Me.CrystalReportViewer.Location = New System.Drawing.Point(0, -1)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.SelectionFormula = ""
        Me.CrystalReportViewer.Size = New System.Drawing.Size(648, 500)
        Me.CrystalReportViewer.TabIndex = 0
        Me.CrystalReportViewer.ViewTimeSelectionFormula = ""
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
        'ReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 500)
        Me.Controls.Add(Me.CrystalReportViewer)
        Me.Name = "ReportViewer"
        Me.Text = "Report Viewer"
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarInventoryValueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents Billing_AddressesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Billing_AddressesTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Caviar_FishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
    Friend WithEvents Caviar_InventoryTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_InventoryTableAdapter
    Friend WithEvents CaviarStatusSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
    Friend WithEvents Customer_PricingTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Customer_PricingTableAdapter
    Friend WithEvents CustomersTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents GradeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
    Friend WithEvents InvoicesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents Non_Inventory_Invoice_RecordsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Non_Inventory_Invoice_RecordsTableAdapter
    Friend WithEvents ProductCategorySelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductCategorySelectionTableAdapter
    Friend WithEvents ProductsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents Shipping_AddressesTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Shipping_AddressesTableAdapter
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CaviarInventoryValueTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarInventoryValueTableAdapter
    Friend WithEvents CaviarInventoryValueBindingSource As System.Windows.Forms.BindingSource
End Class
