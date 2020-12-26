using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
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
        gvOrderItem.DataSource = GetOrderByUserId(Convert.ToInt32(Session["UserId"]));
        gvOrderItem.DataBind();
    }
    public List<Order> GetOrderByUserId(int userId)
    {
        return db.Order.Where(o => o.UserId == userId)
                        .OrderByDescending(o => o.UserId)
                          .ToList();
    }
    protected void GridView1_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        gvOrderItem.PageIndex = e.NewPageIndex;
        Bind();
    }
}