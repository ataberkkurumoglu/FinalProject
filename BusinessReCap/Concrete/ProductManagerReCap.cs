using BusinessReCap.Abstract;
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

        public void AddCar(Car car)
        {
            int carLength = car.Description.Length;
            
            if (car.DailyPrice > 200 && carLength > 2)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba eklendi");
            }
            else
            {
                Console.WriteLine("Araba ekleyemezsiniz");
            }
                
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
