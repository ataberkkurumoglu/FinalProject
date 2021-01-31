using DataAccessReCap.Abstract;
using EntitiesReCap.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessReCap.Concrete
{
    public class ProductManagerReCap
    {
        IProductDalReCap _productDalReCap;

        public ProductManagerReCap(IProductDalReCap productDalReCap)
        {
            _productDalReCap = productDalReCap;
        }

        public List<Car> GetAll()
        {
            return _productDalReCap.GetAll();
        }
    }
}
