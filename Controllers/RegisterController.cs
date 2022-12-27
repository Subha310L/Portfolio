using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioMVCproject.Models;

namespace Portfolio.Controllers
{
    public class RegisterController : Controller
    {

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(RegisterModel register)
        {
            return View();
        }



    }
}