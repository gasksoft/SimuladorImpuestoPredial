Imports SimuladorImpuestoPredial.Entidades

Namespace ImpPred
    Public Class ImpuestoPredial
        Public Shared ClasificacionPredioDictionary As New Dictionary(Of Integer, String) From {
            {1, "Casa habitación, departamentos para viviendas incluidas las ubicadas en edificios"},
            {2, "Tiendas, depósitos, centros de recreación o esparcimiento, clubes sociales o instituciones"},
            {3, "Edificios – oficinas"},
            {4, "Edificaciones de salud, cines, industrias, edificaciones de uso educativo, talleres"}}

        Public Shared MaterialPredominanteDictionary As New Dictionary(Of Integer, String) From {
            {1, "Concreto"},
            {2, "Ladrillo"},
            {3, "Adobe"}}

        Public Shared EstadoConservacionDictionary As New Dictionary(Of Integer, String) From {
            {1, "Muy Bueno"},
            {2, "Bueno"},
            {3, "Regular"},
            {4, "Malo"}}

        Private Shared ReadOnly Uits As New Dictionary(Of Integer, Decimal)
        Private ReadOnly _contexto As New Contexto

        Sub New()
            Predios = New List(Of Predio)
        End Sub

        Property Año As Integer

        ReadOnly Property Uit As Decimal
            Get
                Dim valor As Decimal
                If Not Uits.TryGetValue(Año, valor) Then
                    valor = (From u In _contexto.Uits Where u.Año = Año).FirstOrDefault?.Valor
                    Uits(Año) = valor
                End If
                Return valor
            End Get
        End Property

        ReadOnly Property Predios As List(Of Predio)

        ReadOnly Property BaseImponible As Decimal
            Get
                Return Predios.Sum(Function(p) p.Avaluo)
            End Get
        End Property

        Property Exonerado As Boolean
        Property ExoneradoSueldo As Decimal

        ReadOnly Property BaseImponibleDeducida As Decimal
            Get
                If Exonerado AndAlso ExoneradoSueldo <= Uit Then
                    Return Math.Max(0, BaseImponible - 50 * Uit)
                Else
                    Return BaseImponible
                End If
            End Get
        End Property

        ReadOnly Property BaseImponibleTramo1 As Decimal
            Get
                Dim b = BaseImponibleDeducida
                Dim u = Uit
                Return Math.Max(If(b > 15 * u, 15 * u, b), 0)
            End Get
        End Property

        ReadOnly Property InsolutoTramo1 As Decimal
            Get
                Return Math.Max(BaseImponibleTramo1 * 0.002, 0)
            End Get
        End Property

        ReadOnly Property BaseImponibleTramo2 As Decimal
            Get
                Dim b = BaseImponibleDeducida
                Dim u = Uit
                Return Math.Max(If(b > 60 * u, 60 * u - 15 * u, b - 15 * u) * 0.006, 0)
            End Get
        End Property

        ReadOnly Property InsolutoTramo2 As Decimal
            Get
                Return Math.Max(BaseImponibleTramo2 * 0.006, 0)
            End Get
        End Property

        ReadOnly Property BaseImponibleTramo3 As Decimal
            Get
                Dim b = BaseImponibleDeducida
                Dim u = Uit
                Return Math.Max((b - 60 * u) * 0.01, 0)
            End Get
        End Property

        ReadOnly Property InsolutoTramo3 As Decimal
            Get
                Return Math.Max(BaseImponibleTramo3 * 0.01, 0)
            End Get
        End Property

        ReadOnly Property Insoluto As Decimal
            Get
                Return InsolutoTramo1 + InsolutoTramo2 + InsolutoTramo3
            End Get
        End Property
    End Class
End Namespace