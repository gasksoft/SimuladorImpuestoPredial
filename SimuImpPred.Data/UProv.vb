Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Serializable>
Public Class UProv
    <Key, Column(Order:=0)>
    Public Property CodDep As String

    <Key, Column(Order:=1)>
    Public Property CodProv As String

    Public Property Prov As String
    Public Overridable Property Distritos As New BindingList(Of UDis)

    <ForeignKey(NameOf(CodDep))>
    Public Overridable Property Departamento As UDep
End Class