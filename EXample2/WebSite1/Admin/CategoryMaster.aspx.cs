using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_CategoryMaster : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)  //管理员用户未登录
        {
            Response.Redirect("~/Login.aspx");
        }
    }

    protected void DetailsView1_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
    {
        var productCount = GetProductCountByCategoryId(int.Parse(DetailsView1.DataKey.Value.ToString()));
        if (productCount != 0)
        {
            lblError.Text = "Error：该分类下有商品，要删除该分类请先删除商品！";
            e.Cancel = true;
        }
    }
    public int GetProductCountByCategoryId(int categoryId)
    {
        return (from p in db.Product
                where p.CategoryId == categoryId
                select p).Count();
    }
}