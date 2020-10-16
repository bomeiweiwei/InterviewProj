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
        public List<vw_Products> Get()
        {
            return service.GetProductsList(0);
        }
        public vw_Products Get(int id)
        {
            return service.GetProductsList(id).FirstOrDefault();
        }
    }
}
