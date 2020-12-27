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

    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Session.Clear();  //注销当前用户
        Response.Redirect("~/Login.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Session.Clear();  //注销当前用户
        Response.Redirect("~/NewUser.aspx");
    }
}
