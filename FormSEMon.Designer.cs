namespace SEM_log
{
    partial class FormSEMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSEMon));
            this.timerAutoOff = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mlUser = new MetroFramework.Controls.MetroLabel();
            this.mlTimer = new MetroFramework.Controls.MetroLabel();
            this.mlALO = new MetroFramework.Controls.MetroLabel();
            this.mbLogoff = new MetroFramework.Controls.MetroButton();
            this.timerCS = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerAutoOff
            // 
            this.timerAutoOff.Interval = 30000;
            this.timerAutoOff.Tick += new System.EventHandler(this.timerAutoOff_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mlUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mlTimer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlALO, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mbLogoff, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 72);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mlUser
            // 
            this.mlUser.AutoSize = true;
            this.mlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlUser.Location = new System.Drawing.Point(3, 0);
            this.mlUser.Name = "mlUser";
            this.mlUser.Size = new System.Drawing.Size(173, 36);
            this.mlUser.TabIndex = 0;
            this.mlUser.Text = "Current user: ";
            // 
            // mlTimer
            // 
            this.mlTimer.AutoSize = true;
            this.mlTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlTimer.Location = new System.Drawing.Point(3, 36);
            this.mlTimer.Name = "mlTimer";
            this.mlTimer.Size = new System.Drawing.Size(173, 36);
            this.mlTimer.TabIndex = 1;
            this.mlTimer.Text = "Current session:";
            // 
            // mlALO
            // 
            this.mlALO.AutoSize = true;
            this.mlALO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlALO.Location = new System.Drawing.Point(182, 36);
            this.mlALO.Name = "mlALO";
            this.mlALO.Size = new System.Drawing.Size(174, 36);
            this.mlALO.TabIndex = 2;
            this.mlALO.Text = "Autologoff 5min";
            // 
            // mbLogoff
            // 
            this.mbLogoff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbLogoff.Location = new System.Drawing.Point(182, 3);
            this.mbLogoff.Name = "mbLogoff";
            this.mbLogoff.Size = new System.Drawing.Size(174, 30);
            this.mbLogoff.TabIndex = 3;
            this.mbLogoff.Text = "Logoff";
            this.mbLogoff.UseSelectable = true;
            this.mbLogoff.Click += new System.EventHandler(this.mbLogoff_Click);
            // 
            // FormSEMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 152);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSEMon";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SEMlog";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormSEMon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerAutoOff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel mlUser;
        private MetroFramework.Controls.MetroLabel mlTimer;
        private MetroFramework.Controls.MetroLabel mlALO;
        private MetroFramework.Controls.MetroButton mbLogoff;
        private System.Windows.Forms.Timer timerCS;
    }
}