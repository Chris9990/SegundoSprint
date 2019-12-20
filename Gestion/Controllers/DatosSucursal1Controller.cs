/*using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Gestion.Models;


namespace Gestion.Controllers
{
    public class DatosSucursal1Controller : ApiController
    {
        private DbModels dbb = new DbModels ();

        //get :api/DatosSucursal1

        public IQueryable <Envio> GetEnvios()
        {
            return dbb.Envio;
        }

        [ResponseType(typeof(Envio))]

        public IHttpActionResult GetEnvio(string id)

        {
            Envio envio = dbb.Envio.Find(id);
            if (envio == null)
            {
                return NotFound();
            }
            en e = new en();
        }
    }
}
*/