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
    public partial class AddWindow : Form
    {
        public String UrlFeed;
        public String UrlManga;
        public String MangaName;

        public AddWindow()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UrlFeed = textBox3.Text;
            UrlManga = textBox1.Text;
            MangaName = textBox2.Text;

            if (UrlFeed != "" && UrlManga != "" && MangaName != "")
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("Vous devez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
