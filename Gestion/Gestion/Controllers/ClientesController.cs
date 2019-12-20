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

        
           
    }
}
