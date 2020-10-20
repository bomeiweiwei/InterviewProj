using MyWeb.Models;
using MyWeb.Models.ViewModel;
using MyWeb.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace MyWeb.Areas.ApiArea.Controllers
{
    public class ProductsApiController : ApiController
    {
        List<vw_Products> products = new List<vw_Products>();
        // GET: api/ProductsApi
        private readonly ProductsService service;
        public ProductsApiController()
        {
            service = new ProductsService();
        }
        public ProductsApiController(ProductsService _service)
        {
            service = _service;
        }
        public ProductsApiController(List<vw_Products> products)
        {
            this.products = new List<vw_Products>(); //products;
            service = new ProductsService();
        }
        public List<vw_Products> Get()
        {
            List<vw_Products> list = service.GetProductsList(0);
            return list;
        }
        public IHttpActionResult Get(int id)
        {
            vw_Products obj = service.GetProductsList(id).FirstOrDefault();
            if (obj == null)
            {
                return NotFound();
            }
            else
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
        [System.Web.Http.HttpPost]
        [ValidateAntiForgeryToken]
        public IHttpActionResult Post(vw_Products model)
        {
            ModelState.Remove("model.ProductID");
            if (ModelState.IsValid)
            {
                ExecuteResult executeResult = new ExecuteResult();
                executeResult.Success = service.CreateProduct(model);
                if (executeResult.Success)
                {
                    return CreatedAtRoute("DefaultApi", new { id = model.ProductID }, model);
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
                executeResult.Success = true;
                return Content(HttpStatusCode.Accepted, model);
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
            return Ok();
        }

        //public async Task<IEnumerable<vw_Products>> ToGetAllProductsAsync()
        //{
        //    return await Task.FromResult(Get());
        //}

        //public async Task<IHttpActionResult> ToGetProductAsync(int id)
        //{
        //    return await Task.FromResult(Get(id));
        //}
    }
}
