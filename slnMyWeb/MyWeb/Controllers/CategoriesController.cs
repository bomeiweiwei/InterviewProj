using MyWeb.Models;
using MyWeb.Models.ViewModel;
using MyWeb.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CategoriesService categoriesService;
        public CategoriesController()
        {
            categoriesService = new CategoriesService();
        }
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail(int? id)
        {
            Categories model = new Categories();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            model = categoriesService.FindOne(m => m.CategoryID == id);
            return View(model);
        }

        public ActionResult Create()
        {
            Categories model = new Categories();
            return View(model);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categories categories = categoriesService.FindOne(m => m.CategoryID == id.Value);
            if (categories == null)
            {
                return HttpNotFound();
            }
            return View(categories);
        }
    }
}