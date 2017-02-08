Imports SimuladorImpuestoPredial.Entidades
Imports SimuladorImpuestoPredial.ImpPred

Public Class Form1
    Private ReadOnly _impuestoPredial As New ImpuestoPredial(_contexto)
    Private ReadOnly _contexto As New Contexto
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripDropDownButton1.Items.Add(_contexto)
        ImpuestoPredialBindingSource.DataSource = _impuestoPredial
    End Sub
End Class
