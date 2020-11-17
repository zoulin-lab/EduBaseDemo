namespace Example
{
    partial class frm_RevisePassword
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
            this.lbl_StudentNumber = new System.Windows.Forms.Label();
            this.txt_StudentNumber = new System.Windows.Forms.TextBox();
            this.lbl_ProviousPassword = new System.Windows.Forms.Label();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.lbl_CofirmNewPassword = new System.Windows.Forms.Label();
            this.txt_ProviousPassword = new System.Windows.Forms.TextBox();
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.txt_ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_StudentNumber
            // 
            this.lbl_StudentNumber.AutoSize = true;
            this.lbl_StudentNumber.Location = new System.Drawing.Point(62, 96);
            this.lbl_StudentNumber.Name = "lbl_StudentNumber";
            this.lbl_StudentNumber.Size = new System.Drawing.Size(98, 18);
            this.lbl_StudentNumber.TabIndex = 7;
            this.lbl_StudentNumber.Text = "登录账号：";
            // 
            // txt_StudentNumber
            // 
            this.txt_StudentNumber.Location = new System.Drawing.Point(184, 86);
            this.txt_StudentNumber.Name = "txt_StudentNumber";
            this.txt_StudentNumber.ReadOnly = true;
            this.txt_StudentNumber.Size = new System.Drawing.Size(189, 28);
            this.txt_StudentNumber.TabIndex = 8;
            // 
            // lbl_ProviousPassword
            // 
            this.lbl_ProviousPassword.AutoSize = true;
            this.lbl_ProviousPassword.Location = new System.Drawing.Point(80, 159);
            this.lbl_ProviousPassword.Name = "lbl_ProviousPassword";
            this.lbl_ProviousPassword.Size = new System.Drawing.Size(80, 18);
            this.lbl_ProviousPassword.TabIndex = 9;
            this.lbl_ProviousPassword.Text = "旧密码：";
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Location = new System.Drawing.Point(80, 209);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(80, 18);
            this.lbl_NewPassword.TabIndex = 10;
            this.lbl_NewPassword.Text = "新密码：";
            // 
            // lbl_CofirmNewPassword
            // 
            this.lbl_CofirmNewPassword.AutoSize = true;
            this.lbl_CofirmNewPassword.Location = new System.Drawing.Point(44, 262);
            this.lbl_CofirmNewPassword.Name = "lbl_CofirmNewPassword";
            this.lbl_CofirmNewPassword.Size = new System.Drawing.Size(116, 18);
            this.lbl_CofirmNewPassword.TabIndex = 11;
            this.lbl_CofirmNewPassword.Text = "确认新密码：";
            // 
            // txt_ProviousPassword
            // 
            this.txt_ProviousPassword.Location = new System.Drawing.Point(184, 148);
            this.txt_ProviousPassword.Name = "txt_ProviousPassword";
            this.txt_ProviousPassword.ReadOnly = true;
            this.txt_ProviousPassword.Size = new System.Drawing.Size(189, 28);
            this.txt_ProviousPassword.TabIndex = 12;
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(184, 199);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(189, 28);
            this.txt_NewPassword.TabIndex = 13;
            // 
            // txt_ConfirmNewPassword
            // 
            this.txt_ConfirmNewPassword.Location = new System.Drawing.Point(184, 252);
            this.txt_ConfirmNewPassword.Name = "txt_ConfirmNewPassword";
            this.txt_ConfirmNewPassword.Size = new System.Drawing.Size(189, 28);
            this.txt_ConfirmNewPassword.TabIndex = 14;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(184, 321);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 39);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(298, 321);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 39);
            this.btn_Reset.TabIndex = 16;
            this.btn_Reset.Text = "重置";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // frm_RevisePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_ConfirmNewPassword);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.txt_ProviousPassword);
            this.Controls.Add(this.lbl_CofirmNewPassword);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.lbl_ProviousPassword);
            this.Controls.Add(this.txt_StudentNumber);
            this.Controls.Add(this.lbl_StudentNumber);
            this.Name = "frm_RevisePassword";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StudentNumber;
        private System.Windows.Forms.TextBox txt_StudentNumber;
        private System.Windows.Forms.Label lbl_ProviousPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.Label lbl_CofirmNewPassword;
        private System.Windows.Forms.TextBox txt_ProviousPassword;
        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.TextBox txt_ConfirmNewPassword;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Reset;
    }
}