using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

       

        //this is get method use to return string
        [HttpGet]
        [Route("MyFirstAPI")]
        public string MyFirstAPI()
        {
            return "This is my first get API";
        }

        //this is post method use to add name and id
        [HttpPost]
        [Route("AddName")]

        public ActionResult<user> AddName(string Name,int id)
        {
            user user = new user();
            user.name = Name;
            user.id = id;
            return Ok(user);
        }

        //this is post method use re string
        [HttpPost]
        [Route("say_hello")]
        public string say_hello( string value)
        {
            return "Hello this is my first post method!";
        }

        //this is put method use to uptate value with id
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return "Hello this is my first put request!";
        }

        //this is use to delete data of specific id
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Hello i delete this!";
        }
    }
    public class user
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
