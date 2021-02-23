using Business.Abstract;
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
            ICarService carService = new CarManager(new EfCarDal());
            var result = carService.GetAll();
            return result.Data;
        }
    }
}
