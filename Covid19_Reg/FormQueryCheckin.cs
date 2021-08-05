using Covid19_Reg.Models;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Covid19_Reg
{
    public partial class FormQueryCheckin : Form
    {
        private Expression<Func<DailyCheckin, bool>> whereByDate = d => true;
        private Expression<Func<DailyCheckin, bool>> byName = d => true;

        public FormQueryCheckin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = dateTimePicker_start.Value.Date;
            var de = dateTimePicker_end.Value.Date;
            if (de < ds)
            {
                MessageBox.Show("截止日期不能小于开始日期！");
                return;
            }
            whereByDate = 
                d => d.Date.Date >= dateTimePicker_start.Value.Date 
                && d.Date.Date <= dateTimePicker_end.Value.Date;

            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                byName = d => d.Name.Trim().Equals(textBox1.Text.Trim());
                whereByDate = CommonUtils.ExpressionHelp.And(whereByDate, byName);
            }
            listView1.Items.Clear();
            foreach (var dailyCheckin in Services.DailyCheckinService.FetchData(whereByDate))
            {
                var obj = new ListViewItem(dailyCheckin.Name.Trim());
                obj.SubItems.Add(dailyCheckin.Changed ? "是" : "否");
                obj.SubItems.Add(dailyCheckin.ChangedContent.Trim());
                obj.SubItems.Add(dailyCheckin.Date.Date.ToString("D"));
                obj.SubItems.Add(dailyCheckin.Temperature.ToString());
                listView1.Items.Add(obj);
            }
        }
    }
}
