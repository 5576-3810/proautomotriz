using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Automotriz.Models;

namespace Automotriz.Controllers
{
    public class REPARACIONsController : Controller
    {
        private carrosEntities db = new carrosEntities();

        // GET: REPARACIONs
        public ActionResult Index()
        {
            var rEPARACION = db.REPARACION.Include(r => r.EMPLEADO).Include(r => r.INGRESO_VEHICULO).Include(r => r.REPUESTO);
            return View(rEPARACION.ToList());
        }

        // GET: REPARACIONs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REPARACION rEPARACION = db.REPARACION.Find(id);
            if (rEPARACION == null)
            {
                return HttpNotFound();
            }
            return View(rEPARACION);
        }

        // GET: REPARACIONs/Create
        public ActionResult Create()
        {
            ViewBag.ID_EMPLEADO = new SelectList(db.EMPLEADO, "ID_EMPLEADO", "NOMBRE");
            ViewBag.ID_INGRESO = new SelectList(db.INGRESO_VEHICULO, "ID_INGRESO", "COLOR");
            ViewBag.ID_REPUESTO = new SelectList(db.REPUESTO, "ID_REPUESTO", "NOMBRE");
            return View();
        }

        // POST: REPARACIONs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_REPARACION,ID_INGRESO,DESCRIPCION,NOMBRE_COMPLETO,ID_EMPLEADO,TOTAL_PIEZAS,VALOR_TOTAL,ID_REPUESTO,FECHA")] REPARACION rEPARACION)
        {
            if (ModelState.IsValid)
            {
                db.REPARACION.Add(rEPARACION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_EMPLEADO = new SelectList(db.EMPLEADO, "ID_EMPLEADO", "NOMBRE", rEPARACION.ID_EMPLEADO);
            ViewBag.ID_INGRESO = new SelectList(db.INGRESO_VEHICULO, "ID_INGRESO", "COLOR", rEPARACION.ID_INGRESO);
            ViewBag.ID_REPUESTO = new SelectList(db.REPUESTO, "ID_REPUESTO", "NOMBRE", rEPARACION.ID_REPUESTO);
            return View(rEPARACION);
        }

        // GET: REPARACIONs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REPARACION rEPARACION = db.REPARACION.Find(id);
            if (rEPARACION == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_EMPLEADO = new SelectList(db.EMPLEADO, "ID_EMPLEADO", "NOMBRE", rEPARACION.ID_EMPLEADO);
            ViewBag.ID_INGRESO = new SelectList(db.INGRESO_VEHICULO, "ID_INGRESO", "COLOR", rEPARACION.ID_INGRESO);
            ViewBag.ID_REPUESTO = new SelectList(db.REPUESTO, "ID_REPUESTO", "NOMBRE", rEPARACION.ID_REPUESTO);
            return View(rEPARACION);
        }

        // POST: REPARACIONs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_REPARACION,ID_INGRESO,DESCRIPCION,NOMBRE_COMPLETO,ID_EMPLEADO,TOTAL_PIEZAS,VALOR_TOTAL,ID_REPUESTO,FECHA")] REPARACION rEPARACION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rEPARACION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_EMPLEADO = new SelectList(db.EMPLEADO, "ID_EMPLEADO", "NOMBRE", rEPARACION.ID_EMPLEADO);
            ViewBag.ID_INGRESO = new SelectList(db.INGRESO_VEHICULO, "ID_INGRESO", "COLOR", rEPARACION.ID_INGRESO);
            ViewBag.ID_REPUESTO = new SelectList(db.REPUESTO, "ID_REPUESTO", "NOMBRE", rEPARACION.ID_REPUESTO);
            return View(rEPARACION);
        }

        // GET: REPARACIONs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REPARACION rEPARACION = db.REPARACION.Find(id);
            if (rEPARACION == null)
            {
                return HttpNotFound();
            }
            return View(rEPARACION);
        }

        // POST: REPARACIONs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            REPARACION rEPARACION = db.REPARACION.Find(id);
            db.REPARACION.Remove(rEPARACION);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
