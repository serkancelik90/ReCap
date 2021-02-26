using ReCap.DataAccess.Abstract;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal:EfEntityRepositoryBase<CarImage,RentACarContext>,ICarImageDal
    {
    }
}
