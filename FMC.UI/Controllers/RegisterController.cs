using FMC.Entity.Model;
using FMC.Service.Models;
using FMC.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMC.UI.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        private HastaService hastaService = new HastaService();
        private IlceService ilceService = new IlceService();
        private SehirService sehirService = new SehirService();
        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.sehirler = sehirService.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult Register(Hasta hasta)
        {
            
            if (ModelState.IsValid)
            {
                Session["ilceid"] = hasta.Ilce.Id;
                hastaService.Create(hasta);
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
           
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel hasta)
        {
            hastaService.Login(hasta);
            return RedirectToAction("Add", "Randevu");
        }
        public PartialViewResult GetIlceSelect(int sehirId)
        {
            return PartialView(ilceService.GetByIl(sehirId).Select(x=>new SelectListItem {Value=x.Id.ToString(),Text=x.Ad }));
        }
    }
}