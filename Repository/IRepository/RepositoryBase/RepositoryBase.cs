using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using zadanie.Repository.IRepository.RepositoryBase.IRepositoryBase;

namespace zadanie.Repository.IRepository.RepositoryBase
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DataContext _db;

        protected RepositoryBase(DataContext db)
        {
            _db = db;
        }

        public void Create(T entity)
        {
            _db.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _db.Set<T>().AsNoTracking();
        }

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
        }
    }

}
