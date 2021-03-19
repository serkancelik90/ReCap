using ReCap.DataAccess.Abstract;
using ReCap.Entities.Concrete;
using ReCap.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReCap.DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.CarId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cs in context.Customers on r.CustomerId equals cs.CustomerId
                             select new RentalDetailDto
                             {
                                 BrandName = b.BrandName,
                                 Name = cs.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}
