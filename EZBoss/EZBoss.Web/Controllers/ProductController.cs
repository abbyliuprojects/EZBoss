using EZBoss.Services.Implement;
using EZBoss.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EZBoss.Web.Controllers
{
    public class ProductController : BaseController
    {
        IProductService _productService = new ProductService();
        private readonly static string storeId = "liuMa123";

        // GET: Productdat
        public ViewResult Product()
        {
            ViewBag.ProductData = _productService.GetProductData(storeId);

            return View();
        }
    }
}