using DAL.Context;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class GoodController : Controller
    {
        IRepository<Good> goodRepository;
        IRepository<Manufacturer> manufacturerRepository;
        IRepository<Category> categoryRepository;
        public GoodController(IRepository<Good> goodRepository, IRepository<Manufacturer> manufacturerRepository, IRepository<Category> categoryRepository)
        {
            this.goodRepository = goodRepository;
            this.manufacturerRepository = manufacturerRepository;
            this.categoryRepository = categoryRepository;
        }

        public ActionResult Index(int id = 1)
        {
            ViewBag.PagesCount = goodRepository.PagesCount;
            return View();
        }

        public ActionResult GoodTable(int id = 1)
        {
            return PartialView(goodRepository.GetAll().Skip((id - 1) * goodRepository.ITEMS_PER_PAGE).Take(goodRepository.ITEMS_PER_PAGE));
        }

        public ActionResult Delete(int id)
        {
            goodRepository.Delete(goodRepository.Get(id));
            return RedirectToAction("Index");
        }

        public ActionResult AddOrUpdate(int id = 0)
        {
            GoodEditModel model = new GoodEditModel()
            {
                Good = goodRepository.Get(id),
                Categories = categoryRepository.GetAll(),
                Manufacturers = manufacturerRepository.GetAll()
            };
            if (id == 0)
                return View(new GoodEditModel() { Good = new Good(), Categories = categoryRepository.GetAll(), Manufacturers = manufacturerRepository.GetAll()});
            return View(model);
        }

        [HttpPost]
        public ActionResult AddOrUpdate(Good good)
        {
            if (!ModelState.IsValid)
                return View();

            goodRepository.CreateOrUpdate(good);
            return RedirectToAction("Index");
        }
    }
}