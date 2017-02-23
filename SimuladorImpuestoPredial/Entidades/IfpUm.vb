Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entidades
    Public Class IfpUM
        <Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)>
        Property IdUm As Integer

        Property Desc As String
        Property Abb As String
        Overridable Property Ifps As BindingList(Of Ifp)
    End Class
End NameSpace