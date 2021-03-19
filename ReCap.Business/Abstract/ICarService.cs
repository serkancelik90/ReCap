using Core.Utilities.Results;
using ReCap.Entities.Concrete;
using ReCap.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult Delete(int id);
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId);
        IResult Add(Car car);
        IDataResult<List<CarDetailDto>> GetCarsDetails();
        IDataResult<CarDetailDto> GetCarDetails(int carId);
        IResult AddTransactionalTest(Car car);
        
    }
}
