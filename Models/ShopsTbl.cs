using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ShopsTbl
    {
        public ShopsTbl()
        {
            ShopDetailsTbl = new HashSet<ShopDetailsTbl>();
        }

        public short ShopNum { get; set; }
        public short? CustId { get; set; }
        public DateTime? ShopDate { get; set; }
        public decimal? Summary { get; set; }

        public virtual CustomersTbl Cust { get; set; }
        public virtual ICollection<ShopDetailsTbl> ShopDetailsTbl { get; set; }
    }
}
