Imports System.ComponentModel.DataAnnotations

Public Class UsoGrupo
    Sub New()
    End Sub
    <Key>
    Public Property CodGrupo As Integer
    Public Property Grupo As String
    Public Overridable Property SubGrupos As New List(Of UsoSubGrupo)
End Class
