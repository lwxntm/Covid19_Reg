
namespace Covid19_Reg
{
    partial class FormCheckin
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_changed_content = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_query = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_false = new System.Windows.Forms.RadioButton();
            this.radioButton_true = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(25, 45);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(256, 27);
            this.textBox_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "状态是否有变化（必选）";
            // 
            // textBox_changed_content
            // 
            this.textBox_changed_content.Location = new System.Drawing.Point(29, 226);
            this.textBox_changed_content.Name = "textBox_changed_content";
            this.textBox_changed_content.Size = new System.Drawing.Size(265, 27);
            this.textBox_changed_content.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "变化情况说明";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 314);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "日期";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(25, 385);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(139, 27);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            365,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "体温";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(30, 443);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(76, 41);
            this.button_submit.TabIndex = 9;
            this.button_submit.Text = "提交";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(112, 443);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(76, 41);
            this.button_query.TabIndex = 9;
            this.button_query.Text = "检索";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(194, 443);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(76, 41);
            this.button_return.TabIndex = 9;
            this.button_return.Text = "返回";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_false);
            this.panel1.Controls.Add(this.radioButton_true);
            this.panel1.Location = new System.Drawing.Point(27, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 46);
            this.panel1.TabIndex = 10;
            // 
            // radioButton_false
            // 
            this.radioButton_false.AutoSize = true;
            this.radioButton_false.Location = new System.Drawing.Point(85, 12);
            this.radioButton_false.Name = "radioButton_false";
            this.radioButton_false.Size = new System.Drawing.Size(45, 24);
            this.radioButton_false.TabIndex = 0;
            this.radioButton_false.TabStop = true;
            this.radioButton_false.Text = "无";
            this.radioButton_false.UseVisualStyleBackColor = true;
            // 
            // radioButton_true
            // 
            this.radioButton_true.AutoSize = true;
            this.radioButton_true.Location = new System.Drawing.Point(11, 12);
            this.radioButton_true.Name = "radioButton_true";
            this.radioButton_true.Size = new System.Drawing.Size(45, 24);
            this.radioButton_true.TabIndex = 0;
            this.radioButton_true.TabStop = true;
            this.radioButton_true.Text = "有";
            this.radioButton_true.UseVisualStyleBackColor = true;
            // 
            // FormCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_query);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_changed_content);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCheckin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "疫情数据上报";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_changed_content;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_false;
        private System.Windows.Forms.RadioButton radioButton_true;
    }
}