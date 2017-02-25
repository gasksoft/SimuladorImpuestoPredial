<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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

    Friend WithEvents ToolStripContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim BaseImponibleLabel As System.Windows.Forms.Label
        Dim ImpuestoAnualLabel As System.Windows.Forms.Label
        Dim CuotaTrimestralLabel As System.Windows.Forms.Label
        Dim PresuntoLabel As System.Windows.Forms.Label
        Dim CondicionEspecialContribuyenteLabel As System.Windows.Forms.Label
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BaseImponibleTextBox = New System.Windows.Forms.TextBox()
        Me.ImpuestoAnualTextBox = New System.Windows.Forms.TextBox()
        Me.CuotaTrimestralTextBox = New System.Windows.Forms.TextBox()
        Me.PresuntoCheckBox = New System.Windows.Forms.CheckBox()
        Me.HojaResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CondicionEspecialContribuyenteComboBox = New System.Windows.Forms.ComboBox()
        BaseImponibleLabel = New System.Windows.Forms.Label()
        ImpuestoAnualLabel = New System.Windows.Forms.Label()
        CuotaTrimestralLabel = New System.Windows.Forms.Label()
        PresuntoLabel = New System.Windows.Forms.Label()
        CondicionEspecialContribuyenteLabel = New System.Windows.Forms.Label()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStripContainer.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.ContentPanel.SuspendLayout()
        Me.ToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.SuspendLayout()
        CType(Me.HojaResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(900, 22)
        Me.StatusStrip.TabIndex = 6
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'ToolStrip
        '
        Me.ToolStrip.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator7})
        Me.ToolStrip.Location = New System.Drawing.Point(3, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(18, 25)
        Me.ToolStrip.TabIndex = 0
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'MenuStrip
        '
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator2, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.FileToolStripMenuItem.Text = "&Archivo"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.NewToolStripMenuItem.Text = "&Nuevo"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.OpenToolStripMenuItem.Text = "&Abrir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(203, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SaveToolStripMenuItem.Text = "&Guardar"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SaveAsToolStripMenuItem.Text = "Guardar &como"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(203, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.PrintToolStripMenuItem.Text = "&Imprimir"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "&Vista previa de impresión"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(203, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.ViewToolStripMenuItem.Text = "&Ver"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ToolBarToolStripMenuItem.Text = "&Barra de herramientas"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Barra de estado"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ToolsToolStripMenuItem.Text = "&Herramientas"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OptionsToolStripMenuItem.Text = "&Opciones"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator6, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.HelpToolStripMenuItem.Text = "Ay&uda"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contenido"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.IndexToolStripMenuItem.Text = "&Índice"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SearchToolStripMenuItem.Text = "&Buscar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(173, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de ..."
        '
        'ToolStripContainer
        '
        '
        'ToolStripContainer.BottomToolStripPanel
        '
        Me.ToolStripContainer.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
        '
        'ToolStripContainer.ContentPanel
        '
        Me.ToolStripContainer.ContentPanel.Controls.Add(CondicionEspecialContribuyenteLabel)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.CondicionEspecialContribuyenteComboBox)
        Me.ToolStripContainer.ContentPanel.Controls.Add(PresuntoLabel)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.PresuntoCheckBox)
        Me.ToolStripContainer.ContentPanel.Controls.Add(CuotaTrimestralLabel)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.CuotaTrimestralTextBox)
        Me.ToolStripContainer.ContentPanel.Controls.Add(ImpuestoAnualLabel)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.ImpuestoAnualTextBox)
        Me.ToolStripContainer.ContentPanel.Controls.Add(BaseImponibleLabel)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.BaseImponibleTextBox)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.Button2)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.Button1)
        Me.ToolStripContainer.ContentPanel.Size = New System.Drawing.Size(900, 328)
        Me.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer.Name = "ToolStripContainer"
        Me.ToolStripContainer.Size = New System.Drawing.Size(900, 399)
        Me.ToolStripContainer.TabIndex = 7
        Me.ToolStripContainer.Text = "ToolStripContainer1"
        '
        'ToolStripContainer.TopToolStripPanel
        '
        Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.MenuStrip)
        Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(503, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(503, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BaseImponibleLabel
        '
        BaseImponibleLabel.AutoSize = True
        BaseImponibleLabel.Location = New System.Drawing.Point(100, 88)
        BaseImponibleLabel.Name = "BaseImponibleLabel"
        BaseImponibleLabel.Size = New System.Drawing.Size(82, 13)
        BaseImponibleLabel.TabIndex = 2
        BaseImponibleLabel.Text = "Base Imponible:"
        '
        'BaseImponibleTextBox
        '
        Me.BaseImponibleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "BaseImponible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2"))
        Me.BaseImponibleTextBox.Location = New System.Drawing.Point(188, 85)
        Me.BaseImponibleTextBox.Name = "BaseImponibleTextBox"
        Me.BaseImponibleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BaseImponibleTextBox.TabIndex = 3
        Me.BaseImponibleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImpuestoAnualLabel
        '
        ImpuestoAnualLabel.AutoSize = True
        ImpuestoAnualLabel.Location = New System.Drawing.Point(99, 114)
        ImpuestoAnualLabel.Name = "ImpuestoAnualLabel"
        ImpuestoAnualLabel.Size = New System.Drawing.Size(83, 13)
        ImpuestoAnualLabel.TabIndex = 4
        ImpuestoAnualLabel.Text = "Impuesto Anual:"
        '
        'ImpuestoAnualTextBox
        '
        Me.ImpuestoAnualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "ImpuestoAnual", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.ImpuestoAnualTextBox.Location = New System.Drawing.Point(188, 111)
        Me.ImpuestoAnualTextBox.Name = "ImpuestoAnualTextBox"
        Me.ImpuestoAnualTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImpuestoAnualTextBox.TabIndex = 5
        Me.ImpuestoAnualTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CuotaTrimestralLabel
        '
        CuotaTrimestralLabel.AutoSize = True
        CuotaTrimestralLabel.Location = New System.Drawing.Point(96, 140)
        CuotaTrimestralLabel.Name = "CuotaTrimestralLabel"
        CuotaTrimestralLabel.Size = New System.Drawing.Size(86, 13)
        CuotaTrimestralLabel.TabIndex = 6
        CuotaTrimestralLabel.Text = "Cuota Trimestral:"
        '
        'CuotaTrimestralTextBox
        '
        Me.CuotaTrimestralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "CuotaTrimestral", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.CuotaTrimestralTextBox.Location = New System.Drawing.Point(188, 137)
        Me.CuotaTrimestralTextBox.Name = "CuotaTrimestralTextBox"
        Me.CuotaTrimestralTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CuotaTrimestralTextBox.TabIndex = 7
        Me.CuotaTrimestralTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PresuntoLabel
        '
        PresuntoLabel.AutoSize = True
        PresuntoLabel.Location = New System.Drawing.Point(425, 131)
        PresuntoLabel.Name = "PresuntoLabel"
        PresuntoLabel.Size = New System.Drawing.Size(52, 13)
        PresuntoLabel.TabIndex = 8
        PresuntoLabel.Text = "Presunto:"
        '
        'PresuntoCheckBox
        '
        Me.PresuntoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HojaResumenBindingSource, "Presunto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PresuntoCheckBox.Location = New System.Drawing.Point(483, 126)
        Me.PresuntoCheckBox.Name = "PresuntoCheckBox"
        Me.PresuntoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.PresuntoCheckBox.TabIndex = 9
        Me.PresuntoCheckBox.Text = "CheckBox1"
        Me.PresuntoCheckBox.UseVisualStyleBackColor = True
        '
        'HojaResumenBindingSource
        '
        Me.HojaResumenBindingSource.DataSource = GetType(SimuImpPred.ObjectModel.HojaResumen)
        '
        'CondicionEspecialContribuyenteLabel
        '
        CondicionEspecialContribuyenteLabel.AutoSize = True
        CondicionEspecialContribuyenteLabel.Location = New System.Drawing.Point(51, 20)
        CondicionEspecialContribuyenteLabel.Name = "CondicionEspecialContribuyenteLabel"
        CondicionEspecialContribuyenteLabel.Size = New System.Drawing.Size(168, 13)
        CondicionEspecialContribuyenteLabel.TabIndex = 10
        CondicionEspecialContribuyenteLabel.Text = "Condicion Especial Contribuyente:"
        '
        'CondicionEspecialContribuyenteComboBox
        '
        Me.CondicionEspecialContribuyenteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HojaResumenBindingSource, "CondicionEspecialContribuyente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CondicionEspecialContribuyenteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CondicionEspecialContribuyenteComboBox.FormattingEnabled = True
        Me.CondicionEspecialContribuyenteComboBox.Location = New System.Drawing.Point(51, 36)
        Me.CondicionEspecialContribuyenteComboBox.Name = "CondicionEspecialContribuyenteComboBox"
        Me.CondicionEspecialContribuyenteComboBox.Size = New System.Drawing.Size(322, 21)
        Me.CondicionEspecialContribuyenteComboBox.TabIndex = 11
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 399)
        Me.Controls.Add(Me.ToolStripContainer)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer.ContentPanel.PerformLayout()
        Me.ToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ResumeLayout(False)
        Me.ToolStripContainer.PerformLayout()
        CType(Me.HojaResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HojaResumenBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CuotaTrimestralTextBox As TextBox
    Friend WithEvents ImpuestoAnualTextBox As TextBox
    Friend WithEvents BaseImponibleTextBox As TextBox
    Friend WithEvents PresuntoCheckBox As CheckBox
    Friend WithEvents CondicionEspecialContribuyenteComboBox As ComboBox
End Class
