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


            carManager.GetAll(null);




        }
    }
}
