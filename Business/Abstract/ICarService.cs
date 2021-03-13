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
        IDataResult<List<Car>> GetById(Car car);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(int car);
        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);
    }
}
