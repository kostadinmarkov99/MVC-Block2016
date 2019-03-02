using Bulgaria_at_the_Olympics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bulgaria_at_the_Olympics.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var post = db.Posts.OrderByDescending(p => p.Date).Take(3);
            return View(post.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult FirstOlimpics()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult SecondOlimpycs()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ThirdOlimpycs()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Berlin1936()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Helsinki1952()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Melbourne1956()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Rome1960()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Tokio1964()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Mexico1968()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Munich1972()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Monreal1976()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}