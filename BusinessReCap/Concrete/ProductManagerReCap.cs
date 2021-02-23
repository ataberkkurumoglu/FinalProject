using Business.Constans;
using BusinessReCap.Abstract;
using BusinessReCap.ValidationRules.FluentValidation;
using CoreRecap.CrossCuttingConcerns.Validation;
using CoreReCap.UtilitiesReCap.ResultsReCap;
using DataAccessReCap.Abstract;
using EntitiesReCap.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessReCap.Concrete
{
    public class ProductManagerReCap:ICarService
    {
        ICarDal _carDal;

        public ProductManagerReCap(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult AddCar(Car car)
        {
            ValidationTool.Validate(new ProductValidator(), car);
            
            _carDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Car>>  GetAll()
        {          
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }
    }
}
