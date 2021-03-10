<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReport
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GenerateButton = New System.Windows.Forms.Button
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.CaviarInventoryInvoiceFlatTableTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarInventoryInvoiceFlatTableTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.Caviar_FishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
        Me.FemaleFishInventoryTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.FemaleFishInventoryTableAdapter
        Me.MaleFishHarvestTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.MaleFishHarvestTableAdapter
        Me.NonInventoryInvoiceFlatTableTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.NonInventoryInvoiceFlatTableTableAdapter
        Me.WeightConversionConstantsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.WeightConversionConstantsTableAdapter
        Me.EndDateTimePicker = New Sturgeon_Manager_v1._0.Controls.MyDateTimePicker
        Me.BeginDateTimePicker = New Sturgeon_Manager_v1._0.Controls.MyDateTimePicker
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Begin Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "End Time:"
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(242, 84)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(81, 42)
        Me.GenerateButton.TabIndex = 4
        Me.GenerateButton.Text = "Generate Report"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CaviarInventoryInvoiceFlatTableTableAdapter
        '
        Me.CaviarInventoryInvoiceFlatTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Application_SettingsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_FishTableAdapter = Me.Caviar_FishTableAdapter
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryInvoiceFlatTableTableAdapter = Me.CaviarInventoryInvoiceFlatTableTableAdapter
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryValueTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Customer_PricingTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.FemaleFishInventoryTableAdapter = Me.FemaleFishInventoryTableAdapter
        Me.TableAdapterManager.FilterColumnsTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTypeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.MaleFishHarvestTableAdapter = Me.MaleFishHarvestTableAdapter
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Nothing
        Me.TableAdapterManager.NonInventoryInvoiceFlatTableTableAdapter = Me.NonInventoryInvoiceFlatTableTableAdapter
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.RepackLossTableAdapter = Nothing
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeightConversionConstantsTableAdapter = Me.WeightConversionConstantsTableAdapter
        '
        'Caviar_FishTableAdapter
        '
        Me.Caviar_FishTableAdapter.ClearBeforeFill = True
        '
        'FemaleFishInventoryTableAdapter
        '
        Me.FemaleFishInventoryTableAdapter.ClearBeforeFill = True
        '
        'MaleFishHarvestTableAdapter
        '
        Me.MaleFishHarvestTableAdapter.ClearBeforeFill = True
        '
        'NonInventoryInvoiceFlatTableTableAdapter
        '
        Me.NonInventoryInvoiceFlatTableTableAdapter.ClearBeforeFill = True
        '
        'WeightConversionConstantsTableAdapter
        '
        Me.WeightConversionConstantsTableAdapter.ClearBeforeFill = True
        '
        'EndDateTimePicker
        '
        Me.EndDateTimePicker.Location = New System.Drawing.Point(110, 58)
        Me.EndDateTimePicker.Name = "EndDateTimePicker"
        Me.EndDateTimePicker.Size = New System.Drawing.Size(213, 20)
        Me.EndDateTimePicker.TabIndex = 2
        '
        'BeginDateTimePicker
        '
        Me.BeginDateTimePicker.Location = New System.Drawing.Point(110, 32)
        Me.BeginDateTimePicker.Name = "BeginDateTimePicker"
        Me.BeginDateTimePicker.Size = New System.Drawing.Size(213, 20)
        Me.BeginDateTimePicker.TabIndex = 0
        '
        'SalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 138)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EndDateTimePicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BeginDateTimePicker)
        Me.Name = "SalesReport"
        Me.Text = "Sales Report Generation Guide"
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents CaviarInventoryInvoiceFlatTableTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarInventoryInvoiceFlatTableTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NonInventoryInvoiceFlatTableTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.NonInventoryInvoiceFlatTableTableAdapter
    Friend WithEvents BeginDateTimePicker As Sturgeon_Manager_v1._0.Controls.MyDateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EndDateTimePicker As Sturgeon_Manager_v1._0.Controls.MyDateTimePicker
    Friend WithEvents GenerateButton As System.Windows.Forms.Button
    Friend WithEvents WeightConversionConstantsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.WeightConversionConstantsTableAdapter
    Friend WithEvents FemaleFishInventoryTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.FemaleFishInventoryTableAdapter
    Friend WithEvents MaleFishHarvestTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.MaleFishHarvestTableAdapter
    Friend WithEvents Caviar_FishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
End Class
