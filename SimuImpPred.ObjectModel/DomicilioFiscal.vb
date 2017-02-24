<Serializable>
Public Class DomicilioFiscal
    Implements ICloneable

    Property Distrito As String
    Property Direccion As New Direccion
    Property Referencia As String

    Public Function Clone() As Object Implements ICloneable.Clone
        Dim clon As New DomicilioFiscal
        clon.Distrito = Distrito
        clon.Direccion = Direccion.Clone
        clon.Referencia = Referencia
        Return clon
    End Function
End Class