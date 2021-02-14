using CoreReCap.UtilitiesReCap.ResultsReCap;
using DataAccessReCap.Abstract;
using EntitiesReCap.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessReCap.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rentals rental);
    }
}
