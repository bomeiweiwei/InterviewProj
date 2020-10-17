using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Dao
{
    public class ProductDao
    {
        public int UpdateData(Products data, NorthwindEntities entity)
        {
            int success;
            var entry = entity.Entry(data);

            if (entry.State == EntityState.Detached)
            {
                var set = entity.Set<Products>();
                Products attachedEntity = set.Find(data.ProductID);

                if (attachedEntity != null)
                {
                    var attachedEntry = entity.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(data);
                }
                else
                {
                    entry.State = EntityState.Modified;
                }
            }

            success = entity.SaveChanges();
            return success;
        }
    }
}
