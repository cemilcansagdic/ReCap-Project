using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        public List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars= new List<Car> 
            {
                new Car { ID = 1, BrandID = 1, DailyPrice = 20, Description = "Test1", ModelYear = 2000 },
                new Car { ID = 2, BrandID = 1, DailyPrice = 25, Description = "Test2", ModelYear = 2002 },
                new Car { ID = 3, BrandID = 2, DailyPrice = 22, Description = "Test3", ModelYear = 2010 },
                new Car { ID = 4, BrandID = 2, DailyPrice = 35, Description = "Test4", ModelYear = 2020 },
                new Car { ID = 5, BrandID = 3, DailyPrice = 50, Description = "Test5", ModelYear = 2015 }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car toDelete = _cars.SingleOrDefault(x => x.ID==car.ID);
            _cars.Remove(toDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(x => x.ID == id);
        }

        public void Update(Car car)
        {
            Car toUpdate = _cars.SingleOrDefault(x => x.ID == car.ID);
            toUpdate.BrandID = car.BrandID;
            toUpdate.DailyPrice = car.DailyPrice;
            toUpdate.Description = car.Description;
            toUpdate.ModelYear = car.ModelYear;
        }
    }
}
