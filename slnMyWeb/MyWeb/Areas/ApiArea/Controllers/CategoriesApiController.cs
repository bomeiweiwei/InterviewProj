using MyWeb.Models;
using MyWeb.Models.ViewModel;
using MyWeb.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MyWeb.Areas.ApiArea.Controllers
{
    public class CategoriesApiController : ApiController
    {
        // GET: api/ProductsApi
        private readonly CategoriesService service;
        public CategoriesApiController()
        {
            service = new CategoriesService();
        }
        public List<vw_Categories> Get()
        {
            List<vw_Categories> list = service.GetViewList().ToList();
            return list.Select(m => new vw_Categories { CategoryID = m.CategoryID, CategoryName = m.CategoryName, Description = m.Description }).ToList();
        }
        public IHttpActionResult Get(int id)
        {
            Categories obj = service.FindOne(m => m.CategoryID == id);
            return Ok(obj);
        }

        [ValidateAntiForgeryToken]
        public IHttpActionResult Post(vw_Categories model)
        {
            ModelState.Remove("model.CategoryID");
            if (ModelState.IsValid)
            {
                ExecuteResult executeResult = new ExecuteResult();
                executeResult.Success = service.CreateCategories(model);
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

        // PUT: api/CategoriesApi/5
        public IHttpActionResult Put(int id, Categories model)
        {
            if (ModelState.IsValid)
            {
                ExecuteResult executeResult = new ExecuteResult();
                executeResult.Success = service.UpdateCategories(id, model);
                executeResult.Success = true;
                return Ok(executeResult);
            }
            else
            {
                //return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                return BadRequest("編輯失敗，欄位未填寫完整");
            }
        }

        // DELETE: api/CategoriesApi/5
        public IHttpActionResult Delete(int id)
        {
            ExecuteResult executeResult = new ExecuteResult();
            executeResult.Success = service.DeleteCategories(id);
            return Ok(executeResult);
        }
    }
}
