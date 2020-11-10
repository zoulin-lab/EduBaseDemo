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
    public partial class frm_ReviseStudentInfo : Form
    {
        private string StudentNo;   //学号
        public frm_ReviseStudentInfo()
        {
            InitializeComponent();
        }
        public frm_ReviseStudentInfo(string studentNo) : this()   //将上一窗体的账号传入此窗体
        {
            this.StudentNo = studentNo;
            string commandText =
                $@"SELECT * FROM tb_StudentInformation WHERE No='{this.StudentNo}';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if (sqlHelper.HasRecord)
            {
                this.txt_StudentNumber.Text = sqlHelper["No"].ToString();
                this.txt_Name.Text = sqlHelper["Name"].ToString();
                this.txt_PasswordProtectProblem1.Text = sqlHelper["PasswordProtectProblem_1"].ToString();
                this.txt_PasswordProtectProblem2.Text = sqlHelper["PasswordProtectProblem_2"].ToString();
                this.txt_Answer1.Text = sqlHelper["Answer_1"].ToString();
                this.txt_Answer2.Text = sqlHelper["Answer_2"].ToString();
            }
        }
        

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            string commandText=
                $@"INSERT tb_User(PasswordProtectProblem_1, PasswordProtectProblem_2,Answer_1,Answer_2)
                   VALUES
                   ('{txt_PasswordProtectProblem1.Text.Trim()}', '{txt_PasswordProtectProblem2.Text.Trim()}'
                    ,'{txt_Answer1.Text.Trim()}','{txt_Answer2.Text.Trim()}');";
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected/*受影响的行有几行*/= sqlHelper.QuickSubmit(commandText);
            if (rowAffected == 1)
            {
                MessageBox.Show("重置成功！");
            }
            else
            {
                MessageBox.Show("重置失败！");
            }
            
        }
    }
}
