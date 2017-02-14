
Imports System.ComponentModel
Imports System.Net.Security
Imports SimuladorImpuestoPredial.Entidades

Namespace ImpPred
    Public Class Construccion
        Implements INotifyPropertyChanged

        Private Shared ReadOnly Cats As String() = New String() {"mc", "t", "p", "pv", "r", "b", "ies"}
        Private _areaConstruida As Decimal
        Private _nivel As Integer = 1
        Private _año As Integer = Year(Now)
        Private _mes As Integer = Month(Now)
        Private _cies As String = "A"
        Private _cb As String = "A"
        Private _cr As String = "A"
        Private _cpv As String = "A"
        Private _cp As String = "A"
        Private _ct As String = "A"
        Private _cmc As String = "A"
        Private _material As Integer = 1
        Private _estado As Integer = 1
        Private _areaConstruidaComunPorcentaje As Decimal
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Property Nivel As Integer
            Get
                Return _nivel
            End Get
            Set
                _nivel = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Nivel)))
            End Set
        End Property
        Property Año As Integer
            Get
                Return _año
            End Get
            Set
                _año = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Año)))
            End Set
        End Property
        Property Mes As Integer
            Get
                Return _mes
            End Get
            Set
                _mes = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Mes)))
            End Set
        End Property
        ReadOnly Property Clasificacion As Integer
            Get
                Return Predio.Clasificacion
            End Get
        End Property
        ReadOnly Property Antiguedad As Double
            Get
                Return GetAntiguedad(Año, Mes)
            End Get
        End Property
        ReadOnly Property Categorias As String
            Get
                Return $"{Cmc}{CT}{CP}{Cpv}{CR}{CB}{Cies}"
            End Get
        End Property
        Property Cies As String
            Get
                Return _cies
            End Get
            Set
                _cies = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Cies)))
            End Set
        End Property
        Property CB As String
            Get
                Return _cb
            End Get
            Set
                _cb = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(CB)))
            End Set
        End Property
        Property CR As String
            Get
                Return _cr
            End Get
            Set
                _cr = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(CR)))
            End Set
        End Property
        Property Cpv As String
            Get
                Return _cpv
            End Get
            Set
                _cpv = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Cpv)))
            End Set
        End Property
        Property CP As String
            Get
                Return _cp
            End Get
            Set
                _cp = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(CP)))
            End Set
        End Property
        Property CT As String
            Get
                Return _ct
            End Get
            Set
                _ct = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(CT)))
            End Set
        End Property
        Property Cmc As String
            Get
                Return _cmc
            End Get
            Set
                _cmc = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Cmc)))
            End Set
        End Property
        Property Material As Integer
            Get
                Return _material
            End Get
            Set
                _material = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Material)))
            End Set
        End Property
        Property Estado As Integer
            Get
                Return _estado
            End Get
            Set
                _estado = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Estado)))
            End Set
        End Property
        Private Function GetValueFromCategoria(strCat As String) As Decimal
            Dim cat As Categoria = Nothing
            If Not ParametrosCalculo.GetCategorias().TryGetValue(CallByName(Me, $"C{strCat}", CallType.Get), cat) Then _
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
                Return GetDepreciacion(Antiguedad, Predio.Clasificacion, Estado, Material)
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
            Get
                Return _areaConstruida
            End Get
            Set
                _areaConstruida = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(AreaConstruida)))
            End Set
        End Property
        ReadOnly Property AreaConstruidaValor As Decimal
            Get
                Return ValorUnitarioDepreciado * AreaConstruida
            End Get
        End Property
        Property AreaConstruidaComunPorcentaje As Decimal
            Get
                Return _areaConstruidaComunPorcentaje
            End Get
            Set
                _areaConstruidaComunPorcentaje = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(AreaConstruidaComunPorcentaje)))
            End Set
        End Property
        ReadOnly Property AreaConstruidaComunValor As Decimal
            Get
                Return AreaConstruidaValor * AreaConstruidaComunPorcentaje / 100
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