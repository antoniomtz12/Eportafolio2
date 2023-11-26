using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Eportafolio2.Models;

namespace Eportafolio2.Controllers
{
    public class AcercaController : Controller
    {
        private amartinezEntities db = new amartinezEntities();

        // GET: Acerca
        public ActionResult Index()
        {
            return View(db.Acercas.ToList());
        }

        // GET: Acerca/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acerca acerca = db.Acercas.Find(id);
            if (acerca == null)
            {
                return HttpNotFound();
            }
            return View(acerca);
        }

        // GET: Acerca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Acerca/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Acerca1")] Acerca acerca)
        {
            if (ModelState.IsValid)
            {
                db.Acercas.Add(acerca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(acerca);
        }

        // GET: Acerca/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acerca acerca = db.Acercas.Find(id);
            if (acerca == null)
            {
                return HttpNotFound();
            }
            return View(acerca);
        }

        // POST: Acerca/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Acerca1")] Acerca acerca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(acerca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(acerca);
        }

        // GET: Acerca/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acerca acerca = db.Acercas.Find(id);
            if (acerca == null)
            {
                return HttpNotFound();
            }
            return View(acerca);
        }

        // POST: Acerca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Acerca acerca = db.Acercas.Find(id);
            db.Acercas.Remove(acerca);
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
