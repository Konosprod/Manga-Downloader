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
    public partial class AProposWindow : Form
    {
        public AProposWindow()
        {
            InitializeComponent();

            loadVersion();
            loadLicence();
        }

        private void loadVersion()
        {
            this.labelVersion.Text = "Version : " + Config.getVersion();
        }

        private void loadLicence()
        {
            this.textBoxLicence.Text = Config.getLicence();
            this.textBoxLicence.ReadOnly = true;
        }
    }
}
