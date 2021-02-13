using CoreRecap.DataAccessRecap.EntityFrameworkRecap;
using DataAccessReCap.Abstract;
using EntitiesReCap.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessReCap.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBaseReCap<Car,NorthwindContextReCap>,ICarDal
    {
       
    }
}
