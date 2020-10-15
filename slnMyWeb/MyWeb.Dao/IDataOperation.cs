using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Dao
{
    public interface IDataOperation<T> where T : class, new()
    {
        IQueryable<T> Get(Expression<Func<T, bool>> whereLambda);
        T FindOne(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> GetAll();
        int Create(T Item);
        int Update(T Item);
        int Delete(T Item);
        DbContext GetCurrentContext();
    }
}
