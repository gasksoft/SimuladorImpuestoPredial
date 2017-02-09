Imports System.ComponentModel
Imports SimuladorImpuestoPredial.Entidades
Imports SimuladorImpuestoPredial.ImpPred

Public Class Form1
    Private ReadOnly _impuestoPredial As New ImpuestoPredial()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In ParametrosCalculo.Uits.Keys
            ToolStripDropDownButton1.Items.Add(item)
        Next

        AddHandler ToolStripDropDownButton1.ComboBox.SelectedIndexChanged, AddressOf OnYearChange

        ToolStripDropDownButton1.SelectedIndex = 0

        ClasificacionComboBox.DisplayMember = "Value"
        ClasificacionComboBox.ValueMember = "Key"
        ClasificacionComboBox.DataSource = ParametrosCalculo.ClasificacionPredioDictionary.ToArray

        MaterialComboBox.DisplayMember = "Value"
        MaterialComboBox.ValueMember = "Key"
        MaterialComboBox.DataSource = ParametrosCalculo.MaterialPredominanteDictionary.ToArray

        EstadoComboBox.DisplayMember = "Value"
        EstadoComboBox.ValueMember = "Key"
        EstadoComboBox.DataSource = ParametrosCalculo.EstadoConservacionDictionary.ToArray

        ImpuestoPredialBindingSource.DataSource = _impuestoPredial
    End Sub

    Private Sub OnYearChange(sender As Object, e As EventArgs)
        ParametrosCalculo.Año = ToolStripDropDownButton1.ComboBox.SelectedItem
    End Sub

    Private Sub PrediosBindingSource_ListChanged(sender As Object, e As ListChangedEventArgs) Handles PrediosBindingSource.ListChanged
        GroupBox2.Enabled = PrediosBindingSource.Current IsNot Nothing
    End Sub

    Private Sub ConstruccionesBindingSource_ListChanged(sender As Object, e As ListChangedEventArgs) Handles ConstruccionesBindingSource.ListChanged
        GroupBox7.Enabled = ConstruccionesBindingSource.Current IsNot Nothing
    End Sub

    'Private Sub ValidacionCategoriasConstruccion(sender As Object, e As CancelEventArgs) Handles _
    '        CmcTextBox.Validating, CtTextBox.Validating, CpTextBox.Validating, CpvTextBox.Validating, CrTextBox.Validating, CbTextBox.Validating, CiesTextBox.Validating

    '    Dim txt As TextBox = sender
    '    Me.Text = txt.Text

    'End Sub

    Private Sub PasarElFocoAlSiguienteTextAlLlegarAlMaxLenght(sender As Object, e As EventArgs) Handles _
            CmcTextBox.TextChanged, CtTextBox.TextChanged, CpTextBox.TextChanged, CpvTextBox.TextChanged, CrTextBox.TextChanged, CbTextBox.TextChanged, CiesTextBox.TextChanged
        Dim txt As TextBox = sender
        If txt.TextLength = txt.MaxLength Then
            Dim siguiente As Control = GetNextControl(ActiveControl, True)
            Dim siguienteTxt As TextBox = TryCast(siguiente, TextBox)
            If siguienteTxt IsNot Nothing Then
                siguienteTxt.Select()
            Else
                siguiente.Focus()
            End If
        End If
    End Sub

    Private Sub SeleccionarTextoAlEntrarAlTextBox(sender As Object, e As EventArgs) Handles _
        CmcTextBox.Enter, CtTextBox.Enter, CpTextBox.Enter, CpvTextBox.Enter, CrTextBox.Enter, CbTextBox.Enter, CiesTextBox.Enter
        Dim txt As TextBox = sender
        If (Not String.IsNullOrEmpty(txt.Text)) Then
            txt.SelectionStart = 0
            txt.SelectionLength = txt.Text.Length
        End If
    End Sub
End Class