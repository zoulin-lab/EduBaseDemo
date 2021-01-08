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
    public partial class frm_TeacherManagement : Form
    {
        public frm_TeacherManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SqlHelper sql = new SqlHelper();
            if (cbxClass.SelectedIndex != -1 && cbxTerm.SelectedIndex != -1 && txtCourse.Text == "") //查班级学期
            {
                string command = $@"SELECT
            ROW_NUMBER()OVER(ORDER BY SS.StartTerm),SS.StartTerm,Class,SS.FacultyRate,StudentComments 
			FROM tb_StudentScore AS SS
			JOIN tb_User AS U ON SS.StudentNo=U.No
			WHERE U.Class='{cbxClass.Text}' AND SS.StartTerm='{cbxTerm.Text}' AND SS.StudentComments!=''
            ORDER BY
			SS.StartTerm,U.Class";
                sql.QuickFill(command,dgvTeacherComments);
            }
            if (cbxClass.SelectedIndex != -1 && cbxTerm.SelectedIndex == -1 && txtCourse.Text == "")//查班级
            {
                string command = $@"SELECT
            ROW_NUMBER()OVER(ORDER BY SS.StartTerm),SS.StartTerm,Class,SS.FacultyRate,StudentComments 
			FROM tb_StudentScore AS SS
			JOIN tb_User AS U ON SS.StudentNo=U.No
			WHERE U.Class='{cbxClass.Text}' AND SS.StudentComments!=''
            ORDER BY
			SS.StartTerm,U.Class";
                sql.QuickFill(command, dgvTeacherComments);
            }
            if (cbxClass.SelectedIndex == -1 && cbxTerm.SelectedIndex != -1 && txtCourse.Text == "")//查学期
            {
                string command = $@"SELECT
            ROW_NUMBER()OVER(ORDER BY SS.StartTerm),SS.StartTerm,Class,SS.FacultyRate,StudentComments 
			FROM tb_StudentScore AS SS
			JOIN tb_User AS U ON SS.StudentNo=U.No
			WHERE SS.StartTerm='{cbxTerm.Text}' AND SS.StudentComments!=''
            ORDER BY
			SS.StartTerm,U.Class";
                sql.QuickFill(command, dgvTeacherComments);
            }
            if (cbxClass.SelectedIndex == -1 && cbxTerm.SelectedIndex == -1 && txtCourse.Text != "")//查课程名称
            {
                string command = $@"SELECT
            ROW_NUMBER()OVER(ORDER BY SS.StartTerm),SS.StartTerm,Class,SS.FacultyRate,StudentComments 
			FROM tb_StudentScore AS SS
			JOIN tb_User AS U ON SS.StudentNo=U.No
			WHERE SS.CourseName='{txtCourse.Text}' AND SS.StudentComments!=''
            ORDER BY
			SS.StartTerm,U.Class";
                sql.QuickFill(command, dgvTeacherComments);
            }
            if (cbxClass.SelectedIndex == -1 && cbxTerm.SelectedIndex == -1 && txtCourse.Text == "")//查所有
            {
                string command = $@"SELECT
            ROW_NUMBER()OVER(ORDER BY SS.StartTerm),SS.StartTerm,Class,SS.FacultyRate,StudentComments 
			FROM tb_StudentScore AS SS
			JOIN tb_User AS U ON SS.StudentNo=U.No
			WHERE SS.StudentComments!=''
            ORDER BY
			SS.StartTerm,U.Class";
                sql.QuickFill(command,dgvTeacherComments);
            }
            tc_Teacher.SelectedTab = tc_Teacher.TabPages[1];
        }

        private void btnTeacherReturn_Click(object sender, EventArgs e)
        {
            tc_Teacher.SelectedTab = tc_Teacher.TabPages[0];
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (cbxClass.SelectedIndex != -1 && cbxTerm.SelectedIndex == -1 && txtCourse.Text == "") 
            {
                SqlHelper sql = new SqlHelper();
                string command = $@"SELECT 
             U.Class,AVG(SS.FacultyRate) AS 评教平均分
			 FROM tb_StudentScore AS SS
			 JOIN tb_User AS U ON SS.StudentNo=U.No
             WHERE U.Class='{cbxClass.Text}'
			 GROUP BY 
			 U.Class";
                sql.QuickFill(command,dgvAverage);
            }
            if (cbxClass.SelectedIndex == -1 && cbxTerm.SelectedIndex != -1 && txtCourse.Text == "")
            {
                SqlHelper sql = new SqlHelper();
                string command = $@"SELECT 
             ss.StartTerm,AVG(SS.FacultyRate) AS 评教平均分
			 FROM tb_StudentScore AS SS
			 JOIN tb_User AS U ON SS.StudentNo=U.No
             WHERE SS.StartTerm='{cbxTerm.Text}'
			 GROUP BY 
			 ss.StartTerm";
                sql.QuickFill(command,dgvAverage);
            }
            if (cbxClass.SelectedIndex == -1 && cbxTerm.SelectedIndex == -1 && txtCourse.Text == "")
            {
                SqlHelper sql = new SqlHelper();
                string command = $@"SELECT 
             SS.StartTerm AS 分类,AVG(SS.FacultyRate) AS 评教平均分
			 FROM tb_StudentScore AS SS
			 JOIN tb_User AS U ON SS.StudentNo=U.No
			 GROUP BY 
			 ss.StartTerm
             UNION
             SELECT 
             U.Class,AVG(SS.FacultyRate) AS 评教平均分
			 FROM tb_StudentScore AS SS
			 JOIN tb_User AS U ON SS.StudentNo=U.No
			 GROUP BY 
			 U.Class";
                sql.QuickFill(command, dgvAverage);
            }
            if (cbxClass.SelectedIndex != -1 && cbxTerm.SelectedIndex != -1 && txtCourse.Text == "")
            {
                MessageBox.Show("只能查询班级或者学期中的一种！");
            }
            tc_Teacher.SelectedTab = tc_Teacher.TabPages[2];
        }

        private void btnAverageReturn_Click(object sender, EventArgs e)
        {
            tc_Teacher.SelectedTab = tc_Teacher.TabPages[0];
        }
    }
    
}
