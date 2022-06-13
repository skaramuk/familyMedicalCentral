using FMC.Entity.Model;
using FMC.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMC.UI.Controllers
{
    public class RandevuController : Controller
    {
        private RandevuService randevuService = new RandevuService();
        // GET: Randevu
        public ActionResult Index()
        {
            return View(randevuService.GetAll());
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Randevu randevu)
        {
            randevuService.Create(randevu);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(Randevu randevu)
        {
            randevuService.Update(randevu);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }        
        [HttpPost]
        public ActionResult Delete(Randevu randevu)
        {
            randevuService.Delete(randevu);
            return RedirectToAction("Index","Home");
        }
    }
}