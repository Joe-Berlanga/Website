using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;
using WebMatrix.Data;
using SimpleMemberShip.Models;


namespace SimpleMemberShip.Controllers
{
    public class AccountController : Controller
    {
        //
        
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Members()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult  RegisterForm()
        {

            return PartialView("~/Views/Account/_RegisterForm.cshtml");


        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult RegisterProcess(RegisterModel model)
        {
            if (ModelState.IsValid)
            {


                if (WebSecurity.UserExists(model.UserName))
                {
                    TempData["errorMessage"] = "The username is already in use.";

                }
                else
                {

                    try
                    {
                        WebSecurity.CreateUserAndAccount(model.UserName, model.Password);
                        WebSecurity.Login(model.UserName, model.Password);
                       
                        return RedirectToAction("Index", "Basic");
                    }
                    catch 
                    {
                       TempData["errorMessage"] = "There was a problem creating your account.";
                    }
                    
                    
                }

            }

            return PartialView("~/Views/Account/_RegisterForm.cshtml");

        }
    }
}
