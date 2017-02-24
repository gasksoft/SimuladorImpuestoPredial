<Serializable>
Public Class Direccion
    Implements ICloneable

    Property ConjuntoUrbano As String
    Property Via As String
    Property Numero As String
    Property DptoBlock As String
    Property Interior As String
    Property Mz As String
    Property Lote As String

    Public Function Clone() As Object Implements ICloneable.Clone
        Return MemberwiseClone()
    End Function
End Class