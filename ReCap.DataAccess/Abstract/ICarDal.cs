using Core.DataAccess;
using ReCap.Entities.Concrete;
using ReCap.Entities.DTOs;
using System.Collections.Generic;

namespace ReCap.DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
