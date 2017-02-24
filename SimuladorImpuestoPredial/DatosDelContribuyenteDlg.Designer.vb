<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosDelContribuyenteDlg
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CodContribuyenteLabel As System.Windows.Forms.Label
        Dim ApeNombRazSocLabel As System.Windows.Forms.Label
        Dim NumDocIdentLabel As System.Windows.Forms.Label
        Dim ApeNombRazSocLabel1 As System.Windows.Forms.Label
        Dim NumDocIdentLabel1 As System.Windows.Forms.Label
        Dim ApeNombRazSocLabel2 As System.Windows.Forms.Label
        Dim NumDocIdentLabel2 As System.Windows.Forms.Label
        Dim TipoDocIdentLabel As System.Windows.Forms.Label
        Dim TipoDocIdentLabel1 As System.Windows.Forms.Label
        Dim TipoDocIdentLabel2 As System.Windows.Forms.Label
        Dim CondicionEspecialContribuyenteLabel As System.Windows.Forms.Label
        Dim BaseLegalLabel As System.Windows.Forms.Label
        Dim NroExpAdmLabel As System.Windows.Forms.Label
        Dim NroResAlcaldiaLabel As System.Windows.Forms.Label
        Dim SueldoPensionistaLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.HojaResumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodContribuyenteTextBox = New System.Windows.Forms.TextBox()
        Me.ApeNombRazSocTextBox = New System.Windows.Forms.TextBox()
        Me.NumDocIdentTextBox = New System.Windows.Forms.TextBox()
        Me.ApeNombRazSocTextBox1 = New System.Windows.Forms.TextBox()
        Me.NumDocIdentTextBox1 = New System.Windows.Forms.TextBox()
        Me.ApeNombRazSocTextBox2 = New System.Windows.Forms.TextBox()
        Me.NumDocIdentTextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TipoDocIdentComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TipoDocIdentComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TipoDocIdentComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SueldoPensionistaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.FechaResAlcaldiaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NroResAlcaldiaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaExpAdmDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NroExpAdmTextBox = New System.Windows.Forms.TextBox()
        Me.BaseLegalTextBox = New System.Windows.Forms.TextBox()
        Me.CondicionEspecialContribuyenteComboBox = New System.Windows.Forms.ComboBox()
        CodContribuyenteLabel = New System.Windows.Forms.Label()
        ApeNombRazSocLabel = New System.Windows.Forms.Label()
        NumDocIdentLabel = New System.Windows.Forms.Label()
        ApeNombRazSocLabel1 = New System.Windows.Forms.Label()
        NumDocIdentLabel1 = New System.Windows.Forms.Label()
        ApeNombRazSocLabel2 = New System.Windows.Forms.Label()
        NumDocIdentLabel2 = New System.Windows.Forms.Label()
        TipoDocIdentLabel = New System.Windows.Forms.Label()
        TipoDocIdentLabel1 = New System.Windows.Forms.Label()
        TipoDocIdentLabel2 = New System.Windows.Forms.Label()
        CondicionEspecialContribuyenteLabel = New System.Windows.Forms.Label()
        BaseLegalLabel = New System.Windows.Forms.Label()
        NroExpAdmLabel = New System.Windows.Forms.Label()
        NroResAlcaldiaLabel = New System.Windows.Forms.Label()
        SueldoPensionistaLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.HojaResumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.SueldoPensionistaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodContribuyenteLabel
        '
        CodContribuyenteLabel.AutoSize = True
        CodContribuyenteLabel.Location = New System.Drawing.Point(6, 16)
        CodContribuyenteLabel.Name = "CodContribuyenteLabel"
        CodContribuyenteLabel.Size = New System.Drawing.Size(43, 13)
        CodContribuyenteLabel.TabIndex = 0
        CodContribuyenteLabel.Text = "Codigo:"
        '
        'ApeNombRazSocLabel
        '
        ApeNombRazSocLabel.AutoSize = True
        ApeNombRazSocLabel.Location = New System.Drawing.Point(86, 16)
        ApeNombRazSocLabel.Name = "ApeNombRazSocLabel"
        ApeNombRazSocLabel.Size = New System.Drawing.Size(104, 13)
        ApeNombRazSocLabel.TabIndex = 2
        ApeNombRazSocLabel.Text = "Ape Nomb Raz Soc:"
        '
        'NumDocIdentLabel
        '
        NumDocIdentLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NumDocIdentLabel.AutoSize = True
        NumDocIdentLabel.Location = New System.Drawing.Point(475, 16)
        NumDocIdentLabel.Name = "NumDocIdentLabel"
        NumDocIdentLabel.Size = New System.Drawing.Size(47, 13)
        NumDocIdentLabel.TabIndex = 6
        NumDocIdentLabel.Text = "Número:"
        '
        'ApeNombRazSocLabel1
        '
        ApeNombRazSocLabel1.AutoSize = True
        ApeNombRazSocLabel1.Location = New System.Drawing.Point(6, 16)
        ApeNombRazSocLabel1.Name = "ApeNombRazSocLabel1"
        ApeNombRazSocLabel1.Size = New System.Drawing.Size(104, 13)
        ApeNombRazSocLabel1.TabIndex = 0
        ApeNombRazSocLabel1.Text = "Ape Nomb Raz Soc:"
        '
        'NumDocIdentLabel1
        '
        NumDocIdentLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NumDocIdentLabel1.AutoSize = True
        NumDocIdentLabel1.Location = New System.Drawing.Point(475, 16)
        NumDocIdentLabel1.Name = "NumDocIdentLabel1"
        NumDocIdentLabel1.Size = New System.Drawing.Size(47, 13)
        NumDocIdentLabel1.TabIndex = 4
        NumDocIdentLabel1.Text = "Número:"
        '
        'ApeNombRazSocLabel2
        '
        ApeNombRazSocLabel2.AutoSize = True
        ApeNombRazSocLabel2.Location = New System.Drawing.Point(6, 16)
        ApeNombRazSocLabel2.Name = "ApeNombRazSocLabel2"
        ApeNombRazSocLabel2.Size = New System.Drawing.Size(104, 13)
        ApeNombRazSocLabel2.TabIndex = 0
        ApeNombRazSocLabel2.Text = "Ape Nomb Raz Soc:"
        '
        'NumDocIdentLabel2
        '
        NumDocIdentLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NumDocIdentLabel2.AutoSize = True
        NumDocIdentLabel2.Location = New System.Drawing.Point(475, 16)
        NumDocIdentLabel2.Name = "NumDocIdentLabel2"
        NumDocIdentLabel2.Size = New System.Drawing.Size(47, 13)
        NumDocIdentLabel2.TabIndex = 4
        NumDocIdentLabel2.Text = "Número:"
        '
        'TipoDocIdentLabel
        '
        TipoDocIdentLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TipoDocIdentLabel.AutoSize = True
        TipoDocIdentLabel.Location = New System.Drawing.Point(365, 16)
        TipoDocIdentLabel.Name = "TipoDocIdentLabel"
        TipoDocIdentLabel.Size = New System.Drawing.Size(81, 13)
        TipoDocIdentLabel.TabIndex = 4
        TipoDocIdentLabel.Text = "Tipo Doc Ident:"
        '
        'TipoDocIdentLabel1
        '
        TipoDocIdentLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TipoDocIdentLabel1.AutoSize = True
        TipoDocIdentLabel1.Location = New System.Drawing.Point(365, 16)
        TipoDocIdentLabel1.Name = "TipoDocIdentLabel1"
        TipoDocIdentLabel1.Size = New System.Drawing.Size(81, 13)
        TipoDocIdentLabel1.TabIndex = 2
        TipoDocIdentLabel1.Text = "Tipo Doc Ident:"
        '
        'TipoDocIdentLabel2
        '
        TipoDocIdentLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TipoDocIdentLabel2.AutoSize = True
        TipoDocIdentLabel2.Location = New System.Drawing.Point(365, 16)
        TipoDocIdentLabel2.Name = "TipoDocIdentLabel2"
        TipoDocIdentLabel2.Size = New System.Drawing.Size(81, 13)
        TipoDocIdentLabel2.TabIndex = 2
        TipoDocIdentLabel2.Text = "Tipo Doc Ident:"
        '
        'CondicionEspecialContribuyenteLabel
        '
        CondicionEspecialContribuyenteLabel.AutoSize = True
        CondicionEspecialContribuyenteLabel.Location = New System.Drawing.Point(6, 16)
        CondicionEspecialContribuyenteLabel.Name = "CondicionEspecialContribuyenteLabel"
        CondicionEspecialContribuyenteLabel.Size = New System.Drawing.Size(168, 13)
        CondicionEspecialContribuyenteLabel.TabIndex = 0
        CondicionEspecialContribuyenteLabel.Text = "Condicion Especial Contribuyente:"
        '
        'BaseLegalLabel
        '
        BaseLegalLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BaseLegalLabel.AutoSize = True
        BaseLegalLabel.Location = New System.Drawing.Point(336, 16)
        BaseLegalLabel.Name = "BaseLegalLabel"
        BaseLegalLabel.Size = New System.Drawing.Size(63, 13)
        BaseLegalLabel.TabIndex = 2
        BaseLegalLabel.Text = "Base Legal:"
        '
        'NroExpAdmLabel
        '
        NroExpAdmLabel.AutoSize = True
        NroExpAdmLabel.Location = New System.Drawing.Point(6, 56)
        NroExpAdmLabel.Name = "NroExpAdmLabel"
        NroExpAdmLabel.Size = New System.Drawing.Size(72, 13)
        NroExpAdmLabel.TabIndex = 4
        NroExpAdmLabel.Text = "Nro Exp Adm:"
        '
        'NroResAlcaldiaLabel
        '
        NroResAlcaldiaLabel.AutoSize = True
        NroResAlcaldiaLabel.Location = New System.Drawing.Point(234, 56)
        NroResAlcaldiaLabel.Name = "NroResAlcaldiaLabel"
        NroResAlcaldiaLabel.Size = New System.Drawing.Size(89, 13)
        NroResAlcaldiaLabel.TabIndex = 8
        NroResAlcaldiaLabel.Text = "Nro Res Alcaldia:"
        '
        'SueldoPensionistaLabel
        '
        SueldoPensionistaLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        SueldoPensionistaLabel.AutoSize = True
        SueldoPensionistaLabel.Location = New System.Drawing.Point(465, 56)
        SueldoPensionistaLabel.Name = "SueldoPensionistaLabel"
        SueldoPensionistaLabel.Size = New System.Drawing.Size(100, 13)
        SueldoPensionistaLabel.TabIndex = 12
        SueldoPensionistaLabel.Text = "Sueldo Pensionista:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(439, 336)
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
        'CodContribuyenteTextBox
        '
        Me.CodContribuyenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "CodContribuyente", True))
        Me.CodContribuyenteTextBox.Location = New System.Drawing.Point(6, 32)
        Me.CodContribuyenteTextBox.Name = "CodContribuyenteTextBox"
        Me.CodContribuyenteTextBox.Size = New System.Drawing.Size(77, 20)
        Me.CodContribuyenteTextBox.TabIndex = 1
        '
        'ApeNombRazSocTextBox
        '
        Me.ApeNombRazSocTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApeNombRazSocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DatosContrib.ApeNombRazSoc", True))
        Me.ApeNombRazSocTextBox.Location = New System.Drawing.Point(89, 32)
        Me.ApeNombRazSocTextBox.Name = "ApeNombRazSocTextBox"
        Me.ApeNombRazSocTextBox.Size = New System.Drawing.Size(270, 20)
        Me.ApeNombRazSocTextBox.TabIndex = 3
        '
        'NumDocIdentTextBox
        '
        Me.NumDocIdentTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumDocIdentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DatosContrib.NumDocIdent", True))
        Me.NumDocIdentTextBox.Location = New System.Drawing.Point(478, 32)
        Me.NumDocIdentTextBox.Name = "NumDocIdentTextBox"
        Me.NumDocIdentTextBox.Size = New System.Drawing.Size(89, 20)
        Me.NumDocIdentTextBox.TabIndex = 7
        '
        'ApeNombRazSocTextBox1
        '
        Me.ApeNombRazSocTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApeNombRazSocTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DatosConyuge.ApeNombRazSoc", True))
        Me.ApeNombRazSocTextBox1.Location = New System.Drawing.Point(6, 32)
        Me.ApeNombRazSocTextBox1.Name = "ApeNombRazSocTextBox1"
        Me.ApeNombRazSocTextBox1.Size = New System.Drawing.Size(353, 20)
        Me.ApeNombRazSocTextBox1.TabIndex = 1
        '
        'NumDocIdentTextBox1
        '
        Me.NumDocIdentTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumDocIdentTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DatosConyuge.NumDocIdent", True))
        Me.NumDocIdentTextBox1.Location = New System.Drawing.Point(478, 32)
        Me.NumDocIdentTextBox1.Name = "NumDocIdentTextBox1"
        Me.NumDocIdentTextBox1.Size = New System.Drawing.Size(89, 20)
        Me.NumDocIdentTextBox1.TabIndex = 5
        '
        'ApeNombRazSocTextBox2
        '
        Me.ApeNombRazSocTextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApeNombRazSocTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DatosRepLegal.ApeNombRazSoc", True))
        Me.ApeNombRazSocTextBox2.Location = New System.Drawing.Point(6, 32)
        Me.ApeNombRazSocTextBox2.Name = "ApeNombRazSocTextBox2"
        Me.ApeNombRazSocTextBox2.Size = New System.Drawing.Size(353, 20)
        Me.ApeNombRazSocTextBox2.TabIndex = 1
        '
        'NumDocIdentTextBox2
        '
        Me.NumDocIdentTextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumDocIdentTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "DatosRepLegal.NumDocIdent", True))
        Me.NumDocIdentTextBox2.Location = New System.Drawing.Point(478, 32)
        Me.NumDocIdentTextBox2.Name = "NumDocIdentTextBox2"
        Me.NumDocIdentTextBox2.Size = New System.Drawing.Size(89, 20)
        Me.NumDocIdentTextBox2.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TipoDocIdentComboBox)
        Me.GroupBox1.Controls.Add(TipoDocIdentLabel)
        Me.GroupBox1.Controls.Add(Me.CodContribuyenteTextBox)
        Me.GroupBox1.Controls.Add(CodContribuyenteLabel)
        Me.GroupBox1.Controls.Add(ApeNombRazSocLabel)
        Me.GroupBox1.Controls.Add(Me.ApeNombRazSocTextBox)
        Me.GroupBox1.Controls.Add(NumDocIdentLabel)
        Me.GroupBox1.Controls.Add(Me.NumDocIdentTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 63)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Contribuyente"
        '
        'TipoDocIdentComboBox
        '
        Me.TipoDocIdentComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoDocIdentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HojaResumenBindingSource, "DatosContrib.TipoDocIdent", True))
        Me.TipoDocIdentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoDocIdentComboBox.FormattingEnabled = True
        Me.TipoDocIdentComboBox.Location = New System.Drawing.Point(365, 32)
        Me.TipoDocIdentComboBox.Name = "TipoDocIdentComboBox"
        Me.TipoDocIdentComboBox.Size = New System.Drawing.Size(107, 21)
        Me.TipoDocIdentComboBox.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TipoDocIdentComboBox1)
        Me.GroupBox2.Controls.Add(TipoDocIdentLabel1)
        Me.GroupBox2.Controls.Add(ApeNombRazSocLabel1)
        Me.GroupBox2.Controls.Add(Me.ApeNombRazSocTextBox1)
        Me.GroupBox2.Controls.Add(NumDocIdentLabel1)
        Me.GroupBox2.Controls.Add(Me.NumDocIdentTextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(573, 63)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Conyuge"
        '
        'TipoDocIdentComboBox1
        '
        Me.TipoDocIdentComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoDocIdentComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HojaResumenBindingSource, "DatosConyuge.TipoDocIdent", True))
        Me.TipoDocIdentComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoDocIdentComboBox1.FormattingEnabled = True
        Me.TipoDocIdentComboBox1.Location = New System.Drawing.Point(365, 32)
        Me.TipoDocIdentComboBox1.Name = "TipoDocIdentComboBox1"
        Me.TipoDocIdentComboBox1.Size = New System.Drawing.Size(107, 21)
        Me.TipoDocIdentComboBox1.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TipoDocIdentComboBox2)
        Me.GroupBox3.Controls.Add(TipoDocIdentLabel2)
        Me.GroupBox3.Controls.Add(ApeNombRazSocLabel2)
        Me.GroupBox3.Controls.Add(Me.ApeNombRazSocTextBox2)
        Me.GroupBox3.Controls.Add(NumDocIdentLabel2)
        Me.GroupBox3.Controls.Add(Me.NumDocIdentTextBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(573, 63)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Representante Legal"
        '
        'TipoDocIdentComboBox2
        '
        Me.TipoDocIdentComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoDocIdentComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HojaResumenBindingSource, "DatosRepLegal.TipoDocIdent", True))
        Me.TipoDocIdentComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoDocIdentComboBox2.FormattingEnabled = True
        Me.TipoDocIdentComboBox2.Location = New System.Drawing.Point(365, 32)
        Me.TipoDocIdentComboBox2.Name = "TipoDocIdentComboBox2"
        Me.TipoDocIdentComboBox2.Size = New System.Drawing.Size(107, 21)
        Me.TipoDocIdentComboBox2.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(SueldoPensionistaLabel)
        Me.GroupBox4.Controls.Add(Me.SueldoPensionistaNumericUpDown)
        Me.GroupBox4.Controls.Add(Me.FechaResAlcaldiaDateTimePicker)
        Me.GroupBox4.Controls.Add(NroResAlcaldiaLabel)
        Me.GroupBox4.Controls.Add(Me.NroResAlcaldiaTextBox)
        Me.GroupBox4.Controls.Add(Me.FechaExpAdmDateTimePicker)
        Me.GroupBox4.Controls.Add(NroExpAdmLabel)
        Me.GroupBox4.Controls.Add(Me.NroExpAdmTextBox)
        Me.GroupBox4.Controls.Add(BaseLegalLabel)
        Me.GroupBox4.Controls.Add(Me.BaseLegalTextBox)
        Me.GroupBox4.Controls.Add(CondicionEspecialContribuyenteLabel)
        Me.GroupBox4.Controls.Add(Me.CondicionEspecialContribuyenteComboBox)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 219)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(573, 103)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Exoneración / Inafectación"
        '
        'SueldoPensionistaNumericUpDown
        '
        Me.SueldoPensionistaNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SueldoPensionistaNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HojaResumenBindingSource, "SueldoPensionista", True))
        Me.SueldoPensionistaNumericUpDown.DecimalPlaces = 2
        Me.SueldoPensionistaNumericUpDown.Location = New System.Drawing.Point(468, 72)
        Me.SueldoPensionistaNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.SueldoPensionistaNumericUpDown.Name = "SueldoPensionistaNumericUpDown"
        Me.SueldoPensionistaNumericUpDown.Size = New System.Drawing.Size(99, 20)
        Me.SueldoPensionistaNumericUpDown.TabIndex = 13
        Me.SueldoPensionistaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SueldoPensionistaNumericUpDown.ThousandsSeparator = True
        '
        'FechaResAlcaldiaDateTimePicker
        '
        Me.FechaResAlcaldiaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HojaResumenBindingSource, "FechaResAlcaldia", True))
        Me.FechaResAlcaldiaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaResAlcaldiaDateTimePicker.Location = New System.Drawing.Point(366, 72)
        Me.FechaResAlcaldiaDateTimePicker.Name = "FechaResAlcaldiaDateTimePicker"
        Me.FechaResAlcaldiaDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.FechaResAlcaldiaDateTimePicker.TabIndex = 11
        '
        'NroResAlcaldiaTextBox
        '
        Me.NroResAlcaldiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "NroResAlcaldia", True))
        Me.NroResAlcaldiaTextBox.Location = New System.Drawing.Point(237, 72)
        Me.NroResAlcaldiaTextBox.Name = "NroResAlcaldiaTextBox"
        Me.NroResAlcaldiaTextBox.Size = New System.Drawing.Size(123, 20)
        Me.NroResAlcaldiaTextBox.TabIndex = 9
        '
        'FechaExpAdmDateTimePicker
        '
        Me.FechaExpAdmDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HojaResumenBindingSource, "FechaExpAdm", True))
        Me.FechaExpAdmDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaExpAdmDateTimePicker.Location = New System.Drawing.Point(135, 72)
        Me.FechaExpAdmDateTimePicker.Name = "FechaExpAdmDateTimePicker"
        Me.FechaExpAdmDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.FechaExpAdmDateTimePicker.TabIndex = 7
        '
        'NroExpAdmTextBox
        '
        Me.NroExpAdmTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "NroExpAdm", True))
        Me.NroExpAdmTextBox.Location = New System.Drawing.Point(6, 72)
        Me.NroExpAdmTextBox.Name = "NroExpAdmTextBox"
        Me.NroExpAdmTextBox.Size = New System.Drawing.Size(123, 20)
        Me.NroExpAdmTextBox.TabIndex = 5
        '
        'BaseLegalTextBox
        '
        Me.BaseLegalTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BaseLegalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HojaResumenBindingSource, "BaseLegal", True))
        Me.BaseLegalTextBox.Location = New System.Drawing.Point(336, 32)
        Me.BaseLegalTextBox.Name = "BaseLegalTextBox"
        Me.BaseLegalTextBox.Size = New System.Drawing.Size(231, 20)
        Me.BaseLegalTextBox.TabIndex = 3
        '
        'CondicionEspecialContribuyenteComboBox
        '
        Me.CondicionEspecialContribuyenteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HojaResumenBindingSource, "CondicionEspecialContribuyente", True))
        Me.CondicionEspecialContribuyenteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CondicionEspecialContribuyenteComboBox.FormattingEnabled = True
        Me.CondicionEspecialContribuyenteComboBox.Location = New System.Drawing.Point(6, 32)
        Me.CondicionEspecialContribuyenteComboBox.Name = "CondicionEspecialContribuyenteComboBox"
        Me.CondicionEspecialContribuyenteComboBox.Size = New System.Drawing.Size(322, 21)
        Me.CondicionEspecialContribuyenteComboBox.TabIndex = 1
        '
        'DatosDelContribuyenteDlg
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(597, 377)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DatosDelContribuyenteDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos del Contribuyente"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.HojaResumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.SueldoPensionistaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents HojaResumenBindingSource As BindingSource
    Friend WithEvents CodContribuyenteTextBox As TextBox
    Friend WithEvents ApeNombRazSocTextBox As TextBox
    Friend WithEvents NumDocIdentTextBox As TextBox
    Friend WithEvents ApeNombRazSocTextBox1 As TextBox
    Friend WithEvents NumDocIdentTextBox1 As TextBox
    Friend WithEvents ApeNombRazSocTextBox2 As TextBox
    Friend WithEvents NumDocIdentTextBox2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TipoDocIdentComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TipoDocIdentComboBox1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TipoDocIdentComboBox2 As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CondicionEspecialContribuyenteComboBox As ComboBox
    Friend WithEvents SueldoPensionistaNumericUpDown As NumericUpDown
    Friend WithEvents FechaResAlcaldiaDateTimePicker As DateTimePicker
    Friend WithEvents NroResAlcaldiaTextBox As TextBox
    Friend WithEvents FechaExpAdmDateTimePicker As DateTimePicker
    Friend WithEvents NroExpAdmTextBox As TextBox
    Friend WithEvents BaseLegalTextBox As TextBox
End Class
