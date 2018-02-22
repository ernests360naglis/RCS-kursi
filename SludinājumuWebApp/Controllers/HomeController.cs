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
            adverts = new List<Sludinājums>();

            Sludinājums ad1 = new Sludinājums();
            ad1.AdvertId = 1;
            ad1.Name = "BMW";
            ad1.AdvertText = "Šis ir labs BMW";
            ad1.Price = 2500;
            ad1.CreationTime = DateTime.Now;

            Sludinājums homeAd = new Sludinājums();
            homeAd.AdvertId = 2;
            homeAd.Name = "Māja";
            homeAd.AdvertText = "Liela māja";
            homeAd.Price = 12000;
            homeAd.CreationTime = new DateTime(1999, 12, 31);

            adverts.Add(ad1);
            adverts.Add(homeAd);
        }
        private List<Sludinājums> adverts;
        //ši f-cija tiek izsaukta, kad tiek pieprasīta WebLapas bāzes ceļš
        // GET: Home (piemēram www.ss.lv)
        public ActionResult Index()
        {
            //izsaucam Viewe f-ciju, lai uzģenerētu html rezultātu no mūsu Index.cshtml faila, 
            //tajā iekšā izmantojot datus, kas pieejami adverts sarakstā
            return View(adverts);
        }

        public ActionResult Advert(int advertId)
        {
            //apskatām katru sludinājumu sarakstā
            foreach(var ad in adverts)
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
    }
}