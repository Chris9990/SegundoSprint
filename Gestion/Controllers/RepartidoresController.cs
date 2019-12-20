using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestion.Models;

namespace Gestion.Controllers
{
    [Authorize]
    public class RepartidoresController : Controller
    {
        // GET: Repartidor
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Repartidores.ToList());
            }
        }

        // GET: Repartidor/Details/5
        public ActionResult Details(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Repartidores.Where(x => x.Cod_Repartidor == id).FirstOrDefault());
            }
        }

        // GET: Repartidor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Repartidor/Create
        [HttpPost]
        public ActionResult Create(Repartidores repartidor)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Repartidores.Add(repartidor);
                    dbModels.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Repartidor/Edit/5
        public ActionResult Edit(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Repartidores.Where(x => x.Cod_Repartidor == id).FirstOrDefault());
            }
        }

        // POST: Repartidor/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Repartidores repartidor)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(repartidor).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Repartidor/Delete/5
        public ActionResult Delete(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Repartidores.Where(x => x.Cod_Repartidor == id).FirstOrDefault());
            }
        }

        // POST: Repartidor/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Repartidores repartidor = dbModel.Repartidores.Where(x => x.Cod_Repartidor == id).FirstOrDefault();
                    dbModel.Repartidores.Remove(repartidor);
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
