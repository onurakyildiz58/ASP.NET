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

        public JsonResult checkUser(TBL_users model)
        {
            string result = "Başarısız";
            var data = db.TBL_users.Where(x => x.mail == model.mail && x.password == model.password).SingleOrDefault();
            if (data != null)
            {
                Session["id"] = data.id.ToString();
                Session["name"] = data.name.ToString();
                result = "Başarılı";
            }
            return Json(result, JsonRequestBehavior.AllowGet);
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