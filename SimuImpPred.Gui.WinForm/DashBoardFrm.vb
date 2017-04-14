Imports SimuImpPred.ObjectModel

Public Class DashBoardFrm
    Private _hojaResumen As HojaResumen = HojaResumen.Instancia
    Private Shared _instancia As DashBoardFrm

    Private Sub DashBoardFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetTitle()
    End Sub

    Private Sub SetTitle()
        Text = $"Impuesto Predial {ParametrosCalculo.Instancia.Año}"
    End Sub

    Shared ReadOnly Property Instancia As DashBoardFrm
        Get
            If _instancia Is Nothing Then
                _instancia = New DashBoardFrm
            End If
            Return _instancia
        End Get
    End Property

    Private Sub SalirMl_Click(sender As Object, e As EventArgs) Handles SalirMl.Click
        End
    End Sub

    Private Sub AcercaDeMl_Click(sender As Object, e As EventArgs) Handles AcercaDeMl.Click
        Dim about As New AboutBox
        about.ShowDialog(Me)
    End Sub

    Private Sub SetupMl_Click(sender As Object, e As EventArgs) Handles SetupMl.Click
        Dim setup As New SetupFrm
        setup.ShowDialog(Me)
    End Sub
End Class
