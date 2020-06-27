using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEM_log
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        private cLog LoadJson(string date, string time)
        { 
            string path = @"C:\\SEMlog\\" + date + "\\" + time;
            string input = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<cLog>(input);
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            var directories = Directory.GetDirectories(@"C:\\SEMlog");
            var Year = new string[] { };
            var Month = new string[] { };
            var Day = new string[] { };
            foreach (var subdir in directories)
            {
                Year.Append(subdir.Substring(0, 4));
                Month.Append(subdir.Substring(4, 6));
                Day.Append(subdir.Substring(6, 8));
            }
            Year = Year.Distinct().ToArray();
            Month = Month.Distinct().ToArray();
            Day = Day.Distinct().ToArray();

            foreach (var yr in Year)
            {
                cbYear.Items.Add(yr);
            }
            foreach (var mt in Month)
            {
                cbMonth.Items.Add(mt);
            }
            foreach (var dy in Day)
            {
                cbDay.Items.Add(dy);
            }
        }

        private void cbDay_SelectedValueChanged(object sender, EventArgs e)
        {
            string date = cbYear.Text + cbMonth.Text + cbDay.SelectedItem.ToString();
            var files = Directory.GetFiles("C:\\SEMlog\\" + date);
            foreach (var fj in files)
            {
                ListLog.Items.Add(fj);
            }
        }
    }
}
