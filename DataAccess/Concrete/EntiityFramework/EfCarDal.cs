using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntiityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,CarRentalContext>,ICarDal
    {
        public List<Car> GetCarsByBrandId(int id)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Car>().Where(x => x.BrandID == id).ToList();
            }
        }

        public List<Car> GetCarsByColorId(int id)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Car>().Where(x => x.ColorId == id).ToList();
            }
        }

        public List<CarDetailsDTO> ListAll()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandID equals b.ID
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailsDTO { CarName = c.CarName, BrandName = b.BrandName, ColorName = co.ColorName, DailyPrice = c.DailyPrice };
                // select new 
                return result.ToList();
            }
        }
    }
}
