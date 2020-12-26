using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProShow : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString.Count == 0)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Bind();  //调用自定义方法Bind()
        }
    }
    protected void Bind()
    {
        gvProduct.DataSource = GetProductByProductIdOrCategoryId(Request.QueryString["ProductId"], Request.QueryString["CategoryId"]);
        gvProduct.DataBind();
    }

    protected void gvProduct_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        gvProduct.PageIndex = e.NewPageIndex;
        Bind();  //调用自定义方法Bind()
    }
    public List<Product> GetProductByProductIdOrCategoryId(string productId, string categoryId)
    {
        if (!string.IsNullOrEmpty(productId))
        {
            return (from p in db.Product
                    where p.ProductId == int.Parse(productId)
                    select p).ToList();
        }
        else
        {
            return (from p in db.Product
                    where p.CategoryId == int.Parse(categoryId)
                    select p).ToList();
        }
    }
    
}
