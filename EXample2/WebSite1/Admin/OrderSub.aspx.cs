using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderSub : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)  //管理员用户未登录
        {
            Response.Redirect("~/Login.aspx");
        }
        if (Request.QueryString.Count == 0)
        {
            //跳转到Admin文件夹下的Default.aspx
            Response.Redirect("~/Admin/AddPro.aspx");
        }
        else
        {
            Bind();  //调用自定义方法Bind()
        }
    }
    protected void Bind()
    {
        int orderId = int.Parse(Request.QueryString["OrderId"]);
        var order = GetOrderListByOrderId(orderId);
        var orderItem = GetOrderItemByOrderId(orderId);
        gvOrder.DataSource = order;
        gvOrder.DataBind();
        gvOrderItem.DataSource = orderItem;
        gvOrderItem.DataBind();
    }
    protected void gvOrderItem_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        gvOrderItem.PageIndex = e.NewPageIndex;
        Bind();  //调用自定义方法Bind()
    }
    public List<Order> GetOrderListByOrderId(int orderId)
    {
        return (from o in db.Order
                where o.OrderId == orderId
                select o).ToList();
    }

    public List<OrderItem> GetOrderItemByOrderId(int orderId)
    {
        return (from o in db.OrderItem
                where o.OrderId == orderId
                select o).ToList();
    }
}