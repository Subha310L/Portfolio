using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Education()
        {
            ViewBag.SchoolName = "M.K.V.K MAtric. Hr. Sec. School";
            ViewBag.SchoolPlace = "Tenkasi";
            ViewBag.SchoolPercentage = 82;
            ViewBag.UgCollegeName = "University of madurai";
            ViewBag.CollegePercentage = 83;
            ViewBag.CollegeStream = "Mathematics";
            ViewBag.PgCollegeName = "Anna University";
            ViewBag.CollegePercentage = 82;
            ViewBag.CollegeStream = "Computer application";
            return View();
        }
    }
}