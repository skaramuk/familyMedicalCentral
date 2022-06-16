using FMC.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMC.UI.Controllers
{
    public class IlceController : Controller
    {
        private IlceService ilceService = new IlceService();
        // GET: Ilce
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetIlceList(int sehirid)
        {
            return Json(ilceService.GetByIl(sehirid), JsonRequestBehavior.AllowGet);
        }
    }
}