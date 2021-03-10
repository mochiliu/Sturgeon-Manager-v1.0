<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaviarInventoryAudit
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
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer
        Me.UnScannedGroupBox = New System.Windows.Forms.GroupBox
        Me.EndAuditButton = New System.Windows.Forms.Button
        Me.NoteButton = New System.Windows.Forms.Button
        Me.AcceptButton = New System.Windows.Forms.Button
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.ProductsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SturgeonDBDataSet = New Sturgeon_Manager_v1._0.SturgeonDBDataSet
        Me.CaviarStatusSelectionBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradeSelectionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaviarStatusSelectionBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MissingCaviarInventoryJoinCaviarFishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProblematicSplitContainer = New System.Windows.Forms.SplitContainer
        Me.NotedGroupBox = New System.Windows.Forms.GroupBox
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView = New Sturgeon_Manager_v1._0.MyDataGridView
        Me.NotesPKBarcodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotesFKProductIDColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotesInventoryStatusColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CaviarStatusSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotesNotesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotesGradeColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.GradeSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotesPreviousStatusColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CaviarStatusSelectionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotesCaviarInventoryJoinCaviarFishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarcodeNotFoundGroupBox = New System.Windows.Forms.GroupBox
        Me.NotFoundTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BarcodeInput = New System.Windows.Forms.TextBox
        Me.CaviarInventoryJoinCaviarFishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarInventoryJoinCaviarFishTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.CaviarStatusSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
        Me.GradeSelectionTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
        Me.ProductsTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
        Me.AudioSpeedTrackBar = New System.Windows.Forms.TrackBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.MissingPKBarcodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MissingFKProductIDColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.MissingNotesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewComboBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewComboBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MainSplitContainer.Panel1.SuspendLayout()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        Me.UnScannedGroupBox.SuspendLayout()
        CType(Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarStatusSelectionBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeSelectionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarStatusSelectionBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MissingCaviarInventoryJoinCaviarFishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProblematicSplitContainer.Panel1.SuspendLayout()
        Me.ProblematicSplitContainer.Panel2.SuspendLayout()
        Me.ProblematicSplitContainer.SuspendLayout()
        Me.NotedGroupBox.SuspendLayout()
        CType(Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaviarStatusSelectionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotesCaviarInventoryJoinCaviarFishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarcodeNotFoundGroupBox.SuspendLayout()
        CType(Me.AudioSpeedTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MainSplitContainer.Location = New System.Drawing.Point(1, 54)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.Controls.Add(Me.UnScannedGroupBox)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.ProblematicSplitContainer)
        Me.MainSplitContainer.Size = New System.Drawing.Size(982, 498)
        Me.MainSplitContainer.SplitterDistance = 424
        Me.MainSplitContainer.TabIndex = 6
        '
        'UnScannedGroupBox
        '
        Me.UnScannedGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnScannedGroupBox.Controls.Add(Me.EndAuditButton)
        Me.UnScannedGroupBox.Controls.Add(Me.NoteButton)
        Me.UnScannedGroupBox.Controls.Add(Me.AcceptButton)
        Me.UnScannedGroupBox.Controls.Add(Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView)
        Me.UnScannedGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.UnScannedGroupBox.Name = "UnScannedGroupBox"
        Me.UnScannedGroupBox.Size = New System.Drawing.Size(414, 488)
        Me.UnScannedGroupBox.TabIndex = 2
        Me.UnScannedGroupBox.TabStop = False
        Me.UnScannedGroupBox.Text = "In Inventory Caviar Not Yet Scanned (Potentially Missing)"
        '
        'EndAuditButton
        '
        Me.EndAuditButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EndAuditButton.Location = New System.Drawing.Point(294, 432)
        Me.EndAuditButton.Name = "EndAuditButton"
        Me.EndAuditButton.Size = New System.Drawing.Size(114, 50)
        Me.EndAuditButton.TabIndex = 6
        Me.EndAuditButton.Text = "End Audit"
        Me.EndAuditButton.UseVisualStyleBackColor = True
        '
        'NoteButton
        '
        Me.NoteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NoteButton.Enabled = False
        Me.NoteButton.Location = New System.Drawing.Point(152, 432)
        Me.NoteButton.Name = "NoteButton"
        Me.NoteButton.Size = New System.Drawing.Size(114, 50)
        Me.NoteButton.TabIndex = 3
        Me.NoteButton.Text = "Flag"
        Me.NoteButton.UseVisualStyleBackColor = True
        '
        'AcceptButton
        '
        Me.AcceptButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AcceptButton.Enabled = False
        Me.AcceptButton.Location = New System.Drawing.Point(6, 432)
        Me.AcceptButton.Name = "AcceptButton"
        Me.AcceptButton.Size = New System.Drawing.Size(114, 50)
        Me.AcceptButton.TabIndex = 2
        Me.AcceptButton.Text = "Accept"
        Me.AcceptButton.UseVisualStyleBackColor = True
        '
        'MissingCaviarInventoryJoinCaviarFishMyDataGridView
        '
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.AllowUserToAddRows = False
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.AllowUserToDeleteRows = False
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.AllowUserToResizeRows = False
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.AutoGenerateColumns = False
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MissingPKBarcodeColumn, Me.MissingFKProductIDColumn, Me.DataGridViewComboBoxColumn2, Me.MissingNotesColumn, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn30, Me.DataGridViewComboBoxColumn3, Me.DataGridViewTextBoxColumn31, Me.DataGridViewComboBoxColumn4, Me.DataGridViewTextBoxColumn32})
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.DataSource = Me.MissingCaviarInventoryJoinCaviarFishBindingSource
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.Location = New System.Drawing.Point(7, 21)
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.MultiSelect = False
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.Name = "MissingCaviarInventoryJoinCaviarFishMyDataGridView"
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.ReadOnly = True
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.Size = New System.Drawing.Size(407, 405)
        Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView.TabIndex = 1
        '
        'ProductsBindingSource1
        '
        Me.ProductsBindingSource1.DataMember = "Products"
        Me.ProductsBindingSource1.DataSource = Me.SturgeonDBDataSet
        '
        'SturgeonDBDataSet
        '
        Me.SturgeonDBDataSet.DataSetName = "SturgeonDBDataSet"
        Me.SturgeonDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CaviarStatusSelectionBindingSource2
        '
        Me.CaviarStatusSelectionBindingSource2.DataMember = "CaviarStatusSelection"
        Me.CaviarStatusSelectionBindingSource2.DataSource = Me.SturgeonDBDataSet
        '
        'GradeSelectionBindingSource1
        '
        Me.GradeSelectionBindingSource1.DataMember = "GradeSelection"
        Me.GradeSelectionBindingSource1.DataSource = Me.SturgeonDBDataSet
        '
        'CaviarStatusSelectionBindingSource3
        '
        Me.CaviarStatusSelectionBindingSource3.DataMember = "CaviarStatusSelection"
        Me.CaviarStatusSelectionBindingSource3.DataSource = Me.SturgeonDBDataSet
        '
        'MissingCaviarInventoryJoinCaviarFishBindingSource
        '
        Me.MissingCaviarInventoryJoinCaviarFishBindingSource.DataMember = "CaviarInventoryJoinCaviarFish"
        Me.MissingCaviarInventoryJoinCaviarFishBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'ProblematicSplitContainer
        '
        Me.ProblematicSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProblematicSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProblematicSplitContainer.Location = New System.Drawing.Point(-1, 0)
        Me.ProblematicSplitContainer.Name = "ProblematicSplitContainer"
        Me.ProblematicSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ProblematicSplitContainer.Panel1
        '
        Me.ProblematicSplitContainer.Panel1.Controls.Add(Me.NotedGroupBox)
        '
        'ProblematicSplitContainer.Panel2
        '
        Me.ProblematicSplitContainer.Panel2.Controls.Add(Me.BarcodeNotFoundGroupBox)
        Me.ProblematicSplitContainer.Size = New System.Drawing.Size(553, 496)
        Me.ProblematicSplitContainer.SplitterDistance = 314
        Me.ProblematicSplitContainer.TabIndex = 0
        '
        'NotedGroupBox
        '
        Me.NotedGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotedGroupBox.Controls.Add(Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView)
        Me.NotedGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.NotedGroupBox.Name = "NotedGroupBox"
        Me.NotedGroupBox.Size = New System.Drawing.Size(543, 304)
        Me.NotedGroupBox.TabIndex = 5
        Me.NotedGroupBox.TabStop = False
        Me.NotedGroupBox.Text = "Caviar Flagged"
        '
        'NotesCaviarInventoryJoinCaviarFishMyDataGridView
        '
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView.AllowUserToAddRows = False
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView.AllowUserToDeleteRows = False
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView.AutoGenerateColumns = False
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NotesPKBarcodeColumn, Me.NotesFKProductIDColumn, Me.NotesInventoryStatusColumn, Me.NotesNotesColumn, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.NotesGradeColumn, Me.DataGridViewTextBoxColumn21, Me.NotesPreviousStatusColumn, Me.DataGridViewTextBoxColumn29})
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView.DataSource = Me.NotesCaviarInventoryJoinCaviarFishBindingSource
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView.MultiSelect = False
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView.Name = "NotesCaviarInventoryJoinCaviarFishMyDataGridView"
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView.Size = New System.Drawing.Size(531, 279)
        Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView.TabIndex = 0
        '
        'NotesPKBarcodeColumn
        '
        Me.NotesPKBarcodeColumn.DataPropertyName = "PKBarcode"
        Me.NotesPKBarcodeColumn.HeaderText = "Barcode"
        Me.NotesPKBarcodeColumn.Name = "NotesPKBarcodeColumn"
        '
        'NotesFKProductIDColumn
        '
        Me.NotesFKProductIDColumn.DataPropertyName = "FKProductID"
        Me.NotesFKProductIDColumn.DataSource = Me.ProductsBindingSource
        Me.NotesFKProductIDColumn.DisplayMember = "Product Name"
        Me.NotesFKProductIDColumn.HeaderText = "Product"
        Me.NotesFKProductIDColumn.Name = "NotesFKProductIDColumn"
        Me.NotesFKProductIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NotesFKProductIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NotesFKProductIDColumn.ValueMember = "PKProductID"
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'NotesInventoryStatusColumn
        '
        Me.NotesInventoryStatusColumn.DataPropertyName = "InventoryStatus"
        Me.NotesInventoryStatusColumn.DataSource = Me.CaviarStatusSelectionBindingSource
        Me.NotesInventoryStatusColumn.DisplayMember = "Description"
        Me.NotesInventoryStatusColumn.HeaderText = "Inventory Status"
        Me.NotesInventoryStatusColumn.Name = "NotesInventoryStatusColumn"
        Me.NotesInventoryStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NotesInventoryStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NotesInventoryStatusColumn.ValueMember = "PKStatusID"
        '
        'CaviarStatusSelectionBindingSource
        '
        Me.CaviarStatusSelectionBindingSource.DataMember = "CaviarStatusSelection"
        Me.CaviarStatusSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'NotesNotesColumn
        '
        Me.NotesNotesColumn.DataPropertyName = "Notes"
        Me.NotesNotesColumn.HeaderText = "Notes"
        Me.NotesNotesColumn.Name = "NotesNotesColumn"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Harvest Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Harvest Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tag"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tag"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Species"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Species"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Eggsize"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Egg Size"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Taste"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Taste"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Firmness"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Firmness"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Egg Color"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Egg Color"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'NotesGradeColumn
        '
        Me.NotesGradeColumn.DataPropertyName = "Grade"
        Me.NotesGradeColumn.DataSource = Me.GradeSelectionBindingSource
        Me.NotesGradeColumn.DisplayMember = "Grade"
        Me.NotesGradeColumn.HeaderText = "Grade"
        Me.NotesGradeColumn.Name = "NotesGradeColumn"
        Me.NotesGradeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NotesGradeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NotesGradeColumn.ValueMember = "ID"
        '
        'GradeSelectionBindingSource
        '
        Me.GradeSelectionBindingSource.DataMember = "GradeSelection"
        Me.GradeSelectionBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "FKInvoiceID"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Invoice Number"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'NotesPreviousStatusColumn
        '
        Me.NotesPreviousStatusColumn.DataPropertyName = "PreviousStatus"
        Me.NotesPreviousStatusColumn.DataSource = Me.CaviarStatusSelectionBindingSource1
        Me.NotesPreviousStatusColumn.DisplayMember = "Description"
        Me.NotesPreviousStatusColumn.HeaderText = "PreviousStatus"
        Me.NotesPreviousStatusColumn.Name = "NotesPreviousStatusColumn"
        Me.NotesPreviousStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NotesPreviousStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NotesPreviousStatusColumn.ValueMember = "PKStatusID"
        '
        'CaviarStatusSelectionBindingSource1
        '
        Me.CaviarStatusSelectionBindingSource1.DataMember = "CaviarStatusSelection"
        Me.CaviarStatusSelectionBindingSource1.DataSource = Me.SturgeonDBDataSet
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "DateStatusChanged"
        Me.DataGridViewTextBoxColumn29.HeaderText = "DateStatusChanged"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'NotesCaviarInventoryJoinCaviarFishBindingSource
        '
        Me.NotesCaviarInventoryJoinCaviarFishBindingSource.DataMember = "CaviarInventoryJoinCaviarFish"
        Me.NotesCaviarInventoryJoinCaviarFishBindingSource.DataSource = Me.SturgeonDBDataSet
        '
        'BarcodeNotFoundGroupBox
        '
        Me.BarcodeNotFoundGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BarcodeNotFoundGroupBox.Controls.Add(Me.NotFoundTextBox)
        Me.BarcodeNotFoundGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.BarcodeNotFoundGroupBox.Name = "BarcodeNotFoundGroupBox"
        Me.BarcodeNotFoundGroupBox.Size = New System.Drawing.Size(543, 168)
        Me.BarcodeNotFoundGroupBox.TabIndex = 4
        Me.BarcodeNotFoundGroupBox.TabStop = False
        Me.BarcodeNotFoundGroupBox.Text = "Barcodes Not Found In Database"
        '
        'NotFoundTextBox
        '
        Me.NotFoundTextBox.AcceptsReturn = True
        Me.NotFoundTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotFoundTextBox.Location = New System.Drawing.Point(5, 16)
        Me.NotFoundTextBox.Multiline = True
        Me.NotFoundTextBox.Name = "NotFoundTextBox"
        Me.NotFoundTextBox.ReadOnly = True
        Me.NotFoundTextBox.Size = New System.Drawing.Size(530, 147)
        Me.NotFoundTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Scan Barcode Here:"
        '
        'BarcodeInput
        '
        Me.BarcodeInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BarcodeInput.BackColor = System.Drawing.Color.Red
        Me.BarcodeInput.Location = New System.Drawing.Point(168, 12)
        Me.BarcodeInput.Name = "BarcodeInput"
        Me.BarcodeInput.Size = New System.Drawing.Size(546, 20)
        Me.BarcodeInput.TabIndex = 0
        '
        'CaviarInventoryJoinCaviarFishTableAdapter
        '
        Me.CaviarInventoryJoinCaviarFishTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Application_SettingsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_FishTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryInvoiceFlatTableTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Me.CaviarInventoryJoinCaviarFishTableAdapter
        Me.TableAdapterManager.CaviarInventoryValueTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Me.CaviarStatusSelectionTableAdapter
        Me.TableAdapterManager.ConcurrencyHandlerTableAdapter = Nothing
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
        'AudioSpeedTrackBar
        '
        Me.AudioSpeedTrackBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AudioSpeedTrackBar.Location = New System.Drawing.Point(848, 3)
        Me.AudioSpeedTrackBar.Maximum = 300
        Me.AudioSpeedTrackBar.Minimum = 50
        Me.AudioSpeedTrackBar.Name = "AudioSpeedTrackBar"
        Me.AudioSpeedTrackBar.Size = New System.Drawing.Size(130, 45)
        Me.AudioSpeedTrackBar.TabIndex = 9
        Me.AudioSpeedTrackBar.TickFrequency = 10
        Me.AudioSpeedTrackBar.Value = 100
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(741, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Audio Speed"
        '
        'MissingPKBarcodeColumn
        '
        Me.MissingPKBarcodeColumn.DataPropertyName = "PKBarcode"
        Me.MissingPKBarcodeColumn.HeaderText = "Barcode"
        Me.MissingPKBarcodeColumn.Name = "MissingPKBarcodeColumn"
        Me.MissingPKBarcodeColumn.ReadOnly = True
        '
        'MissingFKProductIDColumn
        '
        Me.MissingFKProductIDColumn.DataPropertyName = "FKProductID"
        Me.MissingFKProductIDColumn.DataSource = Me.ProductsBindingSource1
        Me.MissingFKProductIDColumn.DisplayMember = "Product Name"
        Me.MissingFKProductIDColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MissingFKProductIDColumn.HeaderText = "Product"
        Me.MissingFKProductIDColumn.Name = "MissingFKProductIDColumn"
        Me.MissingFKProductIDColumn.ReadOnly = True
        Me.MissingFKProductIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MissingFKProductIDColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MissingFKProductIDColumn.ValueMember = "PKProductID"
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.DataPropertyName = "InventoryStatus"
        Me.DataGridViewComboBoxColumn2.DataSource = Me.CaviarStatusSelectionBindingSource2
        Me.DataGridViewComboBoxColumn2.DisplayMember = "Description"
        Me.DataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn2.HeaderText = "Inventory Status"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.ReadOnly = True
        Me.DataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn2.ValueMember = "PKStatusID"
        '
        'MissingNotesColumn
        '
        Me.MissingNotesColumn.DataPropertyName = "Notes"
        Me.MissingNotesColumn.HeaderText = "Notes"
        Me.MissingNotesColumn.Name = "MissingNotesColumn"
        Me.MissingNotesColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Harvest Date"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Harvest Date"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Tag"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Tag"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Species"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Species"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Eggsize"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Egg Size"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Taste"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Taste"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Firmness"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Firmness"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Egg Color"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Egg Color"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewComboBoxColumn3
        '
        Me.DataGridViewComboBoxColumn3.DataPropertyName = "Grade"
        Me.DataGridViewComboBoxColumn3.DataSource = Me.GradeSelectionBindingSource1
        Me.DataGridViewComboBoxColumn3.DisplayMember = "Grade"
        Me.DataGridViewComboBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn3.HeaderText = "Grade"
        Me.DataGridViewComboBoxColumn3.Name = "DataGridViewComboBoxColumn3"
        Me.DataGridViewComboBoxColumn3.ReadOnly = True
        Me.DataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn3.ValueMember = "ID"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "FKInvoiceID"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Invoice Number"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'DataGridViewComboBoxColumn4
        '
        Me.DataGridViewComboBoxColumn4.DataPropertyName = "PreviousStatus"
        Me.DataGridViewComboBoxColumn4.DataSource = Me.CaviarStatusSelectionBindingSource3
        Me.DataGridViewComboBoxColumn4.DisplayMember = "Description"
        Me.DataGridViewComboBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn4.HeaderText = "PreviousStatus"
        Me.DataGridViewComboBoxColumn4.Name = "DataGridViewComboBoxColumn4"
        Me.DataGridViewComboBoxColumn4.ReadOnly = True
        Me.DataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn4.ValueMember = "PKStatusID"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "DateStatusChanged"
        Me.DataGridViewTextBoxColumn32.HeaderText = "DateStatusChanged"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'CaviarInventoryAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 554)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AudioSpeedTrackBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BarcodeInput)
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Name = "CaviarInventoryAudit"
        Me.Text = "Caviar Inventory Audit"
        Me.MainSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        Me.MainSplitContainer.ResumeLayout(False)
        Me.UnScannedGroupBox.ResumeLayout(False)
        CType(Me.MissingCaviarInventoryJoinCaviarFishMyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarStatusSelectionBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeSelectionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarStatusSelectionBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MissingCaviarInventoryJoinCaviarFishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProblematicSplitContainer.Panel1.ResumeLayout(False)
        Me.ProblematicSplitContainer.Panel2.ResumeLayout(False)
        Me.ProblematicSplitContainer.ResumeLayout(False)
        Me.NotedGroupBox.ResumeLayout(False)
        CType(Me.NotesCaviarInventoryJoinCaviarFishMyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarStatusSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaviarStatusSelectionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotesCaviarInventoryJoinCaviarFishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarcodeNotFoundGroupBox.ResumeLayout(False)
        Me.BarcodeNotFoundGroupBox.PerformLayout()
        CType(Me.AudioSpeedTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents UnScannedGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ProblematicSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents BarcodeNotFoundGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BarcodeInput As System.Windows.Forms.TextBox
    Friend WithEvents NotedGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents NotesCaviarInventoryJoinCaviarFishBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarInventoryJoinCaviarFishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarInventoryJoinCaviarFishTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NotesCaviarInventoryJoinCaviarFishMyDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents CaviarStatusSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.CaviarStatusSelectionTableAdapter
    Friend WithEvents CaviarStatusSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradeSelectionTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.GradeSelectionTableAdapter
    Friend WithEvents GradeSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarStatusSelectionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MissingCaviarInventoryJoinCaviarFishBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MissingCaviarInventoryJoinCaviarFishMyDataGridView As Sturgeon_Manager_v1._0.MyDataGridView
    Friend WithEvents ProductsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarStatusSelectionBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents GradeSelectionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CaviarStatusSelectionBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents NotFoundTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoteButton As System.Windows.Forms.Button
    Friend WithEvents AcceptButton As System.Windows.Forms.Button
    Friend WithEvents EndAuditButton As System.Windows.Forms.Button
    Friend WithEvents NotesPKBarcodeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesFKProductIDColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents NotesInventoryStatusColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents NotesNotesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesGradeColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesPreviousStatusColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AudioSpeedTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MissingPKBarcodeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MissingFKProductIDColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents MissingNotesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
