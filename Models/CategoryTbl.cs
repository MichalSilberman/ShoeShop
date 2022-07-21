using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CategoryTbl
    {
        public CategoryTbl()
        {
            ShoesTbl = new HashSet<ShoesTbl>();
        }

        public short CategoryId { get; set; }
        public string CategoreyName { get; set; }

        public virtual ICollection<ShoesTbl> ShoesTbl { get; set; }
    }
}
