using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL
{
    public interface IShoesDAL
    {
        //return type table_nameTbl
        //הגדרת חתימות של פונקציות למימוש במחלקה, הסוג המוחזר הוא של הטבלאות
        //Get All Shoes
        public List<ShoesTbl> GetAllShoes();
        //Get shoe by id
        public ShoesTbl GetShoeById(short id);
        //Add New Shoe
        public List<ShoesTbl> PostNewShoe(ShoesTbl NewShoe);
        //update product by id
        public List<ShoesTbl> PutShoeById(ShoesTbl shoe);
        //Delete Shoe By ID
        public List<ShoesTbl> DeleteShoeByID(short id);
        //GetProductsByCategory
        public List<ShoesTbl> GetProductsByCategory(short CategoryId);

    }
}
