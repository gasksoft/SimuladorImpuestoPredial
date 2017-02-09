Imports SimuladorImpuestoPredial.Entidades

Namespace ImpPred
    Public Class Construccion
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
        Public Property Material As Integer = 1
        Public Property Estado As Integer = 1

        Private Function GetVies() As Decimal
            Return If(ParametrosCalculo.Categorias(Cies).Vies, 0)
        End Function

        Private Function GetVb() As Decimal
            Return If(ParametrosCalculo.Categorias(Cb).Vb, 0)
        End Function

        Private Function GetVr() As Decimal
            Return If(ParametrosCalculo.Categorias(Cr).Vr, 0)
        End Function

        Private Function GetVpv() As Decimal
            Return If(ParametrosCalculo.Categorias(Cpv).Vpv, 0)
        End Function

        Private Function GetVp() As Decimal
            Return If(ParametrosCalculo.Categorias(Cp).Vp, 0)
        End Function

        Private Function GetVt() As Decimal
            Return If(ParametrosCalculo.Categorias(Ct).Vt, 0)
        End Function

        Private Function GetVmc() As Decimal
            Return If(ParametrosCalculo.Categorias(Cmc).Vmc, 0)
        End Function

        ReadOnly Property ValorUnitario As Decimal
            Get
                Return GetVies() + GetVb() + GetVr() + GetVpv() + GetVp() + GetVt() + GetVmc()
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

        ReadOnly Property PorcDepreciacion As Decimal
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
                    From d In ParametrosCalculo.Depreciaciones
                    Where d.Antiguedad = ga And
                          d.Clasificacion = Predio.Clasificacion And
                          d.Estado = Estado And
                          d.Material = Material).FirstOrDefault?.Porcentaje
            End Get
        End Property

        ReadOnly Property ValorDepreciacion As Decimal
            Get
                Return ValorUnitarioIncrementado * PorcDepreciacion / 100
            End Get
        End Property

        ReadOnly Property ValorUnitarioDepreciado As Decimal
            Get
                Return ValorUnitarioIncrementado * (1 - PorcDepreciacion / 100)
            End Get
        End Property

        Property AreaConstruida As Decimal
        ReadOnly Property AreaConstruidaValor As Decimal
            Get
                Return ValorUnitarioDepreciado * AreaConstruida
            End Get
        End Property
        Property AreaConstruidaComunPorcentaje As Decimal

        ReadOnly Property AreaConstruidaComunValor As Decimal
            Get
                Return AreaConstruidaValor * AreaConstruidaComunPorcentaje / 100
            End Get
        End Property

        Public ReadOnly Property Valor As Decimal
            Get
                Return If(AreaConstruidaComunValor > 0, AreaConstruidaComunValor, AreaConstruidaValor)
            End Get
        End Property

        Public Property Predio As Predio

    End Class
End Namespace