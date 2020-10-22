using InternetShop.Domain.Abstract;
using InternetShop.BLL.Models.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InternetShop.Domain.Entities;
using InternetShop.BLL.Services.Abstract;
using System.Threading.Tasks;

namespace InternetShop.WebUI.Controllers
{
    [RoutePrefix("Home")]
    public class GoodController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public int PageSize { get; set; } = 7;

        public GoodController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("{List}/{catehory:alpha= }/{manufacturer:alpha= }/{page:int=1}")]
        public async Task<ActionResult> List(string category, string manufacturer, int page = 1)
        {
            GoodsListVM model = new GoodsListVM
            {
                Goods = (await _unitOfWork.GoodsRepo.GetAllAsync())
                    .Where(p => category == null || p.CategoryName == category)
                    .Where(p => manufacturer == null || p.ManufacturerName == manufacturer)
                    .OrderBy(p => p.GoodId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = await GetItemsCount(category, manufacturer)
                },
                CurrentCategory = category,
                CurrentManufacturer = manufacturer
            };

            return View(model);
        }

        [Route("{GoodSummary}/{catehory:alpha=}/{manufacturer:alpha=}/{page:int=1}")]
        public async Task<ActionResult> GoodSummary(string category, string manufacturer, int page = 1)
        {
            return PartialView((await _unitOfWork.GoodsRepo.GetAllAsync())
                .Where(p => category == null || p.CategoryName == category)
                    .Where(p => manufacturer == null || p.ManufacturerName == manufacturer)
                    .OrderBy(p => p.GoodId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                    .ToList());
        }


        private async Task<int> GetItemsCount(string category, string manufacturer)
        {
            int items = 0;
            if (category == null && manufacturer == null)
            {
                items = (await _unitOfWork.GoodsRepo.GetAllAsync()).Count();
            }
            else
            {
                if (category != null && manufacturer != null)
                {
                    items = (await _unitOfWork.GoodsRepo.GetAllAsync()).Where(e => e.CategoryName == category && e.ManufacturerName == manufacturer).Count();
                }
                else if (category != null)
                {
                    items = (await _unitOfWork.GoodsRepo.GetAllAsync()).Where(e => e.CategoryName == category).Count();
                }
                else
                {
                    items = (await _unitOfWork.GoodsRepo.GetAllAsync()).Where(e => e.ManufacturerName == manufacturer).Count();
                }
            }
            return items;
        }

    }
}