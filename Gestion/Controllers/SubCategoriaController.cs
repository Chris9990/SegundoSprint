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
    public class SubCategoriaController : Controller
    {
        // GET: SubCategoria
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.SubCategoria.ToList());
               
            }
        }

        // GET: SubCategoria/Details/5
        public ActionResult Details(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.SubCategoria.Where(x => x.Cod_SubCategoria == id).FirstOrDefault());
            }
        }

        // GET: SubCategoria/Create
        public ActionResult Create()
        {
            using (DbModels dbModel = new DbModels())
            {
                ViewBag.Cod_Categoria = new SelectList(dbModel.Categorias, "Cod_Categoria", "Nombre_Categoria").ToList();

                return View();
            }
                
        }

        // POST: SubCategoria/Create
        [HttpPost]
        public ActionResult Create(SubCategoria subCategoria)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.SubCategoria.Add(subCategoria);
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

        // GET: SubCategoria/Edit/5
        public ActionResult Edit(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.SubCategoria.Where(x => x.Cod_SubCategoria == id).FirstOrDefault());
            }
        }

        // POST: SubCategoria/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, SubCategoria subCategoria)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(subCategoria).State = EntityState.Modified;
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

        // GET: SubCategoria/Delete/5
        public ActionResult Delete(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.SubCategoria.Where(x => x.Cod_SubCategoria == id).FirstOrDefault());
            }
        }

        // POST: SubCategoria/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    SubCategoria subCategoria = dbModel.SubCategoria.Where(x => x.Cod_SubCategoria == id).FirstOrDefault();
                    dbModel.SubCategoria.Remove(subCategoria);
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
