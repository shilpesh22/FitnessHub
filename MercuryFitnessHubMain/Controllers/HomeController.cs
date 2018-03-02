using MercuryFitnessHubMain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MercuryFitnessHubMain.Controllers
{
    public class HomeController : Controller
    {
        MercuryFitnessHubEntitiess1 dc = new MercuryFitnessHubEntitiess1();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult UserLogin(LoginData e)
        {
            var user = dc.EntityMasters.Where(a => a.stUserName.Equals(e.stUserName) && a.stPassword.Equals(Convert.ToByte(e.stPassword))).FirstOrDefault();
            return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}