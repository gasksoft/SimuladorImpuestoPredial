Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Serializable>
Public Class IfpVu
    <Key, Column(Order := 0)>
    Public Property IdIfp As Integer

    <Key, Column(Order := 1)>
    Public Property Año As Integer

    Public Property Valor As Decimal

    <ForeignKey(NameOf(IdIfp))>
    Overridable Property Ifp As Ifp
End Class