using System;
using DAL.Models;
using System.Linq;
using System.Collections.Generic;

namespace DAL
{
    public class CategoriesDAL: ICategoriesDAL
    {
        //implement interface's functions

        //an instance of bd_context
        ShoesShop_dbContext _db;
        //constructor
        public CategoriesDAL(ShoesShop_dbContext _db)
        {
            this._db = _db;
        }
        ////return type is CategoriesTbl
        ///
        //1.//get all Categories
        //public List<CategoryTbl> GetAllCategories();
        public List<CategoryTbl> GetAllCategories()
        {
            return _db.CategoryTbl.ToList();
        }
        //2.//get category By Id
        //public CategoryTbl getcategoryById(short id);
        public CategoryTbl getcategoryById(short id)
        {
            var category = _db.CategoryTbl.FirstOrDefault(c => c.CategoryId == id);
                    if (category != null)
                        return category;
                    return null;
        }
        //3.//add new category
        //public List<CategoryTbl> postNewCategory(CategoryTbl category);
        public List<CategoryTbl> postNewCategory(CategoryTbl category) 
        {
            _db.CategoryTbl.Add(category);
            _db.SaveChanges();
            var newList = _db.CategoryTbl.ToList();
            return newList;
        }
        //4.//update the category 
        //return only the updated object
        //public CategoryTbl putCategory(CategoryTbl updatedCategory);
        public CategoryTbl putCategory(CategoryTbl updatedCategory)
        {
            var category = _db.CategoryTbl.FirstOrDefault(c => c.CategoryId == updatedCategory.CategoryId);
            if(category != null)
            {
                category.CategoreyName = updatedCategory.CategoreyName;
                _db.SaveChanges();
            }
            return category;
        }

        //5.//delete Category by id
        //public List<CategoryTbl> deleteCategory(short id);
        public List<CategoryTbl> deleteCategory(short id)
        {
            var category = _db.CategoryTbl.FirstOrDefault(c => c.CategoryId == id);
            _db.CategoryTbl.Remove(category);
            _db.SaveChanges();
            return _db.CategoryTbl.ToList();
        }

    }
}
