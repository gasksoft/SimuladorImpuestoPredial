Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Ifp
    <Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Property IdIfp As Integer
    Property Desc As String
    Property IdUm As Integer
    Property IdIfpDeno As Integer
    Property IdDescComp As Integer
    Overridable Property IfpDeno As IfpDeno
    Overridable Property IfpUm As IfpUm
End Class

Public Class IfpUm
    <Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Property IdUm As Integer
End Class

Public Class IfpDeno
    <Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Property IdIfpDeno As Integer
    Property Desc As String
End Class
