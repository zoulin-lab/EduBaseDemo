using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerId"]!=null)
        {
            lblWelcome.Text = "您好，" + Session["CustomerName"].ToString();
            lnkbtnPwd.Visible = true;
            lnkbtnOrder.Visible = true;
            lnkbtnLogout.Visible = true;
        }
    }

    protected void lnkbtnRegister_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("~/NewUser.aspx");
    }

    protected void lnkbtnLogin_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("~/Login.aspx");
    }

    protected void lnkbtnLogout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("~/Default.aspx");
    }
}
