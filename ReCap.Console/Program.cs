using ReCap.Business.Concrete;
using ReCap.DataAccess.Concrete.InMemory;
using System;

namespace ReCap.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            var list = carManager.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine(item.CarId);
            }

        }
    }
}
