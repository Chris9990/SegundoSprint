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
    public class MarcasController : Controller
    {
        // GET: Marcas
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Marcas.ToList());
            }
        }

        // GET: Marcas/Details/5
        public ActionResult Details(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Marcas.Where(x => x.Cod_Marca== id).FirstOrDefault());
            }
        }

        // GET: Marcas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Marcas/Create
        [HttpPost]
        public ActionResult Create(Marcas marca)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Marcas.Add(marca);
                    dbModels.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Marcas/Edit/5
        public ActionResult Edit(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Marcas.Where(x => x.Cod_Marca == id).FirstOrDefault());
            }
        }

        // POST: Marcas/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Marcas marca)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(marca).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Marcas/Delete/5
        public ActionResult Delete(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Marcas.Where(x => x.Cod_Marca == id).FirstOrDefault());
            }
        }

        // POST: Marcas/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Marcas marca = dbModel.Marcas.Where(x => x.Cod_Marca == id).FirstOrDefault();
                    dbModel.Marcas.Remove(marca);
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
