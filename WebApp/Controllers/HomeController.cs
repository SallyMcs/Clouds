using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;


namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
           
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult Catalogue()
        {
            return View();
        }
        public ActionResult ProductDetails()
        {
            Product Pro = new Product();
            Pro.MyProducts = "Licences, Salesforce training";
            Pro.Price = 100;
            return View( Pro);
        }
     
    }
}