using EntitiesReCap.Abstract;
using EntitiesReCap.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessReCap.Abstract
{
    public interface IEntityRepositoryReCap<T> where T : class, IEntityReCap, new()
    {       
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
