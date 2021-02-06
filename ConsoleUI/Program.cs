using Business.Concrete;
using DataAccess.Concrete.EntiityFramework;
using DataAccess.Concrete.InMemory;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager= new CarManager(new EfCarDal());


            
            Car car = new Car { BrandID=4,DailyPrice=100,Description="new test",ModelYear=2021};

            

            List<Car> cars = carManager.GetAll(null);

            foreach (var item in cars)
            {
                Console.WriteLine(item.Description);
            }




        }
    }
}
