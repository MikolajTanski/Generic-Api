using System;
using System.Linq;
using System.Linq.Expressions;

namespace zadanie.Repository.IRepository.RepositoryBase.IRepositoryBase
{
    public interface IRepositoryBase<T> where T : class
    {
        public IQueryable<T> GetAll();
        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }

}
