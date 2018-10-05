namespace RosterCSV
{
    partial class Form1
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
            this.btnGenerateCSV = new System.Windows.Forms.Button();
            this.txtBrowseSourceSheet = new System.Windows.Forms.TextBox();
            this.txtBrowseDestinationSheet = new System.Windows.Forms.TextBox();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.openFileDialog_Source = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog_Destination = new System.Windows.Forms.FolderBrowserDialog();
            this.txtCSVFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSheetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateCSV
            // 
            this.btnGenerateCSV.Location = new System.Drawing.Point(161, 200);
            this.btnGenerateCSV.Name = "btnGenerateCSV";
            this.btnGenerateCSV.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateCSV.TabIndex = 0;
            this.btnGenerateCSV.Text = "Generate";
            this.btnGenerateCSV.UseVisualStyleBackColor = true;
            this.btnGenerateCSV.Click += new System.EventHandler(this.btnGenerateCSV_Click);
            // 
            // txtBrowseSourceSheet
            // 
            this.txtBrowseSourceSheet.Location = new System.Drawing.Point(161, 49);
            this.txtBrowseSourceSheet.Name = "txtBrowseSourceSheet";
            this.txtBrowseSourceSheet.Size = new System.Drawing.Size(372, 20);
            this.txtBrowseSourceSheet.TabIndex = 1;
            // 
            // txtBrowseDestinationSheet
            // 
            this.txtBrowseDestinationSheet.Location = new System.Drawing.Point(161, 89);
            this.txtBrowseDestinationSheet.Name = "txtBrowseDestinationSheet";
            this.txtBrowseDestinationSheet.Size = new System.Drawing.Size(372, 20);
            this.txtBrowseDestinationSheet.TabIndex = 2;
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Location = new System.Drawing.Point(22, 88);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(138, 23);
            this.btnBrowseDestination.TabIndex = 3;
            this.btnBrowseDestination.Text = "Destination CSV file path";
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(22, 48);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(138, 23);
            this.btnBrowseSource.TabIndex = 4;
            this.btnBrowseSource.Text = "Source Sheet";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog_Source
            // 
            this.openFileDialog_Source.FileName = "openFileDialogSource";
            // 
            // txtCSVFileName
            // 
            this.txtCSVFileName.Location = new System.Drawing.Point(161, 162);
            this.txtCSVFileName.Name = "txtCSVFileName";
            this.txtCSVFileName.Size = new System.Drawing.Size(185, 20);
            this.txtCSVFileName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CSV File Name";
            // 
            // txtSheetName
            // 
            this.txtSheetName.Location = new System.Drawing.Point(161, 127);
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.Size = new System.Drawing.Size(185, 20);
            this.txtSheetName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sheet Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // timeSettingsToolStripMenuItem
            // 
            this.timeSettingsToolStripMenuItem.Name = "timeSettingsToolStripMenuItem";
            this.timeSettingsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.timeSettingsToolStripMenuItem.Text = "Shift Settings";
            this.timeSettingsToolStripMenuItem.Click += new System.EventHandler(this.timeSettingsToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSheetName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCSVFileName);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.btnBrowseDestination);
            this.Controls.Add(this.txtBrowseDestinationSheet);
            this.Controls.Add(this.txtBrowseSourceSheet);
            this.Controls.Add(this.btnGenerateCSV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate CSV file";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateCSV;
        private System.Windows.Forms.TextBox txtBrowseSourceSheet;
        private System.Windows.Forms.TextBox txtBrowseDestinationSheet;
        private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Source;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Destination;
        private System.Windows.Forms.TextBox txtCSVFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSheetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeSettingsToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

