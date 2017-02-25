<Serializable>
Public Class DatosPersona
    Implements ICloneable

    Public Property ApeNombRazSoc As String
    Public Property TipoDocIdent As Integer
    Public Property NumDocIdent As String

    Public Function Clone() As Object Implements ICloneable.Clone
        Return MemberwiseClone()
    End Function
End Class