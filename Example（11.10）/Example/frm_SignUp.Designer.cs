namespace Example
{
    partial class frm_SignUp
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_UserNumber = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_UserNumber
            // 
            this.txt_UserNumber.Location = new System.Drawing.Point(131, 93);
            this.txt_UserNumber.Name = "txt_UserNumber";
            this.txt_UserNumber.Size = new System.Drawing.Size(184, 28);
            this.txt_UserNumber.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(131, 155);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(184, 28);
            this.txt_Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(131, 226);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 34);
            this.btn_SignUp.TabIndex = 4;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(240, 226);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 34);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 285);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserNumber);
            this.Name = "frm_SignUp";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.frm_SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UserNumber;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Button btn_Login;
    }
}

