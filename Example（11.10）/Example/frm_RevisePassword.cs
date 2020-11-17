using System;
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
    public partial class frm_RevisePassword : Form
    {
        public frm_RevisePassword()
        {
            InitializeComponent();

        }
        public frm_RevisePassword(string studentNo) : this()   //构造函数，将上一窗体的账号传入此窗体
        {
            string commandText =
                    $@"SELECT *
                    FROM tb_User WHERE No={studentNo}";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if (sqlHelper.HasRecord)
            {
                txt_StudentNumber.Text = sqlHelper["No"].ToString();
                txt_ProviousPassword.Text = sqlHelper["Password"].ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string commandText =
                    $@"UPDATE tb_User
                    SET Password='{txt_NewPassword.Text.Trim()}'
                    WHERE No='{txt_StudentNumber.Text.Trim()}';";
                SqlHelper sqlHelper = new SqlHelper();
                int rowAffected/*受影响的行有几行*/= sqlHelper.QuickSubmit(commandText);
                if (rowAffected == 1 && txt_ConfirmNewPassword.Text == txt_NewPassword.Text && txt_NewPassword.Text != null 
                    && txt_NewPassword.Text != txt_ProviousPassword.Text) 
                {
                    MessageBox.Show("保存成功！");
                    //txt_ProviousPassword.Text = sqlHelper["Password"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败！");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_NewPassword.Text = null;
            txt_ConfirmNewPassword.Text = null;
        }
    }
}
