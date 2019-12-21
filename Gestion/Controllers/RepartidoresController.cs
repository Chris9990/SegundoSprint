using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Gestion.Models;

namespace Gestion.Controllers
{
    public class RepartidoresController : Controller
    {
        private DbModels db = new DbModels();

        // GET: Repartidores
        public ActionResult Index()
        {
            return View(db.Repartidores.ToList());
        }

        // GET: Repartidores/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
<<<<<<< Updated upstream
                return View(dbModel.Repartidores.Where(x => x.Cod_Repartidor == id).FirstOrDefault());
=======
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
>>>>>>> Stashed changes
            }
            Repartidores repartidores = db.Repartidores.Find(id);
            if (repartidores == null)
            {
                return HttpNotFound();
            }
            return View(repartidores);
        }

        // GET: Repartidores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Repartidores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cod_Repartidores,CI,Telefono_Repartidor,Nombre_Repartidor,Placa")] Repartidores repartidores)
        {
            if (ModelState.IsValid)
            {
                db.Repartidores.Add(repartidores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(repartidores);
        }

        // GET: Repartidores/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Repartidores repartidores = db.Repartidores.Find(id);
            if (repartidores == null)
            {
<<<<<<< Updated upstream
                return View(dbModel.Repartidores.Where(x => x.Cod_Repartidor == id).FirstOrDefault());
=======
                return HttpNotFound();
>>>>>>> Stashed changes
            }
            return View(repartidores);
        }

        // POST: Repartidores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Cod_Repartidores,CI,Telefono_Repartidor,Nombre_Repartidor,Placa")] Repartidores repartidores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(repartidores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(repartidores);
        }

        // GET: Repartidores/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
<<<<<<< Updated upstream
                return View(dbModel.Repartidores.Where(x => x.Cod_Repartidor == id).FirstOrDefault());
=======
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
>>>>>>> Stashed changes
            }
            Repartidores repartidores = db.Repartidores.Find(id);
            if (repartidores == null)
            {
                return HttpNotFound();
            }
            return View(repartidores);
        }

        // POST: Repartidores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
<<<<<<< Updated upstream
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Repartidores repartidor = dbModel.Repartidores.Where(x => x.Cod_Repartidor == id).FirstOrDefault();
                    dbModel.Repartidores.Remove(repartidor);
                    dbModel.SaveChanges();
                }
=======
            Repartidores repartidores = db.Repartidores.Find(id);
            db.Repartidores.Remove(repartidores);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
>>>>>>> Stashed changes

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
