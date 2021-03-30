using Bussiness.Abstract;
using Bussiness.Constans.Messages;
using Bussiness.ValidationRules.FluentValidation;
using Core.Aspects.AutoFac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Bussiness.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        //[ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, CarImage carImage)
        {
            //Bir arabanın en fazla 5 resmi olabilmesi icin.
            IResult result = BusinessRules.Run(CheckImageCount(carImage.CarID));
            if (result!=null)
            {
                return result;
            }
            //Eklenme tarihinin suanki tarih olması icin.
            carImage.Date = DateTime.Now;
            carImage.ImagePath = FileHelper.Add(file);
            _carImageDal.Add(carImage); 
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(),Messages.CarImagesListed);
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id));
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }
        private IResult CheckImageCount(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarID == carId);
            if (result.Count>5)
            {
                return new ErrorResult(Messages.CarImageNumberInvalid);
            }
            return new SuccessResult();
        }
    }
}
