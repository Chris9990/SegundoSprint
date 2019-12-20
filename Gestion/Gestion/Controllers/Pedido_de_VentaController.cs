using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gestion.Models;

namespace Gestion.Controllers
{
    public class Pedido_de_VentaController : ApiController
    {
        /*  // GET: api/Pedido_de_Venta
          public IEnumerable<Pedido_de_VentaAPI> Get()
          {
              using (DbModels dbmodel = new DbModels())
              {
                  return dbmodel.Pedido_de_VentaAPI.ToList();
              }
          }

          // GET: api/Pedido_de_Venta/5
          public HttpResponseMessage Get(string id)
          {
              using (DbModels dbmodel = new DbModels())
              {
                  var entity = dbmodel.Pedido_de_VentaAPI.FirstOrDefault(e => e.Cod_Pedido == id);

                  if(entity != null)
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
          public HttpResponseMessage Post([FromBody]Pedido_de_VentaAPI pedido_De_VentaAPI)
          {
              try { 

                  using (DbModels dbmodel = new DbModels())
              {
                  dbmodel.Pedido_de_VentaAPI.Add(pedido_De_VentaAPI);
                  dbmodel.SaveChanges();

                  var message = Request.CreateResponse(HttpStatusCode.Created, pedido_De_VentaAPI);
                  message.Headers.Location = new Uri(Request.RequestUri + pedido_De_VentaAPI.Cod_Pedido);
                  return message;
              }
              }
              catch(Exception ex)
              {
                  return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
              }
          }
         // public void Post([FromBody]Pedido_de_Venta pedido)
         // {
          //    using (DbModels dbmodel = new DbModels())
          //    {
          //        dbmodel.Pedido_de_Venta.Add(pedido);
          //        dbmodel.SaveChanges();
          //    }
         // }
          // PUT: api/Pedido_de_Venta/5
          // public void Put(int id, [FromBody]string value)
          // {
          // }

          // DELETE: api/Pedido_de_Venta/5
          //public void Delete(int id)
          //{
          //}

      */
    }
    
}
