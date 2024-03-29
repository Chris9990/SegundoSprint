﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Gestion.Models;

namespace Gestion.Controllers
{
    [Authorize]
    public class ProductosController : Controller
    {
        private DbModels db = new DbModels();

        // GET: Productos
        public ActionResult Index()
        {
            var productos = db.Productos.Include(p => p.Marcas).Include(p => p.SubCategoria);
            return View(productos.ToList());
        }

        // GET: Productos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            return View(productos);
        }

        // GET: Productos/Create
        public ActionResult Create()
        {
            ViewBag.Cod_Marca = new SelectList(db.Marcas, "Cod_Marca", "Nombre_Marca");
            ViewBag.Cod_SubCategoria = new SelectList(db.SubCategoria, "Cod_SubCategoria", "Nombre_SubCategoria");
            return View();
        }

        // POST: Productos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cod_Producto,Nombre_Producto,Cod_Marca,Informacion,Precio_Venta,Oferta,Cod_SubCategoria,URLVideo,stock")] Productos productos)
        {
            if (ModelState.IsValid)
            {
                db.Productos.Add(productos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_Marca = new SelectList(db.Marcas, "Cod_Marca", "Nombre_Marca", productos.Cod_Marca);
            ViewBag.Cod_SubCategoria = new SelectList(db.SubCategoria, "Cod_SubCategoria", "Nombre_SubCategoria", productos.Cod_SubCategoria);
            return View(productos);
        }

        // GET: Productos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_Marca = new SelectList(db.Marcas, "Cod_Marca", "Nombre_Marca", productos.Cod_Marca);
            ViewBag.Cod_SubCategoria = new SelectList(db.SubCategoria, "Cod_SubCategoria", "Nombre_SubCategoria", productos.Cod_SubCategoria);
            return View(productos);
        }

        // POST: Productos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Cod_Producto,Nombre_Producto,Cod_Marca,Informacion,Precio_Venta,Oferta,Cod_SubCategoria,URLVideo,stock")] Productos productos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_Marca = new SelectList(db.Marcas, "Cod_Marca", "Nombre_Marca", productos.Cod_Marca);
            ViewBag.Cod_SubCategoria = new SelectList(db.SubCategoria, "Cod_SubCategoria", "Nombre_SubCategoria", productos.Cod_SubCategoria);
            return View(productos);
        }

        // GET: Productos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos productos = db.Productos.Find(id);
            if (productos == null)
            {
                return HttpNotFound();
            }
            return View(productos);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Productos productos = db.Productos.Find(id);
            db.Productos.Remove(productos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
