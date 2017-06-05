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
    }
}
