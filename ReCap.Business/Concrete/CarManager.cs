using Core.Aspects.Autofac.Validation;
using Core.CrossCuttinConcerns.Validation;
using Core.Utilities.Results;
using FluentValidation;
using ReCap.Business.Abstract;
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

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            //ValidationTool.Validate(new CarValidator(), car);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(int id)
        {
            var deletedCar = _carDal.Get(x => x.CarId == id);
            _carDal.Delete(deletedCar);

            return new SuccessResult(Messages.CarDeleted);
        }

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

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(x => x.BrandId == brandId),Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(x => x.ColorId == colorId),Messages.CarsListed);
        }
    }
}
