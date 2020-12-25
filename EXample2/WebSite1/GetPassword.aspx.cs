using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetPassword : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    public bool IsNameExist(string name)//判断输入的用户是否重名
    {
        //通过User表查询输入的用户名是否重名，若重名则返回用户对象，否则返回null
        User user = (from c in db.User
                     where c.UserName == name
                     select c).FirstOrDefault();
        if (user != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsEmailExist(string name, string email)//判断是否存在用户输入的用户名和邮箱
    {
        User user = (from c in db.User
                     where c.UserName == name && c.Email == email
                     select c).FirstOrDefault();
        if (user != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ResetPassword(string name, string email)//将密码重置为相应的用户名
    {
        User user = (from c in db.User
                             where c.UserName == name && c.Email == email
                             select c).First();
        user.Password = name;
        db.SubmitChanges();
    }

    protected void btnResetPwd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            //调用IsNameExist()方法判断输入的用户名是否存在
            if (!IsNameExist(txtName.Text.Trim()))
            {
                lblMsg.Text = "用户名不存在！";
            }
            else
            {
                //调用IsEmailExist()方法判断输入的用户名和邮箱是否存在
                if (!IsEmailExist(txtName.Text.Trim(), txtEmail.Text.Trim()))
                {
                    lblMsg.Text = "邮箱不正确！";
                }
                else
                {
                    //调用ResetPassword()方法重置用户密码为用户名
                    ResetPassword(txtName.Text.Trim(), txtEmail.Text.Trim());
                    //新建自定义的EmailSender类实例emailSender对象
                    EmailSender emailSender = new EmailSender(txtEmail.Text.Trim(), txtName.Text.Trim());
                    //调用自定义的EmailSender类中的Send()方法发送邮件
                    emailSender.Send();
                    lblMsg.Text = "密码已发送至邮箱！";
                }
            }
        }
    }
}