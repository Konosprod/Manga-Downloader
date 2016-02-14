using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

struct Plugin
{
    public String Creator;
    public String Version;
    public String Description;
    public String Url;
    public String Name;
    public String Download;
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
            XmlDocument store = new XmlDocument();
            try
            {
                store.Load("store.xml");
            }
            catch(Exception e)
            {
                MessageBox.Show("Impossible d'ouvrir le fichier : store.xml\nVeuillez mettre à jour votre liste de plugins.");
                return;
            }

            XmlNode plugins = store.DocumentElement.SelectSingleNode("/plugins");

            foreach(XmlNode node in plugins.ChildNodes)
            {
                Plugin p = new Plugin();

                p.Creator = node.SelectSingleNode("creator").InnerText;
                p.Description = node.SelectSingleNode("description").InnerText;
                p.Name = node.SelectSingleNode("name").InnerText;
                p.Url = node.SelectSingleNode("url").InnerText;
                p.Version = node.SelectSingleNode("version").InnerText;
                p.Download = node.SelectSingleNode("download").InnerText;

                this.plugins.Add(p);
                listBox1.Items.Add(p.Name);
            }
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            labelCreator.Text = "Createur : " + plugins[index].Creator;
            labelDescription.Text = plugins[index].Description;
            labelNom.Text = "Nom      : " + plugins[index].Name;
            labelUrl.Text = "URL      : " + plugins[index].Url;
            labelVersion.Text = "Version  : " + plugins[index].Version;
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
