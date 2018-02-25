using SludinājumuWebApp.Models;
using System;
using System.Collections.Generic;
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

        private List<Sludinājums> adverts;
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
            //apskatām katru sludinājumu sarakstā
            foreach(var ad in advertDb.Adverts)
            {
                //ja sludinājuma id ir tāds pats ko lietotājs pieprasījis,
                if(ad.AdvertId == advertId)
                {
                    //tad izveidojam skatu izmantojot šī sludinājuma datus un atgriežam lietotājam
                    return View(ad);
                }
            }

            return View();
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
    }
}