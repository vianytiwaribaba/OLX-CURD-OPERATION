using DealDoubleDash.DataBase;
using DealDoubleDash.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDoubleDash.Web.Controllers
{
    public class HomeController : Controller
    {
        DealDoubeDashContext context = new DealDoubeDashContext();

        AuctionServices services = new AuctionServices();

        public ActionResult Index()
        {
            var allauction = services.Listing();

            //var allauction = context.Auctions.ToList();

            return View(allauction);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}