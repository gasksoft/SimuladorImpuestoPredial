Imports SimuImpPred.Data

<Serializable>
Public Class ParametrosCalculo
    <NonSerialized> Private _año As Integer
    <NonSerialized> Private _ifps As Dictionary(Of Integer, Decimal)
    <NonSerialized> Private _categorias As Dictionary(Of String, Categoria)
    <NonSerialized> Private _depreciaciones As List(Of Depreciacion)
    <NonSerialized> Private _fo As Decimal
    <NonSerialized> Private _fechaCalculo As Date
    <NonSerialized> Private _uit As Decimal

    Private Sub New()
        Dim añoMaximo = ParameterProvider.GetAños().Max
        Año = Math.Min(Year(Now), añoMaximo)
    End Sub

    Public Sub LeerParametros()
        If Año < Year(Now) Then
            _fechaCalculo = New Date(Año, 12, 31)
        Else
            _fechaCalculo = Now
        End If
        _uit = ParameterProvider.GetUits(_año)
        _fo = ParameterProvider.GetFo(_año)
        _depreciaciones = ParameterProvider.GetDepreciaciones
        _categorias = ParameterProvider.GetCategorias(_año)
        _ifps = ParameterProvider.GetIfps(_año)
    End Sub

    Public Property Año As Integer
        Get
            Return _año
        End Get
        Set
            If _año = Value Then Return
            _año = Value
            LeerParametros()
        End Set
    End Property

    Public ReadOnly Property Uit As Decimal
        Get
            Return _uit
        End Get
    End Property

    Public ReadOnly Property FechaCalculo As Date
        Get
            Return _fechaCalculo
        End Get
    End Property

    Public ReadOnly Property Fo As Decimal
        Get
            Return _fo
        End Get
    End Property

    Public ReadOnly Property Depreciaciones As List(Of Depreciacion)
        Get
            Return _depreciaciones
        End Get
    End Property

    Public ReadOnly Property Categorias As Dictionary(Of String, Categoria)
        Get
            Return _categorias
        End Get
    End Property

    Public ReadOnly Property Ifps As Dictionary(Of Integer, Decimal)
        Get
            Return _ifps
        End Get
    End Property

#Region "Singleton"

    Private Shared _instancia As ParametrosCalculo

    Public Shared ReadOnly Property Instancia As ParametrosCalculo
        Get
            If _instancia Is Nothing Then
                _instancia = New ParametrosCalculo
            End If
            Return _instancia
        End Get
    End Property

#End Region
End Class