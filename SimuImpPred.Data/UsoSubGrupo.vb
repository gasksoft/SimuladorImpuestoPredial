Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class UsoSubGrupo
    <Key, Column(Order:=0)>
    Public Property CodGrupo As Integer
    <Key, Column(Order:=1)>
    Public Property CodSubGrupo As Integer
    Public Property SubGrupo As String
    <ForeignKey(NameOf(CodGrupo))>
    Public Overridable Property Grupo As UsoGrupo
    Public Overridable Property Usos As New List(Of Uso)
End Class
