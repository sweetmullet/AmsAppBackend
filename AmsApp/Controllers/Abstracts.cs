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
    public class Default1Controller : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /Default1/

        public ViewResult Index()
        {
            return View(db.Abstract.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ViewResult Details(int id)
        {
            Abstracts abstracts = db.Abstract.Find(id);
            return View(abstracts);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(Abstracts abstracts)
        {
            if (ModelState.IsValid)
            {
                db.Abstract.Add(abstracts);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(abstracts);
        }


        public System.Web.Mvc.JsonResult Json(int id)
        {
            if (id == 0)
            {

                // var resultCount = results.Count;
                // var genericResult = new { Count = resultCount, Results = results };
                //return Json(genericResult);
                String allUsers = "";
                List<Abstracts> abstractList = new List<Abstracts>();
                abstractList = db.Abstract.ToList();
                User user = db.Users.Find(1);
                int abstractId =0;
                string title = "";
                string body = "";
                int isReviewed = 0;
                int eventId = 0;
                string subFirstName = "";
                string subLastName = "";
                string subEmail = "";
                int subTypeId = 0;

                String email;
                int roleId;

                //return Json(new { firstName = user.FirstName, lastName = user.LastName, roleId = user.RoleId, email = user.Email }, JsonRequestBehavior.AllowGet);

                foreach (Abstracts abstract2 in abstractList)
                {
                    abstractId = abstract2.AbstractsId;
                    title = abstract2.AbstractTitle;
                    body = abstract2.AbstractBody;
                    isReviewed = abstract2.IsReviewedInd;
                    eventId = abstract2.EventId;
                    subFirstName = abstract2.SubmitterFirstName;
                    subLastName = abstract2.SubmitterLastName;
                    subEmail = abstract2.SubmitterEmail;
                    subTypeId = abstract2.SubmissionTypeId;
                   // AbstractCatId = abstract2.


                    //lastName = abstract2.
                   // email = abstract2.Email;
                  //  roleId = abstract2.RoleId;
                    //return Json(new { firstName = user2.FirstName, lastName = user2.LastName, roleId = user2.RoleId, email = user2.Email }, JsonRequestBehavior.AllowGet);
                    //allUsers = allUsers + "{ firstName = " + firstName + ", lastName = " + lastName + ", roleId = " + roleId + ", email = " + email + " }";
                }
                return Json(new { allUsers }, JsonRequestBehavior.AllowGet);
            }

            else
            {
                User user = db.Users.Find(id);
                //return View(user);
                return Json(new { firstName = user.FirstName, lastName = user.LastName, roleId = user.RoleId, email = user.Email }, JsonRequestBehavior.AllowGet);
            }
        }

        
        //
        // GET: /Default1/Edit/5
 
        public ActionResult Edit(int id)
        {
            Abstracts abstracts = db.Abstract.Find(id);
            return View(abstracts);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(Abstracts abstracts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(abstracts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(abstracts);
        }

        //
        // GET: /Default1/Delete/5
 
        public ActionResult Delete(int id)
        {
            Abstracts abstracts = db.Abstract.Find(id);
            return View(abstracts);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Abstracts abstracts = db.Abstract.Find(id);
            db.Abstract.Remove(abstracts);
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