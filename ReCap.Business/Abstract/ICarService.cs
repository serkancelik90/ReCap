using ReCap.Entities.Concrete;
using ReCap.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Delete(int id);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        void Add(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}
