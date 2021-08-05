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
        bool isGuide = false;
        bool isShrink = false;
        // 边缘感应距离
        const int GUIDE_DISTANCE = 30;
        // 窗体靠边凸出显示部分距离
        const int BULGE_DISTANCE = 5;

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


        private void GuideFrm()
        {
            /* 判断窗体边缘是否进入引导距离
             * true     靠边，“isGuide = false;”，窗体已引导
             * false    “isGuide = false;”，窗体未引导
            if (this.Left < GUIDE_DISTANCE && this.Left > -GUIDE_DISTANCE)
            {
                this.Left = 0;
                isGuide = true;
            }
             */
            if (this.Top < GUIDE_DISTANCE && this.Top > -GUIDE_DISTANCE)
            {
                this.Top = 0;
                isGuide = true;
            }
            /*
            else if (this.Right < (Screen.GetWorkingArea(this).Width + GUIDE_DISTANCE) && this.Right > (Screen.GetWorkingArea(this).Width - GUIDE_DISTANCE))
            {
                this.Left = Screen.GetWorkingArea(this).Width - this.Width;
                isGuide = true;
            }
            */
            else
            {
                isGuide = false;
            }
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

        private void mbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_Move(object sender, EventArgs e)
        {
            GuideFrm();
        }

        private void timerHideToEdge_Tick(object sender, EventArgs e)
        {
            ZoomFrm();
        }
        private void ShowFrm()
        {
            // 窗体是否靠边
            if (this.Left == -(this.Width - BULGE_DISTANCE))
            {
                this.Left = 0;
            }
            else if (this.Top == -(this.Height - BULGE_DISTANCE))
            {
                this.Top = 0;
            }
            else if (this.Right == Screen.GetWorkingArea(this).Width + this.Width - BULGE_DISTANCE)
            {
                this.Left = Screen.GetWorkingArea(this).Width - this.Width;
            }
            // 窗体未隐藏
            isShrink = false;


            // 窗口不置顶
            //this.TopMost = false;
            // 在Windows任务栏中显示窗体
            //this.ShowInTaskbar = true;
        }

        private void HideFrm()
        {
            /* 窗体是否靠边
             * true     窗体隐藏
             * false    
             */
            if (this.Left == 0)
            {
                this.Left = -(this.Width - BULGE_DISTANCE);
            }
            else if (this.Top == 0)
            {
                this.Top = -(this.Height - BULGE_DISTANCE);
            }
            else if (this.Right == (Screen.GetWorkingArea(this).Width))
            {
                this.Left = Screen.GetWorkingArea(this).Width - BULGE_DISTANCE;
            }
            // 窗体已隐藏
            isShrink = true;
            // 窗体引导关闭
            isGuide = false;


            // 窗体置顶
            //this.TopMost = true;
            // 在Windows任务栏中不显示窗体
            //this.ShowInTaskbar = false;
        }

        private void ZoomFrm()
        {
            // 获取鼠标位置
            int mouseX = MousePosition.X;
            int mouseY = MousePosition.Y;
            // 获取窗体位置
            int frmX = this.Location.X;
            int frmY = this.Location.Y;


            /* 鼠标是否在窗体内
             * true     显示窗体
             * false    隐藏窗体
             */
            if (mouseX > frmX - 1 && mouseX < frmX + this.Width + 1 && mouseY > frmY - 1 && mouseY < frmY + this.Height + 1)
            {
                // 窗体隐藏时才显示窗体
                if (isShrink)
                {
                    ShowFrm();
                }
            }
            else
            {
                // 窗体引导时才隐藏窗体
                if (isGuide)
                {
                    HideFrm();
                }
            }
        }

        private void FormLogin_LocationChanged(object sender, EventArgs e)
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
