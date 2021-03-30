using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result=_categoryService.GetAll();
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpPost("Add")]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Category category)
        {
            var result = _categoryService.Delete(category);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpPost("Update")]
        public IActionResult Update(Category category)
        {
            var result = _categoryService.Update(category);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
    }
}
