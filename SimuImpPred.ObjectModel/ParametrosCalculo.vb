Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports SimuImpPred.Data

Public Class ParametrosCalculo
    Implements INotifyPropertyChanged
    Implements ICloneable

    Private _fechaCalculo As Date?
    Private _año As Integer
    Private _uit As Decimal
    Private _fo As Decimal

    Property Año As Integer
        Get
            Return _año
        End Get
        Set
            _año = Value
            _fechaCalculo = Nothing
            OnPropertyChanged()
        End Set
    End Property

    Property Uit As Decimal
        Get
            Return _uit
        End Get
        Set
            _uit = Value
            OnPropertyChanged()
        End Set
    End Property

    ReadOnly Property FechaCalculo As Date
        Get
            If Not _fechaCalculo.HasValue Then
                If Año < Year(Now) Then
                    _fechaCalculo = New Date(Año, 12, 31)
                Else
                    _fechaCalculo = Now
                End If
            End If

            Return _fechaCalculo
        End Get
    End Property

    Property Fo As Decimal
        Get
            Return _fo
        End Get
        Set
            _fo = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Depreciaciones As List(Of Depreciacion)

    Public Property Categorias As Dictionary(Of String, Categoria)

    Public Property Ifps As Dictionary(Of Integer, Decimal)


#Region "Implementacion INotifyPropertyChanged"
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
#End Region
End Class