using ReCap.Business.Concrete;
using ReCap.DataAccess.Concrete.EntityFramework;
using ReCap.DataAccess.Concrete.InMemory;
using System;

namespace ReCap.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var list = carManager.GetCarDetails();
            foreach (var item in list)
            {
                Console.WriteLine(item.BrandName + " " + item.CarName);
            }

        }
    }
}
