using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDoubleDash.Entities
{
    public class tbl_Auction : BaseEntity
    {
       
        public string Title { get; set; }

        public string Description { get; set; }

        public decimal ActualAmount { get; set; }

        public DateTime StartingTime { get; set; }

        public DateTime EndindTime { get; set; }

        public List<tbl_AuctionPicture> AuctionPictures { get; set; }

    }
}
