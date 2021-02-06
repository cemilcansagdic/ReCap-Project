using System;
using System.Collections.Generic;
using System.Text;
using Entities;


namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsByBrandId(int id);

    }
}
