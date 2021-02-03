using Business.Concrete;
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
            CarManager carManager= new CarManager(new InMemoryCarDal());

            List<Car> cars = carManager.GetAll();

            foreach (var item in cars)
            {
                Console.WriteLine(item.Description);
            }

            Car car = new Car { ID=6,BrandID=4,DailyPrice=100,Description="new test",ModelYear=2021};

            carManager.Add(car);

            Console.WriteLine("----------------------------------------------------------------------------------");

            cars = carManager.GetAll();
            foreach (var item in cars)
            {
                Console.WriteLine(item.Description);
            }

            carManager.Delete(cars.SingleOrDefault(x=>x.ID==1));

            Console.WriteLine("----------------------------------------------------------------------------------");

            cars = carManager.GetAll();
            foreach (var item in cars)
            {
                Console.WriteLine(item.Description);
            }


        }
    }
}
