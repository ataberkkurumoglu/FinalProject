using CoreRecap.DataAccessRecap.EntityFrameworkRecap;
using DataAccessReCap.Abstract;
using EntitiesReCap.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessReCap.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBaseReCap<Color, NorthwindContextReCap>, IColorDal
    {
    }
}
