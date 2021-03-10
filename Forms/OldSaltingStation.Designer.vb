<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OldSaltingStation
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
        Dim PKFishIDLabel As System.Windows.Forms.Label
        Dim TagLabel As System.Windows.Forms.Label
        Dim Live_WtLabel As System.Windows.Forms.Label
        Dim Gutted_WtLabel As System.Windows.Forms.Label
        Dim Ovary_TotLabel As System.Windows.Forms.Label
        Dim Ovary_WasteLabel As System.Windows.Forms.Label
        Dim SpeciesLabel As System.Windows.Forms.Label
        Dim CycledLabel As System.Windows.Forms.Label
        Dim Purge_TankLabel As System.Windows.Forms.Label
        Dim Egg_WtLabel As System.Windows.Forms.Label
        Dim Harvest_DateLabel As System.Windows.Forms.Label
        Dim SaltLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OldSaltingStation))
        Me.Caviar_FishBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Caviar_FishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Caviar_FishBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PKFishIDTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.TagTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Live_WtTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Gutted_WtTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Ovary_TotTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Ovary_WasteTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.SpeciesTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.CycledCheckBox = New System.Windows.Forms.CheckBox
        Me.Purge_TankTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.PercentSaltTextbox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Egg_WtTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.SaltTextBox = New Sturgeon_Manager_v1._0.TabTextBox
        Me.Caviar_FishTableAdapter = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
        Me.TableAdapterManager = New Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
        Me.Harvest_DateMyDateTimePicker = New Sturgeon_Manager_v1._0.Controls.MyDateTimePicker
        PKFishIDLabel = New System.Windows.Forms.Label
        TagLabel = New System.Windows.Forms.Label
        Live_WtLabel = New System.Windows.Forms.Label
        Gutted_WtLabel = New System.Windows.Forms.Label
        Ovary_TotLabel = New System.Windows.Forms.Label
        Ovary_WasteLabel = New System.Windows.Forms.Label
        SpeciesLabel = New System.Windows.Forms.Label
        CycledLabel = New System.Windows.Forms.Label
        Purge_TankLabel = New System.Windows.Forms.Label
        Egg_WtLabel = New System.Windows.Forms.Label
        Harvest_DateLabel = New System.Windows.Forms.Label
        SaltLabel = New System.Windows.Forms.Label
        CType(Me.Caviar_FishBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Caviar_FishBindingNavigator.SuspendLayout()
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PKFishIDLabel
        '
        PKFishIDLabel.AutoSize = True
        PKFishIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PKFishIDLabel.Location = New System.Drawing.Point(30, 32)
        PKFishIDLabel.Name = "PKFishIDLabel"
        PKFishIDLabel.Size = New System.Drawing.Size(97, 24)
        PKFishIDLabel.TabIndex = 1
        PKFishIDLabel.Text = "PKFish ID:"
        PKFishIDLabel.Visible = False
        '
        'TagLabel
        '
        TagLabel.AutoSize = True
        TagLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TagLabel.Location = New System.Drawing.Point(30, 123)
        TagLabel.Name = "TagLabel"
        TagLabel.Size = New System.Drawing.Size(48, 24)
        TagLabel.TabIndex = 3
        TagLabel.Text = "Tag:"
        '
        'Live_WtLabel
        '
        Live_WtLabel.AutoSize = True
        Live_WtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Live_WtLabel.Location = New System.Drawing.Point(30, 154)
        Live_WtLabel.Name = "Live_WtLabel"
        Live_WtLabel.Size = New System.Drawing.Size(113, 24)
        Live_WtLabel.TabIndex = 17
        Live_WtLabel.Text = "Live Weight:"
        '
        'Gutted_WtLabel
        '
        Gutted_WtLabel.AutoSize = True
        Gutted_WtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Gutted_WtLabel.Location = New System.Drawing.Point(30, 186)
        Gutted_WtLabel.Name = "Gutted_WtLabel"
        Gutted_WtLabel.Size = New System.Drawing.Size(134, 24)
        Gutted_WtLabel.TabIndex = 19
        Gutted_WtLabel.Text = "Gutted Weight:"
        '
        'Ovary_TotLabel
        '
        Ovary_TotLabel.AutoSize = True
        Ovary_TotLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ovary_TotLabel.Location = New System.Drawing.Point(30, 219)
        Ovary_TotLabel.Name = "Ovary_TotLabel"
        Ovary_TotLabel.Size = New System.Drawing.Size(128, 24)
        Ovary_TotLabel.TabIndex = 21
        Ovary_TotLabel.Text = "Ovary Weight:"
        '
        'Ovary_WasteLabel
        '
        Ovary_WasteLabel.AutoSize = True
        Ovary_WasteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ovary_WasteLabel.Location = New System.Drawing.Point(30, 251)
        Ovary_WasteLabel.Name = "Ovary_WasteLabel"
        Ovary_WasteLabel.Size = New System.Drawing.Size(121, 24)
        Ovary_WasteLabel.TabIndex = 23
        Ovary_WasteLabel.Text = "Ovary Waste:"
        '
        'SpeciesLabel
        '
        SpeciesLabel.AutoSize = True
        SpeciesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SpeciesLabel.Location = New System.Drawing.Point(30, 377)
        SpeciesLabel.Name = "SpeciesLabel"
        SpeciesLabel.Size = New System.Drawing.Size(83, 24)
        SpeciesLabel.TabIndex = 46
        SpeciesLabel.Text = "Species:"
        '
        'CycledLabel
        '
        CycledLabel.AutoSize = True
        CycledLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CycledLabel.Location = New System.Drawing.Point(30, 348)
        CycledLabel.Name = "CycledLabel"
        CycledLabel.Size = New System.Drawing.Size(73, 24)
        CycledLabel.TabIndex = 48
        CycledLabel.Text = "Cycled:"
        '
        'Purge_TankLabel
        '
        Purge_TankLabel.AutoSize = True
        Purge_TankLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Purge_TankLabel.Location = New System.Drawing.Point(30, 89)
        Purge_TankLabel.Name = "Purge_TankLabel"
        Purge_TankLabel.Size = New System.Drawing.Size(113, 24)
        Purge_TankLabel.TabIndex = 50
        Purge_TankLabel.Text = "Purge Tank:"
        '
        'Egg_WtLabel
        '
        Egg_WtLabel.AutoSize = True
        Egg_WtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Egg_WtLabel.Location = New System.Drawing.Point(30, 283)
        Egg_WtLabel.Name = "Egg_WtLabel"
        Egg_WtLabel.Size = New System.Drawing.Size(123, 24)
        Egg_WtLabel.TabIndex = 52
        Egg_WtLabel.Text = "Eggs Weight:"
        '
        'Harvest_DateLabel
        '
        Harvest_DateLabel.AutoSize = True
        Harvest_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Harvest_DateLabel.Location = New System.Drawing.Point(30, 61)
        Harvest_DateLabel.Name = "Harvest_DateLabel"
        Harvest_DateLabel.Size = New System.Drawing.Size(126, 24)
        Harvest_DateLabel.TabIndex = 57
        Harvest_DateLabel.Text = "Process Date:"
        '
        'SaltLabel
        '
        SaltLabel.AutoSize = True
        SaltLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SaltLabel.Location = New System.Drawing.Point(30, 313)
        SaltLabel.Name = "SaltLabel"
        SaltLabel.Size = New System.Drawing.Size(45, 24)
        SaltLabel.TabIndex = 58
        SaltLabel.Text = "Salt:"
        '
        'Caviar_FishBindingNavigator
        '
        Me.Caviar_FishBindingNavigator.AddNewItem = Nothing
        Me.Caviar_FishBindingNavigator.BindingSource = Me.Caviar_FishBindingSource
        Me.Caviar_FishBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Caviar_FishBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Caviar_FishBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Caviar_FishBindingNavigatorSaveItem})
        Me.Caviar_FishBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Caviar_FishBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Caviar_FishBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Caviar_FishBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Caviar_FishBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Caviar_FishBindingNavigator.Name = "Caviar_FishBindingNavigator"
        Me.Caviar_FishBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Caviar_FishBindingNavigator.Size = New System.Drawing.Size(433, 25)
        Me.Caviar_FishBindingNavigator.TabIndex = 0
        Me.Caviar_FishBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Caviar_FishBindingNavigatorSaveItem
        '
        Me.Caviar_FishBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Caviar_FishBindingNavigatorSaveItem.Image = CType(resources.GetObject("Caviar_FishBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Caviar_FishBindingNavigatorSaveItem.Name = "Caviar_FishBindingNavigatorSaveItem"
        Me.Caviar_FishBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Caviar_FishBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PKFishIDTextBox
        '
        Me.PKFishIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "PKFishID", True))
        Me.PKFishIDTextBox.Enabled = False
        Me.PKFishIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PKFishIDTextBox.Location = New System.Drawing.Point(165, 29)
        Me.PKFishIDTextBox.Name = "PKFishIDTextBox"
        Me.PKFishIDTextBox.Size = New System.Drawing.Size(199, 29)
        Me.PKFishIDTextBox.TabIndex = 0
        Me.PKFishIDTextBox.TabStop = False
        Me.PKFishIDTextBox.Visible = False
        '
        'TagTextBox
        '
        Me.TagTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TagTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Tag", True))
        Me.TagTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TagTextBox.Location = New System.Drawing.Point(164, 120)
        Me.TagTextBox.Name = "TagTextBox"
        Me.TagTextBox.Size = New System.Drawing.Size(199, 29)
        Me.TagTextBox.TabIndex = 3
        '
        'Live_WtTextBox
        '
        Me.Live_WtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Live Wt", True))
        Me.Live_WtTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Live_WtTextBox.Location = New System.Drawing.Point(164, 151)
        Me.Live_WtTextBox.Name = "Live_WtTextBox"
        Me.Live_WtTextBox.Size = New System.Drawing.Size(199, 29)
        Me.Live_WtTextBox.TabIndex = 4
        '
        'Gutted_WtTextBox
        '
        Me.Gutted_WtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Gutted Wt", True))
        Me.Gutted_WtTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gutted_WtTextBox.Location = New System.Drawing.Point(165, 183)
        Me.Gutted_WtTextBox.Name = "Gutted_WtTextBox"
        Me.Gutted_WtTextBox.Size = New System.Drawing.Size(199, 29)
        Me.Gutted_WtTextBox.TabIndex = 5
        '
        'Ovary_TotTextBox
        '
        Me.Ovary_TotTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Ovary Tot", True))
        Me.Ovary_TotTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ovary_TotTextBox.Location = New System.Drawing.Point(165, 216)
        Me.Ovary_TotTextBox.Name = "Ovary_TotTextBox"
        Me.Ovary_TotTextBox.Size = New System.Drawing.Size(199, 29)
        Me.Ovary_TotTextBox.TabIndex = 6
        '
        'Ovary_WasteTextBox
        '
        Me.Ovary_WasteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Ovary Waste", True))
        Me.Ovary_WasteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ovary_WasteTextBox.Location = New System.Drawing.Point(165, 248)
        Me.Ovary_WasteTextBox.Name = "Ovary_WasteTextBox"
        Me.Ovary_WasteTextBox.Size = New System.Drawing.Size(199, 29)
        Me.Ovary_WasteTextBox.TabIndex = 7
        '
        'SpeciesTextBox
        '
        Me.SpeciesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Species", True))
        Me.SpeciesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeciesTextBox.Location = New System.Drawing.Point(164, 374)
        Me.SpeciesTextBox.Name = "SpeciesTextBox"
        Me.SpeciesTextBox.Size = New System.Drawing.Size(199, 29)
        Me.SpeciesTextBox.TabIndex = 10
        Me.SpeciesTextBox.TabStop = False
        '
        'CycledCheckBox
        '
        Me.CycledCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Caviar_FishBindingSource, "Cycled", True))
        Me.CycledCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CycledCheckBox.Location = New System.Drawing.Point(165, 348)
        Me.CycledCheckBox.Name = "CycledCheckBox"
        Me.CycledCheckBox.Size = New System.Drawing.Size(200, 26)
        Me.CycledCheckBox.TabIndex = 9
        Me.CycledCheckBox.UseVisualStyleBackColor = True
        '
        'Purge_TankTextBox
        '
        Me.Purge_TankTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Purge_TankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Purge Tank", True))
        Me.Purge_TankTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Purge_TankTextBox.Location = New System.Drawing.Point(164, 89)
        Me.Purge_TankTextBox.Name = "Purge_TankTextBox"
        Me.Purge_TankTextBox.Size = New System.Drawing.Size(199, 29)
        Me.Purge_TankTextBox.TabIndex = 2
        '
        'PercentSaltTextbox
        '
        Me.PercentSaltTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentSaltTextbox.Location = New System.Drawing.Point(307, 313)
        Me.PercentSaltTextbox.Name = "PercentSaltTextbox"
        Me.PercentSaltTextbox.Size = New System.Drawing.Size(57, 29)
        Me.PercentSaltTextbox.TabIndex = 11
        Me.PercentSaltTextbox.TabStop = False
        Me.PercentSaltTextbox.Text = "3.7"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 24)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "% Salt:"
        '
        'Egg_WtTextBox
        '
        Me.Egg_WtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Egg Wt", True))
        Me.Egg_WtTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Egg_WtTextBox.Location = New System.Drawing.Point(166, 280)
        Me.Egg_WtTextBox.Name = "Egg_WtTextBox"
        Me.Egg_WtTextBox.Size = New System.Drawing.Size(199, 29)
        Me.Egg_WtTextBox.TabIndex = 8
        '
        'SaltTextBox
        '
        Me.SaltTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Caviar_FishBindingSource, "Salt", True))
        Me.SaltTextBox.Enabled = False
        Me.SaltTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaltTextBox.Location = New System.Drawing.Point(165, 313)
        Me.SaltTextBox.Name = "SaltTextBox"
        Me.SaltTextBox.Size = New System.Drawing.Size(71, 29)
        Me.SaltTextBox.TabIndex = 59
        Me.SaltTextBox.TabStop = False
        '
        'Caviar_FishTableAdapter
        '
        Me.Caviar_FishTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.Caviar_FishTableAdapter = Me.Caviar_FishTableAdapter
        Me.TableAdapterManager.Caviar_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.CaviarInventoryJoinCaviarFishTableAdapter = Nothing
        Me.TableAdapterManager.CaviarStatusSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Customer_PricingTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.GradeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTypeSelectionTableAdapter = Nothing
        Me.TableAdapterManager.Non_Inventory_Invoice_RecordsTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategorySelectionTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Harvest_DateMyDateTimePicker
        '
        Me.Harvest_DateMyDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Caviar_FishBindingSource, "Harvest Date", True))
        Me.Harvest_DateMyDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Harvest_DateMyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Harvest_DateMyDateTimePicker.Location = New System.Drawing.Point(165, 59)
        Me.Harvest_DateMyDateTimePicker.Name = "Harvest_DateMyDateTimePicker"
        Me.Harvest_DateMyDateTimePicker.Size = New System.Drawing.Size(200, 29)
        Me.Harvest_DateMyDateTimePicker.TabIndex = 1
        Me.Harvest_DateMyDateTimePicker.TabStop = False
        Me.Harvest_DateMyDateTimePicker.Value = New Date(2013, 7, 16, 22, 8, 4, 162)
        '
        'SaltingStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(433, 438)
        Me.Controls.Add(SaltLabel)
        Me.Controls.Add(Me.SaltTextBox)
        Me.Controls.Add(Harvest_DateLabel)
        Me.Controls.Add(Me.Harvest_DateMyDateTimePicker)
        Me.Controls.Add(Me.PercentSaltTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Egg_WtLabel)
        Me.Controls.Add(Me.Egg_WtTextBox)
        Me.Controls.Add(Purge_TankLabel)
        Me.Controls.Add(Me.Purge_TankTextBox)
        Me.Controls.Add(CycledLabel)
        Me.Controls.Add(Me.CycledCheckBox)
        Me.Controls.Add(SpeciesLabel)
        Me.Controls.Add(Me.SpeciesTextBox)
        Me.Controls.Add(PKFishIDLabel)
        Me.Controls.Add(Me.PKFishIDTextBox)
        Me.Controls.Add(TagLabel)
        Me.Controls.Add(Me.TagTextBox)
        Me.Controls.Add(Live_WtLabel)
        Me.Controls.Add(Me.Live_WtTextBox)
        Me.Controls.Add(Gutted_WtLabel)
        Me.Controls.Add(Me.Gutted_WtTextBox)
        Me.Controls.Add(Ovary_TotLabel)
        Me.Controls.Add(Me.Ovary_TotTextBox)
        Me.Controls.Add(Ovary_WasteLabel)
        Me.Controls.Add(Me.Ovary_WasteTextBox)
        Me.Controls.Add(Me.Caviar_FishBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "SaltingStation"
        Me.Text = "Salting Station"
        CType(Me.Caviar_FishBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Caviar_FishBindingNavigator.ResumeLayout(False)
        Me.Caviar_FishBindingNavigator.PerformLayout()
        CType(Me.Caviar_FishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SturgeonDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SturgeonDBDataSet As Sturgeon_Manager_v1._0.SturgeonDBDataSet
    Friend WithEvents Caviar_FishBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caviar_FishTableAdapter As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.Caviar_FishTableAdapter
    Friend WithEvents TableAdapterManager As Sturgeon_Manager_v1._0.SturgeonDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Caviar_FishBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Caviar_FishBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PKFishIDTextBox As TabTextBox
    Friend WithEvents TagTextBox As TabTextBox
    Friend WithEvents Live_WtTextBox As TabTextBox
    Friend WithEvents Gutted_WtTextBox As TabTextBox
    Friend WithEvents Ovary_TotTextBox As TabTextBox
    Friend WithEvents Ovary_WasteTextBox As TabTextBox
    Friend WithEvents SpeciesTextBox As TabTextBox
    Friend WithEvents CycledCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Purge_TankTextBox As TabTextBox
    Friend WithEvents PercentSaltTextbox As TabTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Egg_WtTextBox As TabTextBox
    Friend WithEvents Harvest_DateMyDateTimePicker As Sturgeon_Manager_v1._0.Controls.MyDateTimePicker
    Friend WithEvents SaltTextBox As TabTextBox
End Class
