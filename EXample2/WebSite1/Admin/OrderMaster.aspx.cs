using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_OrderMaster : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminId"] == null)  //管理员用户未登录
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!IsPostBack)
        {
            Bind();  //调用自定义方法Bind()
        }
    }
    /// 显示Order表数据
    /// </summary>
    protected void Bind()
    {
        var orders = GetAllOrder();
        if (orders.Count() == 0)
        {
            pnlOrder.Visible = false;
            lblOrder.Text = "尚无订单！";
        }
        else
        {
            pnlOrder.Visible = true;
            lblOrder.Text = "";
        }
        gvOrder.DataSource = orders;
        gvOrder.DataBind();
    }

    protected void gvOrder_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvOrder.PageIndex = e.NewPageIndex;
        Bind();
    }

    protected void btnAudit_Click(object sender, EventArgs e)
    {

        GridView gvOrder = new GridView();
        gvOrder = (GridView)Page.Master.FindControl("cphLeft").FindControl("gvOrder");
        if (gvOrder != null)
        {
            for (int i = 0; i < gvOrder.Rows.Count; i++)
            {
                CheckBox chkChoice = new CheckBox();
                chkChoice = (CheckBox)gvOrder.Rows[i].FindControl("chkChoice");
                if (chkChoice != null)
                {
                    if (chkChoice.Checked)
                    {
                        int OrderId = int.Parse(gvOrder.Rows[i].Cells[2].Text);
                        UpdateOrder(OrderId);  //调用自定义方法UpdateOrder(）
                    }
                }
            }
        }
        Bind();
    }
    public void UpdateOrder(int orderId)
    {
        Order order = (from o in db.Order
                       where o.OrderId == orderId
                       select o).First();
        order.Status = "已审核";
        db.SubmitChanges();
    }
    public List<Order> GetAllOrder()
    {
        return db.Order.ToList();
    }
}