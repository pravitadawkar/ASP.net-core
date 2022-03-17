using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDOprationRepo.Firstmodels;
using CRUDOprationRepo.DataBase;

namespace CRUDOprationRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : Controller
    {
        CarService _record;
        public CarsController(CarService record)
        {
            _record = record;
        }
        //get all car orderby carname..
        [HttpGet]
        [Route("GetallCar")]
        public IActionResult GetallCar()
        {
            var car = _record.Getcarbyname();
            return Ok(car);
        }
        //[HttpGet]
        //[Route("AddCar")]
        //public IActionResult AddCar()
        //{
        //    //var car = _record.GetCar(no);
        //    return View();
        //}

        //insert car in current list
        [HttpPost]
        [Route("AddCar")]
        public IActionResult AddCar(Car car)
        {
            _record.AddCar(car);
            return Ok();
          
        }
        //get list for updation
        [HttpGet]
        [Route("Updatecar")]
        public IActionResult Updatecar()
        {
            return Ok();
        }
       //update record in list
        [HttpPut]
        [Route("Updatecar")]

        public IActionResult Updatecar(Car car)
        {
            _record.UpdateCar(car);
            return Ok();
        }
        //get record for delete
        [HttpGet]
        [Route("Deletecar")]
        public IActionResult Deletecar(int no)
        {
            var car = _record.GetCar(no);
            return Ok(car);
        }
        //delete record 
        [HttpDelete]
        [Route("Deletecar")]
        public IActionResult Deletecar(Car car)
        {
            _record.DeleteCar(car);
            return Ok();
        }
        //get record group by carname and carmodael..
        [HttpGet]
        [Route("GetGroupby")]
        public IActionResult GetGroupby()
        {
            _record.GetGroupby();
            return Ok();
        }
    }

}
