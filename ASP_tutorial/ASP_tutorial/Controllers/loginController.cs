using ASP_tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_tutorial.Controllers
{
    public class loginController : Controller
    {
        DB_tutorialEntities db = new DB_tutorialEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult passUser()
        {
            if (Session["id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Index");
        }
    }
}