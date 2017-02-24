<Serializable>
Public Structure InformacionComplementaria
    Implements ICloneable

    Property Telefono1 As String
    Property Telefono2 As String
    Property Telefono3 As String
    Property CorreoElectronico1 As String
    Property CorreoElectronico2 As String
    Property CorreoElectronico3 As String

    Public Function Clone() As Object Implements ICloneable.Clone
        Return MemberwiseClone()
    End Function
End Structure