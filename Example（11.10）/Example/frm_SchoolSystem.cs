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
    public partial class frm_SchoolSystem : Form
    {
        private string StudentNo;

        public frm_SchoolSystem()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        public frm_SchoolSystem(string studentNo) : this()//构造函数
        {
            //修改个人信息页面
            this.StudentNo = studentNo;
            string commandText1 =
                $@"SELECT * FROM tb_StudentInformation WHERE No='{studentNo}';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText1);
            if (sqlHelper.HasRecord)
            {
                this.txt_StudentNo.Text = sqlHelper["No"].ToString();
                this.txt_Name.Text = sqlHelper["Name"].ToString();
                this.txt_PasswordProtectProblem1.Text = sqlHelper["PasswordProtectProblem_1"].ToString();
                this.txt_PasswordProtectProblem2.Text = sqlHelper["PasswordProtectProblem_2"].ToString();
                this.txt_Answer1.Text = sqlHelper["Answer_1"].ToString();
                this.txt_Answer2.Text = sqlHelper["Answer_2"].ToString();
                this.txtMyName.Text= sqlHelper["Name"].ToString();
                this.txtMyNumber.Text= sqlHelper["No"].ToString();
            }
            //修改密码页面
            string commandText2 =
                    $@"SELECT *
                    FROM tb_User WHERE No={studentNo}";
            SqlHelper sqlHelper2 = new SqlHelper();
            sqlHelper2.QuickRead(commandText2);
            if (sqlHelper2.HasRecord)
            {
                txt_StudentNumber.Text = sqlHelper2["No"].ToString();
                txt_ProviousPassword.Text = sqlHelper2["Password"].ToString();
            }
            //学籍卡片页面
            string commandText3 =
                $@"SELECT * FROM tb_StatusCard AS SC WHERE SC.No='{studentNo}'";
            SqlHelper sqlHelper3 = new SqlHelper();
            sqlHelper3.QuickRead(commandText3);
            if (sqlHelper3.HasRecord)
            {
                txtStuNo.Text = sqlHelper3["No"].ToString();
                txtStuName.Text= sqlHelper3["StuName"].ToString();
                txtStuGender.Text= sqlHelper3["StuGender"].ToString();
                txtStuBirthday.Text= sqlHelper3["StuBirthday"].ToString();
                txtStuNation.Text= sqlHelper3["StuNation"].ToString();
                txtStuClass.Text= sqlHelper3["StuClass"].ToString();
                txtStuMajor.Text= sqlHelper3["StuMajor"].ToString();
                txtStuDepartment.Text= sqlHelper3["StuDepartment"].ToString();
                txtStuToSchool.Text= sqlHelper3["StuTOSchoolDatetime"].ToString();
                txtStuLengthOfSchooling.Text= sqlHelper3["StuLengthOfSchooling"].ToString();
                txtStuMajorDirection.Text= sqlHelper3["StuMajorDirection"].ToString();
                txtStuPoliticsStatus.Text = sqlHelper3["StuPoliticsStatus"].ToString();
                txtStuLearningHierarchy.Text= sqlHelper3["StuLearningHierarchy"].ToString();
                txtStuHomePhone.Text= sqlHelper3["StuHomePhone"].ToString();
                txtStuHomeAddress.Text= sqlHelper3["StuHomeAddress"].ToString();
                txtStuRailwayStation.Text= sqlHelper3["StuRailwayStation"].ToString();
                txtStuPhone.Text= sqlHelper3["StuPhone"].ToString();
                txtStuId.Text= sqlHelper3["StuId"].ToString();

            }

        }
        private void button_PickCourse_Click(object sender, EventArgs e)
        {
            //学生选课中心 studentpickcourse = new 学生选课中心();
            //studentpickcourse.ShowDialog();
        }

        private void button_StudentEvaluation_Click(object sender, EventArgs e)
        {
            //学生评教 studentevaluation = new 学生评教();
            //studentevaluation.ShowDialog();
        }

        private void button_TrainMeans_Click(object sender, EventArgs e)
        {
            //培养方案 trainprogram = new 培养方案();
            //trainprogram.ShowDialog();
        }

        private void button_ReceivedMessage_Click(object sender, EventArgs e)
        {
            tcMyDesktop.SelectedTab = tcMyDesktop.TabPages[1];
        }

        private void button_ReceivedNotice_Click(object sender, EventArgs e)
        {
            tcMyDesktop.SelectedTab = tcMyDesktop.TabPages[0];
        }

        private void button_CourseGradeInquire_Click(object sender, EventArgs e)
        {
            //课程成绩查询 ke程成绩查询 = new 课程成绩查询();
            //ke程成绩查询.ShowDialog();
        }

        private void button_MyCourseGradeInquire_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[8];
        }

        private void button_MyReceivedMessage_Click(object sender, EventArgs e)
        {
            tcMyDesktop.SelectedTab = tcMyDesktop.TabPages[1];
        }

        private void button_MyReceivedNotice_Click(object sender, EventArgs e)
        {

            tcMyDesktop.SelectedTab = tcMyDesktop.TabPages[0];
        }

        private void button_ChangePersonalInformation_Click(object sender, EventArgs e)
        {
            tcMyDesktop.SelectedTab = tcMyDesktop.TabPages[2];
        }

        private void button_ChangeCode_Click(object sender, EventArgs e)
        {
            tcMyDesktop.SelectedTab = tcMyDesktop.TabPages[3];
        }

        private void button_SeeMyTeachingWeek_Click(object sender, EventArgs e)
        {
            tcMyDesktop.SelectedTab = tcMyDesktop.TabPages[4];
        }

        private void button_TeachingWeek_Click(object sender, EventArgs e)
        {
            //教学周历查看 jiao学周历查看 = new 教学周历查看();
            //jiao学周历查看.ShowDialog();
        }

        private void button_InstructionalTrainingProgram_Click(object sender, EventArgs e)
        {
            //指导培养方案 zhi导培养方案 = new 指导培养方案();
            //zhi导培养方案.ShowDialog();
        }

        private void button_TeachingProcessInquire_Click(object sender, EventArgs e)
        {
            //教学进程查看 jiao学进程查看 = new 教学进程查看();
            //jiao学进程查看.ShowDialog();
        }

        private void button_CarryPlan_Click(object sender, EventArgs e)
        {
            //执行计划 zhi行计划 = new 执行计划();
            //zhi行计划.ShowDialog();
        }

        private void button_TheExperimentScheduleInquire_Click(object sender, EventArgs e)
        {
            //实验课表查询 shi验课表查询 = new 实验课表查询();
            //shi验课表查询.ShowDialog();
        }

        private void button_TheTeacherScheduleInquire_Click(object sender, EventArgs e)
        {
            //教师课表查询 jiao师课表查询 = new 教师课表查询();
            //jiao师课表查询.ShowDialog();
        }

        private void button_TheCourseScheduleInquire_Click(object sender, EventArgs e)
        {
            //课程课表查询 ke程课表查询 = new 课程课表查询();
            //ke程课表查询.ShowDialog();
        }

        private void button_SemesterTheorySchedule_Click(object sender, EventArgs e)
        {
            //学期理论课表 xue期理论课表 = new 学期理论课表();
            //xue期理论课表.ShowDialog();
        }

        private void button_TheClassScheduleInquire_Click(object sender, EventArgs e)
        {
            //班级课表查询 ban级课表查询 = new 班级课表查询();
            //ban级课表查询.ShowDialog();
        }

        private void button_TheClassroomScheduleInquire_Click(object sender, EventArgs e)
        {
            //教室课表查询 jiao室课表查询 = new 教室课表查询();
            //jiao室课表查询.ShowDialog();
        }

        private void button_TeachingPlanInquire_Click(object sender, EventArgs e)
        {
            //授课计划查询 shou课计划查询 = new 授课计划查询();
            //shou课计划查询.ShowDialog();
        }

        private void panel_StudentEvaluation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_TestGrade_Click(object sender, EventArgs e)
        {
            //考试成绩 kao试成绩 = new 考试成绩();
            //kao试成绩.ShowDialog();
        }

        private void button_MyClassTestGrade_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[9];
        }

        private void button_MyOSCEGrade_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[10];
        }

        private void button_StudentStatusInforationCard_Click(object sender, EventArgs e)
        {
            //学籍卡片 xue级卡片 = new 学籍卡片();
            //xue级卡片.ShowDialog();
        }

        private void button_MyStatusCard_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[0];
        }

        private void button_SocialTestRegistration_Click(object sender, EventArgs e)
        {
            //社会考试报名 she会考试报名 = new 社会考试报名();
            //she会考试报名.ShowDialog();
        }

        private void button_MySocialTestRegistration_Click(object sender, EventArgs e)
        {
            //社会考试报名 she会考试报名 = new 社会考试报名();
            //she会考试报名.ShowDialog();
        }

        private void button_MyStatusManagement_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[1];
        }

        private void button_MyStatusEarningInquire_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[2];
        }

        private void button_MyStatusDynamicInformatonn_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[3];
        }

        private void button_ProfessionalShunt_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[4];
        }

        private void button_ExchangeStudentApplication_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[5];
        }

        private void button_ExchangeStudentGrade_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[6];
        }

        private void button_ExchangeStudentPickCourse_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[7];
        }

        private void button_MyGradeFirmlyBelieve_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[11];
        }

        private void button_InquirePickCourse_Click(object sender, EventArgs e)
        {
            //查询选课课程 cha询选课课程 = new 查询选课课程();
            //cha询选课课程.ShowDialog();
        }

        private void button_StudentPickCoursePlace_Click(object sender, EventArgs e)
        {
            //学生选课中心 xue生选课中心 = new 学生选课中心();
            //xue生选课中心.ShowDialog();
        }

        private void button_StudentPreselectionManagement_Click(object sender, EventArgs e)
        {
            //学生预选管理 xue生预选管理 = new 学生预选管理();
            //xue生预选管理.ShowDialog();
        }

        private void button_ClassroomBorrowApplication_Click(object sender, EventArgs e)
        {
            //教室借用申请 jiao室借用申请 = new 教室借用申请();
            //jiao室借用申请.ShowDialog();
        }

        private void button_TheTeachingSchedule_Click(object sender, EventArgs e)
        {
            //授课计划查询 shou课计划查询 = new 授课计划查询();
            //shou课计划查询.ShowDialog();
        }

        private void button_TeachingProcessConclusion_Click(object sender, EventArgs e)
        {
            //教学进度汇总 jiao学进度汇总 = new 教学进度汇总();
            //jiao学进度汇总.ShowDialog();
        }

        private void button_StudentStudySituatiion_Click(object sender, EventArgs e)
        {
            //学生修读情况 xue生修读情况 = new 学生修读情况();
            //xue生修读情况.ShowDialog();
        }

        private void button_StudentTextbookPick_Click(object sender, EventArgs e)
        {
            //学生教材选用 xue生教材选用 = new 学生教材选用();
            //xue生教材选用.ShowDialog();
        }

        private void button_TextbookAccountingInformation_Click(object sender, EventArgs e)
        {
            //教材账目信息 jiao材账目信息 = new 教材账目信息();
            //jiao材账目信息.ShowDialog();
        }

        private void button_TextbookPurchase_Click(object sender, EventArgs e)
        {
            //教材征订 jiao材征订 = new 教材征订();
            //jiao材征订.ShowDialog();
        }

        private void button_MinorRegistration_Click(object sender, EventArgs e)
        {
            //辅修报名 fu修报名 = new 辅修报名();
            //fu修报名.ShowDialog();
        }

        private void button_DelayrdExamApplication_Click(object sender, EventArgs e)
        {
            //我的申请 wo的申请 = new 我的申请();
            //wo的申请.ShowDialog();
        }

        private void button_ExemptApplication_Click(object sender, EventArgs e)
        {
            //我的申请 wo的申请 = new 我的申请();
            //wo的申请.ShowDialog();
        }

        private void button_ExemptionApplication_Click(object sender, EventArgs e)
        {
            //我的申请 wo的申请 = new 我的申请();
            //wo的申请.ShowDialog();
        }

        private void button_MyEvaluation_Click(object sender, EventArgs e)
        {
            //学生评价 xue生评价 = new 学生评价();
            //xue生评价.ShowDialog();
        }

        private void button_ExperimentAppointManagement_Click(object sender, EventArgs e)
        {
            //实验预约管理 shi验预约管理 = new 实验预约管理();
            //shi验预约管理.ShowDialog();
        }

        private void button_OpenPracticeAppointment_Click(object sender, EventArgs e)
        {
            //开放实习预约 kai放实习预约 = new 开放实习预约();
            //kai放实习预约.ShowDialog();
        }

        private void button_ClinicalPracticeGrade_Click(object sender, EventArgs e)
        {
            //临床实习成绩 lin床实习成绩 = new 临床实习成绩();
            //lin床实习成绩.ShowDialog();
        }

        private void button_InnovationCreditDeclaration_Click(object sender, EventArgs e)
        {
            //创新学分申报 chuang新学分申报 = new 创新学分申报();
            //chuang新学分申报.ShowDialog();
        }

        private void button_InnovationCreditInquire_Click(object sender, EventArgs e)
        {
            //创新学分查询 chuang新学分查询 = new 创新学分查询();
            //chuang新学分查询.ShowDialog();
        }

        private void button_PracticeInformationInquire_Click(object sender, EventArgs e)
        {
            //实习信息查询 shi习信息查询 = new 实习信息查询();
            //shi习信息查询.ShowDialog();
        }

        private void button_TestArrangementInquire_Click(object sender, EventArgs e)
        {
            //考试安排查询 kao试安排查询 = new 考试安排查询();
            //kao试安排查询.ShowDialog();
        }

        private void button_MidtermTestInquire_Click(object sender, EventArgs e)
        {
            //半期考试查询 ban期考试查询 = new 半期考试查询();
            //ban期考试查询.ShowDialog();
        }

        private void button_AdvanceTestInquire_Click(object sender, EventArgs e)
        {
            //提前考试查询 ti前考试查询 = new 提前考试查询();
            //ti前考试查询.ShowDialog();
        }

        private void button_MakeupTestRegistration_Click(object sender, EventArgs e)
        {
            //补考报名 bu考报名 = new 补考报名();
            //bu考报名.ShowDialog();
        }

        private void button_QingTestRegistration_Click(object sender, EventArgs e)
        {
            //清考报名 qing考报名 = new 清考报名();
            //qing考报名.ShowDialog();
        }

        private void button_MakeupTheRegistrationForTheCourse_Click(object sender, EventArgs e)
        {
            //补重修报名选课 bu重修报名选课 = new 补重修报名选课();
            //bu重修报名选课.ShowDialog();
        }

        private void button_StudentPickTopic_Click(object sender, EventArgs e)
        {
            //学生选题 xue生选题 = new 学生选题();
            //xue生选题.ShowDialog();
        }

        private void button_GraduationReport_Click(object sender, EventArgs e)
        {
            //毕业报告 bi业报告 = new 毕业报告();
            //bi业报告.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_SchoolSystem_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“eduBaseBigHomeworkDataSet.tb_NoticeAndMessage”中。您可以根据需要移动或删除它。
            this.tb_NoticeAndMessageTableAdapter.Fill(this.eduBaseBigHomeworkDataSet.tb_NoticeAndMessage);

        }

        private void btnSave_Click(object sender, EventArgs e)//保存个人信息
        {
            //try
            //{
                string commandText =
                    $@"UPDATE tb_StudentInformation
                    SET PasswordProtectProblem_1='{txt_PasswordProtectProblem1.Text.Trim()}',
                    PasswordProtectProblem_2='{txt_PasswordProtectProblem2.Text.Trim()}',
                    Answer_1='{txt_Answer1.Text.Trim()}',
                    Answer_2='{txt_Answer2.Text.Trim()}'
                    WHERE No='{txt_StudentNumber.Text}';";
                SqlHelper sqlHelper = new SqlHelper();
                int rowAffected/*受影响的行有几行*/= sqlHelper.QuickSubmit(commandText);
                if (rowAffected == 1 &&( txt_PasswordProtectProblem1.Text != null || txt_PasswordProtectProblem2.Text != null
                    || txt_Answer1.Text != null || txt_Answer2.Text != null))
                {
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("问题或回答为空,保存失败！");
                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("保存失败！");
            //}
        }

        private void btnReSet_Click(object sender, EventArgs e)//重置个人信息
        {
            txt_PasswordProtectProblem1.Text = null;
            txt_PasswordProtectProblem2.Text = null;
            txt_Answer1.Text = null;
            txt_Answer2.Text = null;
            txt_PasswordProtectProblem1.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)//保存密码
        {
            string commandText =
                                $@"UPDATE tb_User
                    SET Password='{txt_NewPassword.Text.Trim()}'
                    WHERE No='{txt_StudentNumber.Text.Trim()}';";
            SqlHelper sqlHelper = new SqlHelper();
            //try
            //{
                int rowAffected/*受影响的行有几行*/= sqlHelper.QuickSubmit(commandText);
                if (rowAffected == 1 && txt_ConfirmNewPassword.Text == txt_NewPassword.Text && (txt_NewPassword.Text != null || txt_ConfirmNewPassword != null)) 
                {
                    MessageBox.Show("保存成功！");

                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("保存失败！");
            //}
            
        }

        private void btn_Reset_Click(object sender, EventArgs e)//重置密码
        {
            SqlHelper sqlHelper = new SqlHelper();
            txt_NewPassword.Text = null;
            txt_ConfirmNewPassword.Text = null;
            //txt_ProviousPassword.Text = sqlHelper["Password"].ToString();
        }

        private void tpPassword_Click(object sender, EventArgs e)
        {
            
        }
    }
}
