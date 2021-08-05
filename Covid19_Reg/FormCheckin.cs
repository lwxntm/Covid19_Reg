using Covid19_Reg.Models;
using Covid19_Reg.Services;
using System;
using System.Windows.Forms;
namespace Covid19_Reg
{
    public partial class FormCheckin : Form
    {
        public FormCheckin()
        {
            InitializeComponent();
        }

        private void button_query_Click(object sender, EventArgs e)
        {
            var dlg = new FormQueryCheckin();
            dlg.ShowDialog();
            dlg.Dispose();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            //检测是否输入姓名，是否勾选了状态变化radioButton
            if (!CheckInputs()) return;

            var _dailyCheckin = new DailyCheckin();
            _dailyCheckin.Name = textBox_name.Text.Trim();
            _dailyCheckin.Changed = radioButton_false.Checked ? false : true;
            _dailyCheckin.ChangedContent = textBox_changed_content.Text.Trim();
            _dailyCheckin.Date = dateTimePicker1.Value;
            _dailyCheckin.Temperature = Convert.ToDouble(numericUpDown1.Value);
            DailyCheckinService.Create(_dailyCheckin);
            MessageBox.Show("打卡成功！");
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckInputs()
        {
            if (String.IsNullOrEmpty(textBox_name.Text) ||
                (!radioButton_false.Checked && !radioButton_true.Checked))
            {
                MessageBox.Show("请输入姓名并勾选是否改变状态");
                return false;
            }

            return true;
        }
    }
}
