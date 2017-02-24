
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization.Formatters.Soap
Imports SimuImpPred.ObjectModel

Public Class MainForm
    Dim _hojaResumen As New HojaResumen
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        _hojaResumen = New HojaResumen
        _hojaResumen.DatosContrib = New DatosPersona With {.ApeNombRazSoc = "klark", .NumDocIdent = "41243340", .TipoDocIdent = 1}

        HojaResumenBindingSource.DataSource = _hojaResumen
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Cerrar este formulario
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
        openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
        openFileDialog.ShowDialog(Me)

        Dim fileName As String = openFileDialog.FileName
        ' TODO: agregue el código para abrir el archivo
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
        saveFileDialog.ShowDialog(Me)

        Dim fileName As String = saveFileDialog.FileName
        ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dcdlg As New DatosDelContribuyenteDlg
        dcdlg.HojaResumen = _hojaResumen.clone
        If dcdlg.ShowDialog(Me) = DialogResult.OK Then
            _hojaResumen = dcdlg.HojaResumen
            Validate()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim stream = File.Open("d:\prueba.dj", FileMode.Create)
        Dim formatter As New binaryFormatter
        formatter.Serialize(stream, _hojaResumen)
        stream.Close()
    End Sub
End Class
