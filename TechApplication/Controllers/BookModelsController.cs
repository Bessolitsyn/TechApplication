using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TechApplication.Models;

namespace TechApplication.Controllers
{
    public class BookModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public JsonResult NameValid(string name)
        {
            var result = !(name == "1234");
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        // GET: BookModels
        public ActionResult Index()
        {
            //return View(db.BookModels.ToList());

            List<BookModel> bk = new List<BookModel>();
            bk.Add(new BookModel());
            bk[0].Author = "qasa";
            bk[0].Id = 1;
            bk[0].Name = "dsdsds";
            return View(bk);
            //return View("_RegionFeatures", new BookModel());
        }

        // GET: BookModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookModel bookModel = db.BookModels.Find(id);
            if (bookModel == null)
            {
                return HttpNotFound();
            }
            return View(bookModel);
        }

        // GET: BookModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Name,Author,Year")] BookModel bookModel)
        public ActionResult Create(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                db.BookModels.Add(bookModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookModel);
        }

        // GET: BookModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookModel bookModel = db.BookModels.Find(id);
            if (bookModel == null)
            {
                return HttpNotFound();
            }
            return View(bookModel);
        }

        // POST: BookModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Author,Year")] BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookModel);
        }

        // GET: BookModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookModel bookModel = db.BookModels.Find(id);
            if (bookModel == null)
            {
                return HttpNotFound();
            }
            return View(bookModel);
        }

        // POST: BookModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookModel bookModel = db.BookModels.Find(id);
            db.BookModels.Remove(bookModel);
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
