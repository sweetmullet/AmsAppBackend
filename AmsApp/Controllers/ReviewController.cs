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
    public class ReviewController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /Review/

        public ViewResult Index()
        {
            return View(db.Reviews.ToList());
        }

        //
        // GET: /Review/Details/5

        public ViewResult Details(int id)
        {
            Reviews reviews = db.Reviews.Find(id);
            return View(reviews);
        }

        //
        // GET: /Review/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Review/Create

        [HttpPost]
        public ActionResult Create(Reviews reviews)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(reviews);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(reviews);
        }
        
        //
        // GET: /Review/Edit/5
 
        public ActionResult Edit(int id)
        {
            Reviews reviews = db.Reviews.Find(id);
            return View(reviews);
        }

        //
        // POST: /Review/Edit/5

        [HttpPost]
        public ActionResult Edit(Reviews reviews)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reviews).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reviews);
        }

        //
        // GET: /Review/Delete/5
 
        public ActionResult Delete(int id)
        {
            Reviews reviews = db.Reviews.Find(id);
            return View(reviews);
        }

        //
        // POST: /Review/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Reviews reviews = db.Reviews.Find(id);
            db.Reviews.Remove(reviews);
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