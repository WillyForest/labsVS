using mvclab4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvclab4.Controllers
{
   
    public class EmployeePerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PersonPredmets
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
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
            var emps = (from Schedule in db.Schedules where Schedule.EmployeeId == id select Schedule.PredmetID).ToList();

            Collection<EmployeePerson> SP = new Collection<EmployeePerson>();

            foreach (Schedule e in emps)
            {
                SP.Add(new PersonPredmets { Id = e.PredmetID, EmpId = e.EmployeeId });// { Id = e.PredmetID, Name = (e.EmployeeId + "") });
            }
            return SP;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}