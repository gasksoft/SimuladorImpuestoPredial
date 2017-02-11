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
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Exonerado)))
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
        ReadOnly Property Insoluto As Decimal
            Get
                Dim bi = BaseImponibleDeducida
                Dim u = ParametrosCalculo.Uit
                Dim bit1 = If(bi > 15 * u, 15 * u, bi)
                Dim it1 = bit1 * 0.002
                Dim bit2 = If(bi > 15 * u, bi - bit1, 0)
                Dim it2 = bit2 * 0.006
                Dim bit3 = If(bi > 60 * u, bi - bit1 - bit2, 0)
                Dim it3 = bit3 * 0.01
                Return it1 + it2 + it3
            End Get
        End Property
        ReadOnly Property Predios As New BindingList(Of Predio)
    End Class
End Namespace