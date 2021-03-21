using Core.Utilities.Results;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetById(int carImageId);
        IResult Add(CarImage carImage);
        IResult Update(CarImage carImage);
        IResult Delete(int carImage);
    }
}

