using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eCommerce.Database;
using eCommerce.Tables;

namespace eCommerce.Web.Controllers
{
    public class subCategoriesController : Controller
    {
        private databaseContext db = new databaseContext();

        // GET: subCategories
        public ActionResult Index()
        {
            var subCategory = db.subCategory.Include(s => s.category);
            return View(subCategory.ToList());
        }

        // GET: subCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subCategory subCategory = db.subCategory.Find(id);
            if (subCategory == null)
            {
                return HttpNotFound();
            }
            return View(subCategory);
        }

        // GET: subCategories/Create
        public ActionResult Create()
        {
            ViewBag.categoryID = new SelectList(db.Category, "ID", "Name");
            return View();
        }

        // POST: subCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,categoryID")] subCategory subCategory)
        {
            if (ModelState.IsValid)
            {
                db.subCategory.Add(subCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.categoryID = new SelectList(db.Category, "ID", "Name", subCategory.categoryID);
            return View(subCategory);
        }

        // GET: subCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subCategory subCategory = db.subCategory.Find(id);
            if (subCategory == null)
            {
                return HttpNotFound();
            }
            ViewBag.categoryID = new SelectList(db.Category, "ID", "Name", subCategory.categoryID);
            return View(subCategory);
        }

        // POST: subCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,categoryID")] subCategory subCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categoryID = new SelectList(db.Category, "ID", "Name", subCategory.categoryID);
            return View(subCategory);
        }

        // GET: subCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subCategory subCategory = db.subCategory.Find(id);
            if (subCategory == null)
            {
                return HttpNotFound();
            }
            return View(subCategory);
        }

        // POST: subCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            subCategory subCategory = db.subCategory.Find(id);
            db.subCategory.Remove(subCategory);
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
