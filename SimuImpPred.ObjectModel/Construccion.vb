Imports SimuImpPred.Data

Public Class Construccion
    Inherits Instalacion
    Private Shared ReadOnly Cats As String() = New String() {"mc", "t", "p", "pv", "r", "b", "ies"}
    Private _piso As String
    Private _cies As String
    Private _cb As String
    Private _cr As String
    Private _cpv As String
    Private _cp As String
    Private _ct As String
    Private _cmc As String
    Private _areaConstruida As Decimal
    Public Property TipoPiso As Integer

    Public Property Piso As String
        Get
            Return _piso
        End Get
        Set
            _piso = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Cies As String
        Get
            Return _cies
        End Get
        Set
            _cies = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Cb As String
        Get
            Return _cb
        End Get
        Set
            _cb = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Cr As String
        Get
            Return _cr
        End Get
        Set
            _cr = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Cpv As String
        Get
            Return _cpv
        End Get
        Set
            _cpv = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Cp As String
        Get
            Return _cp
        End Get
        Set
            _cp = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Ct As String
        Get
            Return _ct
        End Get
        Set
            _ct = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Cmc As String
        Get
            Return _cmc
        End Get
        Set
            _cmc = Value
            OnPropertyChanged()
        End Set
    End Property

    Public ReadOnly Property Categorias As String
        Get
            Return $"{Cmc}{Ct}{Cp}{Cpv}{Cr}{Cb}{Cies}"
        End Get
    End Property

    Public Property AreaConstruida As Decimal
        Get
            Return _areaConstruida
        End Get
        Set
            _areaConstruida = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Overrides ReadOnly Property ValorUnitario As Decimal
        Get
            Return Cats.Sum(
                Function(c)
                    Dim cat As Categoria = Nothing
                    Dim catBd = Predio?.HojaResumen?.ParametrosCalculo?.Categorias
                    If Not catBd.TryGetValue(CallByName(Me, $"C{c}", CallType.Get), cat) Then
                        Return 0
                    End If
                    Return If(CallByName(cat, $"V{c}", CallType.Get), 0)
                End Function)
        End Get
    End Property

    Public ReadOnly Property Inc5Porc As Decimal
        Get
            Return If(Piso > 4, ValorUnitario * 0.05, 0)
        End Get
    End Property

    Protected Overrides ReadOnly Property ValorUnitarioIncrementado As Decimal
        Get
            Return ValorUnitario + Inc5Porc
        End Get
    End Property

    Public Overrides ReadOnly Property Valor As Decimal
        Get
            Return ValorUnitarioIncrementado * AreaConstruida
        End Get
    End Property
End Class
