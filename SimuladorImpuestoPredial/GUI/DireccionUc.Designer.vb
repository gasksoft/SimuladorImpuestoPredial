Imports MetroFramework.Controls

Namespace GUI

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DireccionUc
        Inherits MetroUserControl

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
            Dim TipoHabilitacionLabel As MetroFramework.Controls.MetroLabel
            Dim HabilitacionLabel As MetroFramework.Controls.MetroLabel
            Dim TipoViaLabel As MetroFramework.Controls.MetroLabel
            Dim ViaLabel As MetroFramework.Controls.MetroLabel
            Dim NumeroLabel As MetroFramework.Controls.MetroLabel
            Dim MzLabel As MetroFramework.Controls.MetroLabel
            Dim LoteLabel As MetroFramework.Controls.MetroLabel
            Dim InteriorLabel As MetroFramework.Controls.MetroLabel
            Dim DptoLabel As MetroFramework.Controls.MetroLabel
            Dim BlockLabel As MetroFramework.Controls.MetroLabel
            Me.TipoHabilitacionMetroComboBox = New MetroFramework.Controls.MetroComboBox()
            Me.DireccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.HabilitacionTextBox = New MetroFramework.Controls.MetroTextBox()
            Me.TipoViaMetroComboBox = New MetroFramework.Controls.MetroComboBox()
            Me.ViaTextBox = New MetroFramework.Controls.MetroTextBox()
            Me.NumeroTextBox = New MetroFramework.Controls.MetroTextBox()
            Me.MzTextBox = New MetroFramework.Controls.MetroTextBox()
            Me.LoteTextBox = New MetroFramework.Controls.MetroTextBox()
            Me.InteriorTextBox = New MetroFramework.Controls.MetroTextBox()
            Me.DptoTextBox = New MetroFramework.Controls.MetroTextBox()
            Me.BlockTextBox = New MetroFramework.Controls.MetroTextBox()
            TipoHabilitacionLabel = New MetroFramework.Controls.MetroLabel()
            HabilitacionLabel = New MetroFramework.Controls.MetroLabel()
            TipoViaLabel = New MetroFramework.Controls.MetroLabel()
            ViaLabel = New MetroFramework.Controls.MetroLabel()
            NumeroLabel = New MetroFramework.Controls.MetroLabel()
            MzLabel = New MetroFramework.Controls.MetroLabel()
            LoteLabel = New MetroFramework.Controls.MetroLabel()
            InteriorLabel = New MetroFramework.Controls.MetroLabel()
            DptoLabel = New MetroFramework.Controls.MetroLabel()
            BlockLabel = New MetroFramework.Controls.MetroLabel()
            CType(Me.DireccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TipoHabilitacionLabel
            '
            TipoHabilitacionLabel.AutoSize = True
            TipoHabilitacionLabel.Location = New System.Drawing.Point(3, 0)
            TipoHabilitacionLabel.Name = "TipoHabilitacionLabel"
            TipoHabilitacionLabel.Size = New System.Drawing.Size(110, 19)
            TipoHabilitacionLabel.TabIndex = 0
            TipoHabilitacionLabel.Text = "Tipo Habilitacion:"
            '
            'HabilitacionLabel
            '
            HabilitacionLabel.AutoSize = True
            HabilitacionLabel.Location = New System.Drawing.Point(189, 0)
            HabilitacionLabel.Name = "HabilitacionLabel"
            HabilitacionLabel.Size = New System.Drawing.Size(80, 19)
            HabilitacionLabel.TabIndex = 2
            HabilitacionLabel.Text = "Habilitacion:"
            '
            'TipoViaLabel
            '
            TipoViaLabel.AutoSize = True
            TipoViaLabel.Location = New System.Drawing.Point(3, 50)
            TipoViaLabel.Name = "TipoViaLabel"
            TipoViaLabel.Size = New System.Drawing.Size(60, 19)
            TipoViaLabel.TabIndex = 4
            TipoViaLabel.Text = "Tipo Via:"
            '
            'ViaLabel
            '
            ViaLabel.AutoSize = True
            ViaLabel.Location = New System.Drawing.Point(132, 50)
            ViaLabel.Name = "ViaLabel"
            ViaLabel.Size = New System.Drawing.Size(30, 19)
            ViaLabel.TabIndex = 6
            ViaLabel.Text = "Via:"
            '
            'NumeroLabel
            '
            NumeroLabel.AutoSize = True
            NumeroLabel.Location = New System.Drawing.Point(3, 100)
            NumeroLabel.Name = "NumeroLabel"
            NumeroLabel.Size = New System.Drawing.Size(61, 19)
            NumeroLabel.TabIndex = 8
            NumeroLabel.Text = "Numero:"
            '
            'MzLabel
            '
            MzLabel.AutoSize = True
            MzLabel.Location = New System.Drawing.Point(70, 100)
            MzLabel.Name = "MzLabel"
            MzLabel.Size = New System.Drawing.Size(30, 19)
            MzLabel.TabIndex = 10
            MzLabel.Text = "Mz:"
            '
            'LoteLabel
            '
            LoteLabel.AutoSize = True
            LoteLabel.Location = New System.Drawing.Point(137, 100)
            LoteLabel.Name = "LoteLabel"
            LoteLabel.Size = New System.Drawing.Size(37, 19)
            LoteLabel.TabIndex = 12
            LoteLabel.Text = "Lote:"
            '
            'InteriorLabel
            '
            InteriorLabel.AutoSize = True
            InteriorLabel.Location = New System.Drawing.Point(275, 100)
            InteriorLabel.Name = "InteriorLabel"
            InteriorLabel.Size = New System.Drawing.Size(55, 19)
            InteriorLabel.TabIndex = 16
            InteriorLabel.Text = "Interior:"
            '
            'DptoLabel
            '
            DptoLabel.AutoSize = True
            DptoLabel.Location = New System.Drawing.Point(336, 100)
            DptoLabel.Name = "DptoLabel"
            DptoLabel.Size = New System.Drawing.Size(41, 19)
            DptoLabel.TabIndex = 18
            DptoLabel.Text = "Dpto:"
            '
            'BlockLabel
            '
            BlockLabel.AutoSize = True
            BlockLabel.Location = New System.Drawing.Point(204, 100)
            BlockLabel.Name = "BlockLabel"
            BlockLabel.Size = New System.Drawing.Size(43, 19)
            BlockLabel.TabIndex = 14
            BlockLabel.Text = "Block:"
            '
            'TipoHabilitacionMetroComboBox
            '
            Me.TipoHabilitacionMetroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionBindingSource, "TipoHabilitacion", True))
            Me.TipoHabilitacionMetroComboBox.DropDownHeight = 80
            Me.TipoHabilitacionMetroComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small
            Me.TipoHabilitacionMetroComboBox.FormattingEnabled = True
            Me.TipoHabilitacionMetroComboBox.IntegralHeight = False
            Me.TipoHabilitacionMetroComboBox.ItemHeight = 19
            Me.TipoHabilitacionMetroComboBox.Location = New System.Drawing.Point(3, 22)
            Me.TipoHabilitacionMetroComboBox.MaxDropDownItems = 5
            Me.TipoHabilitacionMetroComboBox.Name = "TipoHabilitacionMetroComboBox"
            Me.TipoHabilitacionMetroComboBox.Size = New System.Drawing.Size(180, 25)
            Me.TipoHabilitacionMetroComboBox.TabIndex = 1
            Me.TipoHabilitacionMetroComboBox.UseSelectable = True
            '
            'DireccionBindingSource
            '
            Me.DireccionBindingSource.DataSource = GetType(SimuImpPred.ObjectModel.Direccion)
            '
            'HabilitacionTextBox
            '
            Me.HabilitacionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            '
            '
            '
            Me.HabilitacionTextBox.CustomButton.Image = Nothing
            Me.HabilitacionTextBox.CustomButton.Location = New System.Drawing.Point(197, 2)
            Me.HabilitacionTextBox.CustomButton.Name = ""
            Me.HabilitacionTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
            Me.HabilitacionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
            Me.HabilitacionTextBox.CustomButton.TabIndex = 1
            Me.HabilitacionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
            Me.HabilitacionTextBox.CustomButton.UseSelectable = True
            Me.HabilitacionTextBox.CustomButton.Visible = False
            Me.HabilitacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Habilitacion", True))
            Me.HabilitacionTextBox.Lines = New String(-1) {}
            Me.HabilitacionTextBox.Location = New System.Drawing.Point(189, 22)
            Me.HabilitacionTextBox.MaxLength = 32767
            Me.HabilitacionTextBox.Name = "HabilitacionTextBox"
            Me.HabilitacionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.HabilitacionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.HabilitacionTextBox.SelectedText = ""
            Me.HabilitacionTextBox.SelectionLength = 0
            Me.HabilitacionTextBox.SelectionStart = 0
            Me.HabilitacionTextBox.ShortcutsEnabled = True
            Me.HabilitacionTextBox.Size = New System.Drawing.Size(215, 20)
            Me.HabilitacionTextBox.TabIndex = 3
            Me.HabilitacionTextBox.UseSelectable = True
            Me.HabilitacionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
            Me.HabilitacionTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
            '
            'TipoViaMetroComboBox
            '
            Me.TipoViaMetroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionBindingSource, "TipoVia", True))
            Me.TipoViaMetroComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small
            Me.TipoViaMetroComboBox.FormattingEnabled = True
            Me.TipoViaMetroComboBox.ItemHeight = 19
            Me.TipoViaMetroComboBox.Location = New System.Drawing.Point(3, 72)
            Me.TipoViaMetroComboBox.Name = "TipoViaMetroComboBox"
            Me.TipoViaMetroComboBox.Size = New System.Drawing.Size(122, 25)
            Me.TipoViaMetroComboBox.TabIndex = 5
            Me.TipoViaMetroComboBox.UseSelectable = True
            '
            'ViaTextBox
            '
            Me.ViaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            '
            '
            '
            Me.ViaTextBox.CustomButton.Image = Nothing
            Me.ViaTextBox.CustomButton.Location = New System.Drawing.Point(255, 2)
            Me.ViaTextBox.CustomButton.Name = ""
            Me.ViaTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
            Me.ViaTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
            Me.ViaTextBox.CustomButton.TabIndex = 1
            Me.ViaTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
            Me.ViaTextBox.CustomButton.UseSelectable = True
            Me.ViaTextBox.CustomButton.Visible = False
            Me.ViaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Via", True))
            Me.ViaTextBox.Lines = New String(-1) {}
            Me.ViaTextBox.Location = New System.Drawing.Point(131, 72)
            Me.ViaTextBox.MaxLength = 32767
            Me.ViaTextBox.Name = "ViaTextBox"
            Me.ViaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.ViaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.ViaTextBox.SelectedText = ""
            Me.ViaTextBox.SelectionLength = 0
            Me.ViaTextBox.SelectionStart = 0
            Me.ViaTextBox.ShortcutsEnabled = True
            Me.ViaTextBox.Size = New System.Drawing.Size(273, 20)
            Me.ViaTextBox.TabIndex = 7
            Me.ViaTextBox.UseSelectable = True
            Me.ViaTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
            Me.ViaTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
            '
            'NumeroTextBox
            '
            Me.NumeroTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            '
            '
            '
            Me.NumeroTextBox.CustomButton.Image = Nothing
            Me.NumeroTextBox.CustomButton.Location = New System.Drawing.Point(43, 2)
            Me.NumeroTextBox.CustomButton.Name = ""
            Me.NumeroTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
            Me.NumeroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
            Me.NumeroTextBox.CustomButton.TabIndex = 1
            Me.NumeroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
            Me.NumeroTextBox.CustomButton.UseSelectable = True
            Me.NumeroTextBox.CustomButton.Visible = False
            Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Numero", True))
            Me.NumeroTextBox.Lines = New String(-1) {}
            Me.NumeroTextBox.Location = New System.Drawing.Point(3, 122)
            Me.NumeroTextBox.MaxLength = 32767
            Me.NumeroTextBox.Name = "NumeroTextBox"
            Me.NumeroTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.NumeroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.NumeroTextBox.SelectedText = ""
            Me.NumeroTextBox.SelectionLength = 0
            Me.NumeroTextBox.SelectionStart = 0
            Me.NumeroTextBox.ShortcutsEnabled = True
            Me.NumeroTextBox.Size = New System.Drawing.Size(61, 20)
            Me.NumeroTextBox.TabIndex = 9
            Me.NumeroTextBox.UseSelectable = True
            Me.NumeroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
            Me.NumeroTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
            '
            'MzTextBox
            '
            Me.MzTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            '
            '
            '
            Me.MzTextBox.CustomButton.Image = Nothing
            Me.MzTextBox.CustomButton.Location = New System.Drawing.Point(43, 2)
            Me.MzTextBox.CustomButton.Name = ""
            Me.MzTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
            Me.MzTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
            Me.MzTextBox.CustomButton.TabIndex = 1
            Me.MzTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
            Me.MzTextBox.CustomButton.UseSelectable = True
            Me.MzTextBox.CustomButton.Visible = False
            Me.MzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Mz", True))
            Me.MzTextBox.Lines = New String(-1) {}
            Me.MzTextBox.Location = New System.Drawing.Point(70, 122)
            Me.MzTextBox.MaxLength = 32767
            Me.MzTextBox.Name = "MzTextBox"
            Me.MzTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.MzTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.MzTextBox.SelectedText = ""
            Me.MzTextBox.SelectionLength = 0
            Me.MzTextBox.SelectionStart = 0
            Me.MzTextBox.ShortcutsEnabled = True
            Me.MzTextBox.Size = New System.Drawing.Size(61, 20)
            Me.MzTextBox.TabIndex = 11
            Me.MzTextBox.UseSelectable = True
            Me.MzTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
            Me.MzTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
            '
            'LoteTextBox
            '
            Me.LoteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            '
            '
            '
            Me.LoteTextBox.CustomButton.Image = Nothing
            Me.LoteTextBox.CustomButton.Location = New System.Drawing.Point(43, 2)
            Me.LoteTextBox.CustomButton.Name = ""
            Me.LoteTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
            Me.LoteTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
            Me.LoteTextBox.CustomButton.TabIndex = 1
            Me.LoteTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
            Me.LoteTextBox.CustomButton.UseSelectable = True
            Me.LoteTextBox.CustomButton.Visible = False
            Me.LoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Lote", True))
            Me.LoteTextBox.Lines = New String(-1) {}
            Me.LoteTextBox.Location = New System.Drawing.Point(137, 122)
            Me.LoteTextBox.MaxLength = 32767
            Me.LoteTextBox.Name = "LoteTextBox"
            Me.LoteTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.LoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.LoteTextBox.SelectedText = ""
            Me.LoteTextBox.SelectionLength = 0
            Me.LoteTextBox.SelectionStart = 0
            Me.LoteTextBox.ShortcutsEnabled = True
            Me.LoteTextBox.Size = New System.Drawing.Size(61, 20)
            Me.LoteTextBox.TabIndex = 13
            Me.LoteTextBox.UseSelectable = True
            Me.LoteTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
            Me.LoteTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
            '
            'InteriorTextBox
            '
            Me.InteriorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            '
            '
            '
            Me.InteriorTextBox.CustomButton.Image = Nothing
            Me.InteriorTextBox.CustomButton.Location = New System.Drawing.Point(36, 2)
            Me.InteriorTextBox.CustomButton.Name = ""
            Me.InteriorTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
            Me.InteriorTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
            Me.InteriorTextBox.CustomButton.TabIndex = 1
            Me.InteriorTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
            Me.InteriorTextBox.CustomButton.UseSelectable = True
            Me.InteriorTextBox.CustomButton.Visible = False
            Me.InteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Interior", True))
            Me.InteriorTextBox.Lines = New String(-1) {}
            Me.InteriorTextBox.Location = New System.Drawing.Point(275, 122)
            Me.InteriorTextBox.MaxLength = 32767
            Me.InteriorTextBox.Name = "InteriorTextBox"
            Me.InteriorTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.InteriorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.InteriorTextBox.SelectedText = ""
            Me.InteriorTextBox.SelectionLength = 0
            Me.InteriorTextBox.SelectionStart = 0
            Me.InteriorTextBox.ShortcutsEnabled = True
            Me.InteriorTextBox.Size = New System.Drawing.Size(54, 20)
            Me.InteriorTextBox.TabIndex = 17
            Me.InteriorTextBox.UseSelectable = True
            Me.InteriorTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
            Me.InteriorTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
            '
            'DptoTextBox
            '
            Me.DptoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            '
            '
            '
            Me.DptoTextBox.CustomButton.Image = Nothing
            Me.DptoTextBox.CustomButton.Location = New System.Drawing.Point(51, 2)
            Me.DptoTextBox.CustomButton.Name = ""
            Me.DptoTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
            Me.DptoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
            Me.DptoTextBox.CustomButton.TabIndex = 1
            Me.DptoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
            Me.DptoTextBox.CustomButton.UseSelectable = True
            Me.DptoTextBox.CustomButton.Visible = False
            Me.DptoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Dpto", True))
            Me.DptoTextBox.Lines = New String(-1) {}
            Me.DptoTextBox.Location = New System.Drawing.Point(335, 122)
            Me.DptoTextBox.MaxLength = 32767
            Me.DptoTextBox.Name = "DptoTextBox"
            Me.DptoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.DptoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.DptoTextBox.SelectedText = ""
            Me.DptoTextBox.SelectionLength = 0
            Me.DptoTextBox.SelectionStart = 0
            Me.DptoTextBox.ShortcutsEnabled = True
            Me.DptoTextBox.Size = New System.Drawing.Size(69, 20)
            Me.DptoTextBox.TabIndex = 19
            Me.DptoTextBox.UseSelectable = True
            Me.DptoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
            Me.DptoTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
            '
            'BlockTextBox
            '
            Me.BlockTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            '
            '
            '
            Me.BlockTextBox.CustomButton.Image = Nothing
            Me.BlockTextBox.CustomButton.Location = New System.Drawing.Point(47, 2)
            Me.BlockTextBox.CustomButton.Name = ""
            Me.BlockTextBox.CustomButton.Size = New System.Drawing.Size(15, 15)
            Me.BlockTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
            Me.BlockTextBox.CustomButton.TabIndex = 1
            Me.BlockTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
            Me.BlockTextBox.CustomButton.UseSelectable = True
            Me.BlockTextBox.CustomButton.Visible = False
            Me.BlockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionBindingSource, "Block", True))
            Me.BlockTextBox.Lines = New String(-1) {}
            Me.BlockTextBox.Location = New System.Drawing.Point(204, 122)
            Me.BlockTextBox.MaxLength = 32767
            Me.BlockTextBox.Name = "BlockTextBox"
            Me.BlockTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.BlockTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.BlockTextBox.SelectedText = ""
            Me.BlockTextBox.SelectionLength = 0
            Me.BlockTextBox.SelectionStart = 0
            Me.BlockTextBox.ShortcutsEnabled = True
            Me.BlockTextBox.Size = New System.Drawing.Size(65, 20)
            Me.BlockTextBox.TabIndex = 15
            Me.BlockTextBox.UseSelectable = True
            Me.BlockTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
            Me.BlockTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
            '
            'DireccionUc
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.Controls.Add(BlockLabel)
            Me.Controls.Add(Me.BlockTextBox)
            Me.Controls.Add(DptoLabel)
            Me.Controls.Add(Me.DptoTextBox)
            Me.Controls.Add(InteriorLabel)
            Me.Controls.Add(Me.InteriorTextBox)
            Me.Controls.Add(LoteLabel)
            Me.Controls.Add(Me.LoteTextBox)
            Me.Controls.Add(MzLabel)
            Me.Controls.Add(Me.MzTextBox)
            Me.Controls.Add(NumeroLabel)
            Me.Controls.Add(Me.NumeroTextBox)
            Me.Controls.Add(ViaLabel)
            Me.Controls.Add(Me.ViaTextBox)
            Me.Controls.Add(TipoViaLabel)
            Me.Controls.Add(Me.TipoViaMetroComboBox)
            Me.Controls.Add(HabilitacionLabel)
            Me.Controls.Add(Me.HabilitacionTextBox)
            Me.Controls.Add(TipoHabilitacionLabel)
            Me.Controls.Add(Me.TipoHabilitacionMetroComboBox)
            Me.Name = "DireccionUc"
            Me.Size = New System.Drawing.Size(407, 145)
            CType(Me.DireccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents DireccionBindingSource As BindingSource
        Friend WithEvents TipoHabilitacionMetroComboBox As MetroComboBox
        Friend WithEvents HabilitacionTextBox As MetroTextBox
        Friend WithEvents TipoViaMetroComboBox As MetroComboBox
        Friend WithEvents ViaTextBox As MetroTextBox
        Friend WithEvents NumeroTextBox As MetroTextBox
        Friend WithEvents MzTextBox As MetroTextBox
        Friend WithEvents LoteTextBox As MetroTextBox
        Friend WithEvents InteriorTextBox As MetroTextBox
        Friend WithEvents DptoTextBox As MetroTextBox
        Friend WithEvents BlockTextBox As MetroTextBox
    End Class
End Namespace