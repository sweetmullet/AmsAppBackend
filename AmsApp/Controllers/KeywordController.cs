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
    public class KeywordController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /Keyword/

        public ViewResult Index()
        {
            return View(db.Keywords.ToList());
        }

        //
        // GET: /Keyword/Details/5

        public ViewResult Details(int id)
        {
            Keyword keyword = db.Keywords.Find(id);
            return View(keyword);
        }

        //
        // GET: /Keyword/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Keyword/Create

        [HttpPost]
        public ActionResult Create(Keyword keyword)
        {
            if (ModelState.IsValid)
            {
                db.Keywords.Add(keyword);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(keyword);
        }
        
        //
        // GET: /Keyword/Edit/5
 
        public ActionResult Edit(int id)
        {
            Keyword keyword = db.Keywords.Find(id);
            return View(keyword);
        }

        //
        // POST: /Keyword/Edit/5

        [HttpPost]
        public ActionResult Edit(Keyword keyword)
        {
            if (ModelState.IsValid)
            {
                db.Entry(keyword).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(keyword);
        }

        //
        // GET: /Keyword/Delete/5
 
        public ActionResult Delete(int id)
        {
            Keyword keyword = db.Keywords.Find(id);
            return View(keyword);
        }

        //
        // POST: /Keyword/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Keyword keyword = db.Keywords.Find(id);
            db.Keywords.Remove(keyword);
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