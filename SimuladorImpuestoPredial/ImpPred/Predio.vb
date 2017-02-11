Imports System.ComponentModel

Namespace ImpPred
    Public Class Predio
        Implements INotifyPropertyChanged
        Private _clasificacion As Integer = 1
        Private _arancel As Decimal
        Private _terrenoAreaExclusiva As Decimal
        Private _terrenoAreaComun As Decimal

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Sub New()
            AddHandler Construcciones.AddingNew,
                Sub(sender As Object, e As AddingNewEventArgs)
                    e.NewObject = New Construccion
                    Dim construccion As Construccion = e.NewObject
                    construccion.Predio = Me
                End Sub
            AddHandler Construcciones.ListChanged, Sub() RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(ConstruccionesValor)))
        End Sub
        Private Sub AgregandoConstruccion(sender As Object, e As AddingNewEventArgs)
            e.NewObject = New Construccion
            Dim construccion As Construccion = e.NewObject
            construccion.Predio = Me
        End Sub
        Property Direccion As String
        Property Clasificacion As Integer
            Get
                Return _clasificacion
            End Get
            Set
                _clasificacion = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Clasificacion)))
            End Set
        End Property
        Property Arancel As Decimal
            Get
                Return _arancel
            End Get
            Set
                _arancel = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Arancel)))
            End Set
        End Property
        Property TerrenoAreaExclusiva As Decimal
            Get
                Return _terrenoAreaExclusiva
            End Get
            Set
                _terrenoAreaExclusiva = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(TerrenoAreaExclusiva)))
            End Set
        End Property
        Property TerrenoAreaComun As Decimal
            Get
                Return _terrenoAreaComun
            End Get
            Set
                _terrenoAreaComun = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(TerrenoAreaComun)))
            End Set
        End Property
        ReadOnly Property TerrenoAreaTotal As Decimal
            Get
                Return TerrenoAreaComun + TerrenoAreaExclusiva
            End Get
        End Property
        ReadOnly Property TerrenoValor As Decimal
            Get
                Return TerrenoAreaTotal * Arancel
            End Get
        End Property
        ReadOnly Property ConstruccionesValor As Decimal
            Get
                Return Construcciones.Sum(Function(c) c.Valor)
            End Get
        End Property
        ReadOnly Property Avaluo As Decimal
            Get
                Return TerrenoValor + ConstruccionesValor
            End Get
        End Property
        ReadOnly Property Construcciones As New BindingList(Of Construccion)
    End Class
End Namespace