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
    public class AbstractCategoryController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /AbstractCategory/

        public ViewResult Index()
        {
            return View(db.AbstractCategories.ToList());
        }

        //
        // GET: /AbstractCategory/Details/5

        public ViewResult Details(int id)
        {
            AbstractCategory abstractcategory = db.AbstractCategories.Find(id);
            return View(abstractcategory);
        }

        //
        // GET: /AbstractCategory/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AbstractCategory/Create

        [HttpPost]
        public ActionResult Create(AbstractCategory abstractcategory)
        {
            if (ModelState.IsValid)
            {
                db.AbstractCategories.Add(abstractcategory);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(abstractcategory);
        }
        
        //
        // GET: /AbstractCategory/Edit/5
 
        public ActionResult Edit(int id)
        {
            AbstractCategory abstractcategory = db.AbstractCategories.Find(id);
            return View(abstractcategory);
        }

        //
        // POST: /AbstractCategory/Edit/5

        [HttpPost]
        public ActionResult Edit(AbstractCategory abstractcategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(abstractcategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(abstractcategory);
        }

        //
        // GET: /AbstractCategory/Delete/5
 
        public ActionResult Delete(int id)
        {
            AbstractCategory abstractcategory = db.AbstractCategories.Find(id);
            return View(abstractcategory);
        }

        //
        // POST: /AbstractCategory/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            AbstractCategory abstractcategory = db.AbstractCategories.Find(id);
            db.AbstractCategories.Remove(abstractcategory);
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