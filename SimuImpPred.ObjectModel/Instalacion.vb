Imports System.ComponentModel
Imports System.Runtime.CompilerServices
<Serializable>
Public MustInherit Class Instalacion
    Implements INotifyPropertyChanged
    Private _mes As Integer
    Private _año As Integer
    Private _mep As Integer
    Private _ec As Integer
    Property Predio As Predio

    Public Property Mes As Integer
        Get
            Return _mes
        End Get
        Set
            _mes = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Año As Integer
        Get
            Return _año
        End Get
        Set
            _año = Value
            OnPropertyChanged()
        End Set
    End Property

    Public ReadOnly Property MesAño As String
        Get
            Return $"{Mes:D2}-{Año:D4}"
        End Get
    End Property

    Public Property Mep As Integer
        Get
            Return _mep
        End Get
        Set
            _mep = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Ec As Integer
        Get
            Return _ec
        End Get
        Set
            _ec = Value
            OnPropertyChanged()
        End Set
    End Property

    Public MustOverride ReadOnly Property ValorUnitario As Decimal
    Protected MustOverride ReadOnly Property ValorUnitarioIncrementado As Decimal

    <NonSerialized>
    Public ReadOnly Property Antiguedad As Decimal
        Get
            Dim fc As Date = If(Predio?.HojaResumen?.ParametrosCalculo.FechaCalculo, Now)
            Return DateDiff(DateInterval.Month, New Date(Año, Mes, 1), fc) / 12
        End Get
    End Property

    Public ReadOnly Property PorcDepreciacion As Decimal
        Get
            Dim ga As Integer = Math.Min(Math.Max(Math.Ceiling(Antiguedad / 5) * 5, 5), 55)
            Dim c = Predio?.ClasificacionPredio
            Return (From d In Predio.HojaResumen.ParametrosCalculo.Depreciaciones
                    Where
                    d.Antiguedad = ga AndAlso
                    d.Clasificacion = c AndAlso
                    d.Estado = Ec AndAlso
                    d.Material = Mep).
                FirstOrDefault?.Porcentaje
        End Get
    End Property

    Public ReadOnly Property ValorDepreciacion As Decimal
        Get
            Return ValorUnitarioIncrementado * PorcDepreciacion / 100
        End Get
    End Property

    Public ReadOnly Property ValorUnitarioDepreciado As Decimal
        Get
            Return ValorUnitarioIncrementado - ValorDepreciacion
        End Get
    End Property

    Public MustOverride ReadOnly Property Valor As Decimal

#Region "implementacion de INotifyPropertyChanged"

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

#End Region
End Class