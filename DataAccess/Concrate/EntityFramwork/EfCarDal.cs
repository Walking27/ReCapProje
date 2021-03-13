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
                var result = from p in context.Brands
                             join c in context.Cars
                             on p.Id equals c.BrandId
                             select new CarDetailDTO
                             {
                                 CarId = c.Id,
                                 BrandName =c.CarName,
                                 ColorName = c.ModelYear,
                                 CarName = c.Description
                             };
                return result.ToList();
        }   
        }
    }
}
