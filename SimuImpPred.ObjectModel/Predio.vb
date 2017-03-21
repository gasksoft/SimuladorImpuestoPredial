Imports System.ComponentModel

<Serializable>
Public MustInherit Class Predio
    Sub New()
        Contratantes = New List(Of DatosPersona)
        Construcciones = New BindingList(Of Construccion)
        OtrasInstalaciones = New BindingList(Of OtraInstalacion)
        UbicacionPredio = New Direccion
        EscucharEventosEnInstalaciones()
    End Sub

    Private Sub EscucharEventosEnInstalaciones()
        AddHandler Construcciones.ListChanged, AddressOf OnListChanged
        AddHandler OtrasInstalaciones.ListChanged, AddressOf OnListChanged
    End Sub

    Private Sub OnListChanged(sender As Object, e As ListChangedEventArgs)
        If e.ListChangedType = ListChangedType.ItemAdded Then
            sender(e.NewIndex).ClasificacionPredio = ClasificacionPredio
        End If
    End Sub

    Public ReadOnly Property Anexo As String
        Get
            Return $"{HojaResumen.Instancia.Predios.IndexOf(Me) + 1:D3}"
        End Get
    End Property
    Public MustOverride ReadOnly Property Tipo As String
    Public Property CodigoPredio As String
    Public ReadOnly Property UbicacionPredio As Direccion
    Public Property CondProp As Integer
    Public Property PorcProp As Decimal = 100
    Public Property NumCoprop As Integer
    Public Property TipoPredio As Integer
    Public Property EstadoConstruccion As Integer
    Public Property ClasificacionPredio As Integer = 1
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

    Public ReadOnly Property OtrasInstalaciones As BindingList(Of OtraInstalacion)

    Public ReadOnly Property ValorTotalOtrasInstalaciones As Decimal
        Get
            Return OtrasInstalaciones.Sum(Function(c) c.Valor)
        End Get
    End Property

    Public MustOverride ReadOnly Property ValorTotalTerreno As Decimal

    Public ReadOnly Property ValorAutoavaluo As Decimal
        Get
            Return ValorTotalAreaConstruidaPropia + ValorTotalOtrasInstalaciones + ValorTotalTerreno
        End Get
    End Property

    Public ReadOnly Property ValorPorcPropiedad As Decimal
        Get
            Return ValorAutoavaluo * PorcProp / 100
        End Get
    End Property

    Public Overridable ReadOnly Property Deduccion As Decimal
        Get
            Return 0
        End Get
    End Property

    Public ReadOnly Property Autoavaluo As Decimal
        Get
            Return ValorPorcPropiedad - Deduccion
        End Get
    End Property

    Public ReadOnly Property DescPredio As String
        Get
            If Trim(CodigoPredio) = "" Then Return String.Join(" - ", Tipo, UbicacionPredio)
            Return String.Join(" - ", Tipo, CodigoPredio, UbicacionPredio)
        End Get
    End Property
End Class