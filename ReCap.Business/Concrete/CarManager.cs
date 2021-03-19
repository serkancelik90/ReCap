using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttinConcerns.Validation;
using Core.Utilities.Results;
using FluentValidation;
using ReCap.Business.Abstract;
using ReCap.Business.BusinessAspects.Autofac;
using ReCap.Business.Constants;
using ReCap.Business.ValidationRules.FluentValidation;
using ReCap.DataAccess.Abstract;
using ReCap.Entities.Concrete;
using ReCap.Entities.DTOs;
using System;
using System.Collections.Generic;

namespace ReCap.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            //ValidationTool.Validate(new CarValidator(), car);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult AddTransactionalTest(Car car)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            var deletedCar = _carDal.Get(x => x.CarId == id);
            _carDal.Delete(deletedCar);

            return new SuccessResult(Messages.CarDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            try
            {
                var cars = _carDal.GetAll();
                return new SuccessDataResult<List<Car>>(cars, Messages.CarsListed);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Car>>(ex.Message);
            }

        }

        [CacheAspect]
        public IDataResult<List<CarDetailDto>> GetCarsDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetails(), Messages.CarsListed);
        }
        [CacheAspect]
        public IDataResult<CarDetailDto> GetCarDetails(int carId)
        {
            return new SuccessDataResult<CarDetailDto>(_carDal.GetCarDetails(carId), Messages.CarsListed);
        }


        [CacheAspect]
        public IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarsDetailsByBrand(brandId),Messages.CarsListed);
        }

        [CacheAspect]
        public IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarsDetailsByColor(colorId),Messages.CarsListed);
        }
    }
}
