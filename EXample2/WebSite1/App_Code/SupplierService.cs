using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyPetShop.BLL
{

  public class SupplierService
  {
        FoodDeliveryDataContext db = new FoodDeliveryDataContext();
        public List<Supplier> GetAllSupplier()
    {
      return (from c in db.Supplier
              select c).ToList();
    }
    public void InSertSupplier(int suppId, string name, 
      string address,decimal score,string city,string state,string zip,string phone)
    {
      Supplier supplier = new Supplier();
      supplier.SuppId = suppId;
      supplier.SuppName = name;
      supplier.Address = address;
      supplier.City = city;
      supplier.State = state;
      supplier.Phone = phone;
      supplier.Score = score;

      db.Supplier.InsertOnSubmit(supplier);
      db.SubmitChanges();
    }
    public void UpdateSupplier(int suppId, string name, 
      string address,decimal score,string city,string state,string zip,string phone)
    {
      Supplier supplier = (from c in db.Supplier
                           where c.SuppId == suppId
                           select c).First();
            supplier.SuppName = name;
            supplier.Address = address;
            supplier.City = city;
            supplier.State = state;
            supplier.Phone = phone;
            supplier.Score = score;
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
