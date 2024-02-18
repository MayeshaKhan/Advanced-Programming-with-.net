using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using databaseFirstDemo.EF;
using databaseFirstDemo.Models;


namespace databaseFirstDemo.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ActionResult Student()
        {
            return View(new Models.Student());
        }
        [HttpPost]
        public ActionResult Student(EF.Student s)       
        {
            if (ModelState.IsValid)
            { 
                var db = new taskEntities();
                
                db.Students.Add(s);
                db.SaveChanges();
                return RedirectToAction("Coursess","Coursess");
            }
            return View(s);
        }
       
    }
}