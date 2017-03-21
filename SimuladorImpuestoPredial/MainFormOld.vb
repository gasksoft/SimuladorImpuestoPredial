Imports System.ComponentModel
Imports SimuImpPred.Data
Imports SimuImpPred.ObjectModel

Public Class MainFormOld
    Private _filename As String

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        AñoComboBox.DataSource = ParameterProvider.GetAños

        ParametrosCalculoBindingSource.DataSource = ParametrosCalculo.Instancia

        CondicionEspecialContribuyenteComboBox.DataSource = CondicionEspecialContribuyenteDic.ToList
        CondicionEspecialContribuyenteComboBox.ValueMember = "Key"
        CondicionEspecialContribuyenteComboBox.DisplayMember = "Value"

        Randomize()

        Dim predios As New BindingList(Of Predio)
        For j = 0 To 300
            Dim p As New PredioUrbano
            For i = 0 To Rnd() * 10
                Dim c = p.Construcciones.AddNew()
                c.AreaConstruida = Rnd() * 325 + 27
                c.Año = Rnd() * 50 + (2017 - 50)
                c.PorcPartPredio = Rnd() * 100
                c.Piso = Rnd() * 6
            Next
            predios.Add(p)
        Next
        HojaResumen.Instancia.Predios = predios
        MsgBox(HojaResumen.Instancia.ImpuestoAnual)

        HojaResumenBindingSource.DataSource = HojaResumen.Instancia
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        'Alternar la visibilidad del elemento ToolStrip y el estado de activación del elemento de menú asociado
        ToolBarToolStripMenuItem.Checked = Not ToolBarToolStripMenuItem.Checked
        ToolStrip.Visible = ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles StatusBarToolStripMenuItem.Click
        'Alternar la visibilidad del elemento StatusStrip y el estado de activación del elemento de menú asociado
        StatusBarToolStripMenuItem.Checked = Not StatusBarToolStripMenuItem.Checked
        StatusStrip.Visible = StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        openFileDialog.Filter = $"Archivos de declaraciones juradas (*.dj)|*.dj"
        openFileDialog.ShowDialog(Me)

        _filename = openFileDialog.FileName

        Dim aa = Now

        HojaResumen.SetInstance(Common.DescomprimeYDeseria(Of HojaResumen)(_filename))
        HojaResumenBindingSource.DataSource = HojaResumen.Instancia

        MsgBox((Now - aa).ToString)

    End Sub


    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        saveFileDialog.Filter = $"Archivos de declaraciones juradas (*.dj)|*.dj"
        saveFileDialog.FileName = HojaResumen.Instancia.NombreHr
        saveFileDialog.ShowDialog(Me)

        _filename = saveFileDialog.FileName
        SaveToolStripMenuItem.PerformClick()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If _filename = "" Then
            SaveAsToolStripMenuItem.PerformClick()
            Exit Sub
        End If
        If Not Validate() Then Return
        Common.SeriaYComprime(HojaResumen.Instancia, _filename)
        Validate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dcdlg As New DatosDelContribuyenteDlg
        Validate()
        dcdlg.HojaResumen = HojaResumen.Instancia
        dcdlg.ShowDialog(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dfdlg As New DomicilioFiscalDlg
        Validate()
        dfdlg.HojaResumen = HojaResumen.Instancia
        dfdlg.ShowDialog(Me)
    End Sub

    Private Sub AgregarPuBtn_Click(sender As Object, e As EventArgs) Handles AgregarPuBtn.Click
        Dim dlg As New PuDlg
        Dim predio As New PredioUrbano
        HojaResumen.Instancia.Predios.Add(predio)
        PrediosBindingSource.MoveLast()
        dlg.Predio = predio
        If dlg.ShowDialog(Me) = DialogResult.Cancel Then
            HojaResumen.Instancia.Predios.Remove(dlg.Predio)
        End If
    End Sub

    Private Sub AñoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AñoComboBox.SelectedIndexChanged
        HojaResumenBindingSource.ResetCurrentItem()
        Dim u = ParametrosCalculo.Instancia.Uit
        Label10.Text = $"En S/ UIT {ParametrosCalculo.Instancia.Año} = {u:C2}"
        Label9.Text = $"Hasta {u * 15:C2}"
        Label11.Text = $"Más de {u * 15:C2} y hasta {u * 60:C2}"
        Label12.Text = $"Más de {u * 60:C2}"

    End Sub

End Class
