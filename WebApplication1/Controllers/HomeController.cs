using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult ViewUsers()
        {
            //ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult ViewUsersId()
        {
            //ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult ViewPosts()
        {
            //ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult ViewPostsId()
        {
            //ViewBag.Title = "Home Page";
            return View();
        }
    }
}
