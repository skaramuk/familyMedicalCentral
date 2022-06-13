using FMC.Entity.Model;
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
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Hasta hasta)
        {
            hastaService.Create(hasta);
            return RedirectToAction("Login");
        }
    }
}