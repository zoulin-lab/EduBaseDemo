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
        public frm_ReviseStudentInfo(string studentNo) : this()   //构造函数，将上一窗体的账号传入此窗体
        {
            this.txt_Name.Focus();
            this.txt_Name.SelectAll();
            this.StudentNo = studentNo;
            string commandText =
                $@"SELECT * FROM tb_StudentInformation WHERE No='{studentNo}';";
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
            txt_PasswordProtectProblem1.Text = null;
            txt_PasswordProtectProblem2.Text = null;
            txt_Answer1.Text = null;
            txt_Answer2.Text = null;
            txt_PasswordProtectProblem1.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string commandText =
                    $@"UPDATE tb_StudentInformation
                    SET PasswordProtectProblem_1='{txt_PasswordProtectProblem1.Text.Trim()}',
                    PasswordProtectProblem_2='{txt_PasswordProtectProblem2.Text.Trim()}',
                    Answer_1='{txt_Answer1.Text.Trim()}',
                    Answer_2='{txt_Answer2.Text.Trim()}'
                    WHERE No='{txt_StudentNumber.Text}';";
                SqlHelper sqlHelper = new SqlHelper();
                int rowAffected/*受影响的行有几行*/= sqlHelper.QuickSubmit(commandText);
                if (rowAffected == 1 && txt_PasswordProtectProblem1.Text != null && txt_PasswordProtectProblem2.Text != null
                    && txt_Answer1.Text != null && txt_Answer2.Text != null) 
                {
                    MessageBox.Show("保存成功！");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败！");
            }
        }

        private void frm_ReviseStudentInfo_Load(object sender, EventArgs e)
        {
           
        }
    }
}
