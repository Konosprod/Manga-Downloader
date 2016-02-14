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
    public partial class PreferencesWindow : Form
    {
        public PreferencesWindow()
        {
            InitializeComponent();

            this.textBoxOutputDirectory.Text = Config.getSavePath();
            this.textBoxSavePathScheme.Text = Config.getPathScheme();
            this.textBoxFilenameScheme.Text = Config.getFilenameScheme();
            this.textBoxSaveOutput.Text = Config.getSaveOutput();
            this.checkBoxUseFileOutput.Checked = Config.getUseFileOutput();
            this.checkBoxUseWebInterface.Checked = Config.getUseWebInterface();
            this.timeIntervalSelector.Value = Config.getTimeInterval();

            this.checkBoxUseFileOutput.CheckedChanged += checkBoxUseFileOutput_CheckedChanged;
            
            this.buttonBrowseOutput.Enabled = this.checkBoxUseFileOutput.Checked;
            this.textBoxSaveOutput.Enabled = this.checkBoxUseFileOutput.Checked;
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Config.setFilenameScheme(this.textBoxFilenameScheme.Text);
                Config.setSaveOutput(this.saveFileDialog1.FileName);
                Config.setSavePath(this.textBoxOutputDirectory.Text);
                Config.setTimeInterval((int)this.timeIntervalSelector.Value);
                Config.setUseFileOutput(this.checkBoxUseFileOutput.Checked);
            }
        }

        void checkBoxUseFileOutput_CheckedChanged(object sender, EventArgs e)
        {
            this.buttonBrowseOutput.Enabled = this.checkBoxUseFileOutput.Checked;
            this.textBoxSaveOutput.Enabled = this.checkBoxUseFileOutput.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBoxOutputDirectory.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void buttonBrowseOutput_Click(object sender, EventArgs e)
        {
            String filename = this.textBoxSaveOutput.Text;

            if(filename.Contains("\\"))
            {
                filename = filename.Substring(filename.LastIndexOf("\\")+1);
            }

            this.saveFileDialog1.FileName = filename;

            if(this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBoxSaveOutput.Text = this.saveFileDialog1.FileName;
            }
        }
    }
}
