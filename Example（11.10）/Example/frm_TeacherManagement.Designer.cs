namespace Example
{
    partial class frm_TeacherManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_Teacher = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAverage = new System.Windows.Forms.Button();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.cbxTerm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTeacherComments = new System.Windows.Forms.DataGridView();
            this.btnTeacherReturn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvAverage = new System.Windows.Forms.DataGridView();
            this.btnAverageReturn = new System.Windows.Forms.Button();
            this.tc_Teacher.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherComments)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAverage)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_Teacher
            // 
            this.tc_Teacher.Controls.Add(this.tabPage1);
            this.tc_Teacher.Controls.Add(this.tabPage2);
            this.tc_Teacher.Controls.Add(this.tabPage3);
            this.tc_Teacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Teacher.ItemSize = new System.Drawing.Size(0, 1);
            this.tc_Teacher.Location = new System.Drawing.Point(0, 0);
            this.tc_Teacher.Name = "tc_Teacher";
            this.tc_Teacher.SelectedIndex = 0;
            this.tc_Teacher.Size = new System.Drawing.Size(1012, 574);
            this.tc_Teacher.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_Teacher.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAverage);
            this.tabPage1.Controls.Add(this.txtCourse);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnSelect);
            this.tabPage1.Controls.Add(this.cbxClass);
            this.tabPage1.Controls.Add(this.cbxTerm);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(256, 327);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(127, 35);
            this.btnAverage.TabIndex = 11;
            this.btnAverage.Text = "查询平均分";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(221, 143);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(200, 28);
            this.txtCourse.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(584, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "教师可在此页面按照学期、课程、班级，查询学生评教的平均分和评语！";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(265, 260);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(106, 35);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "查询评语";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbxClass
            // 
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Items.AddRange(new object[] {
            "19信管",
            "19健管",
            "19公管",
            "19健保"});
            this.cbxClass.Location = new System.Drawing.Point(221, 194);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(200, 26);
            this.cbxClass.TabIndex = 6;
            // 
            // cbxTerm
            // 
            this.cbxTerm.FormattingEnabled = true;
            this.cbxTerm.Items.AddRange(new object[] {
            "2020-2021-2",
            "2020-2021-1",
            "2019-2020-2",
            "2019-2020-1"});
            this.cbxTerm.Location = new System.Drawing.Point(221, 90);
            this.cbxTerm.Name = "cbxTerm";
            this.cbxTerm.Size = new System.Drawing.Size(200, 26);
            this.cbxTerm.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "班级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "课程：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "学期：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTeacherComments);
            this.tabPage2.Controls.Add(this.btnTeacherReturn);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1004, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTeacherComments
            // 
            this.dgvTeacherComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherComments.Location = new System.Drawing.Point(24, 67);
            this.dgvTeacherComments.Name = "dgvTeacherComments";
            this.dgvTeacherComments.RowTemplate.Height = 30;
            this.dgvTeacherComments.Size = new System.Drawing.Size(689, 435);
            this.dgvTeacherComments.TabIndex = 1;
            // 
            // btnTeacherReturn
            // 
            this.btnTeacherReturn.Location = new System.Drawing.Point(24, 19);
            this.btnTeacherReturn.Name = "btnTeacherReturn";
            this.btnTeacherReturn.Size = new System.Drawing.Size(75, 29);
            this.btnTeacherReturn.TabIndex = 0;
            this.btnTeacherReturn.Text = "返回";
            this.btnTeacherReturn.UseVisualStyleBackColor = true;
            this.btnTeacherReturn.Click += new System.EventHandler(this.btnTeacherReturn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvAverage);
            this.tabPage3.Controls.Add(this.btnAverageReturn);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1004, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvAverage
            // 
            this.dgvAverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAverage.Location = new System.Drawing.Point(21, 73);
            this.dgvAverage.Name = "dgvAverage";
            this.dgvAverage.RowTemplate.Height = 30;
            this.dgvAverage.Size = new System.Drawing.Size(277, 290);
            this.dgvAverage.TabIndex = 1;
            // 
            // btnAverageReturn
            // 
            this.btnAverageReturn.Location = new System.Drawing.Point(21, 20);
            this.btnAverageReturn.Name = "btnAverageReturn";
            this.btnAverageReturn.Size = new System.Drawing.Size(79, 29);
            this.btnAverageReturn.TabIndex = 0;
            this.btnAverageReturn.Text = "返回";
            this.btnAverageReturn.UseVisualStyleBackColor = true;
            this.btnAverageReturn.Click += new System.EventHandler(this.btnAverageReturn_Click);
            // 
            // frm_TeacherManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 574);
            this.Controls.Add(this.tc_Teacher);
            this.Name = "frm_TeacherManagement";
            this.Text = "教师系统";
            this.tc_Teacher.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherComments)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAverage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Teacher;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.ComboBox cbxTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvTeacherComments;
        private System.Windows.Forms.Button btnTeacherReturn;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvAverage;
        private System.Windows.Forms.Button btnAverageReturn;
    }
}