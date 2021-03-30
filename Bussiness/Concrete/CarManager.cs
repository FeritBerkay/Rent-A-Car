using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Bussiness.Constans.Messages;
using Core.CrossCuttingConcerns.Validation;
using Bussiness.ValidationRules.FluentValidation;
using Core.Aspects.AutoFac.Validation;
using Core.Utilities.Business;
using Core.Aspects.AutoFac.Caching;
using Business.BusinessAspects.Autofac;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            //ValidationTool.Validate(new CarValidator(), car);
            //Alt calısınca ustunde attiribute var mı varsa calıstır onu demek.

            IResult result = BusinessRules.Run(CheckIfCarNameExist(car.CarName));
            if (result != null)
            {
                return result;
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }
        [CacheAspect()]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==8)
            {
                return new ErrorDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsNotListed);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id), Messages.CarsListed);
        }
        [CacheAspect]
        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id), Messages.CarsListed);
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
             
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarsListed);
        }

        //public List<Car> GetByID(int categoryId)
        //{
        //    return _carDal.GetById();
        //}
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
           
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IDataResult<Car> GetById(int carId)
        {
              
            return new SuccessDataResult<Car>(_carDal.Get(p => p.CarId == carId));
        }
        private IResult CheckIfCarNameExist(string carName)
        {
            var result = _carDal.GetAll(c => c.CarName == carName);
            if (result.Any()==true)
            {
                return new ErrorResult(Messages.CarNameAlreadyExist);
            }
            return new SuccessResult();
        }
    }
}
