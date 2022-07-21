using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CustomersTbl
    {
        public CustomersTbl()
        {
            ShopsTbl = new HashSet<ShopsTbl>();
        }

        public short CustId { get; set; }
        public string CustName { get; set; }
        public string CustPassword { get; set; }
        public string CreditCardNumber { get; set; }

        public virtual ICollection<ShopsTbl> ShopsTbl { get; set; }
    }
}
