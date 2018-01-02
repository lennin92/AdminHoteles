Imports System.ComponentModel.DataAnnotations

Public Class PrecioHabitacion

    <Key>
    Public Property precioHabitacionId As Integer
    Public Property habitacionId As Integer
    Public Property precioSugerido As Decimal
    Public Property precioMinimo As Decimal
    Public Property desde As Date
    Public Property hasta As Date

End Class
