using HomeworkOfMoney.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkOfMoney.Controllers
{
    public class HomeController : Controller
    {
        private SkillTree db = new SkillTree();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Id,Categoryyy,Amounttt,Dateee,Remarkkk")] AccountBook accountBook)
        {
            if (ModelState.IsValid)
            {
                accountBook.Id = Guid.NewGuid();
                db.AccountBook.Add(accountBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accountBook);
        }
        public ActionResult add_data()
        {
            var db = new SkillTree();
            var list = new List<MyClass>();

            foreach (var data in db.AccountBook)
            {
                var classData = new MyClass();

                if (data.Categoryyy == 0)
                {
                    classData.category = "收入";
                    
                }
                else
                {
                    classData.category = "支出";
                }

                classData._date = data.Dateee;
                classData.money = data.Amounttt;
                classData.remark = data.Remarkkk;

                if (data.Remarkkk.Length > 10)
                {
                    classData.remark = data.Remarkkk.Substring(0, 11);
                }
                else
                {
                    classData.remark = data.Remarkkk;
                }
                list.Add(classData);
            }
            //var model = new MyClass
            //{

            //    category = "支出",
            //    money = 2000,
            //    _date = DateTime.Now
            //};
            return View(list);
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