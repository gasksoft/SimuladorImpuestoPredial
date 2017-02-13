Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entidades
    Public Class IfpUM
        <Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)>
        Property IdUM As Integer
        Property Desc As String
        Property Abb As String
    End Class
End NameSpace