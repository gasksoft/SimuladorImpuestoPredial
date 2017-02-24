Imports System.ComponentModel
<Serializable>
Public Class PredioRural
    Inherits Predio

    Public Property Colindantes As List(Of Colindante)
    Public Property TipoTerreno
    Public Property UsoTerreno As Integer

    Public Property ValoresTerrenoRural As BindingList(Of ValorTerrenoRural)

    Public Overrides ReadOnly Property ValorTotalTerreno As Decimal
        Get
            Return ValoresTerrenoRural.Sum(Function(t) t.Valor)
        End Get
    End Property

    Public ReadOnly Property DeduccionPredioAgrario As Decimal
        Get
            Return If(UsoTerreno = 1, ValorPorcPropiedad*0.5, 0)
        End Get
    End Property

    Public Overrides ReadOnly Property Deduccion As Decimal
        Get
            If HojaResumen?.CondicionEspecialContribuyente > 0 AndAlso HojaResumen?.CondicionEspecialContribuyente <> 12 _
                Then Return ValorPorcPropiedad
            Return MyBase.Deduccion + DeduccionPredioAgrario
        End Get
    End Property
End Class