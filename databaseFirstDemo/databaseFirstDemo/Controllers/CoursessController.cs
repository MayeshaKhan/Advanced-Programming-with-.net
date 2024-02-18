using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using databaseFirstDemo.EF;
using databaseFirstDemo.Models;

namespace databaseFirstDemo.Controllers
{
    public class CoursessController : Controller
    {
        [HttpGet]
        public ActionResult Coursess()

        {
            var db = new taskEntities();
            
            var data = (from coursess in db.Coursesses
                        select coursess).ToList();
           
            return View(data);

            
        }
    }
}