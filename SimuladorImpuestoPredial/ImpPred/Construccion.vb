Imports SimuladorImpuestoPredial.Entidades

Namespace ImpPred
    Public Class Construccion
        Private ReadOnly _contexto As New Contexto
        Property Nivel As Integer = 1
        Property Año As Integer = Year(Now)
        Property Mes As Integer = Month(Now)

        ReadOnly Property Antiguedad As Double
            Get
                Return DateDiff(DateInterval.Month, New Date(Año, Mes, 1), Now) / 12
            End Get
        End Property

        ReadOnly Property Categorias As String
            Get
                Return $"{Cmc}{Ct}{Cp}{Cpv}{Cr}{Cb}{Cies}"
            End Get
        End Property

        Public Property Cies As String = "A"
        Public Property Cb As String = "A"
        Public Property Cr As String = "A"
        Public Property Cpv As String = "A"
        Public Property Cp As String = "A"
        Public Property Ct As String = "A"
        Public Property Cmc As String = "A"
        Public Property Clasificacion As Integer = 1
        Public Property Material As Integer = 1
        Public Property Estado As Integer = 1

        Public ReadOnly Property Vies As Decimal
            Get
                Return _
                    (From c In _contexto.Categorias Where c.Año = ImpuestoPredial.Año And c.Cat = Cies).
                        FirstOrDefault?.Vies
            End Get
        End Property

        Public ReadOnly Property Vb As Decimal
            Get
                Return _
                    (From c In _contexto.Categorias Where c.Año = ImpuestoPredial.Año And c.Cat = Cb).
                        FirstOrDefault?.Vb
            End Get
        End Property

        Public ReadOnly Property Vr As Decimal
            Get
                Return _
                    (From c In _contexto.Categorias Where c.Año = ImpuestoPredial.Año And c.Cat = Cr).
                        FirstOrDefault?.Vr
            End Get
        End Property

        Public ReadOnly Property Vpv As Decimal
            Get
                Return _
                    (From c In _contexto.Categorias Where c.Año = ImpuestoPredial.Año And c.Cat = Cpv).
                        FirstOrDefault?.Vpv
            End Get
        End Property

        Public ReadOnly Property Vp As Decimal
            Get
                Return _
                    (From c In _contexto.Categorias Where c.Año = ImpuestoPredial.Año And c.Cat = Cp).
                        FirstOrDefault?.Vp
            End Get
        End Property

        Public ReadOnly Property Vt As Decimal
            Get
                Return _
                    (From c In _contexto.Categorias Where c.Año = ImpuestoPredial.Año And c.Cat = Ct).
                        FirstOrDefault?.Vt
            End Get
        End Property

        Public ReadOnly Property Vmc As Decimal
            Get
                Return _
                    (From c In _contexto.Categorias Where c.Año = ImpuestoPredial.Año And c.Cat = Cmc).
                        FirstOrDefault?.Vmc
            End Get
        End Property

        ReadOnly Property ValorUnitario As Decimal
            Get
                Return Vies + Vb + Vr + Vpv + Vp + Vt + Vmc
            End Get
        End Property

        ReadOnly Property Incremento5Porc As Decimal
            Get
                Return If(Nivel > 4, ValorUnitario * 0.05, 0)
            End Get
        End Property

        ReadOnly Property ValorUnitarioIncrementado As Decimal
            Get
                Return ValorUnitario + Incremento5Porc
            End Get
        End Property

        ReadOnly Property Depreciacion As Decimal
            Get
                Dim ga As Integer
                Dim a = Antiguedad
                If a <= 5 Then
                    ga = 5
                ElseIf a <= 10 Then
                    ga = 10
                ElseIf a <= 15 Then
                    ga = 15
                ElseIf a <= 20 Then
                    ga = 20
                ElseIf a <= 25 Then
                    ga = 25
                ElseIf a <= 30 Then
                    ga = 30
                ElseIf a <= 35 Then
                    ga = 35
                ElseIf a <= 40 Then
                    ga = 40
                ElseIf a <= 45 Then
                    ga = 45
                ElseIf a <= 50 Then
                    ga = 50
                Else
                    ga = 55
                End If
                Return (
                    From d In _contexto.Depreciaciones
                    Where d.Antiguedad = ga And
                          d.Clasificacion = Clasificacion And
                          d.Estado = Estado And
                          d.Material = Material).FirstOrDefault?.Porcentaje
            End Get
        End Property

        ReadOnly Property ValorUnitarioDepreciado As Decimal
            Get
                Return ValorUnitarioIncrementado * (1 - Depreciacion / 100)
            End Get
        End Property

        Property AreaConstruida As Decimal
        Property AreaConstruidaComunPorcentaje As Decimal = 100

        ReadOnly Property AreaConstruidaComunValor As Decimal
            Get
                Return AreaConstruida * AreaConstruidaComunPorcentaje / 100
            End Get
        End Property

        Public ReadOnly Property Valor As Decimal
            Get
                Return AreaConstruidaComunValor * ValorUnitarioDepreciado
            End Get
        End Property
    End Class
End Namespace