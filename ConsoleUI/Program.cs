using Business.Concrate;
using DataAccess.Concrate.EntityFramwork;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;


namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            

            //if (result.Success == true)
            //{
            //    foreach (var Car in result.Data)
            //{
            //        Console.WriteLine(Car.CarId + "/" + Car.BrandName);
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine(result.Message);
            //}
            //Console.ReadKey();
            
        }
    }
}

