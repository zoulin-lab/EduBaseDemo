using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShopCart : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();

    public CartItem Add(int userId, int productId, int qty)
    {
        CartItem cartItem = null;

        Product product = (from p in db.Product
                           where p.ProductId == productId
                           select p).First();
        //当前需要添加的CartItem对象

        cartItem = new CartItem();
        cartItem.UserId = userId;
        cartItem.ProductId = product.ProductId;
        cartItem.ProductName = product.ProductName;
        cartItem.ListPrice = product.ListPrice;
        cartItem.Qty = qty;

        //如果客户当前宠物商品已在购物车内，则只要修改数量即可
        int ExistCartItemCount = (from c in db.CartItem
                                  where c.UserId == userId && c.ProductId == productId
                                  select c).Count();
        if (ExistCartItemCount > 0) //修改
        {
            CartItem existCartItem = (from c in db.CartItem
                                      where c.UserId == userId && c.ProductId == productId
                                      select c).First();
            existCartItem.Qty += qty;//添加
        }
        else
        {
            db.CartItem.InsertOnSubmit(cartItem);
        }

        db.SubmitChanges();
        return cartItem;
    }

    public CartItem Update(int userId, int productId, int qty)
    {
        CartItem cartItem = null;

        //如果客户当前宠物商品已在购物车内，则只要修改数量即可;数量为0时删除该购物项
        cartItem = (from c in db.CartItem
                    where c.UserId == userId && c.ProductId == productId
                    select c).First();
        if (cartItem != null)
        {
            cartItem.Qty = qty;
            //数量为0时删除
            if (cartItem.Qty <= 0)
            {
                db.CartItem.DeleteOnSubmit(cartItem);
            }
            db.SubmitChanges();
        }

        return cartItem;
    }

    public void Delete(int userId, int productId)
    {
        CartItem cartItem = (from c in db.CartItem
                             where c.UserId == userId && c.ProductId == productId
                             select c).First();
        if (cartItem != null)
        {
            db.CartItem.DeleteOnSubmit(cartItem);
            db.SubmitChanges();
        }
    }

    public void Clear(int userId)
    {
        List<CartItem> cartItemList = (from c in db.CartItem
                                       where c.UserId == userId
                                       select c).ToList();
        foreach (CartItem cartItem in cartItemList)
        {
            db.CartItem.DeleteOnSubmit(cartItem);
        }
        db.SubmitChanges();
    }

    public List<CartItem> GetCartItemByUserId(int userId)
    {
        return (from c in db.CartItem
                where c.UserId == userId
                select c).ToList();
    }

    public decimal GetTotalPriceByUserId(int userId)
    {
        List<CartItem> list = (from c in db.CartItem
                               where c.UserId == userId
                               select c).ToList();

        return list.Sum(c => c.ListPrice * c.Qty);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] == null)  //用户未登录
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!IsPostBack)
        {
            if (Session["UserId"] == null)//用户未登录
            {
                Response.Redirect("~/Login.aspx");
            }

            if (Request.QueryString["ProductId"] != null)
            {
                int productId = int.Parse(Request.QueryString["ProductId"]);
                // 将指定商品号的商品添加到购物车
                Add(Convert.ToInt32(Session["UserId"]), productId, 1);
            }
            lblHint.Text = "温馨提示：更改购买数量后，请单击'重新计算'按钮进行更新！";
            Bind();
        }
    }
    protected void Bind()
    {
        lblTotalPrice.Text = GetTotalPriceByUserId(Convert.ToInt32(Session["UserId"])).ToString();

        gvCart.DataSource = GetCartItemByUserId(Convert.ToInt32(Session["UserId"]));
        gvCart.DataBind();

        if (gvCart.Rows.Count != 0)
        {
            pnlCart.Visible = true;
            lblCart.Text = "";
        }
        else
        {
            pnlCart.Visible = false;
            lblCart.Text = "购物车内无商品，请先购物！";
        }
    }

    protected decimal TotalPrice()
    {
        return GetTotalPriceByUserId(Convert.ToInt32(Session["UserId"]));
    }

    public Product GetProductByProductId(int productId)
    {
        return (from p in db.Product
                where p.ProductId == productId
                select p).First();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int productId = 0;
        GridView gvCart = new GridView();
        gvCart = (GridView)Page.Master.FindControl("cphLeft").FindControl("gvCart");
        if (gvCart != null)
        {
            for (int i = 0; i < gvCart.Rows.Count; i++)
            {
                CheckBox chkProduct = new CheckBox();
                chkProduct = (CheckBox)gvCart.Rows[i].FindControl("chkProduct");
                if (chkProduct != null)
                {
                    if (chkProduct.Checked)
                    {
                        productId = int.Parse(gvCart.Rows[i].Cells[1].Text);
                        Delete(Convert.ToInt32(Session["UserId"]), productId); //删除购物车中指定商品编号的商品
                    }
                }
            }
        }
        Bind();  //调用自定义方法Bind()显示购物车中商品
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        Clear(Convert.ToInt32(Session["UserId"]));
        Response.Redirect("Default.aspx");
    }

    protected void btnComputeAgain_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        //循环利用FindControl()找到TextBox控件txtQty，然后判断是否为空值，若非空，则在Product表中查找txtQty所在行商品编号确定的商品，从而比较txtQty中的输入值和商品的库存量
        GridView gvCart = new GridView();
        gvCart = (GridView)Page.Master.FindControl("cphLeft").FindControl("gvCart");
        if (gvCart != null)
        {
            for (int i = 0; i < gvCart.Rows.Count; i++)
            {
                TextBox txtQty = new TextBox();
                txtQty = (TextBox)gvCart.Rows[i].FindControl("txtQty");
                if (txtQty != null)
                {
                    var product = GetProductByProductId(Convert.ToInt32(gvCart.Rows[i].Cells[1].Text));

                    if (int.Parse(txtQty.Text) > product.Qty)  //库存不足
                    {
                        lblError.Text += "Error：库存不足，商品名为 " + product.ProductName + " 的库存数量为 " + product.Qty.ToString() + "<br />";
                    }
                    else
                    {
                        Update(Convert.ToInt32(Session["UserId"]), product.ProductId, Convert.ToInt32(txtQty.Text));  //更新购买数量
                    }
                }

            }
        }
        Bind();  //调用自定义方法Bind()显示购物车中商品
    }

    protected void btnSettle_Click(object sender, EventArgs e)
    {
        //如果不为匿名访问，则转到订单地址提交页面，否则转到登录页面
        if (Session["UserId"] != null)
        {
            Response.Redirect("SubmitCart.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
}
