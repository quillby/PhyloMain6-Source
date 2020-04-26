using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace PhyloMain
{
    public partial class MafftFF : Form
    {
        private string aprog;
        private string tprog;
        private string vprog;
        private string newtree = "";
        private string alignfile = "";

        SynchronizationContext originalContext = SynchronizationContext.Current;
        List<ProcessStartInfo> processes = new List<ProcessStartInfo>();

        public MafftFF()
        {
            InitializeComponent();
            btnRun.Enabled = false;
            switch (PhyloMain.node)
            {
                case "Node31":
                    aprog = PhyloMain.mafft;
                    tprog = PhyloMain.fasttree;
                    lblChoice.Text = "MAFFT - FastTree - FigTree";
                    break;
                case "Node32":
                    aprog = PhyloMain.mafft;
                    tprog = PhyloMain.iqtree;
                    lblChoice.Text = "MAFFT - IQtree - FigTree";
                    break;
                case "Node33":
                    aprog = PhyloMain.muscle;
                    tprog = PhyloMain.fasttree;
                    lblChoice.Text = "Muscle - FastTree - FigTree";
                    break;
                case "Node34":
                    aprog = PhyloMain.muscle;
                    tprog = PhyloMain.iqtree;
                    lblChoice.Text = "Muscle - IQtree - FigTree";
                    break;
            }
            vprog = PhyloMain.figtree;
        }

        private void BtnDirectoryPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtDirectoryPath.Text;
            DialogResult drResult = folderBrowserDialog1.ShowDialog();
            if (drResult == DialogResult.OK)
                txtDirectoryPath.Text = folderBrowserDialog1.SelectedPath;
        }

        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //Setting ProgressBar Maximum Value  
            progressBar1.Maximum = Directory.GetFiles(Dir, "*.*", SearchOption.AllDirectories).Length + Directory.GetDirectories(Dir, "**", SearchOption.AllDirectories).Length;
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
                UpdateProgress();
            }
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.fas");
            progressBar1.Maximum = Files.Length;
            // Loop through them to see files  
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
                UpdateProgress();
            }
        }

        private void UpdateProgress()
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                progressBar1.CreateGraphics().DrawString(percent.ToString() + "%", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));
                Application.DoEvents();
            }
        }

        private void TreeView1_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the node at the current mouse pointer location.  
            TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);

            // Set a ToolTip only if the mouse pointer is actually paused on a node.  
            if (theNode != null && theNode.Tag != null)
            {
                // Change the ToolTip only if the pointer moved to a new node.  
                if (theNode.Tag.ToString() != this.toolTip1.GetToolTip(this.treeView1))
                    this.toolTip1.SetToolTip(this.treeView1, theNode.Tag.ToString());
            }
            else     // Pointer is not over a node so clear the ToolTip.  
            {
                this.toolTip1.SetToolTip(this.treeView1, "");
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = treeView1.SelectedNode.Text;
        }

        private void TreeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var node = (TreeNode)e.Item;
            if (node.Level > 0)
            {
                DoDragDrop(e.Item.ToString(), DragDropEffects.Copy);
            }           
        }

        private void TextBox1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(string))) e.Effect = DragDropEffects.Copy;
        }

        private void TextBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                textBox1.Text = (string)e.Data.GetData(typeof(System.String));
                textBox1.Text = textBox1.Text.Substring(10);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            btnRun.Enabled = textBox1.Text != "" ? true : false;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            List<ProcessStartInfo> processes = new List<ProcessStartInfo>();
            string tree = "";
            picFtree.Visible = false;
            picView.Visible = false;
            picAlign.Visible = true;
            string fasta = txtDirectoryPath.Text + "\\" + textBox1.Text;
            string[] temp = textBox1.Text.Split('.');
            string align = txtDirectoryPath.Text + "\\" + temp[0] + ".afa";
            string options = "";
            if (PhyloMain.node == "Node31" || PhyloMain.node == "Node32")
            {
                options = " --localpair --adjustdirection --maxiterate 1000 --reorder \"" + fasta + "\" > \"" + align + "\"";
            }
            if (PhyloMain.node == "Node33" || PhyloMain.node == "Node34")
            {
                options = " -in \"" + fasta + "\" -out \"" + align + "\" -maxiters 16";
            }
            ProcessStartInfo process = new ProcessStartInfo();
            process.FileName = aprog;
            process.Arguments = options;
            process.UseShellExecute = true;
            process.RedirectStandardOutput = false;
            if (!chkCommand.Checked)
            {
                process.WindowStyle = ProcessWindowStyle.Hidden;
            }
            else
            {
                process.WindowStyle = ProcessWindowStyle.Normal;
            }            
            processes.Add(process);

            picFtree.Visible = true;
            string fastprog = PhyloMain.IfRequired(tprog);
            if (PhyloMain.node == "Node31" || PhyloMain.node == "Node33")
            {                
                tree = txtDirectoryPath.Text + "\\" + temp[0] + ".tre";
                options = " -gamma -gtr -nt \"" + align + "\" > \"" + tree + "\"";
                ProcessStartInfo process1 = new ProcessStartInfo();
                process1.FileName = "cmd.exe ";
                process1.Arguments = "/C " + fastprog + " " + options;
                process1.UseShellExecute = true;
                process1.RedirectStandardOutput = false;
                if (!chkCommand.Checked)
                {
                    process1.WindowStyle = ProcessWindowStyle.Hidden;
                }
                else
                {
                    process1.WindowStyle = ProcessWindowStyle.Normal;
                }
                processes.Add(process1);
            }
            else
            {
                if (PhyloMain.node == "Node32" || PhyloMain.node == "Node34")
                {
                    tree = txtDirectoryPath.Text + "\\" + temp[0] + "_IQ";
                    options = " -s " + "\"" + align + "\"" + " -redo -nt AUTO -nm 1000 -m MFP+MERGE -abayes -alrt 1000 -bb 1000 -pre " + "\"" + tree + "\"";
                    ProcessStartInfo process1 = new ProcessStartInfo();
                    process1.FileName = fastprog;
                    process1.Arguments = options;
                    process1.UseShellExecute = false;
                    process1.RedirectStandardOutput = true;
                    if (!chkCommand.Checked)
                    {
                        process1.WindowStyle = ProcessWindowStyle.Hidden;
                    }
                    else
                    {
                        process1.WindowStyle = ProcessWindowStyle.Normal;
                    }
                    processes.Add(process1);
                }
            }            

            picView.Visible = true;
            string file = "";
            if (PhyloMain.node == "Node31" || PhyloMain.node == "Node33")
            {
                file = PhyloMain.IfRequired(tree);
            }
            if (PhyloMain.node == "Node32" || PhyloMain.node == "Node34")
            {
                file = PhyloMain.IfRequired(tree + ".treefile");
            }
            string view = PhyloMain.IfRequired(vprog);
            ProcessStartInfo process2 = new ProcessStartInfo();
            process2.FileName = view;
            process2.Arguments = file;
            process2.UseShellExecute = false;
            process2.RedirectStandardOutput = false;
            if (!chkCommand.Checked)
            {
                process2.WindowStyle = ProcessWindowStyle.Hidden;
            }
            else
            {
                process2.WindowStyle = ProcessWindowStyle.Normal;
            }
            processes.Add(process2);

            Thread th = new Thread(() =>
              {
                  ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { lblRunning.Visible = true; }, null); });
                  ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnRun.Enabled = false; }, null); });
                  for (int i = 0; i < processes.Count; i++)
                  {
                      try
                      {
                          using (Process exeProcess = Process.Start(processes[i]))
                          {
                              exeProcess.WaitForExit();
                          }
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show("Error: " + ex.Message, "End of execution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      }
                      ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { lblRunning.Visible = false; }, null); });
                      ThreadPool.QueueUserWorkItem(delegate { originalContext.Post(delegate { btnRun.Enabled = false; }, null); });
                  }
              });
            th.Start();
            picAlign.Visible = false;
            picFtree.Visible = false;
            picView.Visible = false;
            textBox1.Clear();
        }

        private void TxtDirectoryPath_TextChanged(object sender, EventArgs e)
        {
            if (txtDirectoryPath.Text != "")
            {
                // Setting Inital Value of Progress Bar  
                progressBar1.Value = 0;
                // Clear All Nodes if Already Exists  
                treeView1.Nodes.Clear();
                toolTip1.ShowAlways = true;
                if (txtDirectoryPath.Text != "" && Directory.Exists(txtDirectoryPath.Text))
                {
                    LoadDirectory(txtDirectoryPath.Text);
                    treeView1.ExpandAll();
                }                    
                else
                    MessageBox.Show("Select Directory!!");
            }
        }

        private void BtnSaveCreatedAlignment_Click(object sender, EventArgs e)
        {
            SaveFileDialog alignment = new SaveFileDialog()
            {
                FileName="alignment.afa",
                Filter="(*.afa)|*.afa"
            };
            alignment.ShowDialog();
            if (alignment.FileName != "")
            {
                alignfile = alignment.FileName;
                File.Copy(txtDirectoryPath.Text + "\\a5678.fas", alignfile, true);
            }
            else
            {
                alignfile = txtDirectoryPath.Text + "\\a5678.fas";
            }
        }

        private void BtnSaveCreatedTree_Click(object sender, EventArgs e)
        {
            if (PhyloMain.node == "Node31")
            {
                SaveFileDialog treename = new SaveFileDialog()
                {
                    FileName = "tree.tre",
                    Filter = "(*.tre)|*.tre"
                };
                treename.ShowDialog();
                if (treename.FileName != "")
                {
                    newtree = treename.FileName;
                    File.Copy(txtDirectoryPath.Text + "\\t5678.tre", newtree, true);
                }
                else
                {
                    newtree = txtDirectoryPath.Text + "\\t5678.tre";
                }
            }
            if (PhyloMain.node == "Node32")
            {
                SaveFileDialog treename = new SaveFileDialog()
                {
                    FileName = "t5678_IQ"
                };
                treename.ShowDialog();
                if (treename.FileName != "")
                {
                    newtree = treename.FileName;
                    //File.Copy(txtDirectoryPath.Text + "\\t5678_IQ", newtree, true);
                }
                else
                {
                    newtree = txtDirectoryPath.Text + "\\t5678_IQ";
                }
            }           
        }

        private void BtnDirectoryPath_MouseHover(object sender, EventArgs e)
        {
            btnDirectoryPath.BorderStyle = BorderStyle.Fixed3D;
        }

        private void BtnDirectoryPath_MouseLeave(object sender, EventArgs e)
        {
            btnDirectoryPath.BorderStyle = BorderStyle.None;
        }
    }
}
