Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entidades
    Public Class IfpVu
        <Key, Column(Order:=0)>
        Property IdIfp As Integer
        <Key, Column(Order:=1)>
        <ForeignKey(NameOf(IdIfp))>
        Property A�o As Integer
        Property Valor As Decimal
    End Class
End NameSpace