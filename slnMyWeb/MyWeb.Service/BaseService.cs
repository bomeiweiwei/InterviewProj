﻿using MyWeb.Dao;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Service
{
    public class BaseService<T> where T : class, new()
    {
        private BaseDao<T> serviceModel;
        public BaseService()
        {
            this.serviceModel = new BaseDao<T>();
        }
        /// <summary>
        /// 取得資料
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public IQueryable<T> Get(Expression<Func<T, bool>> whereLambda)
        {
            return serviceModel.GetData.Get(whereLambda);
        }
        /// <summary>
        /// 取得單一資料
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public T FindOne(Expression<Func<T, bool>> whereLambda)
        {
            return serviceModel.GetData.FindOne(whereLambda);
        }
        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return serviceModel.GetData.GetAll();
        }
        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public int Create(T Item)
        {
            return serviceModel.GetData.Create(Item);
        }
        /// <summary>
        /// 更新資料
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public int Update(T Item)
        {
            return serviceModel.GetData.Update(Item);
        }
        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public int Delete(T Item)
        {
            return serviceModel.GetData.Delete(Item);
        }
        /// <summary>
        /// Get Current Context
        /// </summary>
        /// <returns></returns>
        public DbContext GetCurrentContext()
        {
            return serviceModel.GetData.GetCurrentContext();
        }
    }
}
