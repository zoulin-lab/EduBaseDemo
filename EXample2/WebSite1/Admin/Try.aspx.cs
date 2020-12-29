using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FoodDelivery.DAL;

public partial class Admin_Try : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["AdminId"] == null)  //管理员用户未登录
        //{
        //    Response.Redirect("~/Login.aspx");
        //}
    }

    protected void DetailsView1_ItemDeleting(Object sender, DetailsViewDeleteEventArgs e)
    {
        var productCount = GetProductCountByCategoryId(int.Parse(DetailsView1.DataKey.Value.ToString()));
        if (productCount != 0)
        {
            lblError.Text = "Error：该分类下有商品，要删除该分类请先删除商品！";
            e.Cancel = true;
        }
    }
    public int GetProductCountByCategoryId(int categoryId)
    {
        return (from p in db.Product
                where p.CategoryId == categoryId
                select p).Count();
    }
    public void InSertCategory(int categoryId, string name, string descn)           //插入
    {
        Category category = new Category();
        category.CategoryId = categoryId;
        category.CategoryName = name;
        category.Descn = descn;

        db.Category.InsertOnSubmit(category);
        db.SubmitChanges();
    }

    protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        InSertCategory((int)DetailsView1.DataKey.Value, DetailsView1.Rows[1].Cells[2].ToString().Trim(), DetailsView1.Rows[2].Cells[2].ToString().Trim());
        DetailsView1.DataBind();
    }
}