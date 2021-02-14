using BusinessReCap.Abstract;
using CoreReCap.UtilitiesReCap.ResultsReCap;
using DataAccessReCap.Abstract;
using EntitiesReCap.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessReCap.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult AddCar(Customers customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult();
        }
    }
}
