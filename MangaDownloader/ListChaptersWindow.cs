using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace MangaDownloader
{
    public partial class ListChaptersWindow : Form
    {
        private WebClient webClient;
        private String htmlSource = "";
        private MangaPlugin plugin;
        private String url;
        private List<Chapter> chapters;
        private List<Chapter> toDL;
        private Manga manga;

        public ListChaptersWindow(MangaPlugin plugin, String url)
        {
            InitializeComponent();

            webClient = new WebClient();
            toDL = new List<Chapter>();

            this.plugin = plugin;
            this.url = url;

            webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
            webClient.DownloadStringCompleted += webClient_DownloadStringCompleted;

            webClient.DownloadStringAsync(new Uri(url));

            toolStripStatusLabel1.Text = "Getting availabe chapters...";
            
        }

        void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            htmlSource = e.Result;

            initializeManga();
        }

        void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void initializeManga()
        {
            manga = plugin.getMangaInfo(htmlSource);
            chapters = plugin.getChapters(htmlSource);

            loadChapters();
        }

        private void loadChapters()
        {
            label1.Text = "Auteur : " + manga.Author;
            label2.Text = "Nom    : " + manga.Name;
 
            foreach(Chapter chapter in chapters)
            {
                checkedListBox1.Items.Add(chapter.Name, true);
            }

            buttonDeselectAll.Enabled = true;
            buttonDownload.Enabled = true;
            buttonSelectAll.Enabled = true;


            //Reinitialisation du callback
            webClient.DownloadStringCompleted -= webClient_DownloadStringCompleted;
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if(checkedListBox1.GetItemChecked(i))
                {
                    chapters[i].Pages = plugin.getPages(webClient.DownloadString(chapters[i].Url));
                    toDL.Add(chapters[i]);
                }
            }

            DownloadWindow downloadWindow = new DownloadWindow(toDL, plugin);

            downloadWindow.ShowDialog();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {   
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void buttonDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
