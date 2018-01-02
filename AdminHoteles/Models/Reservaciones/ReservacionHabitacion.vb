Imports System.ComponentModel.DataAnnotations

Public Class ReservacionHabitacion

    <Key>
    Public Property reservacionHabitacionId As Integer
    Public Property habitacionId As Integer
    Public Property clienteId As Integer
    Public Property desde As Date
    Public Property hasta As Date
    Public Property precioAcordado As Decimal
End Class
