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
    Public Class HotelesController
        Inherits System.Web.Mvc.Controller

        Private db As New HabitacionesDBC

        ' GET: Hoteles
        Function Index() As ActionResult
            Return View(db.Hoteles.ToList())
        End Function

        ' GET: Hoteles/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hotel As Hotel = db.Hoteles.Find(id)
            If IsNothing(hotel) Then
                Return HttpNotFound()
            End If
            Return View(hotel)
        End Function

        ' GET: Hoteles/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Hoteles/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="hotelId,nombreHotel,direccionHotel,estrellasHotel")> ByVal hotel As Hotel) As ActionResult
            If ModelState.IsValid Then
                db.Hoteles.Add(hotel)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(hotel)
        End Function

        ' GET: Hoteles/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hotel As Hotel = db.Hoteles.Find(id)
            If IsNothing(hotel) Then
                Return HttpNotFound()
            End If
            Return View(hotel)
        End Function

        ' POST: Hoteles/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="hotelId,nombreHotel,direccionHotel,estrellasHotel")> ByVal hotel As Hotel) As ActionResult
            If ModelState.IsValid Then
                db.Entry(hotel).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(hotel)
        End Function

        ' GET: Hoteles/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim hotel As Hotel = db.Hoteles.Find(id)
            If IsNothing(hotel) Then
                Return HttpNotFound()
            End If
            Return View(hotel)
        End Function

        ' POST: Hoteles/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim hotel As Hotel = db.Hoteles.Find(id)
            db.Hoteles.Remove(hotel)
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
