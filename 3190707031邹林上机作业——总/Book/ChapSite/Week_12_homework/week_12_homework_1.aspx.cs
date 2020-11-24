using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Week_12_homework_week_12_homework_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MyPetShopDataContext db = new MyPetShopDataContext();
            var results = from r in db.Category
                          select r;
            ddl_Category.DataSource = results;
            ddl_Category.DataBind();
        }
    }

    protected void ddl_Category_SelectedIndexChanged(object sender, EventArgs e)
    {
        lbl_Count.Text = ddl_Category.SelectedValue;
        MyPetShopDataContext db = new MyPetShopDataContext();
        var results = from r in db.Product
                      where r.CategoryId == int.Parse(ddl_Category.SelectedValue)
                      select r;
        gv_Category.DataSource = results;
        gv_Category.DataBind();
    }
}