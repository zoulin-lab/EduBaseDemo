using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ProductMaster : System.Web.UI.Page
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
    protected void Bind()
    {
        var products = GetAllProduct();
        if (products.Count() == 0)
        {
            pnlProduct.Visible = false;
            lblProErr.Text = "数据库中无商品，请添加！";
        }
        else
        {
            pnlProduct.Visible = true;
            lblProErr.Text = "";
        }
        gvProduct.DataSource = products;
        gvProduct.DataBind();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int productId = 0;
        GridView gvProduct = new GridView();
        gvProduct = (GridView)Page.Master.FindControl("cphRight").FindControl("gvProduct");
        if (gvProduct != null)
        {
            for (int i = 0; i < gvProduct.Rows.Count; i++)
            {
                CheckBox chkChoice = new CheckBox();
                chkChoice = (CheckBox)gvProduct.Rows[i].FindControl("chkChoice");
                if (chkChoice != null)
                {
                    if (chkChoice.Checked)
                    {
                        productId = int.Parse(gvProduct.Rows[i].Cells[1].Text);
                        DeletePro(productId);  //调用方法DeletePro()
                    }
                }

            }
        }
        Bind();
    }

    protected void gvProduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvProduct.PageIndex = e.NewPageIndex;
        Bind();  //调用自定义方法Bind()
    }
    public List<Product> GetAllProduct()
    {
        return (from p in db.Product
                select p).ToList();
    }
    public void DeletePro(int productId)
    {

        var product = (from p in db.Product
                       where p.ProductId == productId
                       select p).First();

        //产品如果已经有用户放入购物车或者下达了订单，该产品删除失败（外键约束）
        //异常: "The DELETE statement conflicted with the REFERENCE constraint "FK__CartItem__ProId". 
        //异常: "The DELETE statement conflicted with the REFERENCE constraint "FK__OrderItem__ProId". 
        db.Product.DeleteOnSubmit(product);
        db.SubmitChanges();
    }
}