using System;
using System.Drawing;
using System.IO;
using System.Net;

namespace SimpleDesktops4Win
{
    class webCl
    {
        public static string APIHOST = "http://api.simpledesktops.com";
        public static string APIPATH = "/v1/desktop_mobile/?format=json";

        private static WebClient client = new WebClient();

        public static string downloadRawWPList(int offset)
        {
            return client.DownloadString(APIHOST + APIPATH + "&offset=" + offset + "&limit=24");           
        }
        public static Image downloadImage(string url)
        {
            using (var ms = new MemoryStream(client.DownloadData(url)))
            {
                return Image.FromStream(ms);
            }
        }

    }
}
