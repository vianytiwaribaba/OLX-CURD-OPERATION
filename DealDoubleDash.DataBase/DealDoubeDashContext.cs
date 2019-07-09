using DealDoubleDash.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDoubleDash.DataBase
{
    public  class DealDoubeDashContext : DbContext
    {
        public DealDoubeDashContext() : base("DealDoubleDashConnection")
        {
                
        }

        public DbSet<tbl_Auction> Auctions { get; set; }
        public DbSet<tbl_Picture> Pictures { get; set; }
        public DbSet<tbl_AuctionPicture> AuctionPictures { get; set; }
    }
}
