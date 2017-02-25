<Serializable>
Public Class Domicilio
    Implements ICloneable
    Public Property CodDep As String = "02"
    Public Property CodProv As String = "01"
    Public Property CodDis As String = "05"
    Public Property Direccion As New Direccion
    Public Property Referencia As String
    Public Property Telefonos As String
    Public Property CorreosElectronicos As String

    Public Function Clone() As Object Implements ICloneable.Clone
        Dim clon = MemberwiseClone()
        clon.Direccion = Direccion.Clone
        Return clon
    End Function
End Class