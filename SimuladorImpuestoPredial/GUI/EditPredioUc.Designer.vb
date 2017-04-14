Imports MetroFramework.Controls

Namespace GUI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class EditPredioUc
        Inherits MetroFramework.Controls.MetroUserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim ClasificacionPredioLabel As MetroFramework.Controls.MetroLabel
            Dim AutoavaluoLabel As System.Windows.Forms.Label
            Dim CodigoPredioLabel As System.Windows.Forms.Label
            Dim CondPropLabel As System.Windows.Forms.Label
            Dim DeduccionLabel As System.Windows.Forms.Label
            Dim EstadoConstruccionLabel As System.Windows.Forms.Label
            Dim NumCopropLabel As System.Windows.Forms.Label
            Dim PorcPropLabel As System.Windows.Forms.Label
            Dim TipoLabel As System.Windows.Forms.Label
            Dim TipoPredioLabel As System.Windows.Forms.Label
            Dim ValorAutoavaluoLabel As System.Windows.Forms.Label
            Dim ValorPorcPropiedadLabel As System.Windows.Forms.Label
            Dim ValorTotalAreaConstruidaPropiaLabel As System.Windows.Forms.Label
            Dim ValorTotalOtrasInstalacionesLabel As System.Windows.Forms.Label
            Dim ValorTotalTerrenoLabel As System.Windows.Forms.Label
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
            Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
            Me.HojaResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
            Me.ImpuestoAnualMetroLabel = New MetroFramework.Controls.MetroLabel()
            Me.MlImpuestoTrimestralL = New MetroFramework.Controls.MetroLabel()
            Me.MlImpuestoTrimestral = New MetroFramework.Controls.MetroLabel()
            Me.AnexoMetroLabel = New MetroFramework.Controls.MetroLabel()
            Me.PredioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
            Me.ClasificacionPredioMetroComboBox = New MetroFramework.Controls.MetroComboBox()
            Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
            Me.UsoGrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
            Me.SubGruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.MetroComboBox3 = New MetroFramework.Controls.MetroComboBox()
            Me.UsosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
            Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
            Me.AutoavaluoTextBox = New System.Windows.Forms.TextBox()
            Me.CodigoPredioTextBox = New System.Windows.Forms.TextBox()
            Me.CondPropMetroComboBox = New MetroFramework.Controls.MetroComboBox()
            Me.ConstruccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ConstruccionesDataGridView = New MetroFramework.Controls.MetroGrid()
            Me.StrPisoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MesAñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.EcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CategoriasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Inc5PorcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PorcDepreciacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.AreaConstruidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorAreaConstruidaComunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PorcPartPredioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ContratantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.DeduccionTextBox = New System.Windows.Forms.TextBox()
            Me.EstadoConstruccionMetroComboBox = New MetroFramework.Controls.MetroComboBox()
            Me.NumCopropNumericUpDown = New System.Windows.Forms.NumericUpDown()
            Me.OtrasInstalacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.OtrasInstalacionesDataGridView = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PorcPropTextBox = New System.Windows.Forms.TextBox()
            Me.TipoMetroLabel = New MetroFramework.Controls.MetroLabel()
            Me.TipoPredioMetroComboBox = New MetroFramework.Controls.MetroComboBox()
            Me.ValorAutoavaluoTextBox = New System.Windows.Forms.TextBox()
            Me.ValorPorcPropiedadTextBox = New System.Windows.Forms.TextBox()
            Me.ValorTotalAreaConstruidaPropiaTextBox = New System.Windows.Forms.TextBox()
            Me.ValorTotalOtrasInstalacionesTextBox = New System.Windows.Forms.TextBox()
            Me.ValorTotalTerrenoTextBox = New System.Windows.Forms.TextBox()
            Me.DireccionUc1 = New SimuImpPred.Gui.GUI.DireccionUc()
            ClasificacionPredioLabel = New MetroFramework.Controls.MetroLabel()
            AutoavaluoLabel = New System.Windows.Forms.Label()
            CodigoPredioLabel = New System.Windows.Forms.Label()
            CondPropLabel = New System.Windows.Forms.Label()
            DeduccionLabel = New System.Windows.Forms.Label()
            EstadoConstruccionLabel = New System.Windows.Forms.Label()
            NumCopropLabel = New System.Windows.Forms.Label()
            PorcPropLabel = New System.Windows.Forms.Label()
            TipoLabel = New System.Windows.Forms.Label()
            TipoPredioLabel = New System.Windows.Forms.Label()
            ValorAutoavaluoLabel = New System.Windows.Forms.Label()
            ValorPorcPropiedadLabel = New System.Windows.Forms.Label()
            ValorTotalAreaConstruidaPropiaLabel = New System.Windows.Forms.Label()
            ValorTotalOtrasInstalacionesLabel = New System.Windows.Forms.Label()
            ValorTotalTerrenoLabel = New System.Windows.Forms.Label()
            Me.FlowLayoutPanel1.SuspendLayout()
            CType(Me.HojaResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PredioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MetroTile1.SuspendLayout()
            CType(Me.UsoGrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SubGruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UsosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MetroTabControl1.SuspendLayout()
            Me.MetroTabPage1.SuspendLayout()
            CType(Me.ConstruccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ConstruccionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ContratantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NumCopropNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OtrasInstalacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OtrasInstalacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ClasificacionPredioLabel
            '
            ClasificacionPredioLabel.AutoSize = True
            ClasificacionPredioLabel.Location = New System.Drawing.Point(100, 39)
            ClasificacionPredioLabel.Name = "ClasificacionPredioLabel"
            ClasificacionPredioLabel.Size = New System.Drawing.Size(126, 19)
            ClasificacionPredioLabel.TabIndex = 3
            ClasificacionPredioLabel.Text = "Clasificacion Predio:"
            '
            'AutoavaluoLabel
            '
            AutoavaluoLabel.AutoSize = True
            AutoavaluoLabel.Location = New System.Drawing.Point(273, 221)
            AutoavaluoLabel.Name = "AutoavaluoLabel"
            AutoavaluoLabel.Size = New System.Drawing.Size(64, 13)
            AutoavaluoLabel.TabIndex = 10
            AutoavaluoLabel.Text = "Autoavaluo:"
            '
            'CodigoPredioLabel
            '
            CodigoPredioLabel.AutoSize = True
            CodigoPredioLabel.Location = New System.Drawing.Point(261, 247)
            CodigoPredioLabel.Name = "CodigoPredioLabel"
            CodigoPredioLabel.Size = New System.Drawing.Size(76, 13)
            CodigoPredioLabel.TabIndex = 11
            CodigoPredioLabel.Text = "Codigo Predio:"
            '
            'CondPropLabel
            '
            CondPropLabel.AutoSize = True
            CondPropLabel.Location = New System.Drawing.Point(277, 273)
            CondPropLabel.Name = "CondPropLabel"
            CondPropLabel.Size = New System.Drawing.Size(60, 13)
            CondPropLabel.TabIndex = 12
            CondPropLabel.Text = "Cond Prop:"
            '
            'DeduccionLabel
            '
            DeduccionLabel.AutoSize = True
            DeduccionLabel.Location = New System.Drawing.Point(275, 308)
            DeduccionLabel.Name = "DeduccionLabel"
            DeduccionLabel.Size = New System.Drawing.Size(62, 13)
            DeduccionLabel.TabIndex = 13
            DeduccionLabel.Text = "Deduccion:"
            '
            'EstadoConstruccionLabel
            '
            EstadoConstruccionLabel.AutoSize = True
            EstadoConstruccionLabel.Location = New System.Drawing.Point(229, 334)
            EstadoConstruccionLabel.Name = "EstadoConstruccionLabel"
            EstadoConstruccionLabel.Size = New System.Drawing.Size(108, 13)
            EstadoConstruccionLabel.TabIndex = 15
            EstadoConstruccionLabel.Text = "Estado Construccion:"
            '
            'NumCopropLabel
            '
            NumCopropLabel.AutoSize = True
            NumCopropLabel.Location = New System.Drawing.Point(100, 146)
            NumCopropLabel.Name = "NumCopropLabel"
            NumCopropLabel.Size = New System.Drawing.Size(69, 13)
            NumCopropLabel.TabIndex = 19
            NumCopropLabel.Text = "Num Coprop:"
            '
            'PorcPropLabel
            '
            PorcPropLabel.AutoSize = True
            PorcPropLabel.Location = New System.Drawing.Point(154, 185)
            PorcPropLabel.Name = "PorcPropLabel"
            PorcPropLabel.Size = New System.Drawing.Size(57, 13)
            PorcPropLabel.TabIndex = 22
            PorcPropLabel.Text = "Porc Prop:"
            '
            'TipoLabel
            '
            TipoLabel.AutoSize = True
            TipoLabel.Location = New System.Drawing.Point(898, 11)
            TipoLabel.Name = "TipoLabel"
            TipoLabel.Size = New System.Drawing.Size(31, 13)
            TipoLabel.TabIndex = 24
            TipoLabel.Text = "Tipo:"
            '
            'TipoPredioLabel
            '
            TipoPredioLabel.AutoSize = True
            TipoPredioLabel.Location = New System.Drawing.Point(68, 300)
            TipoPredioLabel.Name = "TipoPredioLabel"
            TipoPredioLabel.Size = New System.Drawing.Size(64, 13)
            TipoPredioLabel.TabIndex = 28
            TipoPredioLabel.Text = "Tipo Predio:"
            '
            'ValorAutoavaluoLabel
            '
            ValorAutoavaluoLabel.AutoSize = True
            ValorAutoavaluoLabel.Location = New System.Drawing.Point(52, 435)
            ValorAutoavaluoLabel.Name = "ValorAutoavaluoLabel"
            ValorAutoavaluoLabel.Size = New System.Drawing.Size(91, 13)
            ValorAutoavaluoLabel.TabIndex = 30
            ValorAutoavaluoLabel.Text = "Valor Autoavaluo:"
            '
            'ValorPorcPropiedadLabel
            '
            ValorPorcPropiedadLabel.AutoSize = True
            ValorPorcPropiedadLabel.Location = New System.Drawing.Point(33, 461)
            ValorPorcPropiedadLabel.Name = "ValorPorcPropiedadLabel"
            ValorPorcPropiedadLabel.Size = New System.Drawing.Size(110, 13)
            ValorPorcPropiedadLabel.TabIndex = 32
            ValorPorcPropiedadLabel.Text = "Valor Porc Propiedad:"
            '
            'ValorTotalAreaConstruidaPropiaLabel
            '
            ValorTotalAreaConstruidaPropiaLabel.AutoSize = True
            ValorTotalAreaConstruidaPropiaLabel.Location = New System.Drawing.Point(271, 427)
            ValorTotalAreaConstruidaPropiaLabel.Name = "ValorTotalAreaConstruidaPropiaLabel"
            ValorTotalAreaConstruidaPropiaLabel.Size = New System.Drawing.Size(172, 13)
            ValorTotalAreaConstruidaPropiaLabel.TabIndex = 34
            ValorTotalAreaConstruidaPropiaLabel.Text = "Valor Total Area Construida Propia:"
            '
            'ValorTotalOtrasInstalacionesLabel
            '
            ValorTotalOtrasInstalacionesLabel.AutoSize = True
            ValorTotalOtrasInstalacionesLabel.Location = New System.Drawing.Point(289, 452)
            ValorTotalOtrasInstalacionesLabel.Name = "ValorTotalOtrasInstalacionesLabel"
            ValorTotalOtrasInstalacionesLabel.Size = New System.Drawing.Size(154, 13)
            ValorTotalOtrasInstalacionesLabel.TabIndex = 36
            ValorTotalOtrasInstalacionesLabel.Text = "Valor Total Otras Instalaciones:"
            '
            'ValorTotalTerrenoLabel
            '
            ValorTotalTerrenoLabel.AutoSize = True
            ValorTotalTerrenoLabel.Location = New System.Drawing.Point(342, 478)
            ValorTotalTerrenoLabel.Name = "ValorTotalTerrenoLabel"
            ValorTotalTerrenoLabel.Size = New System.Drawing.Size(101, 13)
            ValorTotalTerrenoLabel.TabIndex = 38
            ValorTotalTerrenoLabel.Text = "Valor Total Terreno:"
            '
            'MetroPanel1
            '
            Me.MetroPanel1.AutoSize = True
            Me.MetroPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.MetroPanel1.HorizontalScrollbarBarColor = True
            Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
            Me.MetroPanel1.HorizontalScrollbarSize = 10
            Me.MetroPanel1.Location = New System.Drawing.Point(0, 612)
            Me.MetroPanel1.Name = "MetroPanel1"
            Me.MetroPanel1.Size = New System.Drawing.Size(1154, 0)
            Me.MetroPanel1.TabIndex = 0
            Me.MetroPanel1.VerticalScrollbarBarColor = True
            Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
            Me.MetroPanel1.VerticalScrollbarSize = 10
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.AutoSize = True
            Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            Me.FlowLayoutPanel1.Controls.Add(Me.MetroLabel4)
            Me.FlowLayoutPanel1.Controls.Add(Me.MetroLabel5)
            Me.FlowLayoutPanel1.Controls.Add(Me.MetroLabel1)
            Me.FlowLayoutPanel1.Controls.Add(Me.ImpuestoAnualMetroLabel)
            Me.FlowLayoutPanel1.Controls.Add(Me.MlImpuestoTrimestralL)
            Me.FlowLayoutPanel1.Controls.Add(Me.MlImpuestoTrimestral)
            Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 571)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(8)
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1154, 41)
            Me.FlowLayoutPanel1.TabIndex = 2
            '
            'MetroLabel4
            '
            Me.MetroLabel4.AutoSize = True
            Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
            Me.MetroLabel4.ForeColor = System.Drawing.Color.White
            Me.MetroLabel4.Location = New System.Drawing.Point(11, 8)
            Me.MetroLabel4.Name = "MetroLabel4"
            Me.MetroLabel4.Size = New System.Drawing.Size(170, 25)
            Me.MetroLabel4.TabIndex = 12
            Me.MetroLabel4.Text = "Numero de Predios:"
            Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'MetroLabel5
            '
            Me.MetroLabel5.AutoSize = True
            Me.MetroLabel5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "NumPredios", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
            Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MetroLabel5.Location = New System.Drawing.Point(187, 8)
            Me.MetroLabel5.Name = "MetroLabel5"
            Me.MetroLabel5.Size = New System.Drawing.Size(39, 25)
            Me.MetroLabel5.TabIndex = 13
            Me.MetroLabel5.Text = "999"
            '
            'HojaResumenBindingSource
            '
            Me.HojaResumenBindingSource.DataSource = GetType(SimuImpPred.ObjectModel.HojaResumen)
            '
            'MetroLabel1
            '
            Me.MetroLabel1.AutoSize = True
            Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
            Me.MetroLabel1.ForeColor = System.Drawing.Color.White
            Me.MetroLabel1.Location = New System.Drawing.Point(232, 8)
            Me.MetroLabel1.Name = "MetroLabel1"
            Me.MetroLabel1.Size = New System.Drawing.Size(142, 25)
            Me.MetroLabel1.TabIndex = 9
            Me.MetroLabel1.Text = "Impuesto Anual:"
            Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'ImpuestoAnualMetroLabel
            '
            Me.ImpuestoAnualMetroLabel.AutoSize = True
            Me.ImpuestoAnualMetroLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "ImpuestoAnual", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
            Me.ImpuestoAnualMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.ImpuestoAnualMetroLabel.Location = New System.Drawing.Point(380, 8)
            Me.ImpuestoAnualMetroLabel.Name = "ImpuestoAnualMetroLabel"
            Me.ImpuestoAnualMetroLabel.Size = New System.Drawing.Size(126, 25)
            Me.ImpuestoAnualMetroLabel.TabIndex = 8
            Me.ImpuestoAnualMetroLabel.Text = "S/ 9,999,999.99"
            '
            'MlImpuestoTrimestralL
            '
            Me.MlImpuestoTrimestralL.AutoSize = True
            Me.MlImpuestoTrimestralL.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MlImpuestoTrimestralL.FontWeight = MetroFramework.MetroLabelWeight.Regular
            Me.MlImpuestoTrimestralL.ForeColor = System.Drawing.Color.White
            Me.MlImpuestoTrimestralL.Location = New System.Drawing.Point(512, 8)
            Me.MlImpuestoTrimestralL.Name = "MlImpuestoTrimestralL"
            Me.MlImpuestoTrimestralL.Size = New System.Drawing.Size(143, 25)
            Me.MlImpuestoTrimestralL.TabIndex = 11
            Me.MlImpuestoTrimestralL.Text = "Cuota Trimestral:"
            Me.MlImpuestoTrimestralL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'MlImpuestoTrimestral
            '
            Me.MlImpuestoTrimestral.AutoSize = True
            Me.MlImpuestoTrimestral.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "CuotaTrimestral", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
            Me.MlImpuestoTrimestral.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MlImpuestoTrimestral.Location = New System.Drawing.Point(661, 8)
            Me.MlImpuestoTrimestral.Name = "MlImpuestoTrimestral"
            Me.MlImpuestoTrimestral.Size = New System.Drawing.Size(126, 25)
            Me.MlImpuestoTrimestral.TabIndex = 10
            Me.MlImpuestoTrimestral.Text = "S/ 9,999,999.99"
            '
            'AnexoMetroLabel
            '
            Me.AnexoMetroLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "Anexo", True))
            Me.AnexoMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.AnexoMetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
            Me.AnexoMetroLabel.Location = New System.Drawing.Point(9, 9)
            Me.AnexoMetroLabel.Name = "AnexoMetroLabel"
            Me.AnexoMetroLabel.Size = New System.Drawing.Size(42, 22)
            Me.AnexoMetroLabel.TabIndex = 2
            Me.AnexoMetroLabel.Text = "999"
            Me.AnexoMetroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'PredioBindingSource
            '
            Me.PredioBindingSource.DataSource = GetType(SimuImpPred.ObjectModel.Predio)
            '
            'MetroTile1
            '
            Me.MetroTile1.ActiveControl = Nothing
            Me.MetroTile1.Controls.Add(Me.AnexoMetroLabel)
            Me.MetroTile1.Location = New System.Drawing.Point(3, 3)
            Me.MetroTile1.Name = "MetroTile1"
            Me.MetroTile1.Size = New System.Drawing.Size(62, 62)
            Me.MetroTile1.TabIndex = 3
            Me.MetroTile1.Text = "ANEXO"
            Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
            Me.MetroTile1.UseSelectable = True
            '
            'ClasificacionPredioMetroComboBox
            '
            Me.ClasificacionPredioMetroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PredioBindingSource, "ClasificacionPredio", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ClasificacionPredioMetroComboBox.FormattingEnabled = True
            Me.ClasificacionPredioMetroComboBox.ItemHeight = 23
            Me.ClasificacionPredioMetroComboBox.Location = New System.Drawing.Point(103, 61)
            Me.ClasificacionPredioMetroComboBox.Name = "ClasificacionPredioMetroComboBox"
            Me.ClasificacionPredioMetroComboBox.Size = New System.Drawing.Size(576, 29)
            Me.ClasificacionPredioMetroComboBox.TabIndex = 4
            Me.ClasificacionPredioMetroComboBox.UseSelectable = True
            '
            'MetroComboBox1
            '
            Me.MetroComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PredioBindingSource, "CodUsoGrupo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.MetroComboBox1.DataSource = Me.UsoGrupoBindingSource
            Me.MetroComboBox1.DisplayMember = "Grupo"
            Me.MetroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Small
            Me.MetroComboBox1.FormattingEnabled = True
            Me.MetroComboBox1.ItemHeight = 19
            Me.MetroComboBox1.Location = New System.Drawing.Point(3, 3)
            Me.MetroComboBox1.Name = "MetroComboBox1"
            Me.MetroComboBox1.Size = New System.Drawing.Size(145, 25)
            Me.MetroComboBox1.TabIndex = 5
            Me.MetroComboBox1.UseSelectable = True
            Me.MetroComboBox1.ValueMember = "CodGrupo"
            '
            'UsoGrupoBindingSource
            '
            Me.UsoGrupoBindingSource.DataSource = GetType(SimuImpPred.Data.UsoGrupo)
            '
            'MetroComboBox2
            '
            Me.MetroComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PredioBindingSource, "CodUsoSubGrupo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.MetroComboBox2.DataSource = Me.SubGruposBindingSource
            Me.MetroComboBox2.DisplayMember = "SubGrupo"
            Me.MetroComboBox2.FontSize = MetroFramework.MetroComboBoxSize.Small
            Me.MetroComboBox2.FormattingEnabled = True
            Me.MetroComboBox2.ItemHeight = 19
            Me.MetroComboBox2.Location = New System.Drawing.Point(154, 3)
            Me.MetroComboBox2.Name = "MetroComboBox2"
            Me.MetroComboBox2.Size = New System.Drawing.Size(253, 25)
            Me.MetroComboBox2.TabIndex = 6
            Me.MetroComboBox2.UseSelectable = True
            Me.MetroComboBox2.ValueMember = "CodSubGrupo"
            '
            'SubGruposBindingSource
            '
            Me.SubGruposBindingSource.DataMember = "SubGrupos"
            Me.SubGruposBindingSource.DataSource = Me.UsoGrupoBindingSource
            '
            'MetroComboBox3
            '
            Me.MetroComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PredioBindingSource, "CodUso", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.MetroComboBox3.DataSource = Me.UsosBindingSource
            Me.MetroComboBox3.DisplayMember = "Nombre"
            Me.MetroComboBox3.DropDownWidth = 700
            Me.MetroComboBox3.FontSize = MetroFramework.MetroComboBoxSize.Small
            Me.MetroComboBox3.FormattingEnabled = True
            Me.MetroComboBox3.ItemHeight = 19
            Me.MetroComboBox3.Location = New System.Drawing.Point(3, 34)
            Me.MetroComboBox3.Name = "MetroComboBox3"
            Me.MetroComboBox3.Size = New System.Drawing.Size(404, 25)
            Me.MetroComboBox3.TabIndex = 7
            Me.MetroComboBox3.UseSelectable = True
            Me.MetroComboBox3.ValueMember = "CodUso"
            '
            'UsosBindingSource
            '
            Me.UsosBindingSource.DataMember = "Usos"
            Me.UsosBindingSource.DataSource = Me.SubGruposBindingSource
            '
            'MetroTabControl1
            '
            Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
            Me.MetroTabControl1.Location = New System.Drawing.Point(688, 352)
            Me.MetroTabControl1.Name = "MetroTabControl1"
            Me.MetroTabControl1.SelectedIndex = 0
            Me.MetroTabControl1.Size = New System.Drawing.Size(421, 106)
            Me.MetroTabControl1.TabIndex = 10
            Me.MetroTabControl1.UseSelectable = True
            '
            'MetroTabPage1
            '
            Me.MetroTabPage1.Controls.Add(Me.MetroComboBox3)
            Me.MetroTabPage1.Controls.Add(Me.MetroComboBox1)
            Me.MetroTabPage1.Controls.Add(Me.MetroComboBox2)
            Me.MetroTabPage1.HorizontalScrollbarBarColor = True
            Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
            Me.MetroTabPage1.HorizontalScrollbarSize = 10
            Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
            Me.MetroTabPage1.Name = "MetroTabPage1"
            Me.MetroTabPage1.Size = New System.Drawing.Size(413, 64)
            Me.MetroTabPage1.TabIndex = 0
            Me.MetroTabPage1.Text = "Uso Predominante"
            Me.MetroTabPage1.VerticalScrollbarBarColor = True
            Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
            Me.MetroTabPage1.VerticalScrollbarSize = 10
            '
            'AutoavaluoTextBox
            '
            Me.AutoavaluoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "Autoavaluo", True))
            Me.AutoavaluoTextBox.Location = New System.Drawing.Point(343, 218)
            Me.AutoavaluoTextBox.Name = "AutoavaluoTextBox"
            Me.AutoavaluoTextBox.Size = New System.Drawing.Size(100, 20)
            Me.AutoavaluoTextBox.TabIndex = 11
            '
            'CodigoPredioTextBox
            '
            Me.CodigoPredioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "CodigoPredio", True))
            Me.CodigoPredioTextBox.Location = New System.Drawing.Point(343, 244)
            Me.CodigoPredioTextBox.Name = "CodigoPredioTextBox"
            Me.CodigoPredioTextBox.Size = New System.Drawing.Size(100, 20)
            Me.CodigoPredioTextBox.TabIndex = 12
            '
            'CondPropMetroComboBox
            '
            Me.CondPropMetroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "CondProp", True))
            Me.CondPropMetroComboBox.FormattingEnabled = True
            Me.CondPropMetroComboBox.ItemHeight = 23
            Me.CondPropMetroComboBox.Location = New System.Drawing.Point(343, 270)
            Me.CondPropMetroComboBox.Name = "CondPropMetroComboBox"
            Me.CondPropMetroComboBox.Size = New System.Drawing.Size(121, 29)
            Me.CondPropMetroComboBox.TabIndex = 13
            Me.CondPropMetroComboBox.UseSelectable = True
            '
            'ConstruccionesBindingSource
            '
            Me.ConstruccionesBindingSource.DataMember = "Construcciones"
            Me.ConstruccionesBindingSource.DataSource = Me.PredioBindingSource
            '
            'ConstruccionesDataGridView
            '
            Me.ConstruccionesDataGridView.AllowUserToAddRows = False
            Me.ConstruccionesDataGridView.AllowUserToDeleteRows = False
            Me.ConstruccionesDataGridView.AllowUserToResizeRows = False
            Me.ConstruccionesDataGridView.AutoGenerateColumns = False
            Me.ConstruccionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
            Me.ConstruccionesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ConstruccionesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.ConstruccionesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
            Me.ConstruccionesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.ConstruccionesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.ConstruccionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.ConstruccionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StrPisoDataGridViewTextBoxColumn, Me.MesAñoDataGridViewTextBoxColumn, Me.MepDataGridViewTextBoxColumn, Me.EcDataGridViewTextBoxColumn, Me.CategoriasDataGridViewTextBoxColumn, Me.ValorUnitarioDataGridViewTextBoxColumn, Me.Inc5PorcDataGridViewTextBoxColumn, Me.PorcDepreciacionDataGridViewTextBoxColumn, Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn, Me.AreaConstruidaDataGridViewTextBoxColumn, Me.ValorAreaConstruidaComunDataGridViewTextBoxColumn, Me.PorcPartPredioDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn})
            Me.ConstruccionesDataGridView.DataSource = Me.ConstruccionesBindingSource
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.ConstruccionesDataGridView.DefaultCellStyle = DataGridViewCellStyle10
            Me.ConstruccionesDataGridView.EnableHeadersVisualStyles = False
            Me.ConstruccionesDataGridView.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.ConstruccionesDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ConstruccionesDataGridView.Location = New System.Drawing.Point(545, 96)
            Me.ConstruccionesDataGridView.MultiSelect = False
            Me.ConstruccionesDataGridView.Name = "ConstruccionesDataGridView"
            Me.ConstruccionesDataGridView.ReadOnly = True
            Me.ConstruccionesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.ConstruccionesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
            Me.ConstruccionesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
            Me.ConstruccionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.ConstruccionesDataGridView.ShowCellErrors = False
            Me.ConstruccionesDataGridView.ShowCellToolTips = False
            Me.ConstruccionesDataGridView.ShowRowErrors = False
            Me.ConstruccionesDataGridView.Size = New System.Drawing.Size(554, 182)
            Me.ConstruccionesDataGridView.TabIndex = 13
            '
            'StrPisoDataGridViewTextBoxColumn
            '
            Me.StrPisoDataGridViewTextBoxColumn.DataPropertyName = "StrPiso"
            Me.StrPisoDataGridViewTextBoxColumn.HeaderText = "Piso"
            Me.StrPisoDataGridViewTextBoxColumn.Name = "StrPisoDataGridViewTextBoxColumn"
            Me.StrPisoDataGridViewTextBoxColumn.ReadOnly = True
            Me.StrPisoDataGridViewTextBoxColumn.Width = 51
            '
            'MesAñoDataGridViewTextBoxColumn
            '
            Me.MesAñoDataGridViewTextBoxColumn.DataPropertyName = "MesAño"
            Me.MesAñoDataGridViewTextBoxColumn.HeaderText = "Mes y Año"
            Me.MesAñoDataGridViewTextBoxColumn.Name = "MesAñoDataGridViewTextBoxColumn"
            Me.MesAñoDataGridViewTextBoxColumn.ReadOnly = True
            Me.MesAñoDataGridViewTextBoxColumn.Width = 76
            '
            'MepDataGridViewTextBoxColumn
            '
            Me.MepDataGridViewTextBoxColumn.DataPropertyName = "Mep"
            Me.MepDataGridViewTextBoxColumn.HeaderText = "MEP"
            Me.MepDataGridViewTextBoxColumn.Name = "MepDataGridViewTextBoxColumn"
            Me.MepDataGridViewTextBoxColumn.ReadOnly = True
            Me.MepDataGridViewTextBoxColumn.Width = 52
            '
            'EcDataGridViewTextBoxColumn
            '
            Me.EcDataGridViewTextBoxColumn.DataPropertyName = "Ec"
            Me.EcDataGridViewTextBoxColumn.HeaderText = "EC"
            Me.EcDataGridViewTextBoxColumn.Name = "EcDataGridViewTextBoxColumn"
            Me.EcDataGridViewTextBoxColumn.ReadOnly = True
            Me.EcDataGridViewTextBoxColumn.Width = 43
            '
            'CategoriasDataGridViewTextBoxColumn
            '
            Me.CategoriasDataGridViewTextBoxColumn.DataPropertyName = "Categorias"
            Me.CategoriasDataGridViewTextBoxColumn.HeaderText = "Categorias"
            Me.CategoriasDataGridViewTextBoxColumn.Name = "CategoriasDataGridViewTextBoxColumn"
            Me.CategoriasDataGridViewTextBoxColumn.ReadOnly = True
            Me.CategoriasDataGridViewTextBoxColumn.Width = 85
            '
            'ValorUnitarioDataGridViewTextBoxColumn
            '
            Me.ValorUnitarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
            Me.ValorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario"
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
            DataGridViewCellStyle2.Format = "C2"
            DataGridViewCellStyle2.NullValue = Nothing
            Me.ValorUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
            Me.ValorUnitarioDataGridViewTextBoxColumn.HeaderText = "Valor Unitario"
            Me.ValorUnitarioDataGridViewTextBoxColumn.Name = "ValorUnitarioDataGridViewTextBoxColumn"
            Me.ValorUnitarioDataGridViewTextBoxColumn.ReadOnly = True
            Me.ValorUnitarioDataGridViewTextBoxColumn.Width = 5
            '
            'Inc5PorcDataGridViewTextBoxColumn
            '
            Me.Inc5PorcDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
            Me.Inc5PorcDataGridViewTextBoxColumn.DataPropertyName = "Inc5Porc"
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
            DataGridViewCellStyle3.Format = "C2"
            DataGridViewCellStyle3.NullValue = Nothing
            Me.Inc5PorcDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
            Me.Inc5PorcDataGridViewTextBoxColumn.HeaderText = "Increm 5%"
            Me.Inc5PorcDataGridViewTextBoxColumn.Name = "Inc5PorcDataGridViewTextBoxColumn"
            Me.Inc5PorcDataGridViewTextBoxColumn.ReadOnly = True
            Me.Inc5PorcDataGridViewTextBoxColumn.Width = 5
            '
            'PorcDepreciacionDataGridViewTextBoxColumn
            '
            Me.PorcDepreciacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
            Me.PorcDepreciacionDataGridViewTextBoxColumn.DataPropertyName = "PorcDepreciacion"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
            DataGridViewCellStyle4.Format = "N4"
            DataGridViewCellStyle4.NullValue = Nothing
            Me.PorcDepreciacionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
            Me.PorcDepreciacionDataGridViewTextBoxColumn.HeaderText = "% Dep."
            Me.PorcDepreciacionDataGridViewTextBoxColumn.Name = "PorcDepreciacionDataGridViewTextBoxColumn"
            Me.PorcDepreciacionDataGridViewTextBoxColumn.ReadOnly = True
            Me.PorcDepreciacionDataGridViewTextBoxColumn.Width = 5
            '
            'ValorUnitarioDepreciadoDataGridViewTextBoxColumn
            '
            Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
            Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitarioDepreciado"
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
            DataGridViewCellStyle5.Format = "C2"
            DataGridViewCellStyle5.NullValue = Nothing
            Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
            Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.HeaderText = "Valor Unit. Deprec."
            Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.Name = "ValorUnitarioDepreciadoDataGridViewTextBoxColumn"
            Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.ReadOnly = True
            Me.ValorUnitarioDepreciadoDataGridViewTextBoxColumn.Width = 5
            '
            'AreaConstruidaDataGridViewTextBoxColumn
            '
            Me.AreaConstruidaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
            Me.AreaConstruidaDataGridViewTextBoxColumn.DataPropertyName = "AreaConstruida"
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
            DataGridViewCellStyle6.Format = "N2"
            DataGridViewCellStyle6.NullValue = Nothing
            Me.AreaConstruidaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
            Me.AreaConstruidaDataGridViewTextBoxColumn.HeaderText = "Area Construida"
            Me.AreaConstruidaDataGridViewTextBoxColumn.Name = "AreaConstruidaDataGridViewTextBoxColumn"
            Me.AreaConstruidaDataGridViewTextBoxColumn.ReadOnly = True
            Me.AreaConstruidaDataGridViewTextBoxColumn.Width = 5
            '
            'ValorAreaConstruidaComunDataGridViewTextBoxColumn
            '
            Me.ValorAreaConstruidaComunDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
            Me.ValorAreaConstruidaComunDataGridViewTextBoxColumn.DataPropertyName = "ValorAreaConstruidaComun"
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
            DataGridViewCellStyle7.Format = "C2"
            DataGridViewCellStyle7.NullValue = Nothing
            Me.ValorAreaConstruidaComunDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
            Me.ValorAreaConstruidaComunDataGridViewTextBoxColumn.HeaderText = "Valor Area Construida Comun"
            Me.ValorAreaConstruidaComunDataGridViewTextBoxColumn.Name = "ValorAreaConstruidaComunDataGridViewTextBoxColumn"
            Me.ValorAreaConstruidaComunDataGridViewTextBoxColumn.ReadOnly = True
            Me.ValorAreaConstruidaComunDataGridViewTextBoxColumn.Width = 5
            '
            'PorcPartPredioDataGridViewTextBoxColumn
            '
            Me.PorcPartPredioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
            Me.PorcPartPredioDataGridViewTextBoxColumn.DataPropertyName = "PorcPartPredio"
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
            DataGridViewCellStyle8.Format = "N4"
            DataGridViewCellStyle8.NullValue = Nothing
            Me.PorcPartPredioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
            Me.PorcPartPredioDataGridViewTextBoxColumn.HeaderText = "% Parti. Predio"
            Me.PorcPartPredioDataGridViewTextBoxColumn.Name = "PorcPartPredioDataGridViewTextBoxColumn"
            Me.PorcPartPredioDataGridViewTextBoxColumn.ReadOnly = True
            Me.PorcPartPredioDataGridViewTextBoxColumn.Width = 5
            '
            'ValorDataGridViewTextBoxColumn
            '
            Me.ValorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
            Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
            DataGridViewCellStyle9.Format = "C2"
            DataGridViewCellStyle9.NullValue = Nothing
            Me.ValorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
            Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor Area Construida"
            Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
            Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
            Me.ValorDataGridViewTextBoxColumn.Width = 5
            '
            'ContratantesBindingSource
            '
            Me.ContratantesBindingSource.DataMember = "Contratantes"
            Me.ContratantesBindingSource.DataSource = Me.PredioBindingSource
            '
            'DeduccionTextBox
            '
            Me.DeduccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "Deduccion", True))
            Me.DeduccionTextBox.Location = New System.Drawing.Point(343, 305)
            Me.DeduccionTextBox.Name = "DeduccionTextBox"
            Me.DeduccionTextBox.Size = New System.Drawing.Size(100, 20)
            Me.DeduccionTextBox.TabIndex = 14
            '
            'EstadoConstruccionMetroComboBox
            '
            Me.EstadoConstruccionMetroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "EstadoConstruccion", True))
            Me.EstadoConstruccionMetroComboBox.FormattingEnabled = True
            Me.EstadoConstruccionMetroComboBox.ItemHeight = 23
            Me.EstadoConstruccionMetroComboBox.Location = New System.Drawing.Point(343, 331)
            Me.EstadoConstruccionMetroComboBox.Name = "EstadoConstruccionMetroComboBox"
            Me.EstadoConstruccionMetroComboBox.Size = New System.Drawing.Size(121, 29)
            Me.EstadoConstruccionMetroComboBox.TabIndex = 16
            Me.EstadoConstruccionMetroComboBox.UseSelectable = True
            '
            'NumCopropNumericUpDown
            '
            Me.NumCopropNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PredioBindingSource, "NumCoprop", True))
            Me.NumCopropNumericUpDown.Location = New System.Drawing.Point(175, 146)
            Me.NumCopropNumericUpDown.Name = "NumCopropNumericUpDown"
            Me.NumCopropNumericUpDown.Size = New System.Drawing.Size(120, 20)
            Me.NumCopropNumericUpDown.TabIndex = 20
            '
            'OtrasInstalacionesBindingSource
            '
            Me.OtrasInstalacionesBindingSource.DataMember = "OtrasInstalaciones"
            Me.OtrasInstalacionesBindingSource.DataSource = Me.PredioBindingSource
            '
            'OtrasInstalacionesDataGridView
            '
            Me.OtrasInstalacionesDataGridView.AutoGenerateColumns = False
            Me.OtrasInstalacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.OtrasInstalacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49})
            Me.OtrasInstalacionesDataGridView.DataSource = Me.OtrasInstalacionesBindingSource
            Me.OtrasInstalacionesDataGridView.Location = New System.Drawing.Point(402, 328)
            Me.OtrasInstalacionesDataGridView.Name = "OtrasInstalacionesDataGridView"
            Me.OtrasInstalacionesDataGridView.Size = New System.Drawing.Size(244, 116)
            Me.OtrasInstalacionesDataGridView.TabIndex = 21
            '
            'DataGridViewTextBoxColumn31
            '
            Me.DataGridViewTextBoxColumn31.DataPropertyName = "Ifp"
            Me.DataGridViewTextBoxColumn31.HeaderText = "Ifp"
            Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
            '
            'DataGridViewTextBoxColumn32
            '
            Me.DataGridViewTextBoxColumn32.DataPropertyName = "Cantidad"
            Me.DataGridViewTextBoxColumn32.HeaderText = "Cantidad"
            Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
            '
            'DataGridViewTextBoxColumn33
            '
            Me.DataGridViewTextBoxColumn33.DataPropertyName = "PorcPartPredio"
            Me.DataGridViewTextBoxColumn33.HeaderText = "PorcPartPredio"
            Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
            '
            'DataGridViewTextBoxColumn34
            '
            Me.DataGridViewTextBoxColumn34.DataPropertyName = "Cod"
            Me.DataGridViewTextBoxColumn34.HeaderText = "Cod"
            Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
            Me.DataGridViewTextBoxColumn34.ReadOnly = True
            '
            'DataGridViewTextBoxColumn35
            '
            Me.DataGridViewTextBoxColumn35.DataPropertyName = "Denominacion"
            Me.DataGridViewTextBoxColumn35.HeaderText = "Denominacion"
            Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
            Me.DataGridViewTextBoxColumn35.ReadOnly = True
            '
            'DataGridViewTextBoxColumn36
            '
            Me.DataGridViewTextBoxColumn36.DataPropertyName = "ValorUnitario"
            Me.DataGridViewTextBoxColumn36.HeaderText = "ValorUnitario"
            Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
            Me.DataGridViewTextBoxColumn36.ReadOnly = True
            '
            'DataGridViewTextBoxColumn37
            '
            Me.DataGridViewTextBoxColumn37.DataPropertyName = "Unidad"
            Me.DataGridViewTextBoxColumn37.HeaderText = "Unidad"
            Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
            Me.DataGridViewTextBoxColumn37.ReadOnly = True
            '
            'DataGridViewTextBoxColumn38
            '
            Me.DataGridViewTextBoxColumn38.DataPropertyName = "Fo"
            Me.DataGridViewTextBoxColumn38.HeaderText = "Fo"
            Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
            Me.DataGridViewTextBoxColumn38.ReadOnly = True
            '
            'DataGridViewTextBoxColumn39
            '
            Me.DataGridViewTextBoxColumn39.DataPropertyName = "Valor"
            Me.DataGridViewTextBoxColumn39.HeaderText = "Valor"
            Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
            Me.DataGridViewTextBoxColumn39.ReadOnly = True
            '
            'DataGridViewTextBoxColumn40
            '
            Me.DataGridViewTextBoxColumn40.DataPropertyName = "Mes"
            Me.DataGridViewTextBoxColumn40.HeaderText = "Mes"
            Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
            '
            'DataGridViewTextBoxColumn41
            '
            Me.DataGridViewTextBoxColumn41.DataPropertyName = "Año"
            Me.DataGridViewTextBoxColumn41.HeaderText = "Año"
            Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
            '
            'DataGridViewTextBoxColumn42
            '
            Me.DataGridViewTextBoxColumn42.DataPropertyName = "MesAño"
            Me.DataGridViewTextBoxColumn42.HeaderText = "MesAño"
            Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
            Me.DataGridViewTextBoxColumn42.ReadOnly = True
            '
            'DataGridViewTextBoxColumn43
            '
            Me.DataGridViewTextBoxColumn43.DataPropertyName = "Mep"
            Me.DataGridViewTextBoxColumn43.HeaderText = "Mep"
            Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
            '
            'DataGridViewTextBoxColumn44
            '
            Me.DataGridViewTextBoxColumn44.DataPropertyName = "Ec"
            Me.DataGridViewTextBoxColumn44.HeaderText = "Ec"
            Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
            '
            'DataGridViewTextBoxColumn45
            '
            Me.DataGridViewTextBoxColumn45.DataPropertyName = "ClasificacionPredio"
            Me.DataGridViewTextBoxColumn45.HeaderText = "ClasificacionPredio"
            Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
            Me.DataGridViewTextBoxColumn45.ReadOnly = True
            '
            'DataGridViewTextBoxColumn46
            '
            Me.DataGridViewTextBoxColumn46.DataPropertyName = "Antiguedad"
            Me.DataGridViewTextBoxColumn46.HeaderText = "Antiguedad"
            Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
            Me.DataGridViewTextBoxColumn46.ReadOnly = True
            '
            'DataGridViewTextBoxColumn47
            '
            Me.DataGridViewTextBoxColumn47.DataPropertyName = "PorcDepreciacion"
            Me.DataGridViewTextBoxColumn47.HeaderText = "PorcDepreciacion"
            Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
            Me.DataGridViewTextBoxColumn47.ReadOnly = True
            '
            'DataGridViewTextBoxColumn48
            '
            Me.DataGridViewTextBoxColumn48.DataPropertyName = "ValorDepreciacion"
            Me.DataGridViewTextBoxColumn48.HeaderText = "ValorDepreciacion"
            Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
            Me.DataGridViewTextBoxColumn48.ReadOnly = True
            '
            'DataGridViewTextBoxColumn49
            '
            Me.DataGridViewTextBoxColumn49.DataPropertyName = "ValorUnitarioDepreciado"
            Me.DataGridViewTextBoxColumn49.HeaderText = "ValorUnitarioDepreciado"
            Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
            Me.DataGridViewTextBoxColumn49.ReadOnly = True
            '
            'PorcPropTextBox
            '
            Me.PorcPropTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "PorcProp", True))
            Me.PorcPropTextBox.Location = New System.Drawing.Point(217, 182)
            Me.PorcPropTextBox.Name = "PorcPropTextBox"
            Me.PorcPropTextBox.Size = New System.Drawing.Size(100, 20)
            Me.PorcPropTextBox.TabIndex = 23
            '
            'TipoMetroLabel
            '
            Me.TipoMetroLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "Tipo", True))
            Me.TipoMetroLabel.Location = New System.Drawing.Point(935, 11)
            Me.TipoMetroLabel.Name = "TipoMetroLabel"
            Me.TipoMetroLabel.Size = New System.Drawing.Size(100, 23)
            Me.TipoMetroLabel.TabIndex = 25
            Me.TipoMetroLabel.Text = "MetroLabel2"
            '
            'TipoPredioMetroComboBox
            '
            Me.TipoPredioMetroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "TipoPredio", True))
            Me.TipoPredioMetroComboBox.FormattingEnabled = True
            Me.TipoPredioMetroComboBox.ItemHeight = 23
            Me.TipoPredioMetroComboBox.Location = New System.Drawing.Point(138, 297)
            Me.TipoPredioMetroComboBox.Name = "TipoPredioMetroComboBox"
            Me.TipoPredioMetroComboBox.Size = New System.Drawing.Size(121, 29)
            Me.TipoPredioMetroComboBox.TabIndex = 29
            Me.TipoPredioMetroComboBox.UseSelectable = True
            '
            'ValorAutoavaluoTextBox
            '
            Me.ValorAutoavaluoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "ValorAutoavaluo", True))
            Me.ValorAutoavaluoTextBox.Location = New System.Drawing.Point(149, 432)
            Me.ValorAutoavaluoTextBox.Name = "ValorAutoavaluoTextBox"
            Me.ValorAutoavaluoTextBox.Size = New System.Drawing.Size(100, 20)
            Me.ValorAutoavaluoTextBox.TabIndex = 31
            '
            'ValorPorcPropiedadTextBox
            '
            Me.ValorPorcPropiedadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "ValorPorcPropiedad", True))
            Me.ValorPorcPropiedadTextBox.Location = New System.Drawing.Point(149, 458)
            Me.ValorPorcPropiedadTextBox.Name = "ValorPorcPropiedadTextBox"
            Me.ValorPorcPropiedadTextBox.Size = New System.Drawing.Size(100, 20)
            Me.ValorPorcPropiedadTextBox.TabIndex = 33
            '
            'ValorTotalAreaConstruidaPropiaTextBox
            '
            Me.ValorTotalAreaConstruidaPropiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "ValorTotalAreaConstruidaPropia", True))
            Me.ValorTotalAreaConstruidaPropiaTextBox.Location = New System.Drawing.Point(449, 424)
            Me.ValorTotalAreaConstruidaPropiaTextBox.Name = "ValorTotalAreaConstruidaPropiaTextBox"
            Me.ValorTotalAreaConstruidaPropiaTextBox.Size = New System.Drawing.Size(100, 20)
            Me.ValorTotalAreaConstruidaPropiaTextBox.TabIndex = 35
            '
            'ValorTotalOtrasInstalacionesTextBox
            '
            Me.ValorTotalOtrasInstalacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "ValorTotalOtrasInstalaciones", True))
            Me.ValorTotalOtrasInstalacionesTextBox.Location = New System.Drawing.Point(449, 449)
            Me.ValorTotalOtrasInstalacionesTextBox.Name = "ValorTotalOtrasInstalacionesTextBox"
            Me.ValorTotalOtrasInstalacionesTextBox.Size = New System.Drawing.Size(100, 20)
            Me.ValorTotalOtrasInstalacionesTextBox.TabIndex = 37
            '
            'ValorTotalTerrenoTextBox
            '
            Me.ValorTotalTerrenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredioBindingSource, "ValorTotalTerreno", True))
            Me.ValorTotalTerrenoTextBox.Location = New System.Drawing.Point(449, 475)
            Me.ValorTotalTerrenoTextBox.Name = "ValorTotalTerrenoTextBox"
            Me.ValorTotalTerrenoTextBox.Size = New System.Drawing.Size(100, 20)
            Me.ValorTotalTerrenoTextBox.TabIndex = 39
            '
            'DireccionUc1
            '
            Me.DireccionUc1.AutoSize = True
            Me.DireccionUc1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.DireccionUc1.DataBindings.Add(New System.Windows.Forms.Binding("Direccion", Me.PredioBindingSource, "UbicacionPredio", True))
            Me.DireccionUc1.Direccion = Nothing
            Me.DireccionUc1.Location = New System.Drawing.Point(661, 168)
            Me.DireccionUc1.Name = "DireccionUc1"
            Me.DireccionUc1.Size = New System.Drawing.Size(407, 145)
            Me.DireccionUc1.TabIndex = 40
            Me.DireccionUc1.UseSelectable = True
            '
            'EditPredioUc
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.DireccionUc1)
            Me.Controls.Add(ValorTotalTerrenoLabel)
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Controls.Add(Me.ValorTotalTerrenoTextBox)
            Me.Controls.Add(ValorTotalOtrasInstalacionesLabel)
            Me.Controls.Add(Me.ValorTotalOtrasInstalacionesTextBox)
            Me.Controls.Add(ValorTotalAreaConstruidaPropiaLabel)
            Me.Controls.Add(Me.ValorTotalAreaConstruidaPropiaTextBox)
            Me.Controls.Add(ValorPorcPropiedadLabel)
            Me.Controls.Add(Me.ValorPorcPropiedadTextBox)
            Me.Controls.Add(ValorAutoavaluoLabel)
            Me.Controls.Add(Me.ValorAutoavaluoTextBox)
            Me.Controls.Add(TipoPredioLabel)
            Me.Controls.Add(Me.TipoPredioMetroComboBox)
            Me.Controls.Add(TipoLabel)
            Me.Controls.Add(Me.TipoMetroLabel)
            Me.Controls.Add(PorcPropLabel)
            Me.Controls.Add(Me.PorcPropTextBox)
            Me.Controls.Add(Me.OtrasInstalacionesDataGridView)
            Me.Controls.Add(NumCopropLabel)
            Me.Controls.Add(Me.NumCopropNumericUpDown)
            Me.Controls.Add(EstadoConstruccionLabel)
            Me.Controls.Add(Me.EstadoConstruccionMetroComboBox)
            Me.Controls.Add(DeduccionLabel)
            Me.Controls.Add(Me.DeduccionTextBox)
            Me.Controls.Add(Me.ConstruccionesDataGridView)
            Me.Controls.Add(CondPropLabel)
            Me.Controls.Add(Me.CondPropMetroComboBox)
            Me.Controls.Add(CodigoPredioLabel)
            Me.Controls.Add(Me.CodigoPredioTextBox)
            Me.Controls.Add(AutoavaluoLabel)
            Me.Controls.Add(Me.AutoavaluoTextBox)
            Me.Controls.Add(Me.MetroTabControl1)
            Me.Controls.Add(ClasificacionPredioLabel)
            Me.Controls.Add(Me.ClasificacionPredioMetroComboBox)
            Me.Controls.Add(Me.MetroTile1)
            Me.Controls.Add(Me.MetroPanel1)
            Me.Name = "EditPredioUc"
            Me.Size = New System.Drawing.Size(1154, 612)
            Me.FlowLayoutPanel1.ResumeLayout(False)
            Me.FlowLayoutPanel1.PerformLayout()
            CType(Me.HojaResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PredioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MetroTile1.ResumeLayout(False)
            CType(Me.UsoGrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SubGruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UsosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MetroTabControl1.ResumeLayout(False)
            Me.MetroTabPage1.ResumeLayout(False)
            CType(Me.ConstruccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ConstruccionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ContratantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NumCopropNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OtrasInstalacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OtrasInstalacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
        Friend WithEvents ImpuestoAnualMetroLabel As MetroFramework.Controls.MetroLabel
        Friend WithEvents MlImpuestoTrimestralL As MetroFramework.Controls.MetroLabel
        Friend WithEvents MlImpuestoTrimestral As MetroFramework.Controls.MetroLabel
        Protected Friend WithEvents HojaResumenBindingSource As BindingSource
        Friend WithEvents AnexoMetroLabel As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
        Friend WithEvents PredioBindingSource As BindingSource
        Friend WithEvents ClasificacionPredioMetroComboBox As MetroFramework.Controls.MetroComboBox
        Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
        Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
        Friend WithEvents MetroComboBox3 As MetroFramework.Controls.MetroComboBox
        Friend WithEvents UsoGrupoBindingSource As BindingSource
        Friend WithEvents SubGruposBindingSource As BindingSource
        Friend WithEvents UsosBindingSource As BindingSource
        Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
        Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
        Friend WithEvents AutoavaluoTextBox As TextBox
        Friend WithEvents CodigoPredioTextBox As TextBox
        Friend WithEvents CondPropMetroComboBox As MetroComboBox
        Friend WithEvents ConstruccionesBindingSource As BindingSource
        Friend WithEvents ConstruccionesDataGridView As MetroGrid
        Friend WithEvents ContratantesBindingSource As BindingSource
        Friend WithEvents DeduccionTextBox As TextBox
        Friend WithEvents EstadoConstruccionMetroComboBox As MetroComboBox
        Friend WithEvents NumCopropNumericUpDown As NumericUpDown
        Friend WithEvents OtrasInstalacionesBindingSource As BindingSource
        Friend WithEvents OtrasInstalacionesDataGridView As DataGridView
        Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
        Friend WithEvents PorcPropTextBox As TextBox
        Friend WithEvents TipoMetroLabel As MetroLabel
        Friend WithEvents TipoPredioMetroComboBox As MetroComboBox
        Friend WithEvents ValorAutoavaluoTextBox As TextBox
        Friend WithEvents ValorPorcPropiedadTextBox As TextBox
        Friend WithEvents ValorTotalAreaConstruidaPropiaTextBox As TextBox
        Friend WithEvents ValorTotalOtrasInstalacionesTextBox As TextBox
        Friend WithEvents ValorTotalTerrenoTextBox As TextBox
        Friend WithEvents ValorConstruccionDgvtc As DataGridViewTextBoxColumn
        Friend WithEvents StrPisoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents MesAñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents MepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents EcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents CategoriasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ValorUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents Inc5PorcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents PorcDepreciacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ValorUnitarioDepreciadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents AreaConstruidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ValorAreaConstruidaComunDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents PorcPartPredioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents ValorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
        Friend WithEvents DireccionUc1 As DireccionUc
    End Class
End Namespace