using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaDownloader
{
    public partial class ListPluginWindow : Form
    {

        private List<MangaPlugin> plugins;

        public ListPluginWindow(List<MangaPlugin> plugins)
        {
            InitializeComponent();

            this.plugins = plugins;
            listBox1.Items.Clear();

            foreach(MangaPlugin plugin in this.plugins)
            {
                listBox1.Items.Add(plugin.Name);
            }

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

            if (listBox1.Items.Count > 0)
                listBox1.SetSelected(0, true);
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            labelCreator.Text = "Creator : " + plugins[index].Creator;
            labelNom.Text = "Nom     : " + plugins[index].Name;
            labelUrl.Text     = "URL     : " + plugins[index].Url;
            labelVersion.Text = "Version : " + plugins[index].Version;
        }
    }
}
