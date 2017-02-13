Namespace ImpPred
    Public Class ObraComplementaria
        Property CodDen As Integer
        Property CodCom As Integer
        Property Año As Integer
        Property Mes As Integer
        ReadOnly Property Antiguedad As Double
            Get
                Return GetAntiguedad(Año, Mes)
            End Get
        End Property
        ReadOnly Property Denominacion As String
        ReadOnly Property Componente As String
        ReadOnly Property ValorUnitario As Decimal
        ReadOnly Property UnidadMedida As String
        Property Material As Integer
        Property Estado As Integer
        Property PorcPartic As Decimal = 100
        Property Cantidad As Decimal
        ReadOnly Property Valor As Decimal
        Property Predio As Predio
    End Class
End NameSpace