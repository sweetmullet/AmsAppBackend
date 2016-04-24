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
    public class SubmissionTypeController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /SubmissionType/

        public ViewResult Index()
        {
            return View(db.SubmissionTypes.ToList());
        }

        //
        // GET: /SubmissionType/Details/5

        public ViewResult Details(int id)
        {
            SubmissionType submissiontype = db.SubmissionTypes.Find(id);
            return View(submissiontype);
        }

        //
        // GET: /SubmissionType/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /SubmissionType/Create

        [HttpPost]
        public ActionResult Create(SubmissionType submissiontype)
        {
            if (ModelState.IsValid)
            {
                db.SubmissionTypes.Add(submissiontype);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(submissiontype);
        }
        
        //
        // GET: /SubmissionType/Edit/5
 
        public ActionResult Edit(int id)
        {
            SubmissionType submissiontype = db.SubmissionTypes.Find(id);
            return View(submissiontype);
        }

        //
        // POST: /SubmissionType/Edit/5

        [HttpPost]
        public ActionResult Edit(SubmissionType submissiontype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(submissiontype).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(submissiontype);
        }

        //
        // GET: /SubmissionType/Delete/5
 
        public ActionResult Delete(int id)
        {
            SubmissionType submissiontype = db.SubmissionTypes.Find(id);
            return View(submissiontype);
        }

        //
        // POST: /SubmissionType/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            SubmissionType submissiontype = db.SubmissionTypes.Find(id);
            db.SubmissionTypes.Remove(submissiontype);
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