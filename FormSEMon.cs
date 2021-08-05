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


        private int timeinsec = 0;
        private int autooff = 0;

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

        private void timerCS_Tick(object sender, EventArgs e)
        {
            timeinsec++;
            if (timeinsec / 60 > 0)
            {
                var timeinmin = (int)(timeinsec / 60);
                var timeextrasec = timeinsec % 60;
                mlTimer.Text = "Current session: " + timeinmin.ToString() + " min " + timeextrasec.ToString() + " s";
            }
            else
            {
                mlTimer.Text = "Current session: " + timeinsec.ToString() + " s";
            }
        }

        private void timerAutoOffReminder_Tick(object sender, EventArgs e)
        {
            autooff++;
            mlALO.Text = "Autologoff in " + (5-autooff).ToString() + " min";
        }

        private void FormSEMon_LocationChanged(object sender, EventArgs e)
        {
            if (Top < 0)
            {
                this.Top = 0;
            }
            if (this.Left < 0)
            {
                Left = 0;
            }
            if (Bottom > Screen.PrimaryScreen.Bounds.Height)
            {
                this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height;
            }
            if (Right > Screen.PrimaryScreen.Bounds.Width)
            {
                this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
            }
        }
    }
}
