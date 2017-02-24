<Serializable>
Public Class PredioUrbano
    Inherits Predio
    Private _areaTerrenoPropio As Decimal
    Private _areaTerrenoComun As Decimal
    Private _arancel As Decimal
    Public Property Frente As Decimal

    Public Property AreaTerrenoPropio As Decimal
        Get
            Return _areaTerrenoPropio
        End Get
        Set
            _areaTerrenoPropio = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property AreaTerrenoComun As Decimal
        Get
            Return _areaTerrenoComun
        End Get
        Set
            _areaTerrenoComun = Value
            OnPropertyChanged()
        End Set
    End Property

    Public ReadOnly Property AreaTerrenoTotal As Decimal
        Get
            Return AreaTerrenoComun + AreaTerrenoPropio
        End Get
    End Property

    Public Property Arancel As Decimal
        Get
            Return _arancel
        End Get
        Set
            _arancel = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Overrides ReadOnly Property ValorTotalTerreno As Decimal
        Get
            Return AreaTerrenoTotal*Arancel
        End Get
    End Property
End Class