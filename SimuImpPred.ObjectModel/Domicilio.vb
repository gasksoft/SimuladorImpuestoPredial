<Serializable>
Public Class Domicilio
    Sub New()
        Direccion = New Direccion
    End Sub

    Public Property CodDep As String = "02"
    Public Property CodProv As String = "01"
    Public Property CodDis As String = "05"
    Public Property Direccion As Direccion
    Public Property Referencia As String
    Public Property Telefonos As String
    Public Property CorreosElectronicos As String
End Class