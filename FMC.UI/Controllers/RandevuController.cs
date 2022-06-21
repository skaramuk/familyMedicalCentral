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
        private HastaneService hastaneService = new HastaneService();
        private HastaService hastaService = new HastaService();
        private IlceService ilceService = new IlceService();
        private SehirService sehirService = new SehirService();
        private DoktorService doktorService = new DoktorService();
        // GET: Randevu
        public ActionResult Index()
        {
            return View(randevuService.GetAll());
        }
        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.sehirler = sehirService.GetAll();
            ViewBag.hastaneler = hastaneService.GetAll();
            ViewBag.doktorlar = doktorService.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult Add(Randevu randevu)
        {
            randevu.Hasta=hastaService.GetByKimlikNo(randevu.Hasta.KimlikNo);
            randevu.Aktif = true;
            randevuService.Create(randevu);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Update(int randevuId)
        {
            return View(randevuService.GetById(randevuId));
        }
        [HttpPost]
        public ActionResult Update(Randevu randevu)
        {
            randevuService.Update(randevu);
            return RedirectToAction("Index", "Home");
        }
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
        public ActionResult Search()
        {
            return View();
        }
        public ActionResult GetRandevu(int? randevuId)
        {
            if (randevuId.HasValue)
            {
                ViewBag.randevu = randevuService.GetById(randevuId.Value);
            }
            return View();
        }
        public PartialViewResult GetIlceSelect(int sehirId)
        {
            return PartialView(ilceService.GetByIl(sehirId).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Ad }));
        }
        public PartialViewResult GetHastaneSelect(int ilceId)
        {
            return PartialView(hastaneService.GetByIlce(ilceId).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Ad }));
        }
        public PartialViewResult GetDoktorSelect(int hastaneId)
        {
            return PartialView(doktorService.GetByHastane(hastaneId).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Ad+" "+x.Soyad}));
        }
        public PartialViewResult GetRandevuList(string tc)
        {
            return PartialView(randevuService.GetAllByKimlik(tc));
        }
        public ActionResult DeleteById(int Id)
        {
            Randevu randevu = randevuService.GetById(Id);
            randevuService.Delete(randevu);
            return RedirectToAction("Search");
        }
    }
}