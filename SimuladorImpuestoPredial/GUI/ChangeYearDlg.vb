Imports SimuImpPred.Data
Imports SimuImpPred.ObjectModel

Namespace GUI
    Public Class ChangeYearDlg
        Property Año As Integer
        Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
            Año = MetroComboBox1.SelectedItem
            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        Private Sub ChangeYearDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            MetroComboBox1.DataSource = ParameterProvider.GetAños
            MetroComboBox1.SelectedItem = ParametrosCalculo.Instancia.Año
        End Sub
    End Class
End Namespace