using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SelectPage : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();  //调用自定义方法Bind()
        }
    }
    public List<Product> GetProductBySearchText(string searchText)
    {
        return (from p in db.Product
                where SqlMethods.Like(p.ProductName, "%" + searchText + "%")
                select p).ToList();
    }
    protected void Bind()
    {
        
        if (Request.QueryString["SearchText"] != null)
        {
            string strSearchText = Request.QueryString["SearchText"].ToString();
            gvProduct.DataSource = GetProductBySearchText(strSearchText);
            gvProduct.DataBind();
        }
        else
        {
            lblError.Text = "无搜索结果！";
        }
    }

    protected void gvProduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvProduct.PageIndex = e.NewPageIndex;
        Bind();  //调用自定义方法Bind()
    }
    public string[] GetStrings(string prefixText, int count)
    {
        //调用GetProductBySearchText()方法模糊查找商品名中包含关联文本框输入值的商品
        var products = GetProductBySearchText(prefixText);
        //将查找到商品的商品名填充到列表类中
        List<String> list = new List<String>(count);
        foreach (var product in products)
        {
            list.Add(product.ProductName);
        }
        return list.ToArray();
    }

    protected void imgbtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        // 如果搜索框不为空，以查询字符串形式传递搜索文本到Search.aspx
        string strQuery = "";
        if (txtSearch.Text.Trim() == "")
        {
            strQuery = "";
        }
        else
        {
            strQuery = "?SearchText=" + txtSearch.Text.Trim();
        }
        Response.Redirect("~/SelectPage.aspx" + strQuery);
    }
}