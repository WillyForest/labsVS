using mvclab4v2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace mvclab4v2.Controllers
{
    public class EmployeePerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PersonPredmets
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class WApiController : ApiController
    {
        private Laba2DBEntities db = new Laba2DBEntities();
        // GET api/<controller>
        [HttpGet]
        [ActionName("GetEmp")]
        public IEnumerable<EmployeePerson> GetEmp()
        {
            var emps = (from employee in db.Employees select employee).ToList();

            Collection<EmployeePerson> EP = new Collection<EmployeePerson>();

            foreach (Employee e in emps)
            {
                EP.Add(new EmployeePerson { Id = e.EmployeeID, Name = e.Name });
            }
            return EP;
        }

        [HttpGet]
        [ActionName("GetPredm")]
        public IEnumerable<PersonPredmets> GetPredm(int id)
        {
            var emps = (from Schedule in db.Schedules where Schedule.EmployeeId == id select Schedule.Predmet).ToList();

            Collection<PersonPredmets> SP = new Collection<PersonPredmets>();

            foreach (Predmet e in emps)
            {
                SP.Add(new PersonPredmets { Id = e.PredmetID, Name = e.Name });// { Id = e.PredmetID, Name = (e.EmployeeId + "") });
            }
            return SP;
        }

        [HttpPost]
        [ActionName("CreateEmp")]
        public HttpResponseMessage CreateEmp(Employee emp)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);

            try
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                response.Content = new StringContent("{Id:" + emp.EmployeeID + ",Name:" + emp.Name +
                    ",Position:" + emp.Position + "}", Encoding.UTF8, "application/json");
            } catch (Exception ex)
            {
                response.Content = new StringContent("{Error:" + ex.Message + "}", Encoding.UTF8,
                    "application/json");
            }
            return response;
        }

        [HttpPost]
        [ActionName("UpdateEmp")]
        public HttpResponseMessage UpdateEmp(Employee sEmp)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            var emp = (from o in db.Employees where o.EmployeeID == sEmp.EmployeeID select o).First();

            try
            {
                db.Employees.Remove(emp);
                db.Employees.Add(sEmp);
                db.SaveChanges();
                response.Content = new StringContent("{Id:" + sEmp.EmployeeID + ",Name:" + sEmp.Name +
                    ",Position:" + sEmp.Position + "}", Encoding.UTF8, "application/json");
            }
            catch (Exception ex)
            {
                response.Content = new StringContent("{Error:" + ex.Message + "}", Encoding.UTF8,
                    "application/json");
            }
            return response;
        }

        [HttpPost]
        [ActionName("DeleteEmp")]
        public HttpResponseMessage DeleteEmp(Employee sEmp)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            var emp = (from o in db.Employees where o.EmployeeID == sEmp.EmployeeID select o).First();

            try
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
                response.Content = new StringContent("{Id:" + emp.EmployeeID + ",Name:" + emp.Name +
                    ",Position:" + emp.Position + "}", Encoding.UTF8, "application/json");
            }
            catch (Exception ex)
            {
                response.Content = new StringContent("{Error:" + ex.Message + "}", Encoding.UTF8,
                    "application/json");
            }
            return response;
        }

    }
}