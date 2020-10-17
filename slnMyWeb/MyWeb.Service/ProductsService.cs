using AutoMapper;
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
        private readonly ProductsDA productsDA;
        public ProductsService() : base()
        {
            productsDA = new ProductsDA();
        }
        public List<vw_Products> GetProductsList(int ProductID)
        {
            return productsDA.GetProductsData(ProductID).OrderByDescending(m => m.ProductID).ToList();
        }

        public bool CreateProduct(vw_Products model)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<vw_Products, Products>();
            });
            IMapper mapper = config.CreateMapper();
            Products saveModel = mapper.Map<vw_Products, Products>(model);
            int count = Create(saveModel);
            if (count == 1)
                return true;
            else
                return false;
        }
    }
}
