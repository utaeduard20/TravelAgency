using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TravelAgencyTest.Data.IServices
{
    public interface IAbstractService<T>
    {
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}