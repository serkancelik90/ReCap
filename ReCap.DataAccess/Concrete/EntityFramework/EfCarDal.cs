using ReCap.DataAccess.Abstract;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReCap.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EntityRepository<Car>, ICarDal
    {
      
    }
}
