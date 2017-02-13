Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entidades
    Public Class IfpDeno
        <Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)>
        Property IdIfpDeno As Integer
        Property Desc As String
        Overridable Property Ifps As BindingList(Of Ifp)
    End Class
End NameSpace