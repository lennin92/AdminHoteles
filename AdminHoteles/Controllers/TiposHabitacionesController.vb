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
    Public Class TiposHabitacionesController
        Inherits System.Web.Mvc.Controller

        Private db As New HabitacionesDBC

        ' GET: TiposHabitaciones
        Function Index() As ActionResult
            Return View(db.TiposHabitaciones.ToList())
        End Function

        ' GET: TiposHabitaciones/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tipoHabitacion As TipoHabitacion = db.TiposHabitaciones.Find(id)
            If IsNothing(tipoHabitacion) Then
                Return HttpNotFound()
            End If
            Return View(tipoHabitacion)
        End Function

        ' GET: TiposHabitaciones/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: TiposHabitaciones/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="tipoHabitacionId,nombreTipoHabitacion")> ByVal tipoHabitacion As TipoHabitacion) As ActionResult
            If ModelState.IsValid Then
                db.TiposHabitaciones.Add(tipoHabitacion)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tipoHabitacion)
        End Function

        ' GET: TiposHabitaciones/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tipoHabitacion As TipoHabitacion = db.TiposHabitaciones.Find(id)
            If IsNothing(tipoHabitacion) Then
                Return HttpNotFound()
            End If
            Return View(tipoHabitacion)
        End Function

        ' POST: TiposHabitaciones/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="tipoHabitacionId,nombreTipoHabitacion")> ByVal tipoHabitacion As TipoHabitacion) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tipoHabitacion).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tipoHabitacion)
        End Function

        ' GET: TiposHabitaciones/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tipoHabitacion As TipoHabitacion = db.TiposHabitaciones.Find(id)
            If IsNothing(tipoHabitacion) Then
                Return HttpNotFound()
            End If
            Return View(tipoHabitacion)
        End Function

        ' POST: TiposHabitaciones/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tipoHabitacion As TipoHabitacion = db.TiposHabitaciones.Find(id)
            db.TiposHabitaciones.Remove(tipoHabitacion)
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
