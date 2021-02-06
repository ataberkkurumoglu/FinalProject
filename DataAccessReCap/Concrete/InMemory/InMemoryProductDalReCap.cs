using DataAccessReCap.Abstract;
using EntitiesReCap.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessReCap.Concrete.InMemory
{
    public class InMemoryProductDalReCap : ICarDal
    {
        List<Car> _car;

        public InMemoryProductDalReCap()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=70000,ModelYear=2015,Description="Sıfır"},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=40000,ModelYear=2010,Description="Sıfır"},
                new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=60000,ModelYear=2000,Description="2. El"},
                new Car{Id=4,BrandId=2,ColorId=3,DailyPrice=85000,ModelYear=2004,Description="Doktordan Temiz "},
                new Car{Id=5,BrandId=3,ColorId=4,DailyPrice=90000,ModelYear=2019,Description="Mühendis Arabası"},
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Add(Car entity, Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
