using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentRepo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using StudentRepo.StudentData;

namespace StudentRepo.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentService _stdservice;
       public  HomeController(StudentService stdservice)
        {
            _stdservice = stdservice;
        }
        //get all list of student
        [HttpGet]
        public IActionResult Index()
        {
            var students = _stdservice.GetStudents();
            return View(students);
        }
        //edit student list
        [HttpGet]
        public IActionResult Editstd( int id)
        {
            var student = _stdservice.GetStudent(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Editstd(Student student)
        {
            _stdservice.Update(student);
            return View();
        }
        //add student in list
        [HttpGet]
        public IActionResult Addstd()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Addstd(Student student)
        {
            _stdservice.Insert(student);
            return View();
        }
        //see details of student
        [HttpGet]
        public IActionResult Detailstd()
        {
           var std= _stdservice.GetStudents();
            return View(std);
        }
        //delete student fron list
        [HttpGet]
        public IActionResult Deletestd(int id)
        {
            _stdservice.GetStudent(id);
            return View();
        }
        [HttpPost]
        public IActionResult Deletestd(Student student)
        {
            _stdservice.Delete(student);
            return View();
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        // return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
