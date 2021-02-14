using CoreRecap.DataAccessRecap.EntityFrameworkRecap;
using DataAccessReCap.Abstract;
using EntitiesReCap.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessReCap.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBaseReCap<Rentals, NorthwindContextReCap>, IRentalDal
    {
    }
}
