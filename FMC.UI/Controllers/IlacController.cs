using FMC.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMC.UI.Controllers
{
    public class IlacController : Controller
    {
        // GET: Ilac
        private IlacService ilacService = new IlacService();
        public ActionResult Index()
        {
            return View(ilacService.GetAll());
        }
    }
}