Imports System.IO
Imports System.IO.Compression
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Cryptography
Imports System.Text
Imports SimuImpPred.ObjectModel

Public Class MainForm
    Dim _hojaResumen As New HojaResumen
    Dim _filename As String

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        CondicionEspecialContribuyenteComboBox.DataSource = CondicionEspecialContribuyenteDic.ToList
        CondicionEspecialContribuyenteComboBox.ValueMember = "Key"
        CondicionEspecialContribuyenteComboBox.DisplayMember = "Value"

        HojaResumenBindingSource.DataSource = _hojaResumen






        For I = 0 To 10
            Dim pu As New PredioUrbano
            For j = 0 To 20
                Dim c As New Construccion
                pu.Construcciones.Add(c)
            Next
            _hojaResumen.Predios.Add(pu)
        Next


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
        openFileDialog.Filter = "Archivos de declaraciones juradas (*.dj)|*.dj"
        openFileDialog.ShowDialog(Me)

        _filename = openFileDialog.FileName

        Dim stream = File.Open(_filename, FileMode.Open)
        Dim formatter As New BinaryFormatter
        _hojaResumen = formatter.Deserialize(stream)
        stream.Close()
        HojaResumenBindingSource.DataSource = _hojaResumen
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        saveFileDialog.Filter = "Archivos de declaraciones juradas (*.dj)|*.dj"
        saveFileDialog.ShowDialog(Me)

        _filename = saveFileDialog.FileName
        SaveToolStripMenuItem.PerformClick()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'If _filename = "" Then
        '    SaveAsToolStripMenuItem.PerformClick()
        '    Exit Sub
        'End If
        Dim streamt = New MemoryStream ' File.Open(_filename, FileMode.Create)
        Dim formattert As New BinaryFormatter
        SyncLock locker
            formattert.Serialize(streamt, _hojaResumen)
        End SyncLock

        Dim buffer = streamt.ToArray
        Dim hash = GetHash(buffer)
        If hash <> hash1 Then
            If buf1 Is Nothing Then buf1 = buffer
            MsgBox($"{hash}-{hash.Length}  -  {hash1}-{hash1.Length}     {buffer.Equals(buf1) }")

            For i = 0 To buffer.Length - 1
                If buffer(i) <> buf1(i) Then
                    MsgBox(i)
                End If
            Next
        End If
        hash1 = hash
        buf1 = buffer
        streamt.Close()
        'SeriaYComprime(_hojaResumen, _filename)



        Return

        If _filename = "" Then
            SaveAsToolStripMenuItem.PerformClick()
            Exit Sub
        End If
        Dim stream = File.Open(_filename, FileMode.Create)
        Dim formatter As New BinaryFormatter
        formatter.Serialize(stream, _hojaResumen)
        stream.Close()
    End Sub
    Dim hash1 As String = "sss"
    Dim buf1 As Byte()
    Private Shared ReadOnly locker As New Object()

    Private Shared Function GetHash(bytes As Byte()) As String
        Return MD5.Create().ComputeHash(bytes).Aggregate("", Function(current, b) current & $"{b:x2}")
    End Function
    Private Shared Function GetHash(str As String) As String
        Return GetHash(New ASCIIEncoding().GetBytes(str))
    End Function
    Private Shared Sub SeriaYComprime(obj As Object, arch As String)
        Using fs As New FileStream(arch, FileMode.OpenOrCreate, FileAccess.Write)
            Using zs As New GZipStream(fs, CompressionMode.Compress, True)
                Dim bf = New BinaryFormatter()
                bf.Serialize(zs, obj)
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dcdlg As New DatosDelContribuyenteDlg
        Validate()
        dcdlg.HojaResumen = _hojaResumen.Clone
        If dcdlg.ShowDialog(Me) = DialogResult.OK Then
            _hojaResumen = dcdlg.HojaResumen
            HojaResumenBindingSource.DataSource = _hojaResumen
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dfdlg As New DomicilioFiscalDlg
        Validate()
        dfdlg.HojaResumen = _hojaResumen.Clone
        If dfdlg.ShowDialog(Me) = DialogResult.OK Then
            _hojaResumen = dfdlg.HojaResumen
            HojaResumenBindingSource.DataSource = _hojaResumen
        End If
    End Sub
End Class
