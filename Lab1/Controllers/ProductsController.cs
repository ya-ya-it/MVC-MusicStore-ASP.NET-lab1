using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Details(string details)
        {
            ViewBag.Details = "You selected product: " + details ;
            return View();
        }

    // GET: Products
    public ActionResult Index()
        {
            return View();
        }
    }
}