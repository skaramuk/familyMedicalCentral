using FMC.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMC.UI.Controllers
{
    public class DoktorController : Controller
    {
        private DoktorService doktorService = new DoktorService();
        // GET: Doktor
        public ActionResult Index(string isim)
        {
            return View(doktorService.GetAllByIsim(isim));
        }
    }
}