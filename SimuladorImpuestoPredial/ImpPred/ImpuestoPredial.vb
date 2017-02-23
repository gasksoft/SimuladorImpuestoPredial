Imports System.ComponentModel

Namespace ImpPred
    Public Class ImpuestoPredial
        Implements INotifyPropertyChanged

        Private _exonerado As Boolean
        Private _sinDetalle As Boolean = False
        Private _baseImponible As Decimal
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Sub New()
            AddHandler Predios.ListChanged,
                Sub() RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(BaseImponible)))
        End Sub

        Property BaseImponible As Decimal
            Get
                Return If(SinDetalle, _baseImponible, Predios.Sum(Function(p) p.Avaluo))
            End Get
            Set
                _baseImponible = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(BaseImponible)))
            End Set
        End Property

        Property Exonerado As Boolean
            Get
                Return _exonerado
            End Get
            Set
                _exonerado = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Exonerado)))
            End Set
        End Property

        Property SinDetalle As Boolean
            Get
                Return _sinDetalle
            End Get
            Set
                _sinDetalle = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(SinDetalle)))
            End Set
        End Property

        ReadOnly Property BaseImponibleDeducida As Decimal
            Get
                If Exonerado Then
                    Return Math.Max(0, BaseImponible - 50*GetUit())
                Else
                    Return BaseImponible
                End If
            End Get
        End Property

        ReadOnly Property Insoluto As Decimal
            Get
                Dim bi = BaseImponibleDeducida
                Dim u = GetUit()
                If bi = 0 Then Return 0
                Dim ins As Decimal
                If bi < 15*u Then
                    ins = 0.002*bi
                ElseIf bi < 60*u Then
                    ins = 0.006*bi - 0.06*u
                Else
                    ins = 0.01*bi - 0.3*u
                End If
                Return Math.Max(0.006*u, ins)
            End Get
        End Property

        ReadOnly Property Predios As New BindingList(Of Predio)
    End Class
End Namespace