using Covid19_Reg.Models;
using System;
using System.Windows.Forms;
using Covid19_Reg.Services;
namespace Covid19_Reg
{
    public partial class FormRegister : Form
    {
        //定义一个是否 取消事件的布尔值，若为true，每次关闭窗口时，事件都会被取消，逻辑完成后，把值改成false
        private bool _cancel = true;
        public FormRegister()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput()==false)
            {
                return;
            }

            using (var db = new Covid19_RegContext())
            {
                var user = new User();
                user.UserName = textBox_username.Text.Trim();
                user.UserPasswd = textBox_passwd.Text.Trim();
                user.UserEmail = textBox_email.Text.Trim();
                user.UserDept = textBox_dept.Text.Trim();

                if (UserService.isUserExist(user.UserName))
                {
                    MessageBox.Show("该用户已存在！");
                    return;
                }
                UserService.Create(user);
                MessageBox.Show($"{user.UserName}注册成功，返回登录界面");
                _cancel = false;
            }

        }

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = _cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _cancel = false;
        }

        private bool CheckInput()
        {
            if (String.IsNullOrEmpty(textBox_username.Text)
                || String.IsNullOrEmpty(textBox_passwd.Text)
                || String.IsNullOrEmpty(textBox_passwd_cf.Text)
                || String.IsNullOrEmpty(textBox_email.Text)
                || String.IsNullOrEmpty(textBox_dept.Text)
                )
            {
                MessageBox.Show("所有项目都不能为空");
                return false;
            }
            if (!textBox_passwd.Text.Trim().Equals(textBox_passwd_cf.Text.Trim()))
            {
                MessageBox.Show("两次输入的密码不相同");
                return false;
            }
            return true;

        }
    }
}
