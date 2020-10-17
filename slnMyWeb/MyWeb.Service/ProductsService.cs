using AutoMapper;
using MyWeb.Dao;
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

        public Products GetProducts(int ProductID)
        {
            return FindOne(m => m.ProductID == ProductID);
        }

        public bool CreateProduct(vw_Products model)
        {
            int count = 0;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<vw_Products, Products>();
            });
            IMapper mapper = config.CreateMapper();
            Products saveModel = mapper.Map<vw_Products, Products>(model);
            try
            {
                count = Create(saveModel);
            }
            catch (Exception)
            { }
            if (count == 1)
                return true;
            else
                return false;
        }

        public bool UpdateProduct(int id, Products model)
        {
            int count = 0;
            NorthwindEntities entity = (NorthwindEntities)GetCurrentContext();
            ProductDao dao = new ProductDao();

            Products oriProduct = FindOne(m => m.ProductID == id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Products, Products>();
            });
            IMapper mapper = config.CreateMapper();
            mapper.Map(model, oriProduct);
            try
            {
                count = dao.UpdateData(oriProduct, entity);
            }
            catch (Exception)
            { }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteProduct(int id)
        {
            Products oriProduct = FindOne(m => m.ProductID == id);
            int count = Delete(oriProduct);
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
