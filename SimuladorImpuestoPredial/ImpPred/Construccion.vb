
Imports SimuladorImpuestoPredial.Entidades

Namespace ImpPred
    Public Class Construccion
        Private Shared ReadOnly Cats As String() = New String() {"mc", "t", "p", "pv", "r", "b", "ies"}
        Property Nivel As Integer = 1
        Property Año As Integer = Year(Now)
        Property Mes As Integer = Month(Now)
        ReadOnly Property Clasificacion As Integer
            Get
                Return Predio?.Clasificacion
            End Get
        End Property
        ReadOnly Property Antiguedad As Double
            Get
                Return DateDiff(DateInterval.Month, New Date(Año, Mes, 1), Now) / 12
            End Get
        End Property
        ReadOnly Property Categorias As String
            Get
                Return $"{Cmc}{Ct}{Cp}{Cpv}{Cr}{Cb}{Cies}"
            End Get
        End Property
        Property Cies As String = "A"
        Property Cb As String = "A"
        Property Cr As String = "A"
        Property Cpv As String = "A"
        Property Cp As String = "A"
        Property Ct As String = "A"
        Property Cmc As String = "A"
        Property Material As Integer = 1
        Property Estado As Integer = 1
        Private Function GetValueFromCategoria(strCat As String) As Decimal
            Dim cat As Categoria = Nothing
            If Not ParametrosCalculo.Categorias.TryGetValue(CallByName(Me, $"C{strCat}", CallType.Get), cat) Then _
                Return 0
            Return If(CallByName(cat, $"V{strCat}", CallType.Get), 0)
        End Function
        ReadOnly Property ValorUnitario As Decimal
            Get
                Return (Cats).Sum(Function(c) GetValueFromCategoria(c))
            End Get
        End Property
        ReadOnly Property Incremento5Porc As Decimal
            Get
                Return If(Nivel > 4, ValorUnitario * 0.05, 0)
            End Get
        End Property
        ReadOnly Property ValorUnitarioIncrementado As Decimal
            Get
                Return ValorUnitario + Incremento5Porc
            End Get
        End Property
        ReadOnly Property PorcDepreciacion As Decimal
            Get
                Dim ga As Integer = Math.Min(Math.Max(Math.Ceiling(Antiguedad / 5) * 5, 5), 55)
                Return (
                    From d In ParametrosCalculo.Depreciaciones
                    Where d.Antiguedad = ga And
                              d.Clasificacion = Predio.Clasificacion And
                              d.Estado = Estado And
                              d.Material = Material).FirstOrDefault?.Porcentaje
            End Get
        End Property
        ReadOnly Property ValorDepreciacion As Decimal
            Get
                Return ValorUnitarioIncrementado * PorcDepreciacion / 100
            End Get
        End Property
        ReadOnly Property ValorUnitarioDepreciado As Decimal
            Get
                Return ValorUnitarioIncrementado * (1 - PorcDepreciacion / 100)
            End Get
        End Property
        Property AreaConstruida As Decimal
        ReadOnly Property AreaConstruidaValor As Decimal
            Get
                Return ValorUnitarioDepreciado * AreaConstruida
            End Get
        End Property
        Property AreaConstruidaComunPorcentaje As Decimal
        ReadOnly Property AreaConstruidaComunValor As Decimal
            Get
                Return AreaConstruidaValor * AreaConstruidaComunPorcentaje
            End Get
        End Property
        Public ReadOnly Property Valor As Decimal
            Get
                Return If(AreaConstruidaComunValor > 0, AreaConstruidaComunValor, AreaConstruidaValor)
            End Get
        End Property
        Public Property Predio As Predio
    End Class
End Namespace