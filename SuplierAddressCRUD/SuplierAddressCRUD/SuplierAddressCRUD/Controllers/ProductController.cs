using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuplierAddressCRUD.suplierModel;


namespace SuplierAddressCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProduct _data;
        public ProductController(IProduct data)
        {
            _data = data;
        }
        [HttpGet]
        [Route("GetAllProducts")]
        public IActionResult GetAllProducts(int supplierid)
        {
            var result = _data.GetAllProducts(supplierid);
            return Ok(result);
        }
        [HttpGet]
        [Route("GetAllProduct")]
        public IActionResult GetProduct(int id)
        {
            var result = _data.GetProduct(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Products dto)
        {

            _data.Insert(dto);
            return Ok();
        }

        [HttpPost]
        [Route("UpdateProduct")]
        public IActionResult UpdateProduct(Products dto)
        {
            try
            {
                _data.Update(dto);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();

            }
        }

        [HttpPost]
        [Route("DeleteProduct")]
        public IActionResult DeleteProduct(int Id)
        {
            _data.Delete(Id);
            return Ok();
        }
    }
}
