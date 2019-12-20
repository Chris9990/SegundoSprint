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
    public class Compras1Controller : ApiController
    {
        private DbModels db = new DbModels();

        // GET: api/Compras1
        public IQueryable<Compras> GetCompras()
        {
            return db.Compras;
        }

        // GET: api/Compras1/5
        [ResponseType(typeof(Compras))]
        public IHttpActionResult GetCompras(string id)
        {
            Compras compras = db.Compras.Find(id);
            if (compras == null)
            {
                return NotFound();
            }

            return Ok(compras);
        }

        // PUT: api/Compras1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompras(string id, Compras compras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != compras.Cod_Compra)
            {
                return BadRequest();
            }

            db.Entry(compras).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComprasExists(id))
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

        // POST: api/Compras1
        [ResponseType(typeof(Compras))]
        public IHttpActionResult PostCompras(Compras compras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Compras.Add(compras);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ComprasExists(compras.Cod_Compra))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = compras.Cod_Compra }, compras);
        }

        // DELETE: api/Compras1/5
        [ResponseType(typeof(Compras))]
        public IHttpActionResult DeleteCompras(string id)
        {
            Compras compras = db.Compras.Find(id);
            if (compras == null)
            {
                return NotFound();
            }

            db.Compras.Remove(compras);
            db.SaveChanges();

            return Ok(compras);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ComprasExists(string id)
        {
            return db.Compras.Count(e => e.Cod_Compra == id) > 0;
        }
    }
}