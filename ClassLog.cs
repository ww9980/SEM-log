using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEM_log
{
    public class cLog
    {
        public cLog(string u, string ON) 
        {
            user = u;
            ONtimestamp = ON;
        }

        public cLog() { }

        public string user;
        public string ONtimestamp;
        public string OFFtimestamp;
        public bool OFFflagAuto;
        public bool OFFflagEDX;
        public bool OFFflagBSD;
        public bool OFFflagError;
        public string OFFnote;
        public string totalmin;
        public int currentON=0;
        public int currentOFF=0;
        public double ratio = 0.0;
        public double GunVacA = 0.0;
        public double GunVacB = 0.0;

        public void writeToFile()
        {
            string path = @"C:\\SEMlog\\" + DateTime.Now.ToString("yyyyMMdd");
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch  (Exception e)
                {
                    MessageBox.Show("Error when creating log folder. \n" + e.ToString()
                        +"\nPlease run this program as admin. " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string fpath = path + "\\" + OFFtimestamp.Replace(":", "");
            if (File.Exists(fpath))
            {
                MessageBox.Show("Error when creating log file. \n" 
                        + "\nFile already exists. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string output = JsonConvert.SerializeObject(this);
            File.WriteAllText(fpath, output);
        }

    }
}
