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
    public class ProductController : Controller
    {
        private Shop_BDEntities db = new Shop_BDEntities();

        // GET: /Product/
        public ActionResult Index()
        {
            var product2 = db.product2.Include(p => p.Brand3).Include(p => p.category);
            return View(product2.ToList());
        }

        // GET: /Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product2 product2 = db.product2.Find(id);
            if (product2 == null)
            {
                return HttpNotFound();
            }
            return View(product2);
        }

        // GET: /Product/Create
        public ActionResult Create()
        {
            ViewBag.brand_id = new SelectList(db.Brand3, "id", "Brand_Name");
            ViewBag.cat_id = new SelectList(db.categories, "id", "Category_Name");
            return View();
        }

        // POST: /Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="id,proname,cat_id,brand_id,quntity,price")] product2 product2)
        {
            if (ModelState.IsValid)
            {
                db.product2.Add(product2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.brand_id = new SelectList(db.Brand3, "id", "Brand_Name", product2.brand_id);
            ViewBag.cat_id = new SelectList(db.categories, "id", "Category_Name", product2.cat_id);
            return View(product2);
        }

        // GET: /Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product2 product2 = db.product2.Find(id);
            if (product2 == null)
            {
                return HttpNotFound();
            }
            ViewBag.brand_id = new SelectList(db.Brand3, "id", "Brand_Name", product2.brand_id);
            ViewBag.cat_id = new SelectList(db.categories, "id", "Category_Name", product2.cat_id);
            return View(product2);
        }

        // POST: /Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="id,proname,cat_id,brand_id,quntity,price")] product2 product2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.brand_id = new SelectList(db.Brand3, "id", "Brand_Name", product2.brand_id);
            ViewBag.cat_id = new SelectList(db.categories, "id", "Category_Name", product2.cat_id);
            return View(product2);
        }

        // GET: /Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product2 product2 = db.product2.Find(id);
            if (product2 == null)
            {
                return HttpNotFound();
            }
            return View(product2);
        }

        // POST: /Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            product2 product2 = db.product2.Find(id);
            db.product2.Remove(product2);
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
