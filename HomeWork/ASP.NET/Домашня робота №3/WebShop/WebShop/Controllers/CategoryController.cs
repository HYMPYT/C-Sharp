using DAL.Context;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShop.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<Category> categoryRepository;

        public CategoryController(IRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public ActionResult Index(int id = 1)
        {
            ViewBag.PagesCount = categoryRepository.PagesCount;
            return View();
        }

        public ActionResult CategoryTable(int id = 1)
        {
            return PartialView(categoryRepository.GetAll().Skip((id - 1) * categoryRepository.ITEMS_PER_PAGE).Take(categoryRepository.ITEMS_PER_PAGE));
        }

        public ActionResult Delete(int id)
        {
            categoryRepository.Delete(categoryRepository.Get(id));
            return RedirectToAction("Index");
        }

        public ActionResult AddOrUpdate(int id = 0)
        {
            if (id == 0)
                return View();
            return View(categoryRepository.Get(id));
        }

        [HttpPost]
        public ActionResult AddOrUpdate(int? CategoryId, string CategoryName)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            Category category;

            if (CategoryId == null)
                category = new Category() { CategoryName = CategoryName };
            else
                category = new Category() { CategoryId = (int)CategoryId, CategoryName = CategoryName };

            categoryRepository.CreateOrUpdate(category);
            return RedirectToAction("Index");
        }
    }
}