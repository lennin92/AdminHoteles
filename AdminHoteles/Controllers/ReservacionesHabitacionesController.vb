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
    Public Class ReservacionesHabitacionesController
        Inherits System.Web.Mvc.Controller

        Private db As New ReservacionesDBC

        ' GET: ReservacionesHabitaciones
        Function Index() As ActionResult
            Return View(db.ReservacionHabitacions.ToList())
        End Function

        ' GET: ReservacionesHabitaciones/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim reservacionHabitacion As ReservacionHabitacion = db.ReservacionHabitacions.Find(id)
            If IsNothing(reservacionHabitacion) Then
                Return HttpNotFound()
            End If
            Return View(reservacionHabitacion)
        End Function

        ' GET: ReservacionesHabitaciones/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: ReservacionesHabitaciones/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="reservacionHabitacionId,habitacionId,clienteId,desde,hasta,precioAcordado")> ByVal reservacionHabitacion As ReservacionHabitacion) As ActionResult
            If ModelState.IsValid Then
                db.ReservacionHabitacions.Add(reservacionHabitacion)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(reservacionHabitacion)
        End Function

        ' GET: ReservacionesHabitaciones/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim reservacionHabitacion As ReservacionHabitacion = db.ReservacionHabitacions.Find(id)
            If IsNothing(reservacionHabitacion) Then
                Return HttpNotFound()
            End If
            Return View(reservacionHabitacion)
        End Function

        ' POST: ReservacionesHabitaciones/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="reservacionHabitacionId,habitacionId,clienteId,desde,hasta,precioAcordado")> ByVal reservacionHabitacion As ReservacionHabitacion) As ActionResult
            If ModelState.IsValid Then
                db.Entry(reservacionHabitacion).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(reservacionHabitacion)
        End Function

        ' GET: ReservacionesHabitaciones/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim reservacionHabitacion As ReservacionHabitacion = db.ReservacionHabitacions.Find(id)
            If IsNothing(reservacionHabitacion) Then
                Return HttpNotFound()
            End If
            Return View(reservacionHabitacion)
        End Function

        ' POST: ReservacionesHabitaciones/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim reservacionHabitacion As ReservacionHabitacion = db.ReservacionHabitacions.Find(id)
            db.ReservacionHabitacions.Remove(reservacionHabitacion)
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
