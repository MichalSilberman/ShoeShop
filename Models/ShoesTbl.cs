using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ShoesTbl
    {
        public ShoesTbl()
        {
            ShopDetailsTbl = new HashSet<ShopDetailsTbl>();
        }

        public short ShoeId { get; set; }
        public string ShoeName { get; set; }
        public short? CategoryId { get; set; }
        public decimal? Price { get; set; }
        public string ShoeImage { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int? AmountOnStock { get; set; }

        public virtual CategoryTbl Category { get; set; }
        public virtual ICollection<ShopDetailsTbl> ShopDetailsTbl { get; set; }
    }
}
