Imports SimuladorImpuestoPredial.Entidades
Imports SimuladorImpuestoPredial.ImpPred

Public Class Form1
    Private ReadOnly _impuestoPredial As New ImpuestoPredial(_contexto)
    Private ReadOnly _contexto As New Contexto
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In (From u In _contexto.Uits Order By u.Año Descending Select u.Año).ToList
            ToolStripDropDownButton1.Items.Add(item)
            ToolStripDropDownButton1.SelectedIndex = 0
        Next

        ImpuestoPredialBindingSource.DataSource = _impuestoPredial
    End Sub
End Class
