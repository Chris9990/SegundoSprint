using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestion.Models;

namespace Gestion.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Categorias.ToList());
            }
        }

        // GET: Categorias/Details/5
        public ActionResult Details(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Categorias.Where(x => x.Cod_Categoria == id).FirstOrDefault());
            }
        }

        // GET: Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        [HttpPost]
        public ActionResult Create(Categorias categoria)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Categorias.Add(categoria);
                    dbModels.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categorias/Edit/5
        public ActionResult Edit(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Categorias.Where(x => x.Cod_Categoria == id).FirstOrDefault());
            }
        }

        // POST: Categorias/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Categorias categoria)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(categoria).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categorias/Delete/5
        public ActionResult Delete(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Categorias.Where(x => x.Cod_Categoria == id).FirstOrDefault());
            }
        }

        // POST: Categorias/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Categorias categoria = dbModel.Categorias.Where(x => x.Cod_Categoria == id).FirstOrDefault();
                    dbModel.Categorias.Remove(categoria);
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
