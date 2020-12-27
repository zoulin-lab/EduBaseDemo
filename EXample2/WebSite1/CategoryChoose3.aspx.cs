using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CategoryChoose3 : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] == null)  //用户未登录
        {
            Response.Redirect("~/Login.aspx");
        }
        Bind();
    }
    protected void Bind()
    {
        gvProduct.DataSource = GetAllProduct();
        gvProduct.DataBind();
    }
    public List<Product> GetAllProduct()
    {
        return (from p in db.Product
                where p.CategoryId == 4
                select p).ToList();
    }

    protected void gvProduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvProduct.PageIndex = e.NewPageIndex;
        Bind();
    }
}