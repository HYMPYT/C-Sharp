﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityExample.Controllers
{
  
    public class HomeController : Controller
    {
        // GET: Home
        //данный аттрибут говорит о том, что этот метод действия доступен только
        //авторизованным пользователям
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }
    }
}