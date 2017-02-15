Imports System.Security.Permissions
Imports SimuladorImpuestoPredial.Entidades

Namespace ImpPred
    Public Class ObraComplementaria
        Property idIfp As Integer
        ReadOnly Property CodIfp As String
            Get
                Return $"{Ifp?.IfpDeno?.IdIfpDeno}.{Ifp?.IdDescComp}"
            End Get
        End Property
        Property Año As Integer
        Property Mes As Integer
        ReadOnly Property Antiguedad As Double
            Get
                Return GetAntiguedad(Año, Mes)
            End Get
        End Property
        ReadOnly Property Denominacion As String
            Get
                Return Ifp?.IfpDeno?.Desc
            End Get
        End Property
        ReadOnly Property Componente As String
            Get
                Return Ifp?.Desc
            End Get
        End Property
        ReadOnly Property ValorUnitario As Decimal
        Property Material As Integer
        Property Estado As Integer
        ReadOnly Property PorcDepreciacion As Decimal
            Get
                Return GetDepreciacion(Antiguedad, Predio.Clasificacion, Estado, Material)
            End Get
        End Property
        ReadOnly Property Depreciacion As Decimal
            Get
                Return ValorUnitario * PorcDepreciacion / 100
            End Get
        End Property
        ReadOnly Property ValorUnitarioDepreciado As Decimal
            Get
                Return ValorUnitario - Depreciacion
            End Get
        End Property
        Property Cantidad As Decimal
        ReadOnly Property UnidadMedida As String
            Get
                Return Ifp?.IfpUM?.Abb
            End Get
        End Property
        Property PorcPartic As Decimal = 100
        ReadOnly Property Fo As Decimal
            Get
                Return GetFactorOficializacion()
            End Get
        End Property
        ReadOnly Property Valor As Decimal
            Get
                Return ValorUnitarioDepreciado * PorcPartic * Fo * Cantidad / 100
            End Get
        End Property
        ReadOnly Property Ifp As Ifp
        Property Predio As Predio
    End Class
End NameSpace