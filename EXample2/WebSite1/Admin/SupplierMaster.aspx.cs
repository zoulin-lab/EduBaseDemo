using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FoodDelivery.BLL;

public partial class Admin_SupplierMaster : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)  //管理员用户未登录
        {
            Response.Redirect("~/Login.aspx");
        }
    }
    public List<Supplier> GetAllSupplier()
    {
        return (from c in db.Supplier
                select c).ToList();
    }
    protected void DetailsView1_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
    {
        var productCount = GetProductCountBySupplierId(int.Parse(DetailsView1.DataKey.Value.ToString()));
        
        if (productCount != 0)
        {
            lblError.Text = "Error：该分类下有商品，请先删除商品！";
            e.Cancel = true;
        }
    }
    public int GetProductCountBySupplierId(int supplierId)
    {
        return (from p in db.Product
                where p.SuppId == supplierId
                select p).Count();
    }
    public void InSertSupplier(int suppId, string name,
     string addr1,  string city, string state, string zip, string phone)
    {
        Supplier supplier = new Supplier();
        supplier.SuppId = suppId;
        supplier.SuppName = name;
        supplier.Address = addr1;
        supplier.City = city;
        supplier.State = state;
        supplier.Phone = phone;
        db.Supplier.InsertOnSubmit(supplier);
        db.SubmitChanges();
    }
}