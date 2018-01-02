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
    Public Class PreciosHabitacionesController
        Inherits System.Web.Mvc.Controller

        Private db As New HabitacionesDBC

        ' GET: PreciosHabitaciones
        Function Index() As ActionResult
            Return View(db.PreciosHabitaciones.ToList())
        End Function

        ' GET: PreciosHabitaciones/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim precioHabitacion As PrecioHabitacion = db.PreciosHabitaciones.Find(id)
            If IsNothing(precioHabitacion) Then
                Return HttpNotFound()
            End If
            Return View(precioHabitacion)
        End Function

        ' GET: PreciosHabitaciones/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: PreciosHabitaciones/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="precioHabitacionId,habitacionId,precioSugerido,precioMinimo,desde,hasta")> ByVal precioHabitacion As PrecioHabitacion) As ActionResult
            If ModelState.IsValid Then
                db.PreciosHabitaciones.Add(precioHabitacion)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(precioHabitacion)
        End Function

        ' GET: PreciosHabitaciones/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim precioHabitacion As PrecioHabitacion = db.PreciosHabitaciones.Find(id)
            If IsNothing(precioHabitacion) Then
                Return HttpNotFound()
            End If
            Return View(precioHabitacion)
        End Function

        ' POST: PreciosHabitaciones/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="precioHabitacionId,habitacionId,precioSugerido,precioMinimo,desde,hasta")> ByVal precioHabitacion As PrecioHabitacion) As ActionResult
            If ModelState.IsValid Then
                db.Entry(precioHabitacion).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(precioHabitacion)
        End Function

        ' GET: PreciosHabitaciones/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim precioHabitacion As PrecioHabitacion = db.PreciosHabitaciones.Find(id)
            If IsNothing(precioHabitacion) Then
                Return HttpNotFound()
            End If
            Return View(precioHabitacion)
        End Function

        ' POST: PreciosHabitaciones/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim precioHabitacion As PrecioHabitacion = db.PreciosHabitaciones.Find(id)
            db.PreciosHabitaciones.Remove(precioHabitacion)
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
