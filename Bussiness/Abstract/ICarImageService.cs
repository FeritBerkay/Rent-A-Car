using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImage carImage);
        IDataResult<List<CarImage>> GetAll();

        IDataResult<CarImage> GetById(int id);

        IResult Update(CarImage carImage);

        IResult Delete(CarImage carImage);
    }
}
