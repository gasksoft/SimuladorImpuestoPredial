Imports System.ComponentModel
Imports SimuImpPred.ObjectModel

Namespace GUI
    Public Class DireccionUc
        Private _direccion As Direccion
        Private _inicializado As Boolean

        <Bindable(True)>
        Public Property Direccion As Direccion
            Get
                Return _direccion
            End Get
            Set
                _direccion = Value
                If _direccion Is Nothing Then Return
                Inicializar()
                DireccionBindingSource.DataSource = _direccion
            End Set
        End Property

        Private Sub Inicializar()
            If _inicializado Then Return
            TipoHabilitacionMetroComboBox.DataSource = Common.Codificadores.TipoHabilitacionDic.ToList
            TipoHabilitacionMetroComboBox.DisplayMember = "Value"
            TipoHabilitacionMetroComboBox.ValueMember = "Key"

            TipoViaMetroComboBox.DataSource = Common.Codificadores.TipoViaDic.ToList
            TipoViaMetroComboBox.DisplayMember = "Value"
            TipoViaMetroComboBox.ValueMember = "Key"
            _inicializado = True
        End Sub
    End Class
End Namespace