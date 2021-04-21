using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nhom08PTPMQL.Models;

namespace Nhom08PTPMQL.Controllers
{
    public class EncrytionsController : Controller
    {
        private DemoDbContext db = new DemoDbContext();

        // GET: Encrytions
        public ActionResult Index()
        {
            return View(db.Encrytions.ToList());
        }

        // GET: Encrytions/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encrytion encrytion = db.Encrytions.Find(id);
            if (encrytion == null)
            {
                return HttpNotFound();
            }
            return View(encrytion);
        }

        // GET: Encrytions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Encrytions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ktdn")] Encrytion encrytion)
        {
            if (ModelState.IsValid)
            {
                db.Encrytions.Add(encrytion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(encrytion);
        }

        // GET: Encrytions/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encrytion encrytion = db.Encrytions.Find(id);
            if (encrytion == null)
            {
                return HttpNotFound();
            }
            return View(encrytion);
        }

        // POST: Encrytions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ktdn")] Encrytion encrytion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(encrytion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(encrytion);
        }

        // GET: Encrytions/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encrytion encrytion = db.Encrytions.Find(id);
            if (encrytion == null)
            {
                return HttpNotFound();
            }
            return View(encrytion);
        }

        // POST: Encrytions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Encrytion encrytion = db.Encrytions.Find(id);
            db.Encrytions.Remove(encrytion);
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
