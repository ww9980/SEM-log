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
        public FormLogoff(string username)
        {
            InitializeComponent();
            mtbUser.Text = username;
            mtbUser.Enabled = false;
        }

        private void FormLogoff_Load(object sender, EventArgs e)
        {

        }
    }
}
