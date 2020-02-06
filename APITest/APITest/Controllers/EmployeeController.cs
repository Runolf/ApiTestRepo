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
        private IList<Employee> Employees = new List<Employee>()
        {
            new Employee(){ID = 1, Firstname="Jhon", Lastname="Doe"},
            new Employee(){ID = 2, Firstname="Runolf", Lastname="Erlingson"},
            new Employee(){ID = 3, Firstname="Asbjorn", Lastname="Erlingson"},
            new Employee(){ID = 4, Firstname="Jan", Lastname="Wickiewicz"},
            new Employee(){ID = 5, Firstname="Ingird", Lastname="Durant"}
        };

        public IEnumerable<Employee> Get()
        {
            return Employees; 
        }

       
        public Employee Get(int Id)
        {
            return Employees.Where(e => e.ID == Id).FirstOrDefault();
        }

        
        public void Post(Employee employee)
        {
            int maxId = Employees.Max(e => e.ID);
            employee.ID = maxId + 1;
            Employees.Add(employee);
        }

        public void Put(int id, Employee employee)
        {
            int index = Employees.ToList().FindIndex(e => e.ID == id);
            Employees[index] = employee;
        }

        public void Delete(int id)
        {
            Employee emp = Get(id);
            Employees.Remove(emp);

        }
    }
}
