Imports System.ComponentModel.DataAnnotations

Public Class Cliente

    <Key>
    Public Property clienteId As Integer
    Public Property nombresCliente As String
    Public Property apellidosCliente As String
    Public Property numeroIdentificacionCliente As String
    Public Property tipoIdentificacionCliente As String

End Class
