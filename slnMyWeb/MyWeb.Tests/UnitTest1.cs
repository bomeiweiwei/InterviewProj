using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyWeb.Areas.ApiArea.Controllers;
using MyWeb.Models;
using MyWeb.Models.ViewModel;
using MyWeb.Service;

namespace MyWeb.Tests
{
    [TestClass]
    public class TestProductController
    {
        readonly NorthwindEntities entities;
        public TestProductController()
        {
            entities = new NorthwindEntities();
        }
        [TestMethod]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductsApiController(testProducts);

            var result = controller.Get();
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        [TestMethod]
        public void GetProduct_ShouldReturnCorrectProduct()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductsApiController(testProducts);

            var result = controller.Get(4) as OkNegotiatedContentResult<vw_Products>;
            Assert.IsNotNull(result);
            Assert.AreEqual(testProducts[3].ProductName, result.Content.ProductName);
        }

        [TestMethod]
        public void GetProduct_ShouldNotFindProduct()
        {
            var controller = new ProductsApiController(GetTestProducts());

            var result = controller.Get(999);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        //[TestMethod]
        //public async Task GetAllProductsAsync_ShouldReturnAllProducts()
        //{
        //    var testProducts = GetTestProducts();
        //    var controller = new ProductsApiController(testProducts);

        //    var result = await controller.ToGetAllProductsAsync() as List<vw_Products>;
        //    Assert.AreEqual(testProducts.Count, result.Count);
        //}

        //[TestMethod]
        //public async Task GetProductAsync_ShouldReturnCorrectProduct()
        //{
        //    var testProducts = GetTestProducts();
        //    var controller = new ProductsApiController(testProducts);

        //    var result = await controller. ToGetProductAsync(4) as OkNegotiatedContentResult<vw_Products>;
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(testProducts[3].ProductName, result.Content.ProductName);
        //}

        private List<vw_Products> GetTestProducts()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Products, vw_Products>();
            });
            IMapper mapper = config.CreateMapper();
            var productList = entities.Products.ToList();
            var testProducts = mapper.Map<List<Products>,List<vw_Products>>(productList);

            return testProducts;
        }

        [TestMethod]
        public void T1_PostMethodSetsLocationHeader()
        {
            var Products = new vw_Products { ProductName = "TestUnitProductName", CategoryID = 1, SupplierID = 1 };
            // Arrange
            var mockRepository = new Mock<ProductsService>();
            var controller = new ProductsApiController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.Post(Products);
            var createdResult = actionResult as CreatedAtRouteNegotiatedContentResult<vw_Products>;

            // Assert
            Assert.IsNotNull(createdResult);
            Assert.AreEqual("DefaultApi", createdResult.RouteName);
            //Assert.AreEqual(9999, createdResult.RouteValues["ProductID"]);
        }

        [TestMethod]
        public void T2_PutReturnsContentResult()
        {
            var Products = entities.Products.Where(m => m.ProductName == "TestUnitProductName").FirstOrDefault();
            Products.ProductName = "ModifyTestUnitProductName";
            // Arrange
            var mockRepository = new Mock<ProductsService>();
            var controller = new ProductsApiController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.Put(Products.ProductID, Products);
            var contentResult = actionResult as NegotiatedContentResult<Products>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.AreEqual(HttpStatusCode.Accepted, contentResult.StatusCode);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(Products.ProductID, contentResult.Content.ProductID);
        }

        [TestMethod]
        public void T3_DeleteReturnsOk()
        {
            var Products = entities.Products.Where(m => m.ProductName == "ModifyTestUnitProductName").FirstOrDefault();
            // Arrange
            var mockRepository = new Mock<ProductsService>();
            var controller = new ProductsApiController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.Delete(Products.ProductID);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }
    }
}
