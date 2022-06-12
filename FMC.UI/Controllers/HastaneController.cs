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
        // GET: Hastane
        public ActionResult Index()
        {
            return View(hastaneService.GetAll());
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Hastane hastane)
        {
            hastaneService.Add(hastane);
            return RedirectToAction("Index");
        }
    }
}