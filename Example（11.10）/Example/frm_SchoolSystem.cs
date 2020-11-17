using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public frm_SchoolSystem(string studentNo) :this()
        {
            this.StudentNo = studentNo;
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
            //公告留言 gong告留言 = new 公告留言();
            //gong告留言.ShowDialog();
        }

        private void button_ReceivedNotice_Click(object sender, EventArgs e)
        {
            //公告留言 gong告留言 = new 公告留言();
            //gong告留言.ShowDialog();
        }

        private void button_CourseGradeInquire_Click(object sender, EventArgs e)
        {
            //课程成绩查询 ke程成绩查询 = new 课程成绩查询();
            //ke程成绩查询.ShowDialog();
        }

        private void button_MyCourseGradeInquire_Click(object sender, EventArgs e)
        {
            //课程成绩查询 ke程成绩查询 = new 课程成绩查询();
            //ke程成绩查询.ShowDialog();
        }

        private void button_MyReceivedMessage_Click(object sender, EventArgs e)
        {
            frm_NoticesAndMessages noticesAndMessages = new frm_NoticesAndMessages();
            noticesAndMessages.ShowDialog();
        }

        private void button_MyReceivedNotice_Click(object sender, EventArgs e)
        {
            frm_NoticesAndMessages noticesAndMessages = new frm_NoticesAndMessages();
            noticesAndMessages.ShowDialog();
        }

        private void button_ChangePersonalInformation_Click(object sender, EventArgs e)
        {
            //frm_ReviseStudentInfo f1 = new frm_ReviseStudentInfo();
            //f1.Show();//将窗体一进行显示
            //panel1.Controls.Clear();//清空原容器上的控件
            //panel1.Controls.Add(f1);//将窗体一加入容器panel1
            frm_ReviseStudentInfo reviseStudentInfo = new frm_ReviseStudentInfo(StudentNo);
            reviseStudentInfo.ShowDialog();
        }

        private void button_ChangeCode_Click(object sender, EventArgs e)
        {
            frm_RevisePassword revisePassword = new frm_RevisePassword(StudentNo);
            revisePassword.ShowDialog();
        }

        private void button_SeeMyTeachingWeek_Click(object sender, EventArgs e)
        {
            //教学周历查看 jiao学周历查看 = new 教学周历查看();
            //jiao学周历查看.ShowDialog();
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
            //等级考试成绩 deng级考试成绩 = new 等级考试成绩();
            //deng级考试成绩.ShowDialog();
        }

        private void button_MyOSCEGrade_Click(object sender, EventArgs e)
        {
            //OSCE成绩 osce成绩 = new OSCE成绩();
            //osce成绩.ShowDialog();
        }

        private void button_StudentStatusInforationCard_Click(object sender, EventArgs e)
        {
            //学籍卡片 xue级卡片 = new 学籍卡片();
            //xue级卡片.ShowDialog();
        }

        private void button_MyStatusCard_Click(object sender, EventArgs e)
        {
            //学籍卡片 xue级卡片 = new 学籍卡片();
            //xue级卡片.ShowDialog();
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
            //学籍信息管理 xue级信息管理 = new 学籍信息管理();
            //xue级信息管理.ShowDialog();
        }

        private void button_MyStatusEarningInquire_Click(object sender, EventArgs e)
        {
            //学籍预警查询 xue籍预警查询 = new 学籍预警查询();
            //xue籍预警查询.ShowDialog();
        }

        private void button_MyStatusDynamicInformatonn_Click(object sender, EventArgs e)
        {
            //学籍异动信息 xue籍异动信息 = new 学籍异动信息();
            //xue籍异动信息.ShowDialog();
        }

        private void button_ProfessionalShunt_Click(object sender, EventArgs e)
        {
            //专业分流 zhuan业分流 = new 专业分流();
            //zhuan业分流.ShowDialog();
        }

        private void button_ExchangeStudentApplication_Click(object sender, EventArgs e)
        {
            //申请交换生 shen请交换生 = new 申请交换生();
            //shen请交换生.ShowDialog();
        }

        private void button_ExchangeStudentGrade_Click(object sender, EventArgs e)
        {
            //交换生成绩 jiao换生成绩 = new 交换生成绩();
            //jiao换生成绩.ShowDialog();
        }

        private void button_ExchangeStudentPickCourse_Click(object sender, EventArgs e)
        {
            //交换生选课 jiao换生选课 = new 交换生选课();
            //jiao换生选课.ShowDialog();
        }

        private void button_MyGradeFirmlyBelieve_Click(object sender, EventArgs e)
        {
            //成绩认定 cheng级认定 = new 成绩认定();
            //cheng级认定.ShowDialog();
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
    }
}
