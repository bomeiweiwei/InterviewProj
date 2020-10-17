using MyWeb.Models;
using MyWeb.Models.ViewModel;
using MyWeb.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MyWeb.Areas.Service.Controllers
{
    //Service
    public class ProductsController : ApiController
    {
        private readonly ProductsService service;
        public ProductsController()
        {
            service = new ProductsService();
        }
        public IQueryable<vw_Products> Get()
        {
            IQueryable<vw_Products> list = service.GetProductsList(0).AsQueryable();
            return list;
        }
        public IHttpActionResult Get(int id)
        {
            vw_Products obj = service.GetProductsList(id).FirstOrDefault();
            return Ok(obj);
        }
        [ValidateAntiForgeryToken]
        public IHttpActionResult Post(vw_Products model)
        {
            ExecuteResult executeResult = new ExecuteResult();
            executeResult.Success = service.CreateProduct(model);
            return Ok(executeResult);
        }

        public IHttpActionResult Put(int id, Products model)
        {
            ExecuteResult executeResult = new ExecuteResult();
            executeResult.Success = service.UpdateProduct(id, model);
            return Ok(executeResult);
        }

        public void Delete(int id)
        {
        }
    }
}
