using Gestion.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gestion.Controllers
{
    [Authorize]
    public class ComprasController : Controller
    {
        // GET: Compras
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Compras.ToList());
            }
        }

        // GET: Compras/Details/5
        public ActionResult Details(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Compras.Where(x => x.Cod_Compra == id).FirstOrDefault());
            }
        }

        // GET: Compras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Compras/Create
        [HttpPost]
        public ActionResult Create(Compras compra)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Compras.Add(compra);
                    dbModels.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Compras/Edit/5
        public ActionResult Edit(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Compras.Where(x => x.Cod_Compra == id).FirstOrDefault());
            }
        }

        // POST: Compras/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Compras compra)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(compra).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Compras/Delete/5
        public ActionResult Delete(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Productos.Where(x => x.Cod_Producto == id).FirstOrDefault());
            }
        }

        // POST: Compras/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Compras compra = dbModel.Compras.Where(x => x.Cod_Compra == id).FirstOrDefault();
                    dbModel.Compras.Remove(compra);
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
