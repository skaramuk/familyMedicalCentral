using FMC.Entity.Model;
using FMC.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMC.UI.Controllers
{
    public class ReceteController : Controller
    {
        private ReceteService receteService = new ReceteService();
        // GET: Recete
        public ActionResult Index()
        {
            return View(receteService.GetAll());
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Recete recete)
        {
            receteService.Create(recete);
            return RedirectToAction("Index", "Recete");
        }
        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(Recete recete)
        {
            receteService.Update(recete);
            return RedirectToAction("Index", "Recete");
        }
        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Recete recete)
        {
            receteService.Delete(recete);
            return RedirectToAction("Index", "Recete");
        }
    }
}