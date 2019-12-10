﻿using System;
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
    public class Pedido_de_Venta1Controller : ApiController
    {
        private DbModels db = new DbModels();

        // GET: api/Pedido_de_Venta1
        public IQueryable<Pedido_de_Venta> GetPedido_de_Venta()
        {
            return db.Pedido_de_Venta;
        }

        // GET: api/Pedido_de_Venta1/5
        [ResponseType(typeof(Pedido_de_Venta))]
        public IHttpActionResult GetPedido_de_Venta(string id)
        {
            Pedido_de_Venta pedido_de_Venta = db.Pedido_de_Venta.Find(id);
            if (pedido_de_Venta == null)
            {
                return NotFound();
            }

            ped x = new ped();
            x.Cod_Pedido = pedido_de_Venta.Cod_Pedido;
            x.Cod_Producto = pedido_de_Venta.Cod_Producto;
            x.Cod_Sucursal = pedido_de_Venta.Cod_Sucursal;
            x.Cod_Venta = pedido_de_Venta.Cod_Venta;
            x.Cantidad = pedido_de_Venta.Cantidad;
            x.Cod_Repartidor = pedido_de_Venta.Cod_Repartidor;
            x.FechaHora_Pedido = pedido_de_Venta.FechaHora_Pedido;




            return Ok(x);
        }

        // PUT: api/Pedido_de_Venta1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPedido_de_Venta(string id, Pedido_de_Venta pedido_de_Venta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pedido_de_Venta.Cod_Pedido)
            {
                return BadRequest();
            }

            db.Entry(pedido_de_Venta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Pedido_de_VentaExists(id))
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

        // POST: api/Pedido_de_Venta1
        [ResponseType(typeof(Pedido_de_Venta))]
        public IHttpActionResult PostPedido_de_Venta(Pedido_de_Venta pedido_de_Venta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pedido_de_Venta.Add(pedido_de_Venta);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Pedido_de_VentaExists(pedido_de_Venta.Cod_Pedido))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pedido_de_Venta.Cod_Pedido }, pedido_de_Venta);
        }

        // DELETE: api/Pedido_de_Venta1/5
        [ResponseType(typeof(Pedido_de_Venta))]
        public IHttpActionResult DeletePedido_de_Venta(string id)
        {
            Pedido_de_Venta pedido_de_Venta = db.Pedido_de_Venta.Find(id);
            if (pedido_de_Venta == null)
            {
                return NotFound();
            }

            db.Pedido_de_Venta.Remove(pedido_de_Venta);
            db.SaveChanges();

            return Ok(pedido_de_Venta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Pedido_de_VentaExists(string id)
        {
            return db.Pedido_de_Venta.Count(e => e.Cod_Pedido == id) > 0;
        }

        private class ped
        {
            public string Cod_Pedido { get; set; }
            public string Cod_Producto { get; set; }
            public string Cod_Sucursal { get; set; }
            public string Cod_Venta { get; set; }
            public int Cantidad { get; set; }
            public string Cod_Repartidor { get; set; }
            public System.DateTime FechaHora_Pedido { get; set; }
        }
    }
}