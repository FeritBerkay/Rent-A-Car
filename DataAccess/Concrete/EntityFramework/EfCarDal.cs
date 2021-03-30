using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,RentCarContext> ,ICarDal
    {
       public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext context= new RentCarContext())
            {
                var result = from car in context.Cars
                             join col in context.Colors 
                             on car.ColorId equals col.ColorId
                             join cat in context.Categories
                             on car.CategoryId equals cat.CategoryId
                             join b in context.Brands
                             on car.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarName = car.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = col.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 CategoryName= cat.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
