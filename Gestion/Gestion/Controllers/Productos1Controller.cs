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
    public class Productos1Controller : ApiController
    {
        private DbModels db = new DbModels();

        // GET: api/Productos1
        public IQueryable<Productos> GetProductos()
        {
            return db.Productos;
        }

        // GET: api/Productos1/5
        [ResponseType(typeof(Productos))]
        public IHttpActionResult GetProductos(string id)
        {
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return NotFound();
            }
            prod p = new prod();
            p.Cod_Producto = productos.Cod_Producto;
            p.Nombre_Producto = productos.Nombre_Producto;
            p.Cod_Marca = productos.Cod_Marca;
            p.Informacion = productos.Informacion;
            p.Precio_Venta = productos.Precio_Venta;
            p.Oferta = productos.Oferta;
            p.Cod_SubCategoria = productos.Cod_SubCategoria;
            p.URLVideo = productos.URLVideo;

            return Ok(p);
        }

        // PUT: api/Productos1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProductos(string id, Productos productos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productos.Cod_Producto)
            {
                return BadRequest();
            }

            db.Entry(productos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductosExists(id))
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

        // POST: api/Productos1
        [ResponseType(typeof(Productos))]
        public IHttpActionResult PostProductos(Productos productos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Productos.Add(productos);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProductosExists(productos.Cod_Producto))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = productos.Cod_Producto }, productos);
        }

        // DELETE: api/Productos1/5
        [ResponseType(typeof(Productos))]
        public IHttpActionResult DeleteProductos(string id)
        {
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return NotFound();
            }

            db.Productos.Remove(productos);
            db.SaveChanges();

            return Ok(productos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductosExists(string id)
        {
            return db.Productos.Count(e => e.Cod_Producto == id) > 0;
        }
        public class prod
        {
            public string Cod_Producto { get; set; }
            public string Nombre_Producto { get; set; }
            public string Cod_Marca { get; set; }
            public string Informacion { get; set; }
            public int Precio_Venta { get; set; }
            public string Oferta { get; set; }
            public string Cod_SubCategoria { get; set; }
            public string URLVideo { get; set; }
        }
    }
}