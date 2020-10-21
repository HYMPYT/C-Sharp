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

        public ActionResult Categories()
        {
            var categories = db.Category.ToList();
            ViewBag.Categories = categories;
            return View();
        }

        public ActionResult Goods()
        {
            var goods = db.Good.ToList();
            ViewBag.Goods = goods;
            return View();
        }

        public ActionResult Manufacturers()
        {
            var manufacturers = db.Manufacturer.ToList();
            ViewBag.Manufacturers = manufacturers;
            return View();
        }
    }
}