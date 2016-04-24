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
    public class AbstractController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /Abstract/

        public ViewResult Index()
        {
            return View(db.Abstracts.ToList());
        }

        //
        // GET: /Abstract/Details/5

        public ViewResult Details(int id)
        {
            Abstract abstracts = db.Abstracts.Find(id);
            return View(abstracts);
        }

        //
        // GET: /Abstract/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Abstract/Create

        [HttpPost]
        public ActionResult Create(Abstract abstracts)
        {
            if (ModelState.IsValid)
            {
                db.Abstracts.Add(abstracts);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(abstracts);
        }
        
        //
        // GET: /Abstract/Edit/5
 
        public ActionResult Edit(int id)
        {
            Abstract abstracts = db.Abstracts.Find(id);
            return View(abstracts);
        }

        //
        // POST: /Abstract/Edit/5

        [HttpPost]
        public ActionResult Edit(Abstract abstracts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(abstracts).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(abstracts);
        }

        //
        // GET: /Abstract/Delete/5
 
        public ActionResult Delete(int id)
        {
            Abstract abstracts = db.Abstracts.Find(id);
            return View(abstracts);
        }

        //
        // POST: /Abstract/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Abstract abstracts = db.Abstracts.Find(id);
            db.Abstracts.Remove(abstracts);
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