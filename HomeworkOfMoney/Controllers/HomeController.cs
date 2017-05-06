using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkOfMoney.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            var model = new MyClass
            {
                
                category = "支出",
                money = Math.Floor((Math.random
                _date = DateTime.Now
            };
            return View(model);
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