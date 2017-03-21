Imports System.ComponentModel

<Serializable>
Public Class PredioRustico
    Inherits Predio
    Sub New()
        Colindantes = New List(Of Colindante)
        ValoresTerrenoRural = New BindingList(Of ValorTerrenoRural)
    End Sub

    Public ReadOnly Property Colindantes As List(Of Colindante)

    Public Property TipoTerreno As Integer
    Public Property UsoTerreno As Integer
    Public ReadOnly Property ValoresTerrenoRural As BindingList(Of ValorTerrenoRural)

    Public Overrides ReadOnly Property ValorTotalTerreno As Decimal
        Get
            Return ValoresTerrenoRural.Sum(Function(t) t.Valor)
        End Get
    End Property

    Public Overrides ReadOnly Property Deduccion As Decimal
        Get
            Return If(UsoTerreno = 1, ValorPorcPropiedad * 0.5, 0)
        End Get
    End Property

    Public Overrides ReadOnly Property Tipo As String
        Get
            Return "Rustico"
        End Get
    End Property
End Class