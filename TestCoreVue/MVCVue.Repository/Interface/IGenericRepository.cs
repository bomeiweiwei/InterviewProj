using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MVCVue.Repository.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Entity();
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Expression<Func<TEntity, object>>[] includeProperties = null);
        TEntity GetById(object Id);
        void Insert(TEntity entity);
        void Delete(object Id);
        void Delete(TEntity entityToDelete);
        void Update(TEntity entityToUpdate);
    }
}
