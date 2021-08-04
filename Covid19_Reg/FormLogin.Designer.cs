
namespace Covid19_Reg
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_PassWd = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(99, 12);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(165, 27);
            this.textBox_UserName.TabIndex = 1;
            // 
            // textBox_PassWd
            // 
            this.textBox_PassWd.Location = new System.Drawing.Point(99, 51);
            this.textBox_PassWd.Name = "textBox_PassWd";
            this.textBox_PassWd.Size = new System.Drawing.Size(165, 27);
            this.textBox_PassWd.TabIndex = 1;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(24, 98);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(89, 30);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(163, 98);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(89, 30);
            this.button_register.TabIndex = 2;
            this.button_register.Text = "注册";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 148);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_PassWd);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打卡系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_PassWd;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
    }
}