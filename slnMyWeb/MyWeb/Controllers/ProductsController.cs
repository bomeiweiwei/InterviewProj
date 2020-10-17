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
    public class ProductsController : Controller
    {
        private readonly ProductsService productsService;
        private readonly CategoriesService categoriesService;
        private readonly SuppliersService suppliersService;
        public ProductsController()
        {
            productsService = new ProductsService();
            categoriesService = new CategoriesService();
            suppliersService = new SuppliersService();
        }
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
            vw_Products model = new vw_Products();
            ViewBag.CategoryID = new SelectList(categoriesService.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(suppliersService.GetAll(), "SupplierID", "CompanyName");
            return View(model);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = productsService.GetProducts(id.Value);
            if (products == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(categoriesService.GetAll(), "CategoryID", "CategoryName", products.CategoryID);
            ViewBag.SupplierID = new SelectList(suppliersService.GetAll(), "SupplierID", "CompanyName", products.SupplierID);
            return View(products);
        }
    }
}