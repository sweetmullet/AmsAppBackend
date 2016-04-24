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
    public class AssociatedAuthorController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /AssociatedAuthor/

        public ViewResult Index()
        {
            return View(db.AssociatedAuthors.ToList());
        }

        //
        // GET: /AssociatedAuthor/Details/5

        public ViewResult Details(int id)
        {
            AssociatedAuthors associatedauthors = db.AssociatedAuthors.Find(id);
            return View(associatedauthors);
        }

        //
        // GET: /AssociatedAuthor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AssociatedAuthor/Create

        [HttpPost]
        public ActionResult Create(AssociatedAuthors associatedauthors)
        {
            if (ModelState.IsValid)
            {
                db.AssociatedAuthors.Add(associatedauthors);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(associatedauthors);
        }
        
        //
        // GET: /AssociatedAuthor/Edit/5
 
        public ActionResult Edit(int id)
        {
            AssociatedAuthors associatedauthors = db.AssociatedAuthors.Find(id);
            return View(associatedauthors);
        }

        //
        // POST: /AssociatedAuthor/Edit/5

        [HttpPost]
        public ActionResult Edit(AssociatedAuthors associatedauthors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(associatedauthors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(associatedauthors);
        }

        //
        // GET: /AssociatedAuthor/Delete/5
 
        public ActionResult Delete(int id)
        {
            AssociatedAuthors associatedauthors = db.AssociatedAuthors.Find(id);
            return View(associatedauthors);
        }

        //
        // POST: /AssociatedAuthor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            AssociatedAuthors associatedauthors = db.AssociatedAuthors.Find(id);
            db.AssociatedAuthors.Remove(associatedauthors);
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