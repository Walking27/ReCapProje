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
        public List<CarDetailDTO> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             select new CarDetailDTO
                             {
                                 ColorName=co.ColorName,
                                 CarId=c.Id,
                                 BrandName=b.BrandName,
                                 DailyPrice=c.DailyPrice,
                                 Description=c.Description,
                                 ModelYear=c.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
