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
    public class ActionsController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /Actions/

        public ViewResult Index()
        {
            return View(db.Operation.ToList());
        }

        //
        // GET: /Actions/Details/5

        public ViewResult Details(int id)
        {
            Operation operation = db.Operation.Find(id);
            return View(operation);
        }

        //
        // GET: /Actions/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Actions/Create

        [HttpPost]
        public ActionResult Create(Operation operation)
        {
            if (ModelState.IsValid)
            {
                db.Operation.Add(operation);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(operation);
        }
        
        //
        // GET: /Actions/Edit/5
 
        public ActionResult Edit(int id)
        {
            Operation operation = db.Operation.Find(id);
            return View(operation);
        }

        //
        // POST: /Actions/Edit/5

        [HttpPost]
        public ActionResult Edit(Action actions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actions);
        }

        //
        // GET: /Actions/Delete/5
 
        public ActionResult Delete(int id)
        {
            Operation operation = db.Operation.Find(id);
            return View(operation);
        }

        //
        // POST: /Actions/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Operation operation = db.Operation.Find(id);
            db.Operation.Remove(operation);
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