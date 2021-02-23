using Business.Concrate;
using DataAccess.Concrate.EntityFramwork;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var Car in result.Data)
            {
                    Console.WriteLine(Car.BrandId + "/" + Car.DailyPrice);
                }
            }
            else 
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}

