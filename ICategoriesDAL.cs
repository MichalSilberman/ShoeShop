using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL
{

    public interface ICategoriesDAL
    {
        //return type of CategoriesTbl
        //1.//get all Categories
        public List<CategoryTbl> GetAllCategories();
        //2.//get category By Id
        public CategoryTbl getcategoryById(short id);
        //3.//add new category
        public List<CategoryTbl> postNewCategory(CategoryTbl category);
        //4.//update the category 
        public CategoryTbl putCategory(CategoryTbl updatedCategory);
        //5.//delete Category by id
        public List<CategoryTbl> deleteCategory(short id);

    }
}
