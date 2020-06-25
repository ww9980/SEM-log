namespace SEM_log
{
    partial class FormLogoff
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mbOK = new MetroFramework.Controls.MetroButton();
            this.mtbUser = new MetroFramework.Controls.MetroTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbEDX = new MetroFramework.Controls.MetroCheckBox();
            this.cbBSD = new MetroFramework.Controls.MetroCheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbNoErr = new MetroFramework.Controls.MetroRadioButton();
            this.rbErr = new MetroFramework.Controls.MetroRadioButton();
            this.mtbNote = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mbOK, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.mtbUser, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mtbNote, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "User:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 37);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(122, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Extra function used:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Any error?";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 111);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(102, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Note/comment:";
            // 
            // mbOK
            // 
            this.mbOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.mbOK.Location = new System.Drawing.Point(592, 336);
            this.mbOK.Name = "mbOK";
            this.mbOK.Size = new System.Drawing.Size(165, 31);
            this.mbOK.TabIndex = 5;
            this.mbOK.Text = "OK";
            this.mbOK.UseSelectable = true;
            // 
            // mtbUser
            // 
            // 
            // 
            // 
            this.mtbUser.CustomButton.Image = null;
            this.mtbUser.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.mtbUser.CustomButton.Name = "";
            this.mtbUser.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.mtbUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbUser.CustomButton.TabIndex = 1;
            this.mtbUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbUser.CustomButton.UseSelectable = true;
            this.mtbUser.CustomButton.Visible = false;
            this.mtbUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.mtbUser.Lines = new string[] {
        "User"};
            this.mtbUser.Location = new System.Drawing.Point(220, 3);
            this.mtbUser.MaxLength = 32767;
            this.mtbUser.Name = "mtbUser";
            this.mtbUser.PasswordChar = '\0';
            this.mtbUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbUser.SelectedText = "";
            this.mtbUser.SelectionLength = 0;
            this.mtbUser.SelectionStart = 0;
            this.mtbUser.ShortcutsEnabled = true;
            this.mtbUser.Size = new System.Drawing.Size(232, 31);
            this.mtbUser.TabIndex = 6;
            this.mtbUser.Text = "User";
            this.mtbUser.UseSelectable = true;
            this.mtbUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbEDX);
            this.flowLayoutPanel1.Controls.Add(this.cbBSD);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(220, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(537, 31);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // cbEDX
            // 
            this.cbEDX.AutoSize = true;
            this.cbEDX.Location = new System.Drawing.Point(3, 3);
            this.cbEDX.Name = "cbEDX";
            this.cbEDX.Size = new System.Drawing.Size(44, 15);
            this.cbEDX.TabIndex = 0;
            this.cbEDX.Text = "EDX";
            this.cbEDX.UseSelectable = true;
            // 
            // cbBSD
            // 
            this.cbBSD.AutoSize = true;
            this.cbBSD.Location = new System.Drawing.Point(53, 3);
            this.cbBSD.Name = "cbBSD";
            this.cbBSD.Size = new System.Drawing.Size(44, 15);
            this.cbBSD.TabIndex = 1;
            this.cbBSD.Text = "BSD";
            this.cbBSD.UseSelectable = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rbNoErr);
            this.flowLayoutPanel2.Controls.Add(this.rbErr);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(220, 77);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(537, 31);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // rbNoErr
            // 
            this.rbNoErr.AutoSize = true;
            this.rbNoErr.Location = new System.Drawing.Point(3, 3);
            this.rbNoErr.Name = "rbNoErr";
            this.rbNoErr.Size = new System.Drawing.Size(116, 15);
            this.rbNoErr.TabIndex = 0;
            this.rbNoErr.Text = "NO - all goooood";
            this.rbNoErr.UseSelectable = true;
            // 
            // rbErr
            // 
            this.rbErr.AutoSize = true;
            this.rbErr.Location = new System.Drawing.Point(125, 3);
            this.rbErr.Name = "rbErr";
            this.rbErr.Size = new System.Drawing.Size(163, 15);
            this.rbErr.TabIndex = 1;
            this.rbErr.Text = "ERROR - requires attention";
            this.rbErr.UseSelectable = true;
            // 
            // mtbNote
            // 
            // 
            // 
            // 
            this.mtbNote.CustomButton.Image = null;
            this.mtbNote.CustomButton.Location = new System.Drawing.Point(323, 2);
            this.mtbNote.CustomButton.Name = "";
            this.mtbNote.CustomButton.Size = new System.Drawing.Size(211, 211);
            this.mtbNote.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNote.CustomButton.TabIndex = 1;
            this.mtbNote.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNote.CustomButton.UseSelectable = true;
            this.mtbNote.CustomButton.Visible = false;
            this.mtbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbNote.Lines = new string[] {
        "Fill in any details or comments"};
            this.mtbNote.Location = new System.Drawing.Point(220, 114);
            this.mtbNote.MaxLength = 32767;
            this.mtbNote.Multiline = true;
            this.mtbNote.Name = "mtbNote";
            this.mtbNote.PasswordChar = '\0';
            this.mtbNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNote.SelectedText = "";
            this.mtbNote.SelectionLength = 0;
            this.mtbNote.SelectionStart = 0;
            this.mtbNote.ShortcutsEnabled = true;
            this.mtbNote.Size = new System.Drawing.Size(537, 216);
            this.mtbNote.TabIndex = 9;
            this.mtbNote.Text = "Fill in any details or comments";
            this.mtbNote.UseSelectable = true;
            this.mtbNote.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNote.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormLogoff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormLogoff";
            this.Resizable = false;
            this.Text = "Log off";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormLogoff_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton mbOK;
        private MetroFramework.Controls.MetroTextBox mtbUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroCheckBox cbEDX;
        private MetroFramework.Controls.MetroCheckBox cbBSD;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroRadioButton rbNoErr;
        private MetroFramework.Controls.MetroRadioButton rbErr;
        private MetroFramework.Controls.MetroTextBox mtbNote;
    }
}