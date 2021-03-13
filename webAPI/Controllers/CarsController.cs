﻿using Business.Abstract;
using Business.Concrate;
using DataAccess.Concrate.EntityFramwork;
using Entities.Concrate;
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
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public List<Car> Get() 
        {
            var result = _carService.GetAll();
            return result.Data;
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {

            var result = _carService.Add(car);
            return Ok(result);
        }
    }
}
