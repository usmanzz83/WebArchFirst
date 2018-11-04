using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TestData;
using TestDataRepositories;
using TestDataRepositories.Interfaces;


namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ICategories oCatRep;

        public HomeController(ICategories db)
        {
            this.oCatRep = db;
        }

        public ActionResult Index()
        {
            IEnumerable<Category> lstCategories = oCatRep.GetAll().ToList();
            return View(lstCategories);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}