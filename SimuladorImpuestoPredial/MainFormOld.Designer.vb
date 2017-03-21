Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFormOld
    Inherits MetroFramework.Forms.MetroForm

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
        Dim CondicionEspecialContribuyenteLabel As System.Windows.Forms.Label
        Dim PresuntoLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim UitLabel As System.Windows.Forms.Label
        Dim BaseImponibleLabel As System.Windows.Forms.Label
        Dim BaseImponibleTotalLabel As System.Windows.Forms.Label
        Dim DeduccionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFormOld))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.ValorizacionPresuntaToggle = New MetroFramework.Controls.MetroToggle()
        Me.UitLabel1 = New System.Windows.Forms.Label()
        Me.DeduccionTextBox = New System.Windows.Forms.TextBox()
        Me.BaseImponibleTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.AñoComboBox = New System.Windows.Forms.ComboBox()
        Me.BaseImponibleTotalTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ImpuestoTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImpuestoTramo3TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CuotaTrimestralTextBox = New System.Windows.Forms.TextBox()
        Me.ImpuestoTramo2TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ImpuestoTramo1TextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BaseImponibleTramo3TextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BaseImponibleTramo1TextBox = New System.Windows.Forms.TextBox()
        Me.BaseImponibleTramo2TextBox = New System.Windows.Forms.TextBox()
        Me.PrediosDataGridView = New System.Windows.Forms.DataGridView()
        Me.PrediosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.CondicionEspecialContribuyenteComboBox = New System.Windows.Forms.ComboBox()
        Me.AgregarPrBtn = New System.Windows.Forms.Button()
        Me.AgregarPuBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.HojaResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParametrosCalculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescPredioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CondicionEspecialContribuyenteLabel = New System.Windows.Forms.Label()
        PresuntoLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        UitLabel = New System.Windows.Forms.Label()
        BaseImponibleLabel = New System.Windows.Forms.Label()
        BaseImponibleTotalLabel = New System.Windows.Forms.Label()
        DeduccionLabel = New System.Windows.Forms.Label()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStripContainer.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.ContentPanel.SuspendLayout()
        Me.ToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PrediosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrediosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.HojaResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParametrosCalculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CondicionEspecialContribuyenteLabel
        '
        CondicionEspecialContribuyenteLabel.AutoSize = True
        CondicionEspecialContribuyenteLabel.Location = New System.Drawing.Point(68, 34)
        CondicionEspecialContribuyenteLabel.Name = "CondicionEspecialContribuyenteLabel"
        CondicionEspecialContribuyenteLabel.Size = New System.Drawing.Size(189, 15)
        CondicionEspecialContribuyenteLabel.TabIndex = 13
        CondicionEspecialContribuyenteLabel.Text = "Condicion Especial Contribuyente:"
        '
        'PresuntoLabel
        '
        PresuntoLabel.AutoSize = True
        PresuntoLabel.Location = New System.Drawing.Point(444, 280)
        PresuntoLabel.Name = "PresuntoLabel"
        PresuntoLabel.Size = New System.Drawing.Size(69, 15)
        PresuntoLabel.TabIndex = 17
        PresuntoLabel.Text = "Sin detalles:"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(88, 159)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(32, 15)
        AñoLabel.TabIndex = 31
        AñoLabel.Text = "Año:"
        '
        'UitLabel
        '
        UitLabel.AutoSize = True
        UitLabel.Location = New System.Drawing.Point(293, 158)
        UitLabel.Name = "UitLabel"
        UitLabel.Size = New System.Drawing.Size(25, 15)
        UitLabel.TabIndex = 33
        UitLabel.Text = "Uit:"
        '
        'BaseImponibleLabel
        '
        BaseImponibleLabel.AutoSize = True
        BaseImponibleLabel.Location = New System.Drawing.Point(422, 313)
        BaseImponibleLabel.Name = "BaseImponibleLabel"
        BaseImponibleLabel.Size = New System.Drawing.Size(91, 15)
        BaseImponibleLabel.TabIndex = 14
        BaseImponibleLabel.Text = "Base Imponible:"
        BaseImponibleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BaseImponibleTotalLabel
        '
        BaseImponibleTotalLabel.AutoSize = True
        BaseImponibleTotalLabel.Location = New System.Drawing.Point(393, 375)
        BaseImponibleTotalLabel.Name = "BaseImponibleTotalLabel"
        BaseImponibleTotalLabel.Size = New System.Drawing.Size(120, 15)
        BaseImponibleTotalLabel.TabIndex = 35
        BaseImponibleTotalLabel.Text = "Base Imponible Total:"
        '
        'DeduccionLabel
        '
        DeduccionLabel.AutoSize = True
        DeduccionLabel.Location = New System.Drawing.Point(446, 344)
        DeduccionLabel.Name = "DeduccionLabel"
        DeduccionLabel.Size = New System.Drawing.Size(67, 15)
        DeduccionLabel.TabIndex = 34
        DeduccionLabel.Text = "Deduccion:"
        '
        'StatusStrip
        '
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1089, 22)
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
        Me.MenuStrip.Size = New System.Drawing.Size(1089, 24)
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
        Me.ToolStripContainer.ContentPanel.AutoScroll = True
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.MetroLabel1)
        Me.ToolStripContainer.ContentPanel.Controls.Add(BaseImponibleLabel)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.ValorizacionPresuntaToggle)
        Me.ToolStripContainer.ContentPanel.Controls.Add(DeduccionLabel)
        Me.ToolStripContainer.ContentPanel.Controls.Add(UitLabel)
        Me.ToolStripContainer.ContentPanel.Controls.Add(BaseImponibleTotalLabel)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.UitLabel1)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.DeduccionTextBox)
        Me.ToolStripContainer.ContentPanel.Controls.Add(AñoLabel)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.BaseImponibleTextBox)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.AñoComboBox)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.BaseImponibleTotalTextBox)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.PrediosDataGridView)
        Me.ToolStripContainer.ContentPanel.Controls.Add(PresuntoLabel)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.BindingNavigator1)
        Me.ToolStripContainer.ContentPanel.Controls.Add(CondicionEspecialContribuyenteLabel)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.CondicionEspecialContribuyenteComboBox)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.AgregarPrBtn)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.AgregarPuBtn)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.Button2)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.Button1)
        Me.ToolStripContainer.ContentPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ToolStripContainer.ContentPanel.Size = New System.Drawing.Size(1089, 484)
        Me.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer.Location = New System.Drawing.Point(20, 60)
        Me.ToolStripContainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ToolStripContainer.Name = "ToolStripContainer"
        Me.ToolStripContainer.Size = New System.Drawing.Size(1089, 555)
        Me.ToolStripContainer.TabIndex = 7
        Me.ToolStripContainer.Text = "ToolStripContainer1"
        '
        'ToolStripContainer.TopToolStripPanel
        '
        Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.MenuStrip)
        Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        '
        'ValorizacionPresuntaToggle
        '
        Me.ValorizacionPresuntaToggle.Checked = True
        Me.ValorizacionPresuntaToggle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ValorizacionPresuntaToggle.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.HojaResumenBindingSource, "Presunto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ValorizacionPresuntaToggle.DisplayStatus = False
        Me.ValorizacionPresuntaToggle.Location = New System.Drawing.Point(519, 276)
        Me.ValorizacionPresuntaToggle.Name = "ValorizacionPresuntaToggle"
        Me.ValorizacionPresuntaToggle.Size = New System.Drawing.Size(111, 24)
        Me.ValorizacionPresuntaToggle.TabIndex = 8
        Me.ValorizacionPresuntaToggle.Text = "On"
        '
        'UitLabel1
        '
        Me.UitLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ParametrosCalculoBindingSource, "Uit", True))
        Me.UitLabel1.Location = New System.Drawing.Point(337, 155)
        Me.UitLabel1.Name = "UitLabel1"
        Me.UitLabel1.Size = New System.Drawing.Size(117, 26)
        Me.UitLabel1.TabIndex = 34
        Me.UitLabel1.Text = "Label7"
        '
        'DeduccionTextBox
        '
        Me.DeduccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "Deduccion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.DeduccionTextBox.Location = New System.Drawing.Point(519, 341)
        Me.DeduccionTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DeduccionTextBox.Name = "DeduccionTextBox"
        Me.DeduccionTextBox.Size = New System.Drawing.Size(111, 23)
        Me.DeduccionTextBox.TabIndex = 35
        '
        'BaseImponibleTextBox
        '
        Me.BaseImponibleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "BaseImponible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2"))
        Me.BaseImponibleTextBox.Location = New System.Drawing.Point(519, 310)
        Me.BaseImponibleTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BaseImponibleTextBox.Name = "BaseImponibleTextBox"
        Me.BaseImponibleTextBox.Size = New System.Drawing.Size(111, 23)
        Me.BaseImponibleTextBox.TabIndex = 15
        Me.BaseImponibleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AñoComboBox
        '
        Me.AñoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ParametrosCalculoBindingSource, "Año", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AñoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AñoComboBox.FormattingEnabled = True
        Me.AñoComboBox.Location = New System.Drawing.Point(129, 155)
        Me.AñoComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AñoComboBox.Name = "AñoComboBox"
        Me.AñoComboBox.Size = New System.Drawing.Size(55, 23)
        Me.AñoComboBox.TabIndex = 32
        '
        'BaseImponibleTotalTextBox
        '
        Me.BaseImponibleTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "BaseImponibleTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.BaseImponibleTotalTextBox.Location = New System.Drawing.Point(519, 372)
        Me.BaseImponibleTotalTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BaseImponibleTotalTextBox.Name = "BaseImponibleTotalTextBox"
        Me.BaseImponibleTotalTextBox.Size = New System.Drawing.Size(111, 23)
        Me.BaseImponibleTotalTextBox.TabIndex = 36
        Me.BaseImponibleTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label22, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ImpuestoTextBox, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ImpuestoTramo3TextBox, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.CuotaTrimestralTextBox, 4, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.ImpuestoTramo2TextBox, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ImpuestoTramo1TextBox, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.BaseImponibleTramo3TextBox, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.BaseImponibleTramo1TextBox, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BaseImponibleTramo2TextBox, 3, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 58)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(80, 191)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'Label22
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label22, 2)
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(328, 169)
        Me.Label22.Margin = New System.Windows.Forms.Padding(0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(176, 23)
        Me.Label22.TabIndex = 52
        Me.Label22.Tag = ""
        Me.Label22.Text = "Cuota Trimestral"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label18, 2)
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(328, 145)
        Me.Label18.Margin = New System.Windows.Forms.Padding(0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(176, 23)
        Me.Label18.TabIndex = 48
        Me.Label18.Tag = ""
        Me.Label18.Text = "Impuesto Anual"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Location = New System.Drawing.Point(328, 73)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 23)
        Me.Label13.TabIndex = 43
        Me.Label13.Tag = ""
        Me.Label13.Text = "0.2%"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(131, 73)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 23)
        Me.Label9.TabIndex = 40
        Me.Label9.Tag = ""
        Me.Label9.Text = "Hasta XXXXX"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(131, 49)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(196, 23)
        Me.Label10.TabIndex = 39
        Me.Label10.Tag = ""
        Me.Label10.Text = "En  S/ (UIT 2016 = 3,950)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(505, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label8, 2)
        Me.Label8.Size = New System.Drawing.Size(154, 47)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Impuesto (S/)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(387, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label7, 2)
        Me.Label7.Size = New System.Drawing.Size(117, 47)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Base Imponible por tramo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(1, 49)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 23)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "En UIT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImpuestoTextBox
        '
        Me.ImpuestoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ImpuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "Impuesto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ImpuestoTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImpuestoTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpuestoTextBox.Location = New System.Drawing.Point(508, 149)
        Me.ImpuestoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ImpuestoTextBox.Name = "ImpuestoTextBox"
        Me.ImpuestoTextBox.ReadOnly = True
        Me.ImpuestoTextBox.Size = New System.Drawing.Size(148, 15)
        Me.ImpuestoTextBox.TabIndex = 29
        Me.ImpuestoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label5, 2)
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(1, 1)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label5, 2)
        Me.Label5.Size = New System.Drawing.Size(326, 47)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Tramo de Autoavalúo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(1, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 23)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Hasta 15"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImpuestoTramo3TextBox
        '
        Me.ImpuestoTramo3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ImpuestoTramo3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "ImpuestoTramo3", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ImpuestoTramo3TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImpuestoTramo3TextBox.Location = New System.Drawing.Point(508, 125)
        Me.ImpuestoTramo3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ImpuestoTramo3TextBox.Name = "ImpuestoTramo3TextBox"
        Me.ImpuestoTramo3TextBox.ReadOnly = True
        Me.ImpuestoTramo3TextBox.Size = New System.Drawing.Size(148, 16)
        Me.ImpuestoTramo3TextBox.TabIndex = 27
        Me.ImpuestoTramo3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(1, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Más de 15 y hasta 60"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(1, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Más de 60"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CuotaTrimestralTextBox
        '
        Me.CuotaTrimestralTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CuotaTrimestralTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "CuotaTrimestral", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.CuotaTrimestralTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuotaTrimestralTextBox.Location = New System.Drawing.Point(508, 173)
        Me.CuotaTrimestralTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CuotaTrimestralTextBox.Name = "CuotaTrimestralTextBox"
        Me.CuotaTrimestralTextBox.ReadOnly = True
        Me.CuotaTrimestralTextBox.Size = New System.Drawing.Size(112, 15)
        Me.CuotaTrimestralTextBox.TabIndex = 16
        '
        'ImpuestoTramo2TextBox
        '
        Me.ImpuestoTramo2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ImpuestoTramo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "ImpuestoTramo2", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ImpuestoTramo2TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImpuestoTramo2TextBox.Location = New System.Drawing.Point(508, 101)
        Me.ImpuestoTramo2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ImpuestoTramo2TextBox.Name = "ImpuestoTramo2TextBox"
        Me.ImpuestoTramo2TextBox.ReadOnly = True
        Me.ImpuestoTramo2TextBox.Size = New System.Drawing.Size(148, 16)
        Me.ImpuestoTramo2TextBox.TabIndex = 25
        Me.ImpuestoTramo2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(328, 1)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label4, 3)
        Me.Label4.Size = New System.Drawing.Size(58, 71)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Alicuota"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(131, 97)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 23)
        Me.Label11.TabIndex = 41
        Me.Label11.Tag = ""
        Me.Label11.Text = "Hasta XXXXX y xxxxxxxx"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImpuestoTramo1TextBox
        '
        Me.ImpuestoTramo1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ImpuestoTramo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "ImpuestoTramo1", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.ImpuestoTramo1TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImpuestoTramo1TextBox.Location = New System.Drawing.Point(508, 77)
        Me.ImpuestoTramo1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ImpuestoTramo1TextBox.Name = "ImpuestoTramo1TextBox"
        Me.ImpuestoTramo1TextBox.ReadOnly = True
        Me.ImpuestoTramo1TextBox.Size = New System.Drawing.Size(148, 16)
        Me.ImpuestoTramo1TextBox.TabIndex = 23
        Me.ImpuestoTramo1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(131, 121)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(196, 23)
        Me.Label12.TabIndex = 42
        Me.Label12.Tag = ""
        Me.Label12.Text = "Hasta XXXXX"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Location = New System.Drawing.Point(328, 97)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 23)
        Me.Label14.TabIndex = 44
        Me.Label14.Tag = ""
        Me.Label14.Text = "0.6%"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BaseImponibleTramo3TextBox
        '
        Me.BaseImponibleTramo3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BaseImponibleTramo3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "BaseImponibleTramo3", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.BaseImponibleTramo3TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaseImponibleTramo3TextBox.Location = New System.Drawing.Point(390, 125)
        Me.BaseImponibleTramo3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BaseImponibleTramo3TextBox.Name = "BaseImponibleTramo3TextBox"
        Me.BaseImponibleTramo3TextBox.ReadOnly = True
        Me.BaseImponibleTramo3TextBox.Size = New System.Drawing.Size(111, 16)
        Me.BaseImponibleTramo3TextBox.TabIndex = 21
        Me.BaseImponibleTramo3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Location = New System.Drawing.Point(328, 121)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 23)
        Me.Label15.TabIndex = 45
        Me.Label15.Tag = ""
        Me.Label15.Text = "1%"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BaseImponibleTramo1TextBox
        '
        Me.BaseImponibleTramo1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BaseImponibleTramo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "BaseImponibleTramo1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.BaseImponibleTramo1TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaseImponibleTramo1TextBox.Location = New System.Drawing.Point(390, 77)
        Me.BaseImponibleTramo1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BaseImponibleTramo1TextBox.Name = "BaseImponibleTramo1TextBox"
        Me.BaseImponibleTramo1TextBox.ReadOnly = True
        Me.BaseImponibleTramo1TextBox.Size = New System.Drawing.Size(111, 16)
        Me.BaseImponibleTramo1TextBox.TabIndex = 19
        Me.BaseImponibleTramo1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BaseImponibleTramo2TextBox
        '
        Me.BaseImponibleTramo2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BaseImponibleTramo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "BaseImponibleTramo2", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.BaseImponibleTramo2TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaseImponibleTramo2TextBox.Location = New System.Drawing.Point(390, 101)
        Me.BaseImponibleTramo2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BaseImponibleTramo2TextBox.Name = "BaseImponibleTramo2TextBox"
        Me.BaseImponibleTramo2TextBox.ReadOnly = True
        Me.BaseImponibleTramo2TextBox.Size = New System.Drawing.Size(111, 16)
        Me.BaseImponibleTramo2TextBox.TabIndex = 20
        Me.BaseImponibleTramo2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrediosDataGridView
        '
        Me.PrediosDataGridView.AllowUserToAddRows = False
        Me.PrediosDataGridView.AllowUserToDeleteRows = False
        Me.PrediosDataGridView.AllowUserToResizeColumns = False
        Me.PrediosDataGridView.AllowUserToResizeRows = False
        Me.PrediosDataGridView.AutoGenerateColumns = False
        Me.PrediosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PrediosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.PrediosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrediosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnexoDataGridViewTextBoxColumn, Me.DescPredioDataGridViewTextBoxColumn})
        Me.PrediosDataGridView.DataSource = Me.PrediosBindingSource
        Me.PrediosDataGridView.Location = New System.Drawing.Point(588, 23)
        Me.PrediosDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PrediosDataGridView.MultiSelect = False
        Me.PrediosDataGridView.Name = "PrediosDataGridView"
        Me.PrediosDataGridView.ReadOnly = True
        Me.PrediosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.PrediosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PrediosDataGridView.ShowCellErrors = False
        Me.PrediosDataGridView.ShowEditingIcon = False
        Me.PrediosDataGridView.ShowRowErrors = False
        Me.PrediosDataGridView.Size = New System.Drawing.Size(527, 116)
        Me.PrediosDataGridView.TabIndex = 18
        '
        'PrediosBindingSource
        '
        Me.PrediosBindingSource.AllowNew = False
        Me.PrediosBindingSource.DataMember = "Predios"
        Me.PrediosBindingSource.DataSource = Me.HojaResumenBindingSource
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.PrediosBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(588, 143)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(212, 25)
        Me.BindingNavigator1.TabIndex = 15
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
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
        'CondicionEspecialContribuyenteComboBox
        '
        Me.CondicionEspecialContribuyenteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HojaResumenBindingSource, "CondicionEspecialContribuyente", True))
        Me.CondicionEspecialContribuyenteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CondicionEspecialContribuyenteComboBox.FormattingEnabled = True
        Me.CondicionEspecialContribuyenteComboBox.Location = New System.Drawing.Point(271, 32)
        Me.CondicionEspecialContribuyenteComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CondicionEspecialContribuyenteComboBox.Name = "CondicionEspecialContribuyenteComboBox"
        Me.CondicionEspecialContribuyenteComboBox.Size = New System.Drawing.Size(141, 23)
        Me.CondicionEspecialContribuyenteComboBox.TabIndex = 14
        '
        'AgregarPrBtn
        '
        Me.AgregarPrBtn.Image = Global.SimuImpPred.Gui.My.Resources.Resources.NewPr
        Me.AgregarPrBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AgregarPrBtn.Location = New System.Drawing.Point(744, 176)
        Me.AgregarPrBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AgregarPrBtn.Name = "AgregarPrBtn"
        Me.AgregarPrBtn.Size = New System.Drawing.Size(148, 47)
        Me.AgregarPrBtn.TabIndex = 13
        Me.AgregarPrBtn.Text = "Agregar Predio Rústico"
        Me.AgregarPrBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AgregarPrBtn.UseVisualStyleBackColor = True
        '
        'AgregarPuBtn
        '
        Me.AgregarPuBtn.Image = Global.SimuImpPred.Gui.My.Resources.Resources.NewPu
        Me.AgregarPuBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AgregarPuBtn.Location = New System.Drawing.Point(588, 176)
        Me.AgregarPuBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AgregarPuBtn.Name = "AgregarPuBtn"
        Me.AgregarPuBtn.Size = New System.Drawing.Size(148, 47)
        Me.AgregarPuBtn.TabIndex = 12
        Me.AgregarPuBtn.Text = "Agregar Predio Urbano"
        Me.AgregarPuBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AgregarPuBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(487, 58)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(487, 23)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable
        Me.MetroLabel1.Location = New System.Drawing.Point(744, 314)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(24, 19)
        Me.MetroLabel1.TabIndex = 37
        Me.MetroLabel1.Text = "jjjjj"
        '
        'HojaResumenBindingSource
        '
        Me.HojaResumenBindingSource.DataSource = GetType(SimuImpPred.ObjectModel.HojaResumen)
        '
        'ParametrosCalculoBindingSource
        '
        Me.ParametrosCalculoBindingSource.DataSource = GetType(SimuImpPred.ObjectModel.ParametrosCalculo)
        '
        'AnexoDataGridViewTextBoxColumn
        '
        Me.AnexoDataGridViewTextBoxColumn.DataPropertyName = "Anexo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.AnexoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.AnexoDataGridViewTextBoxColumn.HeaderText = "Anexo"
        Me.AnexoDataGridViewTextBoxColumn.Name = "AnexoDataGridViewTextBoxColumn"
        Me.AnexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnexoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AnexoDataGridViewTextBoxColumn.Width = 46
        '
        'DescPredioDataGridViewTextBoxColumn
        '
        Me.DescPredioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescPredioDataGridViewTextBoxColumn.DataPropertyName = "DescPredio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DescPredioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DescPredioDataGridViewTextBoxColumn.HeaderText = "Predio"
        Me.DescPredioDataGridViewTextBoxColumn.Name = "DescPredioDataGridViewTextBoxColumn"
        Me.DescPredioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 635)
        Me.Controls.Add(Me.ToolStripContainer)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PrediosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrediosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.HojaResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParametrosCalculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HojaResumenBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AgregarPrBtn As Button
    Friend WithEvents AgregarPuBtn As Button
    Friend WithEvents PrediosBindingSource As BindingSource
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents CondicionEspecialContribuyenteComboBox As ComboBox
    Friend WithEvents CuotaTrimestralTextBox As TextBox
    Friend WithEvents PrediosDataGridView As DataGridView
    Friend WithEvents AnexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescPredioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoTextBox As TextBox
    Friend WithEvents ImpuestoTramo3TextBox As TextBox
    Friend WithEvents ImpuestoTramo2TextBox As TextBox
    Friend WithEvents ImpuestoTramo1TextBox As TextBox
    Friend WithEvents BaseImponibleTramo3TextBox As TextBox
    Friend WithEvents BaseImponibleTramo2TextBox As TextBox
    Friend WithEvents BaseImponibleTramo1TextBox As TextBox
    Friend WithEvents UitLabel1 As Label
    Friend WithEvents ParametrosCalculoBindingSource As BindingSource
    Friend WithEvents AñoComboBox As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents BaseImponibleTotalTextBox As MetroTextBox
    Friend WithEvents DeduccionTextBox As TextBox
    Friend WithEvents ValorizacionPresuntaToggle As MetroFramework.Controls.MetroToggle
    Friend WithEvents BaseImponibleTextBox As MetroTextBox
    Friend WithEvents MetroLabel1 As MetroLabel
End Class
