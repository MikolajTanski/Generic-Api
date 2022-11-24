using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace zadanie.Servis.IService.IServiceBase
{
    public interface IServiceBase<EntityType> where EntityType : class
    {
        public Task<List<EntityType>> GetAllAsync();
        public Task<EntityType> GetByIdAsync(int id);
        public IEnumerable<EntityType> GetByCondition(Expression<Func<EntityType, bool>> expression);
        public void Create(EntityType entity);
        public void Update(EntityType entity);
        public void Delete(int id);
    }

}
