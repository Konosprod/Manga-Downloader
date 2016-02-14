namespace MangaDownloader
{
    partial class PreferencesWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOutputDirectory = new System.Windows.Forms.TextBox();
            this.buttonBrowseDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSavePathScheme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFilenameScheme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timeIntervalSelector = new System.Windows.Forms.NumericUpDown();
            this.checkBoxUseFileOutput = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxSaveOutput = new System.Windows.Forms.TextBox();
            this.buttonBrowseOutput = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxUseWebInterface = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeIntervalSelector)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(302, 187);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxFilenameScheme);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxSavePathScheme);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonBrowseDirectory);
            this.tabPage1.Controls.Add(this.textBoxOutputDirectory);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(294, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Général";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.timeIntervalSelector);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(294, 161);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Suivi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dossier de sortie :";
            // 
            // textBoxOutputDirectory
            // 
            this.textBoxOutputDirectory.Location = new System.Drawing.Point(103, 10);
            this.textBoxOutputDirectory.Name = "textBoxOutputDirectory";
            this.textBoxOutputDirectory.Size = new System.Drawing.Size(100, 20);
            this.textBoxOutputDirectory.TabIndex = 1;
            // 
            // buttonBrowseDirectory
            // 
            this.buttonBrowseDirectory.Location = new System.Drawing.Point(213, 8);
            this.buttonBrowseDirectory.Name = "buttonBrowseDirectory";
            this.buttonBrowseDirectory.Size = new System.Drawing.Size(48, 23);
            this.buttonBrowseDirectory.TabIndex = 2;
            this.buttonBrowseDirectory.Text = "...";
            this.buttonBrowseDirectory.UseVisualStyleBackColor = true;
            this.buttonBrowseDirectory.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Forme chemin     :";
            // 
            // textBoxSavePathScheme
            // 
            this.textBoxSavePathScheme.Location = new System.Drawing.Point(103, 44);
            this.textBoxSavePathScheme.Name = "textBoxSavePathScheme";
            this.textBoxSavePathScheme.Size = new System.Drawing.Size(100, 20);
            this.textBoxSavePathScheme.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "?";
            this.toolTip1.SetToolTip(this.label3, "%name%    : Nom du manga\r\n%chapter% : Numéro du chapitre\r\n%author%   : Auteur ");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Forme image       :";
            // 
            // textBoxFilenameScheme
            // 
            this.textBoxFilenameScheme.Location = new System.Drawing.Point(103, 76);
            this.textBoxFilenameScheme.Name = "textBoxFilenameScheme";
            this.textBoxFilenameScheme.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilenameScheme.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "?";
            this.toolTip1.SetToolTip(this.label5, "%name%    : Nom du manga\r\n%chapter% : Numéro de chapitre\r\n%page%      : Numéro de" +
        " page\r\n%author%   : Auteur\r\n");
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(60, 215);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Valider";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(202, 215);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Intervale de vérification :";
            // 
            // timeIntervalSelector
            // 
            this.timeIntervalSelector.Location = new System.Drawing.Point(141, 14);
            this.timeIntervalSelector.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.timeIntervalSelector.Name = "timeIntervalSelector";
            this.timeIntervalSelector.Size = new System.Drawing.Size(120, 20);
            this.timeIntervalSelector.TabIndex = 1;
            this.timeIntervalSelector.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            // 
            // checkBoxUseFileOutput
            // 
            this.checkBoxUseFileOutput.AutoSize = true;
            this.checkBoxUseFileOutput.Location = new System.Drawing.Point(6, 19);
            this.checkBoxUseFileOutput.Name = "checkBoxUseFileOutput";
            this.checkBoxUseFileOutput.Size = new System.Drawing.Size(57, 17);
            this.checkBoxUseFileOutput.TabIndex = 2;
            this.checkBoxUseFileOutput.Text = "Utiliser";
            this.checkBoxUseFileOutput.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBrowseOutput);
            this.groupBox1.Controls.Add(this.textBoxSaveOutput);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBoxUseFileOutput);
            this.groupBox1.Location = new System.Drawing.Point(9, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fichier de sortie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Chemin :";
            // 
            // textBoxSaveOutput
            // 
            this.textBoxSaveOutput.Enabled = false;
            this.textBoxSaveOutput.Location = new System.Drawing.Point(61, 40);
            this.textBoxSaveOutput.Name = "textBoxSaveOutput";
            this.textBoxSaveOutput.Size = new System.Drawing.Size(100, 20);
            this.textBoxSaveOutput.TabIndex = 4;
            // 
            // buttonBrowseOutput
            // 
            this.buttonBrowseOutput.Enabled = false;
            this.buttonBrowseOutput.Location = new System.Drawing.Point(177, 38);
            this.buttonBrowseOutput.Name = "buttonBrowseOutput";
            this.buttonBrowseOutput.Size = new System.Drawing.Size(46, 23);
            this.buttonBrowseOutput.TabIndex = 5;
            this.buttonBrowseOutput.Text = "...";
            this.buttonBrowseOutput.UseVisualStyleBackColor = true;
            this.buttonBrowseOutput.Click += new System.EventHandler(this.buttonBrowseOutput_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBoxUseWebInterface);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(294, 161);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Interface Web";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseWebInterface
            // 
            this.checkBoxUseWebInterface.AutoSize = true;
            this.checkBoxUseWebInterface.Enabled = false;
            this.checkBoxUseWebInterface.Location = new System.Drawing.Point(6, 25);
            this.checkBoxUseWebInterface.Name = "checkBoxUseWebInterface";
            this.checkBoxUseWebInterface.Size = new System.Drawing.Size(59, 17);
            this.checkBoxUseWebInterface.TabIndex = 0;
            this.checkBoxUseWebInterface.Text = "Activer";
            this.checkBoxUseWebInterface.UseVisualStyleBackColor = true;
            // 
            // PreferencesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 250);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Préférences";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeIntervalSelector)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonBrowseDirectory;
        private System.Windows.Forms.TextBox textBoxOutputDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSavePathScheme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFilenameScheme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBrowseOutput;
        private System.Windows.Forms.TextBox textBoxSaveOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxUseFileOutput;
        private System.Windows.Forms.NumericUpDown timeIntervalSelector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkBoxUseWebInterface;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}