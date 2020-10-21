using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        ShopDb db = new ShopDb();
        const int ITEMS_PER_PAGE = 7;
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categories(int id = 1)
        {
            ViewBag.PagesCount = (int)Math.Ceiling(db.Category.ToList().Count / (decimal)ITEMS_PER_PAGE);
            return View();
        }
        public ActionResult CategoryTable(int id = 1)
        {
            var result = db.Category.ToList()
                .Skip((id - 1) * ITEMS_PER_PAGE)
                .Take(ITEMS_PER_PAGE).ToList();
            return PartialView(result);
        }

        public ActionResult Goods(int id = 1)
        {
            ViewBag.PagesCount = (int)Math.Ceiling(db.Good.ToList().Count / (decimal)ITEMS_PER_PAGE);
            return View();
        }
        public ActionResult GoodTable(int id = 1)
        {
            var result = db.Good.ToList()
                .Skip((id - 1) * ITEMS_PER_PAGE)
                .Take(ITEMS_PER_PAGE).ToList();
            return PartialView(result);
        }

        public ActionResult Manufacturers(int id = 1)
        {
            ViewBag.PagesCount = (int)Math.Ceiling(db.Manufacturer.ToList().Count / (decimal)ITEMS_PER_PAGE);
            return View();
        }
        public ActionResult ManufacturerTable(int id = 1)
        {
            var result = db.Manufacturer.ToList()
                .Skip((id - 1) * ITEMS_PER_PAGE)
                .Take(ITEMS_PER_PAGE).ToList();
            return PartialView(result);
        }
    }
}