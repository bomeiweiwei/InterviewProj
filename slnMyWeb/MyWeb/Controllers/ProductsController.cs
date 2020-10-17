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
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View();
        }

        public ActionResult Create()
        {
            CategoriesService categoriesService = new CategoriesService();
            SuppliersService suppliersService = new SuppliersService();
            vw_Products model = new vw_Products();
            ViewBag.CategoryID = new SelectList(categoriesService.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(suppliersService.GetAll(), "SupplierID", "CompanyName");
            return View(model);
        }
    }
}