using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cision.UnitTestDemo.Dao;
using Cision.UnitTestDemo.Outlet;
using Cision.UnitTestDemo.Web.Models;

namespace Cision.UnitTestDemo.Web.Controllers
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
