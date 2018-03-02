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
        FitnessHubDataContext dc = new FitnessHubDataContext();
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}
        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        public JsonResult UserLogin(EntityMaster e)
        {
            //using (MercuryFitnessHubEntities dc = new MercuryFitnessHubEntities())
            //{

                var user = dc.EntityMasters.Where(a => a.stUserName.Equals(e.stUserName) && a.stPassword.Equals(Convert.ToByte(e.stPassword))).FirstOrDefault();
                return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
           // }
        }
    }
}