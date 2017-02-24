Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
<Serializable>
Public Class Categoria
    <Key, Column(Order := 0)>
    Property Año As Integer

    <Key, Column(Order := 1)>
    Property Cat As String

    Public Property Vies As Decimal?
    Public Property Vb As Decimal?
    Public Property Vr As Decimal?
    Public Property Vpv As Decimal?
    Public Property Vp As Decimal?
    Public Property Vt As Decimal?
    Public Property Vmc As Decimal?
End Class