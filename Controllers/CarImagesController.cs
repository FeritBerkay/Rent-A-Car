using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _carImageService.GetById(id);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }

        [HttpPost("Add")]
        public IActionResult Add([FromForm (Name="Image")] IFormFile file, [FromForm] CarImage carImage)
        {
            //if (file==null)
            //{
            //    return BadRequest();
            //}
            var result = _carImageService.Add(file, carImage);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }

        [HttpPost("Delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }

        [HttpPost("Update")]
        public IActionResult Update(CarImage carImage)
        {
            var result = _carImageService.Update(carImage);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpGet("List")]
        public IActionResult List()
        {
            var result = _carImageService.GetAll();
            foreach (var carImage in result.Data)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }
    }
}
