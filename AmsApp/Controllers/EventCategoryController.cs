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
    public class EventCategoryController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /EventCategory/

        public ViewResult Index()
        {
            return View(db.EventCategories.ToList());
        }

        //
        // GET: /EventCategory/Details/5

        public ViewResult Details(int id)
        {
            EventCategories eventcategories = db.EventCategories.Find(id);
            return View(eventcategories);
        }

        //
        // GET: /EventCategory/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /EventCategory/Create

        [HttpPost]
        public ActionResult Create(EventCategories eventcategories)
        {
            if (ModelState.IsValid)
            {
                db.EventCategories.Add(eventcategories);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(eventcategories);
        }
        
        //
        // GET: /EventCategory/Edit/5
 
        public ActionResult Edit(int id)
        {
            EventCategories eventcategories = db.EventCategories.Find(id);
            return View(eventcategories);
        }

        //
        // POST: /EventCategory/Edit/5

        [HttpPost]
        public ActionResult Edit(EventCategories eventcategories)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventcategories).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventcategories);
        }

        //
        // GET: /EventCategory/Delete/5
 
        public ActionResult Delete(int id)
        {
            EventCategories eventcategories = db.EventCategories.Find(id);
            return View(eventcategories);
        }

        //
        // POST: /EventCategory/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            EventCategories eventcategories = db.EventCategories.Find(id);
            db.EventCategories.Remove(eventcategories);
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