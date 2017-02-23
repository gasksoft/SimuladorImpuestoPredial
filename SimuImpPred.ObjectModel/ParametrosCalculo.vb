Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports SimuImpPred.Data

Public Class ParametrosCalculo
    Implements INotifyPropertyChanged
    Private _año As Integer = Year(Now)

    Sub New()
        Depreciaciones = New List(Of Depreciacion)
        Categorias = New Dictionary(Of String, Categoria)
        Ifps = New Dictionary(Of Integer, Decimal)
        Uit = 0
        Fo = 0
        FechaCalculo = Now
        Año = Year(Now)
    End Sub

    Public Property Año As Integer
        Get
            Return _año
        End Get
        Set
            _año = Value
            If Año < Year(Now) Then
                _FechaCalculo = New Date(Año, 12, 31)
            Else
                _FechaCalculo = Now
            End If
            _Uit = ParameterProvider.GetUits(_año)
            _Fo = ParameterProvider.GetFo(_año)
            _Depreciaciones = ParameterProvider.GetDepreciaciones
            _Categorias = ParameterProvider.GetCategorias(_año)
            _Ifps = ParameterProvider.GetIfps(_año)

            OnPropertyChanged()
        End Set
    End Property

    Public ReadOnly Property Uit As Decimal
    Public ReadOnly Property FechaCalculo As Date
    Public ReadOnly Property Fo As Decimal
    Public ReadOnly Property Depreciaciones As List(Of Depreciacion)
    Public ReadOnly Property Categorias As Dictionary(Of String, Categoria)
    Public ReadOnly Property Ifps As Dictionary(Of Integer, Decimal)

#Region "Implementacion INotifyPropertyChanged"

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

#End Region
End Class