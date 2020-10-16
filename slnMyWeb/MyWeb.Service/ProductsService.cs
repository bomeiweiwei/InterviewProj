using MyWeb.Dao.Sql;
using MyWeb.Models;
using MyWeb.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Service
{
    public class ProductsService : BaseService<Products>
    {
        //public ProductsService() : base()
        //{
        //}
        public List<vw_Products> GetProductsList(int ProductID)
        {
            ProductsDA productsDA = new ProductsDA();
            return productsDA.GetProductsData(ProductID);
        }
    }
}
