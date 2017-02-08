﻿Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions

Namespace Entidades
    Public Class Contexto
        Inherits DbContext

        Public Sub New()
            MyBase.New("Datos")
            Database.SetInitializer (Of Contexto)(Nothing)
            'Configuration.LazyLoadingEnabled = False
        End Sub

        Public Overridable Property Uits As DbSet(Of Uit)

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            modelBuilder.Conventions.Remove (Of PluralizingTableNameConvention)()
        End Sub
    End Class
End Namespace