using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPetShop.DAL;
namespace MyPetShop.BLL
{
    class CategoryService
    {
        MyPetShopDataContext db = new MyPetShopDataContext();

        public List<Category> GetAllCategory()
        {
            return (from c in db.Category
                    select c).ToList();
        }
    }
}
