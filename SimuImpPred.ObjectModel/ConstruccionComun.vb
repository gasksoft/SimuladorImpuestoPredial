Public Class ConstruccionComun
    Inherits Construccion
    Private _porcPartPredio As Decimal

    Public Property PorcPartPredio As Decimal
        Get
            Return _porcPartPredio
        End Get
        Set
            _porcPartPredio = Value
            OnPropertyChanged()
        End Set
    End Property

    Public ReadOnly Property ValorAreaConstruidaComun As Decimal
        Get
            Return MyBase.Valor
        End Get
    End Property

    Public Overrides ReadOnly Property Valor As Decimal
        Get
            Return ValorAreaConstruidaComun * PorcPartPredio / 100
        End Get
    End Property
End Class