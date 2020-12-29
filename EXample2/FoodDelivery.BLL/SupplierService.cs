using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDelivery.DAL;
namespace FoodDelivery.BLL
{
    class SupplierService
    {
        FoodDelivery1DataContext db = new FoodDelivery1DataContext();
        public List<Supplier> GetAllSupplier()
        {
            return (from c in db.Supplier
                    select c).ToList();
        }
        public void InSertSupplier(int suppId, string name,
          string address, decimal score, string city, string state, string phone)
        {
            Supplier supplier = new Supplier();
            supplier.SuppId = suppId;
            supplier.SuppName = name;
            supplier.Address = address;
            supplier.Score = score;
            supplier.City = city;
            supplier.State = state;
            supplier.Phone = phone;

            db.Supplier.InsertOnSubmit(supplier);
            db.SubmitChanges();
        }
        public void UpdateSupplier(int suppId, string name,
          string address, decimal score, string city, string state, string phone)
        {
            Supplier supplier = (from c in db.Supplier
                                 where c.SuppId == suppId
                                 select c).First();
            supplier.SuppName = name;
            supplier.Address = address;
            supplier.Score = score;
            supplier.City = city;
            supplier.State = state;
            supplier.Phone = phone;
            db.SubmitChanges();
        }
        public void DeleteSupplier(int suppId)
        {
            Supplier supplier = (from c in db.Supplier
                                 where c.SuppId == suppId
                                 select c).First();
            db.Supplier.DeleteOnSubmit(supplier);
            db.SubmitChanges();
        }
    }
}
