using Core.Utilities.Results;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Delete(int brandId);
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> Get(int brandId);

    }
}
