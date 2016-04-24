using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmsApp.Models;

namespace AmsApp.Controllers
{ 
    public class AuthorController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /Author/

        public ViewResult Index()
        {
            return View(db.Authors.ToList());
        }

        //
        // GET: /Author/Details/5

        public ViewResult Details(int id)
        {
            Author author = db.Authors.Find(id);
            return View(author);
        }

        //
        // GET: /Author/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Author/Create

        [HttpPost]
        public ActionResult Create(Author author)
        {
            if (ModelState.IsValid)
            {
                db.Authors.Add(author);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(author);
        }
        
        //
        // GET: /Author/Edit/5
 
        public ActionResult Edit(int id)
        {
            Author author = db.Authors.Find(id);
            return View(author);
        }

        //
        // POST: /Author/Edit/5

        [HttpPost]
        public ActionResult Edit(Author author)
        {
            if (ModelState.IsValid)
            {
                db.Entry(author).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(author);
        }

        //
        // GET: /Author/Delete/5
 
        public ActionResult Delete(int id)
        {
            Author author = db.Authors.Find(id);
            return View(author);
        }

        //
        // POST: /Author/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Author author = db.Authors.Find(id);
            db.Authors.Remove(author);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}