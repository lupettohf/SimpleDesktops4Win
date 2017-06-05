using System;
using System.Threading;
using System.Windows.Forms;
namespace SimpleDesktops4Win
{
    public partial class Main : Form
    {
        private int current_offset = 0;
        private int current_wallpaper = 0;
        private int total_wallpapers;
        private RootObject parsedData;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            updateWallpaperData(current_offset);
            if (Convert.ToBoolean(Properties.Settings.Default["AutoChange"]))
            {
                timerChangeBackgound.Enabled = true;
                timerChangeBackgound.Interval = (int) TimeSpan.FromMinutes(Convert.ToInt32(Properties.Settings.Default["RefreshTime"])).TotalMilliseconds;
            } else
            {
                timerChangeBackgound.Enabled = false;
            }
        }

        private void updateWallpaperData(int offset)
        {
            try
            {
                RootObject wallpaperdata = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(webCl.downloadRawWPList(current_offset));
                parsedData = wallpaperdata;
                total_wallpapers = wallpaperdata.meta.total_count;
                wpSelector.Items.Clear();
                foreach (var wallpaper in wallpaperdata.objects)
                {
                    wpSelector.Items.Add(new WallPaperItem { WallpaperName = wallpaper.title, WallpaperId = wallpaper.id });
                }
                wpSelector.SelectedIndex = 0;
                toolStripLabelCurrentpage.Text = String.Format("Current Page: {0}/{1}", current_offset / 24, total_wallpapers / 24);
            }catch (Exception) { }
        }

        public void downloadSetBackground(string url)
        {
            try { utils.wallpaperAgent.Set(webCl.downloadImage(url)); } catch(Exception) { }
        }

        private void wpSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentWallpaper = parsedData.objects.Find(x => x.id == ((WallPaperItem)wpSelector.SelectedItem).WallpaperId.ToString());
            pictureBoxCurWallpaper.Image = webCl.downloadImage(currentWallpaper.iphone_thumb);
            labelTitle.Text = String.Format("Title: {0}", currentWallpaper.title);
            labelAuthor.Text = String.Format("Author: {0}", currentWallpaper.creator.name);           
        }

        private class WallPaperItem
        {
            public string WallpaperName { get; set; }
            public object WallpaperId { get; set; }

            public override string ToString()
            {
                return WallpaperName;
            }
        }

        private void toolStripButtonSetCurrent_Click(object sender, EventArgs e)
        {
            var currentWallpaper = parsedData.objects.Find(x => x.id == ((WallPaperItem)wpSelector.SelectedItem).WallpaperId.ToString());
            try {
                Thread downloadAndSet = new Thread(o => { downloadSetBackground((string)o); });
                downloadAndSet.Start(currentWallpaper.url);
            } catch (Exception) { }
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            if(current_offset == 0)
            {
                return;
            } else {
                current_offset -= 24;
                updateWallpaperData(current_offset);
            }
        }

        private void toolStripButtonForward_Click(object sender, EventArgs e)
        {
            if(current_offset == total_wallpapers / 24)
            {
                return;
            } else {
                current_offset += 24;
                updateWallpaperData(current_offset);
            }
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.Show();
        }

        private void timerChanegBackgound_Tick(object sender, EventArgs e)
        {
            if(current_wallpaper == 24 && !(current_offset == total_wallpapers / 24)) { current_offset += 24; current_wallpaper = 0; }
            else { current_offset = 0; current_wallpaper = 0; }
            var currentWallpaper = parsedData.objects[current_wallpaper];
            try
            {
                Thread downloadAndSet = new Thread(o => { downloadSetBackground((string)o); });
                downloadAndSet.Start(currentWallpaper.url);
                current_wallpaper++;
            }
            catch (Exception) { }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            notifyIconControl.ShowBalloonTip(5000);
            Hide();
        }

        private void notifyIconControl_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
