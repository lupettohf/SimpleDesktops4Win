using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleDesktops4Win
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, System.EventArgs e)
        {
            checkBoxUseTimer.Checked = Convert.ToBoolean(Properties.Settings.Default["AutoChange"]);
            numericUpDownTime.Value = Convert.ToInt32(Properties.Settings.Default["RefreshTime"]);
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/lupettohf");
        }

        private void linkIconsMind_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.iconsmind.com/");
        }

        private void linkSimpleDesktopsAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://simpledesktops.com/about/");
        }

        private void checkBoxUseTimer_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxUseTimer.Checked)
            {
                Properties.Settings.Default["AutoChange"] = true;
            } else {
                Properties.Settings.Default["AutoChange"] = false;
            }
            Properties.Settings.Default.Save();
        }

        private void numericUpDownTime_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["RefreshTime"] = Convert.ToInt32(numericUpDownTime.Value);
            Properties.Settings.Default.Save();
        }
    }
}
