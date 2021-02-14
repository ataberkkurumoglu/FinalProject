using CoreReCap.UtilitiesReCap.ResultsReCap;
using EntitiesReCap.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessReCap.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IResult AddCar(Car car);
    }
}
