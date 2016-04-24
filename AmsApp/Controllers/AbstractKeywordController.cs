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
    public class AbstractKeywordController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /AbstractKeyword/

        public ViewResult Index()
        {
            return View(db.AbstractKeywords.ToList());
        }

        //
        // GET: /AbstractKeyword/Details/5

        public ViewResult Details(int id)
        {
            AbstractKeywords abstractkeywords = db.AbstractKeywords.Find(id);
            return View(abstractkeywords);
        }

        //
        // GET: /AbstractKeyword/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AbstractKeyword/Create

        [HttpPost]
        public ActionResult Create(AbstractKeywords abstractkeywords)
        {
            if (ModelState.IsValid)
            {
                db.AbstractKeywords.Add(abstractkeywords);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(abstractkeywords);
        }
        
        //
        // GET: /AbstractKeyword/Edit/5
 
        public ActionResult Edit(int id)
        {
            AbstractKeywords abstractkeywords = db.AbstractKeywords.Find(id);
            return View(abstractkeywords);
        }

        //
        // POST: /AbstractKeyword/Edit/5

        [HttpPost]
        public ActionResult Edit(AbstractKeywords abstractkeywords)
        {
            if (ModelState.IsValid)
            {
                db.Entry(abstractkeywords).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(abstractkeywords);
        }

        //
        // GET: /AbstractKeyword/Delete/5
 
        public ActionResult Delete(int id)
        {
            AbstractKeywords abstractkeywords = db.AbstractKeywords.Find(id);
            return View(abstractkeywords);
        }

        //
        // POST: /AbstractKeyword/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            AbstractKeywords abstractkeywords = db.AbstractKeywords.Find(id);
            db.AbstractKeywords.Remove(abstractkeywords);
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