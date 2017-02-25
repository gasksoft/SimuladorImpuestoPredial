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
        Return (From iv In Contexto.IfpVus Where iv.Año = año).ToDictionary(Function(v) v.IdIfp, Function(v) v.Valor)
    End Function

    Public Shared Function GetFo(año As Integer) As Decimal
        Return Contexto.Fos.Where(Function(x) x.Año = año).FirstOrDefault?.Valor
    End Function

    Public Shared Function GetDepartamentos() As List(Of UDep)
        Return Contexto.Departamentos.Include("Provincias.Distritos").ToList
    End Function
End Class
