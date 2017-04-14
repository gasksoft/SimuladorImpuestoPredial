
Imports System.Xml.Serialization

<Serializable>
Public MustInherit Class Instalacion
    <XmlIgnore>
    Public Property Predio As Predio
    Public Property Mes As Integer = Month(Now)
    Public Property Año As Integer = Year(Now)

    Public ReadOnly Property MesAño As String
        Get
            Return $"{Mes:D2}-{Año:D4}"
        End Get
    End Property

    Public Property Mep As Integer = 1
    Public Property Ec As Integer = 1
    Public ReadOnly Property ClasificacionPredio As Integer
        Get
            If Predio Is Nothing Then Return 1
            Return Predio.ClasificacionPredio
        End Get
    End Property
    Public MustOverride ReadOnly Property ValorUnitario As Decimal
    Protected MustOverride ReadOnly Property ValorUnitarioIncrementado As Decimal

    Public ReadOnly Property Antiguedad As Decimal
        Get
            Dim fc As Date = ParametrosCalculo.Instancia.FechaCalculo
            Return DateDiff(DateInterval.Month, New Date(Año, Mes, 1), fc) / 12
        End Get
    End Property

    Public ReadOnly Property PorcDepreciacion As Decimal
        Get
            Dim ga As Integer = Math.Min(Math.Max(Math.Ceiling(Antiguedad / 5) * 5, 5), 55)
            Dim c = ClasificacionPredio
            Dim deprec = ParametrosCalculo.Instancia.Depreciaciones
            Return (
                From d In deprec
                Where
                        d.Antiguedad = ga AndAlso
                        d.Clasificacion = c AndAlso
                        d.Estado = Ec AndAlso
                        d.Material = Mep).
                FirstOrDefault.Porcentaje
        End Get
    End Property

    Public ReadOnly Property ValorDepreciacion As Decimal
        Get
            Return ValorUnitarioIncrementado * PorcDepreciacion / 100
        End Get
    End Property

    Public ReadOnly Property ValorUnitarioDepreciado As Decimal
        Get
            Return ValorUnitarioIncrementado - ValorDepreciacion
        End Get
    End Property

    Public Property PorcPartPredio As Decimal = 100
    Public MustOverride ReadOnly Property Valor As Decimal
End Class