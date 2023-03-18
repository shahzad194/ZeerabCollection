using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeerabCollection.Entities;
using ZeerabCollection.Services;

namespace ZeerabCollection.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService CategoriesService = new CategoriesService();

        [HttpGet]
        public ActionResult Index()
        {
           var Listcategories = CategoriesService.GetCategories();
            return View(Listcategories);
        }
        //This method Show something to user or it shows the information that user want to see 
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        //This method use when a user send information to database  
        [HttpPost]
        public ActionResult Create(Category category)
        {

            CategoriesService.SaveCategory(category);
            return RedirectToAction("Index");
        }
        //Method for Edit and update Category
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = CategoriesService.GetCategoryId(id);
            return View(category);
        }
        //This method use when a user send information to database  
        [HttpPost]
        public ActionResult Edit(Category category)
        {

            CategoriesService.UpdateCategory(category);
            return RedirectToAction("Index");
        }
        //Method for delete
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var category = CategoriesService.GetCategoryId(id);
            return View(category);
        }
        //This method use when a user send information to database  
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            CategoriesService.DeleteCategory(category.ID);
            return RedirectToAction("Index");
        }
    }
}