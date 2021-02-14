using BusinessReCap.Abstract;
using CoreReCap.UtilitiesReCap.ResultsReCap;
using DataAccessReCap.Abstract;
using EntitiesReCap.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessReCap.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rentals rental)
        {
            if (rental.RentDate==null)
            {
                return new ErrorResult("Araba teslim edilmemiş");
            }
            _rentalDal.Add(rental);
            return new SuccessResult();
        }
    }
}
