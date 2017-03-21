Imports SimuImpPred.Data
Imports SimuImpPred.ObjectModel

Namespace GUI

    Public Class DashBoardUc
        Private _predio As Predio
        Private Sub DashBoardUc_Load(sender As Object, e As EventArgs) Handles Me.Load
            CondicionEspecialContribuyenteComboBox.DataSource = CondicionEspecialContribuyenteDic.ToList
            CondicionEspecialContribuyenteComboBox.ValueMember = "key"
            CondicionEspecialContribuyenteComboBox.DisplayMember = "value"

            Enlazar()
        End Sub

        Protected Friend Sub Enlazar()
            HojaResumenBindingSource.DataSource = HojaResumen.Instancia
            HojaResumenBindingSource.ResetBindings(True)
        End Sub

        Private Sub PresuntoMetroToggle_CheckedChanged(sender As Object, e As EventArgs) Handles PresuntoMetroToggle.CheckedChanged
            BaseImponibleTextBox.ReadOnly = Not PresuntoMetroToggle.Checked
            If Not BaseImponibleTextBox.ReadOnly Then
                BaseImponibleTextBox.Focus()
            End If
        End Sub

        Private Sub PrediosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles PrediosBindingSource.CurrentChanged
            _predio = PrediosBindingSource.Current
            If _predio Is Nothing Then
                MtEditPredio.Enabled = False
                MtDeletePredio.Enabled = False
            Else
                MtEditPredio.Enabled = True
                MtDeletePredio.Enabled = True
            End If
        End Sub
    End Class
End Namespace