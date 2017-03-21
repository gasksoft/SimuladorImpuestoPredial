Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Serializable>
Public Class UDis
    <Key, Column(Order := 0)>
    Public Property CodDep As String

    <Key, Column(Order := 1)>
    Public Property CodProv As String

    <Key, Column(Order := 2)>
    Public Property CodDis As String

    Public Property Dis As String

    <ForeignKey("CodDep,CodProv")>
    Public Overridable Property Provincia As UProv
End Class