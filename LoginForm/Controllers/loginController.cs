using LoginForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginForm.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        static List<User> sun = new List<User>();
        public ActionResult Index()
        {
            return View(sun);
        }
        public ActionResult Record(User sun)
        {
            return View(sun);
        }
        public ActionResult Login()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Login(User sonu)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", sonu);
            }
            sun.Add(sonu);
            return RedirectToAction("Index");
        }
    }
}