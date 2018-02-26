using SludinājumuWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace SludinājumuWebApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            advertDb = new AdvertDb();
        }
        
        private AdvertDb advertDb;

        //ši f-cija tiek izsaukta, kad tiek pieprasīta WebLapas bāzes ceļš
        // GET: Home (piemēram www.ss.lv)
        public ActionResult Index()
        {
            //izsaucam Viewe f-ciju, lai uzģenerētu html rezultātu no mūsu Index.cshtml faila, 
            //tajā iekšā izmantojot datus, kas pieejami adverts sarakstā
            return View(advertDb.Adverts.ToList());
        }

        public ActionResult Advert(int advertId)
        {
            Sludinājums ad = GetAdvertFromDb(advertId);
            return View(ad);
        }

        private Sludinājums GetAdvertFromDb(int advertId)
        {
            foreach (var ad in advertDb.Adverts)
            {
                //ja sludinājuma id ir tāds pats ko lietotājs pieprasījis,
                if(ad.AdvertId == advertId)
                {
                    //atgriežam atrasto sludinājumu
                    return ad;
                }
            }
            return null;
        }

        public ActionResult CreateAdvert()
        {
            return View();
        }

        //šis atribūts norāda, kašo f-ciju iespējams izsaukt ar POST vaicājumu. Tas ir iespējams atsūtīt viņai datus no formas
        [HttpPost]
        public ActionResult CreateAdvert(Sludinājums advert)
        {
            advert.CreationTime = DateTime.Now;
            advertDb.Adverts.Add(advert);
            advertDb.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EditAdvert(int advertId)
        {
            Sludinājums editableAdvert = GetAdvertFromDb(advertId);
            return View(editableAdvert);
        }

        [HttpPost]
        public ActionResult EditAdvert(Sludinājums advert)
        {
            if (!ModelState.IsValid)
            {
               return View(advert);
            }
            advertDb.Entry(advert).State = EntityState.Modified;
            advertDb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}