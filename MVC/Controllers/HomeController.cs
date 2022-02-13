using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using MVC.Common;
using MVC.Models;


namespace MVC.Controllers
{
    public class HomeController : SharedController
    {
        [Route]
        public ActionResult Index()
        {
            var currentculture = Thread.CurrentThread.CurrentCulture.Name;
            EmployeeModel model = new EmployeeModel()
            {
                Fname = "Nikunj",
                LName = "Adhaduk",
                Status = Common.Common.EmployeeStatus.Active.GetDescription()
            };

            ViewBag.Name = "Home";
            ViewBag.Action = model;

            return View( "Index", model);
        }

        public ActionResult About()
        {
            EmployeeModel model = new EmployeeModel()
            {
                Fname = "Nikunj",
                LName = "Adhaduk",
                Status = Common.Common.EmployeeStatus.Active.GetDescription()
            };

            ViewBag.Message = "Your application description page.";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public int Sun(int a, int b)
        {
            return a + b;
        }
    }

}