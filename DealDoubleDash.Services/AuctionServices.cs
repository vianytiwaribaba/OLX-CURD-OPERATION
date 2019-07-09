using DealDoubleDash.DataBase;
using DealDoubleDash.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDoubleDash.Services
{
    public class AuctionServices
    {
        public void SaveAuction(tbl_Auction auction)
        {
            DealDoubeDashContext context = new DealDoubeDashContext();

            context.Auctions.Add(auction);

            context.SaveChanges();
        }

        public List<tbl_Auction> Listing()
        {
            DealDoubeDashContext context = new DealDoubeDashContext();

            return context.Auctions.ToList();
           
        }

        public tbl_Auction EditAuction(int ID)
        {
            DealDoubeDashContext context = new DealDoubeDashContext();

            return context.Auctions.Find(ID);
        }

        public void SaveEdit(tbl_Auction auction)
        {
            DealDoubeDashContext context = new DealDoubeDashContext();

            context.Entry(auction).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }

        public void DeleteAuction(tbl_Auction auction)
        {
            DealDoubeDashContext context = new DealDoubeDashContext();

            context.Entry(auction).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();
        }


    }
}
