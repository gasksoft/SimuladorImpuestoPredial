Namespace ImpPred
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
    End Class
End Namespace