using ReCap.DataAccess.Abstract;
using ReCap.Entities.Abstract;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReCap.DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal //:ICarDal
    {
        //List<Car> _cars;
        //    public InMemoryCarDal()
        //{
        //    _cars = new List<Car> {
        //        new Car { CarId = 1, ModelYear = 2020, BrandId = 1, ColorId = 1, DailyPrice = 300, Decription = "Şahsi" },
        //        new Car { CarId = 2, ModelYear = 2019, BrandId = 2, ColorId = 2, DailyPrice = 250, Decription = "Şahsi" },
        //        new Car { CarId = 3, ModelYear = 2017, BrandId = 3, ColorId = 3, DailyPrice = 230, Decription = "Şirket" },
        //        new Car { CarId = 4, ModelYear = 2018, BrandId = 2, ColorId = 2, DailyPrice = 240, Decription = "Tur" },
        //        new Car { CarId = 5, ModelYear = 2015, BrandId = 1, ColorId = 3, DailyPrice = 200, Decription = "Şirket" }


        //    };
            

        //}
        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(int id)
        //{
        //    var sec = GetById(id);
        //    _cars.Remove(sec);
        //}

        //public List<Car> GetAll()
        //{
        //    return _cars.ToList();
        //}

        //public Car GetById(int id)
        //{
        //    return _cars.Where(c => c.CarId == id).FirstOrDefault();
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = GetById(car.CarId);
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.Decription = car.Decription;
        //    carToUpdate.ModelYear = car.ModelYear;

        //}
    }
}
