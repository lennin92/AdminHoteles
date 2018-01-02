Imports System
Imports System.Data.Entity
Imports System.Linq

Public Class HabitacionesDBC
    Inherits DbContext

    ' Your context has been configured to use a 'HabitacionesDBC' connection string from your application's 
        ' configuration file (App.config or Web.config). By default, this connection string targets the 
        ' 'AdminHoteles.HabitacionesDBC' database on your LocalDb instance. 
        ' 
        ' If you wish to target a different database and/or database provider, modify the 'HabitacionesDBC' 
        ' connection string in the application configuration file.
    Public Sub New()
        MyBase.New("name=HabitacionesDBC")
    End Sub

    ' Add a DbSet for each entity type that you want to include in your model. For more information 
        ' on configuring and using a Code First model, see http:'go.microsoft.com/fwlink/?LinkId=390109.
    ' Public Overridable Property MyEntities() As DbSet(Of MyEntity)
    Public Overridable Property TiposHabitaciones() As DbSet(Of TipoHabitacion)
    Public Overridable Property Hoteles() As DbSet(Of Hotel)
    Public Overridable Property Habitaciones() As DbSet(Of Habitacion)
    Public Overridable Property PreciosHabitaciones() As DbSet(Of PrecioHabitacion)

End Class
 