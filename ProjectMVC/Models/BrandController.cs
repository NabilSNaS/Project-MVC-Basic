using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Models
{
    public class BrandController : Controller
    {
        private Shop_BDEntities db = new Shop_BDEntities();

        // GET: /Brand/
        public ActionResult Index()
        {
            return View(db.Brand3.ToList());
        }

        // GET: /Brand/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand3 brand3 = db.Brand3.Find(id);
            if (brand3 == null)
            {
                return HttpNotFound();
            }
            return View(brand3);
        }

        // GET: /Brand/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Brand/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="id,Brand_Name")] Brand3 brand3)
        {
            if (ModelState.IsValid)
            {
                db.Brand3.Add(brand3);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brand3);
        }

        // GET: /Brand/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand3 brand3 = db.Brand3.Find(id);
            if (brand3 == null)
            {
                return HttpNotFound();
            }
            return View(brand3);
        }

        // POST: /Brand/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="id,Brand_Name")] Brand3 brand3)
        {
            if (ModelState.IsValid)
            {
                db.Entry(brand3).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brand3);
        }

        // GET: /Brand/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand3 brand3 = db.Brand3.Find(id);
            if (brand3 == null)
            {
                return HttpNotFound();
            }
            return View(brand3);
        }

        // POST: /Brand/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Brand3 brand3 = db.Brand3.Find(id);
            db.Brand3.Remove(brand3);
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
