using LinqKit;
using MyWeb.Common;
using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;

namespace MyWeb.Dao
{
    public class BaseDao<T> where T : class
    {
        public BaseDao()
        {
            this.DataOperation = new BaseDataOperation();
        }
        public IDataOperation<T> DataOperation { get; } = null;

        public class BaseDataOperation : IDataOperation<T>, IDisposable
        {
            private readonly DbContext _context;
            /// <summary>
            /// 設定DB
            /// </summary>
            /// <param name="entity">列舉值</param>
            public BaseDataOperation()
            {
                _context = new NorthwindEntities();
            }
            /// <summary>
            /// 取得資料
            /// </summary>
            /// <param name="whereLambda"></param>
            /// <returns></returns>
            public IQueryable<T> Get(Expression<Func<T, bool>> whereLambda)
            {
                return _context.Set<T>().AsExpandable().Where(whereLambda);
            }
            /// <summary>
            /// 取得單一資料
            /// </summary>
            /// <param name="whereLambda"></param>
            /// <returns></returns>
            public T FindOne(Expression<Func<T, bool>> whereLambda)
            {
                return _context.Set<T>().AsExpandable().Where(whereLambda).FirstOrDefault();
            }
            /// <summary>
            /// 取得所有資料
            /// </summary>
            /// <returns></returns>
            public IQueryable<T> GetAll()
            {
                return _context.Set<T>();
            }
            /// <summary>
            /// 新增資料
            /// </summary>
            /// <param name="Item"></param>
            /// <returns></returns>
            public int Create(T Item)
            {
                try
                {
                    _context.Set<T>().Add(Item);
                    return _context.SaveChanges();
                }
                catch (DbEntityValidationException)
                {
                    throw;
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            /// <summary>
            /// 更新資料
            /// </summary>
            /// <param name="Item"></param>
            /// <returns></returns>
            public int Update(T Item)
            {
                try
                {
                    _context.Entry(Item).State = EntityState.Modified;
                    return _context.SaveChanges();
                }
                catch (DbEntityValidationException)
                {
                    throw;
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            /// <summary>
            /// 刪除資料
            /// </summary>
            /// <param name="Item"></param>
            /// <returns></returns>
            public int Delete(T Item)
            {
                try
                {
                    _context.Set<T>().Remove(Item);
                    return _context.SaveChanges();
                }
                catch (DbEntityValidationException)
                {
                    throw;
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            /// <summary>
            /// Get Current Context
            /// </summary>
            /// <returns></returns>
            public DbContext GetCurrentContext()
            {
                return _context;
            }

            private bool disposed = false;
            protected virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        _context.Dispose();
                    }
                }
                this.disposed = true;
            }
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            
        }
    }
}
