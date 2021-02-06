using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        Car Get(Expression<Func<Car, bool>> filter);
        List<Car> GetAll(Expression<Func<Car, bool>> filter);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsByBrandId(int id);
    }
}
