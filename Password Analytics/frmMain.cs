using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Password_Analytics.Classes;

namespace Password_Analytics
{
    public partial class FrmMain : Form
    {

        public DataTable DtDgvCurrent { get; set; }
        private DataTable _dtPrimaryCsvData;
        private DataTable _dtDistinctCsvData;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnReadCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {

                InitialDirectory = @"C:\",
                Title = @"Browse CSV Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "CSV",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (TxtCsvFile.Text != null)
            {
                var strFilePath = TxtCsvFile.Text;
                openFileDialog1.InitialDirectory = strFilePath;
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtCsvFile.Text = openFileDialog1.FileName;
            }
        }

        private void BtnLoadCsv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCsvFile.Text))
            {

                string strPath = Path.GetExtension(TxtCsvFile.Text);
                if (strPath != ".csv")
                {
                    MessageBox.Show("Path does not contain a valid *.CSV file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if(File.Exists(TxtCsvFile.Text))
                    {
                    var output = Classes.CSVReader.ReadFile(TxtCsvFile.Text);
                    _dtPrimaryCsvData = ListToDatatable.ToDataTable(output);

                    DgvData.DataSource = _dtPrimaryCsvData;
                    DgvData.Columns[1].Visible = false;
                    DgvData.Columns[4].Visible = false;

                    CreateTree(_dtPrimaryCsvData);
                    }
                    else
                    {
                        MessageBox.Show("CSV Doesn't Exist.");
                    }
                   
                }
            }
        }

        private void CreateTree(DataTable dtSorted)
        {
            TvDistinct.Nodes.Clear();
            AddParentNodes(dtSorted);
            AddChildrenNodes(dtSorted);
        }


        private void AddChildrenNodes(DataTable dtCsvData)
        {
            try
            {
                WriteToLog("e", "Started adding Children Nodes");
           
            TreeNode[] treeNodes = null;
            foreach (var parentNode in TvDistinct.Nodes)
            {
                int count = 1;
                string strNodeName = "";
                for (int i = 0; i < dtCsvData.Rows.Count; i++)
                {
                    string strPass = dtCsvData.Rows[i]["Pass"].ToString();

                    strNodeName = parentNode.ToString();

                    strNodeName = strNodeName.Remove(0, 10);
                    if (strPass == strNodeName)
                    {
                        //get parent
                        treeNodes = TvDistinct.Nodes
                                    .Cast<TreeNode>()
                                    .Where(r => r.Text == strNodeName)
                                    .ToArray();
                        count++;
                        //add child to parent node
                        TvDistinct.Nodes[treeNodes[0].Index].Nodes.Add(dtCsvData.Rows[i]["uri"].ToString());

                        //add tooltip to child - NOT WORKING
                        //var url = TvDistinct.Nodes[treeNodes[0].Index].Nodes[0].Text;
                        //var Username = (dtCsvData.Rows[i]["user"].ToString());
                        //TvDistinct.Nodes[treeNodes[0].Index].Nodes[0].Tag = (dtCsvData.Rows[i]["user"].ToString());
                    }
                }
                TvDistinct.Nodes[treeNodes[0].Index].Text = string.Format("{0}-[{1}]", strNodeName, count - 1);

                count = 0;
                TvDistinct.Update();
            }
            WriteToLog("e", "Finished adding Children Nodes");
            }
            catch (Exception ex)
            {

                WriteToLog("e", ex.InnerException.ToString());
            }

        }

        private void AddParentNodes(DataTable dtCsvData)
        {
            try
            {
                WriteToLog("e", "Started adding Parent Nodes");
           
            _dtDistinctCsvData = dtCsvData.DefaultView.ToTable(true, "pass");

            //Add all parent nodes
            for (int i = 0; i < _dtDistinctCsvData.Rows.Count; i++)
            {
                string strParentNode = _dtDistinctCsvData.Rows[i]["pass"].ToString();
                var treeNode = new TreeNode(strParentNode);
                TvDistinct.Nodes.Add(treeNode);
            }

            WriteToLog("e", "Finished adding Parent Nodes");
            }
            catch (Exception ex)
            {

                WriteToLog("e", ex.InnerException.ToString());
            }
        }


        private DataTable dtFilteredView;
        private DataView dvDataView;
        private void TxtSearchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtCsvFile.Text))
                {
                    //filter dt bound to dgv
                    string RowFilter = string.Format("pass LIKE '%{0}%' OR uri LIKE '%{0}%' OR user LIKE '%{0}%'", TxtSearchBox.Text);
                    dtFilteredView = ((DataTable)DgvData.DataSource);
                    dtFilteredView.DefaultView.RowFilter = RowFilter;

                    DgvData.Refresh();

                    //take snap shot of current filter
                    dvDataView = new DataView(dtFilteredView);
                    dvDataView.RowFilter = RowFilter;

                }
            }
            catch (Exception)
            {
                //Do Nothing
            }

        }

        private void BtnChromeLoadCSV_Click(object sender, EventArgs e)
        {
            try
            {
                WriteToLog("e", "Started Loading CSV");

                const string cmdArgs = @"chromecsv ""%LOCALAPPDATA%\Google\Chrome\User Data""";

                using (Process cmd = new Process())
                {
                    var strWorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    cmd.StartInfo.WorkingDirectory = strWorkingDirectory;

                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();

                    cmd.StandardInput.WriteLine(cmdArgs);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    cmd.WaitForExit();
                     MessageBox.Show(cmd.StandardOutput.ReadToEnd());

                    TxtCsvFile.Text = Path.Combine(strWorkingDirectory, "passwords.csv");

                    WriteToLog("e", "Finished Loading CSV");
                }
            }
            catch (Exception ex)
            {

                WriteToLog("e", ex.InnerException.ToString());
            }
        }

        /// <summary>
        /// Ref:https://support.microsoft.com/en-gb/kb/322634
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TvDistinct_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            // Get the node at the current mouse pointer location.
            TreeNode theNode = this.TvDistinct.GetNodeAt(e.X, e.Y);

            // Set a ToolTip only if the mouse pointer is actually paused on a node.
            if ((theNode != null))
            {
                // Verify that the tag property is not "null".
                if (theNode.Tag != null)
                {
                    // Change the ToolTip only if the pointer moved to a new node.
                    if (theNode.Tag.ToString() != toolTip1.GetToolTip(this.TvDistinct))
                    {
                        toolTip1.SetToolTip(this.TvDistinct, theNode.Tag.ToString());
                    }
                }
                else
                {
                    toolTip1.SetToolTip(this.TvDistinct, "");
                }
            }
            else     // Pointer is not over a node so clear the ToolTip.
            {
                toolTip1.SetToolTip(this.TvDistinct, "");
            }
        }



        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            TxtSearchBox.Clear();
        }

        private void TvDistinct_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node.Parent != null)
            {
                TxtSearchBox.Text = e.Node.Text;
            }

        }


        private void DgvData_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = DgvData.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    ContextMenu m = new ContextMenu();
                    MenuItem miMenuItem = new MenuItem("Open in Browser");
                    miMenuItem.Click += new EventHandler(miMenuItem_Click);
                    m.MenuItems.Add(miMenuItem);

                    m.Show(DgvData, new Point(e.X, e.Y));

                }


            }

        }

        private void miMenuItem_Click(object sender, EventArgs e)
        {
            int index = DgvData.Rows.IndexOf(DgvData.CurrentRow as DataGridViewRow);
            var url = dvDataView[index][0].ToString();
            Process.Start(url);

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            //CreateLogFiles();
            WriteToLog("p", "Program Started");
        }

        /// <summary>
        /// Checks if Log files has been created, if not create them.
        /// </summary>
        //private void CreateLogFiles()
        //{
        //    List<String> lstLogFiles = new List<string> { "Error.txt", "Action.txt" };

        //    foreach (string Log in lstLogFiles)
        //    {
        //        if (!File.Exists(Log))
        //        {
        //         string strFile = string.Format("{0}\\{1}",Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),Log) ;

        //         File.Create(strFile);
        //            MessageBox.Show(strFile);
        //        }
        //    }

        //}

        public static void WriteToLog(string strLogType, string strText)
        {
            string strLogFile = string.Empty;
            switch (strLogType)
            {
                case "e":
                    strLogFile = "Error.txt";
                    break;
                case "p":
                    strLogFile = "Action.txt";
                    break;
            }

            string strFile = string.Format("{0}\\{1}",
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), strLogFile);

            StringBuilder sbText = new StringBuilder();
            sbText.AppendLine().AppendFormat("{0} - {1}", DateTime.UtcNow, strFile);
            using (StreamWriter sw = new StreamWriter(strFile, true))
            {
                sw.Write(sbText);
                sw.Close();
            }


        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            _dtPrimaryCsvData.Clear();
            _dtDistinctCsvData.Clear();
            TvDistinct.Nodes.Clear();
            
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            WriteToLog("p", "Program Closed");
        }


    }
}
