using Microsoft.Win32;
using System.Windows.Forms;

namespace SimpleDesktops4Win.utils
{
    class registryUtils
    {
        private void setStartup(bool enable)
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if(enable)
            {
                regKey.SetValue("SimpleDesktops4Win", Application.ExecutablePath.ToString());
            } else
            {
                regKey.DeleteValue("SimpleDesktops4Win", false);
            }
        }
        /*
         * By default windows reduces the background quality to the equivalent of a 85% compressed jpg.
         * */
        private void setQualityFix(bool enable)
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("HKEY_CURRENT_USER\\Control Panel\\Desktop", true);
            if(enable)
            {
                regKey.SetValue("JPEGImportQuality", 100);
            } else
            {
                regKey.DeleteValue("JPEGImportQuality", false);
            }
        }
    }
}
