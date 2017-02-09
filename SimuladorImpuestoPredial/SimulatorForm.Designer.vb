<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SimulatorForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim BaseImponibleLabel As System.Windows.Forms.Label
        Dim BaseImponibleDeducidaLabel As System.Windows.Forms.Label
        Dim InsolutoLabel As System.Windows.Forms.Label
        Dim TerrenoAreaExclusivaLabel As System.Windows.Forms.Label
        Dim TerrenoAreaComunLabel As System.Windows.Forms.Label
        Dim TerrenoAreaTotalLabel As System.Windows.Forms.Label
        Dim ArancelLabel As System.Windows.Forms.Label
        Dim TerrenoValorLabel As System.Windows.Forms.Label
        Dim ConstruccionesValorLabel As System.Windows.Forms.Label
        Dim AvaluoLabel As System.Windows.Forms.Label
        Dim NivelLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ClasificacionLabel As System.Windows.Forms.Label
        Dim MaterialLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CmcLabel As System.Windows.Forms.Label
        Dim CtLabel As System.Windows.Forms.Label
        Dim CpLabel As System.Windows.Forms.Label
        Dim CpvLabel As System.Windows.Forms.Label
        Dim CrLabel As System.Windows.Forms.Label
        Dim CbLabel As System.Windows.Forms.Label
        Dim CiesLabel As System.Windows.Forms.Label
        Dim AreaConstruidaLabel As System.Windows.Forms.Label
        Dim AreaConstruidaComunPorcentajeLabel As System.Windows.Forms.Label
        Dim MesLabel1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimulatorForm))
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrediosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImpuestoPredialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConstruccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripComboBox()
        Me.PredioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaseImponibleTextBox = New System.Windows.Forms.TextBox()
        Me.BaseImponibleDeducidaTextBox = New System.Windows.Forms.TextBox()
        Me.InsolutoTextBox = New System.Windows.Forms.TextBox()
        Me.ExoneradoCheckBox = New System.Windows.Forms.CheckBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ConstruccionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDepreciacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaConstruidaValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerrenoAreaExclusivaTextBox = New System.Windows.Forms.TextBox()
        Me.TerrenoAreaComunTextBox = New System.Windows.Forms.TextBox()
        Me.TerrenoAreaTotalTextBox = New System.Windows.Forms.TextBox()
        Me.ArancelTextBox = New System.Windows.Forms.TextBox()
        Me.TerrenoValorTextBox = New System.Windows.Forms.TextBox()
        Me.ConstruccionesValorTextBox = New System.Windows.Forms.TextBox()
        Me.AvaluoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.MesComboBox = New System.Windows.Forms.ComboBox()
        Me.AreaConstruidaComunPorcentajeTextBox = New System.Windows.Forms.TextBox()
        Me.AreaConstruidaTextBox = New System.Windows.Forms.TextBox()
        Me.CiesTextBox = New System.Windows.Forms.TextBox()
        Me.CbTextBox = New System.Windows.Forms.TextBox()
        Me.CrTextBox = New System.Windows.Forms.TextBox()
        Me.CpvTextBox = New System.Windows.Forms.TextBox()
        Me.CpTextBox = New System.Windows.Forms.TextBox()
        Me.CtTextBox = New System.Windows.Forms.TextBox()
        Me.CmcTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.MaterialComboBox = New System.Windows.Forms.ComboBox()
        Me.AñoTextBox = New System.Windows.Forms.TextBox()
        Me.NivelTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ClasificacionComboBox = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        BaseImponibleLabel = New System.Windows.Forms.Label()
        BaseImponibleDeducidaLabel = New System.Windows.Forms.Label()
        InsolutoLabel = New System.Windows.Forms.Label()
        TerrenoAreaExclusivaLabel = New System.Windows.Forms.Label()
        TerrenoAreaComunLabel = New System.Windows.Forms.Label()
        TerrenoAreaTotalLabel = New System.Windows.Forms.Label()
        ArancelLabel = New System.Windows.Forms.Label()
        TerrenoValorLabel = New System.Windows.Forms.Label()
        ConstruccionesValorLabel = New System.Windows.Forms.Label()
        AvaluoLabel = New System.Windows.Forms.Label()
        NivelLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ClasificacionLabel = New System.Windows.Forms.Label()
        MaterialLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CmcLabel = New System.Windows.Forms.Label()
        CtLabel = New System.Windows.Forms.Label()
        CpLabel = New System.Windows.Forms.Label()
        CpvLabel = New System.Windows.Forms.Label()
        CrLabel = New System.Windows.Forms.Label()
        CbLabel = New System.Windows.Forms.Label()
        CiesLabel = New System.Windows.Forms.Label()
        AreaConstruidaLabel = New System.Windows.Forms.Label()
        AreaConstruidaComunPorcentajeLabel = New System.Windows.Forms.Label()
        MesLabel1 = New System.Windows.Forms.Label()
        CType(Me.PrediosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImpuestoPredialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConstruccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PredioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ConstruccionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaseImponibleLabel
        '
        BaseImponibleLabel.AutoSize = True
        BaseImponibleLabel.Location = New System.Drawing.Point(641, 51)
        BaseImponibleLabel.Name = "BaseImponibleLabel"
        BaseImponibleLabel.Size = New System.Drawing.Size(89, 13)
        BaseImponibleLabel.TabIndex = 1
        BaseImponibleLabel.Text = "Base Imponible:"
        '
        'BaseImponibleDeducidaLabel
        '
        BaseImponibleDeducidaLabel.AutoSize = True
        BaseImponibleDeducidaLabel.Location = New System.Drawing.Point(589, 79)
        BaseImponibleDeducidaLabel.Name = "BaseImponibleDeducidaLabel"
        BaseImponibleDeducidaLabel.Size = New System.Drawing.Size(141, 13)
        BaseImponibleDeducidaLabel.TabIndex = 3
        BaseImponibleDeducidaLabel.Text = "Base Imponible Deducida:"
        '
        'InsolutoLabel
        '
        InsolutoLabel.AutoSize = True
        InsolutoLabel.Location = New System.Drawing.Point(677, 107)
        InsolutoLabel.Name = "InsolutoLabel"
        InsolutoLabel.Size = New System.Drawing.Size(53, 13)
        InsolutoLabel.TabIndex = 5
        InsolutoLabel.Text = "Insoluto:"
        '
        'TerrenoAreaExclusivaLabel
        '
        TerrenoAreaExclusivaLabel.AutoSize = True
        TerrenoAreaExclusivaLabel.Location = New System.Drawing.Point(6, 24)
        TerrenoAreaExclusivaLabel.Name = "TerrenoAreaExclusivaLabel"
        TerrenoAreaExclusivaLabel.Size = New System.Drawing.Size(81, 13)
        TerrenoAreaExclusivaLabel.TabIndex = 0
        TerrenoAreaExclusivaLabel.Text = "Area Exclusiva:"
        '
        'TerrenoAreaComunLabel
        '
        TerrenoAreaComunLabel.AutoSize = True
        TerrenoAreaComunLabel.Location = New System.Drawing.Point(199, 24)
        TerrenoAreaComunLabel.Name = "TerrenoAreaComunLabel"
        TerrenoAreaComunLabel.Size = New System.Drawing.Size(73, 13)
        TerrenoAreaComunLabel.TabIndex = 2
        TerrenoAreaComunLabel.Text = "Area Comun:"
        '
        'TerrenoAreaTotalLabel
        '
        TerrenoAreaTotalLabel.AutoSize = True
        TerrenoAreaTotalLabel.Location = New System.Drawing.Point(384, 24)
        TerrenoAreaTotalLabel.Name = "TerrenoAreaTotalLabel"
        TerrenoAreaTotalLabel.Size = New System.Drawing.Size(60, 13)
        TerrenoAreaTotalLabel.TabIndex = 4
        TerrenoAreaTotalLabel.Text = "Area Total:"
        '
        'ArancelLabel
        '
        ArancelLabel.AutoSize = True
        ArancelLabel.Location = New System.Drawing.Point(556, 24)
        ArancelLabel.Name = "ArancelLabel"
        ArancelLabel.Size = New System.Drawing.Size(48, 13)
        ArancelLabel.TabIndex = 6
        ArancelLabel.Text = "Arancel:"
        '
        'TerrenoValorLabel
        '
        TerrenoValorLabel.AutoSize = True
        TerrenoValorLabel.Location = New System.Drawing.Point(164, 24)
        TerrenoValorLabel.Name = "TerrenoValorLabel"
        TerrenoValorLabel.Size = New System.Drawing.Size(96, 13)
        TerrenoValorLabel.TabIndex = 0
        TerrenoValorLabel.Text = "Valor del Terreno:"
        '
        'ConstruccionesValorLabel
        '
        ConstruccionesValorLabel.AutoSize = True
        ConstruccionesValorLabel.Location = New System.Drawing.Point(372, 24)
        ConstruccionesValorLabel.Name = "ConstruccionesValorLabel"
        ConstruccionesValorLabel.Size = New System.Drawing.Size(134, 13)
        ConstruccionesValorLabel.TabIndex = 2
        ConstruccionesValorLabel.Text = "Valor de Construcciones:"
        '
        'AvaluoLabel
        '
        AvaluoLabel.AutoSize = True
        AvaluoLabel.Location = New System.Drawing.Point(618, 24)
        AvaluoLabel.Name = "AvaluoLabel"
        AvaluoLabel.Size = New System.Drawing.Size(45, 13)
        AvaluoLabel.TabIndex = 4
        AvaluoLabel.Text = "Avaluo:"
        '
        'NivelLabel
        '
        NivelLabel.AutoSize = True
        NivelLabel.Location = New System.Drawing.Point(9, 18)
        NivelLabel.Name = "NivelLabel"
        NivelLabel.Size = New System.Drawing.Size(35, 13)
        NivelLabel.TabIndex = 0
        NivelLabel.Text = "Nivel:"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(53, 18)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(31, 13)
        AñoLabel.TabIndex = 2
        AñoLabel.Text = "Año:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(6, 24)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 13)
        Label1.TabIndex = 0
        Label1.Text = "Dirección:"
        '
        'ClasificacionLabel
        '
        ClasificacionLabel.AutoSize = True
        ClasificacionLabel.Location = New System.Drawing.Point(321, 24)
        ClasificacionLabel.Name = "ClasificacionLabel"
        ClasificacionLabel.Size = New System.Drawing.Size(74, 13)
        ClasificacionLabel.TabIndex = 2
        ClasificacionLabel.Text = "Clasificacion:"
        '
        'MaterialLabel
        '
        MaterialLabel.AutoSize = True
        MaterialLabel.Location = New System.Drawing.Point(142, 18)
        MaterialLabel.Name = "MaterialLabel"
        MaterialLabel.Size = New System.Drawing.Size(52, 13)
        MaterialLabel.TabIndex = 6
        MaterialLabel.Text = "Material:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(221, 18)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(79, 13)
        EstadoLabel.TabIndex = 8
        EstadoLabel.Text = "Conservacion:"
        '
        'CmcLabel
        '
        CmcLabel.AutoSize = True
        CmcLabel.Location = New System.Drawing.Point(313, 18)
        CmcLabel.Name = "CmcLabel"
        CmcLabel.Size = New System.Drawing.Size(24, 13)
        CmcLabel.TabIndex = 10
        CmcLabel.Text = "MC"
        '
        'CtLabel
        '
        CtLabel.AutoSize = True
        CtLabel.Location = New System.Drawing.Point(349, 18)
        CtLabel.Name = "CtLabel"
        CtLabel.Size = New System.Drawing.Size(12, 13)
        CtLabel.TabIndex = 12
        CtLabel.Text = "T"
        '
        'CpLabel
        '
        CpLabel.AutoSize = True
        CpLabel.Location = New System.Drawing.Point(385, 18)
        CpLabel.Name = "CpLabel"
        CpLabel.Size = New System.Drawing.Size(13, 13)
        CpLabel.TabIndex = 14
        CpLabel.Text = "P"
        '
        'CpvLabel
        '
        CpvLabel.AutoSize = True
        CpvLabel.Location = New System.Drawing.Point(421, 18)
        CpvLabel.Name = "CpvLabel"
        CpvLabel.Size = New System.Drawing.Size(20, 13)
        CpvLabel.TabIndex = 16
        CpvLabel.Text = "PV"
        '
        'CrLabel
        '
        CrLabel.AutoSize = True
        CrLabel.Location = New System.Drawing.Point(457, 18)
        CrLabel.Name = "CrLabel"
        CrLabel.Size = New System.Drawing.Size(14, 13)
        CrLabel.TabIndex = 18
        CrLabel.Text = "R"
        '
        'CbLabel
        '
        CbLabel.AutoSize = True
        CbLabel.Location = New System.Drawing.Point(493, 18)
        CbLabel.Name = "CbLabel"
        CbLabel.Size = New System.Drawing.Size(14, 13)
        CbLabel.TabIndex = 20
        CbLabel.Text = "B"
        '
        'CiesLabel
        '
        CiesLabel.AutoSize = True
        CiesLabel.Location = New System.Drawing.Point(530, 18)
        CiesLabel.Name = "CiesLabel"
        CiesLabel.Size = New System.Drawing.Size(22, 13)
        CiesLabel.TabIndex = 22
        CiesLabel.Text = "IES"
        '
        'AreaConstruidaLabel
        '
        AreaConstruidaLabel.AutoSize = True
        AreaConstruidaLabel.Location = New System.Drawing.Point(564, 17)
        AreaConstruidaLabel.Name = "AreaConstruidaLabel"
        AreaConstruidaLabel.Size = New System.Drawing.Size(93, 13)
        AreaConstruidaLabel.TabIndex = 24
        AreaConstruidaLabel.Text = "Area Construida:"
        '
        'AreaConstruidaComunPorcentajeLabel
        '
        AreaConstruidaComunPorcentajeLabel.AutoSize = True
        AreaConstruidaComunPorcentajeLabel.Location = New System.Drawing.Point(663, 18)
        AreaConstruidaComunPorcentajeLabel.Name = "AreaConstruidaComunPorcentajeLabel"
        AreaConstruidaComunPorcentajeLabel.Size = New System.Drawing.Size(59, 13)
        AreaConstruidaComunPorcentajeLabel.TabIndex = 26
        AreaConstruidaComunPorcentajeLabel.Text = "% Común:"
        '
        'MesLabel1
        '
        MesLabel1.AutoSize = True
        MesLabel1.Location = New System.Drawing.Point(97, 18)
        MesLabel1.Name = "MesLabel1"
        MesLabel1.Size = New System.Drawing.Size(31, 13)
        MesLabel1.TabIndex = 4
        MesLabel1.Text = "Mes:"
        '
        'PrediosBindingSource
        '
        Me.PrediosBindingSource.DataMember = "Predios"
        Me.PrediosBindingSource.DataSource = Me.ImpuestoPredialBindingSource
        '
        'ImpuestoPredialBindingSource
        '
        Me.ImpuestoPredialBindingSource.DataSource = GetType(SimuladorImpuestoPredial.ImpPred.ImpuestoPredial)
        '
        'ConstruccionesBindingSource
        '
        Me.ConstruccionesBindingSource.DataMember = "Construcciones"
        Me.ConstruccionesBindingSource.DataSource = Me.PrediosBindingSource
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(5, 5)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(824, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(169, 25)
        '
        'PredioDataGridView
        '
        Me.PredioDataGridView.AllowUserToAddRows = False
        Me.PredioDataGridView.AllowUserToDeleteRows = False
        Me.PredioDataGridView.AutoGenerateColumns = False
        Me.PredioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PredioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PredioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PredioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PredioDataGridView.DataSource = Me.PrediosBindingSource
        Me.PredioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PredioDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PredioDataGridView.MultiSelect = False
        Me.PredioDataGridView.Name = "PredioDataGridView"
        Me.PredioDataGridView.ReadOnly = True
        Me.PredioDataGridView.RowHeadersVisible = False
        Me.PredioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PredioDataGridView.Size = New System.Drawing.Size(532, 119)
        Me.PredioDataGridView.TabIndex = 0
        Me.PredioDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TerrenoValor"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn7.HeaderText = "V. Terreno"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 83
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ConstruccionesValor"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn8.HeaderText = "V. Constr."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 82
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Avaluo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn9.HeaderText = "Avaluo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 67
        '
        'BaseImponibleTextBox
        '
        Me.BaseImponibleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImpuestoPredialBindingSource, "BaseImponible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.BaseImponibleTextBox.Location = New System.Drawing.Point(736, 48)
        Me.BaseImponibleTextBox.Name = "BaseImponibleTextBox"
        Me.BaseImponibleTextBox.ReadOnly = True
        Me.BaseImponibleTextBox.Size = New System.Drawing.Size(76, 22)
        Me.BaseImponibleTextBox.TabIndex = 2
        '
        'BaseImponibleDeducidaTextBox
        '
        Me.BaseImponibleDeducidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImpuestoPredialBindingSource, "BaseImponibleDeducida", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.BaseImponibleDeducidaTextBox.Location = New System.Drawing.Point(736, 76)
        Me.BaseImponibleDeducidaTextBox.Name = "BaseImponibleDeducidaTextBox"
        Me.BaseImponibleDeducidaTextBox.ReadOnly = True
        Me.BaseImponibleDeducidaTextBox.Size = New System.Drawing.Size(76, 22)
        Me.BaseImponibleDeducidaTextBox.TabIndex = 4
        '
        'InsolutoTextBox
        '
        Me.InsolutoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImpuestoPredialBindingSource, "Insoluto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.InsolutoTextBox.Location = New System.Drawing.Point(736, 104)
        Me.InsolutoTextBox.Name = "InsolutoTextBox"
        Me.InsolutoTextBox.ReadOnly = True
        Me.InsolutoTextBox.Size = New System.Drawing.Size(76, 22)
        Me.InsolutoTextBox.TabIndex = 6
        '
        'ExoneradoCheckBox
        '
        Me.ExoneradoCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.ExoneradoCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ExoneradoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ImpuestoPredialBindingSource, "Exonerado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ExoneradoCheckBox.Location = New System.Drawing.Point(736, 18)
        Me.ExoneradoCheckBox.Name = "ExoneradoCheckBox"
        Me.ExoneradoCheckBox.Size = New System.Drawing.Size(76, 24)
        Me.ExoneradoCheckBox.TabIndex = 0
        Me.ExoneradoCheckBox.Text = "Exonerado:"
        Me.ExoneradoCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ExoneradoCheckBox.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.PrediosBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 94)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(532, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(BaseImponibleDeducidaLabel)
        Me.GroupBox1.Controls.Add(Me.ExoneradoCheckBox)
        Me.GroupBox1.Controls.Add(Me.BaseImponibleDeducidaTextBox)
        Me.GroupBox1.Controls.Add(Me.BaseImponibleTextBox)
        Me.GroupBox1.Controls.Add(BaseImponibleLabel)
        Me.GroupBox1.Controls.Add(InsolutoLabel)
        Me.GroupBox1.Controls.Add(Me.InsolutoTextBox)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(5, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 140)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BindingNavigator1)
        Me.Panel1.Controls.Add(Me.PredioDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(3, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 119)
        Me.Panel1.TabIndex = 23
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(70, 21)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(245, 22)
        Me.DireccionTextBox.TabIndex = 1
        '
        'ConstruccionesDataGridView
        '
        Me.ConstruccionesDataGridView.AllowUserToAddRows = False
        Me.ConstruccionesDataGridView.AutoGenerateColumns = False
        Me.ConstruccionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ConstruccionesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ConstruccionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConstruccionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Material, Me.Estado, Me.Año, Me.Clasificacion, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn31, Me.ValorDepreciacion, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.AreaConstruidaValor, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37})
        Me.ConstruccionesDataGridView.DataSource = Me.ConstruccionesBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ConstruccionesDataGridView.DefaultCellStyle = DataGridViewCellStyle12
        Me.ConstruccionesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConstruccionesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ConstruccionesDataGridView.MultiSelect = False
        Me.ConstruccionesDataGridView.Name = "ConstruccionesDataGridView"
        Me.ConstruccionesDataGridView.ReadOnly = True
        Me.ConstruccionesDataGridView.RowHeadersVisible = False
        Me.ConstruccionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ConstruccionesDataGridView.Size = New System.Drawing.Size(812, 235)
        Me.ConstruccionesDataGridView.TabIndex = 0
        Me.ConstruccionesDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nivel"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Niv"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Nivel de edificación (piso)"
        Me.DataGridViewTextBoxColumn3.Width = 33
        '
        'Material
        '
        Me.Material.DataPropertyName = "Material"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Material.DefaultCellStyle = DataGridViewCellStyle5
        Me.Material.HeaderText = "MEP"
        Me.Material.Name = "Material"
        Me.Material.ReadOnly = True
        Me.Material.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Material.ToolTipText = "MAterial estructural predominante"
        Me.Material.Width = 39
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "N0"
        Me.Estado.DefaultCellStyle = DataGridViewCellStyle6
        Me.Estado.HeaderText = "EC"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Estado.ToolTipText = "Estado de Conservacion"
        Me.Estado.Width = 30
        '
        'Año
        '
        Me.Año.DataPropertyName = "Año"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "N0"
        Me.Año.DefaultCellStyle = DataGridViewCellStyle7
        Me.Año.HeaderText = "Año"
        Me.Año.Name = "Año"
        Me.Año.ReadOnly = True
        Me.Año.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Año.ToolTipText = "Año de Construccion"
        Me.Año.Width = 38
        '
        'Clasificacion
        '
        Me.Clasificacion.DataPropertyName = "Clasificacion"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "N0"
        Me.Clasificacion.DefaultCellStyle = DataGridViewCellStyle8
        Me.Clasificacion.HeaderText = "C"
        Me.Clasificacion.Name = "Clasificacion"
        Me.Clasificacion.ReadOnly = True
        Me.Clasificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Clasificacion.ToolTipText = "Clasificación del predio"
        Me.Clasificacion.Width = 24
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Categorias"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn10.HeaderText = "Categorias"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn10.Width = 72
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "ValorUnitario"
        Me.DataGridViewTextBoxColumn29.HeaderText = "VU"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn29.ToolTipText = "Valor Unitario"
        Me.DataGridViewTextBoxColumn29.Width = 32
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Incremento5Porc"
        Me.DataGridViewTextBoxColumn31.HeaderText = "5% Inc"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn31.ToolTipText = "5% Incremento a partir del Quinto Piso"
        Me.DataGridViewTextBoxColumn31.Width = 50
        '
        'ValorDepreciacion
        '
        Me.ValorDepreciacion.DataPropertyName = "ValorDepreciacion"
        Me.ValorDepreciacion.HeaderText = "VD"
        Me.ValorDepreciacion.Name = "ValorDepreciacion"
        Me.ValorDepreciacion.ReadOnly = True
        Me.ValorDepreciacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorDepreciacion.ToolTipText = "Depreciación"
        Me.ValorDepreciacion.Width = 32
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "ValorUnitarioDepreciado"
        Me.DataGridViewTextBoxColumn33.HeaderText = "VUD"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn33.ToolTipText = "Valor Unitario Depreciado"
        Me.DataGridViewTextBoxColumn33.Width = 40
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "AreaConstruida"
        DataGridViewCellStyle10.Format = "#,###,###,##0.00 m²"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn34.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn34.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn34.ToolTipText = "Area Construida"
        Me.DataGridViewTextBoxColumn34.Width = 40
        '
        'AreaConstruidaValor
        '
        Me.AreaConstruidaValor.DataPropertyName = "AreaConstruidaValor"
        Me.AreaConstruidaValor.HeaderText = "VAC"
        Me.AreaConstruidaValor.Name = "AreaConstruidaValor"
        Me.AreaConstruidaValor.ReadOnly = True
        Me.AreaConstruidaValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AreaConstruidaValor.ToolTipText = "Valor Area Construida"
        Me.AreaConstruidaValor.Width = 37
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "AreaConstruidaComunPorcentaje"
        DataGridViewCellStyle11.Format = "##0.0000% "
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn35.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn35.HeaderText = "% Comun"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn35.ToolTipText = "Porcentaje de area común"
        Me.DataGridViewTextBoxColumn35.Width = 66
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "AreaConstruidaComunValor"
        Me.DataGridViewTextBoxColumn36.HeaderText = "VACC"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn36.ToolTipText = "Valor de area construida común"
        Me.DataGridViewTextBoxColumn36.Width = 44
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Valor"
        Me.DataGridViewTextBoxColumn37.HeaderText = "VTC"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn37.ToolTipText = "Valor total de la construcción"
        Me.DataGridViewTextBoxColumn37.Width = 35
        '
        'TerrenoAreaExclusivaTextBox
        '
        Me.TerrenoAreaExclusivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoAreaExclusiva", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "#,###,###,###,##0.00 m²"))
        Me.TerrenoAreaExclusivaTextBox.Location = New System.Drawing.Point(93, 21)
        Me.TerrenoAreaExclusivaTextBox.Name = "TerrenoAreaExclusivaTextBox"
        Me.TerrenoAreaExclusivaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TerrenoAreaExclusivaTextBox.TabIndex = 1
        '
        'TerrenoAreaComunTextBox
        '
        Me.TerrenoAreaComunTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoAreaComun", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "#,###,###,###,##0.00 m²"))
        Me.TerrenoAreaComunTextBox.Location = New System.Drawing.Point(278, 21)
        Me.TerrenoAreaComunTextBox.Name = "TerrenoAreaComunTextBox"
        Me.TerrenoAreaComunTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TerrenoAreaComunTextBox.TabIndex = 3
        '
        'TerrenoAreaTotalTextBox
        '
        Me.TerrenoAreaTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoAreaTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,###,###,###,##0.00 m²"))
        Me.TerrenoAreaTotalTextBox.Location = New System.Drawing.Point(450, 21)
        Me.TerrenoAreaTotalTextBox.Name = "TerrenoAreaTotalTextBox"
        Me.TerrenoAreaTotalTextBox.ReadOnly = True
        Me.TerrenoAreaTotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TerrenoAreaTotalTextBox.TabIndex = 5
        '
        'ArancelTextBox
        '
        Me.ArancelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "Arancel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.ArancelTextBox.Location = New System.Drawing.Point(610, 21)
        Me.ArancelTextBox.Name = "ArancelTextBox"
        Me.ArancelTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ArancelTextBox.TabIndex = 7
        '
        'TerrenoValorTextBox
        '
        Me.TerrenoValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoValor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TerrenoValorTextBox.Location = New System.Drawing.Point(266, 21)
        Me.TerrenoValorTextBox.Name = "TerrenoValorTextBox"
        Me.TerrenoValorTextBox.ReadOnly = True
        Me.TerrenoValorTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TerrenoValorTextBox.TabIndex = 1
        '
        'ConstruccionesValorTextBox
        '
        Me.ConstruccionesValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "ConstruccionesValor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ConstruccionesValorTextBox.Location = New System.Drawing.Point(512, 21)
        Me.ConstruccionesValorTextBox.Name = "ConstruccionesValorTextBox"
        Me.ConstruccionesValorTextBox.ReadOnly = True
        Me.ConstruccionesValorTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ConstruccionesValorTextBox.TabIndex = 3
        '
        'AvaluoTextBox
        '
        Me.AvaluoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "Avaluo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.AvaluoTextBox.Location = New System.Drawing.Point(669, 21)
        Me.AvaluoTextBox.Name = "AvaluoTextBox"
        Me.AvaluoTextBox.ReadOnly = True
        Me.AvaluoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AvaluoTextBox.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(5, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(824, 555)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles del Predio"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Panel2)
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(3, 71)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(818, 350)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Construcciones"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ConstruccionesDataGridView)
        Me.Panel2.Controls.Add(Me.BindingNavigator2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(812, 260)
        Me.Panel2.TabIndex = 1
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.ToolStripButton1
        Me.BindingNavigator2.BindingSource = Me.ConstruccionesBindingSource
        Me.BindingNavigator2.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator2.DeleteItem = Me.ToolStripButton2
        Me.BindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 235)
        Me.BindingNavigator2.MoveFirstItem = Me.ToolStripButton3
        Me.BindingNavigator2.MoveLastItem = Me.ToolStripButton6
        Me.BindingNavigator2.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator2.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator2.Size = New System.Drawing.Size(812, 25)
        Me.BindingNavigator2.TabIndex = 1
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add new"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Delete"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(MesLabel1)
        Me.GroupBox7.Controls.Add(AreaConstruidaComunPorcentajeLabel)
        Me.GroupBox7.Controls.Add(Me.MesComboBox)
        Me.GroupBox7.Controls.Add(Me.AreaConstruidaComunPorcentajeTextBox)
        Me.GroupBox7.Controls.Add(AreaConstruidaLabel)
        Me.GroupBox7.Controls.Add(Me.AreaConstruidaTextBox)
        Me.GroupBox7.Controls.Add(CiesLabel)
        Me.GroupBox7.Controls.Add(Me.CiesTextBox)
        Me.GroupBox7.Controls.Add(CbLabel)
        Me.GroupBox7.Controls.Add(Me.CbTextBox)
        Me.GroupBox7.Controls.Add(CrLabel)
        Me.GroupBox7.Controls.Add(Me.CrTextBox)
        Me.GroupBox7.Controls.Add(CpvLabel)
        Me.GroupBox7.Controls.Add(Me.CpvTextBox)
        Me.GroupBox7.Controls.Add(CpLabel)
        Me.GroupBox7.Controls.Add(Me.CpTextBox)
        Me.GroupBox7.Controls.Add(CtLabel)
        Me.GroupBox7.Controls.Add(Me.CtTextBox)
        Me.GroupBox7.Controls.Add(CmcLabel)
        Me.GroupBox7.Controls.Add(Me.CmcTextBox)
        Me.GroupBox7.Controls.Add(EstadoLabel)
        Me.GroupBox7.Controls.Add(Me.EstadoComboBox)
        Me.GroupBox7.Controls.Add(MaterialLabel)
        Me.GroupBox7.Controls.Add(Me.MaterialComboBox)
        Me.GroupBox7.Controls.Add(AñoLabel)
        Me.GroupBox7.Controls.Add(Me.AñoTextBox)
        Me.GroupBox7.Controls.Add(NivelLabel)
        Me.GroupBox7.Controls.Add(Me.NivelTextBox)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox7.Location = New System.Drawing.Point(3, 278)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(812, 69)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Detalles de la Construccion"
        '
        'MesComboBox
        '
        Me.MesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "Mes", True))
        Me.MesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MesComboBox.FormattingEnabled = True
        Me.MesComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.MesComboBox.Location = New System.Drawing.Point(100, 34)
        Me.MesComboBox.Name = "MesComboBox"
        Me.MesComboBox.Size = New System.Drawing.Size(39, 21)
        Me.MesComboBox.TabIndex = 5
        '
        'AreaConstruidaComunPorcentajeTextBox
        '
        Me.AreaConstruidaComunPorcentajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "AreaConstruidaComunPorcentaje", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "##0.0000%"))
        Me.AreaConstruidaComunPorcentajeTextBox.Location = New System.Drawing.Point(663, 34)
        Me.AreaConstruidaComunPorcentajeTextBox.Name = "AreaConstruidaComunPorcentajeTextBox"
        Me.AreaConstruidaComunPorcentajeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AreaConstruidaComunPorcentajeTextBox.TabIndex = 27
        '
        'AreaConstruidaTextBox
        '
        Me.AreaConstruidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "AreaConstruida", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "#,###,###,###,##0.00 m²"))
        Me.AreaConstruidaTextBox.Location = New System.Drawing.Point(567, 34)
        Me.AreaConstruidaTextBox.Name = "AreaConstruidaTextBox"
        Me.AreaConstruidaTextBox.Size = New System.Drawing.Size(90, 22)
        Me.AreaConstruidaTextBox.TabIndex = 25
        '
        'CiesTextBox
        '
        Me.CiesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "Cies", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CiesTextBox.Location = New System.Drawing.Point(532, 34)
        Me.CiesTextBox.MaxLength = 1
        Me.CiesTextBox.Name = "CiesTextBox"
        Me.CiesTextBox.Size = New System.Drawing.Size(29, 22)
        Me.CiesTextBox.TabIndex = 23
        Me.CiesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CbTextBox
        '
        Me.CbTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "Cb", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CbTextBox.Location = New System.Drawing.Point(496, 34)
        Me.CbTextBox.MaxLength = 1
        Me.CbTextBox.Name = "CbTextBox"
        Me.CbTextBox.Size = New System.Drawing.Size(28, 22)
        Me.CbTextBox.TabIndex = 21
        Me.CbTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CrTextBox
        '
        Me.CrTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "Cr", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CrTextBox.Location = New System.Drawing.Point(460, 34)
        Me.CrTextBox.MaxLength = 1
        Me.CrTextBox.Name = "CrTextBox"
        Me.CrTextBox.Size = New System.Drawing.Size(28, 22)
        Me.CrTextBox.TabIndex = 19
        Me.CrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CpvTextBox
        '
        Me.CpvTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CpvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "Cpv", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CpvTextBox.Location = New System.Drawing.Point(424, 34)
        Me.CpvTextBox.MaxLength = 1
        Me.CpvTextBox.Name = "CpvTextBox"
        Me.CpvTextBox.Size = New System.Drawing.Size(28, 22)
        Me.CpvTextBox.TabIndex = 17
        Me.CpvTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CpTextBox
        '
        Me.CpTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "Cp", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CpTextBox.Location = New System.Drawing.Point(388, 34)
        Me.CpTextBox.MaxLength = 1
        Me.CpTextBox.Name = "CpTextBox"
        Me.CpTextBox.Size = New System.Drawing.Size(28, 22)
        Me.CpTextBox.TabIndex = 15
        Me.CpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CtTextBox
        '
        Me.CtTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "Ct", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CtTextBox.Location = New System.Drawing.Point(352, 34)
        Me.CtTextBox.MaxLength = 1
        Me.CtTextBox.Name = "CtTextBox"
        Me.CtTextBox.Size = New System.Drawing.Size(28, 22)
        Me.CtTextBox.TabIndex = 13
        Me.CtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmcTextBox
        '
        Me.CmcTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CmcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "Cmc", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CmcTextBox.Location = New System.Drawing.Point(316, 34)
        Me.CmcTextBox.MaxLength = 1
        Me.CmcTextBox.Name = "CmcTextBox"
        Me.CmcTextBox.Size = New System.Drawing.Size(28, 22)
        Me.CmcTextBox.TabIndex = 11
        Me.CmcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ConstruccionesBindingSource, "Estado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Location = New System.Drawing.Point(224, 34)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(86, 21)
        Me.EstadoComboBox.TabIndex = 9
        '
        'MaterialComboBox
        '
        Me.MaterialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ConstruccionesBindingSource, "Material", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBox.FormattingEnabled = True
        Me.MaterialComboBox.Location = New System.Drawing.Point(145, 34)
        Me.MaterialComboBox.Name = "MaterialComboBox"
        Me.MaterialComboBox.Size = New System.Drawing.Size(72, 21)
        Me.MaterialComboBox.TabIndex = 7
        '
        'AñoTextBox
        '
        Me.AñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "Año", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.AñoTextBox.Location = New System.Drawing.Point(50, 34)
        Me.AñoTextBox.Name = "AñoTextBox"
        Me.AñoTextBox.Size = New System.Drawing.Size(44, 22)
        Me.AñoTextBox.TabIndex = 3
        '
        'NivelTextBox
        '
        Me.NivelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "Nivel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.NivelTextBox.Location = New System.Drawing.Point(6, 34)
        Me.NivelTextBox.Name = "NivelTextBox"
        Me.NivelTextBox.Size = New System.Drawing.Size(38, 22)
        Me.NivelTextBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(TerrenoAreaExclusivaLabel)
        Me.GroupBox3.Controls.Add(Me.TerrenoAreaExclusivaTextBox)
        Me.GroupBox3.Controls.Add(TerrenoAreaComunLabel)
        Me.GroupBox3.Controls.Add(Me.TerrenoAreaComunTextBox)
        Me.GroupBox3.Controls.Add(TerrenoAreaTotalLabel)
        Me.GroupBox3.Controls.Add(Me.TerrenoAreaTotalTextBox)
        Me.GroupBox3.Controls.Add(ArancelLabel)
        Me.GroupBox3.Controls.Add(Me.ArancelTextBox)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(3, 421)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(818, 62)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Terreno"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(TerrenoValorLabel)
        Me.GroupBox6.Controls.Add(Me.TerrenoValorTextBox)
        Me.GroupBox6.Controls.Add(Me.ConstruccionesValorTextBox)
        Me.GroupBox6.Controls.Add(ConstruccionesValorLabel)
        Me.GroupBox6.Controls.Add(AvaluoLabel)
        Me.GroupBox6.Controls.Add(Me.AvaluoTextBox)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox6.Location = New System.Drawing.Point(3, 483)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(818, 69)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Valorización Predio"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(ClasificacionLabel)
        Me.GroupBox4.Controls.Add(Me.ClasificacionComboBox)
        Me.GroupBox4.Controls.Add(Label1)
        Me.GroupBox4.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(818, 53)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'ClasificacionComboBox
        '
        Me.ClasificacionComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClasificacionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrediosBindingSource, "Clasificacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ClasificacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClasificacionComboBox.DropDownWidth = 500
        Me.ClasificacionComboBox.FormattingEnabled = True
        Me.ClasificacionComboBox.Location = New System.Drawing.Point(401, 21)
        Me.ClasificacionComboBox.Name = "ClasificacionComboBox"
        Me.ClasificacionComboBox.Size = New System.Drawing.Size(408, 21)
        Me.ClasificacionComboBox.TabIndex = 3
        '
        'SimulatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(834, 730)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SimulatorForm"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Simulador Impuesto Predial"
        CType(Me.PrediosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImpuestoPredialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConstruccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PredioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ConstruccionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImpuestoPredialBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PrediosBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents ConstruccionesBindingSource As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripComboBox
    Friend WithEvents PredioDataGridView As DataGridView
    Friend WithEvents BaseImponibleTextBox As TextBox
    Friend WithEvents BaseImponibleDeducidaTextBox As TextBox
    Friend WithEvents InsolutoTextBox As TextBox
    Friend WithEvents ExoneradoCheckBox As CheckBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ConstruccionesDataGridView As DataGridView
    Friend WithEvents TerrenoAreaExclusivaTextBox As TextBox
    Friend WithEvents TerrenoAreaComunTextBox As TextBox
    Friend WithEvents TerrenoAreaTotalTextBox As TextBox
    Friend WithEvents ArancelTextBox As TextBox
    Friend WithEvents TerrenoValorTextBox As TextBox
    Friend WithEvents ConstruccionesValorTextBox As TextBox
    Friend WithEvents AvaluoTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents AñoTextBox As TextBox
    Friend WithEvents NivelTextBox As TextBox
    Friend WithEvents ClasificacionComboBox As ComboBox
    Friend WithEvents MaterialComboBox As ComboBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents CtTextBox As TextBox
    Friend WithEvents CmcTextBox As TextBox
    Friend WithEvents CbTextBox As TextBox
    Friend WithEvents CrTextBox As TextBox
    Friend WithEvents CpvTextBox As TextBox
    Friend WithEvents CpTextBox As TextBox
    Friend WithEvents CiesTextBox As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents AreaConstruidaComunPorcentajeTextBox As TextBox
    Friend WithEvents AreaConstruidaTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents MesComboBox As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Material As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Año As DataGridViewTextBoxColumn
    Friend WithEvents Clasificacion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents ValorDepreciacion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents AreaConstruidaValor As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
End Class
