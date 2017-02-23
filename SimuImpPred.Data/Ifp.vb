Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Ifp
    <Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property IdIfp As Integer

    Public Property Desc As String
    Public Property IdUm As Integer
    Public Property IdIfpDeno As Integer
    Public Property IdDescComp As Integer

    <ForeignKey(NameOf(IdIfpDeno))>
    Public Overridable Property IfpDeno As IfpDeno

    <ForeignKey(NameOf(IdUm))>
    Public Overridable Property IfpUm As IfpUm

    Public Overridable Property IfpVus As BindingList(Of IfpVu)
End Class