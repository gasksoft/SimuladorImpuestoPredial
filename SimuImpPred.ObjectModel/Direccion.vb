<Serializable>
Public Class Direccion
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

    Public Overrides Function ToString() As String
        Return "Hola"
    End Function
End Class