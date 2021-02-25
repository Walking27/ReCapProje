using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public Result Add(Car car)
        {
            //business code

            ValidationTool.Validate(new CarValidator(), car);

            _carDal.Add(car);

            return new Result(true, "Araba Eklendi");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }
        public IDataResult<List<Car>> GetById(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarAdded);
        }

        public SuccessDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(data: _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max));
        }

        public IDataResult<List<CarDetailDTO>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetails());
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        IResult ICarService.Add(Car car)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> ICarService.GetByUnitPrice(decimal min, decimal max)
        {
            return (IDataResult<List<Car>>)_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

       
        
    }
}
