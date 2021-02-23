using Core.Entities;
using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDTO>> GetCarDetails();
        IResult Add(Car car); 
    }
}
