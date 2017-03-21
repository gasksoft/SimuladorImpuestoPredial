

<Serializable>
Public Class Construccion
    Inherits Instalacion

    Public Property TipoPiso As Integer = 1
    Public Property Piso As Integer = 1

    Public ReadOnly Property StrPiso As String
        Get
            Return $"{Choose(_TipoPiso, "P", "S", "M", "ACP", "ACS")} {Piso:D2}"
        End Get
    End Property

    Public Property Cies As String = "A"
    Public Property Cb As String = "A"
    Public Property Cr As String = "A"
    Public Property Cpv As String = "A"
    Public Property Cp As String = "A"
    Public Property Ct As String = "A"
    Public Property Cmc As String = "A"

    Public ReadOnly Property Categorias As String
        Get
            Return $"{Cmc}{Ct}{Cp}{Cpv}{Cr}{Cb}{Cies}"
        End Get
    End Property

    Public Property AreaConstruida As Decimal

    Public Overrides ReadOnly Property ValorUnitario As Decimal
        Get
            Dim c = ParametrosCalculo.Instancia.Categorias
            Return c(Cb).Vb + c(Cies).Vies + c(Cmc).Vmc + c(Cp).Vp + c(Cpv).Vpv + c(Cr).Vr + c(Ct).Vt
        End Get
    End Property

    Public ReadOnly Property Inc5Porc As Decimal
        Get
            Return If(Piso > 4, ValorUnitario * 0.05, 0)
        End Get
    End Property

    Protected Overrides ReadOnly Property ValorUnitarioIncrementado As Decimal
        Get
            Return ValorUnitario + Inc5Porc
        End Get
    End Property

    Public Property PorcPartPredio As Decimal

    Public ReadOnly Property ValorAreaConstruidaComun As Decimal
        Get
            Return ValorUnitarioIncrementado * AreaConstruida
        End Get
    End Property

    Public Overrides ReadOnly Property Valor As Decimal
        Get
            Return ValorAreaConstruidaComun * PorcPartPredio / 100
        End Get
    End Property
End Class
