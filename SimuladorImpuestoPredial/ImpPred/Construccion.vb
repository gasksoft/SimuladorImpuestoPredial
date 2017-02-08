Namespace ImpPred
    Public Class Construccion
        Property Nivel As String
        Property Año As Integer
        Property Mes As Integer

        ReadOnly Property Antiguedad As Integer
            Get
                Return DateDiff(DateInterval.Year, Now, New Date(Año, Mes, 1))
            End Get
        End Property

        ReadOnly Property Categorias As String
            Get
                Return $"{CMC}{CT}{CP}{CPV}{CR}{CB}{CIES}"
            End Get
        End Property

        Public Property CIES As String
        Public Property CB As String
        Public Property CR As String
        Public Property CPV As String
        Public Property CP As String
        Public Property CT As String
        Public Property CMC As String
        Public Property Clasificacion As Integer
        Public Property Material As Integer
        Public Property Estado As Integer

        Public ReadOnly Property VIES As Decimal
            Get
                Throw New NotImplementedException
            End Get
        End Property

        Public ReadOnly Property VB As Decimal
            Get
                Throw New NotImplementedException
            End Get
        End Property

        Public ReadOnly Property VR As Decimal
            Get
                Throw New NotImplementedException
            End Get
        End Property

        Public ReadOnly Property VPV As Decimal
            Get
                Throw New NotImplementedException
            End Get
        End Property

        Public ReadOnly Property VP As Decimal
            Get
                Throw New NotImplementedException
            End Get
        End Property

        Public ReadOnly Property VT As Decimal
            Get
                Throw New NotImplementedException
            End Get
        End Property

        Public ReadOnly Property VMC As Decimal
            Get
                Throw New NotImplementedException
            End Get
        End Property

        Public ReadOnly Property Valor As Decimal
            Get
                Throw New NotImplementedException
            End Get
        End Property

        Property Predio As Predio
    End Class
End Namespace