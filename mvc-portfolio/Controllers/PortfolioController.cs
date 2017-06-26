using mvc_portfolio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        private ProjectRepository _projectRepository = null;

        public PortfolioController()
        {
            _projectRepository = new ProjectRepository();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Projects()
        {
            var projects = _projectRepository.GetProjects();
            return View(projects);
        }
    }
}