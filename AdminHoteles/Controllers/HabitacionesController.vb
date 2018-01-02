Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports AdminHoteles

Namespace Controllers
    Public Class HabitacionesController
        Inherits System.Web.Mvc.Controller

        Private db As New HabitacionesDBC

        ' GET: Habitaciones
        Function Index() As ActionResult
            Return View(db.Habitaciones.ToList())
        End Function

        ' GET: Habitaciones/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim habitacion As Habitacion = db.Habitaciones.Find(id)
            If IsNothing(habitacion) Then
                Return HttpNotFound()
            End If
            Return View(habitacion)
        End Function

        ' GET: Habitaciones/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Habitaciones/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="habitacionId,hotelId,tipoHabitacionId,nombreHabitacion,descripcionHabitacion,ubicacionHabitacion,precioBaseHabitacion")> ByVal habitacion As Habitacion) As ActionResult
            If ModelState.IsValid Then
                db.Habitaciones.Add(habitacion)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(habitacion)
        End Function

        ' GET: Habitaciones/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim habitacion As Habitacion = db.Habitaciones.Find(id)
            If IsNothing(habitacion) Then
                Return HttpNotFound()
            End If
            Return View(habitacion)
        End Function

        ' POST: Habitaciones/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="habitacionId,hotelId,tipoHabitacionId,nombreHabitacion,descripcionHabitacion,ubicacionHabitacion,precioBaseHabitacion")> ByVal habitacion As Habitacion) As ActionResult
            If ModelState.IsValid Then
                db.Entry(habitacion).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(habitacion)
        End Function

        ' GET: Habitaciones/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim habitacion As Habitacion = db.Habitaciones.Find(id)
            If IsNothing(habitacion) Then
                Return HttpNotFound()
            End If
            Return View(habitacion)
        End Function

        ' POST: Habitaciones/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim habitacion As Habitacion = db.Habitaciones.Find(id)
            db.Habitaciones.Remove(habitacion)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
