using Covid19_Reg.Models;
using Covid19_Reg.Services;
using System;
using System.Windows.Forms;
using ZqUtils.Core.Extensions;
namespace Covid19_Reg
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            var dlg = new FormRegister();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
            dlg.Dispose();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_UserName.Text.Trim())
                || String.IsNullOrEmpty(textBox_PassWd.Text.Trim()))
            {
                MessageBox.Show("请输入用户名与密码");
                return;
            }

            var _user = UserService.FindUserByNamePasswd(textBox_UserName.Text.Trim(),
                textBox_PassWd.Text.Trim() );
            if (_user != null)
            {
                var dlg = new FormCheckin(); 
                dlg.ShowDialog();
                dlg.Close();
            }
            else
            {
                MessageBox.Show("用户名或者密码错误");
                textBox_UserName.Text = String.Empty;
                textBox_PassWd.Text = String.Empty;
            }
        }
    }
}
