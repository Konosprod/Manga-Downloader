using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

struct Plugin
{
    public String Creator;
    public String Version;
    public String Description;
    public String Url;
    public String Name;
};

namespace MangaDownloader
{
    public partial class AddPluginWindow : Form
    {

        private List<Plugin> plugins;

        public AddPluginWindow()
        {
            InitializeComponent();

            plugins = new List<Plugin>();

            loadXML();

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

            if (listBox1.Items.Count > 0)
                listBox1.SetSelected(0, true);
        }

        private void loadXML()
        {

        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            labelCreator.Text = plugins[index].Creator;
            labelDescription.Text = plugins[index].Description;
            labelNom.Text = plugins[index].Name;
            labelUrl.Text = plugins[index].Url;
            labelVersion.Text = plugins[index].Version;


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Download plugin");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            this.Close();
        }
    }
}
