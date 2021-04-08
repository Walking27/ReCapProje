using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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

        [ValidationAspect(typeof(CarValidator))]
        [SecuredOperation("car.add.admin")]
        public IResult Add(Car car)
        {
            //business code
            
            _carDal.Add(car);
            return new SuccessResult("Araba Eklendi");
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }
        public IDataResult<List<CarDetailDTO>> GetAllByBrandId(int brandId) 
        {
            return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetails(p => p.BrandId == brandId), Messages.CarAdded);
        }

        public IDataResult<List<CarDetailDTO>> GetAll()
        {
            if (DateTime.Now.Hour == 2)
            {
                return new ErrorDataResult<List<CarDetailDTO>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetails(), Messages.CarsListed);
        }


        public IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(data: _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max));
        }

        public IDataResult<List<CarDetailDTO>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<CarDetailDTO>> GetCarDetailsById(int carId)
        {
            return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetails(c => c.CarId == carId));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }

        public IDataResult<Car> GetById(int Id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == Id), Messages.CarAdded);

        }

        public IDataResult<List<CarDetailDTO>> GetAllByColorId(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetails(p => p.ColorId == colorId), Messages.CarAdded);
        }
        public IDataResult<List<CarDetailDTO>> GetAllByBrandIdAndColorId(int brandId, int colorId)
        {
            return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetails(p =>p.BrandId == brandId && p.ColorId == colorId));
        }
    }
}
