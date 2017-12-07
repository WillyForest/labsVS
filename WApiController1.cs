using mvclab4v2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        
    }
}