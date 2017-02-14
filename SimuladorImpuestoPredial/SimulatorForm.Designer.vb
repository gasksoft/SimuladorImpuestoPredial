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
        Dim DireccionLabel As System.Windows.Forms.Label
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
        Dim ValorLabel As System.Windows.Forms.Label
        Dim TerrenoValorLabel1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle66 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle67 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle68 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle69 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimulatorForm))
        Dim DataGridViewCellStyle78 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle70 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle71 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle72 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle73 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle74 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle75 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle76 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle77 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrediosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImpuestoPredialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConstruccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainTs = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripComboBox()
        Me.PredioDataGridView = New System.Windows.Forms.DataGridView()
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorTerrenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorConstruccionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvaluoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaseImponibleTextBox = New System.Windows.Forms.TextBox()
        Me.BaseImponibleDeducidaTextBox = New System.Windows.Forms.TextBox()
        Me.InsolutoTextBox = New System.Windows.Forms.TextBox()
        Me.ExoneradoCheckBox = New System.Windows.Forms.CheckBox()
        Me.PrediosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ResumenGB = New System.Windows.Forms.GroupBox()
        Me.LisatadoPrediosPanel = New System.Windows.Forms.Panel()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ConstruccionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.NivelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClasificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncrementoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDepreciacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaConstruidaValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcConstruccionComunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorConstruccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerrenoAreaExclusivaTextBox = New System.Windows.Forms.TextBox()
        Me.TerrenoAreaComunTextBox = New System.Windows.Forms.TextBox()
        Me.TerrenoAreaTotalTextBox = New System.Windows.Forms.TextBox()
        Me.ArancelTextBox = New System.Windows.Forms.TextBox()
        Me.TerrenoValorTextBox = New System.Windows.Forms.TextBox()
        Me.ConstruccionesValorTextBox = New System.Windows.Forms.TextBox()
        Me.AvaluoTextBox = New System.Windows.Forms.TextBox()
        Me.DetPredioGB = New System.Windows.Forms.GroupBox()
        Me.ConstIfpTabs = New System.Windows.Forms.TabControl()
        Me.ConstruccionesTab = New System.Windows.Forms.TabPage()
        Me.ConstrucciuonesPanel = New System.Windows.Forms.Panel()
        Me.ConstruccionesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DetallesConstruccionGb = New System.Windows.Forms.GroupBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
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
        Me.IfpTab = New System.Windows.Forms.TabPage()
        Me.IfpsComboBox = New System.Windows.Forms.ComboBox()
        Me.IfpsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IfpDenoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IfpDenoComboBox = New System.Windows.Forms.ComboBox()
        Me.TadosTerrenoGb = New System.Windows.Forms.GroupBox()
        Me.TerrenoValorTextBox1 = New System.Windows.Forms.TextBox()
        Me.ValorizacionPredioGb = New System.Windows.Forms.GroupBox()
        Me.DatosPredioGb = New System.Windows.Forms.GroupBox()
        Me.ClasificacionComboBox = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.IfpVusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        DireccionLabel = New System.Windows.Forms.Label()
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
        ValorLabel = New System.Windows.Forms.Label()
        TerrenoValorLabel1 = New System.Windows.Forms.Label()
        CType(Me.PrediosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImpuestoPredialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConstruccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTs.SuspendLayout()
        CType(Me.PredioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrediosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrediosBindingNavigator.SuspendLayout()
        Me.ResumenGB.SuspendLayout()
        Me.LisatadoPrediosPanel.SuspendLayout()
        CType(Me.ConstruccionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetPredioGB.SuspendLayout()
        Me.ConstIfpTabs.SuspendLayout()
        Me.ConstruccionesTab.SuspendLayout()
        Me.ConstrucciuonesPanel.SuspendLayout()
        CType(Me.ConstruccionesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConstruccionesBindingNavigator.SuspendLayout()
        Me.DetallesConstruccionGb.SuspendLayout()
        Me.IfpTab.SuspendLayout()
        CType(Me.IfpsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IfpDenoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TadosTerrenoGb.SuspendLayout()
        Me.ValorizacionPredioGb.SuspendLayout()
        Me.DatosPredioGb.SuspendLayout()
        CType(Me.IfpVusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseImponibleLabel
        '
        BaseImponibleLabel.AutoSize = True
        BaseImponibleLabel.Location = New System.Drawing.Point(701, 22)
        BaseImponibleLabel.Name = "BaseImponibleLabel"
        BaseImponibleLabel.Size = New System.Drawing.Size(89, 13)
        BaseImponibleLabel.TabIndex = 1
        BaseImponibleLabel.Text = "Base Imponible:"
        '
        'BaseImponibleDeducidaLabel
        '
        BaseImponibleDeducidaLabel.AutoSize = True
        BaseImponibleDeducidaLabel.Location = New System.Drawing.Point(649, 50)
        BaseImponibleDeducidaLabel.Name = "BaseImponibleDeducidaLabel"
        BaseImponibleDeducidaLabel.Size = New System.Drawing.Size(141, 13)
        BaseImponibleDeducidaLabel.TabIndex = 3
        BaseImponibleDeducidaLabel.Text = "Base Imponible Deducida:"
        '
        'InsolutoLabel
        '
        InsolutoLabel.AutoSize = True
        InsolutoLabel.Location = New System.Drawing.Point(737, 78)
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
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(6, 24)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(58, 13)
        DireccionLabel.TabIndex = 0
        DireccionLabel.Text = "Dirección:"
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
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(770, 18)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(36, 13)
        ValorLabel.TabIndex = 28
        ValorLabel.Text = "Valor:"
        '
        'TerrenoValorLabel1
        '
        TerrenoValorLabel1.AutoSize = True
        TerrenoValorLabel1.Location = New System.Drawing.Point(716, 24)
        TerrenoValorLabel1.Name = "TerrenoValorLabel1"
        TerrenoValorLabel1.Size = New System.Drawing.Size(36, 13)
        TerrenoValorLabel1.TabIndex = 8
        TerrenoValorLabel1.Text = "Valor:"
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
        'MainTs
        '
        Me.MainTs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.MainTs.Location = New System.Drawing.Point(5, 5)
        Me.MainTs.Name = "MainTs"
        Me.MainTs.Size = New System.Drawing.Size(906, 25)
        Me.MainTs.TabIndex = 0
        Me.MainTs.Text = "ToolStrip1"
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
        Me.PredioDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PredioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PredioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PredioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ObrasComplementariasValorDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.ValorTerrenoDataGridViewTextBoxColumn, Me.ValorConstruccionesDataGridViewTextBoxColumn, Me.AvaluoDataGridViewTextBoxColumn})
        Me.PredioDataGridView.DataSource = Me.PrediosBindingSource
        Me.PredioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PredioDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PredioDataGridView.MultiSelect = False
        Me.PredioDataGridView.Name = "PredioDataGridView"
        Me.PredioDataGridView.ReadOnly = True
        Me.PredioDataGridView.RowHeadersVisible = False
        Me.PredioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PredioDataGridView.Size = New System.Drawing.Size(498, 92)
        Me.PredioDataGridView.TabIndex = 0
        Me.PredioDataGridView.TabStop = False
        '
        'ObrasComplementariasValorDataGridViewTextBoxColumn
        '
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.DataPropertyName = "ObrasComplementariasValor"
        DataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle66.Format = "C2"
        DataGridViewCellStyle66.NullValue = Nothing
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle66
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.HeaderText = "V. O. Comp."
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.Name = "ObrasComplementariasValorDataGridViewTextBoxColumn"
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.Width = 74
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ValorTerrenoDataGridViewTextBoxColumn
        '
        Me.ValorTerrenoDataGridViewTextBoxColumn.DataPropertyName = "TerrenoValor"
        DataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle67.Format = "C2"
        DataGridViewCellStyle67.NullValue = Nothing
        Me.ValorTerrenoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle67
        Me.ValorTerrenoDataGridViewTextBoxColumn.HeaderText = "V. Terreno"
        Me.ValorTerrenoDataGridViewTextBoxColumn.Name = "ValorTerrenoDataGridViewTextBoxColumn"
        Me.ValorTerrenoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorTerrenoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorTerrenoDataGridViewTextBoxColumn.Width = 64
        '
        'ValorConstruccionesDataGridViewTextBoxColumn
        '
        Me.ValorConstruccionesDataGridViewTextBoxColumn.DataPropertyName = "ConstruccionesValor"
        DataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle68.Format = "C2"
        DataGridViewCellStyle68.NullValue = Nothing
        Me.ValorConstruccionesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle68
        Me.ValorConstruccionesDataGridViewTextBoxColumn.HeaderText = "V. Constr."
        Me.ValorConstruccionesDataGridViewTextBoxColumn.Name = "ValorConstruccionesDataGridViewTextBoxColumn"
        Me.ValorConstruccionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorConstruccionesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorConstruccionesDataGridViewTextBoxColumn.Width = 63
        '
        'AvaluoDataGridViewTextBoxColumn
        '
        Me.AvaluoDataGridViewTextBoxColumn.DataPropertyName = "Avaluo"
        DataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle69.Format = "C2"
        DataGridViewCellStyle69.NullValue = Nothing
        Me.AvaluoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle69
        Me.AvaluoDataGridViewTextBoxColumn.HeaderText = "Avaluo"
        Me.AvaluoDataGridViewTextBoxColumn.Name = "AvaluoDataGridViewTextBoxColumn"
        Me.AvaluoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AvaluoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AvaluoDataGridViewTextBoxColumn.Width = 48
        '
        'BaseImponibleTextBox
        '
        Me.BaseImponibleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImpuestoPredialBindingSource, "BaseImponible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.BaseImponibleTextBox.Location = New System.Drawing.Point(796, 19)
        Me.BaseImponibleTextBox.Name = "BaseImponibleTextBox"
        Me.BaseImponibleTextBox.ReadOnly = True
        Me.BaseImponibleTextBox.Size = New System.Drawing.Size(76, 22)
        Me.BaseImponibleTextBox.TabIndex = 2
        Me.BaseImponibleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BaseImponibleDeducidaTextBox
        '
        Me.BaseImponibleDeducidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImpuestoPredialBindingSource, "BaseImponibleDeducida", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.BaseImponibleDeducidaTextBox.Location = New System.Drawing.Point(796, 47)
        Me.BaseImponibleDeducidaTextBox.Name = "BaseImponibleDeducidaTextBox"
        Me.BaseImponibleDeducidaTextBox.ReadOnly = True
        Me.BaseImponibleDeducidaTextBox.Size = New System.Drawing.Size(76, 22)
        Me.BaseImponibleDeducidaTextBox.TabIndex = 4
        Me.BaseImponibleDeducidaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'InsolutoTextBox
        '
        Me.InsolutoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImpuestoPredialBindingSource, "Insoluto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.InsolutoTextBox.Location = New System.Drawing.Point(796, 75)
        Me.InsolutoTextBox.Name = "InsolutoTextBox"
        Me.InsolutoTextBox.ReadOnly = True
        Me.InsolutoTextBox.Size = New System.Drawing.Size(76, 22)
        Me.InsolutoTextBox.TabIndex = 6
        Me.InsolutoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ExoneradoCheckBox
        '
        Me.ExoneradoCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ExoneradoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ImpuestoPredialBindingSource, "Exonerado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ExoneradoCheckBox.Location = New System.Drawing.Point(545, 18)
        Me.ExoneradoCheckBox.Name = "ExoneradoCheckBox"
        Me.ExoneradoCheckBox.Size = New System.Drawing.Size(90, 24)
        Me.ExoneradoCheckBox.TabIndex = 0
        Me.ExoneradoCheckBox.Text = "Exonerado:"
        Me.ExoneradoCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ExoneradoCheckBox.UseVisualStyleBackColor = True
        '
        'PrediosBindingNavigator
        '
        Me.PrediosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PrediosBindingNavigator.BindingSource = Me.PrediosBindingSource
        Me.PrediosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PrediosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PrediosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PrediosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.PrediosBindingNavigator.Location = New System.Drawing.Point(0, 67)
        Me.PrediosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PrediosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PrediosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PrediosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PrediosBindingNavigator.Name = "PrediosBindingNavigator"
        Me.PrediosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PrediosBindingNavigator.Size = New System.Drawing.Size(498, 25)
        Me.PrediosBindingNavigator.TabIndex = 1
        Me.PrediosBindingNavigator.Text = "BindingNavigator1"
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
        'ResumenGB
        '
        Me.ResumenGB.Controls.Add(Me.LisatadoPrediosPanel)
        Me.ResumenGB.Controls.Add(BaseImponibleDeducidaLabel)
        Me.ResumenGB.Controls.Add(Me.ExoneradoCheckBox)
        Me.ResumenGB.Controls.Add(Me.BaseImponibleDeducidaTextBox)
        Me.ResumenGB.Controls.Add(Me.BaseImponibleTextBox)
        Me.ResumenGB.Controls.Add(BaseImponibleLabel)
        Me.ResumenGB.Controls.Add(InsolutoLabel)
        Me.ResumenGB.Controls.Add(Me.InsolutoTextBox)
        Me.ResumenGB.Dock = System.Windows.Forms.DockStyle.Top
        Me.ResumenGB.Location = New System.Drawing.Point(5, 30)
        Me.ResumenGB.Name = "ResumenGB"
        Me.ResumenGB.Size = New System.Drawing.Size(906, 113)
        Me.ResumenGB.TabIndex = 1
        Me.ResumenGB.TabStop = False
        Me.ResumenGB.Text = "Resumen"
        '
        'LisatadoPrediosPanel
        '
        Me.LisatadoPrediosPanel.Controls.Add(Me.PrediosBindingNavigator)
        Me.LisatadoPrediosPanel.Controls.Add(Me.PredioDataGridView)
        Me.LisatadoPrediosPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LisatadoPrediosPanel.Location = New System.Drawing.Point(3, 18)
        Me.LisatadoPrediosPanel.Name = "LisatadoPrediosPanel"
        Me.LisatadoPrediosPanel.Size = New System.Drawing.Size(498, 92)
        Me.LisatadoPrediosPanel.TabIndex = 23
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
        Me.ConstruccionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NivelDataGridViewTextBoxColumn, Me.MaterialDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.AñoDataGridViewTextBoxColumn, Me.ClasificacionDataGridViewTextBoxColumn, Me.CategoriasDataGridViewTextBoxColumn, Me.ValorUnitarioDataGridViewTextBoxColumn, Me.IncrementoDataGridViewTextBoxColumn, Me.ValorDepreciacionDataGridViewTextBoxColumn, Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn, Me.AreaDataGridViewTextBoxColumn, Me.AreaConstruidaValorDataGridViewTextBoxColumn, Me.PorcConstruccionComunDataGridViewTextBoxColumn, Me.ValorCinbstruccionComunDataGridViewTextBoxColumn, Me.ValorConstruccionDataGridViewTextBoxColumn})
        Me.ConstruccionesDataGridView.DataSource = Me.ConstruccionesBindingSource
        DataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle78.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle78.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle78.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle78.Format = "C2"
        DataGridViewCellStyle78.NullValue = Nothing
        DataGridViewCellStyle78.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle78.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle78.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ConstruccionesDataGridView.DefaultCellStyle = DataGridViewCellStyle78
        Me.ConstruccionesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConstruccionesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ConstruccionesDataGridView.MultiSelect = False
        Me.ConstruccionesDataGridView.Name = "ConstruccionesDataGridView"
        Me.ConstruccionesDataGridView.ReadOnly = True
        Me.ConstruccionesDataGridView.RowHeadersVisible = False
        Me.ConstruccionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ConstruccionesDataGridView.Size = New System.Drawing.Size(886, 143)
        Me.ConstruccionesDataGridView.TabIndex = 0
        Me.ConstruccionesDataGridView.TabStop = False
        '
        'NivelDataGridViewTextBoxColumn
        '
        Me.NivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel"
        DataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle70.Format = "N0"
        DataGridViewCellStyle70.NullValue = Nothing
        Me.NivelDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle70
        Me.NivelDataGridViewTextBoxColumn.HeaderText = "Niv"
        Me.NivelDataGridViewTextBoxColumn.Name = "NivelDataGridViewTextBoxColumn"
        Me.NivelDataGridViewTextBoxColumn.ReadOnly = True
        Me.NivelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NivelDataGridViewTextBoxColumn.ToolTipText = "Nivel de edificación (piso)"
        Me.NivelDataGridViewTextBoxColumn.Width = 33
        '
        'MaterialDataGridViewTextBoxColumn
        '
        Me.MaterialDataGridViewTextBoxColumn.DataPropertyName = "Material"
        DataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle71.Format = "N0"
        DataGridViewCellStyle71.NullValue = Nothing
        Me.MaterialDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle71
        Me.MaterialDataGridViewTextBoxColumn.HeaderText = "MEP"
        Me.MaterialDataGridViewTextBoxColumn.Name = "MaterialDataGridViewTextBoxColumn"
        Me.MaterialDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaterialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MaterialDataGridViewTextBoxColumn.ToolTipText = "MAterial estructural predominante"
        Me.MaterialDataGridViewTextBoxColumn.Width = 39
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        DataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle72.Format = "N0"
        Me.EstadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle72
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "EC"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EstadoDataGridViewTextBoxColumn.ToolTipText = "Estado de Conservacion"
        Me.EstadoDataGridViewTextBoxColumn.Width = 30
        '
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "Año"
        DataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle73.Format = "N0"
        Me.AñoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle73
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        Me.AñoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AñoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AñoDataGridViewTextBoxColumn.ToolTipText = "Año de Construccion"
        Me.AñoDataGridViewTextBoxColumn.Width = 38
        '
        'ClasificacionDataGridViewTextBoxColumn
        '
        Me.ClasificacionDataGridViewTextBoxColumn.DataPropertyName = "Clasificacion"
        DataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle74.Format = "N0"
        Me.ClasificacionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle74
        Me.ClasificacionDataGridViewTextBoxColumn.HeaderText = "C"
        Me.ClasificacionDataGridViewTextBoxColumn.Name = "ClasificacionDataGridViewTextBoxColumn"
        Me.ClasificacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClasificacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ClasificacionDataGridViewTextBoxColumn.ToolTipText = "Clasificación del predio"
        Me.ClasificacionDataGridViewTextBoxColumn.Width = 24
        '
        'CategoriasDataGridViewTextBoxColumn
        '
        Me.CategoriasDataGridViewTextBoxColumn.DataPropertyName = "Categorias"
        DataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CategoriasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle75
        Me.CategoriasDataGridViewTextBoxColumn.HeaderText = "Categorias"
        Me.CategoriasDataGridViewTextBoxColumn.Name = "CategoriasDataGridViewTextBoxColumn"
        Me.CategoriasDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoriasDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CategoriasDataGridViewTextBoxColumn.Width = 72
        '
        'ValorUnitarioDataGridViewTextBoxColumn
        '
        Me.ValorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario"
        Me.ValorUnitarioDataGridViewTextBoxColumn.HeaderText = "VU"
        Me.ValorUnitarioDataGridViewTextBoxColumn.Name = "ValorUnitarioDataGridViewTextBoxColumn"
        Me.ValorUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorUnitarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorUnitarioDataGridViewTextBoxColumn.ToolTipText = "Valor Unitario"
        Me.ValorUnitarioDataGridViewTextBoxColumn.Width = 32
        '
        'IncrementoDataGridViewTextBoxColumn
        '
        Me.IncrementoDataGridViewTextBoxColumn.DataPropertyName = "Incremento5Porc"
        Me.IncrementoDataGridViewTextBoxColumn.HeaderText = "5% Inc"
        Me.IncrementoDataGridViewTextBoxColumn.Name = "IncrementoDataGridViewTextBoxColumn"
        Me.IncrementoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IncrementoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IncrementoDataGridViewTextBoxColumn.ToolTipText = "5% Incremento a partir del Quinto Piso"
        Me.IncrementoDataGridViewTextBoxColumn.Width = 50
        '
        'ValorDepreciacionDataGridViewTextBoxColumn
        '
        Me.ValorDepreciacionDataGridViewTextBoxColumn.DataPropertyName = "ValorDepreciacion"
        Me.ValorDepreciacionDataGridViewTextBoxColumn.HeaderText = "VD"
        Me.ValorDepreciacionDataGridViewTextBoxColumn.Name = "ValorDepreciacionDataGridViewTextBoxColumn"
        Me.ValorDepreciacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorDepreciacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorDepreciacionDataGridViewTextBoxColumn.ToolTipText = "Depreciación"
        Me.ValorDepreciacionDataGridViewTextBoxColumn.Width = 32
        '
        'ValorUnitarioDepreciadoDataGridViewTextBoxColumn
        '
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitarioDepreciado"
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.HeaderText = "VUD"
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.Name = "ValorUnitarioDepreciadoDataGridViewTextBoxColumn"
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.ToolTipText = "Valor Unitario Depreciado"
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.Width = 40
        '
        'AreaDataGridViewTextBoxColumn
        '
        Me.AreaDataGridViewTextBoxColumn.DataPropertyName = "AreaConstruida"
        DataGridViewCellStyle76.Format = "#,###,###,##0.00 m²"
        DataGridViewCellStyle76.NullValue = Nothing
        Me.AreaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle76
        Me.AreaDataGridViewTextBoxColumn.HeaderText = "Area"
        Me.AreaDataGridViewTextBoxColumn.Name = "AreaDataGridViewTextBoxColumn"
        Me.AreaDataGridViewTextBoxColumn.ReadOnly = True
        Me.AreaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AreaDataGridViewTextBoxColumn.ToolTipText = "Area Construida"
        Me.AreaDataGridViewTextBoxColumn.Width = 40
        '
        'AreaConstruidaValorDataGridViewTextBoxColumn
        '
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.DataPropertyName = "AreaConstruidaValor"
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.HeaderText = "VAC"
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.Name = "AreaConstruidaValorDataGridViewTextBoxColumn"
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.ReadOnly = True
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.ToolTipText = "Valor Area Construida"
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.Width = 37
        '
        'PorcConstruccionComunDataGridViewTextBoxColumn
        '
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.DataPropertyName = "AreaConstruidaComunPorcentaje"
        DataGridViewCellStyle77.Format = "N4"
        DataGridViewCellStyle77.NullValue = Nothing
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle77
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.HeaderText = "% Comun"
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.Name = "PorcConstruccionComunDataGridViewTextBoxColumn"
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.ReadOnly = True
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.ToolTipText = "Porcentaje de area común"
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.Width = 66
        '
        'ValorCinbstruccionComunDataGridViewTextBoxColumn
        '
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.DataPropertyName = "AreaConstruidaComunValor"
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.HeaderText = "VACC"
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.Name = "ValorCinbstruccionComunDataGridViewTextBoxColumn"
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.ToolTipText = "Valor de area construida común"
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.Width = 44
        '
        'ValorConstruccionDataGridViewTextBoxColumn
        '
        Me.ValorConstruccionDataGridViewTextBoxColumn.DataPropertyName = "Valor"
        Me.ValorConstruccionDataGridViewTextBoxColumn.HeaderText = "VTC"
        Me.ValorConstruccionDataGridViewTextBoxColumn.Name = "ValorConstruccionDataGridViewTextBoxColumn"
        Me.ValorConstruccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorConstruccionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorConstruccionDataGridViewTextBoxColumn.ToolTipText = "Valor total de la construcción"
        Me.ValorConstruccionDataGridViewTextBoxColumn.Width = 35
        '
        'TerrenoAreaExclusivaTextBox
        '
        Me.TerrenoAreaExclusivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoAreaExclusiva", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2"))
        Me.TerrenoAreaExclusivaTextBox.Location = New System.Drawing.Point(93, 21)
        Me.TerrenoAreaExclusivaTextBox.Name = "TerrenoAreaExclusivaTextBox"
        Me.TerrenoAreaExclusivaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TerrenoAreaExclusivaTextBox.TabIndex = 1
        Me.TerrenoAreaExclusivaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TerrenoAreaComunTextBox
        '
        Me.TerrenoAreaComunTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoAreaComun", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2"))
        Me.TerrenoAreaComunTextBox.Location = New System.Drawing.Point(278, 21)
        Me.TerrenoAreaComunTextBox.Name = "TerrenoAreaComunTextBox"
        Me.TerrenoAreaComunTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TerrenoAreaComunTextBox.TabIndex = 3
        Me.TerrenoAreaComunTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TerrenoAreaTotalTextBox
        '
        Me.TerrenoAreaTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoAreaTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,###,###,###,##0.00 m²"))
        Me.TerrenoAreaTotalTextBox.Location = New System.Drawing.Point(450, 21)
        Me.TerrenoAreaTotalTextBox.Name = "TerrenoAreaTotalTextBox"
        Me.TerrenoAreaTotalTextBox.ReadOnly = True
        Me.TerrenoAreaTotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TerrenoAreaTotalTextBox.TabIndex = 5
        Me.TerrenoAreaTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ArancelTextBox
        '
        Me.ArancelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "Arancel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.ArancelTextBox.Location = New System.Drawing.Point(610, 21)
        Me.ArancelTextBox.Name = "ArancelTextBox"
        Me.ArancelTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ArancelTextBox.TabIndex = 7
        Me.ArancelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TerrenoValorTextBox
        '
        Me.TerrenoValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoValor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TerrenoValorTextBox.Location = New System.Drawing.Point(266, 21)
        Me.TerrenoValorTextBox.Name = "TerrenoValorTextBox"
        Me.TerrenoValorTextBox.ReadOnly = True
        Me.TerrenoValorTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TerrenoValorTextBox.TabIndex = 1
        Me.TerrenoValorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ConstruccionesValorTextBox
        '
        Me.ConstruccionesValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "ConstruccionesValor", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ConstruccionesValorTextBox.Location = New System.Drawing.Point(512, 21)
        Me.ConstruccionesValorTextBox.Name = "ConstruccionesValorTextBox"
        Me.ConstruccionesValorTextBox.ReadOnly = True
        Me.ConstruccionesValorTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ConstruccionesValorTextBox.TabIndex = 3
        Me.ConstruccionesValorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AvaluoTextBox
        '
        Me.AvaluoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "Avaluo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.AvaluoTextBox.Location = New System.Drawing.Point(669, 21)
        Me.AvaluoTextBox.Name = "AvaluoTextBox"
        Me.AvaluoTextBox.ReadOnly = True
        Me.AvaluoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AvaluoTextBox.TabIndex = 5
        Me.AvaluoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DetPredioGB
        '
        Me.DetPredioGB.Controls.Add(Me.ConstIfpTabs)
        Me.DetPredioGB.Controls.Add(Me.TadosTerrenoGb)
        Me.DetPredioGB.Controls.Add(Me.ValorizacionPredioGb)
        Me.DetPredioGB.Controls.Add(Me.DatosPredioGb)
        Me.DetPredioGB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetPredioGB.Location = New System.Drawing.Point(5, 143)
        Me.DetPredioGB.Name = "DetPredioGB"
        Me.DetPredioGB.Size = New System.Drawing.Size(906, 441)
        Me.DetPredioGB.TabIndex = 2
        Me.DetPredioGB.TabStop = False
        Me.DetPredioGB.Text = "Detalles del Predio"
        '
        'ConstIfpTabs
        '
        Me.ConstIfpTabs.Controls.Add(Me.ConstruccionesTab)
        Me.ConstIfpTabs.Controls.Add(Me.IfpTab)
        Me.ConstIfpTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConstIfpTabs.Location = New System.Drawing.Point(3, 71)
        Me.ConstIfpTabs.Name = "ConstIfpTabs"
        Me.ConstIfpTabs.SelectedIndex = 0
        Me.ConstIfpTabs.Size = New System.Drawing.Size(900, 264)
        Me.ConstIfpTabs.TabIndex = 24
        '
        'ConstruccionesTab
        '
        Me.ConstruccionesTab.Controls.Add(Me.ConstrucciuonesPanel)
        Me.ConstruccionesTab.Controls.Add(Me.DetallesConstruccionGb)
        Me.ConstruccionesTab.Location = New System.Drawing.Point(4, 22)
        Me.ConstruccionesTab.Name = "ConstruccionesTab"
        Me.ConstruccionesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ConstruccionesTab.Size = New System.Drawing.Size(892, 238)
        Me.ConstruccionesTab.TabIndex = 0
        Me.ConstruccionesTab.Text = "TabPage1"
        Me.ConstruccionesTab.UseVisualStyleBackColor = True
        '
        'ConstrucciuonesPanel
        '
        Me.ConstrucciuonesPanel.Controls.Add(Me.ConstruccionesDataGridView)
        Me.ConstrucciuonesPanel.Controls.Add(Me.ConstruccionesBindingNavigator)
        Me.ConstrucciuonesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConstrucciuonesPanel.Location = New System.Drawing.Point(3, 3)
        Me.ConstrucciuonesPanel.Name = "ConstrucciuonesPanel"
        Me.ConstrucciuonesPanel.Size = New System.Drawing.Size(886, 168)
        Me.ConstrucciuonesPanel.TabIndex = 1
        '
        'ConstruccionesBindingNavigator
        '
        Me.ConstruccionesBindingNavigator.AddNewItem = Me.ToolStripButton1
        Me.ConstruccionesBindingNavigator.BindingSource = Me.ConstruccionesBindingSource
        Me.ConstruccionesBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.ConstruccionesBindingNavigator.DeleteItem = Me.ToolStripButton2
        Me.ConstruccionesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ConstruccionesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ConstruccionesBindingNavigator.Location = New System.Drawing.Point(0, 143)
        Me.ConstruccionesBindingNavigator.MoveFirstItem = Me.ToolStripButton3
        Me.ConstruccionesBindingNavigator.MoveLastItem = Me.ToolStripButton6
        Me.ConstruccionesBindingNavigator.MoveNextItem = Me.ToolStripButton5
        Me.ConstruccionesBindingNavigator.MovePreviousItem = Me.ToolStripButton4
        Me.ConstruccionesBindingNavigator.Name = "ConstruccionesBindingNavigator"
        Me.ConstruccionesBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.ConstruccionesBindingNavigator.Size = New System.Drawing.Size(886, 25)
        Me.ConstruccionesBindingNavigator.TabIndex = 1
        Me.ConstruccionesBindingNavigator.Text = "BindingNavigator2"
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
        'DetallesConstruccionGb
        '
        Me.DetallesConstruccionGb.Controls.Add(ValorLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.ValorTextBox)
        Me.DetallesConstruccionGb.Controls.Add(MesLabel1)
        Me.DetallesConstruccionGb.Controls.Add(AreaConstruidaComunPorcentajeLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.MesComboBox)
        Me.DetallesConstruccionGb.Controls.Add(Me.AreaConstruidaComunPorcentajeTextBox)
        Me.DetallesConstruccionGb.Controls.Add(AreaConstruidaLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.AreaConstruidaTextBox)
        Me.DetallesConstruccionGb.Controls.Add(CiesLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.CiesTextBox)
        Me.DetallesConstruccionGb.Controls.Add(CbLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.CbTextBox)
        Me.DetallesConstruccionGb.Controls.Add(CrLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.CrTextBox)
        Me.DetallesConstruccionGb.Controls.Add(CpvLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.CpvTextBox)
        Me.DetallesConstruccionGb.Controls.Add(CpLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.CpTextBox)
        Me.DetallesConstruccionGb.Controls.Add(CtLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.CtTextBox)
        Me.DetallesConstruccionGb.Controls.Add(CmcLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.CmcTextBox)
        Me.DetallesConstruccionGb.Controls.Add(EstadoLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.EstadoComboBox)
        Me.DetallesConstruccionGb.Controls.Add(MaterialLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.MaterialComboBox)
        Me.DetallesConstruccionGb.Controls.Add(AñoLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.AñoTextBox)
        Me.DetallesConstruccionGb.Controls.Add(NivelLabel)
        Me.DetallesConstruccionGb.Controls.Add(Me.NivelTextBox)
        Me.DetallesConstruccionGb.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DetallesConstruccionGb.Location = New System.Drawing.Point(3, 171)
        Me.DetallesConstruccionGb.Name = "DetallesConstruccionGb"
        Me.DetallesConstruccionGb.Size = New System.Drawing.Size(886, 64)
        Me.DetallesConstruccionGb.TabIndex = 1
        Me.DetallesConstruccionGb.TabStop = False
        Me.DetallesConstruccionGb.Text = "Detalles de la Construccion"
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "Valor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.ValorTextBox.Location = New System.Drawing.Point(769, 34)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.ReadOnly = True
        Me.ValorTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ValorTextBox.TabIndex = 29
        Me.ValorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.AreaConstruidaComunPorcentajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "AreaConstruidaComunPorcentaje", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N4"))
        Me.AreaConstruidaComunPorcentajeTextBox.Location = New System.Drawing.Point(663, 34)
        Me.AreaConstruidaComunPorcentajeTextBox.Name = "AreaConstruidaComunPorcentajeTextBox"
        Me.AreaConstruidaComunPorcentajeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AreaConstruidaComunPorcentajeTextBox.TabIndex = 27
        Me.AreaConstruidaComunPorcentajeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AreaConstruidaTextBox
        '
        Me.AreaConstruidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConstruccionesBindingSource, "AreaConstruida", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2"))
        Me.AreaConstruidaTextBox.Location = New System.Drawing.Point(567, 34)
        Me.AreaConstruidaTextBox.Name = "AreaConstruidaTextBox"
        Me.AreaConstruidaTextBox.Size = New System.Drawing.Size(90, 22)
        Me.AreaConstruidaTextBox.TabIndex = 25
        Me.AreaConstruidaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'IfpTab
        '
        Me.IfpTab.AutoScroll = True
        Me.IfpTab.Controls.Add(Me.IfpsComboBox)
        Me.IfpTab.Controls.Add(Me.IfpDenoComboBox)
        Me.IfpTab.Location = New System.Drawing.Point(4, 22)
        Me.IfpTab.Name = "IfpTab"
        Me.IfpTab.Padding = New System.Windows.Forms.Padding(3)
        Me.IfpTab.Size = New System.Drawing.Size(892, 238)
        Me.IfpTab.TabIndex = 1
        Me.IfpTab.Text = "TabPage2"
        Me.IfpTab.UseVisualStyleBackColor = True
        '
        'IfpsComboBox
        '
        Me.IfpsComboBox.DataSource = Me.IfpsBindingSource
        Me.IfpsComboBox.DisplayMember = "Desc"
        Me.IfpsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IfpsComboBox.FormattingEnabled = True
        Me.IfpsComboBox.Location = New System.Drawing.Point(6, 33)
        Me.IfpsComboBox.Name = "IfpsComboBox"
        Me.IfpsComboBox.Size = New System.Drawing.Size(496, 21)
        Me.IfpsComboBox.TabIndex = 1
        Me.IfpsComboBox.ValueMember = "Desc"
        '
        'IfpsBindingSource
        '
        Me.IfpsBindingSource.DataMember = "Ifps"
        Me.IfpsBindingSource.DataSource = Me.IfpDenoBindingSource
        '
        'IfpDenoBindingSource
        '
        Me.IfpDenoBindingSource.DataSource = GetType(SimuladorImpuestoPredial.Entidades.IfpDeno)
        '
        'IfpDenoComboBox
        '
        Me.IfpDenoComboBox.DataSource = Me.IfpDenoBindingSource
        Me.IfpDenoComboBox.DisplayMember = "Desc"
        Me.IfpDenoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IfpDenoComboBox.FormattingEnabled = True
        Me.IfpDenoComboBox.Location = New System.Drawing.Point(6, 6)
        Me.IfpDenoComboBox.Name = "IfpDenoComboBox"
        Me.IfpDenoComboBox.Size = New System.Drawing.Size(496, 21)
        Me.IfpDenoComboBox.TabIndex = 0
        Me.IfpDenoComboBox.ValueMember = "Desc"
        '
        'TadosTerrenoGb
        '
        Me.TadosTerrenoGb.Controls.Add(TerrenoValorLabel1)
        Me.TadosTerrenoGb.Controls.Add(Me.TerrenoValorTextBox1)
        Me.TadosTerrenoGb.Controls.Add(TerrenoAreaExclusivaLabel)
        Me.TadosTerrenoGb.Controls.Add(Me.TerrenoAreaExclusivaTextBox)
        Me.TadosTerrenoGb.Controls.Add(TerrenoAreaComunLabel)
        Me.TadosTerrenoGb.Controls.Add(Me.TerrenoAreaComunTextBox)
        Me.TadosTerrenoGb.Controls.Add(TerrenoAreaTotalLabel)
        Me.TadosTerrenoGb.Controls.Add(Me.TerrenoAreaTotalTextBox)
        Me.TadosTerrenoGb.Controls.Add(ArancelLabel)
        Me.TadosTerrenoGb.Controls.Add(Me.ArancelTextBox)
        Me.TadosTerrenoGb.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TadosTerrenoGb.Location = New System.Drawing.Point(3, 335)
        Me.TadosTerrenoGb.Name = "TadosTerrenoGb"
        Me.TadosTerrenoGb.Size = New System.Drawing.Size(900, 52)
        Me.TadosTerrenoGb.TabIndex = 2
        Me.TadosTerrenoGb.TabStop = False
        Me.TadosTerrenoGb.Text = "Terreno"
        '
        'TerrenoValorTextBox1
        '
        Me.TerrenoValorTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoValor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.TerrenoValorTextBox1.Location = New System.Drawing.Point(758, 21)
        Me.TerrenoValorTextBox1.Name = "TerrenoValorTextBox1"
        Me.TerrenoValorTextBox1.ReadOnly = True
        Me.TerrenoValorTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TerrenoValorTextBox1.TabIndex = 9
        Me.TerrenoValorTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ValorizacionPredioGb
        '
        Me.ValorizacionPredioGb.Controls.Add(TerrenoValorLabel)
        Me.ValorizacionPredioGb.Controls.Add(Me.TerrenoValorTextBox)
        Me.ValorizacionPredioGb.Controls.Add(Me.ConstruccionesValorTextBox)
        Me.ValorizacionPredioGb.Controls.Add(ConstruccionesValorLabel)
        Me.ValorizacionPredioGb.Controls.Add(AvaluoLabel)
        Me.ValorizacionPredioGb.Controls.Add(Me.AvaluoTextBox)
        Me.ValorizacionPredioGb.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ValorizacionPredioGb.Location = New System.Drawing.Point(3, 387)
        Me.ValorizacionPredioGb.Name = "ValorizacionPredioGb"
        Me.ValorizacionPredioGb.Size = New System.Drawing.Size(900, 51)
        Me.ValorizacionPredioGb.TabIndex = 3
        Me.ValorizacionPredioGb.TabStop = False
        Me.ValorizacionPredioGb.Text = "Valorización Predio"
        '
        'DatosPredioGb
        '
        Me.DatosPredioGb.Controls.Add(ClasificacionLabel)
        Me.DatosPredioGb.Controls.Add(Me.ClasificacionComboBox)
        Me.DatosPredioGb.Controls.Add(DireccionLabel)
        Me.DatosPredioGb.Controls.Add(Me.DireccionTextBox)
        Me.DatosPredioGb.Dock = System.Windows.Forms.DockStyle.Top
        Me.DatosPredioGb.Location = New System.Drawing.Point(3, 18)
        Me.DatosPredioGb.Name = "DatosPredioGb"
        Me.DatosPredioGb.Size = New System.Drawing.Size(900, 53)
        Me.DatosPredioGb.TabIndex = 0
        Me.DatosPredioGb.TabStop = False
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
        Me.ClasificacionComboBox.Size = New System.Drawing.Size(490, 21)
        Me.ClasificacionComboBox.TabIndex = 3
        '
        'IfpVusBindingSource
        '
        Me.IfpVusBindingSource.DataMember = "IfpVus"
        Me.IfpVusBindingSource.DataSource = Me.IfpsBindingSource
        '
        'SimulatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(916, 589)
        Me.Controls.Add(Me.DetPredioGB)
        Me.Controls.Add(Me.ResumenGB)
        Me.Controls.Add(Me.MainTs)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SimulatorForm"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Simulador Impuesto Predial"
        CType(Me.PrediosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImpuestoPredialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConstruccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTs.ResumeLayout(False)
        Me.MainTs.PerformLayout()
        CType(Me.PredioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrediosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrediosBindingNavigator.ResumeLayout(False)
        Me.PrediosBindingNavigator.PerformLayout()
        Me.ResumenGB.ResumeLayout(False)
        Me.ResumenGB.PerformLayout()
        Me.LisatadoPrediosPanel.ResumeLayout(False)
        Me.LisatadoPrediosPanel.PerformLayout()
        CType(Me.ConstruccionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetPredioGB.ResumeLayout(False)
        Me.ConstIfpTabs.ResumeLayout(False)
        Me.ConstruccionesTab.ResumeLayout(False)
        Me.ConstrucciuonesPanel.ResumeLayout(False)
        Me.ConstrucciuonesPanel.PerformLayout()
        CType(Me.ConstruccionesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConstruccionesBindingNavigator.ResumeLayout(False)
        Me.ConstruccionesBindingNavigator.PerformLayout()
        Me.DetallesConstruccionGb.ResumeLayout(False)
        Me.DetallesConstruccionGb.PerformLayout()
        Me.IfpTab.ResumeLayout(False)
        CType(Me.IfpsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IfpDenoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TadosTerrenoGb.ResumeLayout(False)
        Me.TadosTerrenoGb.PerformLayout()
        Me.ValorizacionPredioGb.ResumeLayout(False)
        Me.ValorizacionPredioGb.PerformLayout()
        Me.DatosPredioGb.ResumeLayout(False)
        Me.DatosPredioGb.PerformLayout()
        CType(Me.IfpVusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImpuestoPredialBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PrediosBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents ConstruccionesBindingSource As BindingSource
    Friend WithEvents MainTs As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripComboBox
    Friend WithEvents PredioDataGridView As DataGridView
    Friend WithEvents BaseImponibleTextBox As TextBox
    Friend WithEvents BaseImponibleDeducidaTextBox As TextBox
    Friend WithEvents InsolutoTextBox As TextBox
    Friend WithEvents ExoneradoCheckBox As CheckBox
    Friend WithEvents PrediosBindingNavigator As BindingNavigator
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
    Friend WithEvents ResumenGB As GroupBox
    Friend WithEvents LisatadoPrediosPanel As Panel
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ConstruccionesDataGridView As DataGridView
    Friend WithEvents TerrenoAreaExclusivaTextBox As TextBox
    Friend WithEvents TerrenoAreaComunTextBox As TextBox
    Friend WithEvents TerrenoAreaTotalTextBox As TextBox
    Friend WithEvents ArancelTextBox As TextBox
    Friend WithEvents TerrenoValorTextBox As TextBox
    Friend WithEvents ConstruccionesValorTextBox As TextBox
    Friend WithEvents AvaluoTextBox As TextBox
    Friend WithEvents DetPredioGB As GroupBox
    Friend WithEvents ConstruccionesBindingNavigator As BindingNavigator
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
    Friend WithEvents ValorizacionPredioGb As GroupBox
    Friend WithEvents TadosTerrenoGb As GroupBox
    Friend WithEvents DatosPredioGb As GroupBox
    Friend WithEvents ConstrucciuonesPanel As Panel
    Friend WithEvents DetallesConstruccionGb As GroupBox
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
    Friend WithEvents MesComboBox As ComboBox
    Friend WithEvents ValorTextBox As TextBox
    Friend WithEvents TerrenoValorTextBox1 As TextBox
    Friend WithEvents NivelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClasificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncrementoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorDepreciacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorUnitarioDepreciadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreaConstruidaValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PorcConstruccionComunDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorCinbstruccionComunDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorConstruccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConstIfpTabs As TabControl
    Friend WithEvents ConstruccionesTab As TabPage
    Friend WithEvents IfpTab As TabPage
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorTerrenoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorConstruccionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObrasComplementariasValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AvaluoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IfpsComboBox As ComboBox
    Friend WithEvents IfpsBindingSource As BindingSource
    Friend WithEvents IfpDenoBindingSource As BindingSource
    Friend WithEvents IfpDenoComboBox As ComboBox
    Friend WithEvents IfpVusBindingSource As BindingSource
End Class
