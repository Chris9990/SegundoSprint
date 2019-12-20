using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gestion.Models;

namespace Gestion.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Clientes.ToList());
            }
        }

        // GET: Clientes/Details/5
        public ActionResult Details(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Clientes.Where(x => x.Cod_Cliente == id).FirstOrDefault());
            }
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            using (DbModels dbModel = new DbModels())
            {
                ViewBag.Cod_MPago = new SelectList(dbModel.Metodo_de_Pago, "Cod_MPago", "Metodo").ToList();

                return View();
            }
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Clientes cliente)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Clientes.Add(cliente);
                    dbModels.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Clientes.Where(x => x.Cod_Cliente == id).FirstOrDefault());
            }
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Clientes cliente)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(cliente).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Clientes.Where(x => x.Cod_Cliente == id).FirstOrDefault());
            }
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Clientes cliente = dbModel.Clientes.Where(x => x.Cod_Cliente == id).FirstOrDefault();
                    dbModel.Clientes.Remove(cliente);
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
