using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class StudentController : Controller
    {
        //public IActionResult Index()
       // {
           // return View();
        //}
        [HttpGet]
        public ActionResult GetAllStudents()
        {
            DemoTestRepository repository = new DemoTestRepository();
            List<Student> studetails = repository.GetAllStudents();
            return Ok(studetails);

        }
        [HttpGet]

        public ActionResult GetStuById(int StudentId)
        {
            DemoTestRepository repository = new DemoTestRepository();
            Student studetails = repository.GetStuById(StudentId);
            return Ok(studetails);

        }
    }
}
