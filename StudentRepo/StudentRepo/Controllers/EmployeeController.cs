using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentRepo.EmployeeData;

namespace StudentRepo.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeService _emprepo;
       public EmployeeController(EmployeeService emprepo)
        {
            _emprepo = emprepo;
        }
        //public IActionResult Index()
        //{
        //    var employee = _emprepo.GetEmployees();
        //    return View(employee);
        //}
        public IActionResult Index()
        {
            var employee = _emprepo.GetEmployees();
            return View(employee);
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
             _emprepo.AddEmployee(employee);
            return View();
        }
        [HttpGet]
        public IActionResult ChangeEmployee(int id)
        {
            var employee = _emprepo.GetEmployee(id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult ChangeEmployee(Employee employee)
        {
            _emprepo.UpdateEmployee(employee);
            return View();
        }
        [HttpGet]
        public IActionResult DeleteEmployee(int id)
        {
            var emp = _emprepo.GetEmployee(id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult DeleteEmployee(Employee employee)
        {
            _emprepo.DeleteEmployee(employee);
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var employee = _emprepo.GetEmployee(id);
            return View(employee);
        }
    }
}
