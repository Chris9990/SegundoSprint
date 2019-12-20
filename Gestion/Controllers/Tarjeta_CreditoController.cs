using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestion.Models;

namespace Gestion.Controllers
{
    public class Tarjeta_CreditoController : Controller
    {
        // GET: Tarjeta_Credito
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Tarjeta_Credito.ToList());
            }
        }

        // GET: Tarjeta_Credito/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Tarjeta_Credito.Where(x => x.Numero_Tarjeta == id).FirstOrDefault());
            }
        }

        // GET: Tarjeta_Credito/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tarjeta_Credito/Create
        [HttpPost]
        public ActionResult Create(Tarjeta_Credito tarjeta_Credito)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Tarjeta_Credito.Add(tarjeta_Credito);
                    dbModels.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tarjeta_Credito/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Tarjeta_Credito.Where(x => x.Numero_Tarjeta == id).FirstOrDefault());
            }
        }

        // POST: Tarjeta_Credito/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Tarjeta_Credito tarjeta_Credito)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(tarjeta_Credito).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tarjeta_Credito/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Tarjeta_Credito.Where(x => x.Numero_Tarjeta == id).FirstOrDefault());
            }
        }

        // POST: Tarjeta_Credito/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Tarjeta_Credito tarjeta_Credito = dbModel.Tarjeta_Credito.Where(x => x.Numero_Tarjeta == id).FirstOrDefault();
                    dbModel.Tarjeta_Credito.Remove(tarjeta_Credito);
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
