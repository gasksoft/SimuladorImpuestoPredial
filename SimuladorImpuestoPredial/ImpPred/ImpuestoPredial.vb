Imports System.ComponentModel

Namespace ImpPred
    Public Class ImpuestoPredial
        Implements INotifyPropertyChanged

        Private _exonerado As Boolean
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Sub New()
            AddHandler Predios.ListChanged,
                Sub()
                    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(BaseImponible)))
                End Sub
        End Sub
        ReadOnly Property Predios As New BindingList(Of Predio)
        ReadOnly Property BaseImponible As Decimal
            Get
                Return Predios.Sum(Function(p) p.Avaluo)
            End Get
        End Property
        Property Exonerado As Boolean
            Get
                Return _exonerado
            End Get
            Set
                _exonerado = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(BaseImponible)))
            End Set
        End Property
        ReadOnly Property BaseImponibleDeducida As Decimal
            Get
                If Exonerado Then
                    Return Math.Max(0, BaseImponible - 50 * ParametrosCalculo.Uit)
                Else
                    Return BaseImponible
                End If
            End Get
        End Property
        ReadOnly Property BaseImponibleTramo1 As Decimal
            Get
                Dim b = BaseImponibleDeducida
                Dim u = ParametrosCalculo.Uit
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
                Dim u = ParametrosCalculo.Uit
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
                Dim u = ParametrosCalculo.Uit
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