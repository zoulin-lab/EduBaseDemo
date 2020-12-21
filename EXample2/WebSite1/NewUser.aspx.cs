using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewUser : System.Web.UI.Page
{
    FoodDeliveryDataContext db = new FoodDeliveryDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
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
    public bool IsNameExist(string name)//判断输入的用户是否重名
    {
        //通过MyPetShop.DAL数据访问层中的Customer类查询输入的用户名是否重名，若重名则返回用户对象，否则返回null
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
    public void Insert(string name, string password, string email)//向数据库User表中插入新用户记录
    {
        User user = new User
        {
            UserName = name,
            Password = password,
            Email = email
        };
        db.User.InsertOnSubmit(user);
        db.SubmitChanges();
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            //调用IsNameExist()方法判断用户名是否重名
            if (IsNameExist(txtName.Text.Trim()))
            {
                lblMsg.Text = "用户名已存在！";
            }
            else
            {
                //调用Insert()方法插入新用户记录
                Insert(txtName.Text.Trim(), txtPassword.Text.Trim(), txtEmail.Text.Trim());
                Response.Redirect("Login.aspx?UserName=" + txtName.Text);
            }
        }
    }
}