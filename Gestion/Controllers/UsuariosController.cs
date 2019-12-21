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
    public class UsuariosController : ApiController
    {
        private DbModels db = new DbModels();
        // GET: api/Marcas1
        public IQueryable<Usuarios> GetClientes1()
        {
            return db.Usuarios;
        }

        // GET: api/Marcas1/5
        [ResponseType(typeof(Usuarios))]
        public IHttpActionResult GetClientes1(string id)
        {
            Usuarios usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }
            use c = new use();

            c.Usuario = usuario.Usuario;
            c.Password = usuario.Password;


            return Ok(c);
        }

        // PUT: api/Marcas1/5
        /*[ResponseType(typeof(void))]
        public IHttpActionResult PutMarcas(string id, Marcas marcas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != marcas.Cod_Marca)
            {
                return BadRequest();
            }

            db.Entry(marcas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcasExists(id))
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

        // POST: api/Marcas1
        [ResponseType(typeof(Marcas))]
        public IHttpActionResult PostMarcas(Marcas marcas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Marcas.Add(marcas);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (MarcasExists(marcas.Cod_Marca))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = marcas.Cod_Marca }, marcas);
        }

        // DELETE: api/Marcas1/5
        [ResponseType(typeof(Marcas))]
        public IHttpActionResult DeleteMarcas(string id)
        {
            Marcas marcas = db.Marcas.Find(id);
            if (marcas == null)
            {
                return NotFound();
            }

            db.Marcas.Remove(marcas);
            db.SaveChanges();

            return Ok(marcas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MarcasExists(string id)
        {
            return db.Marcas.Count(e => e.Cod_Marca == id) > 0;
        }
        */
        private class use
        {
            public string Usuario { get; set; }
            public string Password { get; set; }
        }

    }
}
