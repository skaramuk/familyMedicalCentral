using FMC.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMC.UI.Controllers
{
    public class SehirController : Controller
    {
        private SehirService sehirService = new SehirService();
        // GET: Sehir
        public ActionResult Index()
        {
            return View(sehirService.GetAll());
        }
    }
}