using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEM_log
{
    public partial class FormSEMon : MetroFramework.Forms.MetroForm
    {
        public FormSEMon(cLog log)
        {
            InitializeComponent();
            currentlog = log;
        }

        private cLog currentlog;
        private DateTime starttime;

        private void FormSEMon_Load(object sender, EventArgs e)
        {
            mlUser.Text = "Current user:" + currentlog.user;
            starttime = DateTime.Now;
        }

        private void mbLogoff_Click(object sender, EventArgs e)
        {
            currentlog.totalmin = DateTime.Now.Subtract(starttime).ToString("mm");
            currentlog.OFFtimestamp = DateTime.Now.ToString("HH:mm:ss");
            currentlog.OFFflagAuto = false;
            var off = new FormLogoff(currentlog);
            off.Show();
            Close();
        }

        private void timerAutoOff_Tick(object sender, EventArgs e)
        {
            currentlog.OFFflagAuto = true;
            currentlog.OFFflagBSD = false;
            currentlog.OFFflagEDX = false;
            currentlog.OFFflagError = false;
            currentlog.totalmin = DateTime.Now.Subtract(starttime).ToString("mm");
            currentlog.OFFtimestamp = DateTime.Now.ToString("HH:mm:ss");
            currentlog.OFFnote = "Auto timeout after " + currentlog.totalmin + " mins. ";
        }
    }
}
