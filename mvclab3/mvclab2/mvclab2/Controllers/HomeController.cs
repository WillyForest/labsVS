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

        [HttpGet]
        public ActionResult Create()
        {
            Employee emp = new Employee();
            return View(emp);
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    do
                    {
                        try
                        {
                            db.Employees.Add(emp);
                            db.SaveChanges();
                            return RedirectToAction("Index");
                        }
                        catch
                        {
                            emp.EmployeeID++;
                        }
                    } while (true);
                    //emp.EmployeeID++;
                    //db.Employees.Add(emp);
                    //db.SaveChanges();
                    //return RedirectToAction("Index");
                }
            } catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex);
            }
            return View(emp);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var empEdit = (from emp in db.Employees where emp.EmployeeID == id select emp).First();
            return View(empEdit);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var empEdit = (from emp in db.Employees where emp.EmployeeID == id select emp).First();

            try
            {
                UpdateModel(empEdit);
                db.SaveChanges();
                return RedirectToAction("Index");
            } catch
            {
                return View(empEdit);
            }
            
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var empDelete = (from emp in db.Employees where emp.EmployeeID == id select emp).First();
            return View(empDelete);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var empDelete = (from emp in db.Employees where emp.EmployeeID == id select emp).First();
            try
            {
                db.Employees.Remove(empDelete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(empDelete);
            }

        }

        public ActionResult Details(int id)
        {
            var det = (from Schedule in db.Schedules where Schedule.EmployeeId == id select Schedule).ToList();
            return View(det);
        }
        
    }
}