using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private IColorSevice _colorSevice;

        public ColorsController(IColorSevice colorSevice)
        {
            _colorSevice = colorSevice;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _colorSevice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }

}

