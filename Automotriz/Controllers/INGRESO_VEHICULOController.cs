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
    public class INGRESO_VEHICULOController : Controller
    {
        private carrosEntities db = new carrosEntities();

        // GET: INGRESO_VEHICULO
        public ActionResult Index()
        {
            var iNGRESO_VEHICULO = db.INGRESO_VEHICULO.Include(i => i.CLIENTE).Include(i => i.MARCA).Include(i => i.TALLER);
            return View(iNGRESO_VEHICULO.ToList());
        }

        // GET: INGRESO_VEHICULO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INGRESO_VEHICULO iNGRESO_VEHICULO = db.INGRESO_VEHICULO.Find(id);
            if (iNGRESO_VEHICULO == null)
            {
                return HttpNotFound();
            }
            return View(iNGRESO_VEHICULO);
        }

        // GET: INGRESO_VEHICULO/Create
        public ActionResult Create()
        {
            ViewBag.ID_CLIENTE = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE");
            ViewBag.ID_MARCA = new SelectList(db.MARCA, "ID_MARCA", "DESCRIPCION");
            ViewBag.ID_TALLER = new SelectList(db.TALLER, "ID_TALLER", "NOMBRE_TALLER");
            return View();
        }

        // POST: INGRESO_VEHICULO/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_INGRESO,ID_CLIENTE,ID_MARCA,COLOR,MODELO,PLACA,FECHA_INGRESO,DESCRIPCION,ID_TALLER,FECHA_ING")] INGRESO_VEHICULO iNGRESO_VEHICULO)
        {
            if (ModelState.IsValid)
            {
                db.INGRESO_VEHICULO.Add(iNGRESO_VEHICULO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_CLIENTE = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE", iNGRESO_VEHICULO.ID_CLIENTE);
            ViewBag.ID_MARCA = new SelectList(db.MARCA, "ID_MARCA", "DESCRIPCION", iNGRESO_VEHICULO.ID_MARCA);
            ViewBag.ID_TALLER = new SelectList(db.TALLER, "ID_TALLER", "NOMBRE_TALLER", iNGRESO_VEHICULO.ID_TALLER);
            return View(iNGRESO_VEHICULO);
        }

        // GET: INGRESO_VEHICULO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INGRESO_VEHICULO iNGRESO_VEHICULO = db.INGRESO_VEHICULO.Find(id);
            if (iNGRESO_VEHICULO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CLIENTE = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE", iNGRESO_VEHICULO.ID_CLIENTE);
            ViewBag.ID_MARCA = new SelectList(db.MARCA, "ID_MARCA", "DESCRIPCION", iNGRESO_VEHICULO.ID_MARCA);
            ViewBag.ID_TALLER = new SelectList(db.TALLER, "ID_TALLER", "NOMBRE_TALLER", iNGRESO_VEHICULO.ID_TALLER);
            return View(iNGRESO_VEHICULO);
        }

        // POST: INGRESO_VEHICULO/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_INGRESO,ID_CLIENTE,ID_MARCA,COLOR,MODELO,PLACA,FECHA_INGRESO,DESCRIPCION,ID_TALLER,FECHA_ING")] INGRESO_VEHICULO iNGRESO_VEHICULO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iNGRESO_VEHICULO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_CLIENTE = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE", iNGRESO_VEHICULO.ID_CLIENTE);
            ViewBag.ID_MARCA = new SelectList(db.MARCA, "ID_MARCA", "DESCRIPCION", iNGRESO_VEHICULO.ID_MARCA);
            ViewBag.ID_TALLER = new SelectList(db.TALLER, "ID_TALLER", "NOMBRE_TALLER", iNGRESO_VEHICULO.ID_TALLER);
            return View(iNGRESO_VEHICULO);
        }

        // GET: INGRESO_VEHICULO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INGRESO_VEHICULO iNGRESO_VEHICULO = db.INGRESO_VEHICULO.Find(id);
            if (iNGRESO_VEHICULO == null)
            {
                return HttpNotFound();
            }
            return View(iNGRESO_VEHICULO);
        }

        // POST: INGRESO_VEHICULO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            INGRESO_VEHICULO iNGRESO_VEHICULO = db.INGRESO_VEHICULO.Find(id);
            db.INGRESO_VEHICULO.Remove(iNGRESO_VEHICULO);
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
