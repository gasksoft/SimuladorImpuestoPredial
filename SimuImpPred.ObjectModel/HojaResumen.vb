Imports System.ComponentModel
Imports System.Xml.Serialization

<Serializable>
Public Class HojaResumen
    Private _baseImponiblePresunta As Decimal = 0
    Public Property CodContribuyente As String = "CODIGO"
    Public Property DatosContrib As DatosPersona = New DatosPersona
    Public Property DatosConyuge As DatosPersona = New DatosPersona
    Public Property DatosRepLegal As DatosPersona = New DatosPersona
    Public Property DomicilioFiscal As Domicilio = New Domicilio
    Public Property BaseLegal As String
    Public Property NroExpAdm As String
    Public Property FechaExpAdm As Date
    Public Property NroResAlcaldia As String
    Public Property FechaResAlcaldia As Date
    Public Property SueldoPensionista As Decimal
    Public Property CondicionEspecialContribuyente As Integer = 1

    <XmlArrayItem("PU", GetType(PredioUrbano))>
    <XmlArrayItem("PR", GetType(PredioRustico))>
    Public Property Predios As BindingList(Of Predio) = New BindingList(Of Predio)

    <DefaultValue(True)>
    Public Property Presunto As Boolean = True

    Public Property BaseImponible As Decimal
        Get
            If Presunto Then Return _baseImponiblePresunta
            Return Predios.Sum(Function(p) p.Autoavaluo)
        End Get
        Set
            _baseImponiblePresunta = Value
        End Set
    End Property

    Public ReadOnly Property Deduccion As Decimal
        Get
            If CondicionEspecialContribuyente > 1 AndAlso
                CondicionEspecialContribuyente <> 12 Then
                Return BaseImponible
            End If
            Dim u As Decimal = ParametrosCalculo.Instancia.Uit
            If CondicionEspecialContribuyente = 12 AndAlso
                SueldoPensionista <= u Then
                Return Math.Min(50 * u, BaseImponible)
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property BaseImponibleTotal As Decimal
        Get
            Return BaseImponible - Deduccion
        End Get
    End Property

    Public ReadOnly Property ImpuestoAnual As Decimal
        Get
            Dim bi As Decimal = BaseImponibleTotal
            Dim u As Decimal = ParametrosCalculo.Instancia.Uit
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

    Public ReadOnly Property BaseImponibleTramo1 As Decimal
        Get
            Dim bi As Decimal = BaseImponibleTotal
            Dim u As Decimal = ParametrosCalculo.Instancia.Uit
            Return Math.Min(15 * u, bi)
        End Get
    End Property

    Public ReadOnly Property BaseImponibleTramo2 As Decimal
        Get
            Dim bi As Decimal = BaseImponibleTotal
            Dim u As Decimal = ParametrosCalculo.Instancia.Uit
            Return Math.Max(0, Math.Min(60 * u, bi) - BaseImponibleTramo1)
        End Get
    End Property

    Public ReadOnly Property BaseImponibleTramo3 As Decimal
        Get
            Dim bi As Decimal = BaseImponibleTotal
            Return Math.Max(0, bi - BaseImponibleTramo1 - BaseImponibleTramo2)
        End Get
    End Property

    Public ReadOnly Property ImpuestoTramo1 As Decimal
        Get
            Dim bit = BaseImponibleTramo1
            If bit = 0 Then Return 0
            Return Math.Max(bit * 0.002, ParametrosCalculo.Instancia.Uit * 0.006)
        End Get
    End Property

    Public ReadOnly Property ImpuestoTramo2 As Decimal
        Get
            Return BaseImponibleTramo2 * 0.006
        End Get
    End Property

    Public ReadOnly Property ImpuestoTramo3 As Decimal
        Get
            Return BaseImponibleTramo3 * 0.01
        End Get
    End Property

    Public ReadOnly Property Impuesto As Decimal
        Get
            Return ImpuestoTramo1 + ImpuestoTramo2 + ImpuestoTramo3
        End Get
    End Property

    Public ReadOnly Property CuotaTrimestral As Decimal
        Get
            Return Impuesto / 4
        End Get
    End Property

    ReadOnly Property NumPredios As Integer
        Get
            If Presunto Then Return 0
            Return Predios.Count
        End Get
    End Property

    Public ReadOnly Property NombreHr As String
        Get
            Return _
                $"{ParametrosCalculo.Instancia.Año} - {UCase(CodContribuyente)} - {UCase(DatosContrib.ApeNombRazSoc)}"
        End Get
    End Property

#Region "Singleton"
    <NonSerialized> Private Shared _instancia As HojaResumen

    <XmlIgnore>
    Public Shared ReadOnly Property Instancia As HojaResumen
        Get
            If _instancia Is Nothing Then
                _instancia = New HojaResumen
            End If
            Return _instancia
        End Get
    End Property

    Public Shared Sub SetInstance(hr As HojaResumen)
        _instancia = hr
    End Sub

#End Region
End Class