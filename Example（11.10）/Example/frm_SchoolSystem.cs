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
            this.LoadYearAndTerm();
            this.LoadCampus();
        }
        
        private void LoadStanza()//向教室借用申请里载入节次
        {
            cbxRoomStanza1.Items.Clear();
            cbxRoomStanza2.Items.Clear();
            string commandText = " SELECT  Name FROM tb_Stanza";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cbxRoomStanza1.Items.Add(sqlHelper["Name"]);
                this.cbxRoomStanza2.Items.Add(sqlHelper["Name"]);
            }
        }

        private void LoadWeek()//向教室借用申请里载入周次
        {
            cbxRoomWeek1.Items.Clear();
            cbxRoomWeek2.Items.Clear();
            string commandText = " SELECT  Name FROM tb_Week";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cbxRoomWeek1.Items.Add(sqlHelper["Name"]);
                this.cbxRoomWeek2.Items.Add(sqlHelper["Name"]);
            }
        }

        private void LoadWeekDay()//向教室借用申请里载入星期
        {
            cbxRoomWeekDay1.Items.Clear();
            cbxRoomWeekDay2.Items.Clear();
            string commandText = " SELECT  Name FROM tb_WeekDay";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cbxRoomWeekDay1.Items.Add(sqlHelper["Name"]);
                this.cbxRoomWeekDay2.Items.Add(sqlHelper["Name"]);
            }
        }

        private void LoadRoomDepartment()//向教室借用申请里载入借用院系
        {
            cbxRoomBorrowDepartment.Items.Clear();
            string commandText = " SELECT Name FROM tb_StuDepartment";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cbxRoomBorrowDepartment.Items.Add(sqlHelper["Name"]);
            }
        }

        private void LoadRoom()//向教室借用申请里载入教室
        {
            cbxRoom.Items.Clear();
            string commandText = " SELECT DISTINCT Name FROM tb_Room ";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord) 
            {
                this.cbxRoom.Items.Add(sqlHelper["Name"]);
            }
        }

        private void LoadYearAndTerm()//向教室借用申请里载入学期
        {
            cbxRoomTerm.Items.Clear();
            string commandText = "SELECT DISTINCT Name FROM tb_YearAndTerm";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cbxRoomTerm.Items.Add(sqlHelper["Name"]);
            }
        }

        private void LoadCampus()//向教室借用申请里载入校区
        {
            cbxRoomCampus.Items.Clear();
            string commandText = "SELECT DISTINCT Name FROM tb_Campus ";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord)
            {
                this.cbxRoomCampus.Items.Add(sqlHelper["Name"]);
            }
        }

        private void LoadDepartment()//向教室借用申请里载入教学楼
        {
            cbxRoomDepartment.Items.Clear();
            string commandText = "SELECT DISTINCT Name FROM tb_Department ";
            var sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            while (sqlHelper.HasRecord) 
            {
                this.cbxRoomDepartment.Items.Add(sqlHelper["Name"]);
            }
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
                $@"SELECT * FROM tb_StudentInformation WHERE No='{StudentNo}';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText1);
            if (sqlHelper.HasRecord)
            {
                this.txt_StudentNo.Text = StudentNo.ToString();
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
            this.LoadTeacherScore();
        }

        private void LoadTeacherScore()//向教学评价里载入教师得分
        {
            string command = $@"SELECT SS.StudentNo,SS.StartTerm,SS.CourseNo,SS.CourseName,SS.CourseNature,SS.TestWay,SS.FacultyRate,SS.StudentComments  
		                               FROM tb_StudentScore AS SS
                                       WHERE SS.StudentNo='{StudentNo}' 
		                               ORDER BY SS.FacultyRate";
            SqlHelper sql = new SqlHelper();
            sql.QuickFill(command, dgvTeacherScore);
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
            SqlHelper sql = new SqlHelper();
            string command = $@"SELECT COUNT(FacultyRate) FROM tb_StudentScore
                             WHERE FacultyRate =0 AND StudentNo='{StudentNo}'";
            int result= sql.QuickReturn<int>(command);
            if (result == 0) 
            {
                tcStudentAchievement.SelectedTab = tcStudentAchievement.TabPages[2];
            }
            else
            {
                MessageBox.Show("请先完成全部课程教师评教，才可查询课程成绩！");
            }
            
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
            SqlHelper sql = new SqlHelper();
            string command1 = $@" SELECT * FROM tb_ComunityTest where Status='已报名'";
            string command2 = $@"SELECT * FROM tb_ComunityTest where Status='未报名'";
            sql.QuickFill(command1,dgvRankTest1);
            sql.QuickFill(command2,dgvRankTest2);
            tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[7];
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

        }

        private void button_ExchangeStudentPickCourse_Click(object sender, EventArgs e)
        {

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
            this.LoadYearAndTerm();
            this.LoadCampus();
            this.LoadWeek();
            this.LoadWeekDay();
            this.LoadStanza();
            this.LoadRoomDepartment();//借用院系
            tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[6];
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
            tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[7];
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
        
        private void button_ExperimentAppointManagement_Click(object sender, EventArgs e)
        {
            tcExperiment.SelectedTab = tcExperiment.TabPages[0];
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
            tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[5];
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
            this.dgvMessage.CurrentCell = null;
        }

        private void tpNotice_Click(object sender, EventArgs e)
        {
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

        private void btnUpdate_Click(object sender, EventArgs e)//有错但不知道为什么
        {
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected/*受影响的行有几行*/= sqlHelper.QuickSubmit($@"UPDATE tb_StatusCard
	                                 SET StuName='{txtStuName.Text}',StuGender='{rdbFemale.Checked}',StuBirthday='{dtpStuBirthday.Value}',StuNation='{cbxStuNation.Text}',
                                     StuClass='{cbxStuClass.Text}',StuMajor='{cbxStuMajor.Text}',StuDepartment='{cbxStuDepertment.Text}',
                                     StuTOSchoolDatetime='{dtpStuToSchoolTime.Value}',StuLengthOfSchooling='{txtStuLengthOfSchooling.Text}',
	                                 StuMajorDirection='{txtStuMajorDirection.Text}',StuPoliticsStatus='{txtStuPoliticsStatus.Text}',StuLearningHierarchy='{txtStuLearningHierarchy.Text}',StuHomePhone='{txtStuHomePhone.Text}',
                                     StuHomeAddress='{txtStuHomeAddress.Text}',StuRailwayStation='{txtStuRailwayStation.Text}',StuPhone='{txtStuPhone.Text}',StuId='{txtStuId.Text}'
                                   	 WHERE No='{txtStuNo.Text.Trim()}'");
            MessageBox.Show($@"更新成功,更新了{rowAffected}行！");
            
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

        private void btnSelect_Click(object sender, EventArgs e)//查询课程成绩
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
            tcMyDesktop.SelectedTab = tcMyDesktop.TabPages[0];
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
                tcMyDesktop.SelectedTab = tcMyDesktop.TabPages[6];
            }
        }

        private void btnReplyMessage_Click_1(object sender, EventArgs e)//回复留言
        {
            String Number = this.dgvMessage.CurrentRow.Cells["No"].Value.ToString();
            string commandText = $@"UPDATE tb_NoticeAndMessageDetails
                                            SET Answer='{txtReplyMessage.Text}'
                                            WHERE No='{int.Parse(Number)}'";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickFill(commandText, dgvMessage);
            this.LoadMessage();
            MessageBox.Show("回复成功！");
            tcMyDesktop.SelectedTab = tcMyDesktop.TabPages[1];

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
                sql.QuickFill($@"SELECT   
                    DEA.StudentNo,DEA.CourseNo,C.Name AS CourseName,YAT.Name AS Term,C.TotalPeriod,C.Credit,ET.Name AS ExamType,
		            DEA.Reason,DEA.CheckStatus,C.ExamTime,DEA.ApplicateTime
		            FROM tb_DelayrdExamApplication AS DEA
					JOIN tb_Course AS C ON DEA.CourseNo=C.No
					JOIN tb_YearAndTerm AS YAT ON C.TermNo=YAT.No
					JOIN tb_ExamType AS ET ON C.ExamTypeNo=ET.No
					WHERE DEA.StudentNo='{StudentNo}' 
                    AND YAT.Name='{cbxTerm.SelectedItem.ToString()}' ORDER BY C.ExamTime DESC
                    ",dgvDelayrdExamApplication);
                tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[1];
                return;
            }
            if (cbxTerm.SelectedIndex == -1 && cbxCheck.SelectedIndex != -1 && txtCourseNameOrNo.Text == "")//查状态
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@" SELECT    
                    DEA.StudentNo,DEA.CourseNo,C.Name AS CourseName,YAT.Name AS Term,C.TotalPeriod,C.Credit,ET.Name AS ExamType,
		            DEA.Reason,DEA.CheckStatus,C.ExamTime,DEA.ApplicateTime
		            FROM tb_DelayrdExamApplication AS DEA
					JOIN tb_Course AS C ON DEA.CourseNo=C.No
					JOIN tb_YearAndTerm AS YAT ON C.TermNo=YAT.No
					JOIN tb_ExamType AS ET ON C.ExamTypeNo=ET.No
					WHERE DEA.StudentNo='{StudentNo}' 
                    AND DEA.CheckStatus='{cbxCheck.SelectedItem.ToString()}' ORDER BY C.ExamTime DESC",
                    dgvDelayrdExamApplication);
                tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[1];
                return;
            }
            if (cbxTerm.SelectedIndex != -1 && cbxCheck.SelectedIndex != -1 && txtCourseNameOrNo.Text == "")//查学年学期和状态
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@"  SELECT    
                    DEA.StudentNo,DEA.CourseNo,C.Name AS CourseName,YAT.Name AS Term,C.TotalPeriod,C.Credit,ET.Name AS ExamType,
		            DEA.Reason,DEA.CheckStatus,C.ExamTime,DEA.ApplicateTime
		            FROM tb_DelayrdExamApplication AS DEA
					JOIN tb_Course AS C ON DEA.CourseNo=C.No
					JOIN tb_YearAndTerm AS YAT ON C.TermNo=YAT.No
					JOIN tb_ExamType AS ET ON C.ExamTypeNo=ET.No
					WHERE DEA.StudentNo='{StudentNo}' AND DEA.CheckStatus='{cbxCheck.SelectedItem.ToString()}'
                    AND YAT.Name='{cbxTerm.SelectedItem.ToString()}' ORDER BY C.ExamTime DESC", 
                    dgvDelayrdExamApplication);
                tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[1];
                return;
            }
            if (cbxTerm.SelectedIndex == -1 && cbxCheck.SelectedIndex == -1 && txtCourseNameOrNo.Text != "")//查课程号或名称
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@" SELECT    
                    DEA.StudentNo,DEA.CourseNo,C.Name AS CourseName,YAT.Name AS Term,C.TotalPeriod,C.Credit,ET.Name AS ExamType,
		            DEA.Reason,DEA.CheckStatus,C.ExamTime,DEA.ApplicateTime
		            FROM tb_DelayrdExamApplication AS DEA
					JOIN tb_Course AS C ON DEA.CourseNo=C.No
					JOIN tb_YearAndTerm AS YAT ON C.TermNo=YAT.No
					JOIN tb_ExamType AS ET ON C.ExamTypeNo=ET.No
					WHERE DEA.StudentNo='{StudentNo}' AND (C.Name='{txtCourseNameOrNo.Text}'
                    OR C.No='{txtCourseNameOrNo.Text}') ORDER BY C.ExamTime DESC",
                    dgvDelayrdExamApplication);
                tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[1];
                return;
            }
            if (cbxTerm.SelectedIndex == -1 && cbxCheck.SelectedIndex == -1 && txtCourseNameOrNo.Text == "")//全部显示
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@"SELECT    
                    DEA.StudentNo,DEA.CourseNo,C.Name AS CourseName,YAT.Name AS Term,C.TotalPeriod,C.Credit,ET.Name AS ExamType,
		            DEA.Reason,DEA.CheckStatus,C.ExamTime,DEA.ApplicateTime
		            FROM tb_DelayrdExamApplication AS DEA
					JOIN tb_Course AS C ON DEA.CourseNo=C.No
					JOIN tb_YearAndTerm AS YAT ON C.TermNo=YAT.No
					JOIN tb_ExamType AS ET ON C.ExamTypeNo=ET.No
                    WHERE DEA.StudentNo='{StudentNo}' ORDER BY C.ExamTime DESC",dgvDelayrdExamApplication);
                tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[1];
                return;
            }
        }

        private void btnTestReturn_Click(object sender, EventArgs e)
        {
            tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[0];
        }
        
        private void btnTestSelect_Click(object sender, EventArgs e)
        {
            tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[3];
        }

        private void btnTestPlanReturn_Click(object sender, EventArgs e)
        {
            tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[2];
        }
        
        private void btnRoomSelect_Click(object sender, EventArgs e)
        {
            if (cbxRoomTerm.Text == "2020-2021-1" && cbxRoomStatus.SelectedIndex == -1) 
            {
                    SqlHelper sql = new SqlHelper();
                    string commandText = $@"SELECT  D.Name AS 教学楼,R.Name AS 教室名称,R.People AS 人数,W.Name AS 周次, WD.Name AS 星期 ,S.Name AS 节次,
		                          R.RoomStatus  AS 教室状态
		                          FROM tb_Room AS R
		                          JOIN tb_Department AS D ON R.DepartmentNo=D.No
		                          JOIN tb_Week AS W ON R.WeekNo=W.No
		                          JOIN tb_WeekDay AS WD ON R.WeekDayNo=WD.No
		                          JOIN tb_Stanza AS S ON R.StanzaNo=S.No
		                          WHERE D.Name='{cbxRoomDepartment.Text}'AND R.Name='{cbxRoom.Text}' AND R.People={Convert.ToInt32(txtRoomPeople.Text)} 
                                  AND (W.Name='{cbxRoomWeek1.Text}' OR W.Name='{cbxRoomWeek2.Text}') AND (WD.Name='{cbxRoomWeekDay1.Text}' OR WD.Name='{cbxRoomWeekDay2.Text}') 
                                  AND (S.Name='{cbxRoomStanza1.Text}'OR S.Name='{cbxRoomStanza2.Text}')
		                          ORDER BY  R.RoomNo,W.No ,WD.No,S.No";
                sql.QuickFill(commandText, dgvRoomRoom);
                
            }
            else
            {
                if (cbxRoomTerm.Text == "2020-2021-1" && cbxRoomCampus.Text == "旗山校区" && cbxRoomStatus.SelectedIndex != -1)
                {
                    if (cbxRoomStatus.Text != " ")
                    {
                        SqlHelper sql = new SqlHelper();
                        string commandText = $@"SELECT  D.Name AS 教学楼,R.Name AS 教室名称,R.People AS 人数,W.Name AS 周次, WD.Name AS 星期 ,S.Name AS 节次,
		                          R.RoomStatus  AS 教室状态
		                          FROM tb_Room AS R
		                          JOIN tb_Department AS D ON R.DepartmentNo=D.No
		                          JOIN tb_Week AS W ON R.WeekNo=W.No
		                          JOIN tb_WeekDay AS WD ON R.WeekDayNo=WD.No
		                          JOIN tb_Stanza AS S ON R.StanzaNo=S.No
		                          WHERE R.RoomStatus LIKE '{cbxRoomStatus.Text}%'
		                          ORDER BY  R.RoomNo,W.No ,WD.No,S.No";
                        sql.QuickFill(commandText, dgvRoomRoom);
                    }
                    else
                    {
                        SqlHelper sql = new SqlHelper();
                        string commandText = $@"SELECT  D.Name AS 教学楼,R.Name AS 教室名称,R.People AS 人数,W.Name AS 周次, WD.Name AS 星期 ,S.Name AS 节次,
		                          R.RoomStatus  AS 教室状态
		                          FROM tb_Room AS R
		                          JOIN tb_Department AS D ON R.DepartmentNo=D.No
		                          JOIN tb_Week AS W ON R.WeekNo=W.No
		                          JOIN tb_WeekDay AS WD ON R.WeekDayNo=WD.No
		                          JOIN tb_Stanza AS S ON R.StanzaNo=S.No
		                          WHERE R.RoomStatus LIKE ''
		                          ORDER BY  R.RoomNo,W.No ,WD.No,S.No";
                        sql.QuickFill(commandText, dgvRoomRoom);
                    }
                    
                }
            }
        }

        private void btnBookReturn_Click(object sender, EventArgs e)
        {
            tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[7];
        }

        private void btnBookSelect_Click(object sender, EventArgs e)
        {
            if (cbxBookTerm.Text=="2020")
            {
                tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[8];
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@"SELECT 
			                       B.No,B.Name,C.Name AS CourseName,YAT.Name AS TermName,B.Press,B.Author,B.Price,B.IsChoose
		                       	   FROM tb_Book AS B
			                       JOIN tb_YearAndTerm AS YAT ON B.TermNo=YAT.No
			                       JOIN tb_Course AS C ON B.CourseNo=C.No
			                       WHERE YAT.Name LIKE '2020%'", dgvBooks);
                return;
            }
            if (cbxBookTerm.Text == "2019")
            {
                tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[8];
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@"SELECT 
			                       B.No,B.Name,C.Name AS CourseName,YAT.Name AS TermName,B.Press,B.Author,B.Price,B.IsChoose
		                       	   FROM tb_Book AS B
			                       JOIN tb_YearAndTerm AS YAT ON B.TermNo=YAT.No
			                       JOIN tb_Course AS C ON B.CourseNo=C.No
			                       WHERE YAT.Name LIKE '2019%'", dgvBooks);
                return;
            }
        }

        private void btnBookOrder_Click(object sender, EventArgs e)
        {
            string bookNo = this.dgvBooks.CurrentRow.Cells["No"].Value.ToString();
            string bookTerm = this.dgvBooks.CurrentRow.Cells["TermName"].Value.ToString();
            string Status = this.dgvBooks.CurrentRow.Cells["IsChoose"].Value.ToString();
            SqlHelper sql = new SqlHelper();
            if (bookTerm=="2020-2021-1")
            {
                if (Status == "否")
                {
                    sql.QuickFill($@"UPDATE tb_Book SET IsChoose='是' WHERE No='{bookNo}'", dgvBooks);
                    MessageBox.Show("订购成功！");
                    sql.QuickFill($@"SELECT 
			                       B.No,B.Name,C.Name AS CourseName,YAT.Name AS TermName,B.Press,B.Author,B.Price,B.IsChoose
		                       	   FROM tb_Book AS B
			                       JOIN tb_YearAndTerm AS YAT ON B.TermNo=YAT.No
			                       JOIN tb_Course AS C ON B.CourseNo=C.No
			                       WHERE YAT.Name LIKE '2020%'", dgvBooks);
                }
                else
                {
                    MessageBox.Show("该教材已订购！");
                }
            }
            else
            {
                MessageBox.Show("当前时间不能订购！");
            }
        }

        private void btnBookNotOrder_Click(object sender, EventArgs e)
        {
            string bookNo = this.dgvBooks.CurrentRow.Cells["No"].Value.ToString();
            string bookTerm = this.dgvBooks.CurrentRow.Cells["TermName"].Value.ToString();
            SqlHelper sql = new SqlHelper();
            if (bookTerm == "2020-2021-1")
            {
                sql.QuickFill($@"UPDATE tb_Book SET IsChoose='否' WHERE No='{bookNo}'", dgvBooks);
                MessageBox.Show("退订成功！");
                sql.QuickFill($@"SELECT 
			                       B.No,B.Name,C.Name AS CourseName,YAT.Name AS TermName,B.Press,B.Author,B.Price,B.IsChoose
		                       	   FROM tb_Book AS B
			                       JOIN tb_YearAndTerm AS YAT ON B.TermNo=YAT.No
			                       JOIN tb_Course AS C ON B.CourseNo=C.No
			                       WHERE YAT.Name LIKE '2020%'", dgvBooks);
            }
            else
            {
                if (bookTerm=="2019-2020-2")
                {
                    MessageBox.Show("退订时间已过！");
                }
                else
                {
                    MessageBox.Show("当前不是操作时间！");
                }
                
            }
        }

        private void btnApplicate1_Click(object sender, EventArgs e)//缓考申请跳转
        {
            SqlHelper sql = new SqlHelper();
            sql.QuickFill($@"SELECT     
           C.No AS CourseNo,C.Name AS CourseName,YAT.Name AS Term,C.TotalPeriod,C.Credit,ET.Name AS ExamType
           FROM tb_Course AS C
		   JOIN tb_ExamType AS ET ON C.ExamTypeNo=ET.No
		   JOIN tb_YearAndTerm AS YAT ON C.TermNo=YAT.No ORDER BY C.ExamTime DESC", dgvCourse);
            tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[2];
        }

        private void button1_Click(object sender, EventArgs e)//跳转到缓考申请页面
        {
            SqlHelper sql = new SqlHelper();
            sql.QuickFill($@"SELECT    
                    DEA.StudentNo,DEA.CourseNo,C.Name AS CourseName,YAT.Name AS Term,C.TotalPeriod,C.Credit,ET.Name AS ExamType,
		            DEA.Reason,DEA.CheckStatus,C.ExamTime,DEA.ApplicateTime
		            FROM tb_DelayrdExamApplication AS DEA
					JOIN tb_Course AS C ON DEA.CourseNo=C.No
					JOIN tb_YearAndTerm AS YAT ON C.TermNo=YAT.No
					JOIN tb_ExamType AS ET ON C.ExamTypeNo=ET.No
                    WHERE DEA.StudentNo='{StudentNo}' ORDER BY C.ExamTime DESC", dgvDelayrdExamApplication);
            tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tcTrainingAndManagement.SelectedTab = tcTrainingAndManagement.TabPages[0];
        }

        private void btnApplicate_Click_1(object sender, EventArgs e)//申请缓考
        {
            String currentCourseNo = this.dgvCourse.CurrentRow.Cells["CourseNo"].Value.ToString();
            SqlHelper sql = new SqlHelper();
            SqlHelper sql2 = new SqlHelper();
            SqlHelper sql3 = new SqlHelper();
            sql.QuickRead($@"SELECT * FROM tb_Course  WHERE No='{currentCourseNo}'");
            if (sql.HasRecord)
            {
                DateTime courseExamTime = (DateTime)sql["ExamTime"];
                DateTime currentTime = DateTime.Now;
                if (currentTime < courseExamTime && currentTime.AddDays(30) >= courseExamTime) 
                {
                    sql2.QuickSubmit($@"INSERT tb_DelayrdExamApplication
                                     (StudentNo,CourseNo,Reason,CheckStatus,ApplicateTime)
                                      VALUES('{StudentNo}','{currentCourseNo}','{txtReason.Text.Trim()}','待审','{currentTime.ToString()}')");
                    MessageBox.Show("申请成功！");
                    txtReason.Clear();
                    sql3.QuickFill($@"SELECT   
                    DEA.StudentNo,DEA.CourseNo,C.Name AS CourseName,YAT.Name AS Term,C.TotalPeriod,C.Credit,ET.Name AS ExamType,
		            DEA.Reason,DEA.CheckStatus,C.ExamTime,DEA.ApplicateTime
		            FROM tb_DelayrdExamApplication AS DEA
					JOIN tb_Course AS C ON DEA.CourseNo=C.No
					JOIN tb_YearAndTerm AS YAT ON C.TermNo=YAT.No
					JOIN tb_ExamType AS ET ON C.ExamTypeNo=ET.No
					WHERE DEA.StudentNo='{StudentNo}' ORDER BY C.ExamTime DESC
                    ", dgvDelayrdExamApplication);
                    tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[1];
                }
                else
                {
                    MessageBox.Show("当前时间无法申请缓考！");
                }
            }
            
        }

        private void btnRecall_Click_1(object sender, EventArgs e)//撤回缓考申请
        {
            string currentStatus = this.dgvDelayrdExamApplication.CurrentRow.Cells["CheckStatus"].Value.ToString();
            string currentNo = this.dgvDelayrdExamApplication.CurrentRow.Cells["CourseNo"].Value.ToString();
            if (currentStatus == "待审")
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@"DELETE tb_DelayrdExamApplication WHERE CourseNo='{currentNo}'",
                    dgvDelayrdExamApplication);
                sql.QuickFill($@"SELECT    
                    DEA.StudentNo,DEA.CourseNo,C.Name AS CourseName,YAT.Name AS Term,C.TotalPeriod,C.Credit,ET.Name AS ExamType,
		            DEA.Reason,DEA.CheckStatus,DEA.ApplicateTime
		            FROM tb_DelayrdExamApplication AS DEA
					JOIN tb_Course AS C ON DEA.CourseNo=C.No
					JOIN tb_YearAndTerm AS YAT ON C.TermNo=YAT.No
					JOIN tb_ExamType AS ET ON C.ExamTypeNo=ET.No
                    WHERE DEA.StudentNo='{StudentNo}' ORDER BY C.ExamTime DESC", dgvDelayrdExamApplication);
                MessageBox.Show("撤回申请成功！");
                return;
            }
            if (currentStatus == "通过")
            {
                MessageBox.Show("该申请已通过，无法撤回！");
                return;
            }
            if (currentStatus == "不通过")
            {
                MessageBox.Show("该申请未通过！");
                return;
            }
        }

        private void cbxRoomCampus_SelectedIndexChanged(object sender, EventArgs e)//校区改变加载教学楼
        {
            if (cbxRoomCampus.Text == "旗山校区") 
            {
                this.LoadDepartment();
            }
            
        }

        private void cbxRoomDepartment_SelectedIndexChanged(object sender, EventArgs e)//教学楼改变加载教室
        {
            if (cbxRoomDepartment.Text == "自强楼") 
            {
                this.LoadRoom();
            }
        }

        private void btnTeacherScore_Click(object sender, EventArgs e)
        {
            if (txtTeacherScore.Text=="")
            {
                MessageBox.Show("评分不能为空！");
                return;
            }
            string currentTeacherScore = this.dgvTeacherScore.CurrentRow.Cells["FacultyRate"].Value.ToString();
            string currentCourseNo = this.dgvTeacherScore.CurrentRow.Cells["CourseNo"].Value.ToString();
            if (currentTeacherScore != "0") 
            {
                MessageBox.Show("已为该课程教师评分，不可重复评分！");
            }
            else
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickSubmit($@"UPDATE tb_StudentScore 
                                          SET FacultyRate='{txtTeacherScore.Text.Trim()}' ,StudentComments='{txtComments.Text.Trim()}'
                                          WHERE StudentNo='{StudentNo}' AND CourseNo='{currentCourseNo}'");
                MessageBox.Show("评分成功！");
                sql.QuickFill($@"SELECT SS.StudentNo,SS.StartTerm,SS.CourseNo,SS.CourseName,SS.CourseNature,SS.TestWay,SS.FacultyRate,SS.StudentComments  
		                               FROM tb_StudentScore AS SS
                                       WHERE SS.StudentNo='{StudentNo}' 
		                               ORDER BY SS.FacultyRate", dgvTeacherScore);
                txtTeacherScore.Clear();
            }
        }

        private void btnBorrowRoom_Click(object sender, EventArgs e)
        {
            if (cbxRoomBorrowDepartment.SelectedIndex != -1) 
            {
                string currentStatus = this.dgvRoomRoom.CurrentRow.Cells["教室状态"].Value.ToString();
                string currentRoom = this.dgvRoomRoom.CurrentRow.Cells["教室名称"].Value.ToString();
                string currentRoomNo;
                if (currentRoom == "教室1101")
                {
                    currentRoomNo = "01101";
                }
                else
                {
                    currentRoomNo = "01102";
                }
                string currentWeek = this.dgvRoomRoom.CurrentRow.Cells["周次"].Value.ToString();
                int currentWeekNo = 0;
                if (currentWeek == "第一周")
                {
                    currentWeekNo = 1;
                }
                string currentWeekDay = this.dgvRoomRoom.CurrentRow.Cells["星期"].Value.ToString();
                int currentWeekDayNo = 0;
                switch (currentWeekDay)
                {
                    case "星期一": currentWeekDayNo = 1; break;
                    case "星期二": currentWeekDayNo = 2; break;
                    case "星期三": currentWeekDayNo = 3; break;
                    case "星期四": currentWeekDayNo = 4; break;
                    case "星期五": currentWeekDayNo = 5; break;
                    case "星期六": currentWeekDayNo = 6; break;
                    case "星期日": currentWeekDayNo = 7; break;
                }
                string currentStanza = this.dgvRoomRoom.CurrentRow.Cells["节次"].Value.ToString();
                int currentStanzaNo = 0;
                switch (currentStanza)
                {
                    case "第一节": currentStanzaNo = 1; break;
                    case "第二节": currentStanzaNo = 2; break;
                    case "第三节": currentStanzaNo = 3; break;
                    case "第四节": currentStanzaNo = 4; break;
                    case "第五节": currentStanzaNo = 5; break;
                    case "第六节": currentStanzaNo = 6; break;
                    case "第七节": currentStanzaNo = 7; break;
                    case "第八节": currentStanzaNo = 8; break;
                    case "第九节": currentStanzaNo = 9; break;
                    case "第十节": currentStanzaNo = 10; break;
                    case "第十一节": currentStanzaNo = 11; break;
                    case "第十二节": currentStanzaNo = 12; break;
                }
                if (currentStatus == "")
                {
                    SqlHelper sql = new SqlHelper();
                    string command = $@"UPDATE tb_Room
		                            SET RoomStatus='J(借用院系：{cbxRoomBorrowDepartment.Text}) '
		                            WHERE RoomNo='{currentRoomNo}' AND WeekNo='{currentWeekNo}' 
                                    AND WeekDayNo='{currentWeekDayNo}' AND StanzaNo='{currentStanzaNo}'";
                    sql.QuickFill(command, dgvRoomRoom);
                    MessageBox.Show($@"{cbxRoomBorrowDepartment.SelectedItem.ToString()}教室借用成功！");
                }
                else
                {
                    MessageBox.Show("该教室已被占用！");
                }
            }
            else
            {
                MessageBox.Show("请先选择借用院系！");
                return;
            }
        }

        private void txtTestPlanSelect_Click(object sender, EventArgs e)
        {
            if (cbxTestPlanTerm.SelectedIndex != -1 && cbxTestPlanCategory.Text == "期末") 
            {
                SqlHelper sql = new SqlHelper();
                string command = $@"SELECT      
            ROW_NUMBER()OVER(ORDER BY C.No) AS 场次,C.No AS 课程号,C.Name AS 课程名称,YAT.Name AS 学期,ET.Name AS 考试类型,ExamTime AS 考试时间
            FROM tb_Course AS C
			JOIN tb_YearAndTerm AS YAT ON C.TermNo=YAT.No
			JOIN tb_ExamType AS ET ON C.ExamTypeNo=ET.No
			WHERE C.ExamTime!='' AND YAT.Name='{cbxTestPlanTerm.Text}'";
                sql.QuickFill(command,dgvTestPlanSelect);
                tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[6];
            }
            else
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tcTestRegistration.SelectedTab = tcTestRegistration.TabPages[5];
        }

        private void tabPage28_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlHelper sql = new SqlHelper();
            SqlHelper sql2 = new SqlHelper();
            sql.QuickRead($@" SELECT * FROM tb_ComunityTest where Status='未报名'");
            string currentTest = this.dgvRankTest2.CurrentRow.Cells["Name"].Value.ToString();
            if (sql.HasRecord)
            {
                if (DateTime.Now.AddMonths(6)>(DateTime)sql["TestTime"]) 
                {
                    string command = $@" UPDATE tb_ComunityTest SET Status='已报名' WHERE Name='{currentTest}'";
                    sql.QuickSubmit(command);
                    MessageBox.Show("报名成功！");
                }
                else
                {
                    MessageBox.Show("当前不在报名时间范围内或未启用报名！");
                }
            }
            else
            {
                return;
            }
            sql2.QuickFill($@" SELECT * FROM tb_ComunityTest where Status='已报名'", dgvRankTest1);
            sql2.QuickFill($@" SELECT * FROM tb_ComunityTest where Status='未报名'", dgvRankTest2);
        }

        private void btnToMoney_Click(object sender, EventArgs e)
        {
            string currentMoney = this.dgvRankTest1.CurrentRow.Cells["IsGetMoney"].Value.ToString();
            string currentTest = this.dgvRankTest1.CurrentRow.Cells["Name"].Value.ToString();
            if (currentMoney == "否") 
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickSubmit($@" UPDATE tb_ComunityTest SET IsGetMoney ='是' WHERE Name='{currentTest}'");
                MessageBox.Show("缴费成功！");
                sql.QuickFill($@" SELECT * FROM tb_ComunityTest where Status='已报名'", dgvRankTest1);
            }
            else
            {
                MessageBox.Show("该考试已经完成过缴费！");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tcExperiment.SelectedTab = tcExperiment.TabPages[0];
        }

        private void btnExperimentAppoint_Click(object sender, EventArgs e)
        {
            if (cbxExperiment.Text == "2020-2021-1") 
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickFill($@"SELECT * FROM tb_Experiment",dgvExperiment);
                tcExperiment.SelectedTab = tcExperiment.TabPages[1];
            }
            else
            {
                return;
            }
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            string currentStatus = this.dgvExperiment.CurrentRow.Cells["Status"].Value.ToString();
            string currentName = this.dgvExperiment.CurrentRow.Cells["Name"].Value.ToString();
            if (currentStatus == "未预约") 
            {
                SqlHelper sql = new SqlHelper();
                sql.QuickSubmit($@"SELECT * FROM tb_Experiment UPDATE tb_Experiment SET Status='已预约' WHERE Name='{currentName}'");
                MessageBox.Show("预约成功！");
                sql.QuickFill($@"SELECT * FROM tb_Experiment", dgvExperiment);
            }
            else
            {
                MessageBox.Show("该实验时间已过或者已经预约！");
            }
        }
    }
}
