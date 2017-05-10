namespace Password_Analytics
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnReadCSV = new MetroFramework.Controls.MetroButton();
            this.TxtCsvFile = new MetroFramework.Controls.MetroTextBox();
            this.BtnLoadCsv = new MetroFramework.Controls.MetroButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DgvData = new MetroFramework.Controls.MetroGrid();
            this.TvDistinct = new System.Windows.Forms.TreeView();
            this.TxtSearchBox = new MetroFramework.Controls.MetroTextBox();
            this.BtnChromeLoadCSV = new MetroFramework.Controls.MetroButton();
            this.BtnClearSearch = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnReadCSV
            // 
            this.BtnReadCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReadCSV.Location = new System.Drawing.Point(749, 27);
            this.BtnReadCSV.Name = "BtnReadCSV";
            this.BtnReadCSV.Size = new System.Drawing.Size(75, 23);
            this.BtnReadCSV.TabIndex = 1;
            this.BtnReadCSV.Text = "Browse";
            this.BtnReadCSV.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnReadCSV.UseSelectable = true;
            this.BtnReadCSV.Click += new System.EventHandler(this.BtnReadCSV_Click);
            // 
            // TxtCsvFile
            // 
            this.TxtCsvFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtCsvFile.CustomButton.Image = null;
            this.TxtCsvFile.CustomButton.Location = new System.Drawing.Point(434, 1);
            this.TxtCsvFile.CustomButton.Name = "";
            this.TxtCsvFile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtCsvFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCsvFile.CustomButton.TabIndex = 1;
            this.TxtCsvFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCsvFile.CustomButton.UseSelectable = true;
            this.TxtCsvFile.CustomButton.Visible = false;
            this.TxtCsvFile.Lines = new string[0];
            this.TxtCsvFile.Location = new System.Drawing.Point(287, 27);
            this.TxtCsvFile.MaxLength = 32767;
            this.TxtCsvFile.Name = "TxtCsvFile";
            this.TxtCsvFile.PasswordChar = '\0';
            this.TxtCsvFile.PromptText = "Load or Browse CSV file before Reading CSV";
            this.TxtCsvFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCsvFile.SelectedText = "";
            this.TxtCsvFile.SelectionLength = 0;
            this.TxtCsvFile.SelectionStart = 0;
            this.TxtCsvFile.ShortcutsEnabled = true;
            this.TxtCsvFile.Size = new System.Drawing.Size(456, 23);
            this.TxtCsvFile.TabIndex = 2;
            this.TxtCsvFile.UseSelectable = true;
            this.TxtCsvFile.WaterMark = "Load or Browse CSV file before Reading CSV";
            this.TxtCsvFile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCsvFile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnLoadCsv
            // 
            this.BtnLoadCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadCsv.Location = new System.Drawing.Point(716, 56);
            this.BtnLoadCsv.Name = "BtnLoadCsv";
            this.BtnLoadCsv.Size = new System.Drawing.Size(108, 23);
            this.BtnLoadCsv.TabIndex = 3;
            this.BtnLoadCsv.Text = "Read CSV";
            this.BtnLoadCsv.UseSelectable = true;
            this.BtnLoadCsv.Click += new System.EventHandler(this.BtnLoadCsv_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(11, 106);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DgvData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TvDistinct);
            this.splitContainer1.Size = new System.Drawing.Size(813, 403);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 7;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToResizeRows = false;
            this.DgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvData.EnableHeadersVisualStyles = false;
            this.DgvData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvData.Location = new System.Drawing.Point(0, 0);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(377, 403);
            this.DgvData.TabIndex = 1;
            this.DgvData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvData_MouseClick);
            // 
            // TvDistinct
            // 
            this.TvDistinct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvDistinct.Location = new System.Drawing.Point(0, 0);
            this.TvDistinct.Name = "TvDistinct";
            this.TvDistinct.Size = new System.Drawing.Size(432, 403);
            this.TvDistinct.TabIndex = 6;
            this.TvDistinct.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvDistinct_AfterSelect);
            this.TvDistinct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TvDistinct_MouseMove);
            // 
            // TxtSearchBox
            // 
            // 
            // 
            // 
            this.TxtSearchBox.CustomButton.Image = null;
            this.TxtSearchBox.CustomButton.Location = new System.Drawing.Point(596, 1);
            this.TxtSearchBox.CustomButton.Name = "";
            this.TxtSearchBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtSearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearchBox.CustomButton.TabIndex = 1;
            this.TxtSearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearchBox.CustomButton.UseSelectable = true;
            this.TxtSearchBox.CustomButton.Visible = false;
            this.TxtSearchBox.Lines = new string[0];
            this.TxtSearchBox.Location = new System.Drawing.Point(11, 56);
            this.TxtSearchBox.MaxLength = 32767;
            this.TxtSearchBox.Name = "TxtSearchBox";
            this.TxtSearchBox.PasswordChar = '\0';
            this.TxtSearchBox.PromptText = "Search";
            this.TxtSearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearchBox.SelectedText = "";
            this.TxtSearchBox.SelectionLength = 0;
            this.TxtSearchBox.SelectionStart = 0;
            this.TxtSearchBox.ShortcutsEnabled = true;
            this.TxtSearchBox.Size = new System.Drawing.Size(618, 23);
            this.TxtSearchBox.TabIndex = 8;
            this.TxtSearchBox.UseSelectable = true;
            this.TxtSearchBox.WaterMark = "Search";
            this.TxtSearchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearchBox.TextChanged += new System.EventHandler(this.TxtSearchBox_TextChanged);
            // 
            // BtnChromeLoadCSV
            // 
            this.BtnChromeLoadCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnChromeLoadCSV.Location = new System.Drawing.Point(12, 27);
            this.BtnChromeLoadCSV.Name = "BtnChromeLoadCSV";
            this.BtnChromeLoadCSV.Size = new System.Drawing.Size(269, 23);
            this.BtnChromeLoadCSV.TabIndex = 9;
            this.BtnChromeLoadCSV.Text = "Load from chrome";
            this.BtnChromeLoadCSV.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnChromeLoadCSV.UseSelectable = true;
            this.BtnChromeLoadCSV.Click += new System.EventHandler(this.BtnChromeLoadCSV_Click);
            // 
            // BtnClearSearch
            // 
            this.BtnClearSearch.Location = new System.Drawing.Point(635, 56);
            this.BtnClearSearch.Name = "BtnClearSearch";
            this.BtnClearSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnClearSearch.TabIndex = 10;
            this.BtnClearSearch.Text = "Clear Search";
            this.BtnClearSearch.UseSelectable = true;
            this.BtnClearSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.ExitToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorLogToolStripMenuItem,
            this.processLogToolStripMenuItem});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // errorLogToolStripMenuItem
            // 
            this.errorLogToolStripMenuItem.Name = "errorLogToolStripMenuItem";
            this.errorLogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.errorLogToolStripMenuItem.Text = "Error Log";
            // 
            // processLogToolStripMenuItem
            // 
            this.processLogToolStripMenuItem.Name = "processLogToolStripMenuItem";
            this.processLogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.processLogToolStripMenuItem.Text = "Process Log";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 521);
            this.Controls.Add(this.BtnClearSearch);
            this.Controls.Add(this.BtnChromeLoadCSV);
            this.Controls.Add(this.TxtSearchBox);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.BtnLoadCsv);
            this.Controls.Add(this.TxtCsvFile);
            this.Controls.Add(this.BtnReadCSV);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Chrome Password Analytics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnReadCSV;
        private MetroFramework.Controls.MetroTextBox TxtCsvFile;
        private MetroFramework.Controls.MetroButton BtnLoadCsv;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TvDistinct;
        private MetroFramework.Controls.MetroGrid DgvData;
        private MetroFramework.Controls.MetroTextBox TxtSearchBox;
        private MetroFramework.Controls.MetroButton BtnChromeLoadCSV;
        private MetroFramework.Controls.MetroButton BtnClearSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processLogToolStripMenuItem;
    }
}

