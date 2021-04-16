using BasicMVCWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace BasicMVCWebsite.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Search(string name)
        {
            string content = Server.HtmlEncode(name);
            return Content(content);
        }

        [HttpGet]
        public string Search()
        {
            return "Http Get Action verb in action";
        }

        public ActionResult Index()
        {
            var emp = empList.OrderBy(e => e.Age).Select(e => e);
            return View(emp);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                empList.Add(employee);
                return RedirectToAction("Index");
            }
            catch 
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            List<Employee> employeesList = GetAllEmployees();
            var employee = employeesList.Single(emp => emp.Id == id);
            return View(employee);
        }
        
        [HttpPost]
        public ActionResult Save(Employee empEdit)
        {
            try
            { 
                var employee = empList.Single(emp => emp.Id == empEdit.Id);
                if (TryUpdateModel(employee))
                {
                    return RedirectToAction("Index");
                }
                return View("Employee");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public static List<Employee> empList = new List<Employee>
            {
                new Employee{ Id = 1, Name = "John", JoiningDate = DateTime.Parse(DateTime.Now.ToString()), Age = 30},
                new Employee{ Id = 2, Name = "Jesse", JoiningDate = DateTime.Parse(DateTime.Now.ToString()), Age = 31},
                new Employee{ Id = 3, Name = "Mack", JoiningDate = DateTime.Parse(DateTime.Now.ToString()), Age = 29},
                new Employee{ Id = 4, Name = "King", JoiningDate = DateTime.Parse(DateTime.Now.ToString()), Age = 25}
            };

        [NonAction]
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee{ Id = 1, Name = "John", JoiningDate = DateTime.Parse(DateTime.Now.ToString()), Age = 30},
                new Employee{ Id = 2, Name = "Jesse", JoiningDate = DateTime.Parse(DateTime.Now.ToString()), Age = 31},
                new Employee{ Id = 3, Name = "Mack", JoiningDate = DateTime.Parse(DateTime.Now.ToString()), Age = 29},
                new Employee{ Id = 4, Name = "King", JoiningDate = DateTime.Parse(DateTime.Now.ToString()), Age = 25}
            };
        }
    }
}