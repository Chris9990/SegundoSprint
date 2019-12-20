using System;
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
    public class EnviosController : ApiController
    {
        private DbModels db = new DbModels();

        // GET: api/Envios
        public IQueryable<Envio> GetEnvio()
        {
            return db.Envio;
        }

        // GET: api/Envios/5
        [ResponseType(typeof(Envio))]
        public IHttpActionResult GetEnvio(string id)
        {
            Envio envio = db.Envio.Find(id);
            if (envio == null)
            {
                return NotFound();
            }
            env e = new env();
            e.Cod_Envio = envio.Cod_Envio;
            e.Cod_Pedido = envio.Cod_Pedido;
            e.Cod_Repartidores = envio.Cod_Repartidores;
            e.Cod_Sucursal = envio.Cod_Sucursal;
            e.Cod_Venta_Estado = envio.Cod_Venta_Estado;


            return Ok(envio);
        }

        // PUT: api/Envios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEnvio(string id, Envio envio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != envio.Cod_Envio)
            {
                return BadRequest();
            }

            db.Entry(envio).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnvioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Envios
        [ResponseType(typeof(Envio))]
        public IHttpActionResult PostEnvio(Envio envio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Envio.Add(envio);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (EnvioExists(envio.Cod_Envio))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = envio.Cod_Envio }, envio);
        }

        // DELETE: api/Envios/5
        [ResponseType(typeof(Envio))]
        public IHttpActionResult DeleteEnvio(string id)
        {
            Envio envio = db.Envio.Find(id);
            if (envio == null)
            {
                return NotFound();
            }

            db.Envio.Remove(envio);
            db.SaveChanges();

            return Ok(envio);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EnvioExists(string id)
        {
            return db.Envio.Count(e => e.Cod_Envio == id) > 0;
        }

        public class env
        {
            public string Cod_Envio { get; set; }
            public int Cod_Venta_Estado { get; set; }
            public string Cod_Pedido { get; set; }
            public string Cod_Sucursal { get; set; }
            public string Cod_Repartidores { get; set; }

        }
    }
}