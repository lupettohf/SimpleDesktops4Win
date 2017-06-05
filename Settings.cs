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

        private void checkBoxBoot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBoot.Checked)
            {
                Properties.Settings.Default["Startup"] = true;
                utils.registryUtils.setStartup(true);
            }
            else
            {
                Properties.Settings.Default["Startup"] = false;
                utils.registryUtils.setStartup(false);
            }
            Properties.Settings.Default.Save();
        }

        private void checkBoxFixQuality_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFixQuality.Checked)
            {
                Properties.Settings.Default["FixJPG"] = true;
                utils.registryUtils.setQualityFix(true);
            }
            else
            {
                Properties.Settings.Default["FixJPG"] = false;
                utils.registryUtils.setQualityFix(false);
            }
            Properties.Settings.Default.Save();
        }

        private void numericUpDownTime_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["RefreshTime"] = Convert.ToInt32(numericUpDownTime.Value);
            Properties.Settings.Default.Save();
        }

        private void linkLabelQualityInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Windows reduces the quality of JPEG images you set as the desktop background, this fix will force the transcoding quality to 100%.", "Wallpaper Transcoding Fix");
        }

    }
}
