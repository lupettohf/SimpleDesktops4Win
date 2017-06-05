using Microsoft.Win32;
using System.Windows.Forms;

namespace SimpleDesktops4Win.utils
{
    class registryUtils
    {
        public static void setStartup(bool enable)
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
        public static void setQualityFix(bool enable)
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            if (enable)
            {
                regKey.SetValue("JPEGImportQuality", unchecked((int)0x64), RegistryValueKind.DWord);
            } else
            {
                regKey.DeleteValue("JPEGImportQuality", false);
            }
        }
    }
}
