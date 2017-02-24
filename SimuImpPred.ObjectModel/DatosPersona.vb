Imports SimuImpPred.ObjectModel

<Serializable>
Public Class DatosPersona
    Implements ICloneable

    Public Property ApeNombRazSoc As String
    Public Property TipoDocIdent As Integer
    Public Property NumDocIdent As String

    Public Function Clone() As Object Implements ICloneable.Clone
        Dim clon As New DatosPersona
        clon.ApeNombRazSoc = ApeNombRazSoc
        clon.TipoDocIdent = TipoDocIdent
        clon.NumDocIdent = NumDocIdent
        Return clon
    End Function
End Class