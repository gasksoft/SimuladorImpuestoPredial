

Namespace GUI
    Public Class EditPredioUc
        Private Sub EditPredioUc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If DesignMode Then Return

            ClasificacionPredioMetroComboBox.DataSource = Common.Codificadores.ClasificacionPredioDic.ToList
            ClasificacionPredioMetroComboBox.DisplayMember = "Value"
            ClasificacionPredioMetroComboBox.ValueMember = "key"

            UsoGrupoBindingSource.DataSource = Common.Codificadores.UsosGruposList
        End Sub

        Private Sub ConstruccionesDataGridView_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles ConstruccionesDataGridView.ColumnAdded
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
        End Sub

        Private Sub AutoavaluoTextBox_TextChanged(sender As Object, e As EventArgs) Handles AutoavaluoTextBox.TextChanged
            Text = $"dddddddd"
            HojaResumenBindingSource.ResetCurrentItem()
        End Sub




        'Private Sub ClasificacionPredioMetroComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClasificacionPredioMetroComboBox.SelectedIndexChanged
        '    'If ClasificacionPredioMetroComboBox.SelectedIndex = -1 Then Return
        '    'PredioBindingSource.ResetBindings(False)
        'End Sub
    End Class
End Namespace