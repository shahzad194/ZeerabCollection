using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeerabCollection.Entities;
using ZeerabCollection.Services;

namespace ZeerabCollection.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductTable(string search)
        {
            var products = productsService.GetProducts();
            if (string.IsNullOrEmpty(search) == false)
            {
                products = products.Where(p => p.Name!=null && p.Name.ToLower().Contains(search.ToLower())).ToList();
            }
           
            return PartialView(products);
        }
        //This method Show something to user or it shows the information that user want to see 
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        //This method use when a user send information to database  
        [HttpPost]
        public ActionResult Create(Product product)
        {

            productsService.SaveProduct(product);
            return RedirectToAction("Index");
        }
    }
}