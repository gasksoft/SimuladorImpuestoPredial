Imports System.ComponentModel
Imports SimuladorImpuestoPredial.ImpPred

Public Class SimulatorForm
    Private ReadOnly _impuestoPredial As New ImpuestoPredial()
    Private _enlazandoControles As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In GetUits().Keys
            ToolStripDropDownButton1.Items.Add(item)
        Next
        AddHandler ToolStripDropDownButton1.ComboBox.SelectedIndexChanged, AddressOf OnYearChange
        ToolStripDropDownButton1.SelectedIndex = 0
        ClasificacionComboBox.DisplayMember = "Value"
        ClasificacionComboBox.ValueMember = "Key"
        ClasificacionComboBox.DataSource = ClasificacionPredioDictionary.ToArray
        MaterialComboBox.DisplayMember = "Value"
        MaterialComboBox.ValueMember = "Key"
        MaterialComboBox.DataSource = ParametrosCalculo.MaterialPredominanteDictionary.ToArray
        EstadoComboBox.DisplayMember = "Value"
        EstadoComboBox.ValueMember = "Key"
        EstadoComboBox.DataSource = ParametrosCalculo.EstadoConservacionDictionary.ToArray
        ImpuestoPredialBindingSource.DataSource = _impuestoPredial
    End Sub
    Private Sub OnYearChange(sender As Object, e As EventArgs)
        ParametrosCalculo.Año() = ToolStripDropDownButton1.ComboBox.SelectedItem
        ImpuestoPredialBindingSource.ResetBindings(False)
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
    Private Shared Sub SelTextOnEnter(sender As Object, e As EventArgs) _
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
    End Sub
    Private Sub PrediosBindingSource_CurrentChanged(sender As Object, e As EventArgs) _
        Handles PrediosBindingSource.CurrentChanged
        _enlazandoControles = True
    End Sub
    Private Sub PrediosBindingSource_BindingComplete(sender As Object, e As BindingCompleteEventArgs) _
        Handles PrediosBindingSource.BindingComplete
        _enlazandoControles = False
    End Sub
End Class