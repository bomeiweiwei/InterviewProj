using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWeb.Areas.ApiArea.Controllers
{
    public class CategoriesApiController : ApiController
    {
        // GET: api/CategoriesApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CategoriesApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CategoriesApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CategoriesApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CategoriesApi/5
        public void Delete(int id)
        {
        }
    }
}
