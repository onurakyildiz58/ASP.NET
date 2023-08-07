using ASP_tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_tutorial.Controllers
{
    public class userController : Controller
    {
        DB_tutorialEntities db = new DB_tutorialEntities();

        public ActionResult Index()
        {
            int userID = Convert.ToInt32(Session["id"]);
            if (userID == 0)
            {
                return RedirectToAction("index", "login");
            }
            var user = db.TBL_users.Find(userID);
            return View(user);
        }
    }
}