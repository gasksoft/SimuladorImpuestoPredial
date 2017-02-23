Imports System.ComponentModel
Imports SimuladorImpuestoPredial.ImpPred

Public Class SimulatorForm
    Private ReadOnly _impuestoPredial As New ImpuestoPredial()
    Private _enlazandoControles As Boolean
    Private _catActual As String = "MC"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text &= " " & My.Application.Info.Version.ToString
        For Each item In GetUits().Keys
            ToolStripDropDownButton1.Items.Add(item)
        Next
        AddHandler ToolStripDropDownButton1.ComboBox.SelectedIndexChanged,
            Sub()
                Año = ToolStripDropDownButton1.ComboBox.SelectedItem
                DetallarCategoria(_catActual)
                ImpuestoPredialBindingSource.ResetBindings(False)
            End Sub
        ToolStripDropDownButton1.SelectedIndex = 0
        ClasificacionComboBox.DisplayMember = "Value"
        ClasificacionComboBox.ValueMember = "Key"
        ClasificacionComboBox.DataSource = ClasificacionPredioDictionary.ToArray
        MaterialComboBox.DisplayMember = "Value"
        MaterialComboBox.ValueMember = "Key"
        MaterialComboBox.DataSource = MaterialPredominanteDictionary.ToArray
        EstadoComboBox.DisplayMember = "Value"
        EstadoComboBox.ValueMember = "Key"
        EstadoComboBox.DataSource = EstadoConservacionDictionary.ToArray
        ImpuestoPredialBindingSource.DataSource = _impuestoPredial
        IfpDenoBindingSource.DataSource = GetIfpDenominaciones.ToArray
        'detallarCategoria(_catActual)
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub PrediosBindingSource_ListChanged(sender As Object, e As ListChangedEventArgs) _
        Handles PrediosBindingSource.ListChanged
        DetPredioGB.Enabled = PrediosBindingSource.Current IsNot Nothing
    End Sub

    Private Sub ConstruccionesBindingSource_ListChanged(sender As Object, e As ListChangedEventArgs) _
        Handles ConstruccionesBindingSource.ListChanged
        DetallesConstruccionGb.Enabled = ConstruccionesBindingSource.Current IsNot Nothing
    End Sub

    Private Sub PasarElFocoAlSiguienteTextAlLlegarAlMaxLenght(sender As Object, e As EventArgs) _
        Handles CmcTextBox.TextChanged, CtTextBox.TextChanged, CpTextBox.TextChanged, CpvTextBox.TextChanged,
                CrTextBox.TextChanged, CbTextBox.TextChanged, CiesTextBox.TextChanged
        Dim txt As TextBox = sender
        If txt.TextLength = txt.MaxLength AndAlso
           Not _enlazandoControles Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub SelTextOnEnter(sender As Object, e As EventArgs) _
        Handles CmcTextBox.Enter,
                CtTextBox.Enter,
                CpTextBox.Enter,
                CpvTextBox.Enter,
                CrTextBox.Enter,
                CbTextBox.Enter,
                CiesTextBox.Enter
        Dim txt As TextBox = sender
        If (Not String.IsNullOrEmpty(txt.Text)) Then
            txt.SelectionStart = 0
            txt.SelectionLength = txt.Text.Length
        End If
        _catActual = txt.Tag
        DetallarCategoria(_catActual)
    End Sub

    Private Sub PrediosBindingSource_CurrentChanged(sender As Object, e As EventArgs) _
        Handles PrediosBindingSource.CurrentChanged
        _enlazandoControles = True
    End Sub

    Private Sub PrediosBindingSource_BindingComplete(sender As Object, e As BindingCompleteEventArgs) _
        Handles PrediosBindingSource.BindingComplete
        _enlazandoControles = False
    End Sub

    Private Sub DetallarCategoria(cat As String)
        Dim titulo = ""
        If Not TitulosCategorias.TryGetValue(cat, titulo) Then
            Return
        End If
        Panel2.SuspendLayout()
        LabelTituloCategoria.Text = titulo
        For Each cd In GetCategoriasDesc()
            Dim desc = CallByName(cd, $"D{cat}", CallType.Get)
            Dim vis = Not (desc = "")
            Panel2.Controls($"labelDC{cd.Cat}").Visible = vis
            Panel2.Controls($"labelVC{cd.Cat}").Visible = vis
            Panel2.Controls($"labelEC{cd.Cat}").Visible = vis
            Panel2.Controls($"labelDC{cd.Cat}").Text = desc
            Panel2.Controls($"labelVC{cd.Cat}").Text =
                $"{CallByName(GetCategorias(cd.Cat), $"V{cat}", CallType.Get):N2}"
        Next
        Panel2.ResumeLayout()
    End Sub

    Private Shared ReadOnly TitulosCategorias As New Dictionary(Of String, String) From
        {{"MC", "Muros y Columnas"}, {"T", "Techos"}, {"P", "Pisos"}, {"PV", "Puertas y Ventanas"},
        {"R", "Revestimientos"}, {"B", "Baños"}, {"IES", "Instalaciones Electricas y Sanitarias"}}

    Private Sub SinDetalleCheckBox_CheckedChanged(sender As Object, e As EventArgs) _
        Handles SinDetalleCheckBox.CheckedChanged
        BaseImponibleTextBox.ReadOnly = Not SinDetalleCheckBox.Checked
    End Sub

    Private Sub ConstruccionesTab_Enter(sender As Object, e As EventArgs) Handles ConstruccionesTab.Enter
        SplitContainer1.Panel2Collapsed = False
    End Sub

    Private Sub ConstruccionesTab_Leave(sender As Object, e As EventArgs) Handles ConstruccionesTab.Leave
        SplitContainer1.Panel2Collapsed = True
    End Sub
End Class