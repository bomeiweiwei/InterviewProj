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
        //public HttpResponseMessage Post(Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // Do something with the product (not shown).

        //        return new HttpResponseMessage(HttpStatusCode.OK);
        //    }
        //    else
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }
        //}
        [ValidateAntiForgeryToken]
        public IHttpActionResult Post(vw_Products model)
        {
            if (ModelState.IsValid)
            {
                ExecuteResult executeResult = new ExecuteResult();
                executeResult.Success = service.CreateProduct(model);
                if (executeResult.Success)
                {
                    return Ok(executeResult);
                }
                else
                {
                    return BadRequest("新增失敗");
                }
            }
            else
            {
                //return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                return BadRequest("新增失敗，欄位未填寫完整");
            }
        }
        [ValidateAntiForgeryToken]
        public IHttpActionResult Put(int id, Products model)
        {
            if (ModelState.IsValid)
            {
                ExecuteResult executeResult = new ExecuteResult();
                executeResult.Success = service.UpdateProduct(id, model);
                if (executeResult.Success)
                {
                    return Ok(executeResult);
                }
                else
                {
                    return BadRequest("編輯失敗");
                }
            }
            else
            {
                //return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                return BadRequest("編輯失敗，欄位未填寫完整");
            }
        }

        public IHttpActionResult Delete(int id)
        {
            ExecuteResult executeResult = new ExecuteResult();
            executeResult.Success = service.DeleteProduct(id);
            return Ok(executeResult);
        }
    }
}
