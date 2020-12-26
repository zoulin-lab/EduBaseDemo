using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Transactions;

public partial class SubmitCart : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();

    public List<OrderItem> GetOrderItemByOrderId(int orderId)
    {
        return (from o in db.OrderItem
                where o.OrderId == orderId
                select o).ToList();
    }

    public void CreateOrderFromCart(int userId, string customerName, string addr1, string addr2,
      string city, string state, string phone)
    {
        //本项目使用数据库事务，需要在项目中添加引用动态链接库System.Transactions，并在本页代码上 using System.Transactions;
        using (TransactionScope ts = new TransactionScope())
        {
            //获取购物车内商品项目
            List<CartItem> cartItemList = (from c in db.CartItem
                                           where c.UserId == userId
                                           select c).ToList();

            //根据送货地址信息创建订单头，状态为“未审核”
            Order order = new Order();
            order.UserId = userId;
            order.UserName = customerName;
            order.OrderDate = DateTime.Now;
            order.Address1 = addr1;
            order.Address2 = addr2;
            order.city = city;
            order.State = state;
            order.Phone = phone;
            order.Status = "未审核";

            //根据购物车商品清单创建订单明细
            OrderItem orderItem = null;
            Product product = null;
            foreach (CartItem cartItem in cartItemList)
            {
                //依次添加每件商品为订单明细
                orderItem = new OrderItem();
                orderItem.OrderId = order.OrderId;
                orderItem.ProductName = cartItem.ProductName;
                orderItem.ListPrice = cartItem.ListPrice;
                orderItem.Qty = cartItem.Qty;
                orderItem.TotalPrice = cartItem.Qty * cartItem.ListPrice;
                order.OrderItem.Add(orderItem);

                //修改Product表的商品库存
                product = (from p in db.Product
                           where p.ProductId == cartItem.ProductId
                           select p).First();
                product.Qty = product.Qty - cartItem.Qty;

                //从购物车中删除购物项
                db.CartItem.DeleteOnSubmit(cartItem);
            }

            db.Order.InsertOnSubmit(order);
            db.SubmitChanges();
            ts.Complete(); //提交事务
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        if (Session["UserId"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }
        pnlConsignee.Visible = true;
        lblMsg.Text = "";
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        CreateOrderFromCart(
        Convert.ToInt32(Session["UserId"]),
        Session["UserName"].ToString(),
        txtAddr1.Text.Trim(), txtAddr2.Text.Trim(), txtCity.Text.Trim(),
        txtState.Text.Trim(), txtPhone.Text.Trim());

        pnlConsignee.Visible = false;
        lblMsg.Text = "已经成功结算，谢谢光临！";
    }
}
