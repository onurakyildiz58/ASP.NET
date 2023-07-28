using ASP_tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace ASP_tutorial.Controllers
{
    public class registerController : Controller
    {
        DB_tutorialEntities db = new DB_tutorialEntities();

        public ActionResult Index()
        {
            return View();
        }
        
        public JsonResult saveData(TBL_users model)
        {
            model.isExists = false;
            model.createdAt = DateTime.Now;
            db.TBL_users.Add(model);
            db.SaveChanges();
            return Json("Kayıt Başarılı", JsonRequestBehavior.AllowGet);

        }
    }
}