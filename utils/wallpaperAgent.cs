using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
/*
 * Kudos to Neil N (https://stackoverflow.com/users/55164/neil-n)
 * Adapted from https://stackoverflow.com/questions/1061678/change-desktop-wallpaper-using-code-in-net
 */
namespace SimpleDesktops4Win.utils
{
    public sealed class wallpaperAgent
    {
        wallpaperAgent() { }

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public static void Set(Image Image)
        {
            try
            {
                string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
                Image.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);

                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

                key.SetValue(@"WallpaperStyle", 2.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());

                SystemParametersInfo(SPI_SETDESKWALLPAPER,
                    0,
                    tempPath,
                    SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            }
            catch (Exception e){}
        }
    }
}
