using Gestion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gestion.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Usuarios.ToList());
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Marcas/Create
        [HttpPost]
        public ActionResult Create(Usuarios usuarios)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Usuarios.Add(usuarios);
                    dbModels.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(string id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Usuarios.Where(x => x.Usuario == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    Usuarios usuario = dbModel.Usuarios.Where(x => x.Usuario == id).FirstOrDefault();
                    dbModel.Usuarios.Remove(usuario);
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
