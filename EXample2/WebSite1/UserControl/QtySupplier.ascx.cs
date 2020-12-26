using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControl_QtySupplier : System.Web.UI.UserControl
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();
    public List<Product> GetProductBySuppId(int suppId)
    {
        return (from p in db.Product
                where p.SuppId == suppId
                select p).ToList();
    }
    public List<Supplier> GetAllSupplier()
    {
        return (from c in db.Supplier
                where c.Qty > (decimal)2350
                select c).ToList();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindTree();
        }
    }
    /// 将所有分类绑定到TreeView1的父节点中
    protected void BindTree()
    {
        var suppliers = GetAllSupplier();
        foreach (var supplier in suppliers)
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = supplier.SuppName;
            treeNode.Value = supplier.SuppId.ToString();
            treeNode.NavigateUrl = "~/ProShow.aspx?SuppId=" + supplier.SuppId.ToString();
            TreeView1.Nodes.Add(treeNode);
            BindTreeChild(treeNode, supplier.SuppId);
        }
    }
    /// 将指定分类号下的所有商品绑定到子节点中
    protected void BindTreeChild(TreeNode tn, int suppId)
    {
        var products = GetProductBySuppId(suppId);
        foreach (var product in products)
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = product.ProductName;
            treeNode.Value = product.ProductId.ToString();
            treeNode.NavigateUrl = "~/ProShow.aspx?ProductId=" + product.ProductId.ToString();
            tn.ChildNodes.Add(treeNode);
        }
    }
}