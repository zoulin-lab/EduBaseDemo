using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyPetShop.BLL;


public partial class _Default : System.Web.UI.Page
{
    CategoryService categorySrv = new CategoryService();
    ProductService productSrv = new ProductService();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerId"]!=null)
        {
            lblWelcome.Text = "您好，" + Session["CustomerName"].ToString();
            lnkbtnPwd.Visible = true;
            lnkbtnOrder.Visible = true;
            lnkbtnLogout.Visible = true;
        }
        if (!IsPostBack)
        {
            var categories = categorySrv.GetAllCategory();
            foreach (var category in categories)
            {
                ddl_Category.Items.Add(new ListItem(category.Name.ToString(), category.CategoryId.ToString()));
            }
            Bind();
        }
    }
    private void Bind()
    {
        int categoryId = int.Parse(ddl_Category.SelectedValue);
        var products = productSrv.GetProductByCategoryId(categoryId);
        gv_Product.DataSource = products;
        gv_Product.DataBind();
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

    protected void ddl_Category_SelectedIndexChanged(object sender, EventArgs e)
    {
        Bind();
    }
    protected void gv_Product_PageIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        gv_Product.PageIndex = e.NewSelectedIndex;
        Bind();
    }
}