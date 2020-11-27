using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPetShop.DAL;
namespace MyPetShop.BLL
{
    public class ProductService
    {
        MyPetShopDataContext db = new MyPetShopDataContext();

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return (from p in db.Product
                    where p.CategoryId == categoryId
                    select p).ToList();
        }
    }
}
