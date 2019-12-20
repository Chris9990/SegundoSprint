using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestion.Models;

namespace Gestion.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Productos.ToList());
            }
        }

        // GET: Productos/Details/5
        public ActionResult Details(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Productos.Where(x => x.Cod_Producto == id).FirstOrDefault());
            }
        }


        //*** GET: Productos/Create
        public ActionResult Create()
        {
            using (DbModels dbModel = new DbModels())
            {
                ViewBag.Cod_Marca = new SelectList(dbModel.Marcas, "Cod_Marca", "Nombre_Marca").ToList();
                ViewBag.Cod_SubCategoria = new SelectList(dbModel.SubCategoria, "Cod_SubCategoria", "Nombre_SubCategoria").ToList();

                return View();
            }
            
        }

        // *** POST: Productos/Create
        [HttpPost]
        public ActionResult Create(Productos producto)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Productos.Add(producto);
                    dbModels.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Productos/Edit/5
        public ActionResult Edit(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Productos.Where(x => x.Cod_Producto == id).FirstOrDefault());
            }
        }

        // POST: Productos/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Productos producto)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(producto).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Productos/Delete/5
        public ActionResult Delete(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Productos.Where(x => x.Cod_Producto == id).FirstOrDefault());
            }
        }

        // POST: Productos/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Productos producto = dbModel.Productos.Where(x => x.Cod_Producto == id).FirstOrDefault();
                    dbModel.Productos.Remove(producto);
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
