using System.Collections.Generic;
using System.Linq;
using c_sharp_emp_app.EmpDataContext;
using c_sharp_emp_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace c_sharp_emp_app.Controllers
{
    /** 
    invoke by http://localhost:5000/api/employee
    */
    [Route("api/[controller]")]
    public class EmployeeController : Controller {
        private readonly AppDataContext context;
        public EmployeeController(AppDataContext context) {
             this.context = context;

             if(context.Employees.Count() == 0) {
                 context.Employees.Add(new Employee {Name="John", Age=25});
                 context.Employees.Add(new Employee {Name="Bill", Age=23});
                 context.Employees.Add(new Employee {Name="Steve", Age=44});
                 context.Employees.Add(new Employee {Name="Will", Age=50});
                 context.SaveChanges();
             }
        }

        [HttpGet]
        public List<Employee> GetAll() {
           return context.Employees.ToList();
        }
        
        [HttpGet("{id}", Name = "GetTodo")]
        public Employee getById(int id) {
            var item = context.Employees.Find(id);
            return item;
        }


    }
}