using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDelivery.DAL;

namespace FoodDelivery.BLL
{
    public class CategoryService
    {
        FoodDelivery1DataContext db = new FoodDelivery1DataContext();
        public Category GetCategoryById(int categoryId)
        {
            return (from c in db.Category
                    where c.CategoryId == categoryId
                    select c).First();
        }
        public void InSertCategory(int categoryId, string name, string descn)
        {
            Category category = new Category();
            category.CategoryId = categoryId;
            category.CategoryName = name;
            category.Descn = descn;

            db.Category.InsertOnSubmit(category);
            db.SubmitChanges();
        }
        public void UpdateCategory(int categoryId, string name, string descn)
        {
            Category category = (from c in db.Category
                                 where c.CategoryId == categoryId
                                 select c).First();
            category.CategoryName = name;
            category.Descn = descn;

            db.SubmitChanges();
        }
        public void DeleteCategory(int categoryId)
        {
            Category category = (from c in db.Category
                                 where c.CategoryId == categoryId
                                 select c).First();
            db.Category.DeleteOnSubmit(category);
            db.SubmitChanges();
        }
        public List<Category> GetAllCategory()
        {
            return (from c in db.Category
                    select c).ToList();
        }

        public int GetProductCountByCategoryId(int categoryId)
        {
            return (from p in db.Product
                    where p.CategoryId == categoryId
                    select p).Count();
        }
    }
}
