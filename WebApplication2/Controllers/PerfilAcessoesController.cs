using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PerfilAcessoesController : Controller
    {
        private Context db = new Context();

        // GET: PerfilAcessoes
        public ActionResult Index()
        {
            return View(db.PerfilAcessos.ToList());
        }

        // GET: PerfilAcessoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PerfilAcesso perfilAcesso = db.PerfilAcessos.Find(id);
            if (perfilAcesso == null)
            {
                return HttpNotFound();
            }
            return View(perfilAcesso);
        }

        // GET: PerfilAcessoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PerfilAcessoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPerfilAcesso,Descricao")] PerfilAcesso perfilAcesso)
        {
            if (ModelState.IsValid)
            {
                db.PerfilAcessos.Add(perfilAcesso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(perfilAcesso);
        }

        // GET: PerfilAcessoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PerfilAcesso perfilAcesso = db.PerfilAcessos.Find(id);
            if (perfilAcesso == null)
            {
                return HttpNotFound();
            }
            return View(perfilAcesso);
        }

        // POST: PerfilAcessoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPerfilAcesso,Descricao")] PerfilAcesso perfilAcesso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(perfilAcesso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(perfilAcesso);
        }

        // GET: PerfilAcessoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PerfilAcesso perfilAcesso = db.PerfilAcessos.Find(id);
            if (perfilAcesso == null)
            {
                return HttpNotFound();
            }
            return View(perfilAcesso);
        }

        // POST: PerfilAcessoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PerfilAcesso perfilAcesso = db.PerfilAcessos.Find(id);
            db.PerfilAcessos.Remove(perfilAcesso);
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
