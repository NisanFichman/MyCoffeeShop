using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult ShowHomePage()
        {
            return View("ShowHomePage");
        }
        public ActionResult SignUp(User u1)
        {
            CoffeeShopEntities CoffeeDB = new CoffeeShopEntities();
            CoffeeDB.Users.Add(u1);
            CoffeeDB.SaveChanges();
            return RedirectToAction("SignUp", "SignUpController");
        }
  
        public ActionResult Login()
        {
            return View("Login");
        }
    }
}