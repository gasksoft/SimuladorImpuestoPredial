Imports SimuImpPred.ObjectModel

Public Class PuDlg
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Public Property Predio As PredioUrbano

    Private Sub PuDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PredioUrbanoBindingSource.DataSource = Predio
        Text = $"Predio Urbano - Anexo {Predio.Anexo:3}"
    End Sub
End Class
