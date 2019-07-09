using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDoubleDash.Entities
{
    public  class tbl_AuctionPicture :BaseEntity
    {
        public int AuctionID { get; set; }

        public int PictureID { get; set; }

        public tbl_Picture Picture { get; set; }


    }
}
