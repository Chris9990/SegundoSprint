using Gestion.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gestion.Controllers
{
    public class Detalle_de_ComprasController : Controller
    {
        // GET: Detalle_de_Compras
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Detalle_de_Compras.ToList());
            }
        }
        // GET: Detalle_de_Compras/Details/5
        public ActionResult Details(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Detalle_de_Compras.Where(x => x.Cod_Compra == id).FirstOrDefault());
            }
        }
        //*** GET: Detalle_de_Compras/Create
        public ActionResult Create()
        {
            using (DbModels dbModel = new DbModels())
            {
                ViewBag.Cod_Proveedor = new SelectList(dbModel.Detalle_de_Compras, "Cod_Proveedor", "Empresa").ToList();
                ViewBag.Cod_Producto = new SelectList(dbModel.Productos, "Cod_Producto", "Nombre_Producto").ToList();

                return View();
            }
        }
        //*** POST: Detalle_de_Compras/Create
        [HttpPost]
        public ActionResult Create(Detalle_de_Compras detalle)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Detalle_de_Compras.Add(detalle);
                    dbModels.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Detalle_de_Compras/Edit/5
        public ActionResult Edit(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Detalle_de_Compras.Where(x => x.Cod_Compra == id).FirstOrDefault());
            }
        }

        // POST: Detalle_de_Compras/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Detalle_de_Compras detalle)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(detalle).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Detalle_de_Compras/Delete/5
        public ActionResult Delete(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Detalle_de_Compras.Where(x => x.Cod_Compra == id).FirstOrDefault());
            }
        }

        // POST: Detalle_de_Compras/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Detalle_de_Compras detalle = dbModel.Detalle_de_Compras.Where(x => x.Cod_Compra == id).FirstOrDefault();
                    dbModel.Detalle_de_Compras.Remove(detalle);
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
