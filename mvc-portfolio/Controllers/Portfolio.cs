using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_portfolio.Controllers
{
    public class Portfolio : Controller
    {
        public ActionResult About()
        {
            return View(about);
        }
    }
}