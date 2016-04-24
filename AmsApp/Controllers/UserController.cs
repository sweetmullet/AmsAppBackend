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
    public class UserController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /User/

        public ViewResult Index()
        {
            return View(db.Users.ToList());
        }

        //
        // GET: /User/Details/5

        public ViewResult Details(int id)
        {
            User user = db.Users.Find(id);
            return View(user);
        }

        //
        // GET: /User/Create

        public ActionResult Create2()
        {
            return View();
        } 

        //
        // POST: /User/Create

        [HttpPost]
        public ActionResult Create(string firstName, string lastName, string email, int roleId)
        {

         //Create a product and a relationship to a known category by ID 
           User user = new User 
             { 
               FirstName = firstName,
                LastName = lastName, 
                 Email = email,
                 RoleId = roleId
                 };  

            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }

        //
        // GET: /User/Json/5


        public System.Web.Mvc.JsonResult Json(int id)
        {
            if (id == 0)
            {

               // var resultCount = results.Count;
               // var genericResult = new { Count = resultCount, Results = results };
                //return Json(genericResult);
                String allUsers = "";
                List<User> userList = new List<User>();
                userList = db.Users.ToList();
                User user = db.Users.Find(1);
                String firstName;
                String lastName;
                String email;
                int roleId;

                //return Json(new { firstName = user.FirstName, lastName = user.LastName, roleId = user.RoleId, email = user.Email }, JsonRequestBehavior.AllowGet);

                foreach (User user2 in userList)
                {
                    firstName = user2.FirstName;
                    lastName = user2.LastName;
                    email = user2.Email;
                    roleId = user2.RoleId;
                    //return Json(new { firstName = user2.FirstName, lastName = user2.LastName, roleId = user2.RoleId, email = user2.Email }, JsonRequestBehavior.AllowGet);
                    allUsers = allUsers + "{ firstName = " + firstName + ", lastName = " + lastName + ", roleId = " + roleId + ", email = " + email + " }";
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
        // GET: /User/Edit/5
 
        public ActionResult Edit(int id)
        {
            User user = db.Users.Find(id);
            return View(user);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //
        // GET: /User/Delete/5
 
        public ActionResult Delete(int id)
        {
            User user = db.Users.Find(id);
            return View(user);
        }

        //
        // POST: /User/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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