using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangePassword : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        if (Session["UserId"] == null)  //用户未登录
        {
            Response.Redirect("~/Login.aspx");
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

    public void ChangeUserPassword(int userId, string password)//修改用户ID对应的用户密码
    {
        User user = (from c in db.User
                             where c.UserId == userId
                             select c).First();
        user.Password = password;

        db.SubmitChanges();
    }

    protected void btnChangePwd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            //调用CheckLogin()方法检查Session变量UserName关联的用户名和输入的原密码，返回值大于0表示输入的原密码正确
            if (CheckLogin(Session["UserName"].ToString(), txtOldPwd.Text) > 0)
            {
                ChangeUserPassword(Convert.ToInt32(Session["UserId"]), txtPwd.Text);
                lblMsg.Text = "密码修改成功！";
            }
            else  //输入的原密码不正确
            {
                lblMsg.Text = "原密码不正确！";
            }
        }
    }
}