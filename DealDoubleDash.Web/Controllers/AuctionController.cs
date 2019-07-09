using DealDoubleDash.Entities;
using DealDoubleDash.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDoubleDash.Web.Controllers
{
    public class AuctionController : Controller
    {

        AuctionServices services = new AuctionServices();

        // GET: Auction
        public ActionResult Index()
        {
            var list = services.Listing();

            if (Request.IsAjaxRequest())
            {
                return PartialView(list);
            }
            else
            {
                return View(list);
            }

            
        }

        public ActionResult create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult create(tbl_Auction auction)
        {
            services.SaveAuction(auction);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int ID)
        {
            var auction = services.EditAuction(ID);

            return PartialView(auction);
        }

        [HttpPost]
        public ActionResult Edit(tbl_Auction auction)
        {
            services.SaveEdit(auction);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int ID)
        {
            var auction = services.EditAuction(ID);

            return View(auction);
        }

        [HttpPost]
        public ActionResult Delete(tbl_Auction auction)
        {
            services.DeleteAuction(auction);

            return  View(auction);
        }


        public ActionResult Details(int ID)
        {
            var auction = services.EditAuction(ID);

            return View(auction);
        }
    }
}