using DAL.Context;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Good> goodRepository;
        public HomeController(IRepository<Good> goodRepository)
        {
            this.goodRepository = goodRepository;
        }

        public ActionResult Index(int id = 1)
        {
            ViewBag.PagesCount = goodRepository.PagesCount;
            return View();
        }

        public ActionResult HomeTable(int id = 1)
        {
            return PartialView(goodRepository.GetAll().Skip((id - 1) * goodRepository.ITEMS_PER_PAGE).Take(goodRepository.ITEMS_PER_PAGE));
        }
    }
}