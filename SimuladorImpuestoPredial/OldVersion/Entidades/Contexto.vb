Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions

Namespace Entidades
    Public Class Contexto
        Inherits DbContext

        Sub New()
            MyBase.New("Datos")
            Database.SetInitializer (Of Contexto)(Nothing)
            Configuration.LazyLoadingEnabled = False
        End Sub

        Property Uits As DbSet(Of Uit)
        Property Depreciaciones As DbSet(Of Depreciacion)
        Property Categorias As DbSet(Of Categoria)
        Property IfpDenos As DbSet(Of IfpDeno)
        Property IfpUms As DbSet(Of IfpUM)
        Property Ifps As DbSet(Of Ifp)
        Property IfpVus As DbSet(Of IfpVu)
        Property Fos As DbSet(Of Fo)
        Property CategoriasDesc As DbSet(Of CategoriaDesc)

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            If modelBuilder Is Nothing Then Return
            modelBuilder.Conventions.Remove (Of PluralizingTableNameConvention)()
        End Sub
    End Class
End Namespace