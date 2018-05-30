using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitTestDemo.Web.Models
{
    public class HomeModel
    {
        public string Title { get; set; }
        public IList<string> Outlets { get; set; }
        public string DataSource { get; set; }
    }
}
