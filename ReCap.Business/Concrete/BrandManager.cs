using Core.Utilities.Results;
using ReCap.Business.Abstract;
using ReCap.Business.Constants;
using ReCap.DataAccess.Abstract;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
           return new SuccessResult();
        }

        public IResult Delete(int brandId)
        {
            var deletedBrand = _brandDal.Get(x => x.BrandId == brandId);
            _brandDal.Delete(deletedBrand);
            return new SuccessResult();

        }

        public IDataResult<Brand> Get(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(x => x.BrandId == brandId));
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }
    }
}
