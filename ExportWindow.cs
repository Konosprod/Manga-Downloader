using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum ExportType
{
    PDF,
    EPUB
};

namespace MangaDownloader
{
    public partial class ExportWindow : Form
    {
        public ExportType exportType;

        private String folderIn;
        private String fileOut;

        public ExportWindow()
        {
            InitializeComponent();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            String txt = "Export en : ";
            txt += (this.exportType == ExportType.PDF) ? "PDF" : "EPUB";
            txt += "\n" + textBox1.Text + "\n" + textBox2.Text;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MessageBox.Show(txt);
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

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folderIn = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                folderIn = "";
            }

            textBox1.Text = folderIn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = (exportType == ExportType.PDF) ? ".pdf" : ".epub";

            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileOut = saveFileDialog1.FileName;
            }
            else
            {
                fileOut = "";
            }

            textBox2.Text = fileOut;
        }

    }
}
