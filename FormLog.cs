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
    }
}
