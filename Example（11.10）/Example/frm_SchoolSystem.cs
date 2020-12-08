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
        public string StudentNo;

        public frm_SchoolSystem()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.LoadStuClasses();
            this.LoadStuNations();
            this.LoadStuMajors();
            this.LoadStuDepartments();
            //this.LoadNotice();
            //this.LoadMessage();

        }

        private void LoadNotice()//向表格载入公告
        {
            string commandText = $@"SELECT NM.No,NM.Title,NM.Category,NM.Sender,NMD.Receiver,NM.TransmitTime,NMD.Status,NMD.Answer
                                          FROM tb_NoticeAndMessage AS NM 
                                          JOIN tb_NoticeAndMessageDetails AS NMD ON NM.No=NMD.NAndMNo
                                          WHERE NM.Category='公告'AND NMD.ReceiverNo='{txt_StudentNo.Text}'  ";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickFill(commandText, dgvNotice);
        }

        private void LoadMessage()//向表格载入留言
        {
            string commandText = $@"SELECT NM.No,NM.Title,NM.Category,NM.Sender,NMD.Receiver,NM.TransmitTime,NMD.Status,NMD.Answer
                                          FROM tb_NoticeAndMessage AS NM 
                                          JOIN tb_NoticeAndMessageDetails AS NMD ON NM.No=NMD.NAndMNo
                                          WHERE NM.Category='留言' AND NMD.ReceiverNo='{txt_StudentNo.Text}'";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickFill(commandText, dgvMessage);
        }



        private void LoadStuClasses()//向下拉框载入班级名称
        {
            string commandText = "SELECT * FROM tb_StuClass ";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cbxStuClass.Items.Add(sqlHelper["Name"]);
            }
        }
        private void LoadStuNations()//向下拉框载入民族名称
        {
            string commandText = "SELECT * FROM tb_StuNation";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cbxStuNation.Items.Add(sqlHelper["Name"]);
            }
        }
        private void LoadStuMajors()//向下拉框载入专业名称
        {
            string commandText = "SELECT * FROM tb_StuMajor ";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cbxStuMajor.Items.Add(sqlHelper["Name"]);
            }
        }
        private void LoadStuDepartments()//向下拉框载入院系名称
        {
            string commandText = "SELECT * FROM tb_StuDepartment";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cbxStuDepertment.Items.Add(sqlHelper["Name"]);
            }
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
                this.txtMyName.Text = sqlHelper["Name"].ToString();
                this.txtMyNumber.Text = sqlHelper["No"].ToString();
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
                txtStuName.Text = sqlHelper3["StuName"].ToString();
                this.rdbFemale.Checked = !(bool)sqlHelper3["StuGender"];//传入性别
                this.rdbMale.Checked = (bool)sqlHelper3["StuGender"];
                dtpStuBirthday.Value = (DateTime)sqlHelper3["StuBirthday"];
                cbxStuNation.Text = sqlHelper3["StuNation"].ToString();
                cbxStuClass.Text = sqlHelper3["StuClass"].ToString();
                cbxStuMajor.Text = sqlHelper3["StuMajor"].ToString();
                cbxStuDepertment.Text = sqlHelper3["StuDepartment"].ToString();
                dtpStuToSchoolTime.Value = (DateTime)sqlHelper3["StuTOSchoolDatetime"];
                txtStuLengthOfSchooling.Text = sqlHelper3["StuLengthOfSchooling"].ToString();
                txtStuMajorDirection.Text = sqlHelper3["StuMajorDirection"].ToString();
                txtStuPoliticsStatus.Text = sqlHelper3["StuPoliticsStatus"].ToString();
                txtStuLearningHierarchy.Text = sqlHelper3["StuLearningHierarchy"].ToString();
                txtStuHomePhone.Text = sqlHelper3["StuHomePhone"].ToString();
                txtStuHomeAddress.Text = sqlHelper3["StuHomeAddress"].ToString();
                txtStuRailwayStation.Text = sqlHelper3["StuRailwayStation"].ToString();
                txtStuPhone.Text = sqlHelper3["StuPhone"].ToString();
                txtStuId.Text = sqlHelper3["StuId"].ToString();
            }
            this.LoadNotice();
            this.LoadMessage();
        }

        private void button_PickCourse_Click(object sender, EventArgs e)
        {
            this.LoadAllCourse();
            tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[5];
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
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[2];
        }

        private void button_MyCourseGradeInquire_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[2];
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
            tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[3];
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
            string commandText = $@"SELECT * FROM tb_RankTest";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickFill(commandText, dgvRankTest);
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[1];
        }

        private void button_MyOSCEGrade_Click(object sender, EventArgs e)
        {
            //tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[10];
        }

        private void button_StudentStatusInforationCard_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[0];
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
            tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[0];
        }

        private void button_StudentPickCoursePlace_Click(object sender, EventArgs e)
        {
            this.LoadAllCourse();
            tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[5];
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
            tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[3];
        }

        private void button_TeachingProcessConclusion_Click(object sender, EventArgs e)
        {
            //教学进度汇总 jiao学进度汇总 = new 教学进度汇总();
            //jiao学进度汇总.ShowDialog();
        }

        private void button_StudentStudySituatiion_Click(object sender, EventArgs e)
        {
            string commandText1 = $@"SELECT ROW_NUMBER()OVER(ORDER BY SS.CourseNature) AS 序号,
	                                   SS.CourseNature AS 课程性质
	                                   ,SUM(SS.Credit) AS 已获得学分
	                                   FROM tb_StudentScore AS SS
	                                   GROUP BY
	                                   SS.CourseNature";
            SqlHelper sqlHelper1 = new SqlHelper();
            sqlHelper1.QuickFill(commandText1, dgvStuationOne);
            string commandText2 = $@"SELECT ROW_NUMBER()OVER(ORDER BY SS.CourseQuality) AS 序号,--自行排序语句
	                                   SS.CourseQuality AS 课程属性
	                                   , SUM(SS.Credit) AS 已获得学分
                                       FROM tb_StudentScore AS SS
	                                   GROUP BY
                                       SS.CourseQuality";
            SqlHelper sqlHelper2 = new SqlHelper();
            sqlHelper2.QuickFill(commandText2, dgvStuationTwo);
            tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[2];
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
            tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[0];
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
            if (rowAffected == 1 && (txt_PasswordProtectProblem1.Text != null || txt_PasswordProtectProblem2.Text != null
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

        private void btnReadMessage_Click(object sender, EventArgs e)//查看留言
        {

            if (this.dgvMessage.SelectedCells != null)
            {
                string status1 = this.dgvMessage.CurrentRow.Cells["Status"].Value.ToString();
                if (status1 == "已读")
                {
                    SqlHelper sqlHelper1 = new SqlHelper();
                    string commandText1 = $@"SELECT NMD.Content
                                             FROM tb_NoticeAndMessage AS NM 
                                             JOIN tb_NoticeAndMessageDetails AS NMD ON NM.No=NMD.NAndMNo
                                             WHERE NM.Category='留言' AND NM.No={this.dgvMessage.CurrentRow.Cells["No"].Value.ToString()}";
                    sqlHelper1.QuickRead(commandText1);
                    if (sqlHelper1.HasRecord)
                    {
                        MessageBox.Show($"该留言已读，内容为{sqlHelper1["Content"]}");
                    }
                    return;
                }
                if (status1 == "未读")
                {
                    SqlHelper sqlHelper2 = new SqlHelper();
                    string commandText2 = $@"SELECT NMD.Content
                                                     FROM tb_NoticeAndMessage AS NM 
                                                     JOIN tb_NoticeAndMessageDetails AS NMD ON NM.No=NMD.NAndMNo
                                                     WHERE NM.Category='留言' AND NM.No={this.dgvMessage.CurrentRow.Cells["No"].Value.ToString()}";
                    sqlHelper2.QuickRead(commandText2);
                    if (sqlHelper2.HasRecord)
                    {
                        int n = int.Parse(this.dgvMessage.CurrentRow.Cells["No"].Value.ToString());
                        MessageBox.Show($"该留言未读，内容为{sqlHelper2["Content"]}");
                        SqlHelper sqlHelper3 = new SqlHelper();
                        string commandText3 = $@"UPDATE tb_NoticeAndMessageDetails
                                                     SET Status='已读'
                                                     WHERE No={n} ";
                        sqlHelper3.QuickFill(commandText3, dgvMessage);
                        //MessageBox.Show($"修改成功 {n}");
                        this.LoadMessage();

                    }
                }
            }
            else
            {
                return;
            }
        }

        private void btnReadNotice_Click(object sender, EventArgs e)//查看公告
        {
            if (this.dgvNotice.SelectedCells != null)
            {
                string status1 = this.dgvNotice.CurrentRow.Cells["Status"].Value.ToString();
                if (status1 == "已读")
                {
                    SqlHelper sqlHelper1 = new SqlHelper();
                    string commandText1 = $@"SELECT NMD.Content
                                             FROM tb_NoticeAndMessage AS NM 
                                             JOIN tb_NoticeAndMessageDetails AS NMD ON NM.No=NMD.NAndMNo
                                             WHERE NM.Category='公告' AND NM.No={this.dgvNotice.CurrentRow.Cells["No"].Value.ToString()}";
                    sqlHelper1.QuickRead(commandText1);
                    if (sqlHelper1.HasRecord)
                    {
                        MessageBox.Show($"该公告已读，内容为{sqlHelper1["Content"]}");
                    }
                    return;
                }
                if (status1 == "未读")
                {
                    SqlHelper sqlHelper2 = new SqlHelper();
                    string commandText2 = $@"SELECT NMD.Content
                                                     FROM tb_NoticeAndMessage AS NM 
                                                     JOIN tb_NoticeAndMessageDetails AS NMD ON NM.No=NMD.NAndMNo
                                                     WHERE NM.Category='公告' AND NM.No={this.dgvNotice.CurrentRow.Cells["No"].Value.ToString()}";
                    sqlHelper2.QuickRead(commandText2);
                    if (sqlHelper2.HasRecord)
                    {
                        int n = int.Parse(this.dgvNotice.CurrentRow.Cells["No"].Value.ToString());
                        MessageBox.Show($"该公告未读，内容为{sqlHelper2["Content"]}");
                        SqlHelper sqlHelper3 = new SqlHelper();
                        string commandText3 = $@"UPDATE tb_NoticeAndMessageDetails
                                                     SET Status='已读'
                                                     WHERE No={n} ";
                        sqlHelper3.QuickFill(commandText3, dgvNotice);
                        //MessageBox.Show($"修改成功 {n}");
                        this.LoadNotice();

                    }
                }
            }
            else
            {
                return;
            }
        }

        private void tpMessage_Click(object sender, EventArgs e)
        {
            //this.LoadMessage();
            this.dgvMessage.CurrentCell = null;


        }

        private void tpNotice_Click(object sender, EventArgs e)
        {
            //this.LoadNotice();
            this.dgvNotice.CurrentCell = null;

        }

        private void btnAnswerNotice_Click(object sender, EventArgs e)
        {
            string status1 = this.dgvNotice.CurrentRow.Cells["Answer"].Value.ToString();
            string status2 = this.dgvNotice.CurrentRow.Cells["Status"].Value.ToString();
            if (status2 == "未读")
            {
                MessageBox.Show("该公告未读，请先读取再回复！");
            }
            if (status2 == "已读" && status1 != "")
            {
                MessageBox.Show("该公告已读，已回复！");
            }
            if (status2 == "已读" && status1 == "")
            {
                tcMyDesktop.SelectedTab = tcMyDesktop.TabPages[5];
            }
        }

        private void btnResetStuInfo_Click(object sender, EventArgs e)
        {
            txtStuName.Text = null; txtStuLearningHierarchy.Text = null;
            rdbFemale.Checked = false; txtStuLengthOfSchooling.Text = null;
            rdbMale.Checked = false; txtStuHomeAddress.Text = null;
            dtpStuBirthday.Text = null; txtStuHomePhone.Text = null;
            dtpStuToSchoolTime.Text = null; txtStuId.Text = null;
            cbxStuNation.Text = null; txtStuMajorDirection.Text = null;
            cbxStuMajor.Text = null; txtStuPoliticsStatus.Text = null;
            cbxStuDepertment.Text = null; txtStuRailwayStation.Text = null;
            cbxStuClass.Text = null; txtStuPhone.Text = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            MessageBox.Show($"{txtStuNo.Text},更新成功,{(bool)rdbFemale.Checked}");
            string commandText=$@"UPDATE tb_StatusCard
	                                 SET StuName='{txtStuName.Text}',StuGender='{(bool)rdbFemale.Checked}',StuBirthday='{dtpStuBirthday.Text}',StuNation='{cbxStuNation.SelectedItem.ToString()}',
                                     StuClass='{cbxStuClass.SelectedItem.ToString()}',StuMajor='{cbxStuMajor.SelectedItem.ToString()}',StuDepartment='{cbxStuDepertment.SelectedItem.ToString()}',
                                     StuTOSchoolDatetime='{dtpStuToSchoolTime.Text}',StuLengthOfSchooling='{txtStuLengthOfSchooling.Text}',
	                                 StuMajorDirection='{txtStuMajorDirection.Text}',StuPoliticsStatus='{txtStuPoliticsStatus.Text}',StuLearningHierarchy='{txtStuLearningHierarchy.Text}',StuHomePhone='{txtStuHomePhone.Text}',
                                     StuHomeAddress='{txtStuHomeAddress.Text}',StuRailwayStation='{txtStuRailwayStation.Text}',StuPhone='{txtStuPhone.Text}',StuId='{txtStuId.Text}'
                                   	 WHERE No='{txtStuNo.Text}'";

            int rowAffected/*受影响的行有几行*/= sqlHelper.QuickSubmit(commandText);

            if (rowAffected != 0) 
            {
                MessageBox.Show("更新成功！");
            }
            
        }

        private void btnSelectCourse_Click(object sender, EventArgs e)
        {
            tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[1];
            if (cbxYearAndTerm.SelectedItem.ToString() == "2020-2021-1" && cbxSelectCourseCategory.SelectedItem.ToString() == "公共选修课")
            {
                string commandText = $@"SELECT * FROM tb_PublicElectiveCourse";
                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.QuickFill(commandText, dgvSelectCourseName);
            }
            if (cbxYearAndTerm.SelectedItem.ToString() == "2020-2021-1" && cbxSelectCourseCategory.SelectedItem.ToString() == "挂牌选课")
            {
                string commandText2 = $@"SELECT * FROM tb_ForCourseSelection";
                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.QuickFill(commandText2, dgvSelectCourseName);
            }

        }

        private void btnSelectCourseName_Click(object sender, EventArgs e)
        {
            if (cbxSelectCourseCategory.SelectedItem.ToString() == "公共选修课")
            {
                string commandText1 = $@"SELECT PEC.*
                                     FROM tb_PublicElectiveCourse AS PEC
                                     WHERE PEC.CourseName='{txtSelectCourseName.Text}'";
                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.QuickFill(commandText1, dgvSelectCourseName);
            }
            if (cbxSelectCourseCategory.SelectedItem.ToString() == "挂牌选课")
            {
                string commandText2 = $@"SELECT FCS.*
                                     FROM tb_ForCourseSelection AS FCS
                                     WHERE FCS.CourseName='{txtSelectCourseName.Text}'";
                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.QuickFill(commandText2, dgvSelectCourseName);
            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[2];
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string commandText = $@"SELECT * FROM tb_StudentScore WHERE StudentNo='{StudentNo}'";
            SqlHelper sqlHelper = new SqlHelper();

            if (cbxOpenCourseTime.SelectedIndex == -1 && cbxCourseNature.SelectedIndex == -1 && txtCourseName.Text == "" && cbxDisplayWay.SelectedItem.ToString() == "显示全部成绩") //全部成绩
            {
                sqlHelper.QuickFill(commandText, dgvDisplayGrade);
                tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[3];
                return;
            }
            if (cbxOpenCourseTime.SelectedIndex == -1 && cbxCourseNature.SelectedIndex == -1 && txtCourseName.Text == "" && cbxDisplayWay.SelectedIndex == 1)//全部成绩最好成绩
            {
                string commandText2 = $@"SELECT TOP 1 * FROM tb_StudentScore WHERE StudentNo='{StudentNo}' ORDER BY Grade DESC";
                sqlHelper.QuickFill(commandText2, dgvDisplayGrade);
                tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[3];
                return;
            }
            if (cbxCourseNature.SelectedIndex != -1 && cbxOpenCourseTime.SelectedIndex == -1 && txtCourseName.Text == "" && cbxDisplayWay.SelectedItem.ToString() == "显示全部成绩")//课程性质
            {
                sqlHelper.QuickFill(commandText += $@"AND CourseNature='{cbxCourseNature.Text.Trim()}'", dgvDisplayGrade);
                tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[3];
                return;
            }
            if (cbxCourseNature.SelectedIndex != -1 && cbxOpenCourseTime.SelectedIndex == -1 && txtCourseName.Text == "" && cbxDisplayWay.SelectedIndex == 1)//课程性质最好成绩
            {
                string commandText3 = $@"SELECT TOP 1 * FROM tb_StudentScore WHERE StudentNo='{StudentNo}'
                                         AND CourseNature='{cbxCourseNature.Text.Trim()}' ORDER BY Grade DESC";
                sqlHelper.QuickFill(commandText3, dgvDisplayGrade);
                tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[3];
                return;
            }
            if (cbxOpenCourseTime.SelectedIndex != -1 && cbxCourseNature.SelectedIndex == -1 && txtCourseName.Text == "" && cbxDisplayWay.SelectedItem.ToString() == "显示全部成绩") //开课时间
            {
                sqlHelper.QuickFill(commandText += $@"AND StartTerm='{cbxOpenCourseTime.Text.Trim()}' ", dgvDisplayGrade);
                tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[3];
                return;
            }
            if (cbxOpenCourseTime.SelectedIndex != -1 && cbxCourseNature.SelectedIndex == -1 && txtCourseName.Text == "" && cbxDisplayWay.SelectedIndex == 1) //开课时间最好成绩
            {
                string commandText4 = $@"SELECT TOP 1 * FROM tb_StudentScore WHERE StudentNo='{StudentNo}'
                                         AND StartTerm='{cbxOpenCourseTime.Text.Trim()}' ORDER BY Grade DESC";
                sqlHelper.QuickFill(commandText4, dgvDisplayGrade);
                tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[3];
                return;
            }
            if (cbxOpenCourseTime.SelectedIndex != -1 && cbxCourseNature.SelectedIndex != -1 && txtCourseName.Text == "" && cbxDisplayWay.SelectedItem.ToString() == "显示全部成绩")//开课时间和课程性质
            {
                sqlHelper.QuickFill(commandText += $@"AND StartTerm='{cbxOpenCourseTime.Text.Trim()}'
                                                    AND CourseNature='{cbxCourseNature.Text.Trim()}' ", dgvDisplayGrade);
                tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[3];
                return;
            }
            if (cbxOpenCourseTime.SelectedIndex != -1 && cbxCourseNature.SelectedIndex != -1 && txtCourseName.Text == "" && cbxDisplayWay.SelectedIndex == 1)//开课时间和课程性质最好成绩
            {
                string commandText5 = $@"SELECT TOP 1 * FROM tb_StudentScore WHERE StudentNo='{StudentNo}'
                                         AND CourseNature='{cbxCourseNature.Text.Trim()}' AND StartTerm='{cbxOpenCourseTime.Text.Trim()}' ORDER BY Grade DESC";
                sqlHelper.QuickFill(commandText5, dgvDisplayGrade);
                tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[3];
                return;
            }
            if (cbxOpenCourseTime.SelectedIndex == -1 && cbxCourseNature.SelectedIndex == -1 && txtCourseName.Text != "") //课程名称
            {
                sqlHelper.QuickFill(commandText += $@" AND CourseName='{txtCourseName.Text.Trim()}'",dgvDisplayGrade);
                tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[3];
                return;
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)          //回复公告
        {
            String Number = this.dgvNotice.CurrentRow.Cells["No"].Value.ToString();
            string commandText = $@"UPDATE tb_NoticeAndMessageDetails
                                            SET Answer='{txtReplay.Text}'
                                            WHERE No='{int.Parse(Number)}'";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickFill(commandText, dgvNotice);
            this.LoadNotice();
            MessageBox.Show("回复成功！");
        }

        private void btnAnswerMessage_Click(object sender, EventArgs e)
        {
            string status1 = this.dgvMessage.CurrentRow.Cells["Answer"].Value.ToString();
            string status2 = this.dgvMessage.CurrentRow.Cells["Status"].Value.ToString();
            if (status2 == "未读")
            {
                MessageBox.Show("该留言未读，请先读取再回复！");
            }
            if (status2 == "已读" && status1 != "")
            {
                MessageBox.Show("该留言已读，已回复！");           
            }
            if (status2 == "已读" && status1 == "")
            {
                tcMyDesktop.SelectedTab = tcMyDesktop.TabPages[5];
            }
        }

        private void btnReplyMessage_Click(object sender, EventArgs e)      //回复留言
        {
            String Number = this.dgvMessage.CurrentRow.Cells["No"].Value.ToString();
            string commandText = $@"UPDATE tb_NoticeAndMessageDetails
                                            SET Answer='{txtReplay.Text}'
                                            WHERE No='{int.Parse(Number)}'";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickFill(commandText, dgvMessage);
            this.LoadMessage();
            MessageBox.Show("回复成功！");
        }

        private void LoadAllCourse()          //载入选课
        {
            string commandText1 = $@"SELECT PEC.No,PEC.CourseName,PEC.CourseSeries,PEC.Period,PEC.Credit,PEC.Teachers,PEC.ChooseLimitedNumber,
	                                                     IIF(SS.Grade IS NOT NULL,'不可退','可退') AS Status
	                                                     FROM tb_PublicElectiveCourse AS PEC LEFT
	                                                     JOIN tb_StudentScore AS SS 
	                                                     ON SS.CourseNo=PEC.No 
	                                                     WHERE PEC.Status='已选' ";
            SqlHelper sqlHelper1 = new SqlHelper();
            sqlHelper1.QuickFill(commandText1, dgvStudentNotChooseCourse);
            string commandText2 = $@"SELECT No,CourseName,CourseSeries,Period,Credit,Teachers,ChooseLimitedNumber,Status FROM tb_PublicElectiveCourse ";
            SqlHelper sqlHelper2 = new SqlHelper();
            sqlHelper2.QuickFill(commandText2, dgvStudentChooseCourse);
        }

        private void btnChooseCourse_Click(object sender, EventArgs e)       //进行选课
        {
            string status = this.dgvStudentChooseCourse.CurrentRow.Cells["Status"].Value.ToString();
            string CurrentCourseNo = this.dgvStudentChooseCourse.CurrentRow.Cells["No"].Value.ToString();
            if (status == "已选")
            {
                MessageBox.Show("该课程已选，不能重复选课！");
                return;
            }
            if (status == "未选")
            {
                string commandText = $@"UPDATE tb_PublicElectiveCourse
                                          SET Status='已选'
                                          WHERE No='{CurrentCourseNo }'";

                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.QuickFill(commandText, dgvStudentChooseCourse);
                sqlHelper.QuickSubmit($"INSERT tb_StudentScore(StudentNo,CourseNo) VALUES('{StudentNo}','{CurrentCourseNo }');");
                MessageBox.Show("选课成功！");
                this.LoadAllCourse();

            }
        }

        private void btnReturnChooseCourse_Click(object sender, EventArgs e)       //进行退选
        {
            string status = this.dgvStudentNotChooseCourse.CurrentRow.Cells["Status"].Value.ToString();
            string currentCourseNumber = this.dgvStudentNotChooseCourse.CurrentRow.Cells["No"].Value.ToString();
            if (status == "不可退")
            {
                MessageBox.Show("该课已有成绩，不可退选！");
                return;
            }
            if (status == "可退")
            {
                string commandText = $@"UPDATE tb_PublicElectiveCourse
                                          SET Status='未选'
                                          WHERE No='{currentCourseNumber.ToString()}'";
                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.QuickFill(commandText, dgvStudentChooseCourse);
                sqlHelper.QuickSubmit($"DELETE tb_StudentScore WHERE StudentNo='{StudentNo}' AND CourseNo='{currentCourseNumber}';");
                MessageBox.Show("退选成功！");
                this.LoadAllCourse();
            }
        }

        private void tcp_TrainingAndManagement_Click(object sender, EventArgs e)
        {

        }

        private void tcp_StudentAchievement_Click(object sender, EventArgs e)
        {

        }

        private void btnDeferredinquiry_Click(object sender, EventArgs e)//查询缓考申请
        {
            if (cbxTerm.SelectedIndex != -1 && cbxCheck.SelectedIndex == -1 && txtCourseNameOrNo.Text == "") //查学年学期
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@" SELECT  ROW_NUMBER()OVER(ORDER BY C.No) AS Number,YAT.Name,C.No,C.Name,C.TotalPeriod,C.Credit,ET.Name,
                                  DEA.GradeLogo,DEA.Reason,DEA.CheckStatus,DEA.ApplicateTime
                                  FROM tb_DelayrdExamApplication AS DEA
                                  JOIN tb_Course AS C ON DEA.CourseNo=C.No
                                  JOIN tb_ExamType AS ET ON DEA.ExamTypeNo=ET.No
                                  JOIN tb_YearAndTerm AS YAT ON DEA.YearAndTermNo=YAT.No
                                  WHERE DEA.StudentNo='{StudentNo}'AND YAT.Name='{cbxTerm.SelectedItem.ToString()}'",
                                  dgvDelayrdExamApplication);
                tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[1];
                return;
            }
            if (cbxTerm.SelectedIndex == -1 && cbxCheck.SelectedIndex != -1 && txtCourseNameOrNo.Text == "")//查状态
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@" SELECT  ROW_NUMBER()OVER(ORDER BY C.No) AS Number,YAT.Name,C.No,C.Name,C.TotalPeriod,C.Credit,ET.Name,
                                  DEA.GradeLogo,DEA.Reason,DEA.CheckStatus,DEA.ApplicateTime
                                  FROM tb_DelayrdExamApplication AS DEA
                                  JOIN tb_Course AS C ON DEA.CourseNo=C.No
                                  JOIN tb_ExamType AS ET ON DEA.ExamTypeNo=ET.No
                                  JOIN tb_YearAndTerm AS YAT ON DEA.YearAndTermNo=YAT.No
                                  WHERE DEA.StudentNo='{StudentNo}' AND DEA.CheckStatus='{cbxCheck.SelectedItem.ToString()}'", 
                                  dgvDelayrdExamApplication);
                tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[1];
                return;
            }
            if (cbxTerm.SelectedIndex != -1 && cbxCheck.SelectedIndex != -1 && txtCourseNameOrNo.Text == "")//查学年学期和状态
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@" SELECT  ROW_NUMBER()OVER(ORDER BY C.No) AS Number,YAT.Name,C.No,C.Name,C.TotalPeriod,C.Credit,ET.Name,
                                  DEA.GradeLogo,DEA.Reason,DEA.CheckStatus,DEA.ApplicateTime
                                  FROM tb_DelayrdExamApplication AS DEA
                                  JOIN tb_Course AS C ON DEA.CourseNo=C.No
                                  JOIN tb_ExamType AS ET ON DEA.ExamTypeNo=ET.No
                                  JOIN tb_YearAndTerm AS YAT ON DEA.YearAndTermNo=YAT.No
                                  WHERE DEA.StudentNo='{StudentNo}' AND DEA.CheckStatus='{cbxCheck.SelectedItem.ToString()}'
                                  AND YAT.Name='{cbxTerm.SelectedItem.ToString()}'", dgvDelayrdExamApplication);
                tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[1];
                return;
            }
            if (cbxTerm.SelectedIndex == -1 && cbxCheck.SelectedIndex == -1 && txtCourseNameOrNo.Text != "")//查课程号或名称
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@" SELECT  ROW_NUMBER()OVER(ORDER BY C.No) AS Number,YAT.Name,C.No,C.Name,C.TotalPeriod,C.Credit,ET.Name,
                                  DEA.GradeLogo,DEA.Reason,DEA.CheckStatus,DEA.ApplicateTime
                                  FROM tb_DelayrdExamApplication AS DEA
                                  JOIN tb_Course AS C ON DEA.CourseNo=C.No
                                  JOIN tb_ExamType AS ET ON DEA.ExamTypeNo=ET.No
                                  JOIN tb_YearAndTerm AS YAT ON DEA.YearAndTermNo=YAT.No
                                  WHERE DEA.StudentNo='{StudentNo}' AND C.Name='{txtCourseNameOrNo.Text}' OR C.No='{txtCourseNameOrNo.Text}'",
                                  dgvDelayrdExamApplication);
                tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[1];
                return;
            }
            if (cbxTerm.SelectedIndex == -1 && cbxCheck.SelectedIndex == -1 && txtCourseNameOrNo.Text == "")//全部显示
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@" SELECT  ROW_NUMBER()OVER(ORDER BY C.No) AS Number,YAT.Name,C.No,C.Name,C.TotalPeriod,C.Credit,ET.Name,
                                  DEA.GradeLogo,DEA.Reason,DEA.CheckStatus,DEA.ApplicateTime
                                  FROM tb_DelayrdExamApplication AS DEA
                                  JOIN tb_Course AS C ON DEA.CourseNo=C.No
                                  JOIN tb_ExamType AS ET ON DEA.ExamTypeNo=ET.No
                                  JOIN tb_YearAndTerm AS YAT ON DEA.YearAndTermNo=YAT.No
                                  WHERE DEA.StudentNo='{StudentNo}'",
                                  dgvDelayrdExamApplication);
                tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[1];
                return;
            }
        }

        private void btnTestReturn_Click(object sender, EventArgs e)
        {
            tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[0];
        }
    }
}
