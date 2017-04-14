Imports System.IO
Imports System.IO.Compression
Imports System.Xml.Serialization

Public Class Funciones
    Private Sub New()
    End Sub

    Public Shared Function Copiar(Of T)(fuente As T) As T
        'Verificamos que sea serializable antes de hacer la copia
        If Not GetType(T).IsSerializable Then
            Throw New ArgumentException("El tipo de dato debe ser serializable.", "fuente")
        End If
        If (ReferenceEquals(fuente, Nothing)) Then
            Return Nothing
        End If
        'Creamos un stream en memoria
        'Dim formatter As New BinaryFormatter()
        Dim formatter As New XmlSerializer(GetType(T))
        Using stream As New MemoryStream()
            formatter.Serialize(stream, fuente)
            stream.Seek(0, SeekOrigin.Begin)
            'Deserializamos la porcón de memoria en el nuevo objeto
            Return formatter.Deserialize(stream)
        End Using
    End Function

    Public Shared Sub SeriaYComprime(Of TTipo)(obj As TTipo, arch As String)
        Using fs As New FileStream(arch, FileMode.Create, FileAccess.Write)
            Using zs As New GZipStream(fs, CompressionMode.Compress, True)
                'Dim bf = New SoapFormatter()
                'bf.Serialize(zs, obj)
                Dim s As New XmlSerializer(GetType(TTipo))
                s.Serialize(zs, obj)
            End Using
        End Using
    End Sub

    Public Shared Function DescomprimeYDeseria(Of TTipo)(arch As String) As Object
        Using fs As New FileStream(arch, FileMode.Open, FileAccess.Read)
            Using zs As New GZipStream(fs, CompressionMode.Decompress, True)
                'Dim bf As New SoapFormatter()
                'Return bf.Deserialize(zs)
                Dim s As New XmlSerializer(GetType(TTipo))
                Return s.Deserialize(zs)
            End Using
        End Using
    End Function
End Class
