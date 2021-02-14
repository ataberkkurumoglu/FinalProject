using Business.Constans;
using BusinessReCap.Abstract;
using CoreReCap.UtilitiesReCap.ResultsReCap;
using DataAccessReCap.Abstract;
using EntitiesReCap.Concrete;
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
                _carDal.Add(car);
            return new SuccessResult();
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
