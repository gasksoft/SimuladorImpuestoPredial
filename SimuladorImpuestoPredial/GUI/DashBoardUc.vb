Imports SimuImpPred.Common.Codificadores
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
            MetroTabControl2.Enabled = Not PresuntoMetroToggle.Checked
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

        Private Sub MtAddPu_Click(sender As Object, e As EventArgs) Handles MtAddPu.Click
            HojaResumen.Instancia.Predios.Add(New PredioUrbano)
            PrediosBindingSource.MoveLast()
            MtEditPredio.PerformClick()
        End Sub

        Private Sub MtEditPredio_Click(sender As Object, e As EventArgs) Handles MtEditPredio.Click
            Dim control As EditPredioUrbanoUc
            If Not MainForm.Instancia.Contenedor.Controls.ContainsKey("EditPredioUrbanoUc") Then
                control = New EditPredioUrbanoUc
                control.Name = "EditPredioUrbanoUc"
                control.Dock = DockStyle.Fill
                MainForm.Instancia.Contenedor.Controls.Add(control)
            Else
                control = MainForm.Instancia.Contenedor.Controls("EditPredioUrbanoUc")
            End If
            control.HojaResumenBindingSource.DataSource = HojaResumenBindingSource
            control.PredioBindingSource.DataSource = PrediosBindingSource.Current
            control.BringToFront()
            MainForm.Instancia.GoToBack.Visible = True
        End Sub

        Private Sub DashBoardUc_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
            MsgBox(1)
        End Sub
    End Class
End Namespace