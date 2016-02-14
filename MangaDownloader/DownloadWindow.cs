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
using QAD;


// Revoir la méthode asynchrone fin/début de télécharge du chapitre suivant
// Problème, GUI terminé alors que téléchargement encore en cours derrière.


namespace MangaDownloader
{
    public partial class DownloadWindow : Form
    {
        private AQueue queue;
        private List<Chapter> chapters;
        private MangaPlugin plugin;
        private WebClient webClient;
        private QADDownloader downloader;
        private int currentChapter;

        public DownloadWindow(List<Chapter> chapters, MangaPlugin plugin)
        {
            InitializeComponent();

            queue = new AQueue();
            webClient = new WebClient();

            webClient.DownloadStringCompleted += webClient_DownloadStringCompleted;

            this.chapters = chapters;
            this.plugin = plugin;

            currentChapter = 0;

            statusLabel.Text = "Fetching chapter : " + currentChapter.ToString() + "/" + chapters.Count.ToString();
            statusProgressBar.Maximum = chapters.Count;
            loadImages();
        }

        void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            File f = plugin.getImage(e.Result);

            f.extension = System.IO.Path.GetExtension(f.url);
            f.path = GetSafeFilename(plugin.Manga.Name) + "/" + GetSafeFilename(chapters[currentChapter].Name) + "/";

            if (!System.IO.Directory.Exists(f.path))
                System.IO.Directory.CreateDirectory(f.path);

            queue.Enqueue(f);

            if(currentChapter < chapters.Count)
            {
                if (chapters[currentChapter].Pages.Count == 0)
                {
                    startDownload();
                }
                else
                {
                    loadImages();
                }
            }
            else
            {
                MessageBox.Show("here");
            }
        }

        private void startDownload()
        {
            downloader = new QADDownloader(queue);
            downloader.maxParallalDownload = 1;

            downloader.ProgressChanged += downloader_ProgressChanged;
            downloader.DownloadsFinished += downloader_DownloadsFinished;

            statusLabel.Text = "Fetching chapter : " + (currentChapter+1).ToString() + "/" + chapters.Count.ToString();

            downloader.startDownloads();
        }

        void downloader_DownloadsFinished(object sender, EventArgs e)
        {
            statusProgressBar.Value++;
            currentChapter++;

            if (currentChapter >= chapters.Count)
            {
                MessageBox.Show("Téléchargement terminé !");
                this.buttonCancel.Text = "Fermer";
                downloader = null;
            }
            else
            {
                loadImages();
            }
        }

        void downloader_ProgressChanged(object sender, ProgressEventArgs e)
        {
            progressBar1.Value = e.Current;
            progressBar1.Maximum = e.Total;

            label1.Text = e.Current.ToString() + "/" + e.Total.ToString();
        }

        private void loadImages()
        {
            String s = chapters[currentChapter].Pages[0];
            
            chapters[currentChapter].Pages.Remove(s);

            webClient.DownloadStringAsync(new Uri(s));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            if(downloader != null)
                downloader.cancelDownloads();
            
            this.Close();
        }

        private string GetSafeFilename(string filename)
        {
            return string.Join("_", filename.Split(System.IO.Path.GetInvalidFileNameChars()));
        }
    }
}
