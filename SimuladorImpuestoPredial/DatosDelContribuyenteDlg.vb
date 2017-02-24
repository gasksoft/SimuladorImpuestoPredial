Imports SimuImpPred.ObjectModel

Public Class DatosDelContribuyenteDlg
    Public Property HojaResumen As HojaResumen
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Validate()
        HojaResumen = HojaResumenBindingSource.DataSource
        Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub DatosDelContribuyenteDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TipoDocIdentComboBox.DataSource = TipoDocumentoIdentidad.ToList
        TipoDocIdentComboBox1.DataSource = TipoDocumentoIdentidad.ToList
        TipoDocIdentComboBox2.DataSource = TipoDocumentoIdentidad.ToList
        TipoDocIdentComboBox.DisplayMember = "Value"
        TipoDocIdentComboBox1.DisplayMember = "Value"
        TipoDocIdentComboBox2.DisplayMember = "Value"
        TipoDocIdentComboBox.ValueMember = "Key"
        TipoDocIdentComboBox1.ValueMember = "Key"
        TipoDocIdentComboBox2.ValueMember = "Key"
        CondicionEspecialContribuyenteComboBox.DataSource = CondicionEspecialContribuyente.ToList
        CondicionEspecialContribuyenteComboBox.ValueMember = "Key"
        CondicionEspecialContribuyenteComboBox.DisplayMember = "Value"

        HojaResumenBindingSource.DataSource = HojaResumen
    End Sub
End Class
