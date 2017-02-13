Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entidades
    Public Class Ifp
        <Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)>
        Property IdIfp As Integer
        Property Desc As String
        Property IdUM As Integer
        Property IdIfpDeno As Integer
        Property IdDescComp As Integer
        <ForeignKey(NameOf(IdIfpDeno))>
        Overridable Property IfpDeno As IfpDeno
        <ForeignKey(NameOf(IdUM))>
        Overridable Property IfpUM As IfpUm
    End Class
End Namespace