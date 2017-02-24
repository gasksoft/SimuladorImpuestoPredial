Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
<Serializable>
Public Class IfpUm
    <Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Property IdUm As Integer

    Property Desc As String
    Property Abb As String
    Overridable Property Ifps As BindingList(Of Ifp)
End Class
