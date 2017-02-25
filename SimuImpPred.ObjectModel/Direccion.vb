<Serializable>
Public Class Direccion
    Implements ICloneable

    Public Property TipoHabilitacion As Integer = 1
    Public Property Habilitacion As String
    Public Property TipoVia As Integer = 1
    Public Property Via As String
    Public Property Numero As String
    Public Property NumeroAlterno As String
    Public Property Dpto As String
    Public Property Block As String
    Public Property Interior As String
    Public Property Mz As String
    Public Property Lote As String

    Public Function Clone() As Object Implements ICloneable.Clone
        Return MemberwiseClone()
    End Function
End Class