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
    public partial class LogWindow : Form
    {
        public Boolean Viewed = false;

        public LogWindow()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            Viewed = true;
        }

        public void setList(List<String> list)
        {
            this.listBox1.Items.Clear();

            foreach(Object o in list)
            {
                this.listBox1.Items.Add(o);
            }
        }
    }
}
