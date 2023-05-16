using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TravelAgencyTest.Data.IServices;

namespace TravelAgencyTest.Data.Services
{
    public class AbstractService<T> : IAbstractService<T> where T : class
    {
        protected ApplicationDbContext RepositoryContext { get; set; }

        public AbstractService(ApplicationDbContext repositoryContext) => RepositoryContext = repositoryContext;

        public IEnumerable<T> FindAll() => RepositoryContext.Set<T>();

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression) => RepositoryContext.Set<T>().Where(expression);

        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);

        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);

        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);

        public void Save() => RepositoryContext.SaveChanges();
    }
}
