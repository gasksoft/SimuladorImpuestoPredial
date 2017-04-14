Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Uso
    <Key, Column(Order:=0)>
    Public Property CodGrupo As Integer
    <Key, Column(Order:=1)>
    Public Property CodSubGrupo As Integer
    <Key, Column(Order:=2)>
    Public Property CodUso As Integer
    Public Property Nombre As String
    <ForeignKey("CodGrupo,CodSubGrupo")>
    Public Overridable Property SubGrupo As UsoSubGrupo
End Class
