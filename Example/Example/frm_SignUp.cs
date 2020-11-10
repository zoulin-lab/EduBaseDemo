﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace Example
{
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string commandText =
                $@"INSERT tb_User(No, Password)
                   VALUES
                   ('{txt_UserNumber.Text.Trim()}', '{txt_Password.Text.Trim()}');";
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected/*受影响的行有几行*/= sqlHelper.QuickSubmit(commandText);
            if (rowAffected == 1) 
            {
               MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("注册失败！");
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string commandText =
                $@"SELECT 1      
                   FROM tb_User 
                   WHERE NO='{txt_UserNumber.Text.Trim()}' AND Password='{txt_Password.Text.Trim()}';";
            SqlHelper sqlHelper = new SqlHelper();
            int result = sqlHelper.QuickReturn<int>(commandText);
            if (result==1)
            {
                MessageBox.Show("登录成功！");
                frm_ReviseStudentInfo reviseStudentInfo = new frm_ReviseStudentInfo(txt_UserNumber.Text );
                reviseStudentInfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");
                this.txt_Password.Focus();
                this.txt_Password.SelectAll();
            }
        }
    }
}