using EntitiesReCap.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessReCap.Abstract
{
    public interface IProductDalReCap
    {
        List<Car> GetById(int Id);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
