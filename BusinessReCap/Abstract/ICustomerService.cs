using CoreReCap.UtilitiesReCap.ResultsReCap;
using EntitiesReCap.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessReCap.Abstract
{
    public interface ICustomerService
    {
        IResult AddCar(Customers customer);
    }
}
