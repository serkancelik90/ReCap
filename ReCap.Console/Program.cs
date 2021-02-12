using ReCap.Business.Concrete;
using ReCap.DataAccess.Concrete.EntityFramework;
using ReCap.DataAccess.Concrete.InMemory;
using ReCap.Entities.Concrete;
using System;

namespace ReCap.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine("Bilgilerinizi giriniz");
            
            Rental rental = new Rental
            {
                CarId = 1,
                CustomerId = 2,
                RentDate = DateTime.Now,
                //ReturnTime = DateTime.Now.AddDays(1)
            };

            var result = rentalManager.Rent(rental);
            Console.WriteLine(result.Message);
        }
    }
}
