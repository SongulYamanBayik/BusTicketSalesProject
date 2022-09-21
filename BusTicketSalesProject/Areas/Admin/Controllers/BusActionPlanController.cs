using Business_Layer.Concrete;
using DAL.EntityFramework;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusTicketSalesProject.Areas.Admin.Controllers
{
    public class BusActionPlanController : Controller
    {

        BusManager busManager = new BusManager(new EFBusDal());
        // GET: Admin/BusActionPlan
        [HttpGet]
        public ActionResult Index()
        {
            var value = busManager.TGetBusListByStatus();
            return View(value);
        }

        public ActionResult ChangeStatus(int id)
        {

            busManager.TChangeStatu(id);
            //return RedirectToAction("Index", "BusActionPlan");
            return RedirectToAction("Index", "Admin/BusActionPlan");
        }


    }
}