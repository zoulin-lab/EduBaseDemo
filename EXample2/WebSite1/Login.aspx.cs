using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        if (!IsPostBack)
        {
            //Login.aspx页面传递过来的查询字符串变量name值非空(即在注册后跳到登录页面时判断你是否注册过)
            if (Request.QueryString["UserName"] != null)
            {
                txtName.Text = Request.QueryString["UserName"];
                lblMsg.Text = "注册成功，请登录!";
            }
        }
    }
    public int CheckLogin(string userName, string password)//检查用户输入的用户名和密码是否正确
    {
        //查询输入的用户名和密码是否正确，若正确则返回相应的用户对象，否则返回null
        User user = (from c in db.User
                             where c.UserName == userName && c.Password == password
                             select c).FirstOrDefault();
        if (user != null)  //用户名和密码正确
        {
            return user.UserId;
        }
        else  //用户名或密码错误
        {
            return 0;
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)//登录按钮
    {
        if (Page.IsValid)
        {
            //调用CheckLogin()方法检查输入的用户名和密码是否正确
            int UserId = CheckLogin(txtName.Text.Trim(), txtPassword.Text.Trim());
            if (UserId > 0)   //用户名和密码正确
            {
                Session.Clear();   //清理Session中保存的内容        
                if (txtName.Text.Trim() == "Admin")  //管理员登录
                {
                    Session["AdminId"] = UserId;
                    Session["AdminName"] = txtName.Text;
                    Response.Redirect("~/Admin/Default.aspx");
                }
                else  //一般用户登录
                {
                    Session["CustomerId"] = UserId;
                    Session["CustomerName"] = txtName.Text;
                    Response.Redirect("~/Default.aspx");
                }
            }
            else  //用户名或密码错误
            {
                lblMsg.Text = "用户名或密码错误！";
            }
        }
    }
}