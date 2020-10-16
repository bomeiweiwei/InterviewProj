using MyWeb.Models.ViewModel;
using MyWeb.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWeb.Areas.Service.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly ProductsService service;
        public ProductsController()
        {
            service = new ProductsService();
        }
        public IQueryable<vw_Products> GetProducts()
        {
            IQueryable<vw_Products> list = service.GetProductsList(0).AsQueryable();
            return list;
        }
        public IHttpActionResult GetProduct(int id)
        {
            vw_Products obj = service.GetProductsList(id).FirstOrDefault();
            return Ok(obj);
        }
    }
}
