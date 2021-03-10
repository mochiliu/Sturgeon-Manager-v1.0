<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeightConversionConstants
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
        Dim EffectiveDateLabel As System.Windows.Forms.Label
        Dim FilletShrinkageCorrectionLabel As System.Windows.Forms.Label
        Dim BulletShrinkageCorrectionLabel As System.Windows.Forms.Label
        Dim WholeGuttedShrinkageCorrectionLabel As System.Windows.Forms.Label
        Dim FilletToCWGLabel As System.Windows.Forms.Label
        Dim BulletToCWGLabel As System.Windows.Forms.Label
        Dim MaleCWGToCLFLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WeightConversionConstants))
        Dim FemaleCWGToCLFLabel As System.Windows.Forms.Label
        Me.WeightConversionConstantsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.WeightConversionConstantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.WeightConversionConstantsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.EffectiveDateMyDateTimePicker = New Sturgeon_Manager_v1._0.Controls.MyDateTimePicker
        Me.FilletShrinkageCorrectionTextBox = New System.Windows.Forms.TextBox
        Me.BulletShrinkageCorrectionTextBox = New System.Windows.Forms.TextBox
        Me.WholeGuttedShrinkageCorrectionTextBox = New System.Windows.Forms.TextBox
        Me.FilletToCWGTextBox = New System.Windows.Forms.TextBox
        Me.BulletToCWGTextBox = New System.Windows.Forms.TextBox
        Me.MaleCWGToCLFTextBox = New System.Windows.Forms.TextBox
        Me.WeightConversionConstantsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.WeightConversionConstantsTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.FemaleCWGToCLFTextBox = New System.Windows.Forms.TextBox
        EffectiveDateLabel = New System.Windows.Forms.Label
        FilletShrinkageCorrectionLabel = New System.Windows.Forms.Label
        BulletShrinkageCorrectionLabel = New System.Windows.Forms.Label
        WholeGuttedShrinkageCorrectionLabel = New System.Windows.Forms.Label
        FilletToCWGLabel = New System.Windows.Forms.Label
        BulletToCWGLabel = New System.Windows.Forms.Label
        MaleCWGToCLFLabel = New System.Windows.Forms.Label
        FemaleCWGToCLFLabel = New System.Windows.Forms.Label
        CType(Me.WeightConversionConstantsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WeightConversionConstantsBindingNavigator.SuspendLayout()
        CType(Me.WeightConversionConstantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EffectiveDateLabel
        '
        EffectiveDateLabel.AutoSize = True
        EffectiveDateLabel.Location = New System.Drawing.Point(23, 38)
        EffectiveDateLabel.Name = "EffectiveDateLabel"
        EffectiveDateLabel.Size = New System.Drawing.Size(78, 13)
        EffectiveDateLabel.TabIndex = 3
        EffectiveDateLabel.Text = "Effective Date:"
        '
        'FilletShrinkageCorrectionLabel
        '
        FilletShrinkageCorrectionLabel.AutoSize = True
        FilletShrinkageCorrectionLabel.Location = New System.Drawing.Point(23, 63)
        FilletShrinkageCorrectionLabel.Name = "FilletShrinkageCorrectionLabel"
        FilletShrinkageCorrectionLabel.Size = New System.Drawing.Size(133, 13)
        FilletShrinkageCorrectionLabel.TabIndex = 5
        FilletShrinkageCorrectionLabel.Text = "Fillet Shrinkage Correction:"
        '
        'BulletShrinkageCorrectionLabel
        '
        BulletShrinkageCorrectionLabel.AutoSize = True
        BulletShrinkageCorrectionLabel.Location = New System.Drawing.Point(23, 89)
        BulletShrinkageCorrectionLabel.Name = "BulletShrinkageCorrectionLabel"
        BulletShrinkageCorrectionLabel.Size = New System.Drawing.Size(138, 13)
        BulletShrinkageCorrectionLabel.TabIndex = 7
        BulletShrinkageCorrectionLabel.Text = "Bullet Shrinkage Correction:"
        '
        'WholeGuttedShrinkageCorrectionLabel
        '
        WholeGuttedShrinkageCorrectionLabel.AutoSize = True
        WholeGuttedShrinkageCorrectionLabel.Location = New System.Drawing.Point(23, 115)
        WholeGuttedShrinkageCorrectionLabel.Name = "WholeGuttedShrinkageCorrectionLabel"
        WholeGuttedShrinkageCorrectionLabel.Size = New System.Drawing.Size(178, 13)
        WholeGuttedShrinkageCorrectionLabel.TabIndex = 9
        WholeGuttedShrinkageCorrectionLabel.Text = "Whole Gutted Shrinkage Correction:"
        '
        'FilletToCWGLabel
        '
        FilletToCWGLabel.AutoSize = True
        FilletToCWGLabel.Location = New System.Drawing.Point(23, 141)
        FilletToCWGLabel.Name = "FilletToCWGLabel"
        FilletToCWGLabel.Size = New System.Drawing.Size(76, 13)
        FilletToCWGLabel.TabIndex = 11
        FilletToCWGLabel.Text = "Fillet To CWG:"
        '
        'BulletToCWGLabel
        '
        BulletToCWGLabel.AutoSize = True
        BulletToCWGLabel.Location = New System.Drawing.Point(23, 167)
        BulletToCWGLabel.Name = "BulletToCWGLabel"
        BulletToCWGLabel.Size = New System.Drawing.Size(81, 13)
        BulletToCWGLabel.TabIndex = 13
        BulletToCWGLabel.Text = "Bullet To CWG:"
        '
        'MaleCWGToCLFLabel
        '
        MaleCWGToCLFLabel.AutoSize = True
        MaleCWGToCLFLabel.Location = New System.Drawing.Point(23, 193)
        MaleCWGToCLFLabel.Name = "MaleCWGToCLFLabel"
        MaleCWGToCLFLabel.Size = New System.Drawing.Size(100, 13)
        MaleCWGToCLFLabel.TabIndex = 15
        MaleCWGToCLFLabel.Text = "Male CWG To CLF:"
        '
        'WeightConversionConstantsBindingNavigator
        '
        Me.WeightConversionConstantsBindingNavigator.AddNewItem = Nothing
        Me.WeightConversionConstantsBindingNavigator.BindingSource = Me.WeightConversionConstantsBindingSource
        Me.WeightConversionConstantsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WeightConversionConstantsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WeightConversionConstantsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WeightConversionConstantsBindingNavigatorSaveItem})
        Me.WeightConversionConstantsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WeightConversionConstantsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WeightConversionConstantsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WeightConversionConstantsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WeightConversionConstantsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WeightConversionConstantsBindingNavigator.Name = "WeightConversionConstantsBindingNavigator"
        Me.WeightConversionConstantsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WeightConversionConstantsBindingNavigator.Size = New System.Drawing.Size(419, 25)
        Me.WeightConversionConstantsBindingNavigator.TabIndex = 0
        Me.WeightConversionConstantsBindingNavigator.Text = "BindingNavigator1"
        '
        'WeightConversionConstantsBindingSource
        '
        Me.WeightConversionConstantsBindingSource.DataMember = "WeightConversionConstants"
        Me.WeightConversionConstantsBindingSource.DataSource = Me.SturgeonDBDataSet
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'WeightConversionConstantsBindingNavigatorSaveItem
        '
        Me.WeightConversionConstantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WeightConversionConstantsBindingNavigatorSaveItem.Image = CType(resources.GetObject("WeightConversionConstantsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WeightConversionConstantsBindingNavigatorSaveItem.Name = "WeightConversionConstantsBindingNavigatorSaveItem"
        Me.WeightConversionConstantsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WeightConversionConstantsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EffectiveDateMyDateTimePicker
        '
        Me.EffectiveDateMyDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WeightConversionConstantsBindingSource, "EffectiveDate", True))
        Me.EffectiveDateMyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EffectiveDateMyDateTimePicker.Location = New System.Drawing.Point(221, 32)
        Me.EffectiveDateMyDateTimePicker.Name = "EffectiveDateMyDateTimePicker"
        Me.EffectiveDateMyDateTimePicker.Size = New System.Drawing.Size(178, 20)
        Me.EffectiveDateMyDateTimePicker.TabIndex = 4
        '
        'FilletShrinkageCorrectionTextBox
        '
        Me.FilletShrinkageCorrectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WeightConversionConstantsBindingSource, "FilletShrinkageCorrection", True))
        Me.FilletShrinkageCorrectionTextBox.Location = New System.Drawing.Point(221, 58)
        Me.FilletShrinkageCorrectionTextBox.Name = "FilletShrinkageCorrectionTextBox"
        Me.FilletShrinkageCorrectionTextBox.Size = New System.Drawing.Size(178, 20)
        Me.FilletShrinkageCorrectionTextBox.TabIndex = 6
        '
        'BulletShrinkageCorrectionTextBox
        '
        Me.BulletShrinkageCorrectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WeightConversionConstantsBindingSource, "BulletShrinkageCorrection", True))
        Me.BulletShrinkageCorrectionTextBox.Location = New System.Drawing.Point(221, 84)
        Me.BulletShrinkageCorrectionTextBox.Name = "BulletShrinkageCorrectionTextBox"
        Me.BulletShrinkageCorrectionTextBox.Size = New System.Drawing.Size(178, 20)
        Me.BulletShrinkageCorrectionTextBox.TabIndex = 8
        '
        'WholeGuttedShrinkageCorrectionTextBox
        '
        Me.WholeGuttedShrinkageCorrectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WeightConversionConstantsBindingSource, "WholeGuttedShrinkageCorrection", True))
        Me.WholeGuttedShrinkageCorrectionTextBox.Location = New System.Drawing.Point(221, 110)
        Me.WholeGuttedShrinkageCorrectionTextBox.Name = "WholeGuttedShrinkageCorrectionTextBox"
        Me.WholeGuttedShrinkageCorrectionTextBox.Size = New System.Drawing.Size(178, 20)
        Me.WholeGuttedShrinkageCorrectionTextBox.TabIndex = 10
        '
        'FilletToCWGTextBox
        '
        Me.FilletToCWGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WeightConversionConstantsBindingSource, "FilletToCWG", True))
        Me.FilletToCWGTextBox.Location = New System.Drawing.Point(221, 136)
        Me.FilletToCWGTextBox.Name = "FilletToCWGTextBox"
        Me.FilletToCWGTextBox.Size = New System.Drawing.Size(178, 20)
        Me.FilletToCWGTextBox.TabIndex = 12
        '
        'BulletToCWGTextBox
        '
        Me.BulletToCWGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WeightConversionConstantsBindingSource, "BulletToCWG", True))
        Me.BulletToCWGTextBox.Location = New System.Drawing.Point(221, 162)
        Me.BulletToCWGTextBox.Name = "BulletToCWGTextBox"
        Me.BulletToCWGTextBox.Size = New System.Drawing.Size(178, 20)
        Me.BulletToCWGTextBox.TabIndex = 14
        '
        'MaleCWGToCLFTextBox
        '
        Me.MaleCWGToCLFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WeightConversionConstantsBindingSource, "MaleCWGToCLF", True))
        Me.MaleCWGToCLFTextBox.Location = New System.Drawing.Point(221, 188)
        Me.MaleCWGToCLFTextBox.Name = "MaleCWGToCLFTextBox"
        Me.MaleCWGToCLFTextBox.Size = New System.Drawing.Size(178, 20)
        Me.MaleCWGToCLFTextBox.TabIndex = 16
        '
        'WeightConversionConstantsTableAdapter
        '
        Me.WeightConversionConstantsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Application_SettingsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_FishTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryInvoiceFlatTableTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryValueTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Customer_PricingTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.FilterColumnsTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTypeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Nothing
        Me.TableAdapterManager.NonInventoryInvoiceFlatTableTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.RepackLossTableAdapter = Nothing
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeightConversionConstantsTableAdapter = Me.WeightConversionConstantsTableAdapter
        '
        'FemaleCWGToCLFLabel
        '
        FemaleCWGToCLFLabel.AutoSize = True
        FemaleCWGToCLFLabel.Location = New System.Drawing.Point(23, 217)
        FemaleCWGToCLFLabel.Name = "FemaleCWGToCLFLabel"
        FemaleCWGToCLFLabel.Size = New System.Drawing.Size(111, 13)
        FemaleCWGToCLFLabel.TabIndex = 16
        FemaleCWGToCLFLabel.Text = "Female CWG To CLF:"
        '
        'FemaleCWGToCLFTextBox
        '
        Me.FemaleCWGToCLFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WeightConversionConstantsBindingSource, "FemaleCWGToCLF", True))
        Me.FemaleCWGToCLFTextBox.Location = New System.Drawing.Point(221, 214)
        Me.FemaleCWGToCLFTextBox.Name = "FemaleCWGToCLFTextBox"
        Me.FemaleCWGToCLFTextBox.Size = New System.Drawing.Size(178, 20)
        Me.FemaleCWGToCLFTextBox.TabIndex = 17
        '
        'WeightConversionConstants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 246)
        Me.Controls.Add(FemaleCWGToCLFLabel)
        Me.Controls.Add(Me.FemaleCWGToCLFTextBox)
        Me.Controls.Add(EffectiveDateLabel)
        Me.Controls.Add(Me.EffectiveDateMyDateTimePicker)
        Me.Controls.Add(FilletShrinkageCorrectionLabel)
        Me.Controls.Add(Me.FilletShrinkageCorrectionTextBox)
        Me.Controls.Add(BulletShrinkageCorrectionLabel)
        Me.Controls.Add(Me.BulletShrinkageCorrectionTextBox)
        Me.Controls.Add(WholeGuttedShrinkageCorrectionLabel)
        Me.Controls.Add(Me.WholeGuttedShrinkageCorrectionTextBox)
        Me.Controls.Add(FilletToCWGLabel)
        Me.Controls.Add(Me.FilletToCWGTextBox)
        Me.Controls.Add(BulletToCWGLabel)
        Me.Controls.Add(Me.BulletToCWGTextBox)
        Me.Controls.Add(MaleCWGToCLFLabel)
        Me.Controls.Add(Me.MaleCWGToCLFTextBox)
        Me.Controls.Add(Me.WeightConversionConstantsBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "WeightConversionConstants"
        Me.Text = "Edit Weight Conversion Constants"
        CType(Me.WeightConversionConstantsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WeightConversionConstantsBindingNavigator.ResumeLayout(False)
        Me.WeightConversionConstantsBindingNavigator.PerformLayout()
        CType(Me.WeightConversionConstantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents WeightConversionConstantsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WeightConversionConstantsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.WeightConversionConstantsTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WeightConversionConstantsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents WeightConversionConstantsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EffectiveDateMyDateTimePicker As Sturgeon_Manager_v1._0.Controls.MyDateTimePicker
    Friend WithEvents FilletShrinkageCorrectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BulletShrinkageCorrectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WholeGuttedShrinkageCorrectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FilletToCWGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BulletToCWGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaleCWGToCLFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FemaleCWGToCLFTextBox As System.Windows.Forms.TextBox
End Class
