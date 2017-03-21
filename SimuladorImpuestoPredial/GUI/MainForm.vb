Imports MetroFramework.Controls
Imports SimuImpPred.Gui.My.Resources
Imports SimuImpPred.ObjectModel

Namespace GUI
    Public Class MainForm
        Private ReadOnly _dashBoardUc As New DashBoardUc
        Private Shared _instancia As MainForm
        Private _filename As String

        Public Shared ReadOnly Property Instancia As MainForm
            Get
                If _instancia Is Nothing Then
                    _instancia = New MainForm
                End If
                Return _instancia
            End Get
        End Property
        Public Property Contenedor As MetroPanel
            Get
                Return MpContainer
            End Get
            Set
                MpContainer = Value
            End Set
        End Property
        Public Property GoToBack As MetroLink
            Get
                Return MlGoBack
            End Get
            Set
                MlGoBack = Value
            End Set
        End Property

        Public ReadOnly Property Hr As HojaResumen
            Get
                Return HojaResumen.Instancia
            End Get
        End Property

        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'HojaResumen.Instancia.Predios.Add(New PredioUrbano With {.AreaTerrenoPropio = 1000, .Arancel = 180})
            Icon = Icono
            ParametrosCalculoBindingSource.DataSource = ParametrosCalculo.Instancia

            MlGoBack.Visible = False
            _instancia = Me
            _dashBoardUc.Dock = DockStyle.Fill
            _dashBoardUc.Enlazar()
            MpContainer.Controls.Add(_dashBoardUc)
        End Sub

        Private Sub MtParametrosCalculo_Click(sender As Object, e As EventArgs) Handles MtParametrosCalculo.Click
            Dim dlg As New ChangeYearDlg
            If dlg.ShowDialog(Me) = DialogResult.OK Then
                ParametrosCalculo.Instancia.Año = dlg.Año
                ParametrosCalculoBindingSource.ResetBindings(False)
                _dashBoardUc.Enlazar()
            End If
        End Sub

        Private Sub MtNewHr_Click(sender As Object, e As EventArgs) Handles MtNewHr.Click
            HojaResumen.SetInstance(New HojaResumen)
            _dashBoardUc.Enlazar()
            _filename = ""
        End Sub

        Private Sub MtOpenHr_Click(sender As Object, e As EventArgs) Handles MtOpenHr.Click
            Dim openFileDialog As New OpenFileDialog
            openFileDialog.Filter = FilterExtensionForOpenHr
            If openFileDialog.ShowDialog(Me) = DialogResult.OK Then
                _filename = openFileDialog.FileName
#If DEBUG Then
                Dim aa = Now
#End If
                HojaResumen.SetInstance(Common.DescomprimeYDeseria(Of HojaResumen)(_filename))
                _dashBoardUc.Enlazar()
#If DEBUG Then
                MsgBox((Now - aa).ToString)
#End If
            End If
        End Sub

        Private Sub MtSaveHr_Click(sender As Object, e As EventArgs) Handles MtSaveHr.Click
            If _filename = "" Then
                MtSaveAsHr.PerformClick()
                Exit Sub
            End If
            If Not Validate() Then Return
            Common.SeriaYComprime(HojaResumen.Instancia, _filename)
            Validate()
        End Sub

        Private Sub MtSaveAsHr_Click(sender As Object, e As EventArgs) Handles MtSaveAsHr.Click
            Dim saveFileDialog As New SaveFileDialog
            saveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            saveFileDialog.Filter = FilterExtensionForOpenHr
            saveFileDialog.FileName = HojaResumen.Instancia.NombreHr
            saveFileDialog.ShowDialog(Me)

            _filename = saveFileDialog.FileName
            MtSaveHr.PerformClick()
        End Sub

        Private Sub MlGoBack_Click(sender As Object, e As EventArgs) Handles MlGoBack.Click
            MpContainer.Controls("DashBoardUc").BringToFront()
            MlGoBack.Visible = False
        End Sub
    End Class
End Namespace