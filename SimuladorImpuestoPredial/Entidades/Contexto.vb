Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions

Namespace Entidades
    Public NotInheritable Class Contexto
        Inherits DbContext

        Public Sub New()
            MyBase.New("Datos")
            Database.SetInitializer(Of Contexto)(Nothing)
            Configuration.LazyLoadingEnabled = False
        End Sub

        Public Property Uits As DbSet(Of Uit)
        Public Property Depreciaciones As DbSet(Of Depreciacion)
        Public Property Categorias As DbSet(Of Categoria)

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            modelBuilder.Conventions.Remove (Of PluralizingTableNameConvention)()
        End Sub
    End Class
End Namespace