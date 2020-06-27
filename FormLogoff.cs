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
    public partial class FormLogoff : MetroFramework.Forms.MetroForm
    {
        public FormLogoff(cLog log)
        {
            InitializeComponent();
            currentLog = log;
        }

        private cLog currentLog;

        private void FormLogoff_Load(object sender, EventArgs e)
        {
            mtbUser.Text = currentLog.user;
            mtbUser.Enabled = false;
        }

        private void mbOK_Click(object sender, EventArgs e)
        {
            currentLog.OFFflagEDX = cbEDX.Checked;
            currentLog.OFFflagBSD = cbBSD.Checked;
            currentLog.OFFflagError = rbErr.Checked;
            currentLog.OFFnote = mtbNote.Text;
            currentLog.writeToFile();
            this.Close();
            var newform = new FormLogin();
            newform.Show();
        }
    }
}
