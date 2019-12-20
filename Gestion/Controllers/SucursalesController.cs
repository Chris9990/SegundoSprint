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
    public class SucursalesController : Controller
    {
        // GET: Sucursales
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Sucursales.ToList());
            }
        }

        // GET: Sucursales/Details/5
        public ActionResult Details(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Sucursales.Where(x => x.Cod_Sucursal == id).FirstOrDefault());
            }
        }

        // GET: Sucursales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sucursales/Create
        [HttpPost]
        public ActionResult Create(Sucursales sucursal)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Sucursales.Add(sucursal);
                    dbModels.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sucursales/Edit/5
        public ActionResult Edit(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Sucursales.Where(x => x.Cod_Sucursal == id).FirstOrDefault());
            }
        }

        // POST: Sucursales/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Sucursales sucursal)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(sucursal).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sucursales/Delete/5
        public ActionResult Delete(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Sucursales.Where(x => x.Cod_Sucursal == id).FirstOrDefault());
            }
        }

        // POST: Sucursales/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Sucursales sucursal = dbModel.Sucursales.Where(x => x.Cod_Sucursal == id).FirstOrDefault();
                    dbModel.Sucursales.Remove(sucursal);
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
