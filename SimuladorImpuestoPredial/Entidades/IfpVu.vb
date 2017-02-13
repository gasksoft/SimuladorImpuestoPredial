Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entidades
    Public Class IfpVu
        <Key, Column(Order:=0)>
        Property IdIfp As Integer
        <Key, Column(Order:=1)>
        Property Año As Integer
        Property Valor As Decimal
        <ForeignKey(NameOf(IdIfp))>
        Overridable Property Ifp As Ifp
    End Class
End NameSpace