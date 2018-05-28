using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Teste.VS2017.Presentation.MvcWebApp.Controllers
{
    //[Authorize(Roles = "Admin,Usuario")]
    //[RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "About";

            return View();
        }
        public ActionResult Portifolio()
        {
            ViewBag.Message = "Clientes";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Entre em Contato";

            return View();
        }
    }
}
