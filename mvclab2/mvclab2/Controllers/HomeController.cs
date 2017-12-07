using mvclab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvclab2.Controllers
{
    public class HomeController : Controller
    {
        private Laba2DBEntities3 db = new Laba2DBEntities3();

        public ActionResult Index()
        {
            var emps = (from Employee in db.Employees select Employee).ToList();
            return View(emps);
        }

        public ActionResult Details(int id)
        {
            var det = (from Schedule in db.Schedules where Schedule.EmployeeId == id select Schedule).ToList();
            return View(det);
        }
        
    }
}