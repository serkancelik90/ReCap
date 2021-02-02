using ReCap.Entities.Abstract;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.DataAccess.Abstract
{
   public interface ICarDal
    {
        Car GetById(int id);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(int id);
    }
}
