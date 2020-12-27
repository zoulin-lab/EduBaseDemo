using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Admin_ProductSub : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        if (Session["AdminId"] == null)  //管理员用户未登录
        {
            Response.Redirect("~/Login.aspx");
        }
        if (!IsPostBack)
        {
            Bind();  //调用自定义方法Bind()
        }
    }
    /// 根据从ProductMaster.aspx传递过来的ProductId值，显示与ProductId值相等的商品信息
    /// </summary>
    protected void Bind()
    {
        if (Request.QueryString["ProductId"] == null)
        {
            pnlProduct.Visible = false;
        }
        else
        {
            int productId = int.Parse(Request.QueryString["ProductId"]);
            var product = GetProductByProductId(productId);

            var categories = GetAllCategory();
            foreach (var category in categories)
            {
                ddlCategoryId.Items.Add(new ListItem(category.CategoryName, category.CategoryId.ToString()));
            }

            var suppliers = GetAllSupplier();
            foreach (var supplier in suppliers)
            {
                ddlSuppId.Items.Add(new ListItem(supplier.SuppName, supplier.SuppId.ToString()));
            }

            txtName.Text = product.ProductName;
            ddlCategoryId.SelectedValue = product.CategoryId.ToString();
            txtListPrice.Text = product.ListPrice.ToString();
            txtUnitCost.Text = product.UnitCost.ToString();
            ddlSuppId.SelectedValue = product.SuppId.ToString();
            txtDescn.Text = product.Descn;
            txtQty.Text = product.Qty.ToString();
            imgImage.ImageUrl = product.Image;
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["ProductId"] != null)
        {
            int productId = int.Parse(Request.QueryString["ProductId"]);


            Update(productId, txtName.Text.Trim(),
              int.Parse(ddlCategoryId.SelectedValue), int.Parse(ddlSuppId.SelectedValue),
            decimal.Parse(txtListPrice.Text.Trim()), decimal.Parse(txtUnitCost.Text.Trim()),
            txtDescn.Text.Trim(), int.Parse(txtQty.Text.Trim()));

            //如果有上传文件，就删除原来的图片，保存上传的图片
            if (fupImage.PostedFile.ContentLength != 0)
            {
                string filePath = Server.MapPath("~/") + GetProductByProductId(productId).Image.Substring(2);
                File.Delete(filePath);
                fupImage.PostedFile.SaveAs(filePath);
            }

            //清空页面缓存
            Response.Buffer = true;
            //重定向到Admin文件夹中的Default.aspx
            Response.Redirect("ProductMaster.aspx");
        }
    }
    public Product GetProductByProductId(int productId)
    {
        return (from p in db.Product
                where p.ProductId == productId
                select p).First();
    }
    public void Update(int productId, string name, int categoryId, int suppId, decimal listPrice,
      decimal UnitCost, string descn, int qty)
    {
        Product product = (from p in db.Product
                           where p.ProductId == productId
                           select p).First();
        product.ProductName = name;
        product.CategoryId = categoryId;
        product.SuppId = suppId;
        product.ListPrice = listPrice;
        product.UnitCost = UnitCost;
        product.Descn = descn;
        product.Qty = qty;

        db.SubmitChanges();
    }
    public List<Supplier> GetAllSupplier()
    {
        return (from c in db.Supplier
                select c).ToList();
    }
    public List<Category> GetAllCategory()
    {
        return (from c in db.Category
                select c).ToList();
    }
}