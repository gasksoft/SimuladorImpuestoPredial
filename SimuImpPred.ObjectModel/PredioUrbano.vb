<Serializable>
Public Class PredioUrbano
    Inherits Predio
    Public Property Frente As Decimal
    Public Property AreaTerrenoPropio As Decimal
    Public Property AreaTerrenoComun As Decimal

    Public ReadOnly Property AreaTerrenoTotal As Decimal
        Get
            Return AreaTerrenoComun + AreaTerrenoPropio
        End Get
    End Property

    Public Property Arancel As Decimal

    Public Overrides ReadOnly Property ValorTotalTerreno As Decimal
        Get
            Return AreaTerrenoTotal * Arancel
        End Get
    End Property

    Public Overrides ReadOnly Property Tipo As String
        Get
            Return "Urbano"
        End Get
    End Property
End Class