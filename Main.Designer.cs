namespace SimpleDesktops4Win
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBoxRect = new System.Windows.Forms.GroupBox();
            this.wpSelector = new System.Windows.Forms.ComboBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxCurWallpaper = new System.Windows.Forms.PictureBox();
            this.toolStripSettings = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelCurrentpage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonSetCurrent = new System.Windows.Forms.ToolStripButton();
            this.timerChangeBackgound = new System.Windows.Forms.Timer(this.components);
            this.notifyIconControl = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBoxRect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurWallpaper)).BeginInit();
            this.toolStripSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRect
            // 
            this.groupBoxRect.Controls.Add(this.wpSelector);
            this.groupBoxRect.Controls.Add(this.labelAuthor);
            this.groupBoxRect.Controls.Add(this.labelTitle);
            this.groupBoxRect.Controls.Add(this.pictureBoxCurWallpaper);
            this.groupBoxRect.Location = new System.Drawing.Point(12, 28);
            this.groupBoxRect.Name = "groupBoxRect";
            this.groupBoxRect.Size = new System.Drawing.Size(328, 240);
            this.groupBoxRect.TabIndex = 2;
            this.groupBoxRect.TabStop = false;
            // 
            // wpSelector
            // 
            this.wpSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wpSelector.FormattingEnabled = true;
            this.wpSelector.Location = new System.Drawing.Point(190, 206);
            this.wpSelector.Name = "wpSelector";
            this.wpSelector.Size = new System.Drawing.Size(132, 21);
            this.wpSelector.TabIndex = 3;
            this.wpSelector.SelectedIndexChanged += new System.EventHandler(this.wpSelector_SelectedIndexChanged);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(6, 216);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(87, 13);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author: loading...";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(6, 203);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(76, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title: loading...";
            // 
            // pictureBoxCurWallpaper
            // 
            this.pictureBoxCurWallpaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCurWallpaper.BackgroundImage")));
            this.pictureBoxCurWallpaper.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCurWallpaper.ErrorImage")));
            this.pictureBoxCurWallpaper.ImageLocation = "Center";
            this.pictureBoxCurWallpaper.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCurWallpaper.InitialImage")));
            this.pictureBoxCurWallpaper.Location = new System.Drawing.Point(19, 19);
            this.pictureBoxCurWallpaper.Name = "pictureBoxCurWallpaper";
            this.pictureBoxCurWallpaper.Size = new System.Drawing.Size(290, 181);
            this.pictureBoxCurWallpaper.TabIndex = 0;
            this.pictureBoxCurWallpaper.TabStop = false;
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSettings,
            this.toolStripSeparator1,
            this.toolStripButtonBack,
            this.toolStripButtonForward,
            this.toolStripSeparator2,
            this.toolStripButtonExit,
            this.toolStripLabelCurrentpage,
            this.toolStripButtonSetCurrent});
            this.toolStripSettings.Location = new System.Drawing.Point(0, 0);
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(352, 25);
            this.toolStripSettings.TabIndex = 3;
            this.toolStripSettings.Text = "toolStrip1";
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSettings.Text = "Settings & About";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBack.Image")));
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBack.Text = "Previous page";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // toolStripButtonForward
            // 
            this.toolStripButtonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonForward.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonForward.Image")));
            this.toolStripButtonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForward.Name = "toolStripButtonForward";
            this.toolStripButtonForward.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonForward.Text = "Next page";
            this.toolStripButtonForward.Click += new System.EventHandler(this.toolStripButtonForward_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExit.Text = "Exit application";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // toolStripLabelCurrentpage
            // 
            this.toolStripLabelCurrentpage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelCurrentpage.Name = "toolStripLabelCurrentpage";
            this.toolStripLabelCurrentpage.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabelCurrentpage.Text = "Current Page:  0";
            // 
            // toolStripButtonSetCurrent
            // 
            this.toolStripButtonSetCurrent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSetCurrent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSetCurrent.Image")));
            this.toolStripButtonSetCurrent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetCurrent.Name = "toolStripButtonSetCurrent";
            this.toolStripButtonSetCurrent.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSetCurrent.Text = "Set current wallpaper";
            this.toolStripButtonSetCurrent.Click += new System.EventHandler(this.toolStripButtonSetCurrent_Click);
            // 
            // timerChangeBackgound
            // 
            this.timerChangeBackgound.Interval = 300000;
            this.timerChangeBackgound.Tick += new System.EventHandler(this.timerChanegBackgound_Tick);
            // 
            // notifyIconControl
            // 
            this.notifyIconControl.BalloonTipText = "Click here to open the app";
            this.notifyIconControl.BalloonTipTitle = "SimpleDesktops4Win";
            this.notifyIconControl.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconControl.Icon")));
            this.notifyIconControl.Text = "SimpleDesktops4Win";
            this.notifyIconControl.Visible = true;
            this.notifyIconControl.Click += new System.EventHandler(this.notifyIconControl_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 277);
            this.Controls.Add(this.toolStripSettings);
            this.Controls.Add(this.groupBoxRect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleDesktops4Win";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBoxRect.ResumeLayout(false);
            this.groupBoxRect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurWallpaper)).EndInit();
            this.toolStripSettings.ResumeLayout(false);
            this.toolStripSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxRect;
        private System.Windows.Forms.PictureBox pictureBoxCurWallpaper;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.ComboBox wpSelector;
        private System.Windows.Forms.ToolStrip toolStripSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripButton toolStripButtonForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCurrentpage;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetCurrent;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        public System.Windows.Forms.Timer timerChangeBackgound;
        private System.Windows.Forms.NotifyIcon notifyIconControl;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
    }
}

