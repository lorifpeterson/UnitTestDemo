using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTestDemo.Dao;
using UnitTestDemo.Outlet;
using UnitTestDemo.Web.Models;

namespace UnitTestDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IOutletDao outletDao)
        {
            OutletDao = outletDao;
        }

        public ActionResult Index()
        {
            var vm = new HomeModel()
                         {
                             Title = "Outlets",
                             DataSource=OutletDao.DataSource,
                             Outlets = OutletDao.GetData()
                         };

            return View(vm);
        }

        public ActionResult About()
        {
            return View();
        }

        private IOutletDao OutletDao { get; set; }

    }

}
