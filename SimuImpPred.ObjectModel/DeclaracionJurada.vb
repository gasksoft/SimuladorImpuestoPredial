Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Class DeclaracionJurada
    Implements ICloneable
    Implements INotifyPropertyChanged
    Private _fechaCalculo As Date?
    Private _año As Integer
    Private _uit As Decimal
    Private _codContribuyente As String
    Private _datosContrib As DatosPersona
    Private _datosConyugeRepLegal As DatosPersona
    Private _exonerado As Boolean
    Private _exoneradoDesde As Date
    Private _exoneradoHasta As Date
    Private _domicilioFiscal As DomicilioFiscal
    Private _informacionComplementaria As InformacionComplementaria

    Property Año As Integer
        Get
            Return _año
        End Get
        Set
            _año = Value
            OnPropertyChanged()
        End Set
    End Property

    Property Uit As Decimal
        Get
            Return _uit
        End Get
        Set
            _uit = Value
            OnPropertyChanged()
        End Set
    End Property

    Property CodContribuyente As String
        Get
            Return _codContribuyente
        End Get
        Set
            _codContribuyente = Value
            OnPropertyChanged()
        End Set
    End Property

    Property DatosContrib As DatosPersona
        Get
            Return _datosContrib
        End Get
        Set
            _datosContrib = Value
            OnPropertyChanged()
        End Set
    End Property

    Property DatosConyugeRepLegal As DatosPersona
        Get
            Return _datosConyugeRepLegal
        End Get
        Set
            _datosConyugeRepLegal = Value
            OnPropertyChanged()
        End Set
    End Property

    Property Exonerado As Boolean
        Get
            Return _exonerado
        End Get
        Set
            _exonerado = Value
            OnPropertyChanged()
        End Set
    End Property

    Property ExoneradoDesde As Date
        Get
            Return _exoneradoDesde
        End Get
        Set
            _exoneradoDesde = Value
            OnPropertyChanged()
        End Set
    End Property

    Property ExoneradoHasta As Date
        Get
            Return _exoneradoHasta
        End Get
        Set
            _exoneradoHasta = Value
            OnPropertyChanged()
        End Set
    End Property

    Property DomicilioFiscal As DomicilioFiscal
        Get
            Return _domicilioFiscal
        End Get
        Set
            _domicilioFiscal = Value
            OnPropertyChanged()
        End Set
    End Property

    Property InformacionComplementaria As InformacionComplementaria
        Get
            Return _informacionComplementaria
        End Get
        Set
            _informacionComplementaria = Value
            OnPropertyChanged()
        End Set
    End Property

    ReadOnly Property Predios As List(Of Predio) = New List(Of Predio)

#Region "Propiedades Pre Calculadas"

    Private ReadOnly Property FechaCalculo As Date?
        Get

            If Not _fechaCalculo.HasValue Then
                If Año < Year(Now) Then
                    _fechaCalculo = New Date(Año, 12, 31)
                Else
                    _fechaCalculo = New Date(Año, Month(Now), Day(Now))
                End If
            End If

            Return _fechaCalculo
        End Get
    End Property

    ReadOnly Property ValorAutoavaluo As Decimal
        Get
            Return Predios.Sum(Function(p) p.ValorAfecto)
        End Get
    End Property

    ReadOnly Property Deducciones As Decimal
        Get
            If Exonerado AndAlso FechaCalculo >= ExoneradoDesde AndAlso FechaCalculo <= ExoneradoHasta Then
                Return 50*Uit
            Else
                Return 0
            End If
        End Get
    End Property

    ReadOnly Property BaseImponible As Decimal
        Get
            Return ValorAutoavaluo - Deducciones
        End Get
    End Property

    ReadOnly Property ImpuestoAnual As Decimal
        Get
            If BaseImponible = 0 Then Return 0
            If BaseImponible < 15*Uit Then
                Return Math.Max(0.006*Uit, 0.002*BaseImponible)
            ElseIf BaseImponible < 60*Uit Then
                Return Math.Max(0.006*Uit, 0.006*BaseImponible - 0.06*Uit)
            Else
                Return Math.Max(0.006*Uit, 0.01*BaseImponible - 0.3*Uit)
            End If
        End Get
    End Property

    ReadOnly Property ImpuestoTrimestral As Decimal
        Get
            Return ImpuestoAnual/4
        End Get
    End Property

#End Region

#Region "Implementacion de Interfaces"

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Function Clone() As Object Implements ICloneable.Clone
        Dim clon As New DeclaracionJurada
        clon.Año = Año
        clon.CodContribuyente = CodContribuyente
        clon.DatosConyugeRepLegal = DatosConyugeRepLegal
        clon.DatosContrib = DatosContrib
        clon.DomicilioFiscal = DomicilioFiscal
        clon.Exonerado = Exonerado
        clon.ExoneradoDesde = ExoneradoDesde
        clon.ExoneradoHasta = ExoneradoHasta
        clon.InformacionComplementaria = InformacionComplementaria
        clon.Uit = Uit
        clon.Predios.addrange(Predios)
        Return clon
    End Function

#End Region
End Class