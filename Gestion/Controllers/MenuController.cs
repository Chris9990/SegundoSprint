using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gestion.Controllers
{
    [Authorize]
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult MenuAdmin()
        {
            ViewBag.Message = "Menu de Administrador";

            return View();
        }

        
    }
}