Imports System.ComponentModel.DataAnnotations

Public Class Habitacion

    <Key>
    Public Property habitacionId As Integer
    Public Property hotelId As Integer
    Public Property tipoHabitacionId As Integer
    Public Property nombreHabitacion As String
    Public Property descripcionHabitacion As String
    Public Property ubicacionHabitacion As String
    Public Property precioBaseHabitacion As String

End Class
