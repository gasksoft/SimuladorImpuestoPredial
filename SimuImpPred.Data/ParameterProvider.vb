Public Class ParameterProvider
    Private Shared ReadOnly Contexto As New Contexto

    Private Sub New()
    End Sub

    Public Shared Function GetUits() As Dictionary(Of Integer, Decimal)
        Return (From u In Contexto.Uits Order By u.Año Descending Take 10).
            ToDictionary((Function(u) u.Año), (Function(u) u.Valor))
    End Function

    Public Shared Function GetCategorias(año As Integer) As Dictionary(Of String, Categoria)
        Return (From c In Contexto.Categorias Where c.Año = año).
            ToDictionary(Function(c) c.Cat)
    End Function

    Public Shared Function GetCategoriasDesc() As List(Of CategoriaDesc)
        Return Contexto.CategoriasDesc.ToList
    End Function

    Public Shared Function GetDepreciaciones() As List(Of Depreciacion)
        Return Contexto.Depreciaciones.ToList
    End Function

    Public Shared Function GetIfpDenominaciones() As List(Of IfpDeno)
        Return Contexto.IfpDenos.Include("ifps").Include("ifps.ifpum").ToList
    End Function

    Public Shared Function GetIfps(año As Integer) As Dictionary(Of Integer, Decimal)
        Return (From iv In Contexto.IfpVus Where iv.Año = año).ToDictionary(Function(x) x.IdIfp, Function(x) x.Valor)
    End Function

    Public Shared Function GetFos() As List(Of Fo)
        Return Contexto.Fos.ToList
    End Function
End Class
