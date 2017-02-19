Imports System.Collections.ObjectModel
Imports System.Data.Entity
Imports SimuladorImpuestoPredial.Entidades

Public Module ParametrosCalculo
    Private ReadOnly Contexto As New Contexto
    Private _uits As ReadOnlyDictionary(Of Integer, Decimal)
    Private _uit As Decimal?
    Private _categorias As ReadOnlyDictionary(Of String, Categoria)
    Private _depreciaciones As ReadOnlyCollection(Of Depreciacion)
    Private _ifpDenominaciones As ReadOnlyCollection(Of IfpDeno)
    Private _año As Integer
    Private _fo As Decimal?
    Private _categoriasDesc As IReadOnlyList(Of CategoriaDesc)
    Public ReadOnly ClasificacionPredioDictionary As New ReadOnlyDictionary(Of Integer, String) _
        (New Dictionary(Of Integer, String) From {
            {1, "Casa habitación, departamentos para viviendas incluidas las ubicadas en edificios"},
            {2, "Tiendas, depósitos, centros de recreación o esparcimiento, clubes sociales o instituciones"},
            {3, "Edificios – oficinas"},
            {4, "Edificaciones de salud, cines, industrias, edificaciones de uso educativo, talleres"}}
         )
    Public ReadOnly MaterialPredominanteDictionary As New ReadOnlyDictionary(Of Integer, String) _
        (New Dictionary(Of Integer, String) From {
            {1, "Concreto"},
            {2, "Ladrillo"},
            {3, "Adobe"}}
         )
    Public ReadOnly EstadoConservacionDictionary As New ReadOnlyDictionary(Of Integer, String) _
        (New Dictionary(Of Integer, String) From {
            {1, "Muy Bueno"},
            {2, "Bueno"},
            {3, "Regular"},
            {4, "Malo"}}
         )
    Function GetUits() As ReadOnlyDictionary(Of Integer, Decimal)
        If _uits Is Nothing Then
            _uits = New ReadOnlyDictionary(Of Integer, Decimal)(
                (From u In Contexto.Uits Order By u.Año Descending Take 10).
                                                                   ToDictionary((Function(u) u.Año),
                                                                                (Function(u) u.Valor)))
        End If
        Return _uits
    End Function
    Property Año As Integer
        Get
            Return _año
        End Get
        Set
            If _año <> Value Then
                _año = Value
                _uit = Nothing
                _categorias = Nothing
                _fo = Nothing
            End If
        End Set
    End Property
    Function GetUit() As Decimal
        If Not _uit.HasValue Then _uit = GetUits(Año)
        Return _uit
    End Function
    Function GetCategorias() As ReadOnlyDictionary(Of String, Categoria)
        If _categorias Is Nothing Then
            _categorias = New ReadOnlyDictionary(Of String, Categoria) _
                (
                    (From c In Contexto.Categorias Where c.Año = Año).
                    ToDictionary(Function(c) c.Cat))
        End If
        Return _categorias
    End Function
    Function GetCategoriasDesc() As IReadOnlyList(Of CategoriaDesc)
        If _categoriasDesc Is Nothing Then
            _categoriasDesc = New List(Of CategoriaDesc)(Contexto.CategoriasDesc.ToList)
        End If
        Return _categoriasDesc
    End Function
    Private Function GetDepreciaciones() As ReadOnlyCollection(Of Depreciacion)
        If _depreciaciones Is Nothing Then
            _depreciaciones = New ReadOnlyCollection(Of Depreciacion)((From d In Contexto.Depreciaciones).ToList)
        End If
        Return _depreciaciones
    End Function
    Function GetIfpDenominaciones() As ReadOnlyCollection(Of IfpDeno)
        If _ifpDenominaciones Is Nothing Then
            _ifpDenominaciones =
                New ReadOnlyCollection(Of IfpDeno)(
                    (From d In Contexto.IfpDenos).Include("ifps").Include("ifps.ifpum").ToList)
        End If
        Return _ifpDenominaciones
    End Function
    Function GetFactorOficializacion() As Decimal
        If Not _fo.HasValue Then
            _fo = (From f In Contexto.Fos Where f.Año = _año).FirstOrDefault?.Valor
        End If
        Return _fo
    End Function
    Function GetAntiguedad(añoConst As Integer, mes As Integer)
        Dim añoActual = Year(Now)
        Dim mesActual = Month(Now)
        If Año < añoActual Then
            añoActual = Año
            mesActual = 12
        End If
        Return DateDiff(DateInterval.Month, New Date(añoConst, mes, 1), New DateTime(añoActual, mesActual, 1))/12
    End Function
    Function GetDepreciacion(antiguedad As Decimal, clasificacion As Integer, estado As Integer, material As Integer) _
        As Decimal
        Dim ga As Integer = Math.Min(Math.Max(Math.Ceiling(antiguedad/5)*5, 5), 55)
        Return (
            From d In GetDepreciaciones()
                Where d.Antiguedad = ga And
                      d.Clasificacion = clasificacion And
                      d.Estado = estado And
                      d.Material = material).FirstOrDefault?.Porcentaje
    End Function
End Module
