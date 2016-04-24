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
    public class RoleOperationController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /RoleOperation/

        public ViewResult Index()
        {
            return View(db.RoleOperations.ToList());
        }

        //
        // GET: /RoleOperation/Details/5

        public ViewResult Details(int id)
        {
            RoleOperation roleoperation = db.RoleOperations.Find(id);
            return View(roleoperation);
        }

        //
        // GET: /RoleOperation/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /RoleOperation/Create

        [HttpPost]
        public ActionResult Create(RoleOperation roleoperation)
        {
            if (ModelState.IsValid)
            {
                db.RoleOperations.Add(roleoperation);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(roleoperation);
        }
        
        //
        // GET: /RoleOperation/Edit/5
 
        public ActionResult Edit(int id)
        {
            RoleOperation roleoperation = db.RoleOperations.Find(id);
            return View(roleoperation);
        }

        //
        // POST: /RoleOperation/Edit/5

        [HttpPost]
        public ActionResult Edit(RoleOperation roleoperation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roleoperation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roleoperation);
        }

        //
        // GET: /RoleOperation/Delete/5
 
        public ActionResult Delete(int id)
        {
            RoleOperation roleoperation = db.RoleOperations.Find(id);
            return View(roleoperation);
        }

        //
        // POST: /RoleOperation/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            RoleOperation roleoperation = db.RoleOperations.Find(id);
            db.RoleOperations.Remove(roleoperation);
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