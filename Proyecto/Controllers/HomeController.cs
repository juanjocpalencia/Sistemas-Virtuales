using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemasVirtuales.Models;

namespace SistemasVirtuales.Controllers
{
    public class HomeController : Controller
    {
        private SistemasVirtualesEntities db = new SistemasVirtualesEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string pwd,string user)
        {
            var Admin = db.Admins.Where(s=>(s.usuario.Equals(user) || s.correo.Equals(user)) && s.pwd.Equals(pwd)).FirstOrDefault();
            if (Admin != null)
            {
                return RedirectToAction("");
            }
            return View();
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