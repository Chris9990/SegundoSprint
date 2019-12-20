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
    public class ProveedoresController : Controller
    {
        // GET: Proveedores
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Proveedores.ToList());
            }
        }

        // GET: Proveedores/Details/5
        public ActionResult Details(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Proveedores.Where(x => x.Cod_Prov == id).FirstOrDefault());
            }
        }

        // GET: Proveedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proveedores/Create
        [HttpPost]
        public ActionResult Create(Proveedores proveedor)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Proveedores.Add(proveedor);
                    dbModels.SaveChanges();

                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Proveedores/Edit/5
        public ActionResult Edit(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Proveedores.Where(x => x.Cod_Prov == id).FirstOrDefault());
            }
        }

        // POST: Proveedores/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Proveedores proveedor)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(proveedor).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Proveedores/Delete/5
        public ActionResult Delete(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Proveedores.Where(x => x.Cod_Prov == id).FirstOrDefault());
            }
        }

        // POST: Proveedores/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Proveedores proveedor = dbModel.Proveedores.Where(x => x.Cod_Prov == id).FirstOrDefault();
                    dbModel.Proveedores.Remove(proveedor);
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
