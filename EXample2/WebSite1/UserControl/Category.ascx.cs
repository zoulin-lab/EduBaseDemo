using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControl_Category : System.Web.UI.UserControl
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindTree();
        }
    }
    protected void BindTree()
    {
        var categories = GetAllCategory();
        foreach (var category in categories)
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = category.CategoryName;
            treeNode.Value = category.CategoryId.ToString();
            treeNode.NavigateUrl = "~/ProShow.aspx?CategoryId=" + category.CategoryId.ToString();
            TreeView1.Nodes.Add(treeNode);
            BindTreeChild(treeNode, category.CategoryId);
        }
    }

    /// <summary>
    /// 将指定分类号下的所有商品绑定到子节点中
    /// </summary>
    /// <param name="tn">子节点名</param>
    /// <param name="categoryId">指定分类号</param>
    protected void BindTreeChild(TreeNode tn, int categoryId)
    {
        var products = GetProductByCategoryId(categoryId);
        foreach (var product in products)
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = product.ProductName;
            treeNode.Value = product.ProductId.ToString();
            treeNode.NavigateUrl = "~/ProShow.aspx?ProductId=" + product.ProductId.ToString();
            tn.ChildNodes.Add(treeNode);
        }
    }
    public List<Category> GetAllCategory()
    {
        return (from c in db.Category
                select c).ToList();
    }
    public List<Product> GetProductByCategoryId(int categoryId)
    {
        return (from p in db.Product
                where p.CategoryId == categoryId
                select p).ToList();
    }
}