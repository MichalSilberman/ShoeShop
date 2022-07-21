using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ShopDetailsTbl
    {
        public short ShopDetailId { get; set; }
        public short? ShopNum { get; set; }
        public short? ShoeCode { get; set; }
        public int? Amount { get; set; }

        public virtual ShoesTbl ShoeCodeNavigation { get; set; }
        public virtual ShopsTbl ShopNumNavigation { get; set; }
    }
}
