Imports System.Collections.ObjectModel
Imports SimuladorImpuestoPredial.Entidades

Public Class ParametrosCalculo
    Private Shared _uits As ReadOnlyDictionary(Of Integer, Decimal)
    Private Shared _uit As Decimal?
    Private Shared _categorias As ReadOnlyDictionary(Of String, Categoria)
    Private Shared _depreciaciones As ReadOnlyCollection(Of Depreciacion)
    Private Shared _año As Integer

    Public Shared ReadOnly Property ClasificacionPredioDictionary As New ReadOnlyDictionary(Of Integer, String) _
        (New Dictionary(Of Integer, String) From {
            {1, "Casa habitación, departamentos para viviendas incluidas las ubicadas en edificios"},
            {2, "Tiendas, depósitos, centros de recreación o esparcimiento, clubes sociales o instituciones"},
            {3, "Edificios – oficinas"},
            {4, "Edificaciones de salud, cines, industrias, edificaciones de uso educativo, talleres"}}
         )

    Public Shared ReadOnly Property MaterialPredominanteDictionary As New ReadOnlyDictionary(Of Integer, String) _
        (New Dictionary(Of Integer, String) From {
            {1, "Concreto"},
            {2, "Ladrillo"},
            {3, "Adobe"}}
         )

    Public Shared ReadOnly Property EstadoConservacionDictionary As New ReadOnlyDictionary(Of Integer, String) _
        (New Dictionary(Of Integer, String) From {
            {1, "Muy Bueno"},
            {2, "Bueno"},
            {3, "Regular"},
            {4, "Malo"}}
         )

    Public Shared ReadOnly Property Uits As ReadOnlyDictionary(Of Integer, Decimal)
        Get
            If _uits Is Nothing Then
                FillUits()
            End If
            Return _uits
        End Get
    End Property

    Public Shared Property Año As Integer
        Get
            Return _año
        End Get
        Set
            If _año <> Value Then
                _año = Value
                _uit = Nothing
                _categorias = Nothing
            End If
        End Set
    End Property

    Public Shared ReadOnly Property Uit As Decimal
        Get
            If Not _uit.HasValue Then
                _uit = Uits(Año)
            End If
            Return _uit
        End Get
    End Property

    Public Shared ReadOnly Property Categorias As ReadOnlyDictionary(Of String, Categoria)
        Get
            If _categorias Is Nothing Then
                FillCategorias
            End If
            Return _categorias
        End Get
    End Property

    Public Shared ReadOnly Property Depreciaciones As ReadOnlyCollection(Of Depreciacion)
        Get
            If _depreciaciones Is Nothing Then
                Using contexto As New Contexto
                    _depreciaciones = New ReadOnlyCollection(Of Depreciacion)((From d In contexto.Depreciaciones).ToList)
                End Using
            End If
            Return _depreciaciones
        End Get
    End Property

    Private Shared Sub FillUits()
        Using contexto As New Contexto
            _uits = New ReadOnlyDictionary(Of Integer, Decimal) _
                (
                    (From u In contexto.Uits Order By u.Año Descending Take 8).
                    ToDictionary((Function(u) u.Año), (Function(u) u.Valor)))
        End Using
    End Sub

    Private Shared Sub FillCategorias()
        Using contexto As New Contexto
            _categorias = New ReadOnlyDictionary(Of String, Categoria) _
                (
                    (From c In contexto.Categorias Where c.Año = Año).
                    ToDictionary(Function(c) c.Cat))
        End Using
    End Sub
End Class
