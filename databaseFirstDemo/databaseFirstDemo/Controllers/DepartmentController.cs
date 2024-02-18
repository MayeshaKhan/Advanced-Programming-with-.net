using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace databaseFirstDemo.Controllers
{
    public class DepartmentController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        /*public ActionResult Index()
        {
            return View();
        }*/
    }
}