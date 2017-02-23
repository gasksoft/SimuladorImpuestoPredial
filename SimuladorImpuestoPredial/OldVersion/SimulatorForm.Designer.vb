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
        Dim TerrenoValorLabel1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimulatorForm))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrediosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImpuestoPredialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConstruccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainTs = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripComboBox()
        Me.PredioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.SinDetalleCheckBox = New System.Windows.Forms.CheckBox()
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelDCI = New System.Windows.Forms.Label()
        Me.labelVCI = New System.Windows.Forms.Label()
        Me.LabelTituloCategoria = New System.Windows.Forms.Label()
        Me.labelECI = New System.Windows.Forms.Label()
        Me.labelECA = New System.Windows.Forms.Label()
        Me.labelVCG = New System.Windows.Forms.Label()
        Me.labelVCA = New System.Windows.Forms.Label()
        Me.labelVCH = New System.Windows.Forms.Label()
        Me.labelDCA = New System.Windows.Forms.Label()
        Me.labelVCE = New System.Windows.Forms.Label()
        Me.labelECB = New System.Windows.Forms.Label()
        Me.labelVCF = New System.Windows.Forms.Label()
        Me.labelDCB = New System.Windows.Forms.Label()
        Me.labelVCD = New System.Windows.Forms.Label()
        Me.labelVCC = New System.Windows.Forms.Label()
        Me.labelECG = New System.Windows.Forms.Label()
        Me.labelDCC = New System.Windows.Forms.Label()
        Me.labelECH = New System.Windows.Forms.Label()
        Me.labelECC = New System.Windows.Forms.Label()
        Me.labelECF = New System.Windows.Forms.Label()
        Me.labelVCB = New System.Windows.Forms.Label()
        Me.labelECE = New System.Windows.Forms.Label()
        Me.labelECD = New System.Windows.Forms.Label()
        Me.labelDCD = New System.Windows.Forms.Label()
        Me.LabelDCH = New System.Windows.Forms.Label()
        Me.labelDCE = New System.Windows.Forms.Label()
        Me.labelDCG = New System.Windows.Forms.Label()
        Me.labelDCF = New System.Windows.Forms.Label()
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
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaseImponibleLabel
        '
        BaseImponibleLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BaseImponibleLabel.AutoSize = True
        BaseImponibleLabel.Location = New System.Drawing.Point(611, 30)
        BaseImponibleLabel.Name = "BaseImponibleLabel"
        BaseImponibleLabel.Size = New System.Drawing.Size(89, 13)
        BaseImponibleLabel.TabIndex = 1
        BaseImponibleLabel.Text = "Base Imponible:"
        '
        'BaseImponibleDeducidaLabel
        '
        BaseImponibleDeducidaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BaseImponibleDeducidaLabel.AutoSize = True
        BaseImponibleDeducidaLabel.Location = New System.Drawing.Point(589, 58)
        BaseImponibleDeducidaLabel.Name = "BaseImponibleDeducidaLabel"
        BaseImponibleDeducidaLabel.Size = New System.Drawing.Size(111, 13)
        BaseImponibleDeducidaLabel.TabIndex = 3
        BaseImponibleDeducidaLabel.Text = "Base Imp. Deducida:"
        '
        'InsolutoLabel
        '
        InsolutoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        InsolutoLabel.AutoSize = True
        InsolutoLabel.Location = New System.Drawing.Point(647, 86)
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
        TerrenoAreaComunLabel.Location = New System.Drawing.Point(179, 24)
        TerrenoAreaComunLabel.Name = "TerrenoAreaComunLabel"
        TerrenoAreaComunLabel.Size = New System.Drawing.Size(73, 13)
        TerrenoAreaComunLabel.TabIndex = 2
        TerrenoAreaComunLabel.Text = "Area Comun:"
        '
        'TerrenoAreaTotalLabel
        '
        TerrenoAreaTotalLabel.AutoSize = True
        TerrenoAreaTotalLabel.Location = New System.Drawing.Point(344, 24)
        TerrenoAreaTotalLabel.Name = "TerrenoAreaTotalLabel"
        TerrenoAreaTotalLabel.Size = New System.Drawing.Size(60, 13)
        TerrenoAreaTotalLabel.TabIndex = 4
        TerrenoAreaTotalLabel.Text = "Area Total:"
        '
        'ArancelLabel
        '
        ArancelLabel.AutoSize = True
        ArancelLabel.Location = New System.Drawing.Point(496, 24)
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
        'TerrenoValorLabel1
        '
        TerrenoValorLabel1.AutoSize = True
        TerrenoValorLabel1.Location = New System.Drawing.Point(636, 24)
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
        Me.MainTs.Location = New System.Drawing.Point(0, 0)
        Me.MainTs.Name = "MainTs"
        Me.MainTs.Size = New System.Drawing.Size(789, 25)
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
        Me.PredioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DireccionDataGridViewTextBoxColumn, Me.ObrasComplementariasValorDataGridViewTextBoxColumn, Me.ValorTerrenoDataGridViewTextBoxColumn, Me.ValorConstruccionesDataGridViewTextBoxColumn, Me.AvaluoDataGridViewTextBoxColumn})
        Me.PredioDataGridView.DataSource = Me.PrediosBindingSource
        Me.PredioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PredioDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PredioDataGridView.MultiSelect = False
        Me.PredioDataGridView.Name = "PredioDataGridView"
        Me.PredioDataGridView.ReadOnly = True
        Me.PredioDataGridView.RowHeadersVisible = False
        Me.PredioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PredioDataGridView.Size = New System.Drawing.Size(489, 67)
        Me.PredioDataGridView.TabIndex = 0
        Me.PredioDataGridView.TabStop = False
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
        'ObrasComplementariasValorDataGridViewTextBoxColumn
        '
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.DataPropertyName = "ObrasComplementariasValor"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.HeaderText = "V. O. Comp."
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.Name = "ObrasComplementariasValorDataGridViewTextBoxColumn"
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ObrasComplementariasValorDataGridViewTextBoxColumn.Width = 74
        '
        'ValorTerrenoDataGridViewTextBoxColumn
        '
        Me.ValorTerrenoDataGridViewTextBoxColumn.DataPropertyName = "TerrenoValor"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ValorTerrenoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ValorTerrenoDataGridViewTextBoxColumn.HeaderText = "V. Terreno"
        Me.ValorTerrenoDataGridViewTextBoxColumn.Name = "ValorTerrenoDataGridViewTextBoxColumn"
        Me.ValorTerrenoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorTerrenoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorTerrenoDataGridViewTextBoxColumn.Width = 64
        '
        'ValorConstruccionesDataGridViewTextBoxColumn
        '
        Me.ValorConstruccionesDataGridViewTextBoxColumn.DataPropertyName = "ConstruccionesValor"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ValorConstruccionesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ValorConstruccionesDataGridViewTextBoxColumn.HeaderText = "V. Constr."
        Me.ValorConstruccionesDataGridViewTextBoxColumn.Name = "ValorConstruccionesDataGridViewTextBoxColumn"
        Me.ValorConstruccionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorConstruccionesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorConstruccionesDataGridViewTextBoxColumn.Width = 63
        '
        'AvaluoDataGridViewTextBoxColumn
        '
        Me.AvaluoDataGridViewTextBoxColumn.DataPropertyName = "Avaluo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.AvaluoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.AvaluoDataGridViewTextBoxColumn.HeaderText = "Avaluo"
        Me.AvaluoDataGridViewTextBoxColumn.Name = "AvaluoDataGridViewTextBoxColumn"
        Me.AvaluoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AvaluoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AvaluoDataGridViewTextBoxColumn.Width = 48
        '
        'BaseImponibleTextBox
        '
        Me.BaseImponibleTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BaseImponibleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImpuestoPredialBindingSource, "BaseImponible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.BaseImponibleTextBox.Location = New System.Drawing.Point(701, 27)
        Me.BaseImponibleTextBox.Name = "BaseImponibleTextBox"
        Me.BaseImponibleTextBox.ReadOnly = True
        Me.BaseImponibleTextBox.Size = New System.Drawing.Size(76, 22)
        Me.BaseImponibleTextBox.TabIndex = 2
        Me.BaseImponibleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BaseImponibleDeducidaTextBox
        '
        Me.BaseImponibleDeducidaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BaseImponibleDeducidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImpuestoPredialBindingSource, "BaseImponibleDeducida", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.BaseImponibleDeducidaTextBox.Location = New System.Drawing.Point(701, 55)
        Me.BaseImponibleDeducidaTextBox.Name = "BaseImponibleDeducidaTextBox"
        Me.BaseImponibleDeducidaTextBox.ReadOnly = True
        Me.BaseImponibleDeducidaTextBox.Size = New System.Drawing.Size(76, 22)
        Me.BaseImponibleDeducidaTextBox.TabIndex = 4
        Me.BaseImponibleDeducidaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'InsolutoTextBox
        '
        Me.InsolutoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InsolutoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImpuestoPredialBindingSource, "Insoluto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.InsolutoTextBox.Location = New System.Drawing.Point(701, 83)
        Me.InsolutoTextBox.Name = "InsolutoTextBox"
        Me.InsolutoTextBox.ReadOnly = True
        Me.InsolutoTextBox.Size = New System.Drawing.Size(76, 22)
        Me.InsolutoTextBox.TabIndex = 6
        Me.InsolutoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ExoneradoCheckBox
        '
        Me.ExoneradoCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExoneradoCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ExoneradoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ImpuestoPredialBindingSource, "Exonerado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ExoneradoCheckBox.Location = New System.Drawing.Point(498, 28)
        Me.ExoneradoCheckBox.Name = "ExoneradoCheckBox"
        Me.ExoneradoCheckBox.Size = New System.Drawing.Size(85, 24)
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
        Me.PrediosBindingNavigator.Size = New System.Drawing.Size(489, 25)
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
        Me.ResumenGB.Controls.Add(Me.SinDetalleCheckBox)
        Me.ResumenGB.Controls.Add(Me.LisatadoPrediosPanel)
        Me.ResumenGB.Controls.Add(BaseImponibleDeducidaLabel)
        Me.ResumenGB.Controls.Add(Me.ExoneradoCheckBox)
        Me.ResumenGB.Controls.Add(Me.BaseImponibleDeducidaTextBox)
        Me.ResumenGB.Controls.Add(Me.BaseImponibleTextBox)
        Me.ResumenGB.Controls.Add(BaseImponibleLabel)
        Me.ResumenGB.Controls.Add(InsolutoLabel)
        Me.ResumenGB.Controls.Add(Me.InsolutoTextBox)
        Me.ResumenGB.Dock = System.Windows.Forms.DockStyle.Top
        Me.ResumenGB.Location = New System.Drawing.Point(0, 0)
        Me.ResumenGB.Name = "ResumenGB"
        Me.ResumenGB.Size = New System.Drawing.Size(789, 130)
        Me.ResumenGB.TabIndex = 1
        Me.ResumenGB.TabStop = False
        Me.ResumenGB.Text = "Resumen"
        '
        'SinDetalleCheckBox
        '
        Me.SinDetalleCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SinDetalleCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SinDetalleCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ImpuestoPredialBindingSource, "SinDetalle", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SinDetalleCheckBox.Location = New System.Drawing.Point(498, 53)
        Me.SinDetalleCheckBox.Name = "SinDetalleCheckBox"
        Me.SinDetalleCheckBox.Size = New System.Drawing.Size(85, 24)
        Me.SinDetalleCheckBox.TabIndex = 24
        Me.SinDetalleCheckBox.Text = "Sin Detalle"
        Me.SinDetalleCheckBox.UseVisualStyleBackColor = True
        '
        'LisatadoPrediosPanel
        '
        Me.LisatadoPrediosPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LisatadoPrediosPanel.Controls.Add(Me.PredioDataGridView)
        Me.LisatadoPrediosPanel.Controls.Add(Me.PrediosBindingNavigator)
        Me.LisatadoPrediosPanel.Location = New System.Drawing.Point(3, 18)
        Me.LisatadoPrediosPanel.Name = "LisatadoPrediosPanel"
        Me.LisatadoPrediosPanel.Size = New System.Drawing.Size(489, 92)
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
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.Format = "C2"
        DataGridViewCellStyle13.NullValue = Nothing
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ConstruccionesDataGridView.DefaultCellStyle = DataGridViewCellStyle13
        Me.ConstruccionesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConstruccionesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ConstruccionesDataGridView.MultiSelect = False
        Me.ConstruccionesDataGridView.Name = "ConstruccionesDataGridView"
        Me.ConstruccionesDataGridView.ReadOnly = True
        Me.ConstruccionesDataGridView.RowHeadersVisible = False
        Me.ConstruccionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ConstruccionesDataGridView.Size = New System.Drawing.Size(769, 126)
        Me.ConstruccionesDataGridView.TabIndex = 0
        Me.ConstruccionesDataGridView.TabStop = False
        '
        'NivelDataGridViewTextBoxColumn
        '
        Me.NivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.NivelDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.NivelDataGridViewTextBoxColumn.HeaderText = "Niv"
        Me.NivelDataGridViewTextBoxColumn.Name = "NivelDataGridViewTextBoxColumn"
        Me.NivelDataGridViewTextBoxColumn.ReadOnly = True
        Me.NivelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NivelDataGridViewTextBoxColumn.ToolTipText = "Nivel de edificación (piso)"
        Me.NivelDataGridViewTextBoxColumn.Width = 29
        '
        'MaterialDataGridViewTextBoxColumn
        '
        Me.MaterialDataGridViewTextBoxColumn.DataPropertyName = "Material"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.MaterialDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.MaterialDataGridViewTextBoxColumn.HeaderText = "MEP"
        Me.MaterialDataGridViewTextBoxColumn.Name = "MaterialDataGridViewTextBoxColumn"
        Me.MaterialDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaterialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MaterialDataGridViewTextBoxColumn.ToolTipText = "MAterial estructural predominante"
        Me.MaterialDataGridViewTextBoxColumn.Width = 35
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "N0"
        Me.EstadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "EC"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EstadoDataGridViewTextBoxColumn.ToolTipText = "Estado de Conservacion"
        Me.EstadoDataGridViewTextBoxColumn.Width = 26
        '
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "Año"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "N0"
        Me.AñoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        Me.AñoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AñoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AñoDataGridViewTextBoxColumn.ToolTipText = "Año de Construccion"
        Me.AñoDataGridViewTextBoxColumn.Width = 34
        '
        'ClasificacionDataGridViewTextBoxColumn
        '
        Me.ClasificacionDataGridViewTextBoxColumn.DataPropertyName = "Clasificacion"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "N0"
        Me.ClasificacionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.ClasificacionDataGridViewTextBoxColumn.HeaderText = "C"
        Me.ClasificacionDataGridViewTextBoxColumn.Name = "ClasificacionDataGridViewTextBoxColumn"
        Me.ClasificacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClasificacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ClasificacionDataGridViewTextBoxColumn.ToolTipText = "Clasificación del predio"
        Me.ClasificacionDataGridViewTextBoxColumn.Width = 20
        '
        'CategoriasDataGridViewTextBoxColumn
        '
        Me.CategoriasDataGridViewTextBoxColumn.DataPropertyName = "Categorias"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CategoriasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.CategoriasDataGridViewTextBoxColumn.HeaderText = "Categorias"
        Me.CategoriasDataGridViewTextBoxColumn.Name = "CategoriasDataGridViewTextBoxColumn"
        Me.CategoriasDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoriasDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CategoriasDataGridViewTextBoxColumn.Width = 68
        '
        'ValorUnitarioDataGridViewTextBoxColumn
        '
        Me.ValorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario"
        Me.ValorUnitarioDataGridViewTextBoxColumn.HeaderText = "VU"
        Me.ValorUnitarioDataGridViewTextBoxColumn.Name = "ValorUnitarioDataGridViewTextBoxColumn"
        Me.ValorUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorUnitarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorUnitarioDataGridViewTextBoxColumn.ToolTipText = "Valor Unitario"
        Me.ValorUnitarioDataGridViewTextBoxColumn.Width = 28
        '
        'IncrementoDataGridViewTextBoxColumn
        '
        Me.IncrementoDataGridViewTextBoxColumn.DataPropertyName = "Incremento5Porc"
        Me.IncrementoDataGridViewTextBoxColumn.HeaderText = "5% Inc"
        Me.IncrementoDataGridViewTextBoxColumn.Name = "IncrementoDataGridViewTextBoxColumn"
        Me.IncrementoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IncrementoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IncrementoDataGridViewTextBoxColumn.ToolTipText = "5% Incremento a partir del Quinto Piso"
        Me.IncrementoDataGridViewTextBoxColumn.Width = 46
        '
        'ValorDepreciacionDataGridViewTextBoxColumn
        '
        Me.ValorDepreciacionDataGridViewTextBoxColumn.DataPropertyName = "ValorDepreciacion"
        Me.ValorDepreciacionDataGridViewTextBoxColumn.HeaderText = "VD"
        Me.ValorDepreciacionDataGridViewTextBoxColumn.Name = "ValorDepreciacionDataGridViewTextBoxColumn"
        Me.ValorDepreciacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorDepreciacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorDepreciacionDataGridViewTextBoxColumn.ToolTipText = "Depreciación"
        Me.ValorDepreciacionDataGridViewTextBoxColumn.Width = 28
        '
        'ValorUnitarioDepreciadoDataGridViewTextBoxColumn
        '
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitarioDepreciado"
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.HeaderText = "VUD"
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.Name = "ValorUnitarioDepreciadoDataGridViewTextBoxColumn"
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.ToolTipText = "Valor Unitario Depreciado"
        Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.Width = 36
        '
        'AreaDataGridViewTextBoxColumn
        '
        Me.AreaDataGridViewTextBoxColumn.DataPropertyName = "AreaConstruida"
        DataGridViewCellStyle11.Format = "#,###,###,##0.00 m²"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.AreaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.AreaDataGridViewTextBoxColumn.HeaderText = "Area"
        Me.AreaDataGridViewTextBoxColumn.Name = "AreaDataGridViewTextBoxColumn"
        Me.AreaDataGridViewTextBoxColumn.ReadOnly = True
        Me.AreaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AreaDataGridViewTextBoxColumn.ToolTipText = "Area Construida"
        Me.AreaDataGridViewTextBoxColumn.Width = 36
        '
        'AreaConstruidaValorDataGridViewTextBoxColumn
        '
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.DataPropertyName = "AreaConstruidaValor"
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.HeaderText = "VAC"
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.Name = "AreaConstruidaValorDataGridViewTextBoxColumn"
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.ReadOnly = True
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.ToolTipText = "Valor Area Construida"
        Me.AreaConstruidaValorDataGridViewTextBoxColumn.Width = 33
        '
        'PorcConstruccionComunDataGridViewTextBoxColumn
        '
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.DataPropertyName = "AreaConstruidaComunPorcentaje"
        DataGridViewCellStyle12.Format = "N4"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.HeaderText = "% Comun"
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.Name = "PorcConstruccionComunDataGridViewTextBoxColumn"
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.ReadOnly = True
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.ToolTipText = "Porcentaje de area común"
        Me.PorcConstruccionComunDataGridViewTextBoxColumn.Width = 62
        '
        'ValorCinbstruccionComunDataGridViewTextBoxColumn
        '
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.DataPropertyName = "AreaConstruidaComunValor"
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.HeaderText = "VACC"
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.Name = "ValorCinbstruccionComunDataGridViewTextBoxColumn"
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.ToolTipText = "Valor de area construida común"
        Me.ValorCinbstruccionComunDataGridViewTextBoxColumn.Width = 40
        '
        'ValorConstruccionDataGridViewTextBoxColumn
        '
        Me.ValorConstruccionDataGridViewTextBoxColumn.DataPropertyName = "Valor"
        Me.ValorConstruccionDataGridViewTextBoxColumn.HeaderText = "VTC"
        Me.ValorConstruccionDataGridViewTextBoxColumn.Name = "ValorConstruccionDataGridViewTextBoxColumn"
        Me.ValorConstruccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorConstruccionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ValorConstruccionDataGridViewTextBoxColumn.ToolTipText = "Valor total de la construcción"
        Me.ValorConstruccionDataGridViewTextBoxColumn.Width = 31
        '
        'TerrenoAreaExclusivaTextBox
        '
        Me.TerrenoAreaExclusivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoAreaExclusiva", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2"))
        Me.TerrenoAreaExclusivaTextBox.Location = New System.Drawing.Point(93, 21)
        Me.TerrenoAreaExclusivaTextBox.Name = "TerrenoAreaExclusivaTextBox"
        Me.TerrenoAreaExclusivaTextBox.Size = New System.Drawing.Size(80, 22)
        Me.TerrenoAreaExclusivaTextBox.TabIndex = 1
        Me.TerrenoAreaExclusivaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TerrenoAreaComunTextBox
        '
        Me.TerrenoAreaComunTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoAreaComun", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2"))
        Me.TerrenoAreaComunTextBox.Location = New System.Drawing.Point(258, 21)
        Me.TerrenoAreaComunTextBox.Name = "TerrenoAreaComunTextBox"
        Me.TerrenoAreaComunTextBox.Size = New System.Drawing.Size(80, 22)
        Me.TerrenoAreaComunTextBox.TabIndex = 3
        Me.TerrenoAreaComunTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TerrenoAreaTotalTextBox
        '
        Me.TerrenoAreaTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoAreaTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,###,###,###,##0.00 m²"))
        Me.TerrenoAreaTotalTextBox.Location = New System.Drawing.Point(410, 21)
        Me.TerrenoAreaTotalTextBox.Name = "TerrenoAreaTotalTextBox"
        Me.TerrenoAreaTotalTextBox.ReadOnly = True
        Me.TerrenoAreaTotalTextBox.Size = New System.Drawing.Size(80, 22)
        Me.TerrenoAreaTotalTextBox.TabIndex = 5
        Me.TerrenoAreaTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ArancelTextBox
        '
        Me.ArancelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "Arancel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.ArancelTextBox.Location = New System.Drawing.Point(550, 21)
        Me.ArancelTextBox.Name = "ArancelTextBox"
        Me.ArancelTextBox.Size = New System.Drawing.Size(80, 22)
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
        Me.DetPredioGB.Location = New System.Drawing.Point(0, 130)
        Me.DetPredioGB.Name = "DetPredioGB"
        Me.DetPredioGB.Size = New System.Drawing.Size(789, 424)
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
        Me.ConstIfpTabs.Size = New System.Drawing.Size(783, 247)
        Me.ConstIfpTabs.TabIndex = 24
        '
        'ConstruccionesTab
        '
        Me.ConstruccionesTab.Controls.Add(Me.ConstrucciuonesPanel)
        Me.ConstruccionesTab.Controls.Add(Me.DetallesConstruccionGb)
        Me.ConstruccionesTab.Location = New System.Drawing.Point(4, 22)
        Me.ConstruccionesTab.Name = "ConstruccionesTab"
        Me.ConstruccionesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ConstruccionesTab.Size = New System.Drawing.Size(775, 221)
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
        Me.ConstrucciuonesPanel.Size = New System.Drawing.Size(769, 151)
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
        Me.ConstruccionesBindingNavigator.Location = New System.Drawing.Point(0, 126)
        Me.ConstruccionesBindingNavigator.MoveFirstItem = Me.ToolStripButton3
        Me.ConstruccionesBindingNavigator.MoveLastItem = Me.ToolStripButton6
        Me.ConstruccionesBindingNavigator.MoveNextItem = Me.ToolStripButton5
        Me.ConstruccionesBindingNavigator.MovePreviousItem = Me.ToolStripButton4
        Me.ConstruccionesBindingNavigator.Name = "ConstruccionesBindingNavigator"
        Me.ConstruccionesBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.ConstruccionesBindingNavigator.Size = New System.Drawing.Size(769, 25)
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
        Me.DetallesConstruccionGb.Location = New System.Drawing.Point(3, 154)
        Me.DetallesConstruccionGb.Name = "DetallesConstruccionGb"
        Me.DetallesConstruccionGb.Size = New System.Drawing.Size(769, 64)
        Me.DetallesConstruccionGb.TabIndex = 1
        Me.DetallesConstruccionGb.TabStop = False
        Me.DetallesConstruccionGb.Text = "Detalles de la Construccion"
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
        Me.CiesTextBox.Tag = "IES"
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
        Me.CbTextBox.Tag = "B"
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
        Me.CrTextBox.Tag = "R"
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
        Me.CpvTextBox.Tag = "PV"
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
        Me.CpTextBox.Tag = "P"
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
        Me.CtTextBox.Tag = "T"
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
        Me.CmcTextBox.Tag = "MC"
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
        Me.IfpTab.Size = New System.Drawing.Size(775, 223)
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
        Me.TadosTerrenoGb.Location = New System.Drawing.Point(3, 318)
        Me.TadosTerrenoGb.Name = "TadosTerrenoGb"
        Me.TadosTerrenoGb.Size = New System.Drawing.Size(783, 52)
        Me.TadosTerrenoGb.TabIndex = 2
        Me.TadosTerrenoGb.TabStop = False
        Me.TadosTerrenoGb.Text = "Terreno"
        '
        'TerrenoValorTextBox1
        '
        Me.TerrenoValorTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrediosBindingSource, "TerrenoValor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.TerrenoValorTextBox1.Location = New System.Drawing.Point(678, 21)
        Me.TerrenoValorTextBox1.Name = "TerrenoValorTextBox1"
        Me.TerrenoValorTextBox1.ReadOnly = True
        Me.TerrenoValorTextBox1.Size = New System.Drawing.Size(80, 22)
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
        Me.ValorizacionPredioGb.Location = New System.Drawing.Point(3, 370)
        Me.ValorizacionPredioGb.Name = "ValorizacionPredioGb"
        Me.ValorizacionPredioGb.Size = New System.Drawing.Size(783, 51)
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
        Me.DatosPredioGb.Size = New System.Drawing.Size(783, 53)
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
        Me.ClasificacionComboBox.Size = New System.Drawing.Size(373, 21)
        Me.ClasificacionComboBox.TabIndex = 3
        '
        'IfpVusBindingSource
        '
        Me.IfpVusBindingSource.DataMember = "IfpVus"
        Me.IfpVusBindingSource.DataSource = Me.IfpsBindingSource
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MainTs)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1149, 579)
        Me.SplitContainer1.SplitterDistance = 789
        Me.SplitContainer1.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DetPredioGB)
        Me.Panel1.Controls.Add(Me.ResumenGB)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 554)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.labelDCI)
        Me.Panel2.Controls.Add(Me.labelVCI)
        Me.Panel2.Controls.Add(Me.LabelTituloCategoria)
        Me.Panel2.Controls.Add(Me.labelECI)
        Me.Panel2.Controls.Add(Me.labelECA)
        Me.Panel2.Controls.Add(Me.labelVCG)
        Me.Panel2.Controls.Add(Me.labelVCA)
        Me.Panel2.Controls.Add(Me.labelVCH)
        Me.Panel2.Controls.Add(Me.labelDCA)
        Me.Panel2.Controls.Add(Me.labelVCE)
        Me.Panel2.Controls.Add(Me.labelECB)
        Me.Panel2.Controls.Add(Me.labelVCF)
        Me.Panel2.Controls.Add(Me.labelDCB)
        Me.Panel2.Controls.Add(Me.labelVCD)
        Me.Panel2.Controls.Add(Me.labelVCC)
        Me.Panel2.Controls.Add(Me.labelECG)
        Me.Panel2.Controls.Add(Me.labelDCC)
        Me.Panel2.Controls.Add(Me.labelECH)
        Me.Panel2.Controls.Add(Me.labelECC)
        Me.Panel2.Controls.Add(Me.labelECF)
        Me.Panel2.Controls.Add(Me.labelVCB)
        Me.Panel2.Controls.Add(Me.labelECE)
        Me.Panel2.Controls.Add(Me.labelECD)
        Me.Panel2.Controls.Add(Me.labelDCD)
        Me.Panel2.Controls.Add(Me.LabelDCH)
        Me.Panel2.Controls.Add(Me.labelDCE)
        Me.Panel2.Controls.Add(Me.labelDCG)
        Me.Panel2.Controls.Add(Me.labelDCF)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(336, 559)
        Me.Panel2.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(2, 492)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(332, 2)
        Me.Label9.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(2, 434)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(332, 2)
        Me.Label8.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(2, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(332, 2)
        Me.Label7.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(2, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(332, 2)
        Me.Label6.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(2, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(332, 2)
        Me.Label5.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(2, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(332, 2)
        Me.Label4.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(2, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(332, 2)
        Me.Label3.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(2, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 2)
        Me.Label2.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(4, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 2)
        Me.Label1.TabIndex = 27
        '
        'labelDCI
        '
        Me.labelDCI.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.labelDCI.Location = New System.Drawing.Point(68, 494)
        Me.labelDCI.Margin = New System.Windows.Forms.Padding(0)
        Me.labelDCI.Name = "labelDCI"
        Me.labelDCI.Size = New System.Drawing.Size(268, 58)
        Me.labelDCI.TabIndex = 26
        Me.labelDCI.Text = "AIRE ACONDICIONADO, ILUMINACIÓN ESPECIAL, VENTILACIÓN FORZADA, SIST. HIDRONEUMÁTI" &
    "CO, AGUA CALIENTE Y FRÍA, INTERCOMUNICADOR, ALARMAS, ASCENSOR, SISTEMA BOMBEO DE" &
    " AGUA Y DESAGÜE.(5) TELÉFONO."
        Me.labelDCI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelVCI
        '
        Me.labelVCI.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVCI.ForeColor = System.Drawing.Color.Red
        Me.labelVCI.Location = New System.Drawing.Point(0, 523)
        Me.labelVCI.Margin = New System.Windows.Forms.Padding(0)
        Me.labelVCI.Name = "labelVCI"
        Me.labelVCI.Size = New System.Drawing.Size(62, 29)
        Me.labelVCI.TabIndex = 25
        Me.labelVCI.Text = "0.00"
        Me.labelVCI.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelTituloCategoria
        '
        Me.LabelTituloCategoria.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTituloCategoria.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LabelTituloCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelTituloCategoria.Location = New System.Drawing.Point(0, 0)
        Me.LabelTituloCategoria.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTituloCategoria.Name = "LabelTituloCategoria"
        Me.LabelTituloCategoria.Size = New System.Drawing.Size(336, 28)
        Me.LabelTituloCategoria.TabIndex = 0
        Me.LabelTituloCategoria.Text = "MUROS Y COLUMNAS"
        Me.LabelTituloCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelECI
        '
        Me.labelECI.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.labelECI.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelECI.Location = New System.Drawing.Point(0, 494)
        Me.labelECI.Margin = New System.Windows.Forms.Padding(0)
        Me.labelECI.Name = "labelECI"
        Me.labelECI.Size = New System.Drawing.Size(62, 29)
        Me.labelECI.TabIndex = 24
        Me.labelECI.Text = "I"
        Me.labelECI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'labelECA
        '
        Me.labelECA.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.labelECA.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelECA.Location = New System.Drawing.Point(0, 30)
        Me.labelECA.Margin = New System.Windows.Forms.Padding(0)
        Me.labelECA.Name = "labelECA"
        Me.labelECA.Size = New System.Drawing.Size(62, 29)
        Me.labelECA.TabIndex = 0
        Me.labelECA.Text = "A"
        Me.labelECA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'labelVCG
        '
        Me.labelVCG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVCG.ForeColor = System.Drawing.Color.Red
        Me.labelVCG.Location = New System.Drawing.Point(0, 407)
        Me.labelVCG.Margin = New System.Windows.Forms.Padding(0)
        Me.labelVCG.Name = "labelVCG"
        Me.labelVCG.Size = New System.Drawing.Size(62, 29)
        Me.labelVCG.TabIndex = 23
        Me.labelVCG.Text = "0.00"
        Me.labelVCG.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labelVCA
        '
        Me.labelVCA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVCA.ForeColor = System.Drawing.Color.Red
        Me.labelVCA.Location = New System.Drawing.Point(0, 59)
        Me.labelVCA.Margin = New System.Windows.Forms.Padding(0)
        Me.labelVCA.Name = "labelVCA"
        Me.labelVCA.Size = New System.Drawing.Size(62, 29)
        Me.labelVCA.TabIndex = 2
        Me.labelVCA.Text = "0.00"
        Me.labelVCA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labelVCH
        '
        Me.labelVCH.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVCH.ForeColor = System.Drawing.Color.Red
        Me.labelVCH.Location = New System.Drawing.Point(0, 465)
        Me.labelVCH.Margin = New System.Windows.Forms.Padding(0)
        Me.labelVCH.Name = "labelVCH"
        Me.labelVCH.Size = New System.Drawing.Size(62, 29)
        Me.labelVCH.TabIndex = 22
        Me.labelVCH.Text = "0.00"
        Me.labelVCH.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labelDCA
        '
        Me.labelDCA.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.labelDCA.Location = New System.Drawing.Point(68, 30)
        Me.labelDCA.Margin = New System.Windows.Forms.Padding(0)
        Me.labelDCA.Name = "labelDCA"
        Me.labelDCA.Size = New System.Drawing.Size(268, 58)
        Me.labelDCA.TabIndex = 1
        Me.labelDCA.Text = "AIRE ACONDICIONADO, ILUMINACIÓN ESPECIAL, VENTILACIÓN FORZADA, SIST. HIDRONEUMÁTI" &
    "CO, AGUA CALIENTE Y FRÍA, INTERCOMUNICADOR, ALARMAS, ASCENSOR, SISTEMA BOMBEO DE" &
    " AGUA Y DESAGÜE.(5) TELÉFONO."
        Me.labelDCA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelVCE
        '
        Me.labelVCE.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVCE.ForeColor = System.Drawing.Color.Red
        Me.labelVCE.Location = New System.Drawing.Point(0, 291)
        Me.labelVCE.Margin = New System.Windows.Forms.Padding(0)
        Me.labelVCE.Name = "labelVCE"
        Me.labelVCE.Size = New System.Drawing.Size(62, 29)
        Me.labelVCE.TabIndex = 21
        Me.labelVCE.Text = "0.00"
        Me.labelVCE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labelECB
        '
        Me.labelECB.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.labelECB.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelECB.Location = New System.Drawing.Point(0, 88)
        Me.labelECB.Margin = New System.Windows.Forms.Padding(0)
        Me.labelECB.Name = "labelECB"
        Me.labelECB.Size = New System.Drawing.Size(62, 29)
        Me.labelECB.TabIndex = 12
        Me.labelECB.Text = "B"
        Me.labelECB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'labelVCF
        '
        Me.labelVCF.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVCF.ForeColor = System.Drawing.Color.Red
        Me.labelVCF.Location = New System.Drawing.Point(0, 349)
        Me.labelVCF.Margin = New System.Windows.Forms.Padding(0)
        Me.labelVCF.Name = "labelVCF"
        Me.labelVCF.Size = New System.Drawing.Size(62, 29)
        Me.labelVCF.TabIndex = 20
        Me.labelVCF.Text = "0.00"
        Me.labelVCF.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labelDCB
        '
        Me.labelDCB.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.labelDCB.Location = New System.Drawing.Point(68, 88)
        Me.labelDCB.Margin = New System.Windows.Forms.Padding(0)
        Me.labelDCB.Name = "labelDCB"
        Me.labelDCB.Size = New System.Drawing.Size(268, 58)
        Me.labelDCB.TabIndex = 3
        Me.labelDCB.Text = "AIRE ACONDICIONADO, ILUMINACIÓN ESPECIAL, VENTILACIÓN FORZADA, SIST. HIDRONEUMÁTI" &
    "CO, AGUA CALIENTE Y FRÍA, INTERCOMUNICADOR, ALARMAS, ASCENSOR, SISTEMA BOMBEO DE" &
    " AGUA Y DESAGÜE.(5) TELÉFONO."
        Me.labelDCB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelVCD
        '
        Me.labelVCD.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVCD.ForeColor = System.Drawing.Color.Red
        Me.labelVCD.Location = New System.Drawing.Point(0, 233)
        Me.labelVCD.Margin = New System.Windows.Forms.Padding(0)
        Me.labelVCD.Name = "labelVCD"
        Me.labelVCD.Size = New System.Drawing.Size(62, 29)
        Me.labelVCD.TabIndex = 18
        Me.labelVCD.Text = "0.00"
        Me.labelVCD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labelVCC
        '
        Me.labelVCC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVCC.ForeColor = System.Drawing.Color.Red
        Me.labelVCC.Location = New System.Drawing.Point(0, 175)
        Me.labelVCC.Margin = New System.Windows.Forms.Padding(0)
        Me.labelVCC.Name = "labelVCC"
        Me.labelVCC.Size = New System.Drawing.Size(62, 29)
        Me.labelVCC.TabIndex = 19
        Me.labelVCC.Text = "0.00"
        Me.labelVCC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labelECG
        '
        Me.labelECG.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.labelECG.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelECG.Location = New System.Drawing.Point(0, 378)
        Me.labelECG.Margin = New System.Windows.Forms.Padding(0)
        Me.labelECG.Name = "labelECG"
        Me.labelECG.Size = New System.Drawing.Size(62, 29)
        Me.labelECG.TabIndex = 17
        Me.labelECG.Text = "G"
        Me.labelECG.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'labelDCC
        '
        Me.labelDCC.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.labelDCC.Location = New System.Drawing.Point(68, 146)
        Me.labelDCC.Margin = New System.Windows.Forms.Padding(0)
        Me.labelDCC.Name = "labelDCC"
        Me.labelDCC.Size = New System.Drawing.Size(268, 58)
        Me.labelDCC.TabIndex = 4
        Me.labelDCC.Text = "AIRE ACONDICIONADO, ILUMINACIÓN ESPECIAL, VENTILACIÓN FORZADA, SIST. HIDRONEUMÁTI" &
    "CO, AGUA CALIENTE Y FRÍA, INTERCOMUNICADOR, ALARMAS, ASCENSOR, SISTEMA BOMBEO DE" &
    " AGUA Y DESAGÜE.(5) TELÉFONO."
        Me.labelDCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelECH
        '
        Me.labelECH.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.labelECH.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelECH.Location = New System.Drawing.Point(0, 436)
        Me.labelECH.Margin = New System.Windows.Forms.Padding(0)
        Me.labelECH.Name = "labelECH"
        Me.labelECH.Size = New System.Drawing.Size(62, 29)
        Me.labelECH.TabIndex = 16
        Me.labelECH.Text = "H"
        Me.labelECH.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'labelECC
        '
        Me.labelECC.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.labelECC.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelECC.Location = New System.Drawing.Point(0, 146)
        Me.labelECC.Margin = New System.Windows.Forms.Padding(0)
        Me.labelECC.Name = "labelECC"
        Me.labelECC.Size = New System.Drawing.Size(62, 29)
        Me.labelECC.TabIndex = 10
        Me.labelECC.Text = "C"
        Me.labelECC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'labelECF
        '
        Me.labelECF.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.labelECF.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelECF.Location = New System.Drawing.Point(0, 320)
        Me.labelECF.Margin = New System.Windows.Forms.Padding(0)
        Me.labelECF.Name = "labelECF"
        Me.labelECF.Size = New System.Drawing.Size(62, 29)
        Me.labelECF.TabIndex = 15
        Me.labelECF.Text = "F"
        Me.labelECF.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'labelVCB
        '
        Me.labelVCB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVCB.ForeColor = System.Drawing.Color.Red
        Me.labelVCB.Location = New System.Drawing.Point(0, 117)
        Me.labelVCB.Margin = New System.Windows.Forms.Padding(0)
        Me.labelVCB.Name = "labelVCB"
        Me.labelVCB.Size = New System.Drawing.Size(62, 29)
        Me.labelVCB.TabIndex = 11
        Me.labelVCB.Text = "0.00"
        Me.labelVCB.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labelECE
        '
        Me.labelECE.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.labelECE.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelECE.Location = New System.Drawing.Point(0, 262)
        Me.labelECE.Margin = New System.Windows.Forms.Padding(0)
        Me.labelECE.Name = "labelECE"
        Me.labelECE.Size = New System.Drawing.Size(62, 29)
        Me.labelECE.TabIndex = 14
        Me.labelECE.Text = "E"
        Me.labelECE.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'labelECD
        '
        Me.labelECD.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.labelECD.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelECD.Location = New System.Drawing.Point(0, 204)
        Me.labelECD.Margin = New System.Windows.Forms.Padding(0)
        Me.labelECD.Name = "labelECD"
        Me.labelECD.Size = New System.Drawing.Size(62, 29)
        Me.labelECD.TabIndex = 13
        Me.labelECD.Text = "D"
        Me.labelECD.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'labelDCD
        '
        Me.labelDCD.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.labelDCD.Location = New System.Drawing.Point(68, 204)
        Me.labelDCD.Margin = New System.Windows.Forms.Padding(0)
        Me.labelDCD.Name = "labelDCD"
        Me.labelDCD.Size = New System.Drawing.Size(268, 58)
        Me.labelDCD.TabIndex = 5
        Me.labelDCD.Text = "AIRE ACONDICIONADO, ILUMINACIÓN ESPECIAL, VENTILACIÓN FORZADA, SIST. HIDRONEUMÁTI" &
    "CO, AGUA CALIENTE Y FRÍA, INTERCOMUNICADOR, ALARMAS, ASCENSOR, SISTEMA BOMBEO DE" &
    " AGUA Y DESAGÜE.(5) TELÉFONO."
        Me.labelDCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDCH
        '
        Me.LabelDCH.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LabelDCH.Location = New System.Drawing.Point(68, 436)
        Me.LabelDCH.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelDCH.Name = "LabelDCH"
        Me.LabelDCH.Size = New System.Drawing.Size(268, 58)
        Me.LabelDCH.TabIndex = 9
        Me.LabelDCH.Text = "AIRE ACONDICIONADO, ILUMINACIÓN ESPECIAL, VENTILACIÓN FORZADA, SIST. HIDRONEUMÁTI" &
    "CO, AGUA CALIENTE Y FRÍA, INTERCOMUNICADOR, ALARMAS, ASCENSOR, SISTEMA BOMBEO DE" &
    " AGUA Y DESAGÜE.(5) TELÉFONO."
        Me.LabelDCH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelDCE
        '
        Me.labelDCE.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.labelDCE.Location = New System.Drawing.Point(68, 262)
        Me.labelDCE.Margin = New System.Windows.Forms.Padding(0)
        Me.labelDCE.Name = "labelDCE"
        Me.labelDCE.Size = New System.Drawing.Size(268, 58)
        Me.labelDCE.TabIndex = 6
        Me.labelDCE.Text = "AIRE ACONDICIONADO, ILUMINACIÓN ESPECIAL, VENTILACIÓN FORZADA, SIST. HIDRONEUMÁTI" &
    "CO, AGUA CALIENTE Y FRÍA, INTERCOMUNICADOR, ALARMAS, ASCENSOR, SISTEMA BOMBEO DE" &
    " AGUA Y DESAGÜE.(5) TELÉFONO."
        Me.labelDCE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelDCG
        '
        Me.labelDCG.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.labelDCG.Location = New System.Drawing.Point(68, 378)
        Me.labelDCG.Margin = New System.Windows.Forms.Padding(0)
        Me.labelDCG.Name = "labelDCG"
        Me.labelDCG.Size = New System.Drawing.Size(268, 58)
        Me.labelDCG.TabIndex = 8
        Me.labelDCG.Text = "AIRE ACONDICIONADO, ILUMINACIÓN ESPECIAL, VENTILACIÓN FORZADA, SIST. HIDRONEUMÁTI" &
    "CO, AGUA CALIENTE Y FRÍA, INTERCOMUNICADOR, ALARMAS, ASCENSOR, SISTEMA BOMBEO DE" &
    " AGUA Y DESAGÜE.(5) TELÉFONO."
        Me.labelDCG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelDCF
        '
        Me.labelDCF.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.labelDCF.Location = New System.Drawing.Point(68, 320)
        Me.labelDCF.Margin = New System.Windows.Forms.Padding(0)
        Me.labelDCF.Name = "labelDCF"
        Me.labelDCF.Size = New System.Drawing.Size(268, 58)
        Me.labelDCF.TabIndex = 7
        Me.labelDCF.Text = "AIRE ACONDICIONADO, ILUMINACIÓN ESPECIAL, VENTILACIÓN FORZADA, SIST. HIDRONEUMÁTI" &
    "CO, AGUA CALIENTE Y FRÍA, INTERCOMUNICADOR, ALARMAS, ASCENSOR, SISTEMA BOMBEO DE" &
    " AGUA Y DESAGÜE.(5) TELÉFONO."
        Me.labelDCF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SimulatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1159, 589)
        Me.Controls.Add(Me.SplitContainer1)
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
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SinDetalleCheckBox As CheckBox
    Friend WithEvents labelECA As Label
    Friend WithEvents labelVCA As Label
    Friend WithEvents LabelTituloCategoria As Label
    Friend WithEvents labelDCI As Label
    Friend WithEvents labelVCI As Label
    Friend WithEvents labelECI As Label
    Friend WithEvents labelVCG As Label
    Friend WithEvents labelVCH As Label
    Friend WithEvents labelVCE As Label
    Friend WithEvents labelVCF As Label
    Friend WithEvents labelVCC As Label
    Friend WithEvents labelVCD As Label
    Friend WithEvents labelECG As Label
    Friend WithEvents labelECH As Label
    Friend WithEvents labelECF As Label
    Friend WithEvents labelECE As Label
    Friend WithEvents labelECD As Label
    Friend WithEvents labelECB As Label
    Friend WithEvents labelVCB As Label
    Friend WithEvents labelECC As Label
    Friend WithEvents LabelDCH As Label
    Friend WithEvents labelDCG As Label
    Friend WithEvents labelDCF As Label
    Friend WithEvents labelDCE As Label
    Friend WithEvents labelDCD As Label
    Friend WithEvents labelDCC As Label
    Friend WithEvents labelDCB As Label
    Friend WithEvents labelDCA As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
