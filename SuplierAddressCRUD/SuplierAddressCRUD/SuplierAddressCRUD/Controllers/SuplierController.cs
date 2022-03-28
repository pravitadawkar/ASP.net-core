using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuplierAddressCRUD.suplierModel;
using SuplierAddressCRUD.View_Models;
using System;

namespace SuplierAddressCRUD.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SuplierController : ControllerBase
    {
        Isuplier _data;
        public SuplierController(Isuplier data)
        {
            _data = data;
        }
        [HttpGet]
        [Route("GetSuppliers")]
        public IActionResult GetSuppliers()
        {
            var result = _data.GetAllSuplier();
            return Ok(result);
        }
        [HttpGet]
        [Route("GetSupplier")]
        public IActionResult GetSupplier(int id)
        {
            var result = _data.GetSupplier(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddSupplier")]
        public IActionResult AddSupplier(SupplierDTO dto)
        {

            _data.Insert(dto);
            return Ok();
        }

        [HttpPost]
        [Route("UpdateSupplier")]
        public IActionResult UpdateSupplier(SupplierDTO dto)
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
        [Route("DeleteSupplier")]
        public IActionResult DeleteSupplier(int SupplierId)
        {
            _data.Delete(SupplierId);
            return Ok();
        }
    }
}
