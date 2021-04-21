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
    public class DescribesController : Controller
    {
        private DemoDbContext db = new DemoDbContext();

        // GET: Describes
        public ActionResult Index()
        {
            return View(db.Describes.ToList());
        }

        // GET: Describes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Describe describe = db.Describes.Find(id);
            if (describe == null)
            {
                return HttpNotFound();
            }
            return View(describe);
        }

        // GET: Describes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Describes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NameDescribe,ContentDescribe")] Describe describe)
        {
            if (ModelState.IsValid)
            {
                db.Describes.Add(describe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(describe);
        }

        // GET: Describes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Describe describe = db.Describes.Find(id);
            if (describe == null)
            {
                return HttpNotFound();
            }
            return View(describe);
        }

        // POST: Describes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NameDescribe,ContentDescribe")] Describe describe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(describe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(describe);
        }

        // GET: Describes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Describe describe = db.Describes.Find(id);
            if (describe == null)
            {
                return HttpNotFound();
            }
            return View(describe);
        }

        // POST: Describes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Describe describe = db.Describes.Find(id);
            db.Describes.Remove(describe);
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
