Imports SimuImpPred.Data

<Serializable>
Public Class OtraInstalacion
    Inherits Instalacion

    Public Property Ifp As Ifp
    Public Property Cantidad As Decimal
    Public Property PorcPartPredio As Decimal

    Public ReadOnly Property Cod As String
        Get
            Return $"{Ifp?.IdIfpDeno}.{Ifp?.IdDescComp}"
        End Get
    End Property

    Public ReadOnly Property Denominacion As String
        Get
            Return Ifp.Desc
        End Get
    End Property

    Public Overrides ReadOnly Property ValorUnitario As Decimal
        Get
            Dim v As Decimal = 0
            ParametrosCalculo.Instancia.Ifps.TryGetValue(Ifp.IdIfp, v)
            Return v
        End Get
    End Property

    Public ReadOnly Property Unidad As String
        Get
            Return Ifp?.IfpUm?.Abb
        End Get
    End Property

    Protected Overrides ReadOnly Property ValorUnitarioIncrementado As Decimal
        Get
            Return ValorUnitario
        End Get
    End Property

    ReadOnly Property Fo As Decimal
        Get
            Return ParametrosCalculo.Instancia.Fo
        End Get
    End Property

    Public Overrides ReadOnly Property Valor As Decimal
        Get
            Return ValorUnitarioIncrementado * Cantidad * PorcPartPredio * Fo / 100
        End Get
    End Property
End Class