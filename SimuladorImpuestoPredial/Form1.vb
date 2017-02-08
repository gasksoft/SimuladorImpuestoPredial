Imports SimuladorImpuestoPredial.ImpPred

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aaaa As New ImpuestoPredial
        aaaa.Año = 2017
        Dim p As New Predio
        p.ImpuestoPredial = aaaa
        aaaa.Predios.Add(p)
        Dim aaaaaaaaa = aaaa.Uit
    End Sub
End Class
