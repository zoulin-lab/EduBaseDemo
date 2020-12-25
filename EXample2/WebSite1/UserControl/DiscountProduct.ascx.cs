using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControl_DiscountProduct : System.Web.UI.UserControl
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();

    public List<Product> GetNewProduct(int count)
    {
        return (from p in db.Product
                where p.Status == "折扣"
                orderby p.ProductId ascending
                select p).Take(count).ToList();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        gvProduct.DataSource = GetNewProduct(7);
        gvProduct.DataBind();
    }
}