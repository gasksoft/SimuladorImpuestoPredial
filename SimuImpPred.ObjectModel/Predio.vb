Imports System.ComponentModel
Imports System.Runtime.CompilerServices
<Serializable>
Public MustInherit Class Predio
    Implements INotifyPropertyChanged

    Private _clasificacionPredio As Integer
    Private _porcProp As Decimal

    Sub New()
        Contratantes = New List(Of DatosPersona)
        Construcciones = New BindingList(Of Construccion)
        ConstruccionesComunes = New BindingList(Of ConstruccionComun)
        OtrasInstalaciones = New BindingList(Of OtraInstalacion)

        AddHandler Construcciones.ListChanged, AddressOf EnlazarListChanged
        AddHandler ConstruccionesComunes.ListChanged, AddressOf EnlazarListChanged
        AddHandler OtrasInstalaciones.ListChanged, AddressOf EnlazarListChanged
    End Sub

    Private Sub EnlazarListChanged(sender As Object, e As ListChangedEventArgs)
        Select Case e.ListChangedType
            Case ListChangedType.ItemAdded
                sender(e.NewIndex).Predio = Me
        End Select
        OnPropertyChanged(NameOf(ValorAutoavaluo))
    End Sub

    Public Property HojaResumen As HojaResumen

    Public ReadOnly Property Anexo As Integer
        Get
            Return HojaResumen?.Predios?.IndexOf(Me)
        End Get
    End Property

    Public Property CodigoPredio As String
    Public Property UbicacionPredio As Direccion
    Public Property CondProp As Integer

    Public Property PorcProp As Decimal
        Get
            Return _porcProp
        End Get
        Set
            _porcProp = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property NumCoprop As Integer
    Public Property TipoPredio As Integer
    Public Property EstadoConstruccion As Integer

    Public Property ClasificacionPredio As Integer
        Get
            Return _clasificacionPredio
        End Get
        Set
            _clasificacionPredio = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property CodUso As String
    Public Property TipoContrato As Integer
    Public Property FechaContrato As Date
    Public ReadOnly Property Contratantes As List(Of DatosPersona)
    Public ReadOnly Property Construcciones As BindingList(Of Construccion)

    Public ReadOnly Property ValorTotalAreaConstruidaPropia As Decimal
        Get
            Return Construcciones.Sum(Function(c) c.Valor)
        End Get
    End Property

    Public ReadOnly Property ConstruccionesComunes As BindingList(Of ConstruccionComun)

    Public ReadOnly Property ValorTotalAreaConstruidaComun As Decimal
        Get
            Return ConstruccionesComunes.Sum(Function(c) c.Valor)
        End Get
    End Property

    Public ReadOnly Property OtrasInstalaciones As BindingList(Of OtraInstalacion)

    Public ReadOnly Property ValorTotalOtrasInstalaciones As Decimal
        Get
            Return OtrasInstalaciones.Sum(Function(c) c.Valor)
        End Get
    End Property

    Public MustOverride ReadOnly Property ValorTotalTerreno As Decimal

    Public ReadOnly Property ValorAutoavaluo As Decimal
        Get
            Return _
                ValorTotalAreaConstruidaPropia + ValorTotalAreaConstruidaComun + ValorTotalOtrasInstalaciones +
                ValorTotalTerreno
        End Get
    End Property

    Public ReadOnly Property ValorPorcPropiedad As Decimal
        Get
            Return ValorAutoavaluo * PorcProp / 100
        End Get
    End Property

    Public ReadOnly Property DeduccionPensionista As Decimal
        Get
            Dim u As Decimal = HojaResumen?.ParametrosCalculo?.Uit
            If HojaResumen?.CondicionEspecialContribuyente = 12 AndAlso HojaResumen?.SueldoPensionista <= u Then
                Return Math.Max(50 * u, ValorPorcPropiedad)
            Else
                Return 0
            End If
        End Get
    End Property

    Public Overridable ReadOnly Property Deduccion As Decimal
        Get
            If HojaResumen?.CondicionEspecialContribuyente > 0 AndAlso HojaResumen?.CondicionEspecialContribuyente <> 12 _
                Then Return ValorPorcPropiedad
            Return DeduccionPensionista
        End Get
    End Property

    Public ReadOnly Property AutoavaluoAfecto As Decimal
        Get
            Return ValorPorcPropiedad - Deduccion
        End Get
    End Property

#Region "implementacion de INotifyPropertyChanged"

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

#End Region
End Class