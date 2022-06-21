using FMC.Entity.Model;
using FMC.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMC.UI.Controllers
{
    public class HastaneController : Controller
    {
        private HastaneService hastaneService = new HastaneService();
        private IlceService ilceService = new IlceService();
        // GET: Hastane
        public ActionResult Index()
        {
            return View(hastaneService.GetAll());
        }
    }
}