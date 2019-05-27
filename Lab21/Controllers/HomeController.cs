using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewUser(NewUserInfo u)
        {
            ViewBag.Result = u;

            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        //public ActionResult User(string firstName, string lastName, string userName, string email, string password)
        //{

        //    ViewBag.FirstName = firstName;
        //    ViewBag.LastName = lastName;
        //    ViewBag.Username = userName;
        //    ViewBag.Email = email;
        //    ViewBag.Username = password;


        //    return View();
        //}


    }
}