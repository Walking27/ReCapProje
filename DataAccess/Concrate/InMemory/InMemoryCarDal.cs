using Core.DataAccess;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carDals;


        public InMemoryCarDal()
        {
            _carDals = new List<Car>
            {
                new Car{BrandId=11,Id=22,ColorId=2,DailyPrice=150,Description="Sahibinden satlık 0 ayarında",ModelYear="2018"},
            new Car{BrandId=12,Id=20,ColorId=4,DailyPrice=100,Description="Sahibinden satlık 0 ayarında",ModelYear="2018"},
            new Car{BrandId=13,Id=30,ColorId=5,DailyPrice=120,Description="Sahibinden satlık 0 ayarında",ModelYear="2018"},
            new Car{BrandId=14,Id=40,ColorId=6,DailyPrice=180,Description="Sahibinden satlık 0 ayarında",ModelYear="2018"},
            new Car{BrandId=15,Id=50,ColorId=7,DailyPrice=99,Description="Sahibinden satlık 0 ayarında",ModelYear="2018"},
            new Car{BrandId=16,Id=60,ColorId=8,DailyPrice=100,Description="Sahibinden satlık 0 ayarında",ModelYear="2018"},
            new Car{BrandId=17,Id=70,ColorId=3,DailyPrice=168,Description="Sahibinden satlık 0 ayarında",ModelYear="2018"},
            new Car{BrandId=18,Id=80,ColorId=9,DailyPrice=125,Description="Sahibinden satlık 0 ayarında",ModelYear="2018"},
            new Car{BrandId=19,Id=90,ColorId=10,DailyPrice=150,Description="Sahibinden satlık 0 ayarında",ModelYear="2018"},
            new Car{BrandId=21,Id=100,ColorId=11,DailyPrice=128,Description="Sahibinden satlık 0 ayarında",ModelYear="2018"}
            };
        }

        public void Add(Car car)
        {
            _carDals.Add(car);
        }

        public void Delete(Car carId)
        {
            Car deletedToCar = _carDals.SingleOrDefault(c => c == carId);

            _carDals.Remove(deletedToCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDals;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _carDals;
        }

        public Car GetById(int Id)
        {
            return _carDals.SingleOrDefault(p => p.Id == Id);
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDTO> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updatedToCar = _carDals.SingleOrDefault(c => c == car);
            updatedToCar.Id = car.Id;
            updatedToCar.BrandId = car.BrandId;
            updatedToCar.ColorId = car.ColorId;
            updatedToCar.ModelYear = car.ModelYear;
            updatedToCar.DailyPrice = car.DailyPrice;
            updatedToCar.Description = car.Description;
        }

        void IEntityRepository<Car>.Add(Car entity)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Car>.Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        List<Car> IEntityRepository<Car>.GetAll(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        List<CarDetailDTO> ICarDal.GetCarDetails(Expression<Func<CarDetailDTO, bool>> filter)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Car>.Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
