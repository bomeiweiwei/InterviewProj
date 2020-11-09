using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace MVCVue.Web.Controllers
{
    public class RootPathController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public RootPathController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            ViewData["ContentRootPath"] = _env.ContentRootPath;
            return View();
        }
    }
}
