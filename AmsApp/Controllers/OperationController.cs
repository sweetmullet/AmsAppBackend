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
    public class OperationController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /Operation/

        public ViewResult Index()
        {
            return View(db.Operation.ToList());
        }

        //
        // GET: /Operation/Details/5

        public ViewResult Details(int id)
        {
            Operation operation = db.Operation.Find(id);
            return View(operation);
        }

        //
        // GET: /Operation/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Operation/Create

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
        // GET: /Operation/Edit/5
 
        public ActionResult Edit(int id)
        {
            Operation operation = db.Operation.Find(id);
            return View(operation);
        }

        //
        // POST: /Operation/Edit/5

        [HttpPost]
        public ActionResult Edit(Operation operation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(operation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(operation);
        }

        //
        // GET: /Operation/Delete/5
 
        public ActionResult Delete(int id)
        {
            Operation operation = db.Operation.Find(id);
            return View(operation);
        }

        //
        // POST: /Operation/Delete/5

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