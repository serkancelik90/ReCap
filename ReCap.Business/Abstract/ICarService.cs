using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
    }
}
