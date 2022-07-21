//using System;
//using DAL.Models;
//using System.Linq;
//using System.Collections.Generic;

//namespace DAL
//{
//    public class ShoesDAL : IShoesDAL
//    {

//        //מימוש הפונקציות של הממשק
//        //an instance of bd_context
//        ShoesShop_dbContext _db;

//        //a contructor that get an _DbContext object and restart the local props.  
//        public ShoesDAL(ShoesShop_dbContext _db)
//        {
//            this._db = _db;
//        }

//        public List<ShoesTbl> DeleteShoeByID(short id)
//        {
//            var shoeToRemove = _db.ShoesTbl.FirstOrDefault(p => p.ShoeId == id);
//            _db.ShoesTbl.Remove(shoeToRemove);
//            _db.SaveChanges();

//            return _db.ShoesTbl.ToList();
//        }
//        //return all shoes
//        public List<ShoesTbl> GetAllShoes()
//        {
//            return _db.ShoesTbl.ToList();
//        }

//        public List<ShoesTbl> GetProductsByCategory(short CategoryId)
//        {
//            List<ShoesTbl> allShoesInSpecifiesCategory = (List<ShoesTbl>)_db.ShoesTbl.Where(s => s.CategoryId == CategoryId);
//            return allShoesInSpecifiesCategory;
//        }

//        //return shoe by id
//        public ShoesTbl GetShoeById(short id)
//        {//find the she by id
//            var shoe = _db.ShoesTbl.FirstOrDefault(p => p.ShoeId == id);
//            //if there is a shoe, return it!
//            //I didn't understand why we need the if below, we can return shoe.
//            //because if it's null, that it will be returned
//            if (shoe != null)
//                return shoe;
//            return null;
//        }
//        //add new shoe to shoes tbl
//        public List<ShoesTbl> PostNewShoe(ShoesTbl NewShoe)
//        {
//            try
//            {
//                _db.ShoesTbl.Add(NewShoe);
//                _db.SaveChanges();
//                return _db.ShoesTbl.ToList();
//            }
//            catch
//            {
//                return null;
//            }
//        }
//        //update shoe in shoes tbl
//        public List<ShoesTbl> PutShoeById(ShoesTbl shoe)
//        {
//            //find the shoe to change
//            var shoeToUpdate = _db.ShoesTbl.FirstOrDefault(p => p.ShoeId == (short)shoe.ShoeId);
//            //if it's found, change it
//            if (shoeToUpdate != null)
//            {
//                shoeToUpdate.ShoeName = shoe.ShoeName;
//                shoeToUpdate.CategoryId = shoe.CategoryId;
//                shoeToUpdate.Price = shoe.Price;
//                shoeToUpdate.ShoeImage = shoe.ShoeImage;
//                shoeToUpdate.Color = shoe.Color;
//                _db.SaveChanges();
//                return GetAllShoes();
//            }

//            return null;
//        }
    
//    }
//}
