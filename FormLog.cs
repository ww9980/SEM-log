using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private cLog LoadJson(string path)
        {
            string input = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<cLog>(input);
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            var directories = Directory.GetDirectories(@"C:\\SEMlog");
            var Year = new List<string>();
            var Month = new List<string>();
            var Day = new List<string>();
            foreach (var subdir in directories)
            {
                var subd = Regex.Match(subdir, @"\d+").Value;
                if (!Year.Contains(subd.Substring(0, 4)))
                { 
                    Year.Add(subd.Substring(0, 4));
                }
                if (!Month.Contains(subd.Substring(4, 2)))
                {
                    Month.Add(subd.Substring(4, 2));
                }
                if (!Day.Contains(subd.Substring(6, 2)))
                {
                    Day.Add(subd.Substring(6, 2));
                }
            }


            //Year = Year.Distinct().ToArray();
            //Month = Month.Distinct().ToArray();
            //Day = Day.Distinct().ToArray();

            foreach (var yr in Year)
            {
                cbYear.Items.Add(yr);
            }
        }

        private void cbDay_SelectedValueChanged(object sender, EventArgs e)
        {
            /*
             * ListLog.Items.Clear();
            string date = cbYear.Text + cbMonth.Text + cbDay.SelectedItem.ToString();
            var files = Directory.GetFiles("C:\\SEMlog\\" + date);
            foreach (var fj in files)
            {
                ListLog.Items.Add(fj);
            }
            */
        }

        private void cbYear_SelectedValueChanged(object sender, EventArgs e)
        {
            cbMonth.Items.Clear();
            var directories = Directory.GetDirectories(@"C:\\SEMlog");
            var Month = new List<string>();
            var Day = new List<string>();
            foreach (var subdir in directories)
            {
                var subd = Regex.Match(subdir, @"\d+").Value;
                if (cbYear.Text == subd.Substring(0, 4))
                {
                    if (!Month.Contains(subd.Substring(4, 2)))
                    {
                        Month.Add(subd.Substring(4, 2));
                    }
                }
            }

            foreach (var mt in Month)
            {
                cbMonth.Items.Add(mt);
            }
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListLog.Items.Clear();
            var directories = Directory.GetFiles(@"C:\\SEMlog\\" + cbYear.Text + cbMonth.Text + cbDay.SelectedItem.ToString() + @"\\");
            var Visit = new List<Tuple<string, int>>();
            foreach (var files in directories)
            {
                if (!Visit.Contains(new Tuple<string, int>(files.Substring(8, 4), 0)) || !Visit.Contains(new Tuple<string, int>(files.Substring(8, 4), 1)))
                {
                    int status = 0; 
                    string filename = Path.GetFileName(files);
                    var log = LoadJson(cbYear.Text + cbMonth.Text + cbDay.SelectedItem.ToString(),
                        filename.Substring(0, 6));
                    if (log.OFFflagError)
                    {
                        status = 1;
                    }
                    if (log.OFFflagAuto)
                    {
                        status = 2;
                    }
                    if (log.OFFflagRepair)
                    {
                        status = 3;
                    }

                    Visit.Add(new Tuple<string,int>(filename.Substring(0, 6), status));
                }
            }
            foreach (var item in Visit)
            {
                // 1 = ERROR
                // 2 = Auto log off
                // 3 = Repair by SU

                var lastadded = ListLog.Items.Add(item.Item1);
                if (item.Item2 == 1)
                {
                    lastadded.BackColor = Color.FromArgb(255,151,151);
                }
                if (item.Item2 == 2)
                {
                    lastadded.BackColor = Color.FromArgb(242, 255, 151);
                }
                if (item.Item2 == 3)
                {
                    lastadded.BackColor = Color.FromArgb(179, 255, 151);
                }
            }
        }
        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

            var directories = Directory.GetDirectories(@"C:\\SEMlog");
            var Day = new List<string>();
            foreach (var subdir in directories)
            {
                var subd = Regex.Match(subdir, @"\d+").Value;
                if (cbYear.Text == subd.Substring(0, 4) && cbMonth.Text == subd.Substring(4, 2))
                {
                    if (!Day.Contains(subd.Substring(6, 2)))
                    {
                        Day.Add(subd.Substring(6, 2));
                    }
                }
            }

            foreach (var mt in Day)
            {
                cbDay.Items.Add(mt);
            }
        }

        private void ListLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListLog.SelectedItems.Count == 0)
            {
                return;
            }
            var selectedFile = @"C:\\SEMlog\\" + cbYear.Text +
                cbMonth.Text + cbDay.SelectedItem.ToString() + "\\" + ListLog.SelectedItems[0].Text;
            var logitem = LoadJson(selectedFile);
            tbInfo.Text = "Log file on " + cbYear.Text +
                cbMonth.Text + cbDay.SelectedItem.ToString() + " at " 
                + ListLog.SelectedItems[0].Text + " hours" + 
                "\r\nUser = " + logitem.user +
                "\r\nSU? = " + logitem.OFFflagRepair +
                "\r\nAuto log off? = " + logitem.OFFflagAuto +
                "\r\nERROR? = " + logitem.OFFflagError +
                "\r\nOn time = " + logitem.ONtimestamp +
                " off time = " + logitem.OFFtimestamp +
                " total min spent = " + logitem.totalmin +
                "\r\n\r\nFunctions EDX = " + logitem.OFFflagEDX +
                "\r\nFunctions BSD = " + logitem.OFFflagBSD +
                "\r\n\r\nGun vac = " + logitem.GunVacA + "x10^" + logitem.GunVacB +
                "\r\n\r\nNote = " + logitem.OFFnote;
        }
    }
}
