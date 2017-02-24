Imports SimuImpPred.Data
<Serializable>
Public Class OtraInstalacion
    Inherits Instalacion
    Private _ifp As Ifp
    Private _cantidad As Decimal
    Private _porcPartPredio As Decimal

    Public Property Ifp As Ifp
        Get
            Return _ifp
        End Get
        Set
            _ifp = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Cantidad As Decimal
        Get
            Return _cantidad
        End Get
        Set
            _cantidad = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property PorcPartPredio As Decimal
        Get
            Return _porcPartPredio
        End Get
        Set
            _porcPartPredio = Value
            OnPropertyChanged()
        End Set
    End Property

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
            Predio?.HojaResumen?.ParametrosCalculo?.Ifps.TryGetValue(Ifp.IdIfp, v)
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
            Return Predio?.HojaResumen?.ParametrosCalculo?.Fo
        End Get
    End Property
    Public Overrides ReadOnly Property Valor As Decimal
        Get
            Return ValorUnitarioIncrementado * Cantidad * PorcPartPredio * Fo / 100
        End Get
    End Property
End Class