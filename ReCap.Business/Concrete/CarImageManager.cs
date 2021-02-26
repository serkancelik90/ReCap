using Core.Utilities.Business;
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
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(CarImage carImage)
        {
            var result = BusinessRules.Run(CheckCarImageCount(carImage.CarId));
            if (result == null)
            {
                carImage.Date = DateTime.Now;
                _carImageDal.Add(carImage);
                return new SuccessResult(Messages.CarImageAdded);
            }

            return new ErrorResult(result.Message);
        }

        public IResult Delete(int id)
        {
            var result = _carImageDal.Get(c => c.Id == id);
            _carImageDal.Delete(result);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }
        private IResult CheckCarImageCount(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.CarImageMaximum);
            }
            return new SuccessResult();
        }
    }
}
