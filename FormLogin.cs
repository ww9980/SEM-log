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
using MetroFramework;
using MetroFramework.Forms;

namespace SEM_log
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(cLog lastSession)
        {
            InitializeComponent();
            readLastSession(lastSession);
        }

        public cLog logitem;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void readLastSession(cLog lastSession)
        {
            string display = "Last user is " + lastSession.user;
            if (lastSession.OFFflagError)
            {
                display = "Tool requires ATTENTION. ";
                pbStatus.Image = Properties.Resources.wrong.ToBitmap();
            }
            else
            {
                display = "Tool was OK. ";
                pbStatus.Image = Properties.Resources.correct.ToBitmap();
            }
            if (lastSession.OFFnote == "")
            {
                display += "Last user is " + lastSession.user + ". ";
            }
            else 
            {
                display += "Last user is " + lastSession.user + ", with note: " + lastSession.OFFnote + ". ";
            }
            display += "Log off time: " + lastSession.OFFtimestamp; 
            textLastStatus.Text = display; 
        }

        private void mbLogin_Click(object sender, EventArgs e)
        {
            if (mtbUser.Text == "" || mtbUser.Text.Length < 3)
            {
                MetroMessageBox.Show(this, "Entre your user name and try again. ",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            logitem = new cLog(mtbUser.Text, DateTime.Now.ToString("HH:mm:ss"));
            Close();
            var mon = new FormSEMon(logitem);
            mon.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var logform = new FormLog();
            logform.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Created by W Fan. " +
                "Released under GPL v3 license. ", 
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
