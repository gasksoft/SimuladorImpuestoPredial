Imports SimuImpPred.ObjectModel

Public Class DomicilioFiscalDlg
    Public Property HojaResumen As HojaResumen

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub DomicilioFiscalDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UDepBindingSource.DataSource = DepartamentosList
        TipoHabilitacionComboBox.DataSource = TipoHabilitacionDic.ToList
        TipoViaComboBox.DataSource = TipoViaDic.ToList
        TipoHabilitacionComboBox.DisplayMember = "value"
        TipoHabilitacionComboBox.ValueMember = "Key"
        TipoViaComboBox.DisplayMember = "value"
        TipoViaComboBox.ValueMember = "Key"


        HojaResumenBindingSource.DataSource = HojaResumen
    End Sub

    Private Sub BtnEditTelefonos_Click(sender As Object, e As EventArgs) Handles BtnEditTelefonos.Click
        Dim dlg As New EditStringListDlg
        dlg.Valor = TelefonosTextBox.Text
        dlg.Text = "Telefonos"
        If dlg.ShowDialog(Me) = DialogResult.OK Then
            TelefonosTextBox.Text = dlg.Valor
        End If
    End Sub

    Private Sub BtnEditCorreos_Click(sender As Object, e As EventArgs) Handles BtnEditCorreos.Click
        Dim dlg As New EditStringListDlg
        dlg.Valor = CorreosElectronicosTextBox.Text
        dlg.Text = "Correos Electronicos"
        If dlg.ShowDialog(Me) = DialogResult.OK Then
            CorreosElectronicosTextBox.Text = dlg.Valor
        End If
    End Sub
End Class
