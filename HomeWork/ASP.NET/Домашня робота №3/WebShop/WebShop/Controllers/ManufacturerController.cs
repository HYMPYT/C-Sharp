using DAL.Context;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShop.Controllers
{
    public class ManufacturerController : Controller
    {
        IRepository<Manufacturer> manufacturerRepository;

        public ManufacturerController(IRepository<Manufacturer> manufacturerRepository)
        {
            this.manufacturerRepository = manufacturerRepository;
        }

        public ActionResult Index(int id = 1)
        {
            ViewBag.PagesCount = manufacturerRepository.PagesCount;
            return View();
        }

        public ActionResult ManufacturerTable(int id = 1)
        {
            return PartialView(manufacturerRepository.GetAll().Skip((id - 1) * manufacturerRepository.ITEMS_PER_PAGE).Take(manufacturerRepository.ITEMS_PER_PAGE));
        }

        public ActionResult Delete(int id)
        {
            manufacturerRepository.Delete(manufacturerRepository.Get(id));
            return RedirectToAction("Index");
        }

        public ActionResult AddOrUpdate(int id = 0)
        {
            if (id == 0)
                return View();
            return View(manufacturerRepository.Get(id));
        }
        [HttpPost]
        public ActionResult AddOrUpdate(int? ManufacturerId, string ManufacturerName)
        {
            if (!ModelState.IsValid)
                return View();

            Manufacturer manufacturer;

            if (ManufacturerId == null)
                manufacturer = new Manufacturer() { ManufacturerName = ManufacturerName };
            else
                manufacturer = new Manufacturer() { ManufacturerId = (int)ManufacturerId, ManufacturerName = ManufacturerName };

            manufacturerRepository.CreateOrUpdate(manufacturer);
            return RedirectToAction("Index");
        }
    }
}