Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Ifp
    <Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Property IdIfp As Integer

    Property Desc As String
    Property IdUm As Integer
    Property IdIfpDeno As Integer
    Property IdDescComp As Integer

    <ForeignKey(NameOf(IdIfpDeno))>
    Overridable Property IfpDeno As IfpDeno

    <ForeignKey(NameOf(IdUm))>
    Overridable Property IfpUm As IfpUm

    Overridable Property IfpVus As BindingList(Of IfpVu)
End Class