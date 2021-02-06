using EntitiesReCap.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessReCap.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void AddCar(Car car);
    }
}
