Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entidades
    Public Class Depreciacion
        <Key, Column(Order := 0)>
        Property Clasificacion As Integer

        <Key, Column(Order := 1)>
        Property Estado As Integer

        <Key, Column(Order := 2)>
        Property Antiguedad As Integer

        <Key, Column(Order := 3)>
        Property Material As Integer

        Property Porcentaje As Integer
    End Class
End Namespace