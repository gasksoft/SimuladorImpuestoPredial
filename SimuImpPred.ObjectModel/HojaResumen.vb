Imports System.ComponentModel
Imports System.Runtime.CompilerServices

<Serializable>
Public Class HojaResumen
    Implements INotifyPropertyChanged
    Implements ICloneable

    <NonSerialized>
    Private _parametrosCalculo As ParametrosCalculo
    Private _condicionEspecialContribuyente As Integer = 1
    Private _baseImponible As Decimal
    Private _presunto As Boolean

    Sub New()
        Predios = New BindingList(Of Predio)
        _parametrosCalculo = New ParametrosCalculo
        AddHandler Predios.ListChanged,
            Sub(sender, args)
                Select Case args.ListChangedType
                    Case ListChangedType.ItemAdded
                        Predios(args.NewIndex).HojaResumen = Me
                End Select
                OnPropertyChanged(BaseImponible)
            End Sub
    End Sub

    Public Property CodContribuyente As String
    Public Property DatosContrib As New DatosPersona
    Public Property DatosConyuge As New DatosPersona
    Public Property DatosRepLegal As New DatosPersona
    Public Property BaseLegal As String
    Public Property NroExpAdm As String
    Public Property FechaExpAdm As Date?
    Public Property NroResAlcaldia As String
    Public Property FechaResAlcaldia As Date?
    Public Property SueldoPensionista As Decimal?
    Public Property DomicilioFiscal As New Domicilio
    Public ReadOnly Property Predios As BindingList(Of Predio)
    Public Property ParametrosCalculo As ParametrosCalculo
        Get
            Return _parametrosCalculo
        End Get
        Set
            _parametrosCalculo = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property CondicionEspecialContribuyente As Integer
        Get
            Return _condicionEspecialContribuyente
        End Get
        Set
            _condicionEspecialContribuyente = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Presunto As Boolean
        Get
            Return _presunto
        End Get
        Set
            _presunto = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property BaseImponible As Decimal
        Get
            If Presunto Then Return _baseImponible
            Return Predios.Sum(Function(p) p.AutoavaluoAfecto)
        End Get
        Set
            _baseImponible = Value
            OnPropertyChanged()
        End Set
    End Property

    Public ReadOnly Property ImpuestoAnual As Decimal
        Get
            Dim bi As Decimal = BaseImponible
            Dim u As Decimal = ParametrosCalculo?.Uit
            If bi = 0 Then
                Return 0
            ElseIf bi < 15 * u Then
                Return Math.Max(0.006 * u, 0.002 * bi)
            ElseIf bi < 60 * u Then
                Return Math.Max(0.006 * u, 0.006 * bi - 0.06 * u)
            Else
                Return Math.Max(0.006 * u, 0.01 * bi - 0.3 * u)
            End If
        End Get
    End Property

    Public ReadOnly Property CuotaTrimestral As Decimal
        Get
            Return ImpuestoAnual / 4
        End Get
    End Property

#Region "implementacion de INotifyPropertyChanged"

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

#End Region

#Region "Implementacion de ICloneable"

    Public Function Clone() As Object Implements ICloneable.Clone
        Dim clon = MemberwiseClone()
        clon.DatosContrib = DatosContrib.Clone
        clon.DatosConyuge = DatosConyuge.Clone
        clon.DatosRepLegal = DatosRepLegal.Clone
        clon.DomicilioFiscal = DomicilioFiscal.Clone
        clon.ParametrosCalculo = ParametrosCalculo
        'For Each p In Predios
        '    'TODO: Clonar los predios
        '    clon.Predios.Add(p)
        'Next
        Return clon
    End Function

#End Region
End Class