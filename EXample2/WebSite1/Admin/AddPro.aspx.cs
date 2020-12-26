using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Admin_AddPro : System.Web.UI.Page
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
            if (IsExitCS())  //调用方法IsExitCS()
            {
                pnlProductMaster.Visible = false;
                lblMsg.Text = "请先添加分类和提供商！";
            }
            else
            {
                pnlProductMaster.Visible = true;
                lblMsg.Text = "";
                Bind();  //调用自定义方法Bind()
            }
        }
    }
    public bool IsExitCS()
    {
        var categories = from c in db.Category
                         select c;
        var suppliers = from c in db.Supplier
                        select c;
        if (categories.Count() == 0 || suppliers.Count() == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public List<Category> GetAllCategory()
    {
        return (from c in db.Category
                select c).ToList();
    }
    public List<Supplier> GetAllSupplier()
    {
        return (from c in db.Supplier
                select c).ToList();
    }
    /// 自定义方法Bind()用于填充“商品分类”下拉列表和“提供商”下拉列表的值
    /// </summary>
    protected void Bind()
    {
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
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (IsExitProduct(txtName.Text.Trim()))  //输入的商品名已存在
        {
            lblNameErr.Text = "商品已经存在";
        }
        else  //添加商品到Product表
        {
            string fileName;
            string fileFolder;
            //string dateTime = "";
            fileName = Path.GetFileName(fupImage.PostedFile.FileName);
            //dateTime += DateTime.Now.Year.ToString();
            //dateTime += DateTime.Now.Month.ToString();
            //dateTime += DateTime.Now.Day.ToString();
            //dateTime += DateTime.Now.Hour.ToString();
            //dateTime += DateTime.Now.Minute.ToString();
            //dateTime += DateTime.Now.Second.ToString();
            //fileName = dateTime + fileName;
            fileFolder = Server.MapPath("~/") + "Images\\" + "\\";
            fileFolder = fileFolder + fileName;
            fupImage.PostedFile.SaveAs(fileFolder);

            Add("~\\Images\\" + "\\" + fileName,
                          txtName.Text.Trim(),
                          int.Parse(ddlCategoryId.SelectedValue), int.Parse(ddlSuppId.SelectedValue),
                          decimal.Parse(txtListPrice.Text.Trim()), decimal.Parse(txtUnitCost.Text.Trim()),
                          txtDescn.Text.Trim(), int.Parse(txtQty.Text.Trim()));

            Response.Redirect("ProductMaster.aspx");
        }
    }
    public bool IsExitProduct(string name)
    {
        var products = from c in db.Product
                       where c.ProductName == name
                       select c;
        if (products.Count() != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Add(string imageFile, string name, int categoryId, int supplierId,
      decimal listPrice, decimal unitCost, string descn, int qty)
    {
        Product product = new Product();
        product.Image = imageFile;
        product.ProductName = name;
        product.CategoryId = categoryId;
        product.SuppId = supplierId;
        product.ListPrice = listPrice;
        product.UnitCost = unitCost;
        product.Descn = descn;
        product.Qty = qty;

        db.Product.InsertOnSubmit(product);
        db.SubmitChanges();
    }
}