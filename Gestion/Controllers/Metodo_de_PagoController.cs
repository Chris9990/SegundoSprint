using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestion.Models;

namespace Gestion.Controllers
{
    public class Metodo_de_PagoController : Controller
    {
        // GET: Metodo_de_Pago
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Metodo_de_Pago.ToList());
            }
        }

        // GET: MétodoDePago/Details/5
        public ActionResult Details(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Metodo_de_Pago.Where(x => x.Cod_MPago == id).FirstOrDefault());
            }
        }

        // GET: MétodoDePago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MétodoDePago/Create
        [HttpPost]
        public ActionResult Create(Metodo_de_Pago metodo_De_Pago)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Metodo_de_Pago.Add(metodo_De_Pago);
                    dbModels.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MétodoDePago/Edit/5
        public ActionResult Edit(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Metodo_de_Pago.Where(x => x.Cod_MPago == id).FirstOrDefault());
            }
        }

        // POST: MétodoDePago/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Metodo_de_Pago metodo_De_Pago)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(metodo_De_Pago).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MétodoDePago/Delete/5
        public ActionResult Delete(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Metodo_de_Pago.Where(x => x.Cod_MPago == id).FirstOrDefault());
            }
        }

        // POST: MétodoDePago/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Metodo_de_Pago metodo_De_Pago = dbModel.Metodo_de_Pago.Where(x => x.Cod_MPago == id).FirstOrDefault();
                    dbModel.Metodo_de_Pago.Remove(metodo_De_Pago);
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
