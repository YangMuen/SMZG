using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMZG.Controllers
{
    public class HomeController : SMZGControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "联系方式：";

            return View();
        }
        public ActionResult Swtychina()
        {
           return View();
        }
    }
}