<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DomicilioFiscalDlg
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
        Dim CodDepLabel As System.Windows.Forms.Label
        Dim CodDisLabel As System.Windows.Forms.Label
        Dim CodProvLabel As System.Windows.Forms.Label
        Dim TipoHabilitacionLabel As System.Windows.Forms.Label
        Dim HabilitacionLabel As System.Windows.Forms.Label
        Dim MzLabel As System.Windows.Forms.Label
        Dim LoteLabel As System.Windows.Forms.Label
        Dim TipoViaLabel As System.Windows.Forms.Label
        Dim ViaLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim NumeroAlternoLabel As System.Windows.Forms.Label
        Dim DptoLabel As System.Windows.Forms.Label
        Dim BlockLabel As System.Windows.Forms.Label
        Dim InteriorLabel As System.Windows.Forms.Label
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim TelefonosLabel As System.Windows.Forms.Label
        Dim CorreosElectronicosLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.HojaResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodDepComboBox = New System.Windows.Forms.ComboBox()
        Me.UDepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodDisComboBox = New System.Windows.Forms.ComboBox()
        Me.DistritosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodProvComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TipoHabilitacionComboBox = New System.Windows.Forms.ComboBox()
        Me.HabilitacionTextBox = New System.Windows.Forms.TextBox()
        Me.MzTextBox = New System.Windows.Forms.TextBox()
        Me.LoteTextBox = New System.Windows.Forms.TextBox()
        Me.TipoViaComboBox = New System.Windows.Forms.ComboBox()
        Me.ViaTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroAlternoTextBox = New System.Windows.Forms.TextBox()
        Me.DptoTextBox = New System.Windows.Forms.TextBox()
        Me.BlockTextBox = New System.Windows.Forms.TextBox()
        Me.InteriorTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnEditCorreos = New System.Windows.Forms.Button()
        Me.CorreosElectronicosTextBox = New System.Windows.Forms.TextBox()
        Me.BtnEditTelefonos = New System.Windows.Forms.Button()
        Me.TelefonosTextBox = New System.Windows.Forms.TextBox()
        CodDepLabel = New System.Windows.Forms.Label()
        CodDisLabel = New System.Windows.Forms.Label()
        CodProvLabel = New System.Windows.Forms.Label()
        TipoHabilitacionLabel = New System.Windows.Forms.Label()
        HabilitacionLabel = New System.Windows.Forms.Label()
        MzLabel = New System.Windows.Forms.Label()
        LoteLabel = New System.Windows.Forms.Label()
        TipoViaLabel = New System.Windows.Forms.Label()
        ViaLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        NumeroAlternoLabel = New System.Windows.Forms.Label()
        DptoLabel = New System.Windows.Forms.Label()
        BlockLabel = New System.Windows.Forms.Label()
        InteriorLabel = New System.Windows.Forms.Label()
        ReferenciaLabel = New System.Windows.Forms.Label()
        TelefonosLabel = New System.Windows.Forms.Label()
        CorreosElectronicosLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.HojaResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UDepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistritosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodDepLabel
        '
        CodDepLabel.AutoSize = True
        CodDepLabel.Location = New System.Drawing.Point(6, 16)
        CodDepLabel.Name = "CodDepLabel"
        CodDepLabel.Size = New System.Drawing.Size(77, 13)
        CodDepLabel.TabIndex = 0
        CodDepLabel.Text = "Departamento:"
        '
        'CodDisLabel
        '
        CodDisLabel.AutoSize = True
        CodDisLabel.Location = New System.Drawing.Point(349, 16)
        CodDisLabel.Name = "CodDisLabel"
        CodDisLabel.Size = New System.Drawing.Size(42, 13)
        CodDisLabel.TabIndex = 4
        CodDisLabel.Text = "Distrito:"
        '
        'CodProvLabel
        '
        CodProvLabel.AutoSize = True
        CodProvLabel.Location = New System.Drawing.Point(176, 16)
        CodProvLabel.Name = "CodProvLabel"
        CodProvLabel.Size = New System.Drawing.Size(54, 13)
        CodProvLabel.TabIndex = 2
        CodProvLabel.Text = "Provincia:"
        '
        'TipoHabilitacionLabel
        '
        TipoHabilitacionLabel.AutoSize = True
        TipoHabilitacionLabel.Location = New System.Drawing.Point(6, 16)
        TipoHabilitacionLabel.Name = "TipoHabilitacionLabel"
        TipoHabilitacionLabel.Size = New System.Drawing.Size(89, 13)
        TipoHabilitacionLabel.TabIndex = 0
        TipoHabilitacionLabel.Text = "Tipo Habilitacion:"
        '
        'HabilitacionLabel
        '
        HabilitacionLabel.AutoSize = True
        HabilitacionLabel.Location = New System.Drawing.Point(201, 16)
        HabilitacionLabel.Name = "HabilitacionLabel"
        HabilitacionLabel.Size = New System.Drawing.Size(65, 13)
        HabilitacionLabel.TabIndex = 2
        HabilitacionLabel.Text = "Habilitacion:"
        '
        'MzLabel
        '
        MzLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        MzLabel.AutoSize = True
        MzLabel.Location = New System.Drawing.Point(428, 16)
        MzLabel.Name = "MzLabel"
        MzLabel.Size = New System.Drawing.Size(24, 13)
        MzLabel.TabIndex = 4
        MzLabel.Text = "Mz:"
        '
        'LoteLabel
        '
        LoteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        LoteLabel.AutoSize = True
        LoteLabel.Location = New System.Drawing.Point(474, 16)
        LoteLabel.Name = "LoteLabel"
        LoteLabel.Size = New System.Drawing.Size(31, 13)
        LoteLabel.TabIndex = 6
        LoteLabel.Text = "Lote:"
        '
        'TipoViaLabel
        '
        TipoViaLabel.AutoSize = True
        TipoViaLabel.Location = New System.Drawing.Point(6, 56)
        TipoViaLabel.Name = "TipoViaLabel"
        TipoViaLabel.Size = New System.Drawing.Size(49, 13)
        TipoViaLabel.TabIndex = 8
        TipoViaLabel.Text = "Tipo Via:"
        '
        'ViaLabel
        '
        ViaLabel.AutoSize = True
        ViaLabel.Location = New System.Drawing.Point(130, 56)
        ViaLabel.Name = "ViaLabel"
        ViaLabel.Size = New System.Drawing.Size(25, 13)
        ViaLabel.TabIndex = 10
        ViaLabel.Text = "Via:"
        '
        'NumeroLabel
        '
        NumeroLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(392, 56)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(47, 13)
        NumeroLabel.TabIndex = 12
        NumeroLabel.Text = "Numero:"
        '
        'NumeroAlternoLabel
        '
        NumeroAlternoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NumeroAlternoLabel.AutoSize = True
        NumeroAlternoLabel.Location = New System.Drawing.Point(456, 56)
        NumeroAlternoLabel.Name = "NumeroAlternoLabel"
        NumeroAlternoLabel.Size = New System.Drawing.Size(47, 13)
        NumeroAlternoLabel.TabIndex = 14
        NumeroAlternoLabel.Text = "Num Alt:"
        '
        'DptoLabel
        '
        DptoLabel.AutoSize = True
        DptoLabel.Location = New System.Drawing.Point(72, 96)
        DptoLabel.Name = "DptoLabel"
        DptoLabel.Size = New System.Drawing.Size(33, 13)
        DptoLabel.TabIndex = 18
        DptoLabel.Text = "Dpto:"
        '
        'BlockLabel
        '
        BlockLabel.AutoSize = True
        BlockLabel.Location = New System.Drawing.Point(6, 96)
        BlockLabel.Name = "BlockLabel"
        BlockLabel.Size = New System.Drawing.Size(37, 13)
        BlockLabel.TabIndex = 16
        BlockLabel.Text = "Block:"
        '
        'InteriorLabel
        '
        InteriorLabel.AutoSize = True
        InteriorLabel.Location = New System.Drawing.Point(143, 96)
        InteriorLabel.Name = "InteriorLabel"
        InteriorLabel.Size = New System.Drawing.Size(42, 13)
        InteriorLabel.TabIndex = 20
        InteriorLabel.Text = "Interior:"
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.Location = New System.Drawing.Point(246, 96)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(62, 13)
        ReferenciaLabel.TabIndex = 22
        ReferenciaLabel.Text = "Referencia:"
        '
        'TelefonosLabel
        '
        TelefonosLabel.AutoSize = True
        TelefonosLabel.Location = New System.Drawing.Point(6, 16)
        TelefonosLabel.Name = "TelefonosLabel"
        TelefonosLabel.Size = New System.Drawing.Size(57, 13)
        TelefonosLabel.TabIndex = 0
        TelefonosLabel.Text = "Telefonos:"
        '
        'CorreosElectronicosLabel
        '
        CorreosElectronicosLabel.AutoSize = True
        CorreosElectronicosLabel.Location = New System.Drawing.Point(6, 55)
        CorreosElectronicosLabel.Name = "CorreosElectronicosLabel"
        CorreosElectronicosLabel.Size = New System.Drawing.Size(107, 13)
        CorreosElectronicosLabel.TabIndex = 3
        CorreosElectronicosLabel.Text = "Correos Electronicos:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(381, 342)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'HojaResumenBindingSource
        '
        Me.HojaResumenBindingSource.DataSource = GetType(SimuImpPred.ObjectModel.HojaResumen)
        '
        'CodDepComboBox
        '
        Me.CodDepComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HojaResumenBindingSource, "DomicilioFiscal.CodDep", True))
        Me.CodDepComboBox.DataSource = Me.UDepBindingSource
        Me.CodDepComboBox.DisplayMember = "Dep"
        Me.CodDepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CodDepComboBox.FormattingEnabled = True
        Me.CodDepComboBox.Location = New System.Drawing.Point(6, 32)
        Me.CodDepComboBox.Name = "CodDepComboBox"
        Me.CodDepComboBox.Size = New System.Drawing.Size(167, 21)
        Me.CodDepComboBox.TabIndex = 1
        Me.CodDepComboBox.ValueMember = "CodDep"
        '
        'UDepBindingSource
        '
        Me.UDepBindingSource.DataSource = GetType(SimuImpPred.Data.UDep)
        '
        'CodDisComboBox
        '
        Me.CodDisComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CodDisComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HojaResumenBindingSource, "DomicilioFiscal.CodDis", True))
        Me.CodDisComboBox.DataSource = Me.DistritosBindingSource
        Me.CodDisComboBox.DisplayMember = "Dis"
        Me.CodDisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CodDisComboBox.FormattingEnabled = True
        Me.CodDisComboBox.Location = New System.Drawing.Point(352, 32)
        Me.CodDisComboBox.Name = "CodDisComboBox"
        Me.CodDisComboBox.Size = New System.Drawing.Size(165, 21)
        Me.CodDisComboBox.TabIndex = 5
        Me.CodDisComboBox.ValueMember = "CodDis"
        '
        'DistritosBindingSource
        '
        Me.DistritosBindingSource.DataMember = "Distritos"
        Me.DistritosBindingSource.DataSource = Me.ProvinciasBindingSource
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "Provincias"
        Me.ProvinciasBindingSource.DataSource = Me.UDepBindingSource
        '
        'CodProvComboBox
        '
        Me.CodProvComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HojaResumenBindingSource, "DomicilioFiscal.CodProv", True))
        Me.CodProvComboBox.DataSource = Me.ProvinciasBindingSource
        Me.CodProvComboBox.DisplayMember = "Prov"
        Me.CodProvComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CodProvComboBox.FormattingEnabled = True
        Me.CodProvComboBox.Location = New System.Drawing.Point(179, 32)
        Me.CodProvComboBox.Name = "CodProvComboBox"
        Me.CodProvComboBox.Size = New System.Drawing.Size(167, 21)
        Me.CodProvComboBox.TabIndex = 3
        Me.CodProvComboBox.ValueMember = "CodProv"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(CodDepLabel)
        Me.GroupBox1.Controls.Add(Me.CodDepComboBox)
        Me.GroupBox1.Controls.Add(CodProvLabel)
        Me.GroupBox1.Controls.Add(Me.CodProvComboBox)
        Me.GroupBox1.Controls.Add(CodDisLabel)
        Me.GroupBox1.Controls.Add(Me.CodDisComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubigeo"
        '
        'TipoHabilitacionComboBox
        '
        Me.TipoHabilitacionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HojaResumenBindingSource, "DomicilioFiscal.Direccion.TipoHabilitacion", True))
        Me.TipoHabilitacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoHabilitacionComboBox.FormattingEnabled = True
        Me.TipoHabilitacionComboBox.Location = New System.Drawing.Point(6, 32)
        Me.TipoHabilitacionComboBox.Name = "TipoHabilitacionComboBox"
        Me.TipoHabilitacionComboBox.Size = New System.Drawing.Size(192, 21)
        Me.TipoHabilitacionComboBox.TabIndex = 1
        '
        'HabilitacionTextBox
        '
        Me.HabilitacionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HabilitacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DomicilioFiscal.Direccion.Habilitacion", True))
        Me.HabilitacionTextBox.Location = New System.Drawing.Point(204, 32)
        Me.HabilitacionTextBox.Name = "HabilitacionTextBox"
        Me.HabilitacionTextBox.Size = New System.Drawing.Size(221, 20)
        Me.HabilitacionTextBox.TabIndex = 3
        '
        'MzTextBox
        '
        Me.MzTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DomicilioFiscal.Direccion.Mz", True))
        Me.MzTextBox.Location = New System.Drawing.Point(431, 32)
        Me.MzTextBox.Name = "MzTextBox"
        Me.MzTextBox.Size = New System.Drawing.Size(40, 20)
        Me.MzTextBox.TabIndex = 5
        '
        'LoteTextBox
        '
        Me.LoteTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DomicilioFiscal.Direccion.Lote", True))
        Me.LoteTextBox.Location = New System.Drawing.Point(477, 32)
        Me.LoteTextBox.Name = "LoteTextBox"
        Me.LoteTextBox.Size = New System.Drawing.Size(40, 20)
        Me.LoteTextBox.TabIndex = 7
        '
        'TipoViaComboBox
        '
        Me.TipoViaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HojaResumenBindingSource, "DomicilioFiscal.Direccion.TipoVia", True))
        Me.TipoViaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoViaComboBox.FormattingEnabled = True
        Me.TipoViaComboBox.Location = New System.Drawing.Point(6, 72)
        Me.TipoViaComboBox.Name = "TipoViaComboBox"
        Me.TipoViaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TipoViaComboBox.TabIndex = 9
        '
        'ViaTextBox
        '
        Me.ViaTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DomicilioFiscal.Direccion.Via", True))
        Me.ViaTextBox.Location = New System.Drawing.Point(133, 72)
        Me.ViaTextBox.Name = "ViaTextBox"
        Me.ViaTextBox.Size = New System.Drawing.Size(256, 20)
        Me.ViaTextBox.TabIndex = 11
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DomicilioFiscal.Direccion.Numero", True))
        Me.NumeroTextBox.Location = New System.Drawing.Point(395, 72)
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(58, 20)
        Me.NumeroTextBox.TabIndex = 13
        '
        'NumeroAlternoTextBox
        '
        Me.NumeroAlternoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumeroAlternoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DomicilioFiscal.Direccion.NumeroAlterno", True))
        Me.NumeroAlternoTextBox.Location = New System.Drawing.Point(459, 72)
        Me.NumeroAlternoTextBox.Name = "NumeroAlternoTextBox"
        Me.NumeroAlternoTextBox.Size = New System.Drawing.Size(58, 20)
        Me.NumeroAlternoTextBox.TabIndex = 15
        '
        'DptoTextBox
        '
        Me.DptoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DomicilioFiscal.Direccion.Dpto", True))
        Me.DptoTextBox.Location = New System.Drawing.Point(71, 112)
        Me.DptoTextBox.Name = "DptoTextBox"
        Me.DptoTextBox.Size = New System.Drawing.Size(66, 20)
        Me.DptoTextBox.TabIndex = 19
        '
        'BlockTextBox
        '
        Me.BlockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DomicilioFiscal.Direccion.Block", True))
        Me.BlockTextBox.Location = New System.Drawing.Point(6, 112)
        Me.BlockTextBox.Name = "BlockTextBox"
        Me.BlockTextBox.Size = New System.Drawing.Size(59, 20)
        Me.BlockTextBox.TabIndex = 17
        '
        'InteriorTextBox
        '
        Me.InteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DomicilioFiscal.Direccion.Interior", True))
        Me.InteriorTextBox.Location = New System.Drawing.Point(143, 112)
        Me.InteriorTextBox.Name = "InteriorTextBox"
        Me.InteriorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InteriorTextBox.TabIndex = 21
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DomicilioFiscal.Referencia", True))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(249, 112)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(268, 20)
        Me.ReferenciaTextBox.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TipoHabilitacionComboBox)
        Me.GroupBox2.Controls.Add(Me.ReferenciaTextBox)
        Me.GroupBox2.Controls.Add(ReferenciaLabel)
        Me.GroupBox2.Controls.Add(TipoHabilitacionLabel)
        Me.GroupBox2.Controls.Add(HabilitacionLabel)
        Me.GroupBox2.Controls.Add(Me.InteriorTextBox)
        Me.GroupBox2.Controls.Add(InteriorLabel)
        Me.GroupBox2.Controls.Add(Me.HabilitacionTextBox)
        Me.GroupBox2.Controls.Add(MzLabel)
        Me.GroupBox2.Controls.Add(Me.DptoTextBox)
        Me.GroupBox2.Controls.Add(DptoLabel)
        Me.GroupBox2.Controls.Add(Me.BlockTextBox)
        Me.GroupBox2.Controls.Add(BlockLabel)
        Me.GroupBox2.Controls.Add(Me.MzTextBox)
        Me.GroupBox2.Controls.Add(LoteLabel)
        Me.GroupBox2.Controls.Add(Me.LoteTextBox)
        Me.GroupBox2.Controls.Add(TipoViaLabel)
        Me.GroupBox2.Controls.Add(NumeroAlternoLabel)
        Me.GroupBox2.Controls.Add(Me.TipoViaComboBox)
        Me.GroupBox2.Controls.Add(NumeroLabel)
        Me.GroupBox2.Controls.Add(Me.NumeroAlternoTextBox)
        Me.GroupBox2.Controls.Add(Me.NumeroTextBox)
        Me.GroupBox2.Controls.Add(Me.ViaTextBox)
        Me.GroupBox2.Controls.Add(ViaLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 141)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dirección"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.BtnEditCorreos)
        Me.GroupBox3.Controls.Add(CorreosElectronicosLabel)
        Me.GroupBox3.Controls.Add(Me.CorreosElectronicosTextBox)
        Me.GroupBox3.Controls.Add(Me.BtnEditTelefonos)
        Me.GroupBox3.Controls.Add(TelefonosLabel)
        Me.GroupBox3.Controls.Add(Me.TelefonosTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(523, 108)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contacto"
        '
        'BtnEditCorreos
        '
        Me.BtnEditCorreos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditCorreos.Location = New System.Drawing.Point(491, 68)
        Me.BtnEditCorreos.Name = "BtnEditCorreos"
        Me.BtnEditCorreos.Size = New System.Drawing.Size(26, 23)
        Me.BtnEditCorreos.TabIndex = 5
        Me.BtnEditCorreos.Text = "..."
        Me.BtnEditCorreos.UseVisualStyleBackColor = True
        '
        'CorreosElectronicosTextBox
        '
        Me.CorreosElectronicosTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CorreosElectronicosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DomicilioFiscal.CorreosElectronicos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CorreosElectronicosTextBox.Location = New System.Drawing.Point(6, 71)
        Me.CorreosElectronicosTextBox.Name = "CorreosElectronicosTextBox"
        Me.CorreosElectronicosTextBox.ReadOnly = True
        Me.CorreosElectronicosTextBox.Size = New System.Drawing.Size(479, 20)
        Me.CorreosElectronicosTextBox.TabIndex = 4
        '
        'BtnEditTelefonos
        '
        Me.BtnEditTelefonos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditTelefonos.Location = New System.Drawing.Point(491, 30)
        Me.BtnEditTelefonos.Name = "BtnEditTelefonos"
        Me.BtnEditTelefonos.Size = New System.Drawing.Size(26, 23)
        Me.BtnEditTelefonos.TabIndex = 2
        Me.BtnEditTelefonos.Text = "..."
        Me.BtnEditTelefonos.UseVisualStyleBackColor = True
        '
        'TelefonosTextBox
        '
        Me.TelefonosTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TelefonosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DomicilioFiscal.Telefonos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TelefonosTextBox.Location = New System.Drawing.Point(6, 32)
        Me.TelefonosTextBox.Name = "TelefonosTextBox"
        Me.TelefonosTextBox.ReadOnly = True
        Me.TelefonosTextBox.Size = New System.Drawing.Size(479, 20)
        Me.TelefonosTextBox.TabIndex = 1
        '
        'DomicilioFiscalDlg
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(547, 391)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DomicilioFiscalDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Domicilio Fiscal"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.HojaResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UDepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistritosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents HojaResumenBindingSource As BindingSource
    Friend WithEvents CodDepComboBox As ComboBox
    Friend WithEvents CodDisComboBox As ComboBox
    Friend WithEvents CodProvComboBox As ComboBox
    Friend WithEvents UDepBindingSource As BindingSource
    Friend WithEvents ProvinciasBindingSource As BindingSource
    Friend WithEvents DistritosBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TipoHabilitacionComboBox As ComboBox
    Friend WithEvents HabilitacionTextBox As TextBox
    Friend WithEvents MzTextBox As TextBox
    Friend WithEvents LoteTextBox As TextBox
    Friend WithEvents TipoViaComboBox As ComboBox
    Friend WithEvents ViaTextBox As TextBox
    Friend WithEvents NumeroTextBox As TextBox
    Friend WithEvents NumeroAlternoTextBox As TextBox
    Friend WithEvents DptoTextBox As TextBox
    Friend WithEvents BlockTextBox As TextBox
    Friend WithEvents InteriorTextBox As TextBox
    Friend WithEvents ReferenciaTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnEditTelefonos As Button
    Friend WithEvents TelefonosTextBox As TextBox
    Friend WithEvents BtnEditCorreos As Button
    Friend WithEvents CorreosElectronicosTextBox As TextBox
End Class
