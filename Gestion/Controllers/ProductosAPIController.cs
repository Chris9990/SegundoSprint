using Gestion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Gestion.Controllers
{
    public class ProductosAPIController : ApiController
    {
        // GET: api/ProductosAPI
        public IEnumerable<Productos> Get()
        {
            using (DbModels dbmodel = new DbModels())
            {
                return dbmodel.Productos.ToList();
            }
        }

        // GET: api/Pedido_de_Venta/5
        public HttpResponseMessage Get(string id)
        {
            using (DbModels dbmodel = new DbModels())
            {
                var entity = dbmodel.Productos.FirstOrDefault(e => e.Cod_Producto == id);

                if (entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Pedido con Codigo = " + id + " no encontrado");
                }
            }

        }

        // POST: api/Pedido_de_Venta
        public HttpResponseMessage Post([FromBody]Productos producto)
        {
            try
            {

                using (DbModels dbmodel = new DbModels())
                {
                    dbmodel.Productos.Add(producto);
                    dbmodel.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, producto);
                    message.Headers.Location = new Uri(Request.RequestUri + producto.Cod_Producto);
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
