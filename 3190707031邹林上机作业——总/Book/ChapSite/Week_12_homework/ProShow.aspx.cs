using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Week_12_homework_ProShow : System.Web.UI.Page
{
    MyPetShopDataContext db = new MyPetShopDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var categories = from c in db.Category
                             select new
                             {
                                 c.CategoryId,
                                 c.Name
                             };
            foreach (var category in categories)
            {
                ddl_Category.Items.Add(new ListItem(category.Name.ToString(),
                    category.CategoryId.ToString()));
            }
            Bind();
        }
    }

    protected void Bind()
    {
        int categoryId = int.Parse(ddl_Category.SelectedValue);
        var products = from p in db.Product
                       where p.CategoryId == categoryId
                       select p;
        gv_Product.DataSource = products;
        gv_Product.DataBind();
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