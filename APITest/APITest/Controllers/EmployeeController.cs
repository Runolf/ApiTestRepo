using APITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APITest.Controllers
{
    public class EmployeeController : ApiController
    {
        private IList<Employee> List = new List<Employee>()
        {
            new Employee(){ID = 1, Firstname="Jhon", Lastname="Doe"},
            new Employee(){ID = 2, Firstname="Runolf", Lastname="Erlingson"},
            new Employee(){ID = 3, Firstname="Asbjorn", Lastname="Erlingson"},
            new Employee(){ID = 4, Firstname="Jan", Lastname="Wickiewicz"},
            new Employee(){ID = 5, Firstname="Ingird", Lastname="Durant"}
        };

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return List; 
        }

        [HttpGet]
        public Employee Get(int Id)
        {
            return List.Where(e => e.ID == Id).FirstOrDefault();
        }

        [HttpPost]
        public void Post(Employee employee)
        {
            int maxId = List.Max(e => e.ID);
            employee.ID = maxId + 1;
            List.Add(employee);
        }

        public void Put(int id, Employee employee)
        {
            int index = List.ToList().FindIndex(e => e.ID == id);
            List[index] = employee;
        }

        public void Delete(int id)
        {
            Employee emp = Get(id);
            List.Remove(emp);

        }
    }
}
