Public Class ImpuestoPredial
    Sub New()
        Predios = New List(Of Predio)
    End Sub

    Property Año As Integer
    ReadOnly Property Predios As List(Of Predio)
    ReadOnly Property BaseImponible As Decimal
        Get
            Return Predios.Sum(Function(p) p.Avaluo)
        End Get
    End Property

End Class
Public Class Predio
    Sub New()
        Construcciones = New List(Of Construccion)
    End Sub

    Property Arancel As Decimal
    Property TerrenoAreaExclusiva As Decimal
    Property TerrenoAreaComun As Decimal
    ReadOnly Property TerrenoAreaTotal As Decimal
        Get
            Return TerrenoAreaComun + TerrenoAreaExclusiva
        End Get
    End Property
    ReadOnly Property TerrenoValor As Decimal
        Get
            Return TerrenoAreaTotal * Arancel
        End Get
    End Property
    ReadOnly Property Construcciones As List(Of Construccion)
    ReadOnly Property ConstruccionesValor As Decimal
        Get
            Return Construcciones.Sum(Function(c) c.Valor)
        End Get
    End Property
    ReadOnly Property Avaluo As Decimal
        Get
            Return TerrenoValor + ConstruccionesValor
        End Get
    End Property

    Property ImpuestoPredial As ImpuestoPredial
End Class

Public Class Construccion
    Property Nivel As String
    Property Año As Integer
    Property Mes As Integer
    Public ReadOnly Property Valor As Decimal
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Property Predio As Predio
End Class
