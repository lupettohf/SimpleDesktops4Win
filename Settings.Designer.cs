namespace SimpleDesktops4Win
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.AboutBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkIconsMind = new System.Windows.Forms.LinkLabel();
            this.linkSimpleDesktopsAbout = new System.Windows.Forms.LinkLabel();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.AboutText = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.checkBoxUseTimer = new System.Windows.Forms.CheckBox();
            this.groupBoxDivide = new System.Windows.Forms.GroupBox();
            this.AboutBox.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutBox
            // 
            this.AboutBox.Controls.Add(this.label2);
            this.AboutBox.Controls.Add(this.label1);
            this.AboutBox.Controls.Add(this.linkIconsMind);
            this.AboutBox.Controls.Add(this.linkSimpleDesktopsAbout);
            this.AboutBox.Controls.Add(this.linkGithub);
            this.AboutBox.Controls.Add(this.AboutText);
            this.AboutBox.Location = new System.Drawing.Point(4, 76);
            this.AboutBox.Name = "AboutBox";
            this.AboutBox.Size = new System.Drawing.Size(271, 89);
            this.AboutBox.TabIndex = 0;
            this.AboutBox.TabStop = false;
            this.AboutBox.Text = "About";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            // 
            // linkIconsMind
            // 
            this.linkIconsMind.AutoSize = true;
            this.linkIconsMind.Location = new System.Drawing.Point(56, 70);
            this.linkIconsMind.Name = "linkIconsMind";
            this.linkIconsMind.Size = new System.Drawing.Size(56, 13);
            this.linkIconsMind.TabIndex = 3;
            this.linkIconsMind.TabStop = true;
            this.linkIconsMind.Text = "IconsMind";
            this.linkIconsMind.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkIconsMind_LinkClicked);
            // 
            // linkSimpleDesktopsAbout
            // 
            this.linkSimpleDesktopsAbout.AutoSize = true;
            this.linkSimpleDesktopsAbout.Location = new System.Drawing.Point(120, 70);
            this.linkSimpleDesktopsAbout.Name = "linkSimpleDesktopsAbout";
            this.linkSimpleDesktopsAbout.Size = new System.Drawing.Size(114, 13);
            this.linkSimpleDesktopsAbout.TabIndex = 2;
            this.linkSimpleDesktopsAbout.TabStop = true;
            this.linkSimpleDesktopsAbout.Text = "SimpleDesktops About";
            this.linkSimpleDesktopsAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSimpleDesktopsAbout_LinkClicked);
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Location = new System.Drawing.Point(8, 70);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(38, 13);
            this.linkGithub.TabIndex = 1;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "Github";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // AboutText
            // 
            this.AboutText.AutoSize = true;
            this.AboutText.Location = new System.Drawing.Point(8, 16);
            this.AboutText.Name = "AboutText";
            this.AboutText.Size = new System.Drawing.Size(253, 52);
            this.AboutText.TabIndex = 0;
            this.AboutText.Text = resources.GetString("AboutText.Text");
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.groupBoxDivide);
            this.groupBoxSettings.Controls.Add(this.labelMinutes);
            this.groupBoxSettings.Controls.Add(this.numericUpDownTime);
            this.groupBoxSettings.Controls.Add(this.checkBoxUseTimer);
            this.groupBoxSettings.Location = new System.Drawing.Point(4, 1);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(271, 75);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(76, 44);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(44, 13);
            this.labelMinutes.TabIndex = 2;
            this.labelMinutes.Text = "Minutes";
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Location = new System.Drawing.Point(8, 41);
            this.numericUpDownTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownTime.TabIndex = 1;
            this.numericUpDownTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // checkBoxUseTimer
            // 
            this.checkBoxUseTimer.AutoSize = true;
            this.checkBoxUseTimer.Location = new System.Drawing.Point(8, 18);
            this.checkBoxUseTimer.Name = "checkBoxUseTimer";
            this.checkBoxUseTimer.Size = new System.Drawing.Size(131, 17);
            this.checkBoxUseTimer.TabIndex = 0;
            this.checkBoxUseTimer.Text = "Change backgroud in:";
            this.checkBoxUseTimer.UseVisualStyleBackColor = true;
            // 
            // groupBoxDivide
            // 
            this.groupBoxDivide.Location = new System.Drawing.Point(137, 0);
            this.groupBoxDivide.Name = "groupBoxDivide";
            this.groupBoxDivide.Size = new System.Drawing.Size(134, 75);
            this.groupBoxDivide.TabIndex = 3;
            this.groupBoxDivide.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 168);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.AboutBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings & About";
            this.AboutBox.ResumeLayout(false);
            this.AboutBox.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AboutBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkIconsMind;
        private System.Windows.Forms.LinkLabel linkSimpleDesktopsAbout;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.Label AboutText;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.CheckBox checkBoxUseTimer;
        private System.Windows.Forms.GroupBox groupBoxDivide;
    }
}