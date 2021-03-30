using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryCarDal : ICarDal
    //{
    //    List<Car> _cars;
    //    public InMemoryCarDal()
    //    {
    //        _cars = new List<Car>
    //        {
    //            new Car{CarId=1, BrandId=2, CategoryId=1, ColorId=5, DailyPrice=2000, Desciription="Tofas Model 2", ModelYear=1998 },
    //            new Car{CarId=2, BrandId=1, CategoryId=3, ColorId=9, DailyPrice=10000, Desciription="Tesla Model 3", ModelYear=2020},
    //            new Car{CarId=3, BrandId=2, CategoryId=2, ColorId=7, DailyPrice=30000, Desciription="Tesla Model X", ModelYear=2020 },
    //        };
    //    }

    //    public void Add(Car car)
    //    {
    //        _cars.Add(car);
    //    }
    //    public List<Car> Any(string desciription)
    //    {
    //        return _cars.Where(p => p.Desciription == desciription).ToList();
    //    }

    //    public void Delete(Car car)
    //    {
    //        Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);

    //        _cars.Remove(carToDelete);
    //    }

    //    public List<Car> GetAll()
    //    {
    //        return _cars;
    //    }
    //    public void Update(Car car)
    //    {
    //        Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
    //        carToUpdate.CarId = car.CarId;
    //        carToUpdate.BrandId = car.BrandId;
    //        carToUpdate.CategoryId = car.CategoryId;
    //        carToUpdate.ColorId = car.ColorId;
    //        carToUpdate.DailyPrice = car.DailyPrice;
    //        carToUpdate.Desciription = car.Desciription;
    //        carToUpdate.ModelYear = car.ModelYear;
    //    }

    //    public List<Car> GetById(int categoryId)
    //    {
    //        return _cars.Where(p => p.CategoryId == categoryId).ToList();
    //    }

    //    public List<Car> Find(int carId)
    //    {
    //        return _cars.Where(p => p.CarId == carId).ToList();
    //    }

    //    public List<Car> FindAll(string word)
    //    {
    //        //Contains icermek demek Teslayı ıcerenleri bul ve dailypricesi azalana gore sırala dedik.
    //        return _cars.Where(p => p.Desciription.Contains(word)).OrderByDescending(p => p.DailyPrice).ToList();
    //    }
    //}
}
