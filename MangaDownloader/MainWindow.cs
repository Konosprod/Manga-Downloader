using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using QAD;
    

namespace MangaDownloader
{
    public partial class MainWindow : Form
    {
        private List<String> newChapters;
        private List<MangaPlugin> plugins;
        private WebClient webClient;

        public MainWindow()
        {
            InitializeComponent();
            Config.loadConfig();

            newChapters = new List<String>();
            webClient = new WebClient();

            webClient.DownloadFileCompleted += webClient_DownloadFileCompleted;
            webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;

            if(this.listBox1.Items.Count > 0)
                this.listBox1.SetSelected(0, true);

            PluginLoader pluginLoader = new PluginLoader();

            plugins = pluginLoader.loadPlugins("Plugins/").ToList();
        }

        void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            toolStripProgressBar1.Value = (int)e.BytesReceived / 100;
        }

        void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            ajouterDesPluginsToolStripMenuItem.Enabled = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Config.saveConfig();
        }

        private void updateStore()
        {
            toolStripStatusLabel1.Text = "Updating store...";
            webClient.DownloadFileAsync(new Uri("https://www.konosprod.fr/store.xml"), "store.xml");
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            int i = 0;
            int endBaseUrl = textBox1.Text.IndexOf('/', 7);

            String baseUrl = textBox1.Text.Substring(0, endBaseUrl+1);

            while(i < plugins.Count)
            {
                if(plugins[0].Url == baseUrl)
                    break;
                i++;
            }

            ListChaptersWindow listChaptersWindow = new ListChaptersWindow(plugins[i], textBox1.Text);

            listChaptersWindow.ShowDialog();

            plugins[i].Clear();
        }

        private void préférencesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PreferencesWindow preferencesWindow = new PreferencesWindow();

            preferencesWindow.ShowDialog();
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportWindow exportWindow = new ExportWindow();
            exportWindow.exportType = ExportType.PDF;

            exportWindow.ShowDialog();
        }

        private void epubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportWindow exportWindow = new ExportWindow();
            exportWindow.exportType = ExportType.EPUB;

            exportWindow.ShowDialog();
        }

        private void ajouterDesPluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPluginWindow addPluginWindow = new AddPluginWindow();

            addPluginWindow.ShowDialog();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AProposWindow aProposWindow = new AProposWindow();

            aProposWindow.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddMangaWindow addWindow = new AddMangaWindow();

            if(addWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.listBox1.Items.Add(addWindow.MangaName);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;

            if (this.listBox1.SelectedItem != null)
            {
                selectedIndex = this.listBox1.SelectedIndex;
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);

                if(!(selectedIndex < this.listBox1.Items.Count))
                {
                    selectedIndex--;

                }

                if(this.listBox1.Items.Count > 0)
                    this.listBox1.SetSelected(selectedIndex, true);
            }
        }

        private void sitesSupportésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListPluginWindow listPluginWindow = new ListPluginWindow(plugins);

            listPluginWindow.ShowDialog();
        }

        private void buttonNews_Click(object sender, EventArgs e)
        {
            LogWindow logWindow = new LogWindow();

            logWindow.setList(newChapters);

            logWindow.ShowDialog();

            if(logWindow.Viewed)
            {
                newChapters.Clear();
            }
        }

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vérifier les mises à jour");
        }

        private void mettreÀJourLaListeDePluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateStore();
        }
    }
}
