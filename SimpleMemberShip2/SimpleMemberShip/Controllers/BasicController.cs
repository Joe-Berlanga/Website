using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMemberShip.Models;
using System.Net;
using System.Net.Mail;

namespace SimpleMemberShip.Controllers
{
    public class BasicController : Controller
    {
        //
        // GET: /Basic/

        
        public ActionResult Index()
        {
            
           
            return View();
        }
        public ActionResult CSS3()
        {


            return View();
        }
        public ActionResult Razor()
        {


            return View();
        }
        public ActionResult Databases()
        {


            return View();
        }
        public ActionResult Jquery()
        {


            return View();
        }
        public ActionResult Javascript()
        {


            return View();
        }
        public ActionResult MVC()
        {


            return View();
        }
        [ChildActionOnly]
        public ActionResult Header()
        {

            return PartialView("~/Views/Shared/_Header.cshtml");

        }

        [ChildActionOnly]
        public ActionResult Footer()
        {

            return PartialView("~/Views/Shared/_Footer.cshtml");

        }

        [HttpPost]
        public ActionResult Footer(EmailModel model)
        {

            if (ModelState.IsValid)
            {

                TempData["success"] = "Email Sent";

            }

            return PartialView("~/Views/Shared/_Footer.cshtml");
        }

    }
}
