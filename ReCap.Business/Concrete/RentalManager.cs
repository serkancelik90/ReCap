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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Rent(Rental rental)
        {
            var existRental = _rentalDal.Get(r =>r.CarId == rental.CarId && r.ReturnDate == null);
            if (existRental != null)
            {
                return new ErrorResult(Messages.CarInUse);
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarRentable);
            
        }
    }
}
