Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

<Serializable>
Public Class UDep
    <Key>
    Public Property CodDep As String

    Public Property Dep As String
    Public Overridable Property Provincias As New BindingList(Of UProv)
End Class