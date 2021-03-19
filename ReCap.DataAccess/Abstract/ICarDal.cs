using Core.DataAccess;
using ReCap.Entities.Concrete;
using ReCap.Entities.DTOs;
using System.Collections.Generic;

namespace ReCap.DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarsDetails();
        List<CarDetailDto> GetCarsDetailsByColor(int colorId);
        List<CarDetailDto> GetCarsDetailsByBrand(int brandId);
        CarDetailDto GetCarDetails(int carId);
    }
}
