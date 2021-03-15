using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrate.EntityFramwork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDTO> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext()) 
            {
                var result = from car in filter == null ? context.Cars : context.Cars.Where(filter)
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             select new CarDetailDTO
                             {
                                 CarId = car.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 Description = car.Description,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear
                                 
                             };
                return result.ToList();
        }   
        }
    }
}
