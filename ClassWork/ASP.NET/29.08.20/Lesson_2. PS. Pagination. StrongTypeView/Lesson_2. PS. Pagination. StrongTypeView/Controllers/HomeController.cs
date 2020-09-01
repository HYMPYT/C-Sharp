using Lesson_2.PS.Pagination.StrongTypeView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_2.PS.Pagination.StrongTypeView.Controllers
{
    public class HomeController : Controller
    {
        IEnumerable<Student> students = Student.GetStudents();

        const int ITEMS_PER_PAGE = 3;

        public ActionResult Index(int id = 1)
        {
            ViewBag.QueryString = Request.QueryString;
            ViewBag.Id = id;


            int pagesCount = (int)Math.Ceiling(students.Count() / (decimal)ITEMS_PER_PAGE);

            //ViewBag.Students = students
            //                   .Skip((id - 1) * ITEMS_PER_PAGE)
            //                    .Take(ITEMS_PER_PAGE);

            //var result = students
            //                    .Skip((id - 1) * ITEMS_PER_PAGE)
            //                     .Take(ITEMS_PER_PAGE);

            ViewBag.PagesCount = pagesCount;

            return View();
        }

  
        public ActionResult Table(int id = 1)
        {


            var result = students
                              .Skip((id - 1) * ITEMS_PER_PAGE)
                               .Take(ITEMS_PER_PAGE);
            return PartialView(result);
        }
    }
}