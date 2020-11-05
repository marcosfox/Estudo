using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIEntity.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult NovaPagina()
        {
            ViewBag.nome = "Gustavo";
            ViewBag.telefone = "252525252";
            ViewBag.email = "huauhdh@gmail";
            ViewBag.NomeMae = "Thaiz";


            return View();
        }
    }
}
